using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfiguration", DoNotGenerateAcw=true)]
	public partial class OpenIdProviderConfiguration : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfiguration$SerializedNames", DoNotGenerateAcw=true)]
		public sealed partial class SerializedNames : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='ACR_VALUES_SUPPORTED']"
			[Register ("ACR_VALUES_SUPPORTED")]
			public const string AcrValuesSupported = (string) "acr_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='AUTHORIZATION_ENDPOINT']"
			[Register ("AUTHORIZATION_ENDPOINT")]
			public const string AuthorizationEndpoint = (string) "authorization_endpoint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CHECK_SESSION_IFRAME']"
			[Register ("CHECK_SESSION_IFRAME")]
			public const string CheckSessionIframe = (string) "check_session_iframe";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CLAIMS_LOCALES_SUPPORTED']"
			[Register ("CLAIMS_LOCALES_SUPPORTED")]
			public const string ClaimsLocalesSupported = (string) "claims_locales_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CLAIMS_PARAMETER_SUPPORTED']"
			[Register ("CLAIMS_PARAMETER_SUPPORTED")]
			public const string ClaimsParameterSupported = (string) "claims_parameter_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CLAIMS_SUPPORTED']"
			[Register ("CLAIMS_SUPPORTED")]
			public const string ClaimsSupported = (string) "claims_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CLAIM_TYPES_SUPPORTED']"
			[Register ("CLAIM_TYPES_SUPPORTED")]
			public const string ClaimTypesSupported = (string) "claim_types_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CLOUD_GRAPH_HOST_NAME']"
			[Register ("CLOUD_GRAPH_HOST_NAME")]
			public const string CloudGraphHostName = (string) "cloud_graph_host_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='CLOUD_INSTANCE_NAME']"
			[Register ("CLOUD_INSTANCE_NAME")]
			public const string CloudInstanceName = (string) "cloud_instance_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='DEVICE_AUTHORIZATION_ENDPOINT']"
			[Register ("DEVICE_AUTHORIZATION_ENDPOINT")]
			public const string DeviceAuthorizationEndpoint = (string) "device_authorization_endpoint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='DISPLAY_VALUES_SUPPORTED']"
			[Register ("DISPLAY_VALUES_SUPPORTED")]
			public const string DisplayValuesSupported = (string) "display_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='END_SESSION_ENDPOINT']"
			[Register ("END_SESSION_ENDPOINT")]
			public const string EndSessionEndpoint = (string) "end_session_endpoint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='FRONTCHANNEL_LOGOUT_SUPPORTED']"
			[Register ("FRONTCHANNEL_LOGOUT_SUPPORTED")]
			public const string FrontchannelLogoutSupported = (string) "frontchannel_logout_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='GRANT_TYPES_SUPPORTED']"
			[Register ("GRANT_TYPES_SUPPORTED")]
			public const string GrantTypesSupported = (string) "grant_types_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='HTTP_LOGOUT_SUPPORTED']"
			[Register ("HTTP_LOGOUT_SUPPORTED")]
			public const string HttpLogoutSupported = (string) "http_logout_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='ID_TOKEN_ENCRYPTION_ALG_VALUES_SUPPORTED']"
			[Register ("ID_TOKEN_ENCRYPTION_ALG_VALUES_SUPPORTED")]
			public const string IdTokenEncryptionAlgValuesSupported = (string) "id_token_encryption_alg_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='ID_TOKEN_ENCRYPTION_ENC_VALUES_SUPPORTED']"
			[Register ("ID_TOKEN_ENCRYPTION_ENC_VALUES_SUPPORTED")]
			public const string IdTokenEncryptionEncValuesSupported = (string) "id_token_encryption_enc_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='ID_TOKEN_SIGNING_ALG_VALUES_SUPPORTED']"
			[Register ("ID_TOKEN_SIGNING_ALG_VALUES_SUPPORTED")]
			public const string IdTokenSigningAlgValuesSupported = (string) "id_token_signing_alg_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='ISSUER']"
			[Register ("ISSUER")]
			public const string Issuer = (string) "issuer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='JWKS_URI']"
			[Register ("JWKS_URI")]
			public const string JwksUri = (string) "jwks_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='MSGRAPH_HOST']"
			[Register ("MSGRAPH_HOST")]
			public const string MsgraphHost = (string) "msgraph_host";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='OP_POLICY_URI']"
			[Register ("OP_POLICY_URI")]
			public const string OpPolicyUri = (string) "op_policy_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='OP_TOS_URI']"
			[Register ("OP_TOS_URI")]
			public const string OpTosUri = (string) "op_tos_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='RBAC_URL']"
			[Register ("RBAC_URL")]
			public const string RbacUrl = (string) "rbac_url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REGISTRATION_ENDPOINT']"
			[Register ("REGISTRATION_ENDPOINT")]
			public const string RegistrationEndpoint = (string) "registration_endpoint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REQUEST_OBJECT_ENCRYPTION_ALG_VALUES_SUPPORTED']"
			[Register ("REQUEST_OBJECT_ENCRYPTION_ALG_VALUES_SUPPORTED")]
			public const string RequestObjectEncryptionAlgValuesSupported = (string) "request_object_encryption_alg_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REQUEST_OBJECT_ENCRYPTION_ENC_VALUES_SUPPORTED']"
			[Register ("REQUEST_OBJECT_ENCRYPTION_ENC_VALUES_SUPPORTED")]
			public const string RequestObjectEncryptionEncValuesSupported = (string) "request_object_encryption_enc_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REQUEST_OBJECT_SIGNING_ALG_VALUES_SUPPORTED']"
			[Register ("REQUEST_OBJECT_SIGNING_ALG_VALUES_SUPPORTED")]
			public const string RequestObjectSigningAlgValuesSupported = (string) "request_object_signing_alg_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REQUEST_PARAMETER_SUPPORTED']"
			[Register ("REQUEST_PARAMETER_SUPPORTED")]
			public const string RequestParameterSupported = (string) "request_parameter_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REQUEST_URI_PARAMETER_SUPPORTED']"
			[Register ("REQUEST_URI_PARAMETER_SUPPORTED")]
			public const string RequestUriParameterSupported = (string) "request_uri_parameter_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='REQUIRE_REQUEST_URI_REGISTRATION']"
			[Register ("REQUIRE_REQUEST_URI_REGISTRATION")]
			public const string RequireRequestUriRegistration = (string) "require_request_uri_registration";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='RESPONSE_MODES_SUPPORTED']"
			[Register ("RESPONSE_MODES_SUPPORTED")]
			public const string ResponseModesSupported = (string) "response_modes_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='RESPONSE_TYPES_SUPPORTED']"
			[Register ("RESPONSE_TYPES_SUPPORTED")]
			public const string ResponseTypesSupported = (string) "response_types_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='SCOPES_SUPPORTED']"
			[Register ("SCOPES_SUPPORTED")]
			public const string ScopesSupported = (string) "scopes_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='SERVICE_DOCUMENTATION']"
			[Register ("SERVICE_DOCUMENTATION")]
			public const string ServiceDocumentation = (string) "service_documentation";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='SUBJECT_TYPES_SUPPORTED']"
			[Register ("SUBJECT_TYPES_SUPPORTED")]
			public const string SubjectTypesSupported = (string) "subject_types_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='TENANT_REGION_SCOPE']"
			[Register ("TENANT_REGION_SCOPE")]
			public const string TenantRegionScope = (string) "tenant_region_scope";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='TOKEN_ENDPOINT']"
			[Register ("TOKEN_ENDPOINT")]
			public const string TokenEndpoint = (string) "token_endpoint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='TOKEN_ENDPOINT_AUTH_METHODS_SUPPORTED']"
			[Register ("TOKEN_ENDPOINT_AUTH_METHODS_SUPPORTED")]
			public const string TokenEndpointAuthMethodsSupported = (string) "token_endpoint_auth_methods_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='TOKEN_ENDPOINT_AUTH_SIGNING_ALG_VALUES_SUPPORTED']"
			[Register ("TOKEN_ENDPOINT_AUTH_SIGNING_ALG_VALUES_SUPPORTED")]
			public const string TokenEndpointAuthSigningAlgValuesSupported = (string) "token_endpoint_auth_signing_alg_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='UI_LOCALES_SUPPORTED']"
			[Register ("UI_LOCALES_SUPPORTED")]
			public const string UiLocalesSupported = (string) "ui_locales_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='USERINFO_ENCRYPTION_ALG_VALUES_SUPPORTED']"
			[Register ("USERINFO_ENCRYPTION_ALG_VALUES_SUPPORTED")]
			public const string UserinfoEncryptionAlgValuesSupported = (string) "userinfo_encryption_alg_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='USERINFO_ENCRYPTION_ENC_VALUES_SUPPORTED']"
			[Register ("USERINFO_ENCRYPTION_ENC_VALUES_SUPPORTED")]
			public const string UserinfoEncryptionEncValuesSupported = (string) "userinfo_encryption_enc_values_supported";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='USERINFO_ENDPOINT']"
			[Register ("USERINFO_ENDPOINT")]
			public const string UserinfoEndpoint = (string) "userinfo_endpoint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/field[@name='USERINFO_SIGNING_ALG_VALUES_SUPPORTED']"
			[Register ("USERINFO_SIGNING_ALG_VALUES_SUPPORTED")]
			public const string UserinfoSigningAlgValuesSupported = (string) "userinfo_signing_alg_values_supported";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfiguration$SerializedNames", typeof (SerializedNames));

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

			internal SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration.SerializedNames']/constructor[@name='OpenIdProviderConfiguration.SerializedNames' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SerializedNames () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfiguration", typeof (OpenIdProviderConfiguration));

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

		protected OpenIdProviderConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/constructor[@name='OpenIdProviderConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenIdProviderConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAcrValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetAcrValuesSupportedHandler ()
		{
			if (cb_getAcrValuesSupported == null)
				cb_getAcrValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAcrValuesSupported);
			return cb_getAcrValuesSupported;
		}

		static IntPtr n_GetAcrValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AcrValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setAcrValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAcrValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setAcrValuesSupported_Ljava_util_List_ == null)
				cb_setAcrValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAcrValuesSupported_Ljava_util_List_);
			return cb_setAcrValuesSupported_Ljava_util_List_;
		}

		static void n_SetAcrValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_acrValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acrValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_acrValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.AcrValuesSupported = acrValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> AcrValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getAcrValuesSupported' and count(parameter)=0]"
			[Register ("getAcrValuesSupported", "()Ljava/util/List;", "GetGetAcrValuesSupportedHandler")]
			get {
				const string __id = "getAcrValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setAcrValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setAcrValuesSupported", "(Ljava/util/List;)V", "GetSetAcrValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setAcrValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getAuthorizationEndpoint;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationEndpointHandler ()
		{
			if (cb_getAuthorizationEndpoint == null)
				cb_getAuthorizationEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationEndpoint);
			return cb_getAuthorizationEndpoint;
		}

		static IntPtr n_GetAuthorizationEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationEndpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorizationEndpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationEndpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthorizationEndpoint_Ljava_lang_String_ == null)
				cb_setAuthorizationEndpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorizationEndpoint_Ljava_lang_String_);
			return cb_setAuthorizationEndpoint_Ljava_lang_String_;
		}

		static void n_SetAuthorizationEndpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorizationEndpoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorizationEndpoint = JNIEnv.GetString (native_authorizationEndpoint, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationEndpoint = authorizationEndpoint;
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorizationEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getAuthorizationEndpoint' and count(parameter)=0]"
			[Register ("getAuthorizationEndpoint", "()Ljava/lang/String;", "GetGetAuthorizationEndpointHandler")]
			get {
				const string __id = "getAuthorizationEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setAuthorizationEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthorizationEndpoint", "(Ljava/lang/String;)V", "GetSetAuthorizationEndpoint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthorizationEndpoint.(Ljava/lang/String;)V";
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

		static Delegate cb_getCheckSessionIFrame;
#pragma warning disable 0169
		static Delegate GetGetCheckSessionIFrameHandler ()
		{
			if (cb_getCheckSessionIFrame == null)
				cb_getCheckSessionIFrame = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCheckSessionIFrame);
			return cb_getCheckSessionIFrame;
		}

		static IntPtr n_GetCheckSessionIFrame (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CheckSessionIFrame);
		}
#pragma warning restore 0169

		static Delegate cb_setCheckSessionIFrame_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCheckSessionIFrame_Ljava_lang_String_Handler ()
		{
			if (cb_setCheckSessionIFrame_Ljava_lang_String_ == null)
				cb_setCheckSessionIFrame_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCheckSessionIFrame_Ljava_lang_String_);
			return cb_setCheckSessionIFrame_Ljava_lang_String_;
		}

		static void n_SetCheckSessionIFrame_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_checkSessionIFrame)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var checkSessionIFrame = JNIEnv.GetString (native_checkSessionIFrame, JniHandleOwnership.DoNotTransfer);
			__this.CheckSessionIFrame = checkSessionIFrame;
		}
#pragma warning restore 0169

		public virtual unsafe string CheckSessionIFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getCheckSessionIFrame' and count(parameter)=0]"
			[Register ("getCheckSessionIFrame", "()Ljava/lang/String;", "GetGetCheckSessionIFrameHandler")]
			get {
				const string __id = "getCheckSessionIFrame.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setCheckSessionIFrame' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCheckSessionIFrame", "(Ljava/lang/String;)V", "GetSetCheckSessionIFrame_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCheckSessionIFrame.(Ljava/lang/String;)V";
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

		static Delegate cb_getClaimTypesSupported;
#pragma warning disable 0169
		static Delegate GetGetClaimTypesSupportedHandler ()
		{
			if (cb_getClaimTypesSupported == null)
				cb_getClaimTypesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaimTypesSupported);
			return cb_getClaimTypesSupported;
		}

		static IntPtr n_GetClaimTypesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ClaimTypesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setClaimTypesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetClaimTypesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setClaimTypesSupported_Ljava_util_List_ == null)
				cb_setClaimTypesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClaimTypesSupported_Ljava_util_List_);
			return cb_setClaimTypesSupported_Ljava_util_List_;
		}

		static void n_SetClaimTypesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claimTypesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var claimTypesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_claimTypesSupported, JniHandleOwnership.DoNotTransfer);
			__this.ClaimTypesSupported = claimTypesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ClaimTypesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getClaimTypesSupported' and count(parameter)=0]"
			[Register ("getClaimTypesSupported", "()Ljava/util/List;", "GetGetClaimTypesSupportedHandler")]
			get {
				const string __id = "getClaimTypesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setClaimTypesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setClaimTypesSupported", "(Ljava/util/List;)V", "GetSetClaimTypesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setClaimTypesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getClaimsLocalesSupported;
#pragma warning disable 0169
		static Delegate GetGetClaimsLocalesSupportedHandler ()
		{
			if (cb_getClaimsLocalesSupported == null)
				cb_getClaimsLocalesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaimsLocalesSupported);
			return cb_getClaimsLocalesSupported;
		}

		static IntPtr n_GetClaimsLocalesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ClaimsLocalesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setClaimsLocalesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetClaimsLocalesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setClaimsLocalesSupported_Ljava_util_List_ == null)
				cb_setClaimsLocalesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClaimsLocalesSupported_Ljava_util_List_);
			return cb_setClaimsLocalesSupported_Ljava_util_List_;
		}

		static void n_SetClaimsLocalesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claimsLocalesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var claimsLocalesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_claimsLocalesSupported, JniHandleOwnership.DoNotTransfer);
			__this.ClaimsLocalesSupported = claimsLocalesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ClaimsLocalesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getClaimsLocalesSupported' and count(parameter)=0]"
			[Register ("getClaimsLocalesSupported", "()Ljava/util/List;", "GetGetClaimsLocalesSupportedHandler")]
			get {
				const string __id = "getClaimsLocalesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setClaimsLocalesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setClaimsLocalesSupported", "(Ljava/util/List;)V", "GetSetClaimsLocalesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setClaimsLocalesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getClaimsParameterSupported;
#pragma warning disable 0169
		static Delegate GetGetClaimsParameterSupportedHandler ()
		{
			if (cb_getClaimsParameterSupported == null)
				cb_getClaimsParameterSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaimsParameterSupported);
			return cb_getClaimsParameterSupported;
		}

		static IntPtr n_GetClaimsParameterSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClaimsParameterSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setClaimsParameterSupported_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetClaimsParameterSupported_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setClaimsParameterSupported_Ljava_lang_Boolean_ == null)
				cb_setClaimsParameterSupported_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClaimsParameterSupported_Ljava_lang_Boolean_);
			return cb_setClaimsParameterSupported_Ljava_lang_Boolean_;
		}

		static void n_SetClaimsParameterSupported_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claimsParameterSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var claimsParameterSupported = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_claimsParameterSupported, JniHandleOwnership.DoNotTransfer);
			__this.ClaimsParameterSupported = claimsParameterSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ClaimsParameterSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getClaimsParameterSupported' and count(parameter)=0]"
			[Register ("getClaimsParameterSupported", "()Ljava/lang/Boolean;", "GetGetClaimsParameterSupportedHandler")]
			get {
				const string __id = "getClaimsParameterSupported.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setClaimsParameterSupported' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setClaimsParameterSupported", "(Ljava/lang/Boolean;)V", "GetSetClaimsParameterSupported_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setClaimsParameterSupported.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getClaimsSupported;
#pragma warning disable 0169
		static Delegate GetGetClaimsSupportedHandler ()
		{
			if (cb_getClaimsSupported == null)
				cb_getClaimsSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaimsSupported);
			return cb_getClaimsSupported;
		}

		static IntPtr n_GetClaimsSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ClaimsSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setClaimsSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetClaimsSupported_Ljava_util_List_Handler ()
		{
			if (cb_setClaimsSupported_Ljava_util_List_ == null)
				cb_setClaimsSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClaimsSupported_Ljava_util_List_);
			return cb_setClaimsSupported_Ljava_util_List_;
		}

		static void n_SetClaimsSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claimsSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var claimsSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_claimsSupported, JniHandleOwnership.DoNotTransfer);
			__this.ClaimsSupported = claimsSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ClaimsSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getClaimsSupported' and count(parameter)=0]"
			[Register ("getClaimsSupported", "()Ljava/util/List;", "GetGetClaimsSupportedHandler")]
			get {
				const string __id = "getClaimsSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setClaimsSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setClaimsSupported", "(Ljava/util/List;)V", "GetSetClaimsSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setClaimsSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getCloudGraphHostName;
#pragma warning disable 0169
		static Delegate GetGetCloudGraphHostNameHandler ()
		{
			if (cb_getCloudGraphHostName == null)
				cb_getCloudGraphHostName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCloudGraphHostName);
			return cb_getCloudGraphHostName;
		}

		static IntPtr n_GetCloudGraphHostName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CloudGraphHostName);
		}
#pragma warning restore 0169

		static Delegate cb_setCloudGraphHostName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCloudGraphHostName_Ljava_lang_String_Handler ()
		{
			if (cb_setCloudGraphHostName_Ljava_lang_String_ == null)
				cb_setCloudGraphHostName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCloudGraphHostName_Ljava_lang_String_);
			return cb_setCloudGraphHostName_Ljava_lang_String_;
		}

		static void n_SetCloudGraphHostName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cloudGraphHostName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cloudGraphHostName = JNIEnv.GetString (native_cloudGraphHostName, JniHandleOwnership.DoNotTransfer);
			__this.CloudGraphHostName = cloudGraphHostName;
		}
#pragma warning restore 0169

		public virtual unsafe string CloudGraphHostName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getCloudGraphHostName' and count(parameter)=0]"
			[Register ("getCloudGraphHostName", "()Ljava/lang/String;", "GetGetCloudGraphHostNameHandler")]
			get {
				const string __id = "getCloudGraphHostName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setCloudGraphHostName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCloudGraphHostName", "(Ljava/lang/String;)V", "GetSetCloudGraphHostName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCloudGraphHostName.(Ljava/lang/String;)V";
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

		static Delegate cb_getCloudInstanceName;
#pragma warning disable 0169
		static Delegate GetGetCloudInstanceNameHandler ()
		{
			if (cb_getCloudInstanceName == null)
				cb_getCloudInstanceName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCloudInstanceName);
			return cb_getCloudInstanceName;
		}

		static IntPtr n_GetCloudInstanceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CloudInstanceName);
		}
#pragma warning restore 0169

		static Delegate cb_setCloudInstanceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCloudInstanceName_Ljava_lang_String_Handler ()
		{
			if (cb_setCloudInstanceName_Ljava_lang_String_ == null)
				cb_setCloudInstanceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCloudInstanceName_Ljava_lang_String_);
			return cb_setCloudInstanceName_Ljava_lang_String_;
		}

		static void n_SetCloudInstanceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cloudInstanceName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cloudInstanceName = JNIEnv.GetString (native_cloudInstanceName, JniHandleOwnership.DoNotTransfer);
			__this.CloudInstanceName = cloudInstanceName;
		}
#pragma warning restore 0169

		public virtual unsafe string CloudInstanceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getCloudInstanceName' and count(parameter)=0]"
			[Register ("getCloudInstanceName", "()Ljava/lang/String;", "GetGetCloudInstanceNameHandler")]
			get {
				const string __id = "getCloudInstanceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setCloudInstanceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCloudInstanceName", "(Ljava/lang/String;)V", "GetSetCloudInstanceName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCloudInstanceName.(Ljava/lang/String;)V";
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

		static Delegate cb_getDeviceAuthorizationEndpoint;
#pragma warning disable 0169
		static Delegate GetGetDeviceAuthorizationEndpointHandler ()
		{
			if (cb_getDeviceAuthorizationEndpoint == null)
				cb_getDeviceAuthorizationEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceAuthorizationEndpoint);
			return cb_getDeviceAuthorizationEndpoint;
		}

		static IntPtr n_GetDeviceAuthorizationEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceAuthorizationEndpoint);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceAuthorizationEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getDeviceAuthorizationEndpoint' and count(parameter)=0]"
			[Register ("getDeviceAuthorizationEndpoint", "()Ljava/lang/String;", "GetGetDeviceAuthorizationEndpointHandler")]
			get {
				const string __id = "getDeviceAuthorizationEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetDisplayValuesSupportedHandler ()
		{
			if (cb_getDisplayValuesSupported == null)
				cb_getDisplayValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDisplayValuesSupported);
			return cb_getDisplayValuesSupported;
		}

		static IntPtr n_GetDisplayValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.DisplayValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDisplayValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setDisplayValuesSupported_Ljava_util_List_ == null)
				cb_setDisplayValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDisplayValuesSupported_Ljava_util_List_);
			return cb_setDisplayValuesSupported_Ljava_util_List_;
		}

		static void n_SetDisplayValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_displayValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var displayValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_displayValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.DisplayValuesSupported = displayValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> DisplayValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getDisplayValuesSupported' and count(parameter)=0]"
			[Register ("getDisplayValuesSupported", "()Ljava/util/List;", "GetGetDisplayValuesSupportedHandler")]
			get {
				const string __id = "getDisplayValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setDisplayValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setDisplayValuesSupported", "(Ljava/util/List;)V", "GetSetDisplayValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setDisplayValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getEndSessionEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEndSessionEndpointHandler ()
		{
			if (cb_getEndSessionEndpoint == null)
				cb_getEndSessionEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEndSessionEndpoint);
			return cb_getEndSessionEndpoint;
		}

		static IntPtr n_GetEndSessionEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndSessionEndpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setEndSessionEndpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEndSessionEndpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setEndSessionEndpoint_Ljava_lang_String_ == null)
				cb_setEndSessionEndpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEndSessionEndpoint_Ljava_lang_String_);
			return cb_setEndSessionEndpoint_Ljava_lang_String_;
		}

		static void n_SetEndSessionEndpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endSessionEndpoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var endSessionEndpoint = JNIEnv.GetString (native_endSessionEndpoint, JniHandleOwnership.DoNotTransfer);
			__this.EndSessionEndpoint = endSessionEndpoint;
		}
#pragma warning restore 0169

		public virtual unsafe string EndSessionEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getEndSessionEndpoint' and count(parameter)=0]"
			[Register ("getEndSessionEndpoint", "()Ljava/lang/String;", "GetGetEndSessionEndpointHandler")]
			get {
				const string __id = "getEndSessionEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setEndSessionEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEndSessionEndpoint", "(Ljava/lang/String;)V", "GetSetEndSessionEndpoint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEndSessionEndpoint.(Ljava/lang/String;)V";
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

		static Delegate cb_getFrontChannelLogoutSupported;
#pragma warning disable 0169
		static Delegate GetGetFrontChannelLogoutSupportedHandler ()
		{
			if (cb_getFrontChannelLogoutSupported == null)
				cb_getFrontChannelLogoutSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFrontChannelLogoutSupported);
			return cb_getFrontChannelLogoutSupported;
		}

		static IntPtr n_GetFrontChannelLogoutSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FrontChannelLogoutSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setFrontChannelLogoutSupported_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetFrontChannelLogoutSupported_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setFrontChannelLogoutSupported_Ljava_lang_Boolean_ == null)
				cb_setFrontChannelLogoutSupported_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFrontChannelLogoutSupported_Ljava_lang_Boolean_);
			return cb_setFrontChannelLogoutSupported_Ljava_lang_Boolean_;
		}

		static void n_SetFrontChannelLogoutSupported_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frontChannelLogoutSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frontChannelLogoutSupported = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_frontChannelLogoutSupported, JniHandleOwnership.DoNotTransfer);
			__this.FrontChannelLogoutSupported = frontChannelLogoutSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean FrontChannelLogoutSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getFrontChannelLogoutSupported' and count(parameter)=0]"
			[Register ("getFrontChannelLogoutSupported", "()Ljava/lang/Boolean;", "GetGetFrontChannelLogoutSupportedHandler")]
			get {
				const string __id = "getFrontChannelLogoutSupported.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setFrontChannelLogoutSupported' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setFrontChannelLogoutSupported", "(Ljava/lang/Boolean;)V", "GetSetFrontChannelLogoutSupported_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setFrontChannelLogoutSupported.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getGrantTypesSupported;
#pragma warning disable 0169
		static Delegate GetGetGrantTypesSupportedHandler ()
		{
			if (cb_getGrantTypesSupported == null)
				cb_getGrantTypesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGrantTypesSupported);
			return cb_getGrantTypesSupported;
		}

		static IntPtr n_GetGrantTypesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GrantTypesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setGrantTypesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetGrantTypesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setGrantTypesSupported_Ljava_util_List_ == null)
				cb_setGrantTypesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGrantTypesSupported_Ljava_util_List_);
			return cb_setGrantTypesSupported_Ljava_util_List_;
		}

		static void n_SetGrantTypesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_grantTypesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var grantTypesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_grantTypesSupported, JniHandleOwnership.DoNotTransfer);
			__this.GrantTypesSupported = grantTypesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> GrantTypesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getGrantTypesSupported' and count(parameter)=0]"
			[Register ("getGrantTypesSupported", "()Ljava/util/List;", "GetGetGrantTypesSupportedHandler")]
			get {
				const string __id = "getGrantTypesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setGrantTypesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setGrantTypesSupported", "(Ljava/util/List;)V", "GetSetGrantTypesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setGrantTypesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getHttpLogoutSupported;
#pragma warning disable 0169
		static Delegate GetGetHttpLogoutSupportedHandler ()
		{
			if (cb_getHttpLogoutSupported == null)
				cb_getHttpLogoutSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpLogoutSupported);
			return cb_getHttpLogoutSupported;
		}

		static IntPtr n_GetHttpLogoutSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HttpLogoutSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setHttpLogoutSupported_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetHttpLogoutSupported_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setHttpLogoutSupported_Ljava_lang_Boolean_ == null)
				cb_setHttpLogoutSupported_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHttpLogoutSupported_Ljava_lang_Boolean_);
			return cb_setHttpLogoutSupported_Ljava_lang_Boolean_;
		}

		static void n_SetHttpLogoutSupported_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_httpLogoutSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var httpLogoutSupported = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_httpLogoutSupported, JniHandleOwnership.DoNotTransfer);
			__this.HttpLogoutSupported = httpLogoutSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean HttpLogoutSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getHttpLogoutSupported' and count(parameter)=0]"
			[Register ("getHttpLogoutSupported", "()Ljava/lang/Boolean;", "GetGetHttpLogoutSupportedHandler")]
			get {
				const string __id = "getHttpLogoutSupported.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setHttpLogoutSupported' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setHttpLogoutSupported", "(Ljava/lang/Boolean;)V", "GetSetHttpLogoutSupported_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setHttpLogoutSupported.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getIdTokenEncryptionAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetIdTokenEncryptionAlgValuesSupportedHandler ()
		{
			if (cb_getIdTokenEncryptionAlgValuesSupported == null)
				cb_getIdTokenEncryptionAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdTokenEncryptionAlgValuesSupported);
			return cb_getIdTokenEncryptionAlgValuesSupported;
		}

		static IntPtr n_GetIdTokenEncryptionAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.IdTokenEncryptionAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setIdTokenEncryptionAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetIdTokenEncryptionAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setIdTokenEncryptionAlgValuesSupported_Ljava_util_List_ == null)
				cb_setIdTokenEncryptionAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIdTokenEncryptionAlgValuesSupported_Ljava_util_List_);
			return cb_setIdTokenEncryptionAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetIdTokenEncryptionAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idTokenEncryptionAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var idTokenEncryptionAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_idTokenEncryptionAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.IdTokenEncryptionAlgValuesSupported = idTokenEncryptionAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> IdTokenEncryptionAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getIdTokenEncryptionAlgValuesSupported' and count(parameter)=0]"
			[Register ("getIdTokenEncryptionAlgValuesSupported", "()Ljava/util/List;", "GetGetIdTokenEncryptionAlgValuesSupportedHandler")]
			get {
				const string __id = "getIdTokenEncryptionAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setIdTokenEncryptionAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setIdTokenEncryptionAlgValuesSupported", "(Ljava/util/List;)V", "GetSetIdTokenEncryptionAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setIdTokenEncryptionAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getIdTokenEncryptionEncValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetIdTokenEncryptionEncValuesSupportedHandler ()
		{
			if (cb_getIdTokenEncryptionEncValuesSupported == null)
				cb_getIdTokenEncryptionEncValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdTokenEncryptionEncValuesSupported);
			return cb_getIdTokenEncryptionEncValuesSupported;
		}

		static IntPtr n_GetIdTokenEncryptionEncValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.IdTokenEncryptionEncValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setIdTokenEncryptionEncValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetIdTokenEncryptionEncValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setIdTokenEncryptionEncValuesSupported_Ljava_util_List_ == null)
				cb_setIdTokenEncryptionEncValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIdTokenEncryptionEncValuesSupported_Ljava_util_List_);
			return cb_setIdTokenEncryptionEncValuesSupported_Ljava_util_List_;
		}

		static void n_SetIdTokenEncryptionEncValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idTokenEncryptionEncValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var idTokenEncryptionEncValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_idTokenEncryptionEncValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.IdTokenEncryptionEncValuesSupported = idTokenEncryptionEncValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> IdTokenEncryptionEncValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getIdTokenEncryptionEncValuesSupported' and count(parameter)=0]"
			[Register ("getIdTokenEncryptionEncValuesSupported", "()Ljava/util/List;", "GetGetIdTokenEncryptionEncValuesSupportedHandler")]
			get {
				const string __id = "getIdTokenEncryptionEncValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setIdTokenEncryptionEncValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setIdTokenEncryptionEncValuesSupported", "(Ljava/util/List;)V", "GetSetIdTokenEncryptionEncValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setIdTokenEncryptionEncValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getIdTokenSigningAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetIdTokenSigningAlgValuesSupportedHandler ()
		{
			if (cb_getIdTokenSigningAlgValuesSupported == null)
				cb_getIdTokenSigningAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdTokenSigningAlgValuesSupported);
			return cb_getIdTokenSigningAlgValuesSupported;
		}

		static IntPtr n_GetIdTokenSigningAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.IdTokenSigningAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setIdTokenSigningAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetIdTokenSigningAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setIdTokenSigningAlgValuesSupported_Ljava_util_List_ == null)
				cb_setIdTokenSigningAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIdTokenSigningAlgValuesSupported_Ljava_util_List_);
			return cb_setIdTokenSigningAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetIdTokenSigningAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idTokenSigningAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var idTokenSigningAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_idTokenSigningAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.IdTokenSigningAlgValuesSupported = idTokenSigningAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> IdTokenSigningAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getIdTokenSigningAlgValuesSupported' and count(parameter)=0]"
			[Register ("getIdTokenSigningAlgValuesSupported", "()Ljava/util/List;", "GetGetIdTokenSigningAlgValuesSupportedHandler")]
			get {
				const string __id = "getIdTokenSigningAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setIdTokenSigningAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setIdTokenSigningAlgValuesSupported", "(Ljava/util/List;)V", "GetSetIdTokenSigningAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setIdTokenSigningAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getIssuer;
#pragma warning disable 0169
		static Delegate GetGetIssuerHandler ()
		{
			if (cb_getIssuer == null)
				cb_getIssuer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIssuer);
			return cb_getIssuer;
		}

		static IntPtr n_GetIssuer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Issuer);
		}
#pragma warning restore 0169

		static Delegate cb_setIssuer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIssuer_Ljava_lang_String_Handler ()
		{
			if (cb_setIssuer_Ljava_lang_String_ == null)
				cb_setIssuer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIssuer_Ljava_lang_String_);
			return cb_setIssuer_Ljava_lang_String_;
		}

		static void n_SetIssuer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_issuer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var issuer = JNIEnv.GetString (native_issuer, JniHandleOwnership.DoNotTransfer);
			__this.Issuer = issuer;
		}
#pragma warning restore 0169

		public virtual unsafe string Issuer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getIssuer' and count(parameter)=0]"
			[Register ("getIssuer", "()Ljava/lang/String;", "GetGetIssuerHandler")]
			get {
				const string __id = "getIssuer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setIssuer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIssuer", "(Ljava/lang/String;)V", "GetSetIssuer_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIssuer.(Ljava/lang/String;)V";
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

		static Delegate cb_getJwksUri;
#pragma warning disable 0169
		static Delegate GetGetJwksUriHandler ()
		{
			if (cb_getJwksUri == null)
				cb_getJwksUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJwksUri);
			return cb_getJwksUri;
		}

		static IntPtr n_GetJwksUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JwksUri);
		}
#pragma warning restore 0169

		static Delegate cb_setJwksUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetJwksUri_Ljava_lang_String_Handler ()
		{
			if (cb_setJwksUri_Ljava_lang_String_ == null)
				cb_setJwksUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetJwksUri_Ljava_lang_String_);
			return cb_setJwksUri_Ljava_lang_String_;
		}

		static void n_SetJwksUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jwksUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var jwksUri = JNIEnv.GetString (native_jwksUri, JniHandleOwnership.DoNotTransfer);
			__this.JwksUri = jwksUri;
		}
#pragma warning restore 0169

		public virtual unsafe string JwksUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getJwksUri' and count(parameter)=0]"
			[Register ("getJwksUri", "()Ljava/lang/String;", "GetGetJwksUriHandler")]
			get {
				const string __id = "getJwksUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setJwksUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setJwksUri", "(Ljava/lang/String;)V", "GetSetJwksUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setJwksUri.(Ljava/lang/String;)V";
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

		static Delegate cb_getMsGraphHost;
#pragma warning disable 0169
		static Delegate GetGetMsGraphHostHandler ()
		{
			if (cb_getMsGraphHost == null)
				cb_getMsGraphHost = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMsGraphHost);
			return cb_getMsGraphHost;
		}

		static IntPtr n_GetMsGraphHost (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsGraphHost);
		}
#pragma warning restore 0169

		static Delegate cb_setMsGraphHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsGraphHost_Ljava_lang_String_Handler ()
		{
			if (cb_setMsGraphHost_Ljava_lang_String_ == null)
				cb_setMsGraphHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMsGraphHost_Ljava_lang_String_);
			return cb_setMsGraphHost_Ljava_lang_String_;
		}

		static void n_SetMsGraphHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msGraphHost)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msGraphHost = JNIEnv.GetString (native_msGraphHost, JniHandleOwnership.DoNotTransfer);
			__this.MsGraphHost = msGraphHost;
		}
#pragma warning restore 0169

		public virtual unsafe string MsGraphHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getMsGraphHost' and count(parameter)=0]"
			[Register ("getMsGraphHost", "()Ljava/lang/String;", "GetGetMsGraphHostHandler")]
			get {
				const string __id = "getMsGraphHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setMsGraphHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsGraphHost", "(Ljava/lang/String;)V", "GetSetMsGraphHost_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMsGraphHost.(Ljava/lang/String;)V";
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

		static Delegate cb_getOpPolicyUri;
#pragma warning disable 0169
		static Delegate GetGetOpPolicyUriHandler ()
		{
			if (cb_getOpPolicyUri == null)
				cb_getOpPolicyUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOpPolicyUri);
			return cb_getOpPolicyUri;
		}

		static IntPtr n_GetOpPolicyUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpPolicyUri);
		}
#pragma warning restore 0169

		static Delegate cb_setOpPolicyUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpPolicyUri_Ljava_lang_String_Handler ()
		{
			if (cb_setOpPolicyUri_Ljava_lang_String_ == null)
				cb_setOpPolicyUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOpPolicyUri_Ljava_lang_String_);
			return cb_setOpPolicyUri_Ljava_lang_String_;
		}

		static void n_SetOpPolicyUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_opPolicyUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var opPolicyUri = JNIEnv.GetString (native_opPolicyUri, JniHandleOwnership.DoNotTransfer);
			__this.OpPolicyUri = opPolicyUri;
		}
#pragma warning restore 0169

		public virtual unsafe string OpPolicyUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getOpPolicyUri' and count(parameter)=0]"
			[Register ("getOpPolicyUri", "()Ljava/lang/String;", "GetGetOpPolicyUriHandler")]
			get {
				const string __id = "getOpPolicyUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setOpPolicyUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOpPolicyUri", "(Ljava/lang/String;)V", "GetSetOpPolicyUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setOpPolicyUri.(Ljava/lang/String;)V";
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

		static Delegate cb_getOpTosUri;
#pragma warning disable 0169
		static Delegate GetGetOpTosUriHandler ()
		{
			if (cb_getOpTosUri == null)
				cb_getOpTosUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOpTosUri);
			return cb_getOpTosUri;
		}

		static IntPtr n_GetOpTosUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpTosUri);
		}
#pragma warning restore 0169

		static Delegate cb_setOpTosUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpTosUri_Ljava_lang_String_Handler ()
		{
			if (cb_setOpTosUri_Ljava_lang_String_ == null)
				cb_setOpTosUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOpTosUri_Ljava_lang_String_);
			return cb_setOpTosUri_Ljava_lang_String_;
		}

		static void n_SetOpTosUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_opTosUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var opTosUri = JNIEnv.GetString (native_opTosUri, JniHandleOwnership.DoNotTransfer);
			__this.OpTosUri = opTosUri;
		}
#pragma warning restore 0169

		public virtual unsafe string OpTosUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getOpTosUri' and count(parameter)=0]"
			[Register ("getOpTosUri", "()Ljava/lang/String;", "GetGetOpTosUriHandler")]
			get {
				const string __id = "getOpTosUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setOpTosUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOpTosUri", "(Ljava/lang/String;)V", "GetSetOpTosUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setOpTosUri.(Ljava/lang/String;)V";
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

		static Delegate cb_getRbacUrl;
#pragma warning disable 0169
		static Delegate GetGetRbacUrlHandler ()
		{
			if (cb_getRbacUrl == null)
				cb_getRbacUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRbacUrl);
			return cb_getRbacUrl;
		}

		static IntPtr n_GetRbacUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RbacUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setRbacUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRbacUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setRbacUrl_Ljava_lang_String_ == null)
				cb_setRbacUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRbacUrl_Ljava_lang_String_);
			return cb_setRbacUrl_Ljava_lang_String_;
		}

		static void n_SetRbacUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rbacUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rbacUrl = JNIEnv.GetString (native_rbacUrl, JniHandleOwnership.DoNotTransfer);
			__this.RbacUrl = rbacUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string RbacUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRbacUrl' and count(parameter)=0]"
			[Register ("getRbacUrl", "()Ljava/lang/String;", "GetGetRbacUrlHandler")]
			get {
				const string __id = "getRbacUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRbacUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRbacUrl", "(Ljava/lang/String;)V", "GetSetRbacUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRbacUrl.(Ljava/lang/String;)V";
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

		static Delegate cb_getRegistrationEndpoint;
#pragma warning disable 0169
		static Delegate GetGetRegistrationEndpointHandler ()
		{
			if (cb_getRegistrationEndpoint == null)
				cb_getRegistrationEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRegistrationEndpoint);
			return cb_getRegistrationEndpoint;
		}

		static IntPtr n_GetRegistrationEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegistrationEndpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setRegistrationEndpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegistrationEndpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setRegistrationEndpoint_Ljava_lang_String_ == null)
				cb_setRegistrationEndpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRegistrationEndpoint_Ljava_lang_String_);
			return cb_setRegistrationEndpoint_Ljava_lang_String_;
		}

		static void n_SetRegistrationEndpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_registrationEndpoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var registrationEndpoint = JNIEnv.GetString (native_registrationEndpoint, JniHandleOwnership.DoNotTransfer);
			__this.RegistrationEndpoint = registrationEndpoint;
		}
#pragma warning restore 0169

		public virtual unsafe string RegistrationEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRegistrationEndpoint' and count(parameter)=0]"
			[Register ("getRegistrationEndpoint", "()Ljava/lang/String;", "GetGetRegistrationEndpointHandler")]
			get {
				const string __id = "getRegistrationEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRegistrationEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegistrationEndpoint", "(Ljava/lang/String;)V", "GetSetRegistrationEndpoint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRegistrationEndpoint.(Ljava/lang/String;)V";
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

		static Delegate cb_getRequestObjectEncryptionAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetRequestObjectEncryptionAlgValuesSupportedHandler ()
		{
			if (cb_getRequestObjectEncryptionAlgValuesSupported == null)
				cb_getRequestObjectEncryptionAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestObjectEncryptionAlgValuesSupported);
			return cb_getRequestObjectEncryptionAlgValuesSupported;
		}

		static IntPtr n_GetRequestObjectEncryptionAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RequestObjectEncryptionAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_ == null)
				cb_setRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_);
			return cb_setRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestObjectEncryptionAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestObjectEncryptionAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_requestObjectEncryptionAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.RequestObjectEncryptionAlgValuesSupported = requestObjectEncryptionAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> RequestObjectEncryptionAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRequestObjectEncryptionAlgValuesSupported' and count(parameter)=0]"
			[Register ("getRequestObjectEncryptionAlgValuesSupported", "()Ljava/util/List;", "GetGetRequestObjectEncryptionAlgValuesSupportedHandler")]
			get {
				const string __id = "getRequestObjectEncryptionAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRequestObjectEncryptionAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setRequestObjectEncryptionAlgValuesSupported", "(Ljava/util/List;)V", "GetSetRequestObjectEncryptionAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setRequestObjectEncryptionAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getRequestObjectEncryptionEncValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetRequestObjectEncryptionEncValuesSupportedHandler ()
		{
			if (cb_getRequestObjectEncryptionEncValuesSupported == null)
				cb_getRequestObjectEncryptionEncValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestObjectEncryptionEncValuesSupported);
			return cb_getRequestObjectEncryptionEncValuesSupported;
		}

		static IntPtr n_GetRequestObjectEncryptionEncValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RequestObjectEncryptionEncValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestObjectEncryptionEncValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetRequestObjectEncryptionEncValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setRequestObjectEncryptionEncValuesSupported_Ljava_util_List_ == null)
				cb_setRequestObjectEncryptionEncValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestObjectEncryptionEncValuesSupported_Ljava_util_List_);
			return cb_setRequestObjectEncryptionEncValuesSupported_Ljava_util_List_;
		}

		static void n_SetRequestObjectEncryptionEncValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestObjectEncryptionEncValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestObjectEncryptionEncValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_requestObjectEncryptionEncValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.RequestObjectEncryptionEncValuesSupported = requestObjectEncryptionEncValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> RequestObjectEncryptionEncValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRequestObjectEncryptionEncValuesSupported' and count(parameter)=0]"
			[Register ("getRequestObjectEncryptionEncValuesSupported", "()Ljava/util/List;", "GetGetRequestObjectEncryptionEncValuesSupportedHandler")]
			get {
				const string __id = "getRequestObjectEncryptionEncValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRequestObjectEncryptionEncValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setRequestObjectEncryptionEncValuesSupported", "(Ljava/util/List;)V", "GetSetRequestObjectEncryptionEncValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setRequestObjectEncryptionEncValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getRequestObjectSigningAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetRequestObjectSigningAlgValuesSupportedHandler ()
		{
			if (cb_getRequestObjectSigningAlgValuesSupported == null)
				cb_getRequestObjectSigningAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestObjectSigningAlgValuesSupported);
			return cb_getRequestObjectSigningAlgValuesSupported;
		}

		static IntPtr n_GetRequestObjectSigningAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RequestObjectSigningAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestObjectSigningAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetRequestObjectSigningAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setRequestObjectSigningAlgValuesSupported_Ljava_util_List_ == null)
				cb_setRequestObjectSigningAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestObjectSigningAlgValuesSupported_Ljava_util_List_);
			return cb_setRequestObjectSigningAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetRequestObjectSigningAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestObjectSigningAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestObjectSigningAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_requestObjectSigningAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.RequestObjectSigningAlgValuesSupported = requestObjectSigningAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> RequestObjectSigningAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRequestObjectSigningAlgValuesSupported' and count(parameter)=0]"
			[Register ("getRequestObjectSigningAlgValuesSupported", "()Ljava/util/List;", "GetGetRequestObjectSigningAlgValuesSupportedHandler")]
			get {
				const string __id = "getRequestObjectSigningAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRequestObjectSigningAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setRequestObjectSigningAlgValuesSupported", "(Ljava/util/List;)V", "GetSetRequestObjectSigningAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setRequestObjectSigningAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getRequestParameterSupported;
#pragma warning disable 0169
		static Delegate GetGetRequestParameterSupportedHandler ()
		{
			if (cb_getRequestParameterSupported == null)
				cb_getRequestParameterSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestParameterSupported);
			return cb_getRequestParameterSupported;
		}

		static IntPtr n_GetRequestParameterSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestParameterSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestParameterSupported_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRequestParameterSupported_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRequestParameterSupported_Ljava_lang_Boolean_ == null)
				cb_setRequestParameterSupported_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestParameterSupported_Ljava_lang_Boolean_);
			return cb_setRequestParameterSupported_Ljava_lang_Boolean_;
		}

		static void n_SetRequestParameterSupported_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestParameterSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestParameterSupported = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_requestParameterSupported, JniHandleOwnership.DoNotTransfer);
			__this.RequestParameterSupported = requestParameterSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean RequestParameterSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRequestParameterSupported' and count(parameter)=0]"
			[Register ("getRequestParameterSupported", "()Ljava/lang/Boolean;", "GetGetRequestParameterSupportedHandler")]
			get {
				const string __id = "getRequestParameterSupported.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRequestParameterSupported' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setRequestParameterSupported", "(Ljava/lang/Boolean;)V", "GetSetRequestParameterSupported_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setRequestParameterSupported.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRequestUriParameterSupported;
#pragma warning disable 0169
		static Delegate GetGetRequestUriParameterSupportedHandler ()
		{
			if (cb_getRequestUriParameterSupported == null)
				cb_getRequestUriParameterSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestUriParameterSupported);
			return cb_getRequestUriParameterSupported;
		}

		static IntPtr n_GetRequestUriParameterSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestUriParameterSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestUriParameterSupported_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRequestUriParameterSupported_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRequestUriParameterSupported_Ljava_lang_Boolean_ == null)
				cb_setRequestUriParameterSupported_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestUriParameterSupported_Ljava_lang_Boolean_);
			return cb_setRequestUriParameterSupported_Ljava_lang_Boolean_;
		}

		static void n_SetRequestUriParameterSupported_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestUriParameterSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestUriParameterSupported = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_requestUriParameterSupported, JniHandleOwnership.DoNotTransfer);
			__this.RequestUriParameterSupported = requestUriParameterSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean RequestUriParameterSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRequestUriParameterSupported' and count(parameter)=0]"
			[Register ("getRequestUriParameterSupported", "()Ljava/lang/Boolean;", "GetGetRequestUriParameterSupportedHandler")]
			get {
				const string __id = "getRequestUriParameterSupported.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRequestUriParameterSupported' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setRequestUriParameterSupported", "(Ljava/lang/Boolean;)V", "GetSetRequestUriParameterSupported_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setRequestUriParameterSupported.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRequireRequestUriRegistration;
#pragma warning disable 0169
		static Delegate GetGetRequireRequestUriRegistrationHandler ()
		{
			if (cb_getRequireRequestUriRegistration == null)
				cb_getRequireRequestUriRegistration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequireRequestUriRegistration);
			return cb_getRequireRequestUriRegistration;
		}

		static IntPtr n_GetRequireRequestUriRegistration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequireRequestUriRegistration);
		}
#pragma warning restore 0169

		static Delegate cb_setRequireRequestUriRegistration_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRequireRequestUriRegistration_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRequireRequestUriRegistration_Ljava_lang_Boolean_ == null)
				cb_setRequireRequestUriRegistration_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequireRequestUriRegistration_Ljava_lang_Boolean_);
			return cb_setRequireRequestUriRegistration_Ljava_lang_Boolean_;
		}

		static void n_SetRequireRequestUriRegistration_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requireRequestUriRegistration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requireRequestUriRegistration = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_requireRequestUriRegistration, JniHandleOwnership.DoNotTransfer);
			__this.RequireRequestUriRegistration = requireRequestUriRegistration;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean RequireRequestUriRegistration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getRequireRequestUriRegistration' and count(parameter)=0]"
			[Register ("getRequireRequestUriRegistration", "()Ljava/lang/Boolean;", "GetGetRequireRequestUriRegistrationHandler")]
			get {
				const string __id = "getRequireRequestUriRegistration.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setRequireRequestUriRegistration' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setRequireRequestUriRegistration", "(Ljava/lang/Boolean;)V", "GetSetRequireRequestUriRegistration_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setRequireRequestUriRegistration.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getResponseModesSupported;
#pragma warning disable 0169
		static Delegate GetGetResponseModesSupportedHandler ()
		{
			if (cb_getResponseModesSupported == null)
				cb_getResponseModesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseModesSupported);
			return cb_getResponseModesSupported;
		}

		static IntPtr n_GetResponseModesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ResponseModesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseModesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetResponseModesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setResponseModesSupported_Ljava_util_List_ == null)
				cb_setResponseModesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseModesSupported_Ljava_util_List_);
			return cb_setResponseModesSupported_Ljava_util_List_;
		}

		static void n_SetResponseModesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseModesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseModesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_responseModesSupported, JniHandleOwnership.DoNotTransfer);
			__this.ResponseModesSupported = responseModesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ResponseModesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getResponseModesSupported' and count(parameter)=0]"
			[Register ("getResponseModesSupported", "()Ljava/util/List;", "GetGetResponseModesSupportedHandler")]
			get {
				const string __id = "getResponseModesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setResponseModesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setResponseModesSupported", "(Ljava/util/List;)V", "GetSetResponseModesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setResponseModesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getResponseTypesSupported;
#pragma warning disable 0169
		static Delegate GetGetResponseTypesSupportedHandler ()
		{
			if (cb_getResponseTypesSupported == null)
				cb_getResponseTypesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseTypesSupported);
			return cb_getResponseTypesSupported;
		}

		static IntPtr n_GetResponseTypesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ResponseTypesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseTypesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetResponseTypesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setResponseTypesSupported_Ljava_util_List_ == null)
				cb_setResponseTypesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseTypesSupported_Ljava_util_List_);
			return cb_setResponseTypesSupported_Ljava_util_List_;
		}

		static void n_SetResponseTypesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseTypesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseTypesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_responseTypesSupported, JniHandleOwnership.DoNotTransfer);
			__this.ResponseTypesSupported = responseTypesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ResponseTypesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getResponseTypesSupported' and count(parameter)=0]"
			[Register ("getResponseTypesSupported", "()Ljava/util/List;", "GetGetResponseTypesSupportedHandler")]
			get {
				const string __id = "getResponseTypesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setResponseTypesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setResponseTypesSupported", "(Ljava/util/List;)V", "GetSetResponseTypesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setResponseTypesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getScopesSupported;
#pragma warning disable 0169
		static Delegate GetGetScopesSupportedHandler ()
		{
			if (cb_getScopesSupported == null)
				cb_getScopesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopesSupported);
			return cb_getScopesSupported;
		}

		static IntPtr n_GetScopesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ScopesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setScopesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetScopesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setScopesSupported_Ljava_util_List_ == null)
				cb_setScopesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScopesSupported_Ljava_util_List_);
			return cb_setScopesSupported_Ljava_util_List_;
		}

		static void n_SetScopesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_scopesSupported, JniHandleOwnership.DoNotTransfer);
			__this.ScopesSupported = scopesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ScopesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getScopesSupported' and count(parameter)=0]"
			[Register ("getScopesSupported", "()Ljava/util/List;", "GetGetScopesSupportedHandler")]
			get {
				const string __id = "getScopesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setScopesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setScopesSupported", "(Ljava/util/List;)V", "GetSetScopesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setScopesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getServiceDocumentation;
#pragma warning disable 0169
		static Delegate GetGetServiceDocumentationHandler ()
		{
			if (cb_getServiceDocumentation == null)
				cb_getServiceDocumentation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceDocumentation);
			return cb_getServiceDocumentation;
		}

		static IntPtr n_GetServiceDocumentation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceDocumentation);
		}
#pragma warning restore 0169

		static Delegate cb_setServiceDocumentation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServiceDocumentation_Ljava_lang_String_Handler ()
		{
			if (cb_setServiceDocumentation_Ljava_lang_String_ == null)
				cb_setServiceDocumentation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetServiceDocumentation_Ljava_lang_String_);
			return cb_setServiceDocumentation_Ljava_lang_String_;
		}

		static void n_SetServiceDocumentation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serviceDocumentation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serviceDocumentation = JNIEnv.GetString (native_serviceDocumentation, JniHandleOwnership.DoNotTransfer);
			__this.ServiceDocumentation = serviceDocumentation;
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceDocumentation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getServiceDocumentation' and count(parameter)=0]"
			[Register ("getServiceDocumentation", "()Ljava/lang/String;", "GetGetServiceDocumentationHandler")]
			get {
				const string __id = "getServiceDocumentation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setServiceDocumentation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceDocumentation", "(Ljava/lang/String;)V", "GetSetServiceDocumentation_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServiceDocumentation.(Ljava/lang/String;)V";
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

		static Delegate cb_getSubjectTypesSupported;
#pragma warning disable 0169
		static Delegate GetGetSubjectTypesSupportedHandler ()
		{
			if (cb_getSubjectTypesSupported == null)
				cb_getSubjectTypesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubjectTypesSupported);
			return cb_getSubjectTypesSupported;
		}

		static IntPtr n_GetSubjectTypesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.SubjectTypesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setSubjectTypesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSubjectTypesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setSubjectTypesSupported_Ljava_util_List_ == null)
				cb_setSubjectTypesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubjectTypesSupported_Ljava_util_List_);
			return cb_setSubjectTypesSupported_Ljava_util_List_;
		}

		static void n_SetSubjectTypesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subjectTypesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subjectTypesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_subjectTypesSupported, JniHandleOwnership.DoNotTransfer);
			__this.SubjectTypesSupported = subjectTypesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> SubjectTypesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getSubjectTypesSupported' and count(parameter)=0]"
			[Register ("getSubjectTypesSupported", "()Ljava/util/List;", "GetGetSubjectTypesSupportedHandler")]
			get {
				const string __id = "getSubjectTypesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setSubjectTypesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setSubjectTypesSupported", "(Ljava/util/List;)V", "GetSetSubjectTypesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setSubjectTypesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getTenantRegionScope;
#pragma warning disable 0169
		static Delegate GetGetTenantRegionScopeHandler ()
		{
			if (cb_getTenantRegionScope == null)
				cb_getTenantRegionScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantRegionScope);
			return cb_getTenantRegionScope;
		}

		static IntPtr n_GetTenantRegionScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantRegionScope);
		}
#pragma warning restore 0169

		static Delegate cb_setTenantRegionScope_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTenantRegionScope_Ljava_lang_String_Handler ()
		{
			if (cb_setTenantRegionScope_Ljava_lang_String_ == null)
				cb_setTenantRegionScope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTenantRegionScope_Ljava_lang_String_);
			return cb_setTenantRegionScope_Ljava_lang_String_;
		}

		static void n_SetTenantRegionScope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tenantRegionScope)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tenantRegionScope = JNIEnv.GetString (native_tenantRegionScope, JniHandleOwnership.DoNotTransfer);
			__this.TenantRegionScope = tenantRegionScope;
		}
#pragma warning restore 0169

		public virtual unsafe string TenantRegionScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getTenantRegionScope' and count(parameter)=0]"
			[Register ("getTenantRegionScope", "()Ljava/lang/String;", "GetGetTenantRegionScopeHandler")]
			get {
				const string __id = "getTenantRegionScope.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setTenantRegionScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTenantRegionScope", "(Ljava/lang/String;)V", "GetSetTenantRegionScope_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTenantRegionScope.(Ljava/lang/String;)V";
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

		static Delegate cb_getTokenEndpoint;
#pragma warning disable 0169
		static Delegate GetGetTokenEndpointHandler ()
		{
			if (cb_getTokenEndpoint == null)
				cb_getTokenEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenEndpoint);
			return cb_getTokenEndpoint;
		}

		static IntPtr n_GetTokenEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenEndpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenEndpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenEndpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenEndpoint_Ljava_lang_String_ == null)
				cb_setTokenEndpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTokenEndpoint_Ljava_lang_String_);
			return cb_setTokenEndpoint_Ljava_lang_String_;
		}

		static void n_SetTokenEndpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenEndpoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenEndpoint = JNIEnv.GetString (native_tokenEndpoint, JniHandleOwnership.DoNotTransfer);
			__this.TokenEndpoint = tokenEndpoint;
		}
#pragma warning restore 0169

		public virtual unsafe string TokenEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getTokenEndpoint' and count(parameter)=0]"
			[Register ("getTokenEndpoint", "()Ljava/lang/String;", "GetGetTokenEndpointHandler")]
			get {
				const string __id = "getTokenEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setTokenEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenEndpoint", "(Ljava/lang/String;)V", "GetSetTokenEndpoint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTokenEndpoint.(Ljava/lang/String;)V";
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

		static Delegate cb_getTokenEndpointAuthMethodsSupported;
#pragma warning disable 0169
		static Delegate GetGetTokenEndpointAuthMethodsSupportedHandler ()
		{
			if (cb_getTokenEndpointAuthMethodsSupported == null)
				cb_getTokenEndpointAuthMethodsSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenEndpointAuthMethodsSupported);
			return cb_getTokenEndpointAuthMethodsSupported;
		}

		static IntPtr n_GetTokenEndpointAuthMethodsSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TokenEndpointAuthMethodsSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenEndpointAuthMethodsSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTokenEndpointAuthMethodsSupported_Ljava_util_List_Handler ()
		{
			if (cb_setTokenEndpointAuthMethodsSupported_Ljava_util_List_ == null)
				cb_setTokenEndpointAuthMethodsSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTokenEndpointAuthMethodsSupported_Ljava_util_List_);
			return cb_setTokenEndpointAuthMethodsSupported_Ljava_util_List_;
		}

		static void n_SetTokenEndpointAuthMethodsSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenEndpointAuthMethodsSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenEndpointAuthMethodsSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_tokenEndpointAuthMethodsSupported, JniHandleOwnership.DoNotTransfer);
			__this.TokenEndpointAuthMethodsSupported = tokenEndpointAuthMethodsSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> TokenEndpointAuthMethodsSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getTokenEndpointAuthMethodsSupported' and count(parameter)=0]"
			[Register ("getTokenEndpointAuthMethodsSupported", "()Ljava/util/List;", "GetGetTokenEndpointAuthMethodsSupportedHandler")]
			get {
				const string __id = "getTokenEndpointAuthMethodsSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setTokenEndpointAuthMethodsSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setTokenEndpointAuthMethodsSupported", "(Ljava/util/List;)V", "GetSetTokenEndpointAuthMethodsSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setTokenEndpointAuthMethodsSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getTokenEndpointAuthSigningAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetTokenEndpointAuthSigningAlgValuesSupportedHandler ()
		{
			if (cb_getTokenEndpointAuthSigningAlgValuesSupported == null)
				cb_getTokenEndpointAuthSigningAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenEndpointAuthSigningAlgValuesSupported);
			return cb_getTokenEndpointAuthSigningAlgValuesSupported;
		}

		static IntPtr n_GetTokenEndpointAuthSigningAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TokenEndpointAuthSigningAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_ == null)
				cb_setTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_);
			return cb_setTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenEndpointAuthSigningAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenEndpointAuthSigningAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_tokenEndpointAuthSigningAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.TokenEndpointAuthSigningAlgValuesSupported = tokenEndpointAuthSigningAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> TokenEndpointAuthSigningAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getTokenEndpointAuthSigningAlgValuesSupported' and count(parameter)=0]"
			[Register ("getTokenEndpointAuthSigningAlgValuesSupported", "()Ljava/util/List;", "GetGetTokenEndpointAuthSigningAlgValuesSupportedHandler")]
			get {
				const string __id = "getTokenEndpointAuthSigningAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setTokenEndpointAuthSigningAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setTokenEndpointAuthSigningAlgValuesSupported", "(Ljava/util/List;)V", "GetSetTokenEndpointAuthSigningAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setTokenEndpointAuthSigningAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getUiLocalesSupported;
#pragma warning disable 0169
		static Delegate GetGetUiLocalesSupportedHandler ()
		{
			if (cb_getUiLocalesSupported == null)
				cb_getUiLocalesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUiLocalesSupported);
			return cb_getUiLocalesSupported;
		}

		static IntPtr n_GetUiLocalesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UiLocalesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setUiLocalesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUiLocalesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setUiLocalesSupported_Ljava_util_List_ == null)
				cb_setUiLocalesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUiLocalesSupported_Ljava_util_List_);
			return cb_setUiLocalesSupported_Ljava_util_List_;
		}

		static void n_SetUiLocalesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uiLocalesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uiLocalesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_uiLocalesSupported, JniHandleOwnership.DoNotTransfer);
			__this.UiLocalesSupported = uiLocalesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> UiLocalesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getUiLocalesSupported' and count(parameter)=0]"
			[Register ("getUiLocalesSupported", "()Ljava/util/List;", "GetGetUiLocalesSupportedHandler")]
			get {
				const string __id = "getUiLocalesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setUiLocalesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setUiLocalesSupported", "(Ljava/util/List;)V", "GetSetUiLocalesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setUiLocalesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getUserInfoEncryptionAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetUserInfoEncryptionAlgValuesSupportedHandler ()
		{
			if (cb_getUserInfoEncryptionAlgValuesSupported == null)
				cb_getUserInfoEncryptionAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserInfoEncryptionAlgValuesSupported);
			return cb_getUserInfoEncryptionAlgValuesSupported;
		}

		static IntPtr n_GetUserInfoEncryptionAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UserInfoEncryptionAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfoEncryptionAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUserInfoEncryptionAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setUserInfoEncryptionAlgValuesSupported_Ljava_util_List_ == null)
				cb_setUserInfoEncryptionAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserInfoEncryptionAlgValuesSupported_Ljava_util_List_);
			return cb_setUserInfoEncryptionAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetUserInfoEncryptionAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userInfoEncryptionAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userInfoEncryptionAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_userInfoEncryptionAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.UserInfoEncryptionAlgValuesSupported = userInfoEncryptionAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> UserInfoEncryptionAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getUserInfoEncryptionAlgValuesSupported' and count(parameter)=0]"
			[Register ("getUserInfoEncryptionAlgValuesSupported", "()Ljava/util/List;", "GetGetUserInfoEncryptionAlgValuesSupportedHandler")]
			get {
				const string __id = "getUserInfoEncryptionAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setUserInfoEncryptionAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setUserInfoEncryptionAlgValuesSupported", "(Ljava/util/List;)V", "GetSetUserInfoEncryptionAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setUserInfoEncryptionAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getUserInfoEncryptionEncValueSupported;
#pragma warning disable 0169
		static Delegate GetGetUserInfoEncryptionEncValueSupportedHandler ()
		{
			if (cb_getUserInfoEncryptionEncValueSupported == null)
				cb_getUserInfoEncryptionEncValueSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserInfoEncryptionEncValueSupported);
			return cb_getUserInfoEncryptionEncValueSupported;
		}

		static IntPtr n_GetUserInfoEncryptionEncValueSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UserInfoEncryptionEncValueSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfoEncryptionEncValueSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUserInfoEncryptionEncValueSupported_Ljava_util_List_Handler ()
		{
			if (cb_setUserInfoEncryptionEncValueSupported_Ljava_util_List_ == null)
				cb_setUserInfoEncryptionEncValueSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserInfoEncryptionEncValueSupported_Ljava_util_List_);
			return cb_setUserInfoEncryptionEncValueSupported_Ljava_util_List_;
		}

		static void n_SetUserInfoEncryptionEncValueSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userInfoEncryptionEncValueSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userInfoEncryptionEncValueSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_userInfoEncryptionEncValueSupported, JniHandleOwnership.DoNotTransfer);
			__this.UserInfoEncryptionEncValueSupported = userInfoEncryptionEncValueSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> UserInfoEncryptionEncValueSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getUserInfoEncryptionEncValueSupported' and count(parameter)=0]"
			[Register ("getUserInfoEncryptionEncValueSupported", "()Ljava/util/List;", "GetGetUserInfoEncryptionEncValueSupportedHandler")]
			get {
				const string __id = "getUserInfoEncryptionEncValueSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setUserInfoEncryptionEncValueSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setUserInfoEncryptionEncValueSupported", "(Ljava/util/List;)V", "GetSetUserInfoEncryptionEncValueSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setUserInfoEncryptionEncValueSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

		static Delegate cb_getUserInfoEndpoint;
#pragma warning disable 0169
		static Delegate GetGetUserInfoEndpointHandler ()
		{
			if (cb_getUserInfoEndpoint == null)
				cb_getUserInfoEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserInfoEndpoint);
			return cb_getUserInfoEndpoint;
		}

		static IntPtr n_GetUserInfoEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserInfoEndpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfoEndpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserInfoEndpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setUserInfoEndpoint_Ljava_lang_String_ == null)
				cb_setUserInfoEndpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserInfoEndpoint_Ljava_lang_String_);
			return cb_setUserInfoEndpoint_Ljava_lang_String_;
		}

		static void n_SetUserInfoEndpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userInfoEndpoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userInfoEndpoint = JNIEnv.GetString (native_userInfoEndpoint, JniHandleOwnership.DoNotTransfer);
			__this.UserInfoEndpoint = userInfoEndpoint;
		}
#pragma warning restore 0169

		public virtual unsafe string UserInfoEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getUserInfoEndpoint' and count(parameter)=0]"
			[Register ("getUserInfoEndpoint", "()Ljava/lang/String;", "GetGetUserInfoEndpointHandler")]
			get {
				const string __id = "getUserInfoEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setUserInfoEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserInfoEndpoint", "(Ljava/lang/String;)V", "GetSetUserInfoEndpoint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUserInfoEndpoint.(Ljava/lang/String;)V";
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

		static Delegate cb_getUserInfoSigningAlgValuesSupported;
#pragma warning disable 0169
		static Delegate GetGetUserInfoSigningAlgValuesSupportedHandler ()
		{
			if (cb_getUserInfoSigningAlgValuesSupported == null)
				cb_getUserInfoSigningAlgValuesSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserInfoSigningAlgValuesSupported);
			return cb_getUserInfoSigningAlgValuesSupported;
		}

		static IntPtr n_GetUserInfoSigningAlgValuesSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UserInfoSigningAlgValuesSupported);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfoSigningAlgValuesSupported_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUserInfoSigningAlgValuesSupported_Ljava_util_List_Handler ()
		{
			if (cb_setUserInfoSigningAlgValuesSupported_Ljava_util_List_ == null)
				cb_setUserInfoSigningAlgValuesSupported_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserInfoSigningAlgValuesSupported_Ljava_util_List_);
			return cb_setUserInfoSigningAlgValuesSupported_Ljava_util_List_;
		}

		static void n_SetUserInfoSigningAlgValuesSupported_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userInfoSigningAlgValuesSupported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userInfoSigningAlgValuesSupported = global::Android.Runtime.JavaList<string>.FromJniHandle (native_userInfoSigningAlgValuesSupported, JniHandleOwnership.DoNotTransfer);
			__this.UserInfoSigningAlgValuesSupported = userInfoSigningAlgValuesSupported;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> UserInfoSigningAlgValuesSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='getUserInfoSigningAlgValuesSupported' and count(parameter)=0]"
			[Register ("getUserInfoSigningAlgValuesSupported", "()Ljava/util/List;", "GetGetUserInfoSigningAlgValuesSupportedHandler")]
			get {
				const string __id = "getUserInfoSigningAlgValuesSupported.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfiguration']/method[@name='setUserInfoSigningAlgValuesSupported' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setUserInfoSigningAlgValuesSupported", "(Ljava/util/List;)V", "GetSetUserInfoSigningAlgValuesSupported_Ljava_util_List_Handler")]
			set {
				const string __id = "setUserInfoSigningAlgValuesSupported.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
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

	}
}
