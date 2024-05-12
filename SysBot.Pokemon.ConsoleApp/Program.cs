using PKHeX.Core;
using SysBot.Base;
using SysBot.Pokemon.Z3;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SysBot.Pokemon.ConsoleApp;

public static class Program
{
    private const string ConfigPath = "config.json";

    private static void Main(string[] args)
    {
        Console.WriteLine("Starten...");
        if (args.Length > 1)
            Console.WriteLine("Dieses Programm unterstützt keine Befehlszeilenargumente.");

        if (!File.Exists(ConfigPath))
        {
            ExitNoConfig();
            return;
        }

        try
        {
            var lines = File.ReadAllText(ConfigPath);
            var cfg = JsonSerializer.Deserialize(lines, ProgramConfigContext.Default.ProgramConfig) ?? new ProgramConfig();
            PokeTradeBotSWSH.SeedChecker = new Z3SeedSearchHandler<PK8>();
            BotContainer.RunBots(cfg);
        }
        catch (Exception)
        {
            Console.WriteLine("Bots können mit der gespeicherten Konfigurationsdatei nicht gestartet werden. Bitte kopieren Sie Ihre Konfiguration aus dem WinForms-Projekt oder löschen Sie sie und konfigurieren Sie neu.");
            Console.ReadKey();
        }
    }

    private static void ExitNoConfig()
    {
        var bot = new PokeBotState { Connection = new SwitchConnectionConfig { IP = "192.168.0.1", Port = 6000 }, InitialRoutine = PokeRoutineType.FlexTrade };
        var cfg = new ProgramConfig { Bots = [bot] };
        var created = JsonSerializer.Serialize(cfg, ProgramConfigContext.Default.ProgramConfig);
        File.WriteAllText(ConfigPath, created);
        Console.WriteLine("Es wurde eine neue Konfigurationsdatei erstellt, da im Programmpfad keine gefunden wurde. Bitte konfigurieren Sie diese und starten Sie das Programm neu.");
        Console.WriteLine("Es wird empfohlen, diese Konfigurationsdatei möglichst mit dem GUI-Projekt zu konfigurieren, da dies bei der korrekten Zuweisung von Einstellungen hilft.");
        Console.WriteLine("Drücken Sie eine beliebige Taste zum Beenden.");
        Console.ReadKey();
    }
}

[JsonSerializable(typeof(ProgramConfig))]
[JsonSourceGenerationOptions(WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
public sealed partial class ProgramConfigContext : JsonSerializerContext;

public static class BotContainer
{
    private static IPokeBotRunner? Environment;
    private static bool IsRunning => Environment != null;
    private static bool IsStopping;

    public static void RunBots(ProgramConfig prog)
    {
        IPokeBotRunner env = GetRunner(prog);
        foreach (var bot in prog.Bots)
        {
            bot.Initialize();
            if (!AddBot(env, bot, prog.Mode))
                Console.WriteLine($"Bot konnte nicht hinzugefügt werden: {bot}");
        }

        LogUtil.Forwarders.Add(ConsoleForwarder.Instance);
        env.StartAll();
        Console.WriteLine($"Alle Bots gestartet (Count: {prog.Bots.Length}).");

        Environment = env;
        WaitForExit();
    }

    private static void WaitForExit()
    {
        var msg = Console.IsInputRedirected
            ? "Läuft ohne Konsoleneingabe. Wartet auf Exit-Signal."
            : "Drücken Sie CTRL-C, um die Ausführung zu beenden. Sie können dieses Fenster auch minimieren.";
        Console.WriteLine(msg);

        AppDomain.CurrentDomain.ProcessExit += (_, _) =>
        {
            if (IsStopping)
                return; // Already stopping, don't double stop.
            // Try as best we can to shut down.
            StopProcess("Prozessabbruch erkannt. Stoppe alle Bots.");
        };
        Console.CancelKeyPress += (_, e) =>
        {
            if (IsStopping)
                return; // Already stopping, don't double stop.
            e.Cancel = true; // Gracefully exit after stopping all bots.
            StopProcess("Abbruchtaste erfasst. Alle Bots werden gestoppt.");
        };

        while (IsRunning)
            System.Threading.Thread.Sleep(1000);
    }

    private static void StopProcess(string message)
    {
        IsStopping = true;
        Console.WriteLine(message);
        Environment?.StopAll();
        Environment = null;
    }

    private static IPokeBotRunner GetRunner(ProgramConfig prog) => prog.Mode switch
    {
        ProgramMode.SWSH => new PokeBotRunnerImpl<PK8>(prog.Hub, new BotFactory8SWSH()),
        ProgramMode.BDSP => new PokeBotRunnerImpl<PB8>(prog.Hub, new BotFactory8BS()),
        ProgramMode.LA   => new PokeBotRunnerImpl<PA8>(prog.Hub, new BotFactory8LA()),
        ProgramMode.SV   => new PokeBotRunnerImpl<PK9>(prog.Hub, new BotFactory9SV()),
        _ => throw new IndexOutOfRangeException("Nicht unterstützter Modus."),
    };

    private static bool AddBot(IPokeBotRunner env, PokeBotState cfg, ProgramMode mode)
    {
        if (!cfg.IsValid())
        {
            Console.WriteLine($"Die Konfiguration von {cfg} ist nicht gültig.");
            return false;
        }

        PokeRoutineExecutorBase newBot;
        try
        {
            newBot = env.CreateBotFromConfig(cfg);
        }
        catch
        {
            Console.WriteLine($"Der aktuelle Modus ({mode}) unterstützt diese Art von Bot nicht ({cfg.CurrentRoutineType}).");
            return false;
        }
        try
        {
            env.Add(newBot);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

        Console.WriteLine($"Hinzugefügt: {cfg}: {cfg.InitialRoutine}");
        return true;
    }
}
