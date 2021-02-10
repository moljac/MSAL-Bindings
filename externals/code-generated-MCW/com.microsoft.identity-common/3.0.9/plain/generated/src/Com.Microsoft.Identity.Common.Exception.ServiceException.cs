using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/ServiceException", DoNotGenerateAcw=true)]
	public partial class ServiceException : global::Com.Microsoft.Identity.Common.Exception.BaseException {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='ACCESS_DENIED']"
		[Register ("ACCESS_DENIED")]
		public const string AccessDenied = (string) "access_denied";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='DEFAULT_STATUS_CODE']"
		[Register ("DEFAULT_STATUS_CODE")]
		public const int DefaultStatusCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='INVALID_INSTANCE']"
		[Register ("INVALID_INSTANCE")]
		public const string InvalidInstance = (string) "invalid_instance";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='INVALID_REQUEST']"
		[Register ("INVALID_REQUEST")]
		public const string InvalidRequest = (string) "invalid_request";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='INVALID_SCOPE']"
		[Register ("INVALID_SCOPE")]
		public const string InvalidScope = (string) "invalid_scope";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='OPENID_PROVIDER_CONFIGURATION_FAILED_TO_LOAD']"
		[Register ("OPENID_PROVIDER_CONFIGURATION_FAILED_TO_LOAD")]
		public const string OpenidProviderConfigurationFailedToLoad = (string) "failed_to_load_openid_configuration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='REQUEST_TIMEOUT']"
		[Register ("REQUEST_TIMEOUT")]
		public const string RequestTimeout = (string) "request_timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='SERVICE_NOT_AVAILABLE']"
		[Register ("SERVICE_NOT_AVAILABLE")]
		public const string ServiceNotAvailable = (string) "service_not_available";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='UNAUTHORIZED_CLIENT']"
		[Register ("UNAUTHORIZED_CLIENT")]
		public const string UnauthorizedClient = (string) "unauthorized_client";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const string UnknownError = (string) "unknown_error";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/field[@name='sName']"
		[Register ("sName")]
		public static string SName {
			get {
				const string __id = "sName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/ServiceException", typeof (ServiceException));

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

		protected ServiceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/constructor[@name='ServiceException' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", "")]
		public unsafe ServiceException (string errorCode, string errorMessage, int httpStatusCode, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/constructor[@name='ServiceException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe ServiceException (string errorCode, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getHttpResponseBody;
#pragma warning disable 0169
		static Delegate GetGetHttpResponseBodyHandler ()
		{
			if (cb_getHttpResponseBody == null)
				cb_getHttpResponseBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpResponseBody);
			return cb_getHttpResponseBody;
		}

		static IntPtr n_GetHttpResponseBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.HttpResponseBody);
		}
#pragma warning restore 0169

		static Delegate cb_setHttpResponseBody_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetHttpResponseBody_Ljava_util_HashMap_Handler ()
		{
			if (cb_setHttpResponseBody_Ljava_util_HashMap_ == null)
				cb_setHttpResponseBody_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHttpResponseBody_Ljava_util_HashMap_);
			return cb_setHttpResponseBody_Ljava_util_HashMap_;
		}

		static void n_SetHttpResponseBody_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseBody)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseBody = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_responseBody, JniHandleOwnership.DoNotTransfer);
			__this.HttpResponseBody = responseBody;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> HttpResponseBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='getHttpResponseBody' and count(parameter)=0]"
			[Register ("getHttpResponseBody", "()Ljava/util/HashMap;", "GetGetHttpResponseBodyHandler")]
			get {
				const string __id = "getHttpResponseBody.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='setHttpResponseBody' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setHttpResponseBody", "(Ljava/util/HashMap;)V", "GetSetHttpResponseBody_Ljava_util_HashMap_Handler")]
			set {
				const string __id = "setHttpResponseBody.(Ljava/util/HashMap;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getHttpResponseHeaders;
#pragma warning disable 0169
		static Delegate GetGetHttpResponseHeadersHandler ()
		{
			if (cb_getHttpResponseHeaders == null)
				cb_getHttpResponseHeaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpResponseHeaders);
			return cb_getHttpResponseHeaders;
		}

		static IntPtr n_GetHttpResponseHeaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.HttpResponseHeaders);
		}
#pragma warning restore 0169

		static Delegate cb_setHttpResponseHeaders_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetHttpResponseHeaders_Ljava_util_HashMap_Handler ()
		{
			if (cb_setHttpResponseHeaders_Ljava_util_HashMap_ == null)
				cb_setHttpResponseHeaders_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHttpResponseHeaders_Ljava_util_HashMap_);
			return cb_setHttpResponseHeaders_Ljava_util_HashMap_;
		}

		static void n_SetHttpResponseHeaders_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseHeaders)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_responseHeaders, JniHandleOwnership.DoNotTransfer);
			__this.HttpResponseHeaders = responseHeaders;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HttpResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='getHttpResponseHeaders' and count(parameter)=0]"
			[Register ("getHttpResponseHeaders", "()Ljava/util/HashMap;", "GetGetHttpResponseHeadersHandler")]
			get {
				const string __id = "getHttpResponseHeaders.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='setHttpResponseHeaders' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
			[Register ("setHttpResponseHeaders", "(Ljava/util/HashMap;)V", "GetSetHttpResponseHeaders_Ljava_util_HashMap_Handler")]
			set {
				const string __id = "setHttpResponseHeaders.(Ljava/util/HashMap;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpStatusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int HttpStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='getHttpStatusCode' and count(parameter)=0]"
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

		static Delegate cb_getOAuthSubErrorCode;
#pragma warning disable 0169
		static Delegate GetGetOAuthSubErrorCodeHandler ()
		{
			if (cb_getOAuthSubErrorCode == null)
				cb_getOAuthSubErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOAuthSubErrorCode);
			return cb_getOAuthSubErrorCode;
		}

		static IntPtr n_GetOAuthSubErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OAuthSubErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string OAuthSubErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='getOAuthSubErrorCode' and count(parameter)=0]"
			[Register ("getOAuthSubErrorCode", "()Ljava/lang/String;", "GetGetOAuthSubErrorCodeHandler")]
			get {
				const string __id = "getOAuthSubErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setOauthSubErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOauthSubErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_setOauthSubErrorCode_Ljava_lang_String_ == null)
				cb_setOauthSubErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOauthSubErrorCode_Ljava_lang_String_);
			return cb_setOauthSubErrorCode_Ljava_lang_String_;
		}

		static void n_SetOauthSubErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subErrorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subErrorCode = JNIEnv.GetString (native_subErrorCode, JniHandleOwnership.DoNotTransfer);
			__this.SetOauthSubErrorCode (subErrorCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ServiceException']/method[@name='setOauthSubErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOauthSubErrorCode", "(Ljava/lang/String;)V", "GetSetOauthSubErrorCode_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOauthSubErrorCode (string subErrorCode)
		{
			const string __id = "setOauthSubErrorCode.(Ljava/lang/String;)V";
			IntPtr native_subErrorCode = JNIEnv.NewString (subErrorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_subErrorCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_subErrorCode);
			}
		}

	}
}
