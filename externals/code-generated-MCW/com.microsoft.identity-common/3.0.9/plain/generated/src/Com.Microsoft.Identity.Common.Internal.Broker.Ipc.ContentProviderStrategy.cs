using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker.Ipc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='ContentProviderStrategy']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/ipc/ContentProviderStrategy", DoNotGenerateAcw=true)]
	public partial class ContentProviderStrategy : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/ipc/ContentProviderStrategy", typeof (ContentProviderStrategy));

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

		protected ContentProviderStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='ContentProviderStrategy']/constructor[@name='ContentProviderStrategy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ContentProviderStrategy (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.ContentProviderStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='ContentProviderStrategy']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_;
#pragma warning disable 0169
		static Delegate GetCommunicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Handler ()
		{
			if (cb_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ == null)
				cb_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CommunicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_);
			return cb_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_;
		}

		static IntPtr n_CommunicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brokerOperationBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.ContentProviderStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var brokerOperationBundle = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (native_brokerOperationBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CommunicateToBroker (brokerOperationBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='ContentProviderStrategy']/method[@name='communicateToBroker' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.BrokerOperationBundle']]"
		[Register ("communicateToBroker", "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;)Landroid/os/Bundle;", "GetCommunicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle CommunicateToBroker (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle brokerOperationBundle)
		{
			const string __id = "communicateToBroker.(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((brokerOperationBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) brokerOperationBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (brokerOperationBundle);
			}
		}

		static Delegate cb_isBrokerContentProviderAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBrokerContentProviderAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_isBrokerContentProviderAvailable_Ljava_lang_String_ == null)
				cb_isBrokerContentProviderAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsBrokerContentProviderAvailable_Ljava_lang_String_);
			return cb_isBrokerContentProviderAvailable_Ljava_lang_String_;
		}

		static bool n_IsBrokerContentProviderAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetedBrokerPackageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.ContentProviderStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetedBrokerPackageName = JNIEnv.GetString (native_targetedBrokerPackageName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsBrokerContentProviderAvailable (targetedBrokerPackageName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='ContentProviderStrategy']/method[@name='isBrokerContentProviderAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBrokerContentProviderAvailable", "(Ljava/lang/String;)Z", "GetIsBrokerContentProviderAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsBrokerContentProviderAvailable (string targetedBrokerPackageName)
		{
			const string __id = "isBrokerContentProviderAvailable.(Ljava/lang/String;)Z";
			IntPtr native_targetedBrokerPackageName = JNIEnv.NewString (targetedBrokerPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_targetedBrokerPackageName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_targetedBrokerPackageName);
			}
		}

	}
}
