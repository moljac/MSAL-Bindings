using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerAccountServiceClient']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerAccountServiceClient", DoNotGenerateAcw=true)]
	public partial class BrokerAccountServiceClient : global::Com.Microsoft.Identity.Common.Internal.Broker.BoundServiceClient {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerAccountServiceClient", typeof (BrokerAccountServiceClient));

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

		protected BrokerAccountServiceClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerAccountServiceClient']/constructor[@name='BrokerAccountServiceClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BrokerAccountServiceClient (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerAccountServiceClient']/constructor[@name='BrokerAccountServiceClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe BrokerAccountServiceClient (global::Android.Content.Context context, int timeOutInSeconds) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (timeOutInSeconds);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_performOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_;
#pragma warning disable 0169
		static Delegate GetPerformOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_Handler ()
		{
			if (cb_performOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_ == null)
				cb_performOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_PerformOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_);
			return cb_performOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_;
		}

		static IntPtr n_PerformOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brokerOperationBundle, IntPtr native_brokerAccountService)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerAccountServiceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var brokerOperationBundle = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (native_brokerOperationBundle, JniHandleOwnership.DoNotTransfer);
			var brokerAccountService = (global::Com.Microsoft.Aad.Adal.IBrokerAccountService)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (native_brokerAccountService, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformOperationInternal (brokerOperationBundle, brokerAccountService));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerAccountServiceClient']/method[@name='performOperationInternal' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.BrokerOperationBundle'] and parameter[2][@type='com.microsoft.aad.adal.IBrokerAccountService']]"
		[Register ("performOperationInternal", "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;Lcom/microsoft/aad/adal/IBrokerAccountService;)Landroid/os/Bundle;", "GetPerformOperationInternal_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Lcom_microsoft_aad_adal_IBrokerAccountService_Handler")]
		public virtual unsafe global::Android.OS.Bundle PerformOperationInternal (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle brokerOperationBundle, global::Com.Microsoft.Aad.Adal.IBrokerAccountService brokerAccountService)
		{
			const string __id = "performOperationInternal.(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;Lcom/microsoft/aad/adal/IBrokerAccountService;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((brokerOperationBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) brokerOperationBundle).Handle);
				__args [1] = new JniArgumentValue ((brokerAccountService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) brokerAccountService).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (brokerOperationBundle);
				global::System.GC.KeepAlive (brokerAccountService);
			}
		}

	}
}
