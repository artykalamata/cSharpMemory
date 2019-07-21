using System;
using cSharpMemoryLib;
using cSharpMemoryLib.Helper;

namespace MemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var cSharpMem = new cSharpMemory(ProcessFinder.GetProcessByName("portal_knights_x64"));
            IntPtr address = new IntPtr(0x17FC1B8CBE0);

            cSharpMem.WriteASCII(address, "Hello");
            Console.ReadLine();



        }
    }
}
