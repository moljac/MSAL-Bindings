using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse", DoNotGenerateAcw=true)]
	public partial class TokenErrorResponse : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse", typeof (TokenErrorResponse));

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

		protected TokenErrorResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/constructor[@name='TokenErrorResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenErrorResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		static Delegate cb_setError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetError_Ljava_lang_String_Handler ()
		{
			if (cb_setError_Ljava_lang_String_ == null)
				cb_setError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetError_Ljava_lang_String_);
			return cb_setError_Ljava_lang_String_;
		}

		static void n_SetError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = JNIEnv.GetString (native_error, JniHandleOwnership.DoNotTransfer);
			__this.Error = error;
		}
#pragma warning restore 0169

		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setError", "(Ljava/lang/String;)V", "GetSetError_Ljava_lang_String_Handler")]
			set {
				const string __id = "setError.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getErrorDescription;
#pragma warning disable 0169
		static Delegate GetGetErrorDescriptionHandler ()
		{
			if (cb_getErrorDescription == null)
				cb_getErrorDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorDescription);
			return cb_getErrorDescription;
		}

		static IntPtr n_GetErrorDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorDescription_Ljava_lang_String_ == null)
				cb_setErrorDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetErrorDescription_Ljava_lang_String_);
			return cb_setErrorDescription_Ljava_lang_String_;
		}

		static void n_SetErrorDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorDescription)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorDescription = JNIEnv.GetString (native_errorDescription, JniHandleOwnership.DoNotTransfer);
			__this.ErrorDescription = errorDescription;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getErrorDescription' and count(parameter)=0]"
			[Register ("getErrorDescription", "()Ljava/lang/String;", "GetGetErrorDescriptionHandler")]
			get {
				const string __id = "getErrorDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setErrorDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorDescription", "(Ljava/lang/String;)V", "GetSetErrorDescription_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorDescription.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getErrorUri;
#pragma warning disable 0169
		static Delegate GetGetErrorUriHandler ()
		{
			if (cb_getErrorUri == null)
				cb_getErrorUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorUri);
			return cb_getErrorUri;
		}

		static IntPtr n_GetErrorUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorUri);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorUri_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorUri_Ljava_lang_String_ == null)
				cb_setErrorUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetErrorUri_Ljava_lang_String_);
			return cb_setErrorUri_Ljava_lang_String_;
		}

		static void n_SetErrorUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorUri = JNIEnv.GetString (native_errorUri, JniHandleOwnership.DoNotTransfer);
			__this.ErrorUri = errorUri;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getErrorUri' and count(parameter)=0]"
			[Register ("getErrorUri", "()Ljava/lang/String;", "GetGetErrorUriHandler")]
			get {
				const string __id = "getErrorUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setErrorUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorUri", "(Ljava/lang/String;)V", "GetSetErrorUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorUri.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseBody;
#pragma warning disable 0169
		static Delegate GetGetResponseBodyHandler ()
		{
			if (cb_getResponseBody == null)
				cb_getResponseBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseBody);
			return cb_getResponseBody;
		}

		static IntPtr n_GetResponseBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseBody);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseBody_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseBody_Ljava_lang_String_ == null)
				cb_setResponseBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseBody_Ljava_lang_String_);
			return cb_setResponseBody_Ljava_lang_String_;
		}

		static void n_SetResponseBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseBody)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseBody = JNIEnv.GetString (native_responseBody, JniHandleOwnership.DoNotTransfer);
			__this.ResponseBody = responseBody;
		}
#pragma warning restore 0169

		public virtual unsafe string ResponseBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getResponseBody' and count(parameter)=0]"
			[Register ("getResponseBody", "()Ljava/lang/String;", "GetGetResponseBodyHandler")]
			get {
				const string __id = "getResponseBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setResponseBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseBody", "(Ljava/lang/String;)V", "GetSetResponseBody_Ljava_lang_String_Handler")]
			set {
				const string __id = "setResponseBody.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseHeadersJson;
#pragma warning disable 0169
		static Delegate GetGetResponseHeadersJsonHandler ()
		{
			if (cb_getResponseHeadersJson == null)
				cb_getResponseHeadersJson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseHeadersJson);
			return cb_getResponseHeadersJson;
		}

		static IntPtr n_GetResponseHeadersJson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseHeadersJson);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseHeadersJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseHeadersJson_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseHeadersJson_Ljava_lang_String_ == null)
				cb_setResponseHeadersJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseHeadersJson_Ljava_lang_String_);
			return cb_setResponseHeadersJson_Ljava_lang_String_;
		}

		static void n_SetResponseHeadersJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseHeadersJson)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseHeadersJson = JNIEnv.GetString (native_responseHeadersJson, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeadersJson = responseHeadersJson;
		}
#pragma warning restore 0169

		public virtual unsafe string ResponseHeadersJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getResponseHeadersJson' and count(parameter)=0]"
			[Register ("getResponseHeadersJson", "()Ljava/lang/String;", "GetGetResponseHeadersJsonHandler")]
			get {
				const string __id = "getResponseHeadersJson.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setResponseHeadersJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseHeadersJson", "(Ljava/lang/String;)V", "GetSetResponseHeadersJson_Ljava_lang_String_Handler")]
			set {
				const string __id = "setResponseHeadersJson.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetStatusCode_IHandler ()
		{
			if (cb_setStatusCode_I == null)
				cb_setStatusCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStatusCode_I);
			return cb_setStatusCode_I;
		}

		static void n_SetStatusCode_I (IntPtr jnienv, IntPtr native__this, int statusCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusCode = statusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatusCode", "(I)V", "GetSetStatusCode_IHandler")]
			set {
				const string __id = "setStatusCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSubError;
#pragma warning disable 0169
		static Delegate GetGetSubErrorHandler ()
		{
			if (cb_getSubError == null)
				cb_getSubError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubError);
			return cb_getSubError;
		}

		static IntPtr n_GetSubError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubError);
		}
#pragma warning restore 0169

		static Delegate cb_setSubError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubError_Ljava_lang_String_Handler ()
		{
			if (cb_setSubError_Ljava_lang_String_ == null)
				cb_setSubError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubError_Ljava_lang_String_);
			return cb_setSubError_Ljava_lang_String_;
		}

		static void n_SetSubError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subError = JNIEnv.GetString (native_subError, JniHandleOwnership.DoNotTransfer);
			__this.SubError = subError;
		}
#pragma warning restore 0169

		public virtual unsafe string SubError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='getSubError' and count(parameter)=0]"
			[Register ("getSubError", "()Ljava/lang/String;", "GetGetSubErrorHandler")]
			get {
				const string __id = "getSubError.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenErrorResponse']/method[@name='setSubError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubError", "(Ljava/lang/String;)V", "GetSetSubError_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubError.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
