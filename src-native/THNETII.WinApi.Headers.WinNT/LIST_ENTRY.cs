﻿using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Doubly linked list structure.  Can be used as either a list head, or
    /// as link words.
    /// </summary>
    /// <remarks>
    /// All list items must be aligned on a <see cref="F:THNETII.WinApi.WinNT.WinNTConstants.MEMORY_ALLOCATION_ALIGNMENT"/> boundary. Unaligned items can cause unpredictable results. See <em>_aligned_malloc</em>.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_list_entry">_LIST_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="InitializeSListHead"/>
    /// <seealso cref="InterlockedFlushSList"/>
    /// <seealso cref="InterlockedPopEntrySList"/>
    /// <seealso cref="InterlockedPushEntrySList"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct LIST_ENTRY
    {
        public LIST_ENTRY* Flink;
        public LIST_ENTRY* Blink;
    }
}
