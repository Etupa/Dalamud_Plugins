using System;
using System.Reflection;
using System.Linq;

class Program {
    static void Main() {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\XIVLauncher\addon\Hooks\dev\FFXIVClientStructs.dll";
        if (!System.IO.File.Exists(path)) {
            Console.WriteLine("Not found: " + path);
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\XIVLauncher\addon\Hooks\FFXIVClientStructs.dll";
        }
        if (!System.IO.File.Exists(path)) {
            Console.WriteLine("Not found: " + path);
            return;
        }
        var asm = Assembly.LoadFrom(path);
        
        var uiState = asm.GetType("FFXIVClientStructs.FFXIV.Client.Game.UI.UIState");
        if (uiState != null) {
            Console.WriteLine("UIState Methods:");
            foreach (var m in uiState.GetMethods().Where(m => m.Name.Contains("Emote") || m.Name.Contains("Unlock"))) {
                Console.WriteLine("  " + m.Name);
            }
        }
        
        var ps = asm.GetType("FFXIVClientStructs.FFXIV.Client.Game.UI.PlayerState");
        if (ps != null) {
            Console.WriteLine("PlayerState Methods:");
            foreach (var m in ps.GetMethods().Where(m => m.Name.Contains("Emote") || m.Name.Contains("Unlock"))) {
                Console.WriteLine("  " + m.Name);
            }
        }
    }
}
