using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authorities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAuthority", DoNotGenerateAcw=true)]
	public partial class AzureActiveDirectoryAuthority : global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/field[@name='mAudience']"
		[Register ("mAudience")]
		public global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience MAudience {
			get {
				const string __id = "mAudience.Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAudience.Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/field[@name='mFlightParameters']"
		[Register ("mFlightParameters")]
		public global::System.Collections.IDictionary MFlightParameters {
			get {
				const string __id = "mFlightParameters.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFlightParameters.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/field[@name='mMultipleCloudsSupported']"
		[Register ("mMultipleCloudsSupported")]
		public bool MMultipleCloudsSupported {
			get {
				const string __id = "mMultipleCloudsSupported.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMultipleCloudsSupported.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAuthority", typeof (AzureActiveDirectoryAuthority));

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

		protected AzureActiveDirectoryAuthority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/constructor[@name='AzureActiveDirectoryAuthority' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AzureActiveDirectoryAuthority () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/constructor[@name='AzureActiveDirectoryAuthority' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.authorities.AzureActiveDirectoryAudience']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;)V", "")]
		public unsafe AzureActiveDirectoryAuthority (global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience signInAudience) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((signInAudience == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signInAudience).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (signInAudience);
			}
		}

		static Delegate cb_getAudience;
#pragma warning disable 0169
		static Delegate GetGetAudienceHandler ()
		{
			if (cb_getAudience == null)
				cb_getAudience = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudience);
			return cb_getAudience;
		}

		static IntPtr n_GetAudience (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Audience);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience Audience {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='getAudience' and count(parameter)=0]"
			[Register ("getAudience", "()Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;", "GetGetAudienceHandler")]
			get {
				const string __id = "getAudience.()Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorityURL);
		}
#pragma warning restore 0169

		public override unsafe global::Java.Net.URL AuthorityURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='getAuthorityURL' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorityUri);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Net.Uri AuthorityUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='getAuthorityUri' and count(parameter)=0]"
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

		static Delegate cb_getFlightParameters;
#pragma warning disable 0169
		static Delegate GetGetFlightParametersHandler ()
		{
			if (cb_getFlightParameters == null)
				cb_getFlightParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFlightParameters);
			return cb_getFlightParameters;
		}

		static IntPtr n_GetFlightParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.FlightParameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> FlightParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='getFlightParameters' and count(parameter)=0]"
			[Register ("getFlightParameters", "()Ljava/util/Map;", "GetGetFlightParametersHandler")]
			get {
				const string __id = "getFlightParameters.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMultipleCloudsSupported;
#pragma warning disable 0169
		static Delegate GetGetMultipleCloudsSupportedHandler ()
		{
			if (cb_getMultipleCloudsSupported == null)
				cb_getMultipleCloudsSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetMultipleCloudsSupported);
			return cb_getMultipleCloudsSupported;
		}

		static bool n_GetMultipleCloudsSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultipleCloudsSupported;
		}
#pragma warning restore 0169

		static Delegate cb_setMultipleCloudsSupported_Z;
#pragma warning disable 0169
		static Delegate GetSetMultipleCloudsSupported_ZHandler ()
		{
			if (cb_setMultipleCloudsSupported_Z == null)
				cb_setMultipleCloudsSupported_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMultipleCloudsSupported_Z);
			return cb_setMultipleCloudsSupported_Z;
		}

		static void n_SetMultipleCloudsSupported_Z (IntPtr jnienv, IntPtr native__this, bool supported)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MultipleCloudsSupported = supported;
		}
#pragma warning restore 0169

		public virtual unsafe bool MultipleCloudsSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='getMultipleCloudsSupported' and count(parameter)=0]"
			[Register ("getMultipleCloudsSupported", "()Z", "GetGetMultipleCloudsSupportedHandler")]
			get {
				const string __id = "getMultipleCloudsSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='setMultipleCloudsSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMultipleCloudsSupported", "(Z)V", "GetSetMultipleCloudsSupported_ZHandler")]
			set {
				const string __id = "setMultipleCloudsSupported.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOAuth2Strategy (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAuthority']/method[@name='createOAuth2Strategy' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2StrategyParameters']]"
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
