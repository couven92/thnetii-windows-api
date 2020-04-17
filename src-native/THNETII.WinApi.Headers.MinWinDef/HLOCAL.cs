﻿using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinDef
{
    /// <summary>
    /// A handle to a local memory block.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/winprog/windows-data-types#HLOCAL">Windows Data Types</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct HLOCAL
    {
        public HLOCAL(IntPtr ptr) => Pointer = ptr;

        public IntPtr Pointer { get; }
    }
}
