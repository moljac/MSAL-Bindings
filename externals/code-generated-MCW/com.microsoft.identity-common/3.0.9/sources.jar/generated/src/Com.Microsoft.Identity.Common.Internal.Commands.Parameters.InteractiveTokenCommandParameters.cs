using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands.Parameters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters", DoNotGenerateAcw=true)]
	public partial class InteractiveTokenCommandParameters : global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters", typeof (InteractiveTokenCommandParameters));

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

		protected InteractiveTokenCommandParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationAgent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent AuthorizationAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getAuthorizationAgent' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.ToLocalJniHandle (__this.BrowserSafeList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor> BrowserSafeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getBrowserSafeList' and count(parameter)=0]"
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

		static Delegate cb_getExtraQueryStringParameters;
#pragma warning disable 0169
		static Delegate GetGetExtraQueryStringParametersHandler ()
		{
			if (cb_getExtraQueryStringParameters == null)
				cb_getExtraQueryStringParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtraQueryStringParameters);
			return cb_getExtraQueryStringParameters;
		}

		static IntPtr n_GetExtraQueryStringParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.ExtraQueryStringParameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> ExtraQueryStringParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getExtraQueryStringParameters' and count(parameter)=0]"
			[Register ("getExtraQueryStringParameters", "()Ljava/util/List;", "GetGetExtraQueryStringParametersHandler")]
			get {
				const string __id = "getExtraQueryStringParameters.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraScopesToConsent;
#pragma warning disable 0169
		static Delegate GetGetExtraScopesToConsentHandler ()
		{
			if (cb_getExtraScopesToConsent == null)
				cb_getExtraScopesToConsent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtraScopesToConsent);
			return cb_getExtraScopesToConsent;
		}

		static IntPtr n_GetExtraScopesToConsent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ExtraScopesToConsent);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ExtraScopesToConsent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getExtraScopesToConsent' and count(parameter)=0]"
			[Register ("getExtraScopesToConsent", "()Ljava/util/List;", "GetGetExtraScopesToConsentHandler")]
			get {
				const string __id = "getExtraScopesToConsent.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFragment;
#pragma warning disable 0169
		static Delegate GetGetFragmentHandler ()
		{
			if (cb_getFragment == null)
				cb_getFragment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFragment);
			return cb_getFragment;
		}

		static IntPtr n_GetFragment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fragment);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Fragment.App.Fragment Fragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getFragment' and count(parameter)=0]"
			[Register ("getFragment", "()Landroidx/fragment/app/Fragment;", "GetGetFragmentHandler")]
			get {
				const string __id = "getFragment.()Landroidx/fragment/app/Fragment;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Fragment.App.Fragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBrokerBrowserSupportEnabled;
#pragma warning disable 0169
		static Delegate GetIsBrokerBrowserSupportEnabledHandler ()
		{
			if (cb_isBrokerBrowserSupportEnabled == null)
				cb_isBrokerBrowserSupportEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBrokerBrowserSupportEnabled);
			return cb_isBrokerBrowserSupportEnabled;
		}

		static bool n_IsBrokerBrowserSupportEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBrokerBrowserSupportEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBrokerBrowserSupportEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='isBrokerBrowserSupportEnabled' and count(parameter)=0]"
			[Register ("isBrokerBrowserSupportEnabled", "()Z", "GetIsBrokerBrowserSupportEnabledHandler")]
			get {
				const string __id = "isBrokerBrowserSupportEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWebViewZoomControlsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWebViewZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='isWebViewZoomControlsEnabled' and count(parameter)=0]"
			[Register ("isWebViewZoomControlsEnabled", "()Z", "GetIsWebViewZoomControlsEnabledHandler")]
			get {
				const string __id = "isWebViewZoomControlsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWebViewZoomEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWebViewZoomEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='isWebViewZoomEnabled' and count(parameter)=0]"
			[Register ("isWebViewZoomEnabled", "()Z", "GetIsWebViewZoomEnabledHandler")]
			get {
				const string __id = "isWebViewZoomEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLoginHint;
#pragma warning disable 0169
		static Delegate GetGetLoginHintHandler ()
		{
			if (cb_getLoginHint == null)
				cb_getLoginHint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoginHint);
			return cb_getLoginHint;
		}

		static IntPtr n_GetLoginHint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LoginHint);
		}
#pragma warning restore 0169

		public virtual unsafe string LoginHint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getLoginHint' and count(parameter)=0]"
			[Register ("getLoginHint", "()Ljava/lang/String;", "GetGetLoginHintHandler")]
			get {
				const string __id = "getLoginHint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrompt;
#pragma warning disable 0169
		static Delegate GetGetPromptHandler ()
		{
			if (cb_getPrompt == null)
				cb_getPrompt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrompt);
			return cb_getPrompt;
		}

		static IntPtr n_GetPrompt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Prompt);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter Prompt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getPrompt' and count(parameter)=0]"
			[Register ("getPrompt", "()Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;", "GetGetPromptHandler")]
			get {
				const string __id = "getPrompt.()Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestHeaders;
#pragma warning disable 0169
		static Delegate GetGetRequestHeadersHandler ()
		{
			if (cb_getRequestHeaders == null)
				cb_getRequestHeaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestHeaders);
			return cb_getRequestHeaders;
		}

		static IntPtr n_GetRequestHeaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestHeaders);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='InteractiveTokenCommandParameters']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/HashMap;", "GetGetRequestHeadersHandler")]
			get {
				const string __id = "getRequestHeaders.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
