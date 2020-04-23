﻿namespace THNETII.WinApi.Native.MinWinBase
{
    /// <summary>
    /// Identifies the type of file information that <see cref="GetFileInformationByHandleEx"/> should retrieve or <see cref="SetFileInformationByHandle"/> should set.
    /// </summary>
    /// <remarks>
    /// As noted in the preceding section, some file information classes are valid only for use with <see cref="GetFileInformationByHandleEx"/>. Others are valid only for use with <see cref="SetFileInformationByHandle"/>. Where neither function is mentioned, the information class is valid with both functions.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ne-minwinbase-file_info_by_handle_class">FILE_INFO_BY_HANDLE_CLASS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="GetFileInformationByHandleEx"/>
    /// <seealso cref="SetFileInformationByHandle"/>
    public enum FILE_INFO_BY_HANDLE_CLASS
    {
        /// <summary>Minimal information for the file should be retrieved or set. Used for file handles. See <see cref="FILE_BASIC_INFO"/>.</summary>
        FileBasicInfo,
        /// <summary>Extended information for the file should be retrieved. Used for file handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_STANDARD_INFO"/>.</summary>
        FileStandardInfo,
        /// <summary>The file name should be retrieved. Used for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_NAME_INFO"/>.</summary>
        FileNameInfo,
        /// <summary>The file name should be changed. Used for file handles. Use only when calling <see cref="SetFileInformationByHandle"/>. See <see cref="FILE_RENAME_INFO"/>.</summary>
        FileRenameInfo,
        /// <summary>The file should be deleted. Used for any handles. Use only when calling <see cref="SetFileInformationByHandle"/>. See <see cref="FILE_DISPOSITION_INFO"/>.</summary>
        FileDispositionInfo,
        /// <summary>The file allocation information should be changed. Used for file handles. Use only when calling <see cref="SetFileInformationByHandle"/>. See <see cref="FILE_ALLOCATION_INFO"/>.</summary>
        FileAllocationInfo,
        /// <summary>The end of the file should be set. Use only when calling <see cref="SetFileInformationByHandle"/>. See <see cref="FILE_END_OF_FILE_INFO"/>.</summary>
        FileEndOfFileInfo,
        /// <summary>File stream information for the specified file should be retrieved. Used for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_STREAM_INFO"/>.</summary>
        FileStreamInfo,
        /// <summary>File compression information should be retrieved. Used for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_COMPRESSION_INFO"/>.</summary>
        FileCompressionInfo,
        /// <summary>File attribute information should be retrieved. Used for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_ATTRIBUTE_TAG_INFO"/>.</summary>
        FileAttributeTagInfo,
        /// <summary>Files in the specified directory should be retrieved. Used for directory handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. The number of files returned for each call to <see cref="GetFileInformationByHandleEx"/> depends on the size of the buffer that is passed to the function. Any subsequent calls to <see cref="GetFileInformationByHandleEx"/> on the same handle will resume the enumeration operation after the last file is returned. See <see cref="FILE_ID_BOTH_DIR_INFO"/>.</summary>
        FileIdBothDirectoryInfo,
        /// <summary>Identical to <see cref="FileIdBothDirectoryInfo"/>, but forces the enumeration operation to start again from the beginning. See <see cref="FILE_ID_BOTH_DIR_INFO"/>.</summary>
        FileIdBothDirectoryRestartInfo,
        /// <summary>Priority hint information should be set. Use only when calling <see cref="SetFileInformationByHandle"/>. See <see cref="FILE_IO_PRIORITY_HINT_INFO"/>.</summary>
        FileIoPriorityHintInfo,
        /// <summary>File remote protocol information should be retrieved. Use for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_REMOTE_PROTOCOL_INFO"/>.</summary>
        FileRemoteProtocolInfo,
        /// <summary>
        /// Files in the specified directory should be retrieved. Used for directory handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_FULL_DIR_INFO"/>.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileFullDirectoryInfo,
        /// <summary>
        /// Identical to <see cref="FileFullDirectoryInfo"/>, but forces the enumeration operation to start again from the beginning. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_FULL_DIR_INFO"/>. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileFullDirectoryRestartInfo,
        /// <summary>
        /// File storage information should be retrieved. Use for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_STORAGE_INFO"/>. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileStorageInfo,
        /// <summary>
        /// File alignment information should be retrieved. Use for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_ALIGNMENT_INFO"/>. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileAlignmentInfo,
        /// <summary>
        /// File information should be retrieved. Use for any handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_ID_INFO"/>. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileIdInfo,
        /// <summary>
        /// Files in the specified directory should be retrieved. Used for directory handles. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_ID_EXTD_DIR_INFO"/>.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileIdExtdDirectoryInfo,
        /// <summary>
        /// Identical to <see cref="FileIdExtdDirectoryInfo"/>, but forces the enumeration operation to start again from the beginning. Use only when calling <see cref="GetFileInformationByHandleEx"/>. See <see cref="FILE_ID_EXTD_DIR_INFO"/>.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported before Windows 8 and Windows Server 2012</para>
        /// </summary>
        FileIdExtdDirectoryRestartInfo,
        /// <summary/>
        FileDispositionInfoEx,
        /// <summary/>
        FileRenameInfoEx,
        /// <summary/>
        MaximumFileInfoByHandleClass
    }
}
