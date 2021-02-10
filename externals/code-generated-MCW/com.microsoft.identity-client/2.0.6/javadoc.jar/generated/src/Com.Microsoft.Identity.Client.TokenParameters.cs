using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenParameters", DoNotGenerateAcw=true)]
	public abstract partial class TokenParameters : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenParameters$Builder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends com.microsoft.identity.client.TokenParameters.Builder<B>"})]
		public abstract partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenParameters$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/constructor[@name='TokenParameters.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/client/TokenParameters;", "GetBuildHandler")]
			public abstract global::Com.Microsoft.Identity.Client.TokenParameters Build ();

			static Delegate cb_forAccount_Lcom_microsoft_identity_client_IAccount_;
#pragma warning disable 0169
			static Delegate GetForAccount_Lcom_microsoft_identity_client_IAccount_Handler ()
			{
				if (cb_forAccount_Lcom_microsoft_identity_client_IAccount_ == null)
					cb_forAccount_Lcom_microsoft_identity_client_IAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ForAccount_Lcom_microsoft_identity_client_IAccount_);
				return cb_forAccount_Lcom_microsoft_identity_client_IAccount_;
			}

			static IntPtr n_ForAccount_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForAccount (account));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='forAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAccount']]"
			[Register ("forAccount", "(Lcom/microsoft/identity/client/IAccount;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetForAccount_Lcom_microsoft_identity_client_IAccount_Handler")]
			public virtual unsafe global::Java.Lang.Object ForAccount (global::Com.Microsoft.Identity.Client.IAccount account)
			{
				const string __id = "forAccount.(Lcom/microsoft/identity/client/IAccount;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (account);
				}
			}

			static Delegate cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_;
#pragma warning disable 0169
			static Delegate GetFromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Handler ()
			{
				if (cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_ == null)
					cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_);
				return cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_;
			}

			static IntPtr n_FromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cloudInstance, IntPtr native_audience)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cloudInstance = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (native_cloudInstance, JniHandleOwnership.DoNotTransfer);
				var audience = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (native_audience, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromAuthority (cloudInstance, audience));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='fromAuthority' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.AzureCloudInstance'] and parameter[2][@type='com.microsoft.identity.client.AadAuthorityAudience']]"
			[Register ("fromAuthority", "(Lcom/microsoft/identity/client/AzureCloudInstance;Lcom/microsoft/identity/client/AadAuthorityAudience;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetFromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Handler")]
			public virtual unsafe global::Java.Lang.Object FromAuthority (global::Com.Microsoft.Identity.Client.AzureCloudInstance cloudInstance, global::Com.Microsoft.Identity.Client.AadAuthorityAudience audience)
			{
				const string __id = "fromAuthority.(Lcom/microsoft/identity/client/AzureCloudInstance;Lcom/microsoft/identity/client/AadAuthorityAudience;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((cloudInstance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cloudInstance).Handle);
					__args [1] = new JniArgumentValue ((audience == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audience).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (cloudInstance);
					global::System.GC.KeepAlive (audience);
				}
			}

			static Delegate cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_Handler ()
			{
				if (cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_ == null)
					cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_FromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_);
				return cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_;
			}

			static IntPtr n_FromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cloudInstance, IntPtr native_audience, IntPtr native_tenant)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cloudInstance = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (native_cloudInstance, JniHandleOwnership.DoNotTransfer);
				var audience = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (native_audience, JniHandleOwnership.DoNotTransfer);
				var tenant = JNIEnv.GetString (native_tenant, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromAuthority (cloudInstance, audience, tenant));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='fromAuthority' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.AzureCloudInstance'] and parameter[2][@type='com.microsoft.identity.client.AadAuthorityAudience'] and parameter[3][@type='java.lang.String']]"
			[Register ("fromAuthority", "(Lcom/microsoft/identity/client/AzureCloudInstance;Lcom/microsoft/identity/client/AadAuthorityAudience;Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetFromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Lcom_microsoft_identity_client_AadAuthorityAudience_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object FromAuthority (global::Com.Microsoft.Identity.Client.AzureCloudInstance cloudInstance, global::Com.Microsoft.Identity.Client.AadAuthorityAudience audience, string tenant)
			{
				const string __id = "fromAuthority.(Lcom/microsoft/identity/client/AzureCloudInstance;Lcom/microsoft/identity/client/AadAuthorityAudience;Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				IntPtr native_tenant = JNIEnv.NewString (tenant);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((cloudInstance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cloudInstance).Handle);
					__args [1] = new JniArgumentValue ((audience == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audience).Handle);
					__args [2] = new JniArgumentValue (native_tenant);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_tenant);
					global::System.GC.KeepAlive (cloudInstance);
					global::System.GC.KeepAlive (audience);
				}
			}

			static Delegate cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_Handler ()
			{
				if (cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_ == null)
					cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_);
				return cb_fromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_;
			}

			static IntPtr n_FromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cloudInstance, IntPtr native_tenant)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cloudInstance = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (native_cloudInstance, JniHandleOwnership.DoNotTransfer);
				var tenant = JNIEnv.GetString (native_tenant, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromAuthority (cloudInstance, tenant));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='fromAuthority' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.AzureCloudInstance'] and parameter[2][@type='java.lang.String']]"
			[Register ("fromAuthority", "(Lcom/microsoft/identity/client/AzureCloudInstance;Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetFromAuthority_Lcom_microsoft_identity_client_AzureCloudInstance_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object FromAuthority (global::Com.Microsoft.Identity.Client.AzureCloudInstance cloudInstance, string tenant)
			{
				const string __id = "fromAuthority.(Lcom/microsoft/identity/client/AzureCloudInstance;Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				IntPtr native_tenant = JNIEnv.NewString (tenant);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((cloudInstance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cloudInstance).Handle);
					__args [1] = new JniArgumentValue (native_tenant);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_tenant);
					global::System.GC.KeepAlive (cloudInstance);
				}
			}

			static Delegate cb_fromAuthority_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFromAuthority_Ljava_lang_String_Handler ()
			{
				if (cb_fromAuthority_Ljava_lang_String_ == null)
					cb_fromAuthority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FromAuthority_Ljava_lang_String_);
				return cb_fromAuthority_Ljava_lang_String_;
			}

			static IntPtr n_FromAuthority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorityUrl)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authorityUrl = JNIEnv.GetString (native_authorityUrl, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromAuthority (authorityUrl));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='fromAuthority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromAuthority", "(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetFromAuthority_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object FromAuthority (string authorityUrl)
			{
				const string __id = "fromAuthority.(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				IntPtr native_authorityUrl = JNIEnv.NewString (authorityUrl);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_authorityUrl);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_authorityUrl);
				}
			}

			static Delegate cb_self;
#pragma warning disable 0169
			static Delegate GetSelfHandler ()
			{
				if (cb_self == null)
					cb_self = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Self);
				return cb_self;
			}

			static IntPtr n_Self (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Self ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetSelfHandler")]
			public abstract global::Java.Lang.Object Self ();

			static Delegate cb_withAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_;
#pragma warning disable 0169
			static Delegate GetWithAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_Handler ()
			{
				if (cb_withAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_ == null)
					cb_withAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_);
				return cb_withAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_;
			}

			static IntPtr n_WithAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scheme)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scheme = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AuthenticationScheme> (native_scheme, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAuthenticationScheme (scheme));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='withAuthenticationScheme' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AuthenticationScheme']]"
			[Register ("withAuthenticationScheme", "(Lcom/microsoft/identity/client/AuthenticationScheme;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetWithAuthenticationScheme_Lcom_microsoft_identity_client_AuthenticationScheme_Handler")]
			public virtual unsafe global::Java.Lang.Object WithAuthenticationScheme (global::Com.Microsoft.Identity.Client.AuthenticationScheme scheme)
			{
				const string __id = "withAuthenticationScheme.(Lcom/microsoft/identity/client/AuthenticationScheme;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((scheme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheme).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (scheme);
				}
			}

			static Delegate cb_withClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_;
#pragma warning disable 0169
			static Delegate GetWithClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_Handler ()
			{
				if (cb_withClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_ == null)
					cb_withClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_);
				return cb_withClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_;
			}

			static IntPtr n_WithClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claimsRequest)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var claimsRequest = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (native_claimsRequest, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithClaims (claimsRequest));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='withClaims' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.claims.ClaimsRequest']]"
			[Register ("withClaims", "(Lcom/microsoft/identity/client/claims/ClaimsRequest;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetWithClaims_Lcom_microsoft_identity_client_claims_ClaimsRequest_Handler")]
			public virtual unsafe global::Java.Lang.Object WithClaims (global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest claimsRequest)
			{
				const string __id = "withClaims.(Lcom/microsoft/identity/client/claims/ClaimsRequest;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((claimsRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) claimsRequest).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (claimsRequest);
				}
			}

			static Delegate cb_withCorrelationId_Ljava_util_UUID_;
#pragma warning disable 0169
			static Delegate GetWithCorrelationId_Ljava_util_UUID_Handler ()
			{
				if (cb_withCorrelationId_Ljava_util_UUID_ == null)
					cb_withCorrelationId_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithCorrelationId_Ljava_util_UUID_);
				return cb_withCorrelationId_Ljava_util_UUID_;
			}

			static IntPtr n_WithCorrelationId_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var correlationId = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_correlationId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCorrelationId (correlationId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='withCorrelationId' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
			[Register ("withCorrelationId", "(Ljava/util/UUID;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetWithCorrelationId_Ljava_util_UUID_Handler")]
			public virtual unsafe global::Java.Lang.Object WithCorrelationId (global::Java.Util.UUID correlationId)
			{
				const string __id = "withCorrelationId.(Ljava/util/UUID;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((correlationId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) correlationId).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (correlationId);
				}
			}

			static Delegate cb_withResource_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithResource_Ljava_lang_String_Handler ()
			{
				if (cb_withResource_Ljava_lang_String_ == null)
					cb_withResource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithResource_Ljava_lang_String_);
				return cb_withResource_Ljava_lang_String_;
			}

			static IntPtr n_WithResource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var resource = JNIEnv.GetString (native_resource, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithResource (resource));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='withResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withResource", "(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetWithResource_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object WithResource (string resource)
			{
				const string __id = "withResource.(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				IntPtr native_resource = JNIEnv.NewString (resource);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_resource);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_resource);
				}
			}

			static Delegate cb_withScopes_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetWithScopes_Ljava_util_List_Handler ()
			{
				if (cb_withScopes_Ljava_util_List_ == null)
					cb_withScopes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithScopes_Ljava_util_List_);
				return cb_withScopes_Ljava_util_List_;
			}

			static IntPtr n_WithScopes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scopes = global::Android.Runtime.JavaList<string>.FromJniHandle (native_scopes, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithScopes (scopes));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='withScopes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("withScopes", "(Ljava/util/List;)Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetWithScopes_Ljava_util_List_Handler")]
			public virtual unsafe global::Java.Lang.Object WithScopes (global::System.Collections.Generic.IList<string> scopes)
			{
				const string __id = "withScopes.(Ljava/util/List;)Lcom/microsoft/identity/client/TokenParameters$Builder;";
				IntPtr native_scopes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (scopes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scopes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_scopes);
					global::System.GC.KeepAlive (scopes);
				}
			}

		}

		[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenParameters$Builder", DoNotGenerateAcw=true)]
		internal partial class BuilderInvoker : Builder {
			public BuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenParameters$Builder", typeof (BuilderInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/client/TokenParameters;", "GetBuildHandler")]
			public override unsafe global::Com.Microsoft.Identity.Client.TokenParameters Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/client/TokenParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/client/TokenParameters$Builder;", "GetSelfHandler")]
			public override unsafe global::Java.Lang.Object Self ()
			{
				const string __id = "self.()Lcom/microsoft/identity/client/TokenParameters$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenParameters", typeof (TokenParameters));

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

		protected TokenParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/constructor[@name='TokenParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.TokenParameters.Builder']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/TokenParameters$Builder;)V", "")]
		protected unsafe TokenParameters (global::Com.Microsoft.Identity.Client.TokenParameters.Builder builder) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/client/TokenParameters$Builder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.IAccount Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/microsoft/identity/client/IAccount;", "GetGetAccountHandler")]
			get {
				const string __id = "getAccount.()Lcom/microsoft/identity/client/IAccount;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccountRecord;
#pragma warning disable 0169
		static Delegate GetGetAccountRecordHandler ()
		{
			if (cb_getAccountRecord == null)
				cb_getAccountRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccountRecord);
			return cb_getAccountRecord;
		}

		static IntPtr n_GetAccountRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountRecord);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord AccountRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getAccountRecord' and count(parameter)=0]"
			[Register ("getAccountRecord", "()Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccountRecordHandler")]
			get {
				const string __id = "getAccountRecord.()Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthenticationScheme;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationSchemeHandler ()
		{
			if (cb_getAuthenticationScheme == null)
				cb_getAuthenticationScheme = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthenticationScheme);
			return cb_getAuthenticationScheme;
		}

		static IntPtr n_GetAuthenticationScheme (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthenticationScheme);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.AuthenticationScheme AuthenticationScheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getAuthenticationScheme' and count(parameter)=0]"
			[Register ("getAuthenticationScheme", "()Lcom/microsoft/identity/client/AuthenticationScheme;", "GetGetAuthenticationSchemeHandler")]
			get {
				const string __id = "getAuthenticationScheme.()Lcom/microsoft/identity/client/AuthenticationScheme;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AuthenticationScheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthority;
#pragma warning disable 0169
		static Delegate GetGetAuthorityHandler ()
		{
			if (cb_getAuthority == null)
				cb_getAuthority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthority);
			return cb_getAuthority;
		}

		static IntPtr n_GetAuthority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Authority);
		}
#pragma warning restore 0169

		public virtual unsafe string Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getAuthority' and count(parameter)=0]"
			[Register ("getAuthority", "()Ljava/lang/String;", "GetGetAuthorityHandler")]
			get {
				const string __id = "getAuthority.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClaimsRequest;
#pragma warning disable 0169
		static Delegate GetGetClaimsRequestHandler ()
		{
			if (cb_getClaimsRequest == null)
				cb_getClaimsRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaimsRequest);
			return cb_getClaimsRequest;
		}

		static IntPtr n_GetClaimsRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClaimsRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest ClaimsRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getClaimsRequest' and count(parameter)=0]"
			[Register ("getClaimsRequest", "()Lcom/microsoft/identity/client/claims/ClaimsRequest;", "GetGetClaimsRequestHandler")]
			get {
				const string __id = "getClaimsRequest.()Lcom/microsoft/identity/client/claims/ClaimsRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCorrelationId;
#pragma warning disable 0169
		static Delegate GetGetCorrelationIdHandler ()
		{
			if (cb_getCorrelationId == null)
				cb_getCorrelationId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCorrelationId);
			return cb_getCorrelationId;
		}

		static IntPtr n_GetCorrelationId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		public virtual unsafe string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getCorrelationId' and count(parameter)=0]"
			[Register ("getCorrelationId", "()Ljava/lang/String;", "GetGetCorrelationIdHandler")]
			get {
				const string __id = "getCorrelationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Scopes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParameters']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/List;", "GetGetScopesHandler")]
			get {
				const string __id = "getScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenParameters", DoNotGenerateAcw=true)]
	internal partial class TokenParametersInvoker : TokenParameters {
		public TokenParametersInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenParameters", typeof (TokenParametersInvoker));

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
