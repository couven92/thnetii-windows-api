﻿using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_LIMIT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11710
    /// <summary>
    /// Contains basic and extended limit information for a job object.
    /// </summary>
    /// <remarks>
    /// <para>The system tracks the value of <see cref="PeakProcessMemoryUsed"/> and <see cref="PeakJobMemoryUsed"/> constantly. This allows you know the peak memory usage of each job. You can use this information to establish a memory limit using the <see cref="JOB_OBJECT_LIMIT_PROCESS_MEMORY"/> or <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/> value.</para>
    /// <para>Note that the job memory and process memory limits are very similar in operation, but they are independent. You could set a job-wide limit of 100 MB with a per-process limit of 10 MB. In this scenario, no single process could commit more than 10 MB, and the set of processes associated with a job could never exceed 100 MB.</para>
    /// <para>To register for notifications that a job has exceeded its peak memory limit while allowing processes to continue to commit memory, use the <see cref="SetInformationJobObject"/> function with the <see cref="JobObjectNotificationLimitInformation"/> information class.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_basic_limit_information">JOBOBJECT_BASIC_LIMIT_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/>
    /// <seealso cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
    {
        /// <summary>
        /// A <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure that contains basic limit information.
        /// </summary>
        public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;
        /// <summary>
        /// Reserved.
        /// </summary>
        public IO_COUNTERS IoInfo;
        /// <summary>
        /// If the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.LimitFlags"/> member of the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure specifies the <see cref="JOB_OBJECT_LIMIT_PROCESS_MEMORY"/> value, this member specifies the limit for the virtual memory that can be committed by a process. Otherwise, this member is ignored.
        /// </summary>
        public UIntPtr ProcessMemoryLimit;
        /// <summary>
        /// If the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.LimitFlags"/> member of the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure specifies the <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/> value, this member specifies the limit for the virtual memory that can be committed for the job. Otherwise, this member is ignored.
        /// </summary>
        public UIntPtr JobMemoryLimit;
        /// <summary>
        /// The peak memory used by any process ever associated with the job.
        /// </summary>
        public UIntPtr PeakProcessMemoryUsed;
        /// <summary>
        /// The peak memory usage of all processes currently associated with the job.
        /// </summary>
        public UIntPtr PeakJobMemoryUsed;
    }
}
