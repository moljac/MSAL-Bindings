using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerOperationExecutor']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/BrokerOperationExecutor", DoNotGenerateAcw=true)]
	public partial class BrokerOperationExecutor : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']"
		[Register ("com/microsoft/identity/common/internal/controllers/BrokerOperationExecutor$BrokerOperation", "", "Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IBrokerOperation : IJavaObject, IJavaPeerable {
			global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle Bundle {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']/method[@name='getBundle' and count(parameter)=0]"
				[Register ("getBundle", "()Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;", "GetGetBundleHandler:Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker, Microsoft.Identity.Common")]
				get; 
			}

			string MethodName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']/method[@name='getMethodName' and count(parameter)=0]"
				[Register ("getMethodName", "()Ljava/lang/String;", "GetGetMethodNameHandler:Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker, Microsoft.Identity.Common")]
				get; 
			}

			string TelemetryApiId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']/method[@name='getTelemetryApiId' and count(parameter)=0]"
				[Register ("getTelemetryApiId", "()Ljava/lang/String;", "GetGetTelemetryApiIdHandler:Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker, Microsoft.Identity.Common")]
				get; 
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']/method[@name='extractResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("extractResultBundle", "(Landroid/os/Bundle;)Ljava/lang/Object;", "GetExtractResultBundle_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker, Microsoft.Identity.Common")]
			global::Java.Lang.Object ExtractResultBundle (global::Android.OS.Bundle p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']/method[@name='performPrerequisites' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.IIpcStrategy']]"
			[Register ("performPrerequisites", "(Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy;)V", "GetPerformPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Handler:Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker, Microsoft.Identity.Common")]
			void PerformPrerequisites (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/interface[@name='BrokerOperationExecutor.BrokerOperation']/method[@name='putValueInSuccessEvent' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.events.ApiEndEvent'] and parameter[2][@type='T']]"
			[Register ("putValueInSuccessEvent", "(Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;Ljava/lang/Object;)V", "GetPutValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_Handler:Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor/IBrokerOperationInvoker, Microsoft.Identity.Common")]
			void PutValueInSuccessEvent (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/BrokerOperationExecutor$BrokerOperation", DoNotGenerateAcw=true)]
		internal partial class IBrokerOperationInvoker : global::Java.Lang.Object, IBrokerOperation {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/BrokerOperationExecutor$BrokerOperation", typeof (IBrokerOperationInvoker));

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

			public static IBrokerOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBrokerOperation> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.controllers.BrokerOperationExecutor.BrokerOperation"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBrokerOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getBundle;
#pragma warning disable 0169
			static Delegate GetGetBundleHandler ()
			{
				if (cb_getBundle == null)
					cb_getBundle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBundle);
				return cb_getBundle;
			}

			static IntPtr n_GetBundle (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Bundle);
			}
#pragma warning restore 0169

			IntPtr id_getBundle;
			public unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle Bundle {
				get {
					if (id_getBundle == IntPtr.Zero)
						id_getBundle = JNIEnv.GetMethodID (class_ref, "getBundle", "()Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;");
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBundle), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getMethodName;
#pragma warning disable 0169
			static Delegate GetGetMethodNameHandler ()
			{
				if (cb_getMethodName == null)
					cb_getMethodName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMethodName);
				return cb_getMethodName;
			}

			static IntPtr n_GetMethodName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MethodName);
			}
#pragma warning restore 0169

			IntPtr id_getMethodName;
			public unsafe string MethodName {
				get {
					if (id_getMethodName == IntPtr.Zero)
						id_getMethodName = JNIEnv.GetMethodID (class_ref, "getMethodName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethodName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTelemetryApiId;
#pragma warning disable 0169
			static Delegate GetGetTelemetryApiIdHandler ()
			{
				if (cb_getTelemetryApiId == null)
					cb_getTelemetryApiId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTelemetryApiId);
				return cb_getTelemetryApiId;
			}

			static IntPtr n_GetTelemetryApiId (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TelemetryApiId);
			}
#pragma warning restore 0169

			IntPtr id_getTelemetryApiId;
			public unsafe string TelemetryApiId {
				get {
					if (id_getTelemetryApiId == IntPtr.Zero)
						id_getTelemetryApiId = JNIEnv.GetMethodID (class_ref, "getTelemetryApiId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTelemetryApiId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_extractResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetExtractResultBundle_Landroid_os_Bundle_Handler ()
			{
				if (cb_extractResultBundle_Landroid_os_Bundle_ == null)
					cb_extractResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExtractResultBundle_Landroid_os_Bundle_);
				return cb_extractResultBundle_Landroid_os_Bundle_;
			}

			static IntPtr n_ExtractResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractResultBundle (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_extractResultBundle_Landroid_os_Bundle_;
			public unsafe global::Java.Lang.Object ExtractResultBundle (global::Android.OS.Bundle p0)
			{
				if (id_extractResultBundle_Landroid_os_Bundle_ == IntPtr.Zero)
					id_extractResultBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extractResultBundle", "(Landroid/os/Bundle;)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractResultBundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_;
#pragma warning disable 0169
			static Delegate GetPerformPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_Handler ()
			{
				if (cb_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_ == null)
					cb_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PerformPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_);
				return cb_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_;
			}

			static void n_PerformPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PerformPrerequisites (p0);
			}
#pragma warning restore 0169

			IntPtr id_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_;
			public unsafe void PerformPrerequisites (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy p0)
			{
				if (id_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_ == IntPtr.Zero)
					id_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_ = JNIEnv.GetMethodID (class_ref, "performPrerequisites", "(Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_performPrerequisites_Lcom_microsoft_identity_common_internal_broker_ipc_IIpcStrategy_, __args);
			}

			static Delegate cb_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetPutValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_Handler ()
			{
				if (cb_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_ == null)
					cb_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_);
				return cb_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_;
			}

			static void n_PutValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.PutValueInSuccessEvent (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_;
			public unsafe void PutValueInSuccessEvent (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent p0, global::Java.Lang.Object p1)
			{
				if (id_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_ == IntPtr.Zero)
					id_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putValueInSuccessEvent", "(Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;Ljava/lang/Object;)V");
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putValueInSuccessEvent_Lcom_microsoft_identity_common_internal_telemetry_events_ApiEndEvent_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/BrokerOperationExecutor", typeof (BrokerOperationExecutor));

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

		protected BrokerOperationExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerOperationExecutor']/constructor[@name='BrokerOperationExecutor' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.common.internal.broker.ipc.IIpcStrategy&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe BrokerOperationExecutor (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy> strategies) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_strategies = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IIpcStrategy>.ToLocalJniHandle (strategies);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strategies);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_strategies);
				global::System.GC.KeepAlive (strategies);
			}
		}

		static Delegate cb_execute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_Handler ()
		{
			if (cb_execute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_ == null)
				cb_execute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Execute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_);
			return cb_execute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_;
		}

		static IntPtr n_Execute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters, IntPtr native_operation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_parameters, JniHandleOwnership.DoNotTransfer);
			var operation = (global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation> (native_operation, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (parameters, operation));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='BrokerOperationExecutor']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.BrokerOperationExecutor.BrokerOperation&lt;U&gt;']]"
		[Register ("execute", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Lcom/microsoft/identity/common/internal/controllers/BrokerOperationExecutor$BrokerOperation;)Ljava/lang/Object;", "GetExecute_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Lcom_microsoft_identity_common_internal_controllers_BrokerOperationExecutor_BrokerOperation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.internal.commands.parameters.CommandParameters", "U"})]
		public virtual unsafe global::Java.Lang.Object Execute (global::Java.Lang.Object parameters, global::Com.Microsoft.Identity.Common.Internal.Controllers.BrokerOperationExecutor.IBrokerOperation operation)
		{
			const string __id = "execute.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Lcom/microsoft/identity/common/internal/controllers/BrokerOperationExecutor$BrokerOperation;)Ljava/lang/Object;";
			IntPtr native_parameters = JNIEnv.ToLocalJniHandle (parameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_parameters);
				__args [1] = new JniArgumentValue ((operation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) operation).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_parameters);
				global::System.GC.KeepAlive (parameters);
				global::System.GC.KeepAlive (operation);
			}
		}

	}
}
