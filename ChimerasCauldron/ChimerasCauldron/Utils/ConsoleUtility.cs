using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChimerasCauldron.Utils
{
    internal static class ConsoleUtility
    {
        // This attribute tells .NET to import a function from kernel32.dll called AllocConsole
        // AllocConsole creates a new console window for the calling process with windows api
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        // Flag to see if there is a console open from our code
        private static bool consoleAllocated = false;

        // Custom Write Function
        public static void CWrite(string text)
        {
            if (!consoleAllocated)
            {
                AllocConsole();
                consoleAllocated = true;
            }
            Console.Write(text);
        }

        // Custom WriteLine Function
        public static void CWriteLine(string text)
        {
            if (!consoleAllocated)
            {
                AllocConsole();
                consoleAllocated = true;
            }
            Console.WriteLine(text);
        }
    }
}
