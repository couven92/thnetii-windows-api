﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApiNative.ErrorHandling
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum FORMAT_MESSAGE_FLAGS : int
    {
        FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100,
        FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
        FORMAT_MESSAGE_FROM_STRING = 0x00000400,
        FORMAT_MESSAGE_FROM_HMODULE = 0x00000800,
        FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
        FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}