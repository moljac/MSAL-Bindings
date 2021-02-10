using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='AdalBrokerRequestAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/request/AdalBrokerRequestAdapter", DoNotGenerateAcw=true)]
	public partial class AdalBrokerRequestAdapter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/request/AdalBrokerRequestAdapter", typeof (AdalBrokerRequestAdapter));

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

		protected AdalBrokerRequestAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='AdalBrokerRequestAdapter']/constructor[@name='AdalBrokerRequestAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdalBrokerRequestAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.AdalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BrokerRequestFromAcquireTokenParameters (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='AdalBrokerRequestAdapter']/method[@name='brokerRequestFromAcquireTokenParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.AdalBrokerRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BrokerRequestFromSilentOperationParameters (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='AdalBrokerRequestAdapter']/method[@name='brokerRequestFromSilentOperationParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.SilentTokenCommandParameters']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='AdalBrokerRequestAdapter']/method[@name='getRequestAuthorityWithExtraQP' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("getRequestAuthorityWithExtraQP", "(Ljava/lang/String;Ljava/util/List;)Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAuthority;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority GetRequestAuthorityWithExtraQP (string authority, global::System.Collections.Generic.IList<global::Android.Util.Pair> extraQP)
		{
			const string __id = "getRequestAuthorityWithExtraQP.(Ljava/lang/String;Ljava/util/List;)Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAuthority;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_extraQP = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (extraQP);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_extraQP);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAuthority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_extraQP);
				global::System.GC.KeepAlive (extraQP);
			}
		}

	}
}
