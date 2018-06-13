// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1028:EnumStorageShouldBeInt32", Scope = "type", Target = "Microsoft.Wim.CopyFileProgressAction")]
[assembly: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Microsoft.Wim.WimgApi+CopyProgressRoutine")]
[assembly: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Microsoft.Wim.WimgApi+FILETIME")]
[assembly: SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Microsoft.Wim.WimgApi+FILETIME.#dwHighDateTime")]
[assembly: SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Microsoft.Wim.WimgApi+FILETIME.#dwLowDateTime")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#CaptureImage(Microsoft.Wim.WimHandle,System.String,Microsoft.Wim.WimCaptureImageOptions)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#DeleteImage(Microsoft.Wim.WimHandle,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#LoadImage(Microsoft.Wim.WimHandle,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#MountImage(Microsoft.Wim.WimHandle,System.String,Microsoft.Wim.WimMountImageOptions)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#MountImage(System.String,System.String,System.Int32,System.String)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#RemountImage(System.String)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#SetBootImage(Microsoft.Wim.WimHandle,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#SetImageInformation(Microsoft.Wim.WimHandle,System.Xml.XPath.IXPathNavigable)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#SetReferenceFile(Microsoft.Wim.WimHandle,System.String,Microsoft.Wim.WimSetReferenceMode,Microsoft.Wim.WimSetReferenceOptions)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#SetTemporaryPath(Microsoft.Wim.WimHandle,System.String)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#SplitFile(Microsoft.Wim.WimHandle,System.String,System.Int64)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Wim.WimgApi.#UnmountImage(System.String,System.String,System.Int32,System.Boolean)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dw", Scope = "member", Target = "Microsoft.Wim.WimgApi+FILETIME.#dwHighDateTime")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dw", Scope = "member", Target = "Microsoft.Wim.WimgApi+FILETIME.#dwLowDateTime")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dw", Scope = "type", Target = "Microsoft.Wim.WimgApi+CopyProgressRoutine")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "h", Scope = "type", Target = "Microsoft.Wim.WimgApi+CopyProgressRoutine")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lp", Scope = "type", Target = "Microsoft.Wim.WimgApi+CopyProgressRoutine")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FILETIME", Scope = "type", Target = "Microsoft.Wim.WimgApi+FILETIME")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Stream", Scope = "type", Target = "Microsoft.Wim.WimgApi+CopyProgressRoutine")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Total", Scope = "type", Target = "Microsoft.Wim.WimgApi+CopyProgressRoutine")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Scope = "type", Target = "Microsoft.Wim.WimgApi+FILETIME")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMApplyImage(Microsoft.Wim.WimHandle,System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMCaptureImage(Microsoft.Wim.WimHandle,System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMCloseHandle(System.IntPtr)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMCommitImageHandle(Microsoft.Wim.WimHandle,System.UInt32,Microsoft.Wim.WimHandle&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMCopyFile(System.String,System.String,Microsoft.Win32.Kernel32+CopyProgressRoutine,System.IntPtr,System.Boolean&,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMCreateFile(System.String,System.UInt32,System.UInt32,System.UInt32,System.UInt32,Microsoft.Wim.WimCreationResult&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMDeleteImage(Microsoft.Wim.WimHandle,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMDeleteImageMounts(System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMExportImage(Microsoft.Wim.WimHandle,Microsoft.Wim.WimHandle,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMExtractImagePath(Microsoft.Wim.WimHandle,System.String,System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetAttributes(Microsoft.Wim.WimHandle,System.IntPtr,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetImageCount(Microsoft.Wim.WimHandle)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetImageInformation(Microsoft.Wim.WimHandle,System.IntPtr&,System.UInt32&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetMessageCallbackCount(Microsoft.Wim.WimHandle)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetMountedImageHandle(System.String,System.UInt32,Microsoft.Wim.WimHandle&,Microsoft.Wim.WimHandle&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetMountedImageInfo(Microsoft.Wim.WimMountedImageInfoLevels,System.UInt32&,System.IntPtr,System.UInt32,System.UInt32&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMGetMountedImageInfoFromHandle(Microsoft.Wim.WimHandle,Microsoft.Wim.WimMountedImageInfoLevels,System.IntPtr,System.UInt32,System.UInt32&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMLoadImage(Microsoft.Wim.WimHandle,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMMountImage(System.String,System.String,System.UInt32,System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMMountImageHandle(Microsoft.Wim.WimHandle,System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMRegisterLogFile(System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMRegisterMessageCallback(Microsoft.Wim.WimHandle,Microsoft.Wim.WimgApi+WIMMessageCallback,System.IntPtr)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMRemountImage(System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMSetBootImage(Microsoft.Wim.WimHandle,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMSetImageInformation(Microsoft.Wim.WimHandle,System.IntPtr,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMSetReferenceFile(Microsoft.Wim.WimHandle,System.String,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMSetTemporaryPath(Microsoft.Wim.WimHandle,System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMSplitFile(Microsoft.Wim.WimHandle,System.String,System.Int64&,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMUnmountImage(System.String,System.String,System.UInt32,System.Boolean)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMUnmountImageHandle(Microsoft.Wim.WimHandle,System.UInt32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMUnregisterLogFile(System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "Microsoft.Wim.WimgApi+NativeMethods.#WIMUnregisterMessageCallback(Microsoft.Wim.WimHandle,Microsoft.Wim.WimgApi+WIMMessageCallback)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Microsoft.Wim.WimgApi.#DeleteImage(Microsoft.Wim.WimHandle,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Microsoft.Wim.WimgApi.#LoadImage(Microsoft.Wim.WimHandle,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Microsoft.Wim.WimgApi.#MountImage(System.String,System.String,System.Int32,System.String)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Microsoft.Wim.WimgApi.#SetBootImage(Microsoft.Wim.WimHandle,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Microsoft.Wim.WimgApi.#UnmountImage(System.String,System.String,System.Int32,System.Boolean)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", Justification = "Reviewed")]