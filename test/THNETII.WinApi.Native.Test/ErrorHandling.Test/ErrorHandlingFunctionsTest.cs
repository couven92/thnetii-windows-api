﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;
using THNETII.WindowsProtocols.WindowsErrorCodes;
using Xunit;

using static THNETII.WindowsProtocols.WindowsErrorCodes.Constants.WinErrorConstants;

namespace THNETII.WinApiNative.ErrorHandling.Test
{
    public static class ErrorHandlingFunctionsTest
    {
        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void Beep()
        {
            var beep = ErrorHandlingFunctions.Beep(750, 300);
            if (beep)
                Assert.Equal(ERROR_SUCCESS, Marshal.GetLastWin32Error());
            else
            {
                Win32ErrorCode win32Error = Marshal.GetLastWin32Error();

                throw new Win32Exception(win32Error.Value);
            }
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void CaptureStackBackTrace()
        {
            var frames = ErrorHandlingFunctions.CaptureStackBackTrace(
                FramesToSkip: 0, FramesToCapture: ushort.MaxValue,
                out var stackTracePtr, out var _
                );

            if (stackTracePtr.IsNull())
                return;

            var stackTrace = stackTracePtr.AsSpan(frames);

            for (int i = 0; i < stackTrace.Length; i++)
            {
                var stackFrame = stackTrace[i];
                Assert.NotEqual(IntPtr.Zero, stackFrame);
            }
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void FlashWindow()
        {
            IntPtr hWnd = default;
#pragma warning disable PC001 // API not supported on all platforms
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                hWnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
#pragma warning restore PC001 // API not supported on all platforms
            var state = ErrorHandlingFunctions.FlashWindow(hWnd, true);
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void FlashWindowEx()
        {
            IntPtr hWnd = default;
#pragma warning disable PC001 // API not supported on all platforms
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                hWnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
#pragma warning restore PC001 // API not supported on all platforms
            var state = ErrorHandlingFunctions.FlashWindowEx(new FLASHWINFO
            {
                cbSize = SizeOf<FLASHWINFO>.Bytes,
                hwnd = hWnd,
                dwFlags = FLASHWFLAGS.FLASHW_ALL,
                uCount = 100
            });
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void GetErrorMode()
        {
            var mode = ErrorHandlingFunctions.GetErrorMode();
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void GetThreadErrorMode()
        {
            var mode = ErrorHandlingFunctions.GetThreadErrorMode();
        }
    }
}