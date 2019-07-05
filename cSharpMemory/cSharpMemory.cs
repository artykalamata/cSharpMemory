using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMemory
{
    public class cSharpMemory
    {
        Process process;
        IntPtr processHandle;

        public cSharpMemory(Process process)
        {
            this.process = process;
            this.processHandle = Windows.NativeFunctions.OpenProcess(Windows.ProcessAccessFlags.All, false, process.Id);
        }

    }
}
