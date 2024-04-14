using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SysBot.Base;

/// <summary>
/// Logic wrapper to handle logging (via NLog).
/// </summary>
public static class LogUtil
{
    static LogUtil()
    {
        if (!LogConfig.LoggingEnabled)
            return;

        var config = new LoggingConfiguration();
        Directory.CreateDirectory("logs");
        var WorkingDirectory = Path.GetDirectoryName(Environment.ProcessPath)!;
        var logfile = new FileTarget("logfile")
        {
            FileName = Path.Combine(WorkingDirectory, "logs", "SysBotLog.txt"),
            ConcurrentWrites = true,

            ArchiveEvery = FileArchivePeriod.Day,
            ArchiveNumbering = ArchiveNumberingMode.Date,
            ArchiveFileName = Path.Combine(WorkingDirectory, "logs", "SysBotLog.{#}.txt"),
            ArchiveDateFormat = "yyyy-MM-dd",
            ArchiveAboveSize = 104857600, // 100MB (never)
            MaxArchiveFiles = LogConfig.MaxArchiveFiles,
            Encoding = Encoding.Unicode,
            WriteBom = true,
        };
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
        LogManager.Configuration = config;
    }

    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    public static void LogText(string message) => Logger.Log(LogLevel.Info, message);

    // hook in here if you want to forward the message elsewhere???
    public static readonly List<ILogForwarder> Forwarders = [];

    public static DateTime LastLogged { get; private set; } = DateTime.Now;

    public static void LogError(string message, string identity)
    {
        Logger.Log(LogLevel.Error, $"{identity} {message}");
        Log(message, identity);
    }

    public static void LogInfo(string message, string identity)
    {
        Logger.Log(LogLevel.Info, $"{identity} {message}");
        Log(message, identity);
    }

    private static void Log(string message, string identity)
    {
        foreach (var fwd in Forwarders)
        {
            try
            {
                fwd.Forward(message, identity);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, $"Fehler beim Weiterleiten des Protokolls von {identity} - {message}");
                Logger.Log(LogLevel.Error, ex);
            }
        }

        LastLogged = DateTime.Now;
    }

    public static void LogSafe(Exception exception, string identity)
    {
        Logger.Log(LogLevel.Error, $"Ausnahme von {identity}:");
        Logger.Log(LogLevel.Error, exception);

        var err = exception.InnerException;
        while (err is not null)
        {
            Logger.Log(LogLevel.Error, err);
            err = err.InnerException;
        }
    }
}
