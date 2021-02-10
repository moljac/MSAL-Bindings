using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker.Ipc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type", DoNotGenerateAcw=true)]
	public sealed partial class IpcStrategyType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']/field[@name='ACCOUNT_MANAGER_ADD_ACCOUNT']"
		[Register ("ACCOUNT_MANAGER_ADD_ACCOUNT")]
		public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType AccountManagerAddAccount {
			get {
				const string __id = "ACCOUNT_MANAGER_ADD_ACCOUNT.Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']/field[@name='BOUND_SERVICE']"
		[Register ("BOUND_SERVICE")]
		public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType BoundService {
			get {
				const string __id = "BOUND_SERVICE.Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']/field[@name='CONTENT_PROVIDER']"
		[Register ("CONTENT_PROVIDER")]
		public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType ContentProvider {
			get {
				const string __id = "CONTENT_PROVIDER.Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']/field[@name='LEGACY_ACCOUNT_MANAGER_FOR_BROKER_API']"
		[Register ("LEGACY_ACCOUNT_MANAGER_FOR_BROKER_API")]
		public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType LegacyAccountManagerForBrokerApi {
			get {
				const string __id = "LEGACY_ACCOUNT_MANAGER_FOR_BROKER_API.Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type", typeof (IpcStrategyType));

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

		internal IpcStrategyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='IIpcStrategy.Type']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/interface[@name='IIpcStrategy']"
	[Register ("com/microsoft/identity/common/internal/broker/ipc/IIpcStrategy", "", "Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategyInvoker")]
	public partial interface IIpcStrategy : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/interface[@name='IIpcStrategy']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;", "GetGetTypeHandler:Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategyInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/interface[@name='IIpcStrategy']/method[@name='communicateToBroker' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.BrokerOperationBundle']]"
		[Register ("communicateToBroker", "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;)Landroid/os/Bundle;", "GetCommunicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Handler:Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategyInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle CommunicateToBroker (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/ipc/IIpcStrategy", DoNotGenerateAcw=true)]
	internal partial class IIpcStrategyInvoker : global::Java.Lang.Object, IIpcStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/ipc/IIpcStrategy", typeof (IIpcStrategyInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IIpcStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIpcStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.broker.ipc.IIpcStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIpcStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_CommunicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CommunicateToBroker (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_;
		public unsafe global::Android.OS.Bundle CommunicateToBroker (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle p0)
		{
			if (id_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ == IntPtr.Zero)
				id_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ = JNIEnv.GetMethodID (class_ref, "communicateToBroker", "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_communicateToBroker_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
