using System;
using System.Diagnostics;
using cSharpMemory.Windows;
using cSharpMemory.Mem;

namespace cSharpMemory
{
    public class cSharpMemoryMain
    {
        Process process;
        IntPtr processHandle;

        public cSharpMemoryMain(Process process)
        {
            this.process = process;
            this.processHandle = NativeFunctions.OpenProcess(ProcessAccessFlags.All, false, process.Id);
        }

        public Int16 ReadInt16(IntPtr address)
        {
            return BitConverter.ToInt16(Memory.ReadBytes(processHandle, address, sizeof(Int16)), 0);
        }

        public Int32 ReadInt32(IntPtr address)
        {
            return BitConverter.ToInt32(Memory.ReadBytes(processHandle, address, sizeof(Int32)), 0);
        }

        public Int64 ReadInt64(IntPtr address)
        {
            return BitConverter.ToInt64(Memory.ReadBytes(processHandle, address, sizeof(Int64)), 0);
        }

        public Single ReadSingle(IntPtr address)
        {
            return BitConverter.ToSingle(Memory.ReadBytes(processHandle, address, sizeof(Single)), 0);
        }

        public Double ReadDouble(IntPtr address)
        {
            return BitConverter.ToDouble(Memory.ReadBytes(processHandle, address, sizeof(Double)), 0);
        }

        public Boolean ReadBoolean(IntPtr address)
        {
            return BitConverter.ToBoolean(Memory.ReadBytes(processHandle, address, sizeof(Boolean)), 0);
        }

        public Char ReadChar(IntPtr address)
        {
            return BitConverter.ToChar(Memory.ReadBytes(processHandle, address, sizeof(Char)), 0);
        }

        public String ReadUnicode(IntPtr address, int length)
        {
            return System.Text.Encoding.Unicode.GetString(Memory.ReadBytes(processHandle, address, sizeof(Char) * length), 0, length);
        }

        public String ReadASCII(IntPtr address, int length)
        {
            return System.Text.Encoding.ASCII.GetString(Memory.ReadBytes(processHandle, address, sizeof(Char) * length), 0, length);
        }

        public byte ReadByte(IntPtr address)
        {
            return Memory.ReadBytes(processHandle, address, 1)[0];
        }

        public byte[] ReadByteArray(IntPtr address, int size)
        {
            return Memory.ReadBytes(processHandle, address, size);
        }
    }
}
