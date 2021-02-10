using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/AcquireTokenResult", DoNotGenerateAcw=true)]
	public partial class AcquireTokenResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/AcquireTokenResult", typeof (AcquireTokenResult));

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

		protected AcquireTokenResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/constructor[@name='AcquireTokenResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AcquireTokenResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAuthorizationResult;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationResultHandler ()
		{
			if (cb_getAuthorizationResult == null)
				cb_getAuthorizationResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationResult);
			return cb_getAuthorizationResult;
		}

		static IntPtr n_GetAuthorizationResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationResult);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Handler ()
		{
			if (cb_setAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_ == null)
				cb_setAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_);
			return cb_setAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_;
		}

		static void n_SetAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorizationResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorizationResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (native_authorizationResult, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationResult = authorizationResult;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult AuthorizationResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='getAuthorizationResult' and count(parameter)=0]"
			[Register ("getAuthorizationResult", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;", "GetGetAuthorizationResultHandler")]
			get {
				const string __id = "getAuthorizationResult.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='setAuthorizationResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResult']]"
			[Register ("setAuthorizationResult", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;)V", "GetSetAuthorizationResult_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Handler")]
			set {
				const string __id = "setAuthorizationResult.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getLocalAuthenticationResult;
#pragma warning disable 0169
		static Delegate GetGetLocalAuthenticationResultHandler ()
		{
			if (cb_getLocalAuthenticationResult == null)
				cb_getLocalAuthenticationResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalAuthenticationResult);
			return cb_getLocalAuthenticationResult;
		}

		static IntPtr n_GetLocalAuthenticationResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalAuthenticationResult);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_;
#pragma warning disable 0169
		static Delegate GetSetLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Handler ()
		{
			if (cb_setLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ == null)
				cb_setLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_);
			return cb_setLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_;
		}

		static void n_SetLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.LocalAuthenticationResult = result;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult LocalAuthenticationResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='getLocalAuthenticationResult' and count(parameter)=0]"
			[Register ("getLocalAuthenticationResult", "()Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;", "GetGetLocalAuthenticationResultHandler")]
			get {
				const string __id = "getLocalAuthenticationResult.()Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='setLocalAuthenticationResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult']]"
			[Register ("setLocalAuthenticationResult", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)V", "GetSetLocalAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Handler")]
			set {
				const string __id = "setLocalAuthenticationResult.(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSucceeded;
#pragma warning disable 0169
		static Delegate GetGetSucceededHandler ()
		{
			if (cb_getSucceeded == null)
				cb_getSucceeded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSucceeded);
			return cb_getSucceeded;
		}

		static IntPtr n_GetSucceeded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Succeeded);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean Succeeded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='getSucceeded' and count(parameter)=0]"
			[Register ("getSucceeded", "()Ljava/lang/Boolean;", "GetGetSucceededHandler")]
			get {
				const string __id = "getSucceeded.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenResult;
#pragma warning disable 0169
		static Delegate GetGetTokenResultHandler ()
		{
			if (cb_getTokenResult == null)
				cb_getTokenResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenResult);
			return cb_getTokenResult;
		}

		static IntPtr n_GetTokenResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TokenResult);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_;
#pragma warning disable 0169
		static Delegate GetSetTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_Handler ()
		{
			if (cb_setTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_ == null)
				cb_setTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_);
			return cb_setTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_;
		}

		static void n_SetTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (native_tokenResult, JniHandleOwnership.DoNotTransfer);
			__this.TokenResult = tokenResult;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult TokenResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='getTokenResult' and count(parameter)=0]"
			[Register ("getTokenResult", "()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;", "GetGetTokenResultHandler")]
			get {
				const string __id = "getTokenResult.()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AcquireTokenResult']/method[@name='setTokenResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResult']]"
			[Register ("setTokenResult", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;)V", "GetSetTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResult_Handler")]
			set {
				const string __id = "setTokenResult.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
