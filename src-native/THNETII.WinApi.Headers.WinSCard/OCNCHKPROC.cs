using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinSCard
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 891
    /// <param name="hSCardContext">the card context passed in the parameter block</param>
    /// <param name="hCard">card handle</param>
    /// <param name="pvUserData">pointer to user data passed in the parameter block</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool OCNCHKPROC(
        [In] SCARDCONTEXT hSCardContext,
        [In] SCARDHANDLE hCard,
        [In] IntPtr pvUserData
        );

    [StructLayout(LayoutKind.Sequential)]
    public struct LPOCNCHKPROC : IFunctionPointer<OCNCHKPROC>
    {
        public IntPtr Pointer { get; }
    }
}
