using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/BrokerMsalController", DoNotGenerateAcw=true)]
	public partial class BrokerMsalController : global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/field[@name='mRequestAdapter']"
		[Register ("mRequestAdapter")]
		protected global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter MRequestAdapter {
			get {
				const string __id = "mRequestAdapter.Lcom/microsoft/identity/common/internal/request/MsalBrokerRequestAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRequestAdapter.Lcom/microsoft/identity/common/internal/request/MsalBrokerRequestAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/field[@name='mResultAdapter']"
		[Register ("mResultAdapter")]
		protected global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter MResultAdapter {
			get {
				const string __id = "mResultAdapter.Lcom/microsoft/identity/common/internal/result/MsalBrokerResultAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mResultAdapter.Lcom/microsoft/identity/common/internal/result/MsalBrokerResultAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/BrokerMsalController", typeof (BrokerMsalController));

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

		protected BrokerMsalController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/constructor[@name='BrokerMsalController' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BrokerMsalController (global::Android.Content.Context applicationContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (applicationContext);
			}
		}

		static Delegate cb_getActiveBrokerPackageName;
#pragma warning disable 0169
		static Delegate GetGetActiveBrokerPackageNameHandler ()
		{
			if (cb_getActiveBrokerPackageName == null)
				cb_getActiveBrokerPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActiveBrokerPackageName);
			return cb_getActiveBrokerPackageName;
		}

		static IntPtr n_GetActiveBrokerPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActiveBrokerPackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string ActiveBrokerPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='getActiveBrokerPackageName' and count(parameter)=0]"
			[Register ("getActiveBrokerPackageName", "()Ljava/lang/String;", "GetGetActiveBrokerPackageNameHandler")]
			get {
				const string __id = "getActiveBrokerPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHelloCache;
#pragma warning disable 0169
		static Delegate GetGetHelloCacheHandler ()
		{
			if (cb_getHelloCache == null)
				cb_getHelloCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHelloCache);
			return cb_getHelloCache;
		}

		static IntPtr n_GetHelloCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HelloCache);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.HelloCache HelloCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='getHelloCache' and count(parameter)=0]"
			[Register ("getHelloCache", "()Lcom/microsoft/identity/common/internal/cache/HelloCache;", "GetGetHelloCacheHandler")]
			get {
				const string __id = "getHelloCache.()Lcom/microsoft/identity/common/internal/cache/HelloCache;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.HelloCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static IntPtr n_AcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorizationResult, IntPtr native_commandParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorizationResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (native_authorizationResult, JniHandleOwnership.DoNotTransfer);
			var commandParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters> (native_commandParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireDeviceCodeFlowToken (authorizationResult, commandParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='acquireDeviceCodeFlowToken' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResult'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters']]"
		[Register ("acquireDeviceCodeFlowToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireDeviceCodeFlowToken_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationResult_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireDeviceCodeFlowToken (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult authorizationResult, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters commandParameters)
		{
			const string __id = "acquireDeviceCodeFlowToken.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((authorizationResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authorizationResult).Handle);
				__args [1] = new JniArgumentValue ((commandParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commandParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (authorizationResult);
				global::System.GC.KeepAlive (commandParameters);
			}
		}

		static Delegate cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler ()
		{
			if (cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ == null)
				cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_);
			return cb_acquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
		}

		static IntPtr n_AcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireToken (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='acquireToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
		[Register ("acquireToken", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireToken_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireToken (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters)
		{
			const string __id = "acquireToken.(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler ()
		{
			if (cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ == null)
				cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_);
			return cb_acquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
		}

		static IntPtr n_AcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='acquireTokenSilent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
		[Register ("acquireTokenSilent", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult AcquireTokenSilent (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters parameters)
		{
			const string __id = "acquireTokenSilent.(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
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

		static void n_CompleteAcquireToken_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int requestCode, int resultCode, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.CompleteAcquireToken (requestCode, resultCode, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='completeAcquireToken' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeAcquireToken", "(IILandroid/content/Intent;)V", "GetCompleteAcquireToken_IILandroid_content_Intent_Handler")]
		public override unsafe void CompleteAcquireToken (int requestCode, int resultCode, global::Android.Content.Intent data)
		{
			const string __id = "completeAcquireToken.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestCode);
				__args [1] = new JniArgumentValue (resultCode);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_;
#pragma warning disable 0169
		static Delegate GetDeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler ()
		{
			if (cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ == null)
				cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_);
			return cb_deviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_;
		}

		static IntPtr n_DeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeviceCodeFlowAuthRequest (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='deviceCodeFlowAuthRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters']]"
		[Register ("deviceCodeFlowAuthRequest", "(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;", "GetDeviceCodeFlowAuthRequest_Lcom_microsoft_identity_common_internal_commands_parameters_DeviceCodeFlowCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult DeviceCodeFlowAuthRequest (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters parameters)
		{
			const string __id = "deviceCodeFlowAuthRequest.(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
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

		static IntPtr n_GenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateSignedHttpRequest (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.GenerateShrCommandParameters']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters parameters)
		{
			const string __id = "generateSignedHttpRequest.(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_getAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static IntPtr n_GetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetAccounts (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getAccounts", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;", "GetGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccounts (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters)
		{
			const string __id = "getAccounts.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_GetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetCurrentAccount (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getCurrentAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;", "GetGetCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetCurrentAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters)
		{
			const string __id = "getCurrentAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_GetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_getDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static bool n_GetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetDeviceMode (parameters);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='getDeviceMode' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getDeviceMode", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Z", "GetGetDeviceMode_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public override unsafe bool GetDeviceMode (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters)
		{
			const string __id = "getDeviceMode.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_hello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetHello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_hello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_hello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Hello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_hello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static IntPtr n_Hello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Hello (strategy, parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='hello' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.IIpcStrategy'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("hello", "(Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy;Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/lang/String;", "GetHello_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public virtual unsafe string Hello (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy strategy, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters)
		{
			const string __id = "hello.(Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy;Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (parameters);
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

		static bool n_RemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (parameters);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler")]
		public override unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters parameters)
		{
			const string __id = "removeAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_;
#pragma warning disable 0169
		static Delegate GetRemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler ()
		{
			if (cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ == null)
				cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_);
			return cb_removeCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_;
		}

		static bool n_RemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerMsalController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCurrentAccount (parameters);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerMsalController']/method[@name='removeCurrentAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters']]"
		[Register ("removeCurrentAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z", "GetRemoveCurrentAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Handler")]
		public override unsafe bool RemoveCurrentAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters parameters)
		{
			const string __id = "removeCurrentAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

	}
}
