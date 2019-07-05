using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMemory.Memory
{
    class Memory
    {
        public static byte[] ReadBytes(IntPtr processHandle, IntPtr address, int size)
        {
            IntPtr bytesRead = IntPtr.Zero;
            byte[] buffer = new byte[size];
            if(Windows.NativeFunctions.ReadProcessMemory(processHandle, address, buffer, buffer.Length, out bytesRead) && size == bytesRead.ToInt64())
                return buffer;

            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }
}
