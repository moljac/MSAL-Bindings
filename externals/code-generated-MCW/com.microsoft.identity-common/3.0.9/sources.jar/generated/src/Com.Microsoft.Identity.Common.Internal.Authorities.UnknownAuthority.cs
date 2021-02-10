using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authorities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='UnknownAuthority']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/UnknownAuthority", DoNotGenerateAcw=true)]
	public partial class UnknownAuthority : global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/UnknownAuthority", typeof (UnknownAuthority));

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

		protected UnknownAuthority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='UnknownAuthority']/constructor[@name='UnknownAuthority' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnknownAuthority () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAuthorityURL;
#pragma warning disable 0169
		static Delegate GetGetAuthorityURLHandler ()
		{
			if (cb_getAuthorityURL == null)
				cb_getAuthorityURL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityURL);
			return cb_getAuthorityURL;
		}

		static IntPtr n_GetAuthorityURL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.UnknownAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorityURL);
		}
#pragma warning restore 0169

		public override unsafe global::Java.Net.URL AuthorityURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='UnknownAuthority']/method[@name='getAuthorityURL' and count(parameter)=0]"
			[Register ("getAuthorityURL", "()Ljava/net/URL;", "GetGetAuthorityURLHandler")]
			get {
				const string __id = "getAuthorityURL.()Ljava/net/URL;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorityUri;
#pragma warning disable 0169
		static Delegate GetGetAuthorityUriHandler ()
		{
			if (cb_getAuthorityUri == null)
				cb_getAuthorityUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityUri);
			return cb_getAuthorityUri;
		}

		static IntPtr n_GetAuthorityUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.UnknownAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorityUri);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Net.Uri AuthorityUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='UnknownAuthority']/method[@name='getAuthorityUri' and count(parameter)=0]"
			[Register ("getAuthorityUri", "()Landroid/net/Uri;", "GetGetAuthorityUriHandler")]
			get {
				const string __id = "getAuthorityUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_;
#pragma warning disable 0169
		static Delegate GetCreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_Handler ()
		{
			if (cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_ == null)
				cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_);
			return cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_;
		}

		static IntPtr n_CreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.UnknownAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOAuth2Strategy (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='UnknownAuthority']/method[@name='createOAuth2Strategy' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2StrategyParameters']]"
		[Register ("createOAuth2Strategy", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;", "GetCreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy CreateOAuth2Strategy (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters parameters)
		{
			const string __id = "createOAuth2Strategy.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

	}
}
