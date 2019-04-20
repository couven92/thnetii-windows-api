﻿using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15596
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_WMI_IDLE_STATES
    {
        public int Type;
        public int Count;
        /// <summary>current idle state</summary>
        public int TargetState;
        /// <summary>previous idle state</summary>
        public int OldState;
        public long TargetProcessors;
        #region public PPM_WMI_IDLE_STATE[] State = new PPM_WMI_IDLE_STATE[Count];
        internal PPM_WMI_IDLE_STATE StateField;
        public Span<PPM_WMI_IDLE_STATE> State => SpanOverRef.GetSpan(ref StateField, Count);
        #endregion
    }
}