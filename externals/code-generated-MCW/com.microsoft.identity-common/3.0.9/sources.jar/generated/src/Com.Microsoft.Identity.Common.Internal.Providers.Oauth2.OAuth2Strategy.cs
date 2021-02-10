using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericAccessToken extends com.microsoft.identity.common.internal.providers.oauth2.AccessToken", "GenericAccount extends com.microsoft.identity.common.BaseAccount", "GenericAuthorizationRequest extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest", "GenericAuthorizationRequestBuilder extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest.Builder", "GenericAuthorizationStrategy extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationStrategy", "GenericOAuth2Configuration extends com.microsoft.identity.common.internal.providers.oauth2.OAuth2Configuration", "GenericOAuth2StrategyParameters extends com.microsoft.identity.common.internal.providers.oauth2.OAuth2StrategyParameters", "GenericAuthorizationResponse extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResponse", "GenericRefreshToken extends com.microsoft.identity.common.internal.providers.oauth2.RefreshToken", "GenericTokenRequest extends com.microsoft.identity.common.internal.providers.oauth2.TokenRequest", "GenericTokenResponse extends com.microsoft.identity.common.internal.providers.oauth2.TokenResponse", "GenericTokenResult extends com.microsoft.identity.common.internal.providers.oauth2.TokenResult", "GenericAuthorizationResult extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResult"})]
	public abstract partial class OAuth2Strategy : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='DEVICE_CODE_CONTENT_TYPE']"
		[Register ("DEVICE_CODE_CONTENT_TYPE")]
		protected const string DeviceCodeContentType = (string) "application/x-www-form-urlencoded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='TOKEN_REQUEST_CONTENT_TYPE']"
		[Register ("TOKEN_REQUEST_CONTENT_TYPE")]
		protected const string TokenRequestContentType = (string) "application/x-www-form-urlencoded";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='mAuthorizationEndpoint']"
		[Register ("mAuthorizationEndpoint")]
		protected string MAuthorizationEndpoint {
			get {
				const string __id = "mAuthorizationEndpoint.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAuthorizationEndpoint.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='mClockSkewManager']"
		[Register ("mClockSkewManager")]
		protected global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager MClockSkewManager {
			get {
				const string __id = "mClockSkewManager.Lcom/microsoft/identity/common/internal/util/IClockSkewManager;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mClockSkewManager.Lcom/microsoft/identity/common/internal/util/IClockSkewManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='mConfig']"
		[Register ("mConfig")]
		protected global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Configuration MConfig {
			get {
				const string __id = "mConfig.Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Configuration;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Configuration> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConfig.Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Configuration;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='mStrategyParameters']"
		[Register ("mStrategyParameters")]
		protected global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters MStrategyParameters {
			get {
				const string __id = "mStrategyParameters.Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mStrategyParameters.Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/field[@name='mTokenEndpoint']"
		[Register ("mTokenEndpoint")]
		protected string MTokenEndpoint {
			get {
				const string __id = "mTokenEndpoint.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTokenEndpoint.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy", typeof (OAuth2Strategy));

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

		protected OAuth2Strategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/constructor[@name='OAuth2Strategy' and count(parameter)=2 and parameter[1][@type='GenericOAuth2Configuration'] and parameter[2][@type='GenericOAuth2StrategyParameters']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Configuration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)V", "")]
		public unsafe OAuth2Strategy (global::Java.Lang.Object config, global::Java.Lang.Object strategyParameters) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Configuration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_config = JNIEnv.ToLocalJniHandle (config);
			IntPtr native_strategyParameters = JNIEnv.ToLocalJniHandle (strategyParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_config);
				__args [1] = new JniArgumentValue (native_strategyParameters);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_config);
				JNIEnv.DeleteLocalRef (native_strategyParameters);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (strategyParameters);
			}
		}

		static Delegate cb_getAuthorityFromTokenEndpoint;
#pragma warning disable 0169
		static Delegate GetGetAuthorityFromTokenEndpointHandler ()
		{
			if (cb_getAuthorityFromTokenEndpoint == null)
				cb_getAuthorityFromTokenEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityFromTokenEndpoint);
			return cb_getAuthorityFromTokenEndpoint;
		}

		static IntPtr n_GetAuthorityFromTokenEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityFromTokenEndpoint);
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorityFromTokenEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getAuthorityFromTokenEndpoint' and count(parameter)=0]"
			[Register ("getAuthorityFromTokenEndpoint", "()Ljava/lang/String;", "GetGetAuthorityFromTokenEndpointHandler")]
			get {
				const string __id = "getAuthorityFromTokenEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorizationResultFactory;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationResultFactoryHandler ()
		{
			if (cb_getAuthorizationResultFactory == null)
				cb_getAuthorizationResultFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationResultFactory);
			return cb_getAuthorizationResultFactory;
		}

		static IntPtr n_GetAuthorizationResultFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationResultFactory);
		}
#pragma warning restore 0169

		public abstract global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResultFactory AuthorizationResultFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getAuthorizationResultFactory' and count(parameter)=0]"
			[Register ("getAuthorizationResultFactory", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory;", "GetGetAuthorizationResultFactoryHandler")]
			get; 
		}

		protected unsafe global::Android.Net.Uri Issuer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getIssuer' and count(parameter)=0]"
			[Register ("getIssuer", "()Landroid/net/Uri;", "GetGetIssuerHandler")]
			get {
				const string __id = "getIssuer.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='setIssuer' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setIssuer", "(Landroid/net/Uri;)V", "")]
			set {
				const string __id = "setIssuer.(Landroid/net/Uri;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getOAuth2Configuration;
#pragma warning disable 0169
		static Delegate GetGetOAuth2ConfigurationHandler ()
		{
			if (cb_getOAuth2Configuration == null)
				cb_getOAuth2Configuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOAuth2Configuration);
			return cb_getOAuth2Configuration;
		}

		static IntPtr n_GetOAuth2Configuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OAuth2Configuration);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.Lang.Object OAuth2Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getOAuth2Configuration' and count(parameter)=0]"
			[Register ("getOAuth2Configuration", "()Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Configuration;", "GetGetOAuth2ConfigurationHandler")]
			get {
				const string __id = "getOAuth2Configuration.()Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Configuration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetCreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_CreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createAccount' and count(parameter)=1 and parameter[1][@type='GenericTokenResponse']]"
		[Register ("createAccount", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/BaseAccount;", "GetCreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public abstract global::Java.Lang.Object CreateAccount (global::Java.Lang.Object p0);

		static Delegate cb_createAuthorizationRequestBuilder;
#pragma warning disable 0169
		static Delegate GetCreateAuthorizationRequestBuilderHandler ()
		{
			if (cb_createAuthorizationRequestBuilder == null)
				cb_createAuthorizationRequestBuilder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateAuthorizationRequestBuilder);
			return cb_createAuthorizationRequestBuilder;
		}

		static IntPtr n_CreateAuthorizationRequestBuilder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateAuthorizationRequestBuilder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createAuthorizationRequestBuilder' and count(parameter)=0]"
		[Register ("createAuthorizationRequestBuilder", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetCreateAuthorizationRequestBuilderHandler")]
		public abstract global::Java.Lang.Object CreateAuthorizationRequestBuilder ();

		static Delegate cb_createAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_;
#pragma warning disable 0169
		static Delegate GetCreateAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_Handler ()
		{
			if (cb_createAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_ == null)
				cb_createAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_);
			return cb_createAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_;
		}

		static IntPtr n_CreateAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAuthorizationRequestBuilder (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createAuthorizationRequestBuilder' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.IAccountRecord']]"
		[Register ("createAuthorizationRequestBuilder", "(Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetCreateAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_Handler")]
		public abstract global::Java.Lang.Object CreateAuthorizationRequestBuilder (global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord p0);

		static Delegate cb_createRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
#pragma warning disable 0169
		static Delegate GetCreateRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler ()
		{
			if (cb_createRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ == null)
				cb_createRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_);
			return cb_createRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
		}

		static IntPtr n_CreateRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRefreshTokenRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createRefreshTokenRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("createRefreshTokenRequest", "(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;", "GetCreateRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public abstract global::Java.Lang.Object CreateRefreshTokenRequest (global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p0);

		static Delegate cb_createTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
#pragma warning disable 0169
		static Delegate GetCreateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler ()
		{
			if (cb_createTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ == null)
				cb_createTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_);
			return cb_createTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
		}

		static IntPtr n_CreateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateTokenRequest (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createTokenRequest' and count(parameter)=3 and parameter[1][@type='GenericAuthorizationRequest'] and parameter[2][@type='GenericAuthorizationResponse'] and parameter[3][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("createTokenRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;", "GetCreateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public abstract global::Java.Lang.Object CreateTokenRequest (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p2);

		static Delegate cb_getAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_getAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_getAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_getAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_GetAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccessTokenFromResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getAccessTokenFromResponse' and count(parameter)=1 and parameter[1][@type='GenericTokenResponse']]"
		[Register ("getAccessTokenFromResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/providers/oauth2/AccessToken;", "GetGetAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public abstract global::Java.Lang.Object GetAccessTokenFromResponse (global::Java.Lang.Object p0);

		static Delegate cb_getIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_;
#pragma warning disable 0169
		static Delegate GetGetIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler ()
		{
			if (cb_getIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ == null)
				cb_getIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_);
			return cb_getIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_;
		}

		static IntPtr n_GetIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetIssuerCacheIdentifier (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getIssuerCacheIdentifier' and count(parameter)=1 and parameter[1][@type='GenericAuthorizationRequest']]"
		[Register ("getIssuerCacheIdentifier", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)Ljava/lang/String;", "GetGetIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler")]
		public abstract string GetIssuerCacheIdentifier (global::Java.Lang.Object p0);

		static Delegate cb_getRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_getRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_getRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_getRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_GetRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRefreshTokenFromResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getRefreshTokenFromResponse' and count(parameter)=1 and parameter[1][@type='GenericTokenResponse']]"
		[Register ("getRefreshTokenFromResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;", "GetGetRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public abstract global::Java.Lang.Object GetRefreshTokenFromResponse (global::Java.Lang.Object p0);

		static Delegate cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_;
#pragma warning disable 0169
		static Delegate GetRequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_Handler ()
		{
			if (cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_ == null)
				cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_RequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_);
			return cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_;
		}

		static IntPtr n_RequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_authorizationStrategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_request, JniHandleOwnership.DoNotTransfer);
			var authorizationStrategy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_authorizationStrategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestAuthorization (request, authorizationStrategy));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='requestAuthorization' and count(parameter)=2 and parameter[1][@type='GenericAuthorizationRequest'] and parameter[2][@type='GenericAuthorizationStrategy']]"
		[Register ("requestAuthorization", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy;)Ljava/util/concurrent/Future;", "GetRequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationStrategy_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture RequestAuthorization (global::Java.Lang.Object request, global::Java.Lang.Object authorizationStrategy)
		{
			const string __id = "requestAuthorization.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy;)Ljava/util/concurrent/Future;";
			IntPtr native_request = JNIEnv.ToLocalJniHandle (request);
			IntPtr native_authorizationStrategy = JNIEnv.ToLocalJniHandle (authorizationStrategy);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_request);
				__args [1] = new JniArgumentValue (native_authorizationStrategy);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_request);
				JNIEnv.DeleteLocalRef (native_authorizationStrategy);
				global::System.GC.KeepAlive (request);
				global::System.GC.KeepAlive (authorizationStrategy);
			}
		}

		static Delegate cb_requestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_;
#pragma warning disable 0169
		static Delegate GetRequestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Handler ()
		{
			if (cb_requestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_ == null)
				cb_requestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RequestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_);
			return cb_requestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_;
		}

		static IntPtr n_RequestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestToken (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='requestToken' and count(parameter)=1 and parameter[1][@type='GenericTokenRequest']]"
		[Register ("requestToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;", "GetRequestToken_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Handler")]
		public virtual unsafe global::Java.Lang.Object RequestToken (global::Java.Lang.Object request)
		{
			const string __id = "requestToken.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;";
			IntPtr native_request = JNIEnv.ToLocalJniHandle (request);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_request);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_request);
				global::System.GC.KeepAlive (request);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='setAuthorizationEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAuthorizationEndpoint", "(Ljava/lang/String;)V", "")]
		protected unsafe void SetAuthorizationEndpoint (string authorizationEndpoint)
		{
			const string __id = "setAuthorizationEndpoint.(Ljava/lang/String;)V";
			IntPtr native_authorizationEndpoint = JNIEnv.NewString (authorizationEndpoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authorizationEndpoint);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authorizationEndpoint);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='setTokenEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTokenEndpoint", "(Ljava/lang/String;)V", "")]
		protected unsafe void SetTokenEndpoint (string tokenEndpoint)
		{
			const string __id = "setTokenEndpoint.(Ljava/lang/String;)V";
			IntPtr native_tokenEndpoint = JNIEnv.NewString (tokenEndpoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tokenEndpoint);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tokenEndpoint);
			}
		}

		static Delegate cb_validateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_;
#pragma warning disable 0169
		static Delegate GetValidateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler ()
		{
			if (cb_validateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ == null)
				cb_validateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ValidateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_);
			return cb_validateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_;
		}

		static void n_ValidateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValidateAuthorizationRequest (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateAuthorizationRequest' and count(parameter)=1 and parameter[1][@type='GenericAuthorizationRequest']]"
		[Register ("validateAuthorizationRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)V", "GetValidateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler")]
		protected abstract void ValidateAuthorizationRequest (global::Java.Lang.Object p0);

		static Delegate cb_validateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
#pragma warning disable 0169
		static Delegate GetValidateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler ()
		{
			if (cb_validateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ == null)
				cb_validateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_ValidateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_);
			return cb_validateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
		}

		static bool n_ValidateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authScheme, IntPtr native_cacheRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authScheme = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_authScheme, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ValidateCachedResult (authScheme, cacheRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateCachedResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme'] and parameter[2][@type='com.microsoft.identity.common.internal.cache.ICacheRecord']]"
		[Register ("validateCachedResult", "(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)Z", "GetValidateCachedResult_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler")]
		public virtual unsafe bool ValidateCachedResult (global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme authScheme, global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord)
		{
			const string __id = "validateCachedResult.(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((authScheme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authScheme).Handle);
				__args [1] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (authScheme);
				global::System.GC.KeepAlive (cacheRecord);
			}
		}

		static Delegate cb_validateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_;
#pragma warning disable 0169
		static Delegate GetValidateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Handler ()
		{
			if (cb_validateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_ == null)
				cb_validateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ValidateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_);
			return cb_validateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_;
		}

		static void n_ValidateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValidateTokenRequest (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateTokenRequest' and count(parameter)=1 and parameter[1][@type='GenericTokenRequest']]"
		[Register ("validateTokenRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;)V", "GetValidateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Handler")]
		protected abstract void ValidateTokenRequest (global::Java.Lang.Object p0);

		static Delegate cb_validateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetValidateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_validateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_validateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ValidateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_validateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static void n_ValidateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ValidateTokenResponse (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateTokenResponse' and count(parameter)=2 and parameter[1][@type='GenericTokenRequest'] and parameter[2][@type='GenericTokenResponse']]"
		[Register ("validateTokenResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V", "GetValidateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		protected abstract void ValidateTokenResponse (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy", DoNotGenerateAcw=true)]
	internal partial class OAuth2StrategyInvoker : OAuth2Strategy {
		public OAuth2StrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy", typeof (OAuth2StrategyInvoker));

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

		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResultFactory AuthorizationResultFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getAuthorizationResultFactory' and count(parameter)=0]"
			[Register ("getAuthorizationResultFactory", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory;", "GetGetAuthorizationResultFactoryHandler")]
			get {
				const string __id = "getAuthorizationResultFactory.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResultFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createAccount' and count(parameter)=1 and parameter[1][@type='GenericTokenResponse']]"
		[Register ("createAccount", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/BaseAccount;", "GetCreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public override unsafe global::Java.Lang.Object CreateAccount (global::Java.Lang.Object p0)
		{
			const string __id = "createAccount.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/BaseAccount;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createAuthorizationRequestBuilder' and count(parameter)=0]"
		[Register ("createAuthorizationRequestBuilder", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetCreateAuthorizationRequestBuilderHandler")]
		public override unsafe global::Java.Lang.Object CreateAuthorizationRequestBuilder ()
		{
			const string __id = "createAuthorizationRequestBuilder.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createAuthorizationRequestBuilder' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.IAccountRecord']]"
		[Register ("createAuthorizationRequestBuilder", "(Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetCreateAuthorizationRequestBuilder_Lcom_microsoft_identity_common_internal_dto_IAccountRecord_Handler")]
		public override unsafe global::Java.Lang.Object CreateAuthorizationRequestBuilder (global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord p0)
		{
			const string __id = "createAuthorizationRequestBuilder.(Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createRefreshTokenRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("createRefreshTokenRequest", "(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;", "GetCreateRefreshTokenRequest_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public override unsafe global::Java.Lang.Object CreateRefreshTokenRequest (global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p0)
		{
			const string __id = "createRefreshTokenRequest.(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='createTokenRequest' and count(parameter)=3 and parameter[1][@type='GenericAuthorizationRequest'] and parameter[2][@type='GenericAuthorizationResponse'] and parameter[3][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("createTokenRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;", "GetCreateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public override unsafe global::Java.Lang.Object CreateTokenRequest (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p2)
		{
			const string __id = "createTokenRequest.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getAccessTokenFromResponse' and count(parameter)=1 and parameter[1][@type='GenericTokenResponse']]"
		[Register ("getAccessTokenFromResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/providers/oauth2/AccessToken;", "GetGetAccessTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public override unsafe global::Java.Lang.Object GetAccessTokenFromResponse (global::Java.Lang.Object p0)
		{
			const string __id = "getAccessTokenFromResponse.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/providers/oauth2/AccessToken;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getIssuerCacheIdentifier' and count(parameter)=1 and parameter[1][@type='GenericAuthorizationRequest']]"
		[Register ("getIssuerCacheIdentifier", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)Ljava/lang/String;", "GetGetIssuerCacheIdentifier_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler")]
		public override unsafe string GetIssuerCacheIdentifier (global::Java.Lang.Object p0)
		{
			const string __id = "getIssuerCacheIdentifier.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='getRefreshTokenFromResponse' and count(parameter)=1 and parameter[1][@type='GenericTokenResponse']]"
		[Register ("getRefreshTokenFromResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;", "GetGetRefreshTokenFromResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public override unsafe global::Java.Lang.Object GetRefreshTokenFromResponse (global::Java.Lang.Object p0)
		{
			const string __id = "getRefreshTokenFromResponse.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateAuthorizationRequest' and count(parameter)=1 and parameter[1][@type='GenericAuthorizationRequest']]"
		[Register ("validateAuthorizationRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)V", "GetValidateAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler")]
		protected override unsafe void ValidateAuthorizationRequest (global::Java.Lang.Object p0)
		{
			const string __id = "validateAuthorizationRequest.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateTokenRequest' and count(parameter)=1 and parameter[1][@type='GenericTokenRequest']]"
		[Register ("validateTokenRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;)V", "GetValidateTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Handler")]
		protected override unsafe void ValidateTokenRequest (global::Java.Lang.Object p0)
		{
			const string __id = "validateTokenRequest.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2Strategy']/method[@name='validateTokenResponse' and count(parameter)=2 and parameter[1][@type='GenericTokenRequest'] and parameter[2][@type='GenericTokenResponse']]"
		[Register ("validateTokenResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V", "GetValidateTokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		protected override unsafe void ValidateTokenResponse (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "validateTokenResponse.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
