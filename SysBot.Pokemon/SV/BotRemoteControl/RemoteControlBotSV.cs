using SysBot.Base;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SysBot.Pokemon;

public class RemoteControlBotSV(PokeBotState Config) : PokeRoutineExecutor9SV(Config)
{
    public override async Task MainLoop(CancellationToken token)
    {
        try
        {
            Log("Identifiziere Trainerdaten der Host-Konsole.");
            await IdentifyTrainer(token).ConfigureAwait(false);

            Log("Starte main loop, warte dann auf Befehle.");
            Config.IterateNextRoutine();
            while (!token.IsCancellationRequested)
            {
                await Task.Delay(1_000, token).ConfigureAwait(false);
                ReportStatus();
            }
        }
        catch (Exception e)
        {
            Log(e.Message);
        }

        Log($"Ending {nameof(RemoteControlBotSV)} loop.");
        await HardStop().ConfigureAwait(false);
    }

    public override async Task HardStop()
    {
        await SetStick(SwitchStick.LEFT, 0, 0, 0_500, CancellationToken.None).ConfigureAwait(false); // reset
        await CleanExit(CancellationToken.None).ConfigureAwait(false);
    }

    private class DummyReset : IBotStateSettings
    {
        public bool ScreenOff => true;
    }
}
