using System;
using System.Diagnostics;
using cSharpMemoryLib.Windows;
using cSharpMemoryLib.Memory;
using System.Text;

namespace cSharpMemoryLib
{
    public class cSharpMemory
    {
        Process process;
        IntPtr processHandle;

        public cSharpMemory(Process process)
        {
            this.process = process;
            this.processHandle = NativeFunctions.OpenProcess(ProcessAccessFlags.All, false, process.Id);
        }

        #region Read

        public byte ReadByte(IntPtr address)
        {
            return RWM.ReadBytes(processHandle, address, 1)[0];
        }

        public byte[] ReadByteArray(IntPtr address, int size)
        {
            return RWM.ReadBytes(processHandle, address, size);
        }

        public Int16 ReadInt16(IntPtr address)
        {
            return BitConverter.ToInt16(RWM.ReadBytes(processHandle, address, sizeof(Int16)), 0);
        }

        public Int32 ReadInt32(IntPtr address)
        {
            return BitConverter.ToInt32(RWM.ReadBytes(processHandle, address, sizeof(Int32)), 0);
        }

        public Int64 ReadInt64(IntPtr address)
        {
            return BitConverter.ToInt64(RWM.ReadBytes(processHandle, address, sizeof(Int64)), 0);
        }

        public Single ReadSingle(IntPtr address)
        {
            return BitConverter.ToSingle(RWM.ReadBytes(processHandle, address, sizeof(Single)), 0);
        }

        public Double ReadDouble(IntPtr address)
        {
            return BitConverter.ToDouble(RWM.ReadBytes(processHandle, address, sizeof(Double)), 0);
        }

        public Boolean ReadBoolean(IntPtr address)
        {
            return BitConverter.ToBoolean(RWM.ReadBytes(processHandle, address, sizeof(Boolean)), 0);
        }

        public Char ReadChar(IntPtr address)
        {
            return BitConverter.ToChar(RWM.ReadBytes(processHandle, address, sizeof(Char)), 0);
        }

        public String ReadASCII(IntPtr address, int length)
        {
            return System.Text.Encoding.ASCII.GetString(RWM.ReadBytes(processHandle, address, sizeof(Char) * length), 0, length);
        }

        #endregion

        #region Write

        public void WriteByte(IntPtr address, byte value)
        {
            RWM.WriteBytes(processHandle, address, new byte[] { value });
        }

        public void WriteByteArray(IntPtr address, byte[] array)
        {
            RWM.WriteBytes(processHandle, address, array);
        }

        public void WriteInt16(IntPtr address, Int16 value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteInt32(IntPtr address, Int32 value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteInt64(IntPtr address, Int64 value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteSingle(IntPtr address, Single value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteDouble(IntPtr address, Double value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteBoolean(IntPtr address, Boolean value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteChar(IntPtr address, Char value)
        {
            RWM.WriteBytes(processHandle, address, BitConverter.GetBytes(value));
        }

        public void WriteASCII(IntPtr address, string value)
        {
            RWM.WriteBytes(processHandle, address, Encoding.ASCII.GetBytes(value));
        }

        #endregion
    }
}
