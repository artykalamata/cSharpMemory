using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMemory.Helper
{
    class ProcessFinder
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
