using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/request/MsalBrokerRequestAdapter", DoNotGenerateAcw=true)]
	public partial class MsalBrokerRequestAdapter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/request/MsalBrokerRequestAdapter", typeof (MsalBrokerRequestAdapter));

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

		protected MsalBrokerRequestAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/constructor[@name='MsalBrokerRequestAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MsalBrokerRequestAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor> BrowserSafeListForBroker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getBrowserSafeListForBroker' and count(parameter)=0]"
			[Register ("getBrowserSafeListForBroker", "()Ljava/util/List;", "")]
			get {
				const string __id = "getBrowserSafeListForBroker.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_brokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetBrokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler ()
		{
			if (cb_brokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ == null)
				cb_brokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BrokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_);
			return cb_brokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
		}

		static IntPtr n_BrokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BrokerRequestFromAcquireTokenParameters (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='brokerRequestFromAcquireTokenParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
		[Register ("brokerRequestFromAcquireTokenParameters", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest;", "GetBrokerRequestFromAcquireTokenParameters_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest BrokerRequestFromAcquireTokenParameters (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters)
		{
			const string __id = "brokerRequestFromAcquireTokenParameters.(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_brokerRequestFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetBrokerRequestFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_brokerRequestFromBundle_Landroid_os_Bundle_ == null)
				cb_brokerRequestFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BrokerRequestFromBundle_Landroid_os_Bundle_);
			return cb_brokerRequestFromBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_BrokerRequestFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_requestBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BrokerRequestFromBundle (requestBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='brokerRequestFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("brokerRequestFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest;", "GetBrokerRequestFromBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest BrokerRequestFromBundle (global::Android.OS.Bundle requestBundle)
		{
			const string __id = "brokerRequestFromBundle.(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (requestBundle);
			}
		}

		static Delegate cb_brokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetBrokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler ()
		{
			if (cb_brokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ == null)
				cb_brokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BrokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_);
			return cb_brokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_;
		}

		static IntPtr n_BrokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BrokerRequestFromSilentOperationParameters (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='brokerRequestFromSilentOperationParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
		[Register ("brokerRequestFromSilentOperationParameters", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest;", "GetBrokerRequestFromSilentOperationParameters_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest BrokerRequestFromSilentOperationParameters (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters parameters)
		{
			const string __id = "brokerRequestFromSilentOperationParameters.(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;)Lcom/microsoft/identity/common/internal/broker/BrokerRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_ == null)
				cb_getRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_);
			return cb_getRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForAcquireTokenInteractive (parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForAcquireTokenInteractive' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRequestBundleForAcquireTokenInteractive", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetRequestBundleForAcquireTokenInteractive_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForAcquireTokenInteractive (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestBundleForAcquireTokenInteractive.(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_ == null)
				cb_getRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_);
			return cb_getRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForAcquireTokenSilent (parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForAcquireTokenSilent' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRequestBundleForAcquireTokenSilent", "(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetRequestBundleForAcquireTokenSilent_Lcom_microsoft_identity_common_internal_commands_parameters_SilentTokenCommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForAcquireTokenSilent (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestBundleForAcquireTokenSilent.(Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_ == null)
				cb_getRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_);
			return cb_getRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForGenerateShr (parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForGenerateShr' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.GenerateShrCommandParameters'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRequestBundleForGenerateShr", "(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetRequestBundleForGenerateShr_Lcom_microsoft_identity_common_internal_commands_parameters_GenerateShrCommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForGenerateShr (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestBundleForGenerateShr.(Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_ == null)
				cb_getRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_);
			return cb_getRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForGetAccounts (parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForGetAccounts' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRequestBundleForGetAccounts", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetRequestBundleForGetAccounts_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForGetAccounts (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestBundleForGetAccounts.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_getRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_getRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_getRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static IntPtr n_GetRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForHello (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForHello' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("getRequestBundleForHello", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Landroid/os/Bundle;", "GetGetRequestBundleForHello_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForHello (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters)
		{
			const string __id = "getRequestBundleForHello.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_ == null)
				cb_getRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_);
			return cb_getRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForRemoveAccount (parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForRemoveAccount' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRequestBundleForRemoveAccount", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetRequestBundleForRemoveAccount_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForRemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestBundleForRemoveAccount.(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_ == null)
				cb_getRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_);
			return cb_getRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBundleForRemoveAccountFromSharedDevice (parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestBundleForRemoveAccountFromSharedDevice' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.RemoveAccountCommandParameters'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRequestBundleForRemoveAccountFromSharedDevice", "(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetRequestBundleForRemoveAccountFromSharedDevice_Lcom_microsoft_identity_common_internal_commands_parameters_RemoveAccountCommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetRequestBundleForRemoveAccountFromSharedDevice (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestBundleForRemoveAccountFromSharedDevice.(Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_getRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_ == null)
				cb_getRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_);
			return cb_getRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle, IntPtr native_parameters, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.MsalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestIntentForAcquireTokenInteractive (resultBundle, parameters, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='MsalBrokerRequestAdapter']/method[@name='getRequestIntentForAcquireTokenInteractive' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters'] and parameter[3][@type='java.lang.String']]"
		[Register ("getRequestIntentForAcquireTokenInteractive", "(Landroid/os/Bundle;Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Ljava/lang/String;)Landroid/content/Intent;", "GetGetRequestIntentForAcquireTokenInteractive_Landroid_os_Bundle_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Content.Intent GetRequestIntentForAcquireTokenInteractive (global::Android.OS.Bundle resultBundle, global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "getRequestIntentForAcquireTokenInteractive.(Landroid/os/Bundle;Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Ljava/lang/String;)Landroid/content/Intent;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [2] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (resultBundle);
				global::System.GC.KeepAlive (parameters);
			}
		}

	}
}
