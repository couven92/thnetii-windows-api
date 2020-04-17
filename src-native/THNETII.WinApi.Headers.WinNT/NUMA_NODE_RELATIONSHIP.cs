﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12306
    /// <summary>
    /// Represents information about a NUMA node in a processor group. This structure is used with the <see cref="GetLogicalProcessorInformationEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-numa_node_relationship">NUMA_NODE_RELATIONSHIP structure</a></para>
    /// </remarks>
    /// <seealso cref="GROUP_AFFINITY"/>
    /// <seealso cref="GetLogicalProcessorInformationEx"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NUMA_NODE_RELATIONSHIP
    {
        /// <summary>The number of the NUMA node.</summary>
        public int NodeNumber;
        /// <summary>This member is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved[20];
        /// <summary>A <see cref="GROUP_AFFINITY"/> structure that specifies a group number and processor affinity within the group.</summary>
        public GROUP_AFFINITY GroupMask;
    }
}
