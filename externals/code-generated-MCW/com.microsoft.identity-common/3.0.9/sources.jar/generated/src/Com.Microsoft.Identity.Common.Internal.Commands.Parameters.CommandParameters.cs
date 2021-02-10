using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands.Parameters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/parameters/CommandParameters", DoNotGenerateAcw=true)]
	public partial class CommandParameters : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/parameters/CommandParameters", typeof (CommandParameters));

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

		protected CommandParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAndroidApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetAndroidApplicationContextHandler ()
		{
			if (cb_getAndroidApplicationContext == null)
				cb_getAndroidApplicationContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAndroidApplicationContext);
			return cb_getAndroidApplicationContext;
		}

		static IntPtr n_GetAndroidApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AndroidApplicationContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context AndroidApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getAndroidApplicationContext' and count(parameter)=0]"
			[Register ("getAndroidApplicationContext", "()Landroid/content/Context;", "GetGetAndroidApplicationContextHandler")]
			get {
				const string __id = "getAndroidApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationName;
#pragma warning disable 0169
		static Delegate GetGetApplicationNameHandler ()
		{
			if (cb_getApplicationName == null)
				cb_getApplicationName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApplicationName);
			return cb_getApplicationName;
		}

		static IntPtr n_GetApplicationName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationName);
		}
#pragma warning restore 0169

		public virtual unsafe string ApplicationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getApplicationName' and count(parameter)=0]"
			[Register ("getApplicationName", "()Ljava/lang/String;", "GetGetApplicationNameHandler")]
			get {
				const string __id = "getApplicationName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationVersion;
#pragma warning disable 0169
		static Delegate GetGetApplicationVersionHandler ()
		{
			if (cb_getApplicationVersion == null)
				cb_getApplicationVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApplicationVersion);
			return cb_getApplicationVersion;
		}

		static IntPtr n_GetApplicationVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string ApplicationVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getApplicationVersion' and count(parameter)=0]"
			[Register ("getApplicationVersion", "()Ljava/lang/String;", "GetGetApplicationVersionHandler")]
			get {
				const string __id = "getApplicationVersion.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		static Delegate cb_setCorrelationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCorrelationId_Ljava_lang_String_Handler ()
		{
			if (cb_setCorrelationId_Ljava_lang_String_ == null)
				cb_setCorrelationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCorrelationId_Ljava_lang_String_);
			return cb_setCorrelationId_Ljava_lang_String_;
		}

		static void n_SetCorrelationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
			__this.CorrelationId = correlationId;
		}
#pragma warning restore 0169

		public virtual unsafe string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getCorrelationId' and count(parameter)=0]"
			[Register ("getCorrelationId", "()Ljava/lang/String;", "GetGetCorrelationIdHandler")]
			get {
				const string __id = "getCorrelationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='setCorrelationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCorrelationId", "(Ljava/lang/String;)V", "GetSetCorrelationId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCorrelationId.(Ljava/lang/String;)V";
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

		static Delegate cb_isPowerOptCheckEnabled;
#pragma warning disable 0169
		static Delegate GetIsPowerOptCheckEnabledHandler ()
		{
			if (cb_isPowerOptCheckEnabled == null)
				cb_isPowerOptCheckEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPowerOptCheckEnabled);
			return cb_isPowerOptCheckEnabled;
		}

		static bool n_IsPowerOptCheckEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPowerOptCheckEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPowerOptCheckEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='isPowerOptCheckEnabled' and count(parameter)=0]"
			[Register ("isPowerOptCheckEnabled", "()Z", "GetIsPowerOptCheckEnabledHandler")]
			get {
				const string __id = "isPowerOptCheckEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSharedDevice;
#pragma warning disable 0169
		static Delegate GetIsSharedDeviceHandler ()
		{
			if (cb_isSharedDevice == null)
				cb_isSharedDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSharedDevice);
			return cb_isSharedDevice;
		}

		static bool n_IsSharedDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSharedDevice;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSharedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='isSharedDevice' and count(parameter)=0]"
			[Register ("isSharedDevice", "()Z", "GetIsSharedDeviceHandler")]
			get {
				const string __id = "isSharedDevice.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOAuth2TokenCache;
#pragma warning disable 0169
		static Delegate GetGetOAuth2TokenCacheHandler ()
		{
			if (cb_getOAuth2TokenCache == null)
				cb_getOAuth2TokenCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOAuth2TokenCache);
			return cb_getOAuth2TokenCache;
		}

		static IntPtr n_GetOAuth2TokenCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OAuth2TokenCache);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache OAuth2TokenCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getOAuth2TokenCache' and count(parameter)=0]"
			[Register ("getOAuth2TokenCache", "()Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;", "GetGetOAuth2TokenCacheHandler")]
			get {
				const string __id = "getOAuth2TokenCache.()Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				const string __id = "getRedirectUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequiredBrokerProtocolVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string RequiredBrokerProtocolVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getRequiredBrokerProtocolVersion' and count(parameter)=0]"
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

		static Delegate cb_getSdkType;
#pragma warning disable 0169
		static Delegate GetGetSdkTypeHandler ()
		{
			if (cb_getSdkType == null)
				cb_getSdkType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSdkType);
			return cb_getSdkType;
		}

		static IntPtr n_GetSdkType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SdkType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Request.SdkType SdkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getSdkType' and count(parameter)=0]"
			[Register ("getSdkType", "()Lcom/microsoft/identity/common/internal/request/SdkType;", "GetGetSdkTypeHandler")]
			get {
				const string __id = "getSdkType.()Lcom/microsoft/identity/common/internal/request/SdkType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetSdkVersionHandler ()
		{
			if (cb_getSdkVersion == null)
				cb_getSdkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSdkVersion);
			return cb_getSdkVersion;
		}

		static IntPtr n_GetSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				const string __id = "getSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canEqual_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCanEqual_Ljava_lang_Object_Handler ()
		{
			if (cb_canEqual_Ljava_lang_Object_ == null)
				cb_canEqual_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanEqual_Ljava_lang_Object_);
			return cb_canEqual_Ljava_lang_Object_;
		}

		static bool n_CanEqual_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanEqual (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='CommandParameters']/method[@name='canEqual' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("canEqual", "(Ljava/lang/Object;)Z", "GetCanEqual_Ljava_lang_Object_Handler")]
		protected virtual unsafe bool CanEqual (global::Java.Lang.Object other)
		{
			const string __id = "canEqual.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

	}
}
