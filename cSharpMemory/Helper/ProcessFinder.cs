using System;
using System.Diagnostics;
using System.Linq;

namespace cSharpMemoryLib.Helper
{
    public class ProcessFinder
    {
        public static Process GetProcessById(int processId)
        {
            return Process.GetProcessById(processId);
        }

        public static Process GetProcessByName(string processName)
        {
            return Process.GetProcessesByName(processName).First();
        }

    }
}
