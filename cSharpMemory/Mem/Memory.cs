using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using cSharpMemory.Windows;

namespace cSharpMemory.Mem
{
    public class Memory
    {
        public static byte[] ReadBytes(IntPtr processHandle, IntPtr address, int size)
        {
            IntPtr bytesRead = IntPtr.Zero;
            byte[] buffer = new byte[size];
            if(NativeFunctions.ReadProcessMemory(processHandle, address, buffer, buffer.Length, out bytesRead) && size == bytesRead.ToInt64())
                return buffer;

            throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        public static void WriteBytes(IntPtr processHandle, IntPtr address, byte[] buffer)
        {
            IntPtr bytesWritten = IntPtr.Zero;
            if (NativeFunctions.WriteProcessMemory(processHandle, address, buffer, buffer.Length, out bytesWritten) && buffer.Length == bytesWritten.ToInt64())
                return;

            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }
}
