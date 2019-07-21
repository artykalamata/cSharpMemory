using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpMemory;
using cSharpMemory.Helper;

namespace MemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var cSharpMem = new cSharpMemoryMain(ProcessFinder.GetProcessByName("portal_knights_x64"));
            IntPtr address = new IntPtr(0x17FC1B8CBE0);

            cSharpMem.WriteASCII(address, "Hello");
            Console.ReadLine();



        }
    }
}
