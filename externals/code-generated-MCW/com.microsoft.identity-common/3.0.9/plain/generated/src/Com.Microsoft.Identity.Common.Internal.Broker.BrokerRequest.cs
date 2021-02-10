using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerRequest", DoNotGenerateAcw=true)]
	public partial class BrokerRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerRequest$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerRequest$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/constructor[@name='BrokerRequest.Builder' and count(parameter)=0]"
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

			static Delegate cb_applicationName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetApplicationName_Ljava_lang_String_Handler ()
			{
				if (cb_applicationName_Ljava_lang_String_ == null)
					cb_applicationName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplicationName_Ljava_lang_String_);
				return cb_applicationName_Ljava_lang_String_;
			}

			static IntPtr n_ApplicationName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var applicationName = JNIEnv.GetString (native_applicationName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplicationName (applicationName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='applicationName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("applicationName", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetApplicationName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder ApplicationName (string applicationName)
			{
				const string __id = "applicationName.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_applicationName = JNIEnv.NewString (applicationName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_applicationName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_applicationName);
				}
			}

			static Delegate cb_applicationVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetApplicationVersion_Ljava_lang_String_Handler ()
			{
				if (cb_applicationVersion_Ljava_lang_String_ == null)
					cb_applicationVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplicationVersion_Ljava_lang_String_);
				return cb_applicationVersion_Ljava_lang_String_;
			}

			static IntPtr n_ApplicationVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationVersion)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var applicationVersion = JNIEnv.GetString (native_applicationVersion, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplicationVersion (applicationVersion));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='applicationVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("applicationVersion", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetApplicationVersion_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder ApplicationVersion (string applicationVersion)
			{
				const string __id = "applicationVersion.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_applicationVersion = JNIEnv.NewString (applicationVersion);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_applicationVersion);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_applicationVersion);
				}
			}

			static Delegate cb_authenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
#pragma warning disable 0169
			static Delegate GetAuthenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler ()
			{
				if (cb_authenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ == null)
					cb_authenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AuthenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_);
				return cb_authenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
			}

			static IntPtr n_AuthenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authenticationScheme)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authenticationScheme = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_authenticationScheme, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AuthenticationScheme (authenticationScheme));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='authenticationScheme' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
			[Register ("authenticationScheme", "(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetAuthenticationScheme_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder AuthenticationScheme (global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme authenticationScheme)
			{
				const string __id = "authenticationScheme.(Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((authenticationScheme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationScheme).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (authenticationScheme);
				}
			}

			static Delegate cb_authority_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAuthority_Ljava_lang_String_Handler ()
			{
				if (cb_authority_Ljava_lang_String_ == null)
					cb_authority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Authority_Ljava_lang_String_);
				return cb_authority_Ljava_lang_String_;
			}

			static IntPtr n_Authority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authority)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authority (authority));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='authority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("authority", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetAuthority_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Authority (string authority)
			{
				const string __id = "authority.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_authority = JNIEnv.NewString (authority);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_authority);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_authority);
				}
			}

			static Delegate cb_authorizationAgent_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAuthorizationAgent_Ljava_lang_String_Handler ()
			{
				if (cb_authorizationAgent_Ljava_lang_String_ == null)
					cb_authorizationAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AuthorizationAgent_Ljava_lang_String_);
				return cb_authorizationAgent_Ljava_lang_String_;
			}

			static IntPtr n_AuthorizationAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorizationAgent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authorizationAgent = JNIEnv.GetString (native_authorizationAgent, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AuthorizationAgent (authorizationAgent));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='authorizationAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("authorizationAgent", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetAuthorizationAgent_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder AuthorizationAgent (string authorizationAgent)
			{
				const string __id = "authorizationAgent.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_authorizationAgent = JNIEnv.NewString (authorizationAgent);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_authorizationAgent);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_authorizationAgent);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/broker/BrokerRequest;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/broker/BrokerRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_claims_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetClaims_Ljava_lang_String_Handler ()
			{
				if (cb_claims_Ljava_lang_String_ == null)
					cb_claims_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Claims_Ljava_lang_String_);
				return cb_claims_Ljava_lang_String_;
			}

			static IntPtr n_Claims_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claims)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var claims = JNIEnv.GetString (native_claims, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Claims (claims));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='claims' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("claims", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetClaims_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Claims (string claims)
			{
				const string __id = "claims.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_claims = JNIEnv.NewString (claims);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_claims);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_claims);
				}
			}

			static Delegate cb_clientId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetClientId_Ljava_lang_String_Handler ()
			{
				if (cb_clientId_Ljava_lang_String_ == null)
					cb_clientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ClientId_Ljava_lang_String_);
				return cb_clientId_Ljava_lang_String_;
			}

			static IntPtr n_ClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClientId (clientId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='clientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("clientId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetClientId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder ClientId (string clientId)
			{
				const string __id = "clientId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_clientId = JNIEnv.NewString (clientId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientId);
				}
			}

			static Delegate cb_correlationId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCorrelationId_Ljava_lang_String_Handler ()
			{
				if (cb_correlationId_Ljava_lang_String_ == null)
					cb_correlationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CorrelationId_Ljava_lang_String_);
				return cb_correlationId_Ljava_lang_String_;
			}

			static IntPtr n_CorrelationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CorrelationId (correlationId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='correlationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("correlationId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetCorrelationId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder CorrelationId (string correlationId)
			{
				const string __id = "correlationId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_correlationId = JNIEnv.NewString (correlationId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_correlationId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_correlationId);
				}
			}

			static Delegate cb_environment_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetEnvironment_Ljava_lang_String_Handler ()
			{
				if (cb_environment_Ljava_lang_String_ == null)
					cb_environment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Environment_Ljava_lang_String_);
				return cb_environment_Ljava_lang_String_;
			}

			static IntPtr n_Environment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_environment)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Environment (environment));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='environment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("environment", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetEnvironment_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Environment (string environment)
			{
				const string __id = "environment.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_environment = JNIEnv.NewString (environment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_environment);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_environment);
				}
			}

			static Delegate cb_extraQueryStringParameter_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetExtraQueryStringParameter_Ljava_lang_String_Handler ()
			{
				if (cb_extraQueryStringParameter_Ljava_lang_String_ == null)
					cb_extraQueryStringParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExtraQueryStringParameter_Ljava_lang_String_);
				return cb_extraQueryStringParameter_Ljava_lang_String_;
			}

			static IntPtr n_ExtraQueryStringParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extraQueryStringParameter)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var extraQueryStringParameter = JNIEnv.GetString (native_extraQueryStringParameter, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtraQueryStringParameter (extraQueryStringParameter));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='extraQueryStringParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("extraQueryStringParameter", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetExtraQueryStringParameter_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder ExtraQueryStringParameter (string extraQueryStringParameter)
			{
				const string __id = "extraQueryStringParameter.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_extraQueryStringParameter = JNIEnv.NewString (extraQueryStringParameter);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_extraQueryStringParameter);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_extraQueryStringParameter);
				}
			}

			static Delegate cb_forceRefresh_Z;
#pragma warning disable 0169
			static Delegate GetForceRefresh_ZHandler ()
			{
				if (cb_forceRefresh_Z == null)
					cb_forceRefresh_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ForceRefresh_Z);
				return cb_forceRefresh_Z;
			}

			static IntPtr n_ForceRefresh_Z (IntPtr jnienv, IntPtr native__this, bool forceRefresh)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ForceRefresh (forceRefresh));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='forceRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("forceRefresh", "(Z)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetForceRefresh_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder ForceRefresh (bool forceRefresh)
			{
				const string __id = "forceRefresh.(Z)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (forceRefresh);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_homeAccountId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHomeAccountId_Ljava_lang_String_Handler ()
			{
				if (cb_homeAccountId_Ljava_lang_String_ == null)
					cb_homeAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HomeAccountId_Ljava_lang_String_);
				return cb_homeAccountId_Ljava_lang_String_;
			}

			static IntPtr n_HomeAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var userId = JNIEnv.GetString (native_userId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HomeAccountId (userId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='homeAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("homeAccountId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetHomeAccountId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder HomeAccountId (string userId)
			{
				const string __id = "homeAccountId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_userId = JNIEnv.NewString (userId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_userId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_userId);
				}
			}

			static Delegate cb_localAccountId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLocalAccountId_Ljava_lang_String_Handler ()
			{
				if (cb_localAccountId_Ljava_lang_String_ == null)
					cb_localAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LocalAccountId_Ljava_lang_String_);
				return cb_localAccountId_Ljava_lang_String_;
			}

			static IntPtr n_LocalAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_localAccountId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var localAccountId = JNIEnv.GetString (native_localAccountId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LocalAccountId (localAccountId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='localAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("localAccountId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetLocalAccountId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder LocalAccountId (string localAccountId)
			{
				const string __id = "localAccountId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_localAccountId = JNIEnv.NewString (localAccountId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_localAccountId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_localAccountId);
				}
			}

			static Delegate cb_msalVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetMsalVersion_Ljava_lang_String_Handler ()
			{
				if (cb_msalVersion_Ljava_lang_String_ == null)
					cb_msalVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MsalVersion_Ljava_lang_String_);
				return cb_msalVersion_Ljava_lang_String_;
			}

			static IntPtr n_MsalVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var version = JNIEnv.GetString (native_version, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MsalVersion (version));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='msalVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("msalVersion", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetMsalVersion_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder MsalVersion (string version)
			{
				const string __id = "msalVersion.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_version = JNIEnv.NewString (version);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_version);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_version);
				}
			}

			static Delegate cb_multipleCloudsSupported_Z;
#pragma warning disable 0169
			static Delegate GetMultipleCloudsSupported_ZHandler ()
			{
				if (cb_multipleCloudsSupported_Z == null)
					cb_multipleCloudsSupported_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_MultipleCloudsSupported_Z);
				return cb_multipleCloudsSupported_Z;
			}

			static IntPtr n_MultipleCloudsSupported_Z (IntPtr jnienv, IntPtr native__this, bool multipleCloudsSupported)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MultipleCloudsSupported (multipleCloudsSupported));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='multipleCloudsSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("multipleCloudsSupported", "(Z)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetMultipleCloudsSupported_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder MultipleCloudsSupported (bool multipleCloudsSupported)
			{
				const string __id = "multipleCloudsSupported.(Z)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (multipleCloudsSupported);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_powerOptCheckEnabled_Z;
#pragma warning disable 0169
			static Delegate GetPowerOptCheckEnabled_ZHandler ()
			{
				if (cb_powerOptCheckEnabled_Z == null)
					cb_powerOptCheckEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_PowerOptCheckEnabled_Z);
				return cb_powerOptCheckEnabled_Z;
			}

			static IntPtr n_PowerOptCheckEnabled_Z (IntPtr jnienv, IntPtr native__this, bool powerOptCheckEnabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PowerOptCheckEnabled (powerOptCheckEnabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='powerOptCheckEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("powerOptCheckEnabled", "(Z)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetPowerOptCheckEnabled_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder PowerOptCheckEnabled (bool powerOptCheckEnabled)
			{
				const string __id = "powerOptCheckEnabled.(Z)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (powerOptCheckEnabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_prompt_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrompt_Ljava_lang_String_Handler ()
			{
				if (cb_prompt_Ljava_lang_String_ == null)
					cb_prompt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Prompt_Ljava_lang_String_);
				return cb_prompt_Ljava_lang_String_;
			}

			static IntPtr n_Prompt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prompt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var prompt = JNIEnv.GetString (native_prompt, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Prompt (prompt));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='prompt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("prompt", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetPrompt_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Prompt (string prompt)
			{
				const string __id = "prompt.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_prompt = JNIEnv.NewString (prompt);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_prompt);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_prompt);
				}
			}

			static Delegate cb_redirect_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRedirect_Ljava_lang_String_Handler ()
			{
				if (cb_redirect_Ljava_lang_String_ == null)
					cb_redirect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Redirect_Ljava_lang_String_);
				return cb_redirect_Ljava_lang_String_;
			}

			static IntPtr n_Redirect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirect)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var redirect = JNIEnv.GetString (native_redirect, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Redirect (redirect));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='redirect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("redirect", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetRedirect_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Redirect (string redirect)
			{
				const string __id = "redirect.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_redirect = JNIEnv.NewString (redirect);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_redirect);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_redirect);
				}
			}

			static Delegate cb_scope_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetScope_Ljava_lang_String_Handler ()
			{
				if (cb_scope_Ljava_lang_String_ == null)
					cb_scope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Scope_Ljava_lang_String_);
				return cb_scope_Ljava_lang_String_;
			}

			static IntPtr n_Scope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scope)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Scope (scope));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='scope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("scope", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetScope_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Scope (string scope)
			{
				const string __id = "scope.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_scope = JNIEnv.NewString (scope);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scope);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_scope);
				}
			}

			static Delegate cb_sdkType_Lcom_microsoft_identity_common_internal_request_SdkType_;
#pragma warning disable 0169
			static Delegate GetSdkType_Lcom_microsoft_identity_common_internal_request_SdkType_Handler ()
			{
				if (cb_sdkType_Lcom_microsoft_identity_common_internal_request_SdkType_ == null)
					cb_sdkType_Lcom_microsoft_identity_common_internal_request_SdkType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SdkType_Lcom_microsoft_identity_common_internal_request_SdkType_);
				return cb_sdkType_Lcom_microsoft_identity_common_internal_request_SdkType_;
			}

			static IntPtr n_SdkType_Lcom_microsoft_identity_common_internal_request_SdkType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sdkType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var sdkType = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (native_sdkType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SdkType (sdkType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='sdkType' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.request.SdkType']]"
			[Register ("sdkType", "(Lcom/microsoft/identity/common/internal/request/SdkType;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetSdkType_Lcom_microsoft_identity_common_internal_request_SdkType_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder SdkType (global::Com.Microsoft.Identity.Common.Internal.Request.SdkType sdkType)
			{
				const string __id = "sdkType.(Lcom/microsoft/identity/common/internal/request/SdkType;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((sdkType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdkType).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (sdkType);
				}
			}

			static Delegate cb_username_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUsername_Ljava_lang_String_Handler ()
			{
				if (cb_username_Ljava_lang_String_ == null)
					cb_username_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Username_Ljava_lang_String_);
				return cb_username_Ljava_lang_String_;
			}

			static IntPtr n_Username_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var userName = JNIEnv.GetString (native_userName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Username (userName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest.Builder']/method[@name='username' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("username", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;", "GetUsername_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder Username (string userName)
			{
				const string __id = "username.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest$Builder;";
				IntPtr native_userName = JNIEnv.NewString (userName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_userName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_userName);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerRequest", typeof (BrokerRequest));

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

		protected BrokerRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationName);
		}
#pragma warning restore 0169

		public virtual unsafe string ApplicationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getApplicationName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string ApplicationVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getApplicationVersion' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthenticationScheme);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme AuthenticationScheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getAuthenticationScheme' and count(parameter)=0]"
			[Register ("getAuthenticationScheme", "()Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;", "GetGetAuthenticationSchemeHandler")]
			get {
				const string __id = "getAuthenticationScheme.()Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Authority);
		}
#pragma warning restore 0169

		public virtual unsafe string Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getAuthority' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationAgent);
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorizationAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getAuthorizationAgent' and count(parameter)=0]"
			[Register ("getAuthorizationAgent", "()Ljava/lang/String;", "GetGetAuthorizationAgentHandler")]
			get {
				const string __id = "getAuthorizationAgent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClaims;
#pragma warning disable 0169
		static Delegate GetGetClaimsHandler ()
		{
			if (cb_getClaims == null)
				cb_getClaims = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaims);
			return cb_getClaims;
		}

		static IntPtr n_GetClaims (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Claims);
		}
#pragma warning restore 0169

		public virtual unsafe string Claims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getClaims' and count(parameter)=0]"
			[Register ("getClaims", "()Ljava/lang/String;", "GetGetClaimsHandler")]
			get {
				const string __id = "getClaims.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getClientId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		public virtual unsafe string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getCorrelationId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		public virtual unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get {
				const string __id = "getEnvironment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraQueryStringParameter;
#pragma warning disable 0169
		static Delegate GetGetExtraQueryStringParameterHandler ()
		{
			if (cb_getExtraQueryStringParameter == null)
				cb_getExtraQueryStringParameter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtraQueryStringParameter);
			return cb_getExtraQueryStringParameter;
		}

		static IntPtr n_GetExtraQueryStringParameter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExtraQueryStringParameter);
		}
#pragma warning restore 0169

		public virtual unsafe string ExtraQueryStringParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getExtraQueryStringParameter' and count(parameter)=0]"
			[Register ("getExtraQueryStringParameter", "()Ljava/lang/String;", "GetGetExtraQueryStringParameterHandler")]
			get {
				const string __id = "getExtraQueryStringParameter.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getForceRefresh;
#pragma warning disable 0169
		static Delegate GetGetForceRefreshHandler ()
		{
			if (cb_getForceRefresh == null)
				cb_getForceRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetForceRefresh);
			return cb_getForceRefresh;
		}

		static bool n_GetForceRefresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForceRefresh;
		}
#pragma warning restore 0169

		public virtual unsafe bool ForceRefresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getForceRefresh' and count(parameter)=0]"
			[Register ("getForceRefresh", "()Z", "GetGetForceRefreshHandler")]
			get {
				const string __id = "getForceRefresh.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHomeAccountId;
#pragma warning disable 0169
		static Delegate GetGetHomeAccountIdHandler ()
		{
			if (cb_getHomeAccountId == null)
				cb_getHomeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHomeAccountId);
			return cb_getHomeAccountId;
		}

		static IntPtr n_GetHomeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get {
				const string __id = "getHomeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPowerOptCheckEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPowerOptCheckEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='isPowerOptCheckEnabled' and count(parameter)=0]"
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

		static Delegate cb_getLocalAccountId;
#pragma warning disable 0169
		static Delegate GetGetLocalAccountIdHandler ()
		{
			if (cb_getLocalAccountId == null)
				cb_getLocalAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalAccountId);
			return cb_getLocalAccountId;
		}

		static IntPtr n_GetLocalAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalAccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string LocalAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getLocalAccountId' and count(parameter)=0]"
			[Register ("getLocalAccountId", "()Ljava/lang/String;", "GetGetLocalAccountIdHandler")]
			get {
				const string __id = "getLocalAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMsalVersion;
#pragma warning disable 0169
		static Delegate GetGetMsalVersionHandler ()
		{
			if (cb_getMsalVersion == null)
				cb_getMsalVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMsalVersion);
			return cb_getMsalVersion;
		}

		static IntPtr n_GetMsalVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsalVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string MsalVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getMsalVersion' and count(parameter)=0]"
			[Register ("getMsalVersion", "()Ljava/lang/String;", "GetGetMsalVersionHandler")]
			get {
				const string __id = "getMsalVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultipleCloudsSupported;
		}
#pragma warning restore 0169

		public virtual unsafe bool MultipleCloudsSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getMultipleCloudsSupported' and count(parameter)=0]"
			[Register ("getMultipleCloudsSupported", "()Z", "GetGetMultipleCloudsSupportedHandler")]
			get {
				const string __id = "getMultipleCloudsSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prompt);
		}
#pragma warning restore 0169

		public virtual unsafe string Prompt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getPrompt' and count(parameter)=0]"
			[Register ("getPrompt", "()Ljava/lang/String;", "GetGetPromptHandler")]
			get {
				const string __id = "getPrompt.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirect;
#pragma warning disable 0169
		static Delegate GetGetRedirectHandler ()
		{
			if (cb_getRedirect == null)
				cb_getRedirect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRedirect);
			return cb_getRedirect;
		}

		static IntPtr n_GetRedirect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Redirect);
		}
#pragma warning restore 0169

		public virtual unsafe string Redirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getRedirect' and count(parameter)=0]"
			[Register ("getRedirect", "()Ljava/lang/String;", "GetGetRedirectHandler")]
			get {
				const string __id = "getRedirect.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SdkType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Request.SdkType SdkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getSdkType' and count(parameter)=0]"
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

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		public virtual unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerRequest']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				const string __id = "getUserName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
