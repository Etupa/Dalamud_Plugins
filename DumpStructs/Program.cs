using System;
using System.Linq;
class Program {
    static void Main() {
        var uiState = typeof(FFXIVClientStructs.FFXIV.Client.Game.UI.UIState);
        Console.WriteLine("UIState Methods:");
        foreach (var m in uiState.GetMethods().Where(m => m.Name.Contains("Emote") || m.Name.Contains("Unlock"))) {
            Console.WriteLine("  " + m.Name);
        }
        
        var ps = typeof(FFXIVClientStructs.FFXIV.Client.Game.UI.PlayerState);
        Console.WriteLine("PlayerState Methods:");
        foreach (var m in ps.GetMethods().Where(m => m.Name.Contains("Emote") || m.Name.Contains("Unlock"))) {
            Console.WriteLine("  " + m.Name);
        }
    }
}
