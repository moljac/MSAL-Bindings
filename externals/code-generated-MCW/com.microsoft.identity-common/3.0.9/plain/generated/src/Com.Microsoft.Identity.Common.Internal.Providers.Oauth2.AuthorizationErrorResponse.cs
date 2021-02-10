using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse", DoNotGenerateAcw=true)]
	public partial class AuthorizationErrorResponse : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse.Fields']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse$Fields", DoNotGenerateAcw=true)]
		public partial class Fields : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse.Fields']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const string Error = (string) "error";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse.Fields']/field[@name='ERROR_DESCRIPTION']"
			[Register ("ERROR_DESCRIPTION")]
			public const string ErrorDescription = (string) "error_description";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse$Fields", typeof (Fields));

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

			protected Fields (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse.Fields']/constructor[@name='AuthorizationErrorResponse.Fields' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Fields () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse", typeof (AuthorizationErrorResponse));

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

		protected AuthorizationErrorResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse']/constructor[@name='AuthorizationErrorResponse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AuthorizationErrorResponse (string error, string errorDescription) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_error = JNIEnv.NewString (error);
			IntPtr native_errorDescription = JNIEnv.NewString (errorDescription);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_error);
				__args [1] = new JniArgumentValue (native_errorDescription);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_error);
				JNIEnv.DeleteLocalRef (native_errorDescription);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = JNIEnv.GetString (native_error, JniHandleOwnership.DoNotTransfer);
			__this.Error = error;
		}
#pragma warning restore 0169

		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorDescription = JNIEnv.GetString (native_errorDescription, JniHandleOwnership.DoNotTransfer);
			__this.ErrorDescription = errorDescription;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse']/method[@name='getErrorDescription' and count(parameter)=0]"
			[Register ("getErrorDescription", "()Ljava/lang/String;", "GetGetErrorDescriptionHandler")]
			get {
				const string __id = "getErrorDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationErrorResponse']/method[@name='setErrorDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
