﻿using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_CASEIGNORE_LIST"/> structure is an ADSI representation of the <strong>Case Ignore List</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>A <strong>Case Ignore List</strong> attribute represents an ordered sequence of case insensitive strings.</para>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-_ads_caseignore_list">_ADS_CASEIGNORE_LIST structure</a></para>
    /// </remarks>
    /// <see cref="ADSVALUE"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_CASEIGNORE_LIST
    {
        /// <summary>
        /// Pointer to the next <see cref="ADS_CASEIGNORE_LIST"/> in the list of case-insensitive strings.
        /// </summary>
        public IntPtr pNext;

        /// <summary>
        /// A reference to the next ADS_CASEIGNORE_LIST in the list of case-insensitive strings.
        /// </summary>
        public ref ADS_CASEIGNORE_LIST Next =>
            ref pNext.AsRefStruct<ADS_CASEIGNORE_LIST>();

        /// <summary>
        /// Pointer to the null-terminated Unicode string value of the current entry of the list.
        /// </summary>
        public IntPtr pszString;

        /// <summary>
        /// Gets the span over the string value of the current entry of the list.
        /// </summary>
        public Span<char> String => pszString.AsZeroTerminatedUnicodeSpan();
    }
}