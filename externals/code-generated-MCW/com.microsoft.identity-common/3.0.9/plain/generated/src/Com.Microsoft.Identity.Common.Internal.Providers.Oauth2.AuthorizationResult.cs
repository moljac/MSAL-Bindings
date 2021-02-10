using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericAuthorizationResponse extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResponse", "GenericAuthorizationErrorResponse extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationErrorResponse"})]
	public abstract partial class AuthorizationResult : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult", typeof (AuthorizationResult));

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

		protected AuthorizationResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/constructor[@name='AuthorizationResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizationResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/constructor[@name='AuthorizationResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationStatus']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStatus;)V", "")]
		public unsafe AuthorizationResult (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStatus status) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStatus;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (status);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/constructor[@name='AuthorizationResult' and count(parameter)=2 and parameter[1][@type='GenericAuthorizationResponse'] and parameter[2][@type='GenericAuthorizationErrorResponse']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse;)V", "")]
		public unsafe AuthorizationResult (global::Java.Lang.Object response, global::Java.Lang.Object errorResponse) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_response = JNIEnv.ToLocalJniHandle (response);
			IntPtr native_errorResponse = JNIEnv.ToLocalJniHandle (errorResponse);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_response);
				__args [1] = new JniArgumentValue (native_errorResponse);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_response);
				JNIEnv.DeleteLocalRef (native_errorResponse);
				global::System.GC.KeepAlive (response);
				global::System.GC.KeepAlive (errorResponse);
			}
		}

		static Delegate cb_getAuthorizationErrorResponse;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationErrorResponseHandler ()
		{
			if (cb_getAuthorizationErrorResponse == null)
				cb_getAuthorizationErrorResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationErrorResponse);
			return cb_getAuthorizationErrorResponse;
		}

		static IntPtr n_GetAuthorizationErrorResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationErrorResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object AuthorizationErrorResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='getAuthorizationErrorResponse' and count(parameter)=0]"
			[Register ("getAuthorizationErrorResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse;", "GetGetAuthorizationErrorResponseHandler")]
			get {
				const string __id = "getAuthorizationErrorResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorizationResponse;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationResponseHandler ()
		{
			if (cb_getAuthorizationResponse == null)
				cb_getAuthorizationResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationResponse);
			return cb_getAuthorizationResponse;
		}

		static IntPtr n_GetAuthorizationResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object AuthorizationResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='getAuthorizationResponse' and count(parameter)=0]"
			[Register ("getAuthorizationResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;", "GetGetAuthorizationResponseHandler")]
			get {
				const string __id = "getAuthorizationResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorizationStatus;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationStatusHandler ()
		{
			if (cb_getAuthorizationStatus == null)
				cb_getAuthorizationStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationStatus);
			return cb_getAuthorizationStatus;
		}

		static IntPtr n_GetAuthorizationStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationStatus);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStatus AuthorizationStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='getAuthorizationStatus' and count(parameter)=0]"
			[Register ("getAuthorizationStatus", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStatus;", "GetGetAuthorizationStatusHandler")]
			get {
				const string __id = "getAuthorizationStatus.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorResponse;
#pragma warning disable 0169
		static Delegate GetGetErrorResponseHandler ()
		{
			if (cb_getErrorResponse == null)
				cb_getErrorResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorResponse);
			return cb_getErrorResponse;
		}

		static IntPtr n_GetErrorResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse ErrorResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='getErrorResponse' and count(parameter)=0]"
			[Register ("getErrorResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/IErrorResponse;", "GetGetErrorResponseHandler")]
			get {
				const string __id = "getErrorResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/IErrorResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuccess;
#pragma warning disable 0169
		static Delegate GetGetSuccessHandler ()
		{
			if (cb_getSuccess == null)
				cb_getSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetSuccess);
			return cb_getSuccess;
		}

		static bool n_GetSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Success;
		}
#pragma warning restore 0169

		public virtual unsafe bool Success {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='getSuccess' and count(parameter)=0]"
			[Register ("getSuccess", "()Z", "GetGetSuccessHandler")]
			get {
				const string __id = "getSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSuccessResponse;
#pragma warning disable 0169
		static Delegate GetGetSuccessResponseHandler ()
		{
			if (cb_getSuccessResponse == null)
				cb_getSuccessResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSuccessResponse);
			return cb_getSuccessResponse;
		}

		static IntPtr n_GetSuccessResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuccessResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse SuccessResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='getSuccessResponse' and count(parameter)=0]"
			[Register ("getSuccessResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/ISuccessResponse;", "GetGetSuccessResponseHandler")]
			get {
				const string __id = "getSuccessResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/ISuccessResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_Handler ()
		{
			if (cb_setAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_ == null)
				cb_setAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_);
			return cb_setAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_;
		}

		static void n_SetAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authErrorResponse)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authErrorResponse = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_authErrorResponse, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthorizationErrorResponse (authErrorResponse);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='setAuthorizationErrorResponse' and count(parameter)=1 and parameter[1][@type='GenericAuthorizationErrorResponse']]"
		[Register ("setAuthorizationErrorResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse;)V", "GetSetAuthorizationErrorResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationErrorResponse_Handler")]
		protected virtual unsafe void SetAuthorizationErrorResponse (global::Java.Lang.Object authErrorResponse)
		{
			const string __id = "setAuthorizationErrorResponse.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationErrorResponse;)V";
			IntPtr native_authErrorResponse = JNIEnv.ToLocalJniHandle (authErrorResponse);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authErrorResponse);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authErrorResponse);
				global::System.GC.KeepAlive (authErrorResponse);
			}
		}

		static Delegate cb_setAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Handler ()
		{
			if (cb_setAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_ == null)
				cb_setAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_);
			return cb_setAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_;
		}

		static void n_SetAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authResponse)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authResponse = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_authResponse, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthorizationResponse (authResponse);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='setAuthorizationResponse' and count(parameter)=1 and parameter[1][@type='GenericAuthorizationResponse']]"
		[Register ("setAuthorizationResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;)V", "GetSetAuthorizationResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Handler")]
		protected virtual unsafe void SetAuthorizationResponse (global::Java.Lang.Object authResponse)
		{
			const string __id = "setAuthorizationResponse.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;)V";
			IntPtr native_authResponse = JNIEnv.ToLocalJniHandle (authResponse);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authResponse);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authResponse);
				global::System.GC.KeepAlive (authResponse);
			}
		}

		static Delegate cb_setAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_Handler ()
		{
			if (cb_setAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_ == null)
				cb_setAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_);
			return cb_setAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_;
		}

		static void n_SetAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authStatus = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStatus> (native_authStatus, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthorizationStatus (authStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResult']/method[@name='setAuthorizationStatus' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationStatus']]"
		[Register ("setAuthorizationStatus", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStatus;)V", "GetSetAuthorizationStatus_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStatus_Handler")]
		protected virtual unsafe void SetAuthorizationStatus (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStatus authStatus)
		{
			const string __id = "setAuthorizationStatus.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStatus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((authStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authStatus).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (authStatus);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult", DoNotGenerateAcw=true)]
	internal partial class AuthorizationResultInvoker : AuthorizationResult {
		public AuthorizationResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult", typeof (AuthorizationResultInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
