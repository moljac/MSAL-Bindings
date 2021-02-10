using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/BaseController", DoNotGenerateAcw=true)]
	public abstract partial class BaseController : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/field[@name='DEFAULT_SCOPES']"
		[Register ("DEFAULT_SCOPES")]
		public static global::System.Collections.ICollection DefaultScopes {
			get {
				const string __id = "DEFAULT_SCOPES.Ljava/util/Set;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaSet.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/BaseController", typeof (BaseController));

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

		protected BaseController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/constructor[@name='BaseController' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseController () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe string DelimitedDefaultScopeString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getDelimitedDefaultScopeString' and count(parameter)=0]"
			[Register ("getDelimitedDefaultScopeString", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDelimitedDefaultScopeString.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_accessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
#pragma warning disable 0169
		static Delegate GetAccessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler ()
		{
			if (cb_accessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ == null)
				cb_accessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AccessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_);
			return cb_accessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
		}

		static bool n_AccessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AccessTokenIsNull (cacheRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='accessTokenIsNull' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheRecord']]"
		[Register ("accessTokenIsNull", "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)Z", "GetAccessTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler")]
		protected virtual unsafe bool AccessTokenIsNull (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord)
		{
			const string __id = "accessTokenIsNull.(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (cacheRecord);
			}
		}

		static Delegate cb_acquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler ()
		{
			if (cb_acquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ == null)
				cb_acquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_);
			return cb_acquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_;
		}

		static IntPtr n_AcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireDeviceCodeFlowToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='acquireDeviceCodeFlowToken' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResult'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters']]"
		[Register ("acquireDeviceCodeFlowToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireDeviceCodeFlowToken (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult p0, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters p1);

		static Delegate cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler ()
		{
			if (cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ == null)
				cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_);
			return cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
		}

		static IntPtr n_AcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='acquireToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
		[Register ("acquireToken", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireToken (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters p0);

		static Delegate cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler ()
		{
			if (cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ == null)
				cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_);
			return cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
		}

		static IntPtr n_AcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='acquireTokenSilent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
		[Register ("acquireTokenSilent", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireTokenSilent (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters p0);

		static Delegate cb_addDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetAddDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_Handler ()
		{
			if (cb_addDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_ == null)
				cb_addDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_);
			return cb_addDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_;
		}

		static IntPtr n_AddDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commandParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commandParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (native_commandParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AddDefaultScopes (commandParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='addDefaultScopes' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.TokenCommandParameters']]"
		[Register ("addDefaultScopes", "(Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;)Ljava/util/Set;", "GetAddDefaultScopes_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_Handler")]
		protected virtual unsafe global::System.Collections.Generic.ICollection<string> AddDefaultScopes (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters commandParameters)
		{
			const string __id = "addDefaultScopes.(Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commandParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commandParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (commandParameters);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanEqual (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='canEqual' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_completeAcquireToken_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCompleteAcquireToken_IILandroid_content_Intent_Handler ()
		{
			if (cb_completeAcquireToken_IILandroid_content_Intent_ == null)
				cb_completeAcquireToken_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_CompleteAcquireToken_IILandroid_content_Intent_);
			return cb_completeAcquireToken_IILandroid_content_Intent_;
		}

		static void n_CompleteAcquireToken_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CompleteAcquireToken (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='completeAcquireToken' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeAcquireToken", "(IILandroid/content/Intent;)V", "GetCompleteAcquireToken_IILandroid_content_Intent_Handler")]
		public abstract void CompleteAcquireToken (int p0, int p1, global::Android.Content.Intent p2);

		static Delegate cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_;
#pragma warning disable 0169
		static Delegate GetDeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler ()
		{
			if (cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ == null)
				cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_);
			return cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_;
		}

		static IntPtr n_DeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeviceCodeFlowAuthRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='deviceCodeFlowAuthRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters']]"
		[Register ("deviceCodeFlowAuthRequest", "(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;", "GetDeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult DeviceCodeFlowAuthRequest (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters p0);

		static Delegate cb_finalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
#pragma warning disable 0169
		static Delegate GetFinalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler ()
		{
			if (cb_finalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ == null)
				cb_finalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FinalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_);
			return cb_finalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
		}

		static IntPtr n_FinalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecord, IntPtr native_scheme)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			var scheme = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_scheme, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FinalizeCacheRecordForResult (cacheRecord, scheme));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='finalizeCacheRecordForResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheRecord'] and parameter[2][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("finalizeCacheRecordForResult", "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetFinalizeCacheRecordForResult_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord FinalizeCacheRecordForResult (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme scheme)
		{
			const string __id = "finalizeCacheRecordForResult.(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				__args [1] = new JniArgumentValue ((scheme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheme).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cacheRecord);
				global::System.GC.KeepAlive (scheme);
			}
		}

		static Delegate cb_generateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Handler ()
		{
			if (cb_generateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_ == null)
				cb_generateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_);
			return cb_generateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_;
		}

		static IntPtr n_GenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateSignedHttpRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.GenerateShrCommandParameters']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters p0);

		static Delegate cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static IntPtr n_GetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetAccounts (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getAccounts", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;", "GetGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccounts (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters p0);

		static Delegate cb_getAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_Handler ()
		{
			if (cb_getAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_ == null)
				cb_getAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_);
			return cb_getAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_;
		}

		static IntPtr n_GetAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthorizationRequest (strategy, parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getAuthorizationRequest' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.TokenCommandParameters']]"
		[Register ("getAuthorizationRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;", "GetGetAuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_commands_parameters_TokenCommandParameters_Handler")]
		protected virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest GetAuthorizationRequest (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy strategy, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters parameters)
		{
			const string __id = "getAuthorizationRequest.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler ()
		{
			if (cb_getCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ == null)
				cb_getCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_);
			return cb_getCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
		}

		static IntPtr n_GetCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCachedAccountRecord (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getCachedAccountRecord' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
		[Register ("getCachedAccountRecord", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetCachedAccountRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler")]
		protected virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetCachedAccountRecord (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters parameters)
		{
			const string __id = "getCachedAccountRecord.(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_getCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_getCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_getCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static IntPtr n_GetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetCurrentAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getCurrentAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;", "GetGetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetCurrentAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters p0);

		static Delegate cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_GetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static bool n_GetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetDeviceMode (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getDeviceMode' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getDeviceMode", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Z", "GetGetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public abstract bool GetDeviceMode (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters p0);

		static Delegate cb_idTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_;
#pragma warning disable 0169
		static Delegate GetIdTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_Handler ()
		{
			if (cb_idTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_ == null)
				cb_idTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IdTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_);
			return cb_idTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_;
		}

		static bool n_IdTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecord, IntPtr native_sdkType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			var sdkType = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (native_sdkType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IdTokenIsNull (cacheRecord, sdkType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='idTokenIsNull' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheRecord'] and parameter[2][@type='com.microsoft.identity.common.internal.request.SdkType']]"
		[Register ("idTokenIsNull", "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Lcom/microsoft/identity/common/internal/request/SdkType;)Z", "GetIdTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Lcom_microsoft_identity_common_internal_request_SdkType_Handler")]
		protected virtual unsafe bool IdTokenIsNull (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord, global::Com.Microsoft.Identity.Common.Internal.Request.SdkType sdkType)
		{
			const string __id = "idTokenIsNull.(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Lcom/microsoft/identity/common/internal/request/SdkType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				__args [1] = new JniArgumentValue ((sdkType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdkType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (cacheRecord);
				global::System.GC.KeepAlive (sdkType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='initializeAuthorizationRequestBuilder' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest.Builder'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.TokenCommandParameters']]"
		[Register ("initializeAuthorizationRequestBuilder", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "")]
		protected unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder InitializeAuthorizationRequestBuilder (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder builder, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters parameters)
		{
			const string __id = "initializeAuthorizationRequestBuilder.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (builder);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_isRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_;
#pragma warning disable 0169
		static Delegate GetIsRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_Handler ()
		{
			if (cb_isRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_ == null)
				cb_isRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IsRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_);
			return cb_isRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_;
		}

		static bool n_IsRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestAuthority, IntPtr native_accessTokenRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestAuthority = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (native_requestAuthority, JniHandleOwnership.DoNotTransfer);
			var accessTokenRecord = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (native_accessTokenRecord, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRequestAuthorityRealmSameAsATRealm (requestAuthority, accessTokenRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='isRequestAuthorityRealmSameAsATRealm' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.authorities.Authority'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccessTokenRecord']]"
		[Register ("isRequestAuthorityRealmSameAsATRealm", "(Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;)Z", "GetIsRequestAuthorityRealmSameAsATRealm_Lcom_microsoft_identity_common_internal_authorities_Authority_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_Handler")]
		protected virtual unsafe bool IsRequestAuthorityRealmSameAsATRealm (global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority requestAuthority, global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord accessTokenRecord)
		{
			const string __id = "isRequestAuthorityRealmSameAsATRealm.(Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((requestAuthority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestAuthority).Handle);
				__args [1] = new JniArgumentValue ((accessTokenRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accessTokenRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (requestAuthority);
				global::System.GC.KeepAlive (accessTokenRecord);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='logExposedFieldsOfObject' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("logExposedFieldsOfObject", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		protected static unsafe void LogExposedFieldsOfObject (string tag, global::Java.Lang.Object @object)
		{
			const string __id = "logExposedFieldsOfObject.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (@object);
			}
		}

		static Delegate cb_logParameters_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLogParameters_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_logParameters_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_logParameters_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_LogParameters_Ljava_lang_String_Ljava_lang_Object_);
			return cb_logParameters_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_LogParameters_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_parameters, JniHandleOwnership.DoNotTransfer);
			__this.LogParameters (tag, parameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='logParameters' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("logParameters", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetLogParameters_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void LogParameters (string tag, global::Java.Lang.Object parameters)
		{
			const string __id = "logParameters.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (parameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='logResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.IResult']]"
		[Register ("logResult", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/providers/oauth2/IResult;)V", "")]
		public static unsafe void LogResult (string tag, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResult result)
		{
			const string __id = "logResult.(Ljava/lang/String;Lcom/microsoft/identity/common/internal/providers/oauth2/IResult;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (result);
			}
		}

		static Delegate cb_performSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetPerformSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler ()
		{
			if (cb_performSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ == null)
				cb_performSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_PerformSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_);
			return cb_performSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
		}

		static IntPtr n_PerformSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy, IntPtr native_refreshToken, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			var refreshToken = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformSilentTokenRequest (strategy, refreshToken, parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='performSilentTokenRequest' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.RefreshTokenRecord'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
		[Register ("performSilentTokenRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;", "GetPerformSilentTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler")]
		protected virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult PerformSilentTokenRequest (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy strategy, global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord refreshToken, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters parameters)
		{
			const string __id = "performSilentTokenRequest.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [1] = new JniArgumentValue ((refreshToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshToken).Handle);
				__args [2] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (refreshToken);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_performTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetPerformTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler ()
		{
			if (cb_performTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ == null)
				cb_performTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_PerformTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_);
			return cb_performTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
		}

		static IntPtr n_PerformTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy, IntPtr native_request, IntPtr native_response, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			var response = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformTokenRequest (strategy, request, response, parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='performTokenRequest' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest'] and parameter[3][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResponse'] and parameter[4][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
		[Register ("performTokenRequest", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;", "GetPerformTokenRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResponse_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler")]
		protected virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult PerformTokenRequest (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy strategy, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest request, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResponse response, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters)
		{
			const string __id = "performTokenRequest.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResponse;Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [2] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [3] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (request);
				global::System.GC.KeepAlive (response);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_refreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
#pragma warning disable 0169
		static Delegate GetRefreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler ()
		{
			if (cb_refreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ == null)
				cb_refreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RefreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_);
			return cb_refreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
		}

		static bool n_RefreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RefreshTokenIsNull (cacheRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='refreshTokenIsNull' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheRecord']]"
		[Register ("refreshTokenIsNull", "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)Z", "GetRefreshTokenIsNull_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler")]
		protected virtual unsafe bool RefreshTokenIsNull (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord)
		{
			const string __id = "refreshTokenIsNull.(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (cacheRecord);
			}
		}

		static Delegate cb_removeAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ == null)
				cb_removeAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_);
			return cb_removeAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_;
		}

		static bool n_RemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler")]
		public abstract bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters p0);

		static Delegate cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_;
#pragma warning disable 0169
		static Delegate GetRemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler ()
		{
			if (cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ == null)
				cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_);
			return cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_;
		}

		static bool n_RemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCurrentAccount (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='removeCurrentAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters']]"
		[Register ("removeCurrentAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z", "GetRemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler")]
		public abstract bool RemoveCurrentAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters p0);

		static Delegate cb_renewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
#pragma warning disable 0169
		static Delegate GetRenewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler ()
		{
			if (cb_renewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ == null)
				cb_renewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_RenewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_);
			return cb_renewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_;
		}

		static void n_RenewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_acquireTokenSilentResult, IntPtr native_tokenCache, IntPtr native_strategy, IntPtr native_cacheRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var acquireTokenSilentResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (native_acquireTokenSilentResult, JniHandleOwnership.DoNotTransfer);
			var tokenCache = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (native_tokenCache, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			__this.RenewAccessToken (parameters, acquireTokenSilentResult, tokenCache, strategy, cacheRecord);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='renewAccessToken' and count(parameter)=5 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters'] and parameter[2][@type='com.microsoft.identity.common.internal.result.AcquireTokenResult'] and parameter[3][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[4][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy'] and parameter[5][@type='com.microsoft.identity.common.internal.cache.ICacheRecord']]"
		[Register ("renewAccessToken", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)V", "GetRenewAccessToken_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_cache_ICacheRecord_Handler")]
		protected virtual unsafe void RenewAccessToken (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters parameters, global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult acquireTokenSilentResult, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy strategy, global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord)
		{
			const string __id = "renewAccessToken.(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/cache/ICacheRecord;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue ((acquireTokenSilentResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenSilentResult).Handle);
				__args [2] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				__args [3] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [4] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parameters);
				global::System.GC.KeepAlive (acquireTokenSilentResult);
				global::System.GC.KeepAlive (tokenCache);
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (cacheRecord);
			}
		}

		static Delegate cb_saveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_;
#pragma warning disable 0169
		static Delegate GetSaveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Handler ()
		{
			if (cb_saveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_ == null)
				cb_saveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_SaveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_);
			return cb_saveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_;
		}

		static IntPtr n_SaveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy, IntPtr native_request, IntPtr native_tokenResponse, IntPtr native_tokenCache)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			var tokenResponse = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (native_tokenResponse, JniHandleOwnership.DoNotTransfer);
			var tokenCache = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (native_tokenCache, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.SaveTokens (strategy, request, tokenResponse, tokenCache));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='saveTokens' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest'] and parameter[3][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResponse'] and parameter[4][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache']]"
		[Register ("saveTokens", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;)Ljava/util/List;", "GetSaveTokens_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2TokenCache_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> SaveTokens (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy strategy, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest request, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse tokenResponse, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache)
		{
			const string __id = "saveTokens.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [2] = new JniArgumentValue ((tokenResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenResponse).Handle);
				__args [3] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (request);
				global::System.GC.KeepAlive (tokenResponse);
				global::System.GC.KeepAlive (tokenCache);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/BaseController", DoNotGenerateAcw=true)]
	internal partial class BaseControllerInvoker : BaseController {
		public BaseControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/BaseController", typeof (BaseControllerInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='acquireDeviceCodeFlowToken' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResult'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters']]"
		[Register ("acquireDeviceCodeFlowToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireDeviceCodeFlowToken (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult p0, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters p1)
		{
			const string __id = "acquireDeviceCodeFlowToken.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='acquireToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
		[Register ("acquireToken", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireToken (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters p0)
		{
			const string __id = "acquireToken.(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='acquireTokenSilent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
		[Register ("acquireTokenSilent", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireTokenSilent (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters p0)
		{
			const string __id = "acquireTokenSilent.(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='completeAcquireToken' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeAcquireToken", "(IILandroid/content/Intent;)V", "GetCompleteAcquireToken_IILandroid_content_Intent_Handler")]
		public override unsafe void CompleteAcquireToken (int p0, int p1, global::Android.Content.Intent p2)
		{
			const string __id = "completeAcquireToken.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='deviceCodeFlowAuthRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters']]"
		[Register ("deviceCodeFlowAuthRequest", "(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;", "GetDeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult DeviceCodeFlowAuthRequest (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters p0)
		{
			const string __id = "deviceCodeFlowAuthRequest.(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.GenerateShrCommandParameters']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters p0)
		{
			const string __id = "generateSignedHttpRequest.(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getAccounts", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;", "GetGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccounts (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters p0)
		{
			const string __id = "getAccounts.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getCurrentAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;", "GetGetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetCurrentAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters p0)
		{
			const string __id = "getCurrentAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='getDeviceMode' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getDeviceMode", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Z", "GetGetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public override unsafe bool GetDeviceMode (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters p0)
		{
			const string __id = "getDeviceMode.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler")]
		public override unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters p0)
		{
			const string __id = "removeAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BaseController']/method[@name='removeCurrentAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters']]"
		[Register ("removeCurrentAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z", "GetRemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler")]
		public override unsafe bool RemoveCurrentAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters p0)
		{
			const string __id = "removeCurrentAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
