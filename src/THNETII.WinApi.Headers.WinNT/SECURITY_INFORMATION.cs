﻿using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum SECURITY_INFORMATION
    {
        OWNER_SECURITY_INFORMATION = WinNTConstants.OWNER_SECURITY_INFORMATION,
        GROUP_SECURITY_INFORMATION = WinNTConstants.GROUP_SECURITY_INFORMATION,
        DACL_SECURITY_INFORMATION = WinNTConstants.DACL_SECURITY_INFORMATION,
        SACL_SECURITY_INFORMATION = WinNTConstants.SACL_SECURITY_INFORMATION,
        LABEL_SECURITY_INFORMATION = WinNTConstants.LABEL_SECURITY_INFORMATION,
        ATTRIBUTE_SECURITY_INFORMATION = WinNTConstants.ATTRIBUTE_SECURITY_INFORMATION,
        SCOPE_SECURITY_INFORMATION = WinNTConstants.SCOPE_SECURITY_INFORMATION,
        PROCESS_TRUST_LABEL_SECURITY_INFORMATION = WinNTConstants.PROCESS_TRUST_LABEL_SECURITY_INFORMATION,
        ACCESS_FILTER_SECURITY_INFORMATION = WinNTConstants.ACCESS_FILTER_SECURITY_INFORMATION,
        BACKUP_SECURITY_INFORMATION = WinNTConstants.BACKUP_SECURITY_INFORMATION,

        PROTECTED_DACL_SECURITY_INFORMATION = WinNTConstants.PROTECTED_DACL_SECURITY_INFORMATION,
        PROTECTED_SACL_SECURITY_INFORMATION = WinNTConstants.PROTECTED_SACL_SECURITY_INFORMATION,
        UNPROTECTED_DACL_SECURITY_INFORMATION = WinNTConstants.UNPROTECTED_DACL_SECURITY_INFORMATION,
        UNPROTECTED_SACL_SECURITY_INFORMATION = WinNTConstants.UNPROTECTED_SACL_SECURITY_INFORMATION,
    }
}