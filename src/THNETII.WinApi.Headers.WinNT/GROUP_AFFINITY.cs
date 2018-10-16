﻿using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.WinNT
{
    //
    // Structure to represent a group-specific affinity, such as that of a
    // thread.  Specifies the group number and the affinity within that group.
    //

    /// <summary>
    /// Represents a processor group-specific affinity, such as the affinity of a thread.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_group_affinity">_GROUP_AFFINITY structure</a></para>
    /// </remarks>
    /// <seealso cref="CACHE_RELATIONSHIP"/>
    /// <seealso cref="NUMA_NODE_RELATIONSHIP"/>
    /// <seealso cref="PROCESSOR_RELATIONSHIP"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct GROUP_AFFINITY
    {
        /// <summary>
        /// A bitmap that specifies the affinity for zero or more processors within the specified group.
        /// </summary>
        [MarshalAs(UnmanagedType.SysUInt)]
        public UIntPtr Mask;
        /// <summary>The processor group number.</summary>
        public short Group;
        /// <summary>This member is reserved.</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        internal short[] Reserved;
    }
}