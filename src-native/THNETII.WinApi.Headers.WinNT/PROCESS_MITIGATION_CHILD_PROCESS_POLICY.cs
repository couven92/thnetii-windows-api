﻿using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11686
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_CHILD_PROCESS_POLICY
    {
        private static readonly Bitfield32 bfNoChildProcessCreation = Bitfield32.LowBits(1);
        private static readonly Bitfield32 bfAuditNoChildProcessCreation = Bitfield32.SelectBits(1, 1);
        private static readonly Bitfield32 bfAllowSecureProcessCreation = Bitfield32.SelectBits(2, 1);

        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(29));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool NoChildProcessCreation
        {
            get => bfNoChildProcessCreation.ReadBool(dwFlags);
            set => bfNoChildProcessCreation.WriteBool(ref dwFlags, value);
        }

        public bool AuditNoChildProcessCreation
        {
            get => bfAuditNoChildProcessCreation.ReadBool(dwFlags);
            set => bfAuditNoChildProcessCreation.WriteBool(ref dwFlags, value);
        }

        public bool AllowSecureProcessCreation
        {
            get => bfAllowSecureProcessCreation.ReadBool(dwFlags);
            set => bfAllowSecureProcessCreation.WriteBool(ref dwFlags, value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}
