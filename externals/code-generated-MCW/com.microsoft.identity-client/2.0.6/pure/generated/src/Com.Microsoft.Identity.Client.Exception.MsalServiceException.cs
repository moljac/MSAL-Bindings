using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/exception/MsalServiceException", DoNotGenerateAcw=true)]
	public partial class MsalServiceException : global::Com.Microsoft.Identity.Client.Exception.MsalException {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='ACCESS_DENIED']"
		[Register ("ACCESS_DENIED")]
		public const string AccessDenied = (string) "access_denied";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='DEFAULT_STATUS_CODE']"
		[Register ("DEFAULT_STATUS_CODE")]
		public const int DefaultStatusCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='INVALID_INSTANCE']"
		[Register ("INVALID_INSTANCE")]
		public const string InvalidInstance = (string) "invalid_instance";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='INVALID_REQUEST']"
		[Register ("INVALID_REQUEST")]
		public const string InvalidRequest = (string) "invalid_request";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='INVALID_SCOPE']"
		[Register ("INVALID_SCOPE")]
		public const string InvalidScope = (string) "invalid_scope";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='REQUEST_TIMEOUT']"
		[Register ("REQUEST_TIMEOUT")]
		public const string RequestTimeout = (string) "request_timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='SERVICE_NOT_AVAILABLE']"
		[Register ("SERVICE_NOT_AVAILABLE")]
		public const string ServiceNotAvailable = (string) "service_not_available";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='UNAUTHORIZED_CLIENT']"
		[Register ("UNAUTHORIZED_CLIENT")]
		public const string UnauthorizedClient = (string) "unauthorized_client";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const string UnknownError = (string) "unknown_error";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/exception/MsalServiceException", typeof (MsalServiceException));

		internal static new IntPtr class_ref {
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

		protected MsalServiceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/constructor[@name='MsalServiceException' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", "")]
		public unsafe MsalServiceException (string errorCode, string errorMessage, int httpStatusCode, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue (httpStatusCode);
				__args [3] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/constructor[@name='MsalServiceException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MsalServiceException (string errorCode, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (throwable);
			}
		}

		static Delegate cb_getHttpStatusCode;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusCodeHandler ()
		{
			if (cb_getHttpStatusCode == null)
				cb_getHttpStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHttpStatusCode);
			return cb_getHttpStatusCode;
		}

		static int n_GetHttpStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpStatusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int HttpStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalServiceException']/method[@name='getHttpStatusCode' and count(parameter)=0]"
			[Register ("getHttpStatusCode", "()I", "GetGetHttpStatusCodeHandler")]
			get {
				const string __id = "getHttpStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
