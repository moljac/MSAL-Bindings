using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerResult", DoNotGenerateAcw=true)]
	public partial class BrokerResult : global::Java.Lang.Object, global::Java.IO.ISerializable {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerResult$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerResult$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/constructor[@name='BrokerResult.Builder' and count(parameter)=0]"
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

			static Delegate cb_accessToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAccessToken_Ljava_lang_String_Handler ()
			{
				if (cb_accessToken_Ljava_lang_String_ == null)
					cb_accessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AccessToken_Ljava_lang_String_);
				return cb_accessToken_Ljava_lang_String_;
			}

			static IntPtr n_AccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AccessToken (accessToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='accessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("accessToken", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetAccessToken_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder AccessToken (string accessToken)
			{
				const string __id = "accessToken.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_accessToken = JNIEnv.NewString (accessToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_accessToken);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_accessToken);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authority (authority));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='authority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("authority", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetAuthority_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder Authority (string authority)
			{
				const string __id = "authority.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_authority = JNIEnv.NewString (authority);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_authority);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_authority);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/broker/BrokerResult;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/broker/BrokerResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_cachedAt_J;
#pragma warning disable 0169
			static Delegate GetCachedAt_JHandler ()
			{
				if (cb_cachedAt_J == null)
					cb_cachedAt_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_CachedAt_J);
				return cb_cachedAt_J;
			}

			static IntPtr n_CachedAt_J (IntPtr jnienv, IntPtr native__this, long cachedAt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CachedAt (cachedAt));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='cachedAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("cachedAt", "(J)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetCachedAt_JHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder CachedAt (long cachedAt)
			{
				const string __id = "cachedAt.(J)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (cachedAt);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_cliTelemErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCliTelemErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_cliTelemErrorCode_Ljava_lang_String_ == null)
					cb_cliTelemErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CliTelemErrorCode_Ljava_lang_String_);
				return cb_cliTelemErrorCode_Ljava_lang_String_;
			}

			static IntPtr n_CliTelemErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cliTelemErrorCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cliTelemErrorCode = JNIEnv.GetString (native_cliTelemErrorCode, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CliTelemErrorCode (cliTelemErrorCode));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='cliTelemErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("cliTelemErrorCode", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetCliTelemErrorCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder CliTelemErrorCode (string cliTelemErrorCode)
			{
				const string __id = "cliTelemErrorCode.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_cliTelemErrorCode = JNIEnv.NewString (cliTelemErrorCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cliTelemErrorCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_cliTelemErrorCode);
				}
			}

			static Delegate cb_cliTelemSubErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCliTelemSubErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_cliTelemSubErrorCode_Ljava_lang_String_ == null)
					cb_cliTelemSubErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CliTelemSubErrorCode_Ljava_lang_String_);
				return cb_cliTelemSubErrorCode_Ljava_lang_String_;
			}

			static IntPtr n_CliTelemSubErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cliTelemSubErrorCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cliTelemSubErrorCode = JNIEnv.GetString (native_cliTelemSubErrorCode, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CliTelemSubErrorCode (cliTelemSubErrorCode));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='cliTelemSubErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("cliTelemSubErrorCode", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetCliTelemSubErrorCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder CliTelemSubErrorCode (string cliTelemSubErrorCode)
			{
				const string __id = "cliTelemSubErrorCode.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_cliTelemSubErrorCode = JNIEnv.NewString (cliTelemSubErrorCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cliTelemSubErrorCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_cliTelemSubErrorCode);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClientId (clientId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='clientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("clientId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetClientId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ClientId (string clientId)
			{
				const string __id = "clientId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_clientId = JNIEnv.NewString (clientId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientId);
				}
			}

			static Delegate cb_clientInfo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetClientInfo_Ljava_lang_String_Handler ()
			{
				if (cb_clientInfo_Ljava_lang_String_ == null)
					cb_clientInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ClientInfo_Ljava_lang_String_);
				return cb_clientInfo_Ljava_lang_String_;
			}

			static IntPtr n_ClientInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var clientInfo = JNIEnv.GetString (native_clientInfo, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClientInfo (clientInfo));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='clientInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("clientInfo", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetClientInfo_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ClientInfo (string clientInfo)
			{
				const string __id = "clientInfo.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_clientInfo = JNIEnv.NewString (clientInfo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientInfo);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientInfo);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CorrelationId (correlationId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='correlationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("correlationId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetCorrelationId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder CorrelationId (string correlationId)
			{
				const string __id = "correlationId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_correlationId = JNIEnv.NewString (correlationId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_correlationId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Environment (environment));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='environment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("environment", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetEnvironment_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder Environment (string environment)
			{
				const string __id = "environment.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_environment = JNIEnv.NewString (environment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_environment);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_environment);
				}
			}

			static Delegate cb_errorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_errorCode_Ljava_lang_String_ == null)
					cb_errorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ErrorCode_Ljava_lang_String_);
				return cb_errorCode_Ljava_lang_String_;
			}

			static IntPtr n_ErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ErrorCode (errorCode));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='errorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("errorCode", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetErrorCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ErrorCode (string errorCode)
			{
				const string __id = "errorCode.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_errorCode = JNIEnv.NewString (errorCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_errorCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_errorCode);
				}
			}

			static Delegate cb_errorMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetErrorMessage_Ljava_lang_String_Handler ()
			{
				if (cb_errorMessage_Ljava_lang_String_ == null)
					cb_errorMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ErrorMessage_Ljava_lang_String_);
				return cb_errorMessage_Ljava_lang_String_;
			}

			static IntPtr n_ErrorMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorMessage)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var errorMessage = JNIEnv.GetString (native_errorMessage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ErrorMessage (errorMessage));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='errorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("errorMessage", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetErrorMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ErrorMessage (string errorMessage)
			{
				const string __id = "errorMessage.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_errorMessage);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_errorMessage);
				}
			}

			static Delegate cb_exceptionType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetExceptionType_Ljava_lang_String_Handler ()
			{
				if (cb_exceptionType_Ljava_lang_String_ == null)
					cb_exceptionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExceptionType_Ljava_lang_String_);
				return cb_exceptionType_Ljava_lang_String_;
			}

			static IntPtr n_ExceptionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exceptionType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var exceptionType = JNIEnv.GetString (native_exceptionType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExceptionType (exceptionType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='exceptionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("exceptionType", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetExceptionType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ExceptionType (string exceptionType)
			{
				const string __id = "exceptionType.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_exceptionType = JNIEnv.NewString (exceptionType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_exceptionType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_exceptionType);
				}
			}

			static Delegate cb_expiresOn_J;
#pragma warning disable 0169
			static Delegate GetExpiresOn_JHandler ()
			{
				if (cb_expiresOn_J == null)
					cb_expiresOn_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ExpiresOn_J);
				return cb_expiresOn_J;
			}

			static IntPtr n_ExpiresOn_J (IntPtr jnienv, IntPtr native__this, long mExpiresOn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ExpiresOn (mExpiresOn));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='expiresOn' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("expiresOn", "(J)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetExpiresOn_JHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ExpiresOn (long mExpiresOn)
			{
				const string __id = "expiresOn.(J)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (mExpiresOn);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_extendedExpiresOn_J;
#pragma warning disable 0169
			static Delegate GetExtendedExpiresOn_JHandler ()
			{
				if (cb_extendedExpiresOn_J == null)
					cb_extendedExpiresOn_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ExtendedExpiresOn_J);
				return cb_extendedExpiresOn_J;
			}

			static IntPtr n_ExtendedExpiresOn_J (IntPtr jnienv, IntPtr native__this, long extendedExpiresOn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ExtendedExpiresOn (extendedExpiresOn));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='extendedExpiresOn' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("extendedExpiresOn", "(J)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetExtendedExpiresOn_JHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ExtendedExpiresOn (long extendedExpiresOn)
			{
				const string __id = "extendedExpiresOn.(J)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (extendedExpiresOn);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_familyId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFamilyId_Ljava_lang_String_Handler ()
			{
				if (cb_familyId_Ljava_lang_String_ == null)
					cb_familyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FamilyId_Ljava_lang_String_);
				return cb_familyId_Ljava_lang_String_;
			}

			static IntPtr n_FamilyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_familyId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var familyId = JNIEnv.GetString (native_familyId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FamilyId (familyId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='familyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("familyId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetFamilyId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder FamilyId (string familyId)
			{
				const string __id = "familyId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_familyId = JNIEnv.NewString (familyId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_familyId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_familyId);
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

			static IntPtr n_HomeAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_homeAccountId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HomeAccountId (homeAccountId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='homeAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("homeAccountId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetHomeAccountId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder HomeAccountId (string homeAccountId)
			{
				const string __id = "homeAccountId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_homeAccountId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_homeAccountId);
				}
			}

			static Delegate cb_httpResponseBody_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHttpResponseBody_Ljava_lang_String_Handler ()
			{
				if (cb_httpResponseBody_Ljava_lang_String_ == null)
					cb_httpResponseBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HttpResponseBody_Ljava_lang_String_);
				return cb_httpResponseBody_Ljava_lang_String_;
			}

			static IntPtr n_HttpResponseBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_httpResponseBody)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var httpResponseBody = JNIEnv.GetString (native_httpResponseBody, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HttpResponseBody (httpResponseBody));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='httpResponseBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("httpResponseBody", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetHttpResponseBody_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder HttpResponseBody (string httpResponseBody)
			{
				const string __id = "httpResponseBody.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_httpResponseBody = JNIEnv.NewString (httpResponseBody);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_httpResponseBody);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_httpResponseBody);
				}
			}

			static Delegate cb_httpResponseHeaders_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHttpResponseHeaders_Ljava_lang_String_Handler ()
			{
				if (cb_httpResponseHeaders_Ljava_lang_String_ == null)
					cb_httpResponseHeaders_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HttpResponseHeaders_Ljava_lang_String_);
				return cb_httpResponseHeaders_Ljava_lang_String_;
			}

			static IntPtr n_HttpResponseHeaders_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_httpResponseHeaders)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var httpResponseHeaders = JNIEnv.GetString (native_httpResponseHeaders, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HttpResponseHeaders (httpResponseHeaders));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='httpResponseHeaders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("httpResponseHeaders", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetHttpResponseHeaders_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder HttpResponseHeaders (string httpResponseHeaders)
			{
				const string __id = "httpResponseHeaders.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_httpResponseHeaders = JNIEnv.NewString (httpResponseHeaders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_httpResponseHeaders);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_httpResponseHeaders);
				}
			}

			static Delegate cb_httpStatusCode_I;
#pragma warning disable 0169
			static Delegate GetHttpStatusCode_IHandler ()
			{
				if (cb_httpStatusCode_I == null)
					cb_httpStatusCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_HttpStatusCode_I);
				return cb_httpStatusCode_I;
			}

			static IntPtr n_HttpStatusCode_I (IntPtr jnienv, IntPtr native__this, int httpStatusCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.HttpStatusCode (httpStatusCode));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='httpStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("httpStatusCode", "(I)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetHttpStatusCode_IHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder HttpStatusCode (int httpStatusCode)
			{
				const string __id = "httpStatusCode.(I)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (httpStatusCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_idToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIdToken_Ljava_lang_String_Handler ()
			{
				if (cb_idToken_Ljava_lang_String_ == null)
					cb_idToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_IdToken_Ljava_lang_String_);
				return cb_idToken_Ljava_lang_String_;
			}

			static IntPtr n_IdToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var idToken = JNIEnv.GetString (native_idToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IdToken (idToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='idToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("idToken", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetIdToken_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder IdToken (string idToken)
			{
				const string __id = "idToken.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_idToken = JNIEnv.NewString (idToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_idToken);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_idToken);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var localAccountId = JNIEnv.GetString (native_localAccountId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LocalAccountId (localAccountId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='localAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("localAccountId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetLocalAccountId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder LocalAccountId (string localAccountId)
			{
				const string __id = "localAccountId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_localAccountId = JNIEnv.NewString (localAccountId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_localAccountId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_localAccountId);
				}
			}

			static Delegate cb_negotiatedBrokerProtocolVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNegotiatedBrokerProtocolVersion_Ljava_lang_String_Handler ()
			{
				if (cb_negotiatedBrokerProtocolVersion_Ljava_lang_String_ == null)
					cb_negotiatedBrokerProtocolVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NegotiatedBrokerProtocolVersion_Ljava_lang_String_);
				return cb_negotiatedBrokerProtocolVersion_Ljava_lang_String_;
			}

			static IntPtr n_NegotiatedBrokerProtocolVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_negotiatedBrokerProtocolVersion)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NegotiatedBrokerProtocolVersion (negotiatedBrokerProtocolVersion));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='negotiatedBrokerProtocolVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("negotiatedBrokerProtocolVersion", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetNegotiatedBrokerProtocolVersion_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder NegotiatedBrokerProtocolVersion (string negotiatedBrokerProtocolVersion)
			{
				const string __id = "negotiatedBrokerProtocolVersion.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				}
			}

			static Delegate cb_oauthSubErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOauthSubErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_oauthSubErrorCode_Ljava_lang_String_ == null)
					cb_oauthSubErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OauthSubErrorCode_Ljava_lang_String_);
				return cb_oauthSubErrorCode_Ljava_lang_String_;
			}

			static IntPtr n_OauthSubErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subErrorCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var subErrorCode = JNIEnv.GetString (native_subErrorCode, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OauthSubErrorCode (subErrorCode));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='oauthSubErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("oauthSubErrorCode", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetOauthSubErrorCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder OauthSubErrorCode (string subErrorCode)
			{
				const string __id = "oauthSubErrorCode.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_subErrorCode = JNIEnv.NewString (subErrorCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_subErrorCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_subErrorCode);
				}
			}

			static Delegate cb_refreshToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRefreshToken_Ljava_lang_String_Handler ()
			{
				if (cb_refreshToken_Ljava_lang_String_ == null)
					cb_refreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RefreshToken_Ljava_lang_String_);
				return cb_refreshToken_Ljava_lang_String_;
			}

			static IntPtr n_RefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RefreshToken (refreshToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='refreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("refreshToken", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetRefreshToken_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder RefreshToken (string refreshToken)
			{
				const string __id = "refreshToken.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_refreshToken);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_refreshToken);
				}
			}

			static Delegate cb_refreshTokenAge_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRefreshTokenAge_Ljava_lang_String_Handler ()
			{
				if (cb_refreshTokenAge_Ljava_lang_String_ == null)
					cb_refreshTokenAge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RefreshTokenAge_Ljava_lang_String_);
				return cb_refreshTokenAge_Ljava_lang_String_;
			}

			static IntPtr n_RefreshTokenAge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshTokenAge)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var refreshTokenAge = JNIEnv.GetString (native_refreshTokenAge, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RefreshTokenAge (refreshTokenAge));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='refreshTokenAge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("refreshTokenAge", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetRefreshTokenAge_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder RefreshTokenAge (string refreshTokenAge)
			{
				const string __id = "refreshTokenAge.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_refreshTokenAge = JNIEnv.NewString (refreshTokenAge);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_refreshTokenAge);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_refreshTokenAge);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Scope (scope));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='scope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("scope", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetScope_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder Scope (string scope)
			{
				const string __id = "scope.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_scope = JNIEnv.NewString (scope);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scope);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_scope);
				}
			}

			static Delegate cb_servicedFromCache_Z;
#pragma warning disable 0169
			static Delegate GetServicedFromCache_ZHandler ()
			{
				if (cb_servicedFromCache_Z == null)
					cb_servicedFromCache_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ServicedFromCache_Z);
				return cb_servicedFromCache_Z;
			}

			static IntPtr n_ServicedFromCache_Z (IntPtr jnienv, IntPtr native__this, bool servicedFromCache)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ServicedFromCache (servicedFromCache));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='servicedFromCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("servicedFromCache", "(Z)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetServicedFromCache_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder ServicedFromCache (bool servicedFromCache)
			{
				const string __id = "servicedFromCache.(Z)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (servicedFromCache);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_speRing_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSpeRing_Ljava_lang_String_Handler ()
			{
				if (cb_speRing_Ljava_lang_String_ == null)
					cb_speRing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SpeRing_Ljava_lang_String_);
				return cb_speRing_Ljava_lang_String_;
			}

			static IntPtr n_SpeRing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_speRing)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var speRing = JNIEnv.GetString (native_speRing, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SpeRing (speRing));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='speRing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("speRing", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetSpeRing_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder SpeRing (string speRing)
			{
				const string __id = "speRing.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_speRing = JNIEnv.NewString (speRing);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_speRing);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_speRing);
				}
			}

			static Delegate cb_success_Z;
#pragma warning disable 0169
			static Delegate GetSuccess_ZHandler ()
			{
				if (cb_success_Z == null)
					cb_success_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Success_Z);
				return cb_success_Z;
			}

			static IntPtr n_Success_Z (IntPtr jnienv, IntPtr native__this, bool success)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Success (success));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='success' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("success", "(Z)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetSuccess_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder Success (bool success)
			{
				const string __id = "success.(Z)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (success);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_tenantId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetTenantId_Ljava_lang_String_Handler ()
			{
				if (cb_tenantId_Ljava_lang_String_ == null)
					cb_tenantId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TenantId_Ljava_lang_String_);
				return cb_tenantId_Ljava_lang_String_;
			}

			static IntPtr n_TenantId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tenantId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tenantId = JNIEnv.GetString (native_tenantId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TenantId (tenantId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='tenantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("tenantId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetTenantId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder TenantId (string tenantId)
			{
				const string __id = "tenantId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_tenantId = JNIEnv.NewString (tenantId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_tenantId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_tenantId);
				}
			}

			static Delegate cb_tenantProfileRecords_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetTenantProfileRecords_Ljava_util_List_Handler ()
			{
				if (cb_tenantProfileRecords_Ljava_util_List_ == null)
					cb_tenantProfileRecords_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TenantProfileRecords_Ljava_util_List_);
				return cb_tenantProfileRecords_Ljava_util_List_;
			}

			static IntPtr n_TenantProfileRecords_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecordWithTenantProfileData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cacheRecordWithTenantProfileData = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (native_cacheRecordWithTenantProfileData, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TenantProfileRecords (cacheRecordWithTenantProfileData));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='tenantProfileRecords' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.common.internal.cache.ICacheRecord&gt;']]"
			[Register ("tenantProfileRecords", "(Ljava/util/List;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetTenantProfileRecords_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder TenantProfileRecords (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> cacheRecordWithTenantProfileData)
			{
				const string __id = "tenantProfileRecords.(Ljava/util/List;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_cacheRecordWithTenantProfileData = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (cacheRecordWithTenantProfileData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cacheRecordWithTenantProfileData);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_cacheRecordWithTenantProfileData);
					global::System.GC.KeepAlive (cacheRecordWithTenantProfileData);
				}
			}

			static Delegate cb_tokenType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetTokenType_Ljava_lang_String_Handler ()
			{
				if (cb_tokenType_Ljava_lang_String_ == null)
					cb_tokenType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TokenType_Ljava_lang_String_);
				return cb_tokenType_Ljava_lang_String_;
			}

			static IntPtr n_TokenType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tokenType = JNIEnv.GetString (native_tokenType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TokenType (tokenType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='tokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("tokenType", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetTokenType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder TokenType (string tokenType)
			{
				const string __id = "tokenType.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_tokenType = JNIEnv.NewString (tokenType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_tokenType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_tokenType);
				}
			}

			static Delegate cb_userName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUserName_Ljava_lang_String_Handler ()
			{
				if (cb_userName_Ljava_lang_String_ == null)
					cb_userName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_UserName_Ljava_lang_String_);
				return cb_userName_Ljava_lang_String_;
			}

			static IntPtr n_UserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var userName = JNIEnv.GetString (native_userName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UserName (userName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult.Builder']/method[@name='userName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("userName", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;", "GetUserName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder UserName (string userName)
			{
				const string __id = "userName.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult$Builder;";
				IntPtr native_userName = JNIEnv.NewString (userName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_userName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_userName);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerResult", typeof (BrokerResult));

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

		protected BrokerResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Authority);
		}
#pragma warning restore 0169

		public virtual unsafe string Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getAuthority' and count(parameter)=0]"
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

		static Delegate cb_getCachedAt;
#pragma warning disable 0169
		static Delegate GetGetCachedAtHandler ()
		{
			if (cb_getCachedAt == null)
				cb_getCachedAt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCachedAt);
			return cb_getCachedAt;
		}

		static long n_GetCachedAt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CachedAt;
		}
#pragma warning restore 0169

		public virtual unsafe long CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()J", "GetGetCachedAtHandler")]
			get {
				const string __id = "getCachedAt.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCliTelemErrorCode;
#pragma warning disable 0169
		static Delegate GetGetCliTelemErrorCodeHandler ()
		{
			if (cb_getCliTelemErrorCode == null)
				cb_getCliTelemErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCliTelemErrorCode);
			return cb_getCliTelemErrorCode;
		}

		static IntPtr n_GetCliTelemErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CliTelemErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string CliTelemErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getCliTelemErrorCode' and count(parameter)=0]"
			[Register ("getCliTelemErrorCode", "()Ljava/lang/String;", "GetGetCliTelemErrorCodeHandler")]
			get {
				const string __id = "getCliTelemErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCliTelemSubErrorCode;
#pragma warning disable 0169
		static Delegate GetGetCliTelemSubErrorCodeHandler ()
		{
			if (cb_getCliTelemSubErrorCode == null)
				cb_getCliTelemSubErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCliTelemSubErrorCode);
			return cb_getCliTelemSubErrorCode;
		}

		static IntPtr n_GetCliTelemSubErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CliTelemSubErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string CliTelemSubErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getCliTelemSubErrorCode' and count(parameter)=0]"
			[Register ("getCliTelemSubErrorCode", "()Ljava/lang/String;", "GetGetCliTelemSubErrorCodeHandler")]
			get {
				const string __id = "getCliTelemSubErrorCode.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getClientId' and count(parameter)=0]"
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

		static Delegate cb_getClientInfo;
#pragma warning disable 0169
		static Delegate GetGetClientInfoHandler ()
		{
			if (cb_getClientInfo == null)
				cb_getClientInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientInfo);
			return cb_getClientInfo;
		}

		static IntPtr n_GetClientInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientInfo);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getClientInfo' and count(parameter)=0]"
			[Register ("getClientInfo", "()Ljava/lang/String;", "GetGetClientInfoHandler")]
			get {
				const string __id = "getClientInfo.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		public virtual unsafe string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getCorrelationId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		public virtual unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getEnvironment' and count(parameter)=0]"
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

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static IntPtr n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Ljava/lang/String;", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorMessage;
#pragma warning disable 0169
		static Delegate GetGetErrorMessageHandler ()
		{
			if (cb_getErrorMessage == null)
				cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorMessage);
			return cb_getErrorMessage;
		}

		static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				const string __id = "getErrorMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExceptionType;
#pragma warning disable 0169
		static Delegate GetGetExceptionTypeHandler ()
		{
			if (cb_getExceptionType == null)
				cb_getExceptionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExceptionType);
			return cb_getExceptionType;
		}

		static IntPtr n_GetExceptionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExceptionType);
		}
#pragma warning restore 0169

		public virtual unsafe string ExceptionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getExceptionType' and count(parameter)=0]"
			[Register ("getExceptionType", "()Ljava/lang/String;", "GetGetExceptionTypeHandler")]
			get {
				const string __id = "getExceptionType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpiresOn;
#pragma warning disable 0169
		static Delegate GetGetExpiresOnHandler ()
		{
			if (cb_getExpiresOn == null)
				cb_getExpiresOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetExpiresOn);
			return cb_getExpiresOn;
		}

		static long n_GetExpiresOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresOn;
		}
#pragma warning restore 0169

		public virtual unsafe long ExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getExpiresOn' and count(parameter)=0]"
			[Register ("getExpiresOn", "()J", "GetGetExpiresOnHandler")]
			get {
				const string __id = "getExpiresOn.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExtendedExpiresOn;
#pragma warning disable 0169
		static Delegate GetGetExtendedExpiresOnHandler ()
		{
			if (cb_getExtendedExpiresOn == null)
				cb_getExtendedExpiresOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetExtendedExpiresOn);
			return cb_getExtendedExpiresOn;
		}

		static long n_GetExtendedExpiresOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtendedExpiresOn;
		}
#pragma warning restore 0169

		public virtual unsafe long ExtendedExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getExtendedExpiresOn' and count(parameter)=0]"
			[Register ("getExtendedExpiresOn", "()J", "GetGetExtendedExpiresOnHandler")]
			get {
				const string __id = "getExtendedExpiresOn.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFamilyId;
#pragma warning disable 0169
		static Delegate GetGetFamilyIdHandler ()
		{
			if (cb_getFamilyId == null)
				cb_getFamilyId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFamilyId);
			return cb_getFamilyId;
		}

		static IntPtr n_GetFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyId);
		}
#pragma warning restore 0169

		public virtual unsafe string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler")]
			get {
				const string __id = "getFamilyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getHomeAccountId' and count(parameter)=0]"
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

		static Delegate cb_getHttpResponseBody;
#pragma warning disable 0169
		static Delegate GetGetHttpResponseBodyHandler ()
		{
			if (cb_getHttpResponseBody == null)
				cb_getHttpResponseBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpResponseBody);
			return cb_getHttpResponseBody;
		}

		static IntPtr n_GetHttpResponseBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HttpResponseBody);
		}
#pragma warning restore 0169

		public virtual unsafe string HttpResponseBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getHttpResponseBody' and count(parameter)=0]"
			[Register ("getHttpResponseBody", "()Ljava/lang/String;", "GetGetHttpResponseBodyHandler")]
			get {
				const string __id = "getHttpResponseBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpResponseHeaders;
#pragma warning disable 0169
		static Delegate GetGetHttpResponseHeadersHandler ()
		{
			if (cb_getHttpResponseHeaders == null)
				cb_getHttpResponseHeaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpResponseHeaders);
			return cb_getHttpResponseHeaders;
		}

		static IntPtr n_GetHttpResponseHeaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HttpResponseHeaders);
		}
#pragma warning restore 0169

		public virtual unsafe string HttpResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getHttpResponseHeaders' and count(parameter)=0]"
			[Register ("getHttpResponseHeaders", "()Ljava/lang/String;", "GetGetHttpResponseHeadersHandler")]
			get {
				const string __id = "getHttpResponseHeaders.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpStatusCode;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusCodeHandler ()
		{
			if (cb_getHttpStatusCode == null)
				cb_getHttpStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHttpStatusCode);
			return cb_getHttpStatusCode;
		}

		static int n_GetHttpStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpStatusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int HttpStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getHttpStatusCode' and count(parameter)=0]"
			[Register ("getHttpStatusCode", "()I", "GetGetHttpStatusCodeHandler")]
			get {
				const string __id = "getHttpStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIdToken;
#pragma warning disable 0169
		static Delegate GetGetIdTokenHandler ()
		{
			if (cb_getIdToken == null)
				cb_getIdToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdToken);
			return cb_getIdToken;
		}

		static IntPtr n_GetIdToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdToken);
		}
#pragma warning restore 0169

		public virtual unsafe string IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Ljava/lang/String;", "GetGetIdTokenHandler")]
			get {
				const string __id = "getIdToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isServicedFromCache;
#pragma warning disable 0169
		static Delegate GetIsServicedFromCacheHandler ()
		{
			if (cb_isServicedFromCache == null)
				cb_isServicedFromCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsServicedFromCache);
			return cb_isServicedFromCache;
		}

		static bool n_IsServicedFromCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsServicedFromCache;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsServicedFromCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='isServicedFromCache' and count(parameter)=0]"
			[Register ("isServicedFromCache", "()Z", "GetIsServicedFromCacheHandler")]
			get {
				const string __id = "isServicedFromCache.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				const string __id = "isSuccess.()Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalAccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string LocalAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getLocalAccountId' and count(parameter)=0]"
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

		static Delegate cb_getRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenHandler ()
		{
			if (cb_getRefreshToken == null)
				cb_getRefreshToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshToken);
			return cb_getRefreshToken;
		}

		static IntPtr n_GetRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				const string __id = "getRefreshToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshTokenAge;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenAgeHandler ()
		{
			if (cb_getRefreshTokenAge == null)
				cb_getRefreshTokenAge = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshTokenAge);
			return cb_getRefreshTokenAge;
		}

		static IntPtr n_GetRefreshTokenAge (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshTokenAge);
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshTokenAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getRefreshTokenAge' and count(parameter)=0]"
			[Register ("getRefreshTokenAge", "()Ljava/lang/String;", "GetGetRefreshTokenAgeHandler")]
			get {
				const string __id = "getRefreshTokenAge.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getScope' and count(parameter)=0]"
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

		static Delegate cb_getSpeRing;
#pragma warning disable 0169
		static Delegate GetGetSpeRingHandler ()
		{
			if (cb_getSpeRing == null)
				cb_getSpeRing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSpeRing);
			return cb_getSpeRing;
		}

		static IntPtr n_GetSpeRing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpeRing);
		}
#pragma warning restore 0169

		public virtual unsafe string SpeRing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getSpeRing' and count(parameter)=0]"
			[Register ("getSpeRing", "()Ljava/lang/String;", "GetGetSpeRingHandler")]
			get {
				const string __id = "getSpeRing.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubErrorCode;
#pragma warning disable 0169
		static Delegate GetGetSubErrorCodeHandler ()
		{
			if (cb_getSubErrorCode == null)
				cb_getSubErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubErrorCode);
			return cb_getSubErrorCode;
		}

		static IntPtr n_GetSubErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string SubErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getSubErrorCode' and count(parameter)=0]"
			[Register ("getSubErrorCode", "()Ljava/lang/String;", "GetGetSubErrorCodeHandler")]
			get {
				const string __id = "getSubErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTenantId;
#pragma warning disable 0169
		static Delegate GetGetTenantIdHandler ()
		{
			if (cb_getTenantId == null)
				cb_getTenantId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantId);
			return cb_getTenantId;
		}

		static IntPtr n_GetTenantId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		public virtual unsafe string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler")]
			get {
				const string __id = "getTenantId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTenantProfileData;
#pragma warning disable 0169
		static Delegate GetGetTenantProfileDataHandler ()
		{
			if (cb_getTenantProfileData == null)
				cb_getTenantProfileData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantProfileData);
			return cb_getTenantProfileData;
		}

		static IntPtr n_GetTenantProfileData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.TenantProfileData);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> TenantProfileData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getTenantProfileData' and count(parameter)=0]"
			[Register ("getTenantProfileData", "()Ljava/util/List;", "GetGetTenantProfileDataHandler")]
			get {
				const string __id = "getTenantProfileData.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenType;
#pragma warning disable 0169
		static Delegate GetGetTokenTypeHandler ()
		{
			if (cb_getTokenType == null)
				cb_getTokenType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenType);
			return cb_getTokenType;
		}

		static IntPtr n_GetTokenType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenType);
		}
#pragma warning restore 0169

		public virtual unsafe string TokenType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getTokenType' and count(parameter)=0]"
			[Register ("getTokenType", "()Ljava/lang/String;", "GetGetTokenTypeHandler")]
			get {
				const string __id = "getTokenType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		public virtual unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResult']/method[@name='getUserName' and count(parameter)=0]"
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
