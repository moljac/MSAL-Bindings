using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='DateUtilities']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/DateUtilities", DoNotGenerateAcw=true)]
	public sealed partial class DateUtilities : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='DateUtilities']/field[@name='LOCALE_CHANGE_LOCK']"
		[Register ("LOCALE_CHANGE_LOCK")]
		public static global::Java.Lang.Object LocaleChangeLock {
			get {
				const string __id = "LOCALE_CHANGE_LOCK.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/DateUtilities", typeof (DateUtilities));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal DateUtilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='DateUtilities']/method[@name='createCopy' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("createCopy", "(Ljava/util/Date;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date CreateCopy (global::Java.Util.Date date)
		{
			const string __id = "createCopy.(Ljava/util/Date;)Ljava/util/Date;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (date);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='DateUtilities']/method[@name='getExpiresOn' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getExpiresOn", "(J)J", "")]
		public static unsafe long GetExpiresOn (long expiresIn)
		{
			const string __id = "getExpiresOn.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expiresIn);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='DateUtilities']/method[@name='isLocaleCalendarNonGregorian' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("isLocaleCalendarNonGregorian", "(Ljava/util/Locale;)Z", "")]
		public static unsafe bool IsLocaleCalendarNonGregorian (global::Java.Util.Locale inputLocale)
		{
			const string __id = "isLocaleCalendarNonGregorian.(Ljava/util/Locale;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputLocale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputLocale).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (inputLocale);
			}
		}

	}
}
