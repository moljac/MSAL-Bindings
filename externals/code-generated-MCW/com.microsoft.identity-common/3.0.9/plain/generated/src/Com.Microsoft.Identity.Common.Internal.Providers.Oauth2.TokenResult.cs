using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/TokenResult", DoNotGenerateAcw=true)]
	public partial class TokenResult : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/TokenResult", typeof (TokenResult));

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

		protected TokenResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/constructor[@name='TokenResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/constructor[@name='TokenResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenErrorResponse']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;)V", "")]
		public unsafe TokenResult (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse errorResponse) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorResponse).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (errorResponse);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/constructor[@name='TokenResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResponse']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V", "")]
		public unsafe TokenResult (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse response) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (response);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/constructor[@name='TokenResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResponse'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenErrorResponse']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;)V", "")]
		public unsafe TokenResult (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse response, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse errorResponse) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [1] = new JniArgumentValue ((errorResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorResponse).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (response);
				global::System.GC.KeepAlive (errorResponse);
			}
		}

		static Delegate cb_getCliTelemInfo;
#pragma warning disable 0169
		static Delegate GetGetCliTelemInfoHandler ()
		{
			if (cb_getCliTelemInfo == null)
				cb_getCliTelemInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCliTelemInfo);
			return cb_getCliTelemInfo;
		}

		static IntPtr n_GetCliTelemInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CliTelemInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_;
#pragma warning disable 0169
		static Delegate GetSetCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_Handler ()
		{
			if (cb_setCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_ == null)
				cb_setCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_);
			return cb_setCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_;
		}

		static void n_SetCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cliTelemInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cliTelemInfo = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (native_cliTelemInfo, JniHandleOwnership.DoNotTransfer);
			__this.CliTelemInfo = cliTelemInfo;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo CliTelemInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='getCliTelemInfo' and count(parameter)=0]"
			[Register ("getCliTelemInfo", "()Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;", "GetGetCliTelemInfoHandler")]
			get {
				const string __id = "getCliTelemInfo.()Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='setCliTelemInfo' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.CliTelemInfo']]"
			[Register ("setCliTelemInfo", "(Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;)V", "GetSetCliTelemInfo_Lcom_microsoft_identity_common_internal_telemetry_CliTelemInfo_Handler")]
			set {
				const string __id = "setCliTelemInfo.(Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse ErrorResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='getErrorResponse' and count(parameter)=0]"
			[Register ("getErrorResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;", "GetGetErrorResponseHandler")]
			get {
				const string __id = "getErrorResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Success;
		}
#pragma warning restore 0169

		static Delegate cb_setSuccess_Z;
#pragma warning disable 0169
		static Delegate GetSetSuccess_ZHandler ()
		{
			if (cb_setSuccess_Z == null)
				cb_setSuccess_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSuccess_Z);
			return cb_setSuccess_Z;
		}

		static void n_SetSuccess_Z (IntPtr jnienv, IntPtr native__this, bool success)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Success = success;
		}
#pragma warning restore 0169

		public virtual unsafe bool Success {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='getSuccess' and count(parameter)=0]"
			[Register ("getSuccess", "()Z", "GetGetSuccessHandler")]
			get {
				const string __id = "getSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='setSuccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSuccess", "(Z)V", "GetSetSuccess_ZHandler")]
			set {
				const string __id = "setSuccess.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuccessResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse SuccessResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='getSuccessResponse' and count(parameter)=0]"
			[Register ("getSuccessResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;", "GetGetSuccessResponseHandler")]
			get {
				const string __id = "getSuccessResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenResponse;
#pragma warning disable 0169
		static Delegate GetGetTokenResponseHandler ()
		{
			if (cb_getTokenResponse == null)
				cb_getTokenResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenResponse);
			return cb_getTokenResponse;
		}

		static IntPtr n_GetTokenResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TokenResponse);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse TokenResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResult']/method[@name='getTokenResponse' and count(parameter)=0]"
			[Register ("getTokenResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;", "GetGetTokenResponseHandler")]
			get {
				const string __id = "getTokenResponse.()Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
