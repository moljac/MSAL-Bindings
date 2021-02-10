using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/PublicClientApplicationConfiguration", DoNotGenerateAcw=true)]
	public partial class PublicClientApplicationConfiguration : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/PublicClientApplicationConfiguration$SerializedNames", DoNotGenerateAcw=true)]
		public sealed partial class SerializedNames : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PublicClientApplicationConfiguration$SerializedNames", typeof (SerializedNames));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration.SerializedNames']/constructor[@name='PublicClientApplicationConfiguration.SerializedNames' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PublicClientApplicationConfiguration", typeof (PublicClientApplicationConfiguration));

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

		protected PublicClientApplicationConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/constructor[@name='PublicClientApplicationConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PublicClientApplicationConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAccountMode;
#pragma warning disable 0169
		static Delegate GetGetAccountModeHandler ()
		{
			if (cb_getAccountMode == null)
				cb_getAccountMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccountMode);
			return cb_getAccountMode;
		}

		static IntPtr n_GetAccountMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Configuration.AccountMode AccountMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getAccountMode' and count(parameter)=0]"
			[Register ("getAccountMode", "()Lcom/microsoft/identity/client/configuration/AccountMode;", "GetGetAccountModeHandler")]
			get {
				const string __id = "getAccountMode.()Lcom/microsoft/identity/client/configuration/AccountMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.AccountMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppContext;
#pragma warning disable 0169
		static Delegate GetGetAppContextHandler ()
		{
			if (cb_getAppContext == null)
				cb_getAppContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppContext);
			return cb_getAppContext;
		}

		static IntPtr n_GetAppContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context AppContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getAppContext' and count(parameter)=0]"
			[Register ("getAppContext", "()Landroid/content/Context;", "GetGetAppContextHandler")]
			get {
				const string __id = "getAppContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorities;
#pragma warning disable 0169
		static Delegate GetGetAuthoritiesHandler ()
		{
			if (cb_getAuthorities == null)
				cb_getAuthorities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorities);
			return cb_getAuthorities;
		}

		static IntPtr n_GetAuthorities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority>.ToLocalJniHandle (__this.Authorities);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> Authorities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getAuthorities' and count(parameter)=0]"
			[Register ("getAuthorities", "()Ljava/util/List;", "GetGetAuthoritiesHandler")]
			get {
				const string __id = "getAuthorities.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorizationAgent;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationAgentHandler ()
		{
			if (cb_getAuthorizationAgent == null)
				cb_getAuthorizationAgent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationAgent);
			return cb_getAuthorizationAgent;
		}

		static IntPtr n_GetAuthorizationAgent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationAgent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent AuthorizationAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getAuthorizationAgent' and count(parameter)=0]"
			[Register ("getAuthorizationAgent", "()Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;", "GetGetAuthorizationAgentHandler")]
			get {
				const string __id = "getAuthorizationAgent.()Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBrowserSafeList;
#pragma warning disable 0169
		static Delegate GetGetBrowserSafeListHandler ()
		{
			if (cb_getBrowserSafeList == null)
				cb_getBrowserSafeList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBrowserSafeList);
			return cb_getBrowserSafeList;
		}

		static IntPtr n_GetBrowserSafeList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.ToLocalJniHandle (__this.BrowserSafeList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor> BrowserSafeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getBrowserSafeList' and count(parameter)=0]"
			[Register ("getBrowserSafeList", "()Ljava/util/List;", "GetGetBrowserSafeListHandler")]
			get {
				const string __id = "getBrowserSafeList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientCapabilities;
#pragma warning disable 0169
		static Delegate GetGetClientCapabilitiesHandler ()
		{
			if (cb_getClientCapabilities == null)
				cb_getClientCapabilities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientCapabilities);
			return cb_getClientCapabilities;
		}

		static IntPtr n_GetClientCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientCapabilities);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getClientCapabilities' and count(parameter)=0]"
			[Register ("getClientCapabilities", "()Ljava/lang/String;", "GetGetClientCapabilitiesHandler")]
			get {
				const string __id = "getClientCapabilities.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientId_Ljava_lang_String_ == null)
				cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientId_Ljava_lang_String_);
			return cb_setClientId_Ljava_lang_String_;
		}

		static void n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = clientId;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientId", "(Ljava/lang/String;)V", "GetSetClientId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientId.(Ljava/lang/String;)V";
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

		static Delegate cb_getDefaultAuthority;
#pragma warning disable 0169
		static Delegate GetGetDefaultAuthorityHandler ()
		{
			if (cb_getDefaultAuthority == null)
				cb_getDefaultAuthority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultAuthority);
			return cb_getDefaultAuthority;
		}

		static IntPtr n_GetDefaultAuthority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultAuthority);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority DefaultAuthority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getDefaultAuthority' and count(parameter)=0]"
			[Register ("getDefaultAuthority", "()Lcom/microsoft/identity/common/internal/authorities/Authority;", "GetGetDefaultAuthorityHandler")]
			get {
				const string __id = "getDefaultAuthority.()Lcom/microsoft/identity/common/internal/authorities/Authority;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnvironment);
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Environment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.Environment Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Lcom/microsoft/identity/common/internal/authorities/Environment;", "GetGetEnvironmentHandler")]
			get {
				const string __id = "getEnvironment.()Lcom/microsoft/identity/common/internal/authorities/Environment;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Environment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpConfiguration;
#pragma warning disable 0169
		static Delegate GetGetHttpConfigurationHandler ()
		{
			if (cb_getHttpConfiguration == null)
				cb_getHttpConfiguration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpConfiguration);
			return cb_getHttpConfiguration;
		}

		static IntPtr n_GetHttpConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HttpConfiguration);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Configuration.HttpConfiguration HttpConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getHttpConfiguration' and count(parameter)=0]"
			[Register ("getHttpConfiguration", "()Lcom/microsoft/identity/client/configuration/HttpConfiguration;", "GetGetHttpConfigurationHandler")]
			get {
				const string __id = "getHttpConfiguration.()Lcom/microsoft/identity/client/configuration/HttpConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.HttpConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDefaultAuthorityConfigured;
#pragma warning disable 0169
		static Delegate GetIsDefaultAuthorityConfiguredHandler ()
		{
			if (cb_isDefaultAuthorityConfigured == null)
				cb_isDefaultAuthorityConfigured = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDefaultAuthorityConfigured);
			return cb_isDefaultAuthorityConfigured;
		}

		static bool n_IsDefaultAuthorityConfigured (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDefaultAuthorityConfigured;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDefaultAuthorityConfigured {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='isDefaultAuthorityConfigured' and count(parameter)=0]"
			[Register ("isDefaultAuthorityConfigured", "()Z", "GetIsDefaultAuthorityConfiguredHandler")]
			get {
				const string __id = "isDefaultAuthorityConfigured.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIsSharedDevice;
#pragma warning disable 0169
		static Delegate GetGetIsSharedDeviceHandler ()
		{
			if (cb_getIsSharedDevice == null)
				cb_getIsSharedDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetIsSharedDevice);
			return cb_getIsSharedDevice;
		}

		static bool n_GetIsSharedDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSharedDevice;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSharedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getIsSharedDevice' and count(parameter)=0]"
			[Register ("getIsSharedDevice", "()Z", "GetGetIsSharedDeviceHandler")]
			get {
				const string __id = "getIsSharedDevice.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLoggerConfiguration;
#pragma warning disable 0169
		static Delegate GetGetLoggerConfigurationHandler ()
		{
			if (cb_getLoggerConfiguration == null)
				cb_getLoggerConfiguration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoggerConfiguration);
			return cb_getLoggerConfiguration;
		}

		static IntPtr n_GetLoggerConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoggerConfiguration);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Configuration.LoggerConfiguration LoggerConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getLoggerConfiguration' and count(parameter)=0]"
			[Register ("getLoggerConfiguration", "()Lcom/microsoft/identity/client/configuration/LoggerConfiguration;", "GetGetLoggerConfigurationHandler")]
			get {
				const string __id = "getLoggerConfiguration.()Lcom/microsoft/identity/client/configuration/LoggerConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.LoggerConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMultipleCloudsSupported;
#pragma warning disable 0169
		static Delegate GetGetMultipleCloudsSupportedHandler ()
		{
			if (cb_getMultipleCloudsSupported == null)
				cb_getMultipleCloudsSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMultipleCloudsSupported);
			return cb_getMultipleCloudsSupported;
		}

		static IntPtr n_GetMultipleCloudsSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MultipleCloudsSupported);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean MultipleCloudsSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getMultipleCloudsSupported' and count(parameter)=0]"
			[Register ("getMultipleCloudsSupported", "()Ljava/lang/Boolean;", "GetGetMultipleCloudsSupportedHandler")]
			get {
				const string __id = "getMultipleCloudsSupported.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		static Delegate cb_setRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRedirectUri_Ljava_lang_String_Handler ()
		{
			if (cb_setRedirectUri_Ljava_lang_String_ == null)
				cb_setRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRedirectUri_Ljava_lang_String_);
			return cb_setRedirectUri_Ljava_lang_String_;
		}

		static void n_SetRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirectUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var redirectUri = JNIEnv.GetString (native_redirectUri, JniHandleOwnership.DoNotTransfer);
			__this.RedirectUri = redirectUri;
		}
#pragma warning restore 0169

		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				const string __id = "getRedirectUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUri", "(Ljava/lang/String;)V", "GetSetRedirectUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRedirectUri.(Ljava/lang/String;)V";
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

		static Delegate cb_getRequiredBrokerProtocolVersion;
#pragma warning disable 0169
		static Delegate GetGetRequiredBrokerProtocolVersionHandler ()
		{
			if (cb_getRequiredBrokerProtocolVersion == null)
				cb_getRequiredBrokerProtocolVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequiredBrokerProtocolVersion);
			return cb_getRequiredBrokerProtocolVersion;
		}

		static IntPtr n_GetRequiredBrokerProtocolVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequiredBrokerProtocolVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string RequiredBrokerProtocolVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getRequiredBrokerProtocolVersion' and count(parameter)=0]"
			[Register ("getRequiredBrokerProtocolVersion", "()Ljava/lang/String;", "GetGetRequiredBrokerProtocolVersionHandler")]
			get {
				const string __id = "getRequiredBrokerProtocolVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTelemetryConfiguration;
#pragma warning disable 0169
		static Delegate GetGetTelemetryConfigurationHandler ()
		{
			if (cb_getTelemetryConfiguration == null)
				cb_getTelemetryConfiguration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTelemetryConfiguration);
			return cb_getTelemetryConfiguration;
		}

		static IntPtr n_GetTelemetryConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TelemetryConfiguration);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration TelemetryConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getTelemetryConfiguration' and count(parameter)=0]"
			[Register ("getTelemetryConfiguration", "()Lcom/microsoft/identity/common/internal/telemetry/TelemetryConfiguration;", "GetGetTelemetryConfigurationHandler")]
			get {
				const string __id = "getTelemetryConfiguration.()Lcom/microsoft/identity/common/internal/telemetry/TelemetryConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUseBroker;
#pragma warning disable 0169
		static Delegate GetGetUseBrokerHandler ()
		{
			if (cb_getUseBroker == null)
				cb_getUseBroker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUseBroker);
			return cb_getUseBroker;
		}

		static IntPtr n_GetUseBroker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UseBroker);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean UseBroker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='getUseBroker' and count(parameter)=0]"
			[Register ("getUseBroker", "()Ljava/lang/Boolean;", "GetGetUseBrokerHandler")]
			get {
				const string __id = "getUseBroker.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isWebViewZoomControlsEnabled;
#pragma warning disable 0169
		static Delegate GetIsWebViewZoomControlsEnabledHandler ()
		{
			if (cb_isWebViewZoomControlsEnabled == null)
				cb_isWebViewZoomControlsEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWebViewZoomControlsEnabled);
			return cb_isWebViewZoomControlsEnabled;
		}

		static bool n_IsWebViewZoomControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebViewZoomControlsEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setWebViewZoomControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetWebViewZoomControlsEnabled_ZHandler ()
		{
			if (cb_setWebViewZoomControlsEnabled_Z == null)
				cb_setWebViewZoomControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetWebViewZoomControlsEnabled_Z);
			return cb_setWebViewZoomControlsEnabled_Z;
		}

		static void n_SetWebViewZoomControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool webViewZoomControlsEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebViewZoomControlsEnabled = webViewZoomControlsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool WebViewZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='isWebViewZoomControlsEnabled' and count(parameter)=0]"
			[Register ("isWebViewZoomControlsEnabled", "()Z", "GetIsWebViewZoomControlsEnabledHandler")]
			get {
				const string __id = "isWebViewZoomControlsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='setWebViewZoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWebViewZoomControlsEnabled", "(Z)V", "GetSetWebViewZoomControlsEnabled_ZHandler")]
			set {
				const string __id = "setWebViewZoomControlsEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isWebViewZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsWebViewZoomEnabledHandler ()
		{
			if (cb_isWebViewZoomEnabled == null)
				cb_isWebViewZoomEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWebViewZoomEnabled);
			return cb_isWebViewZoomEnabled;
		}

		static bool n_IsWebViewZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebViewZoomEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setWebViewZoomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetWebViewZoomEnabled_ZHandler ()
		{
			if (cb_setWebViewZoomEnabled_Z == null)
				cb_setWebViewZoomEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetWebViewZoomEnabled_Z);
			return cb_setWebViewZoomEnabled_Z;
		}

		static void n_SetWebViewZoomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool webViewZoomEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebViewZoomEnabled = webViewZoomEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool WebViewZoomEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='isWebViewZoomEnabled' and count(parameter)=0]"
			[Register ("isWebViewZoomEnabled", "()Z", "GetIsWebViewZoomEnabledHandler")]
			get {
				const string __id = "isWebViewZoomEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='setWebViewZoomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWebViewZoomEnabled", "(Z)V", "GetSetWebViewZoomEnabled_ZHandler")]
			set {
				const string __id = "setWebViewZoomEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkIntentFilterAddedToAppManifestForBrokerFlow;
#pragma warning disable 0169
		static Delegate GetCheckIntentFilterAddedToAppManifestForBrokerFlowHandler ()
		{
			if (cb_checkIntentFilterAddedToAppManifestForBrokerFlow == null)
				cb_checkIntentFilterAddedToAppManifestForBrokerFlow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CheckIntentFilterAddedToAppManifestForBrokerFlow);
			return cb_checkIntentFilterAddedToAppManifestForBrokerFlow;
		}

		static void n_CheckIntentFilterAddedToAppManifestForBrokerFlow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckIntentFilterAddedToAppManifestForBrokerFlow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='checkIntentFilterAddedToAppManifestForBrokerFlow' and count(parameter)=0]"
		[Register ("checkIntentFilterAddedToAppManifestForBrokerFlow", "()V", "GetCheckIntentFilterAddedToAppManifestForBrokerFlowHandler")]
		public virtual unsafe void CheckIntentFilterAddedToAppManifestForBrokerFlow ()
		{
			const string __id = "checkIntentFilterAddedToAppManifestForBrokerFlow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='isBrokerRedirectUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isBrokerRedirectUri", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsBrokerRedirectUri (string redirectUri, string packageName)
		{
			const string __id = "isBrokerRedirectUri.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_redirectUri);
				__args [1] = new JniArgumentValue (native_packageName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_redirectUri);
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_isPowerOptCheckForEnabled;
#pragma warning disable 0169
		static Delegate GetIsPowerOptCheckForEnabledHandler ()
		{
			if (cb_isPowerOptCheckForEnabled == null)
				cb_isPowerOptCheckForEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsPowerOptCheckForEnabled);
			return cb_isPowerOptCheckForEnabled;
		}

		static IntPtr n_IsPowerOptCheckForEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsPowerOptCheckForEnabled ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='isPowerOptCheckForEnabled' and count(parameter)=0]"
		[Register ("isPowerOptCheckForEnabled", "()Ljava/lang/Boolean;", "GetIsPowerOptCheckForEnabledHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsPowerOptCheckForEnabled ()
		{
			const string __id = "isPowerOptCheckForEnabled.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPowerOptCheckEnabled_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetPowerOptCheckEnabled_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setPowerOptCheckEnabled_Ljava_lang_Boolean_ == null)
				cb_setPowerOptCheckEnabled_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPowerOptCheckEnabled_Ljava_lang_Boolean_);
			return cb_setPowerOptCheckEnabled_Ljava_lang_Boolean_;
		}

		static void n_SetPowerOptCheckEnabled_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_powerOptCheckEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var powerOptCheckEnabled = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_powerOptCheckEnabled, JniHandleOwnership.DoNotTransfer);
			__this.SetPowerOptCheckEnabled (powerOptCheckEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='setPowerOptCheckEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setPowerOptCheckEnabled", "(Ljava/lang/Boolean;)V", "GetSetPowerOptCheckEnabled_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetPowerOptCheckEnabled (global::Java.Lang.Boolean powerOptCheckEnabled)
		{
			const string __id = "setPowerOptCheckEnabled.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((powerOptCheckEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) powerOptCheckEnabled).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (powerOptCheckEnabled);
			}
		}

		static Delegate cb_setTokenCacheSecretKeys_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTokenCacheSecretKeys_arrayBHandler ()
		{
			if (cb_setTokenCacheSecretKeys_arrayB == null)
				cb_setTokenCacheSecretKeys_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTokenCacheSecretKeys_arrayB);
			return cb_setTokenCacheSecretKeys_arrayB;
		}

		static void n_SetTokenCacheSecretKeys_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_rawKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rawKey = (byte[]) JNIEnv.GetArray (native_rawKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTokenCacheSecretKeys (rawKey);
			if (rawKey != null)
				JNIEnv.CopyArray (rawKey, native_rawKey);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfiguration']/method[@name='setTokenCacheSecretKeys' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setTokenCacheSecretKeys", "([B)V", "GetSetTokenCacheSecretKeys_arrayBHandler")]
		public virtual unsafe void SetTokenCacheSecretKeys (byte[] rawKey)
		{
			const string __id = "setTokenCacheSecretKeys.([B)V";
			IntPtr native_rawKey = JNIEnv.NewArray (rawKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawKey);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (rawKey != null) {
					JNIEnv.CopyArray (native_rawKey, rawKey);
					JNIEnv.DeleteLocalRef (native_rawKey);
				}
				global::System.GC.KeepAlive (rawKey);
			}
		}

	}
}
