using Content.Shared.Administration;
using Robust.Shared.Console;
using jerk.Some;

namespace jerk.command;

[AnyCommand]
public class ToggleCommand: IConsoleCommand
{
    public string Command => "toggle";
    public string Description => "";
    
    public string Help => "toggle";
    
    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        JerkCrash.tog = true;
    }
}