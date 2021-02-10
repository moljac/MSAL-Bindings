using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BoundServiceClient", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.os.IInterface"})]
	public abstract partial class BoundServiceClient : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BoundServiceClient", typeof (BoundServiceClient));

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

		protected BoundServiceClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/constructor[@name='BoundServiceClient' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BoundServiceClient (global::Android.Content.Context context, string targetServiceClassName, string targetServiceIntentFilter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_targetServiceClassName = JNIEnv.NewString (targetServiceClassName);
			IntPtr native_targetServiceIntentFilter = JNIEnv.NewString (targetServiceIntentFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_targetServiceClassName);
				__args [2] = new JniArgumentValue (native_targetServiceIntentFilter);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetServiceClassName);
				JNIEnv.DeleteLocalRef (native_targetServiceIntentFilter);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/constructor[@name='BoundServiceClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe BoundServiceClient (global::Android.Content.Context context, string targetServiceClassName, string targetServiceIntentFilter, int timeOutInSeconds) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_targetServiceClassName = JNIEnv.NewString (targetServiceClassName);
			IntPtr native_targetServiceIntentFilter = JNIEnv.NewString (targetServiceIntentFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_targetServiceClassName);
				__args [2] = new JniArgumentValue (native_targetServiceIntentFilter);
				__args [3] = new JniArgumentValue (timeOutInSeconds);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetServiceClassName);
				JNIEnv.DeleteLocalRef (native_targetServiceIntentFilter);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Connect_Ljava_lang_String_);
			return cb_connect_Ljava_lang_String_;
		}

		static IntPtr n_Connect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetServicePackageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BoundServiceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetServicePackageName = JNIEnv.GetString (native_targetServicePackageName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (targetServicePackageName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/String;)Landroid/os/IInterface;", "GetConnect_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Java.Lang.Object Connect (string targetServicePackageName)
		{
			const string __id = "connect.(Ljava/lang/String;)Landroid/os/IInterface;";
			IntPtr native_targetServicePackageName = JNIEnv.NewString (targetServicePackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_targetServicePackageName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetServicePackageName);
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BoundServiceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isBoundServiceSupported_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBoundServiceSupported_Ljava_lang_String_Handler ()
		{
			if (cb_isBoundServiceSupported_Ljava_lang_String_ == null)
				cb_isBoundServiceSupported_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsBoundServiceSupported_Ljava_lang_String_);
			return cb_isBoundServiceSupported_Ljava_lang_String_;
		}

		static bool n_IsBoundServiceSupported_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetServicePackageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BoundServiceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetServicePackageName = JNIEnv.GetString (native_targetServicePackageName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsBoundServiceSupported (targetServicePackageName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/method[@name='isBoundServiceSupported' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBoundServiceSupported", "(Ljava/lang/String;)Z", "GetIsBoundServiceSupported_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsBoundServiceSupported (string targetServicePackageName)
		{
			const string __id = "isBoundServiceSupported.(Ljava/lang/String;)Z";
			IntPtr native_targetServicePackageName = JNIEnv.NewString (targetServicePackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_targetServicePackageName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_targetServicePackageName);
			}
		}

		static Delegate cb_performOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_;
#pragma warning disable 0169
		static Delegate GetPerformOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Handler ()
		{
			if (cb_performOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ == null)
				cb_performOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PerformOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_);
			return cb_performOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_;
		}

		static IntPtr n_PerformOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BoundServiceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputBundle = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (native_inputBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformOperation (inputBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BoundServiceClient']/method[@name='performOperation' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.BrokerOperationBundle']]"
		[Register ("performOperation", "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;)Landroid/os/Bundle;", "GetPerformOperation_Lcom_microsoft_identity_common_internal_broker_ipc_BrokerOperationBundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle PerformOperation (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle inputBundle)
		{
			const string __id = "performOperation.(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputBundle);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BoundServiceClient", DoNotGenerateAcw=true)]
	internal partial class BoundServiceClientInvoker : BoundServiceClient {
		public BoundServiceClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BoundServiceClient", typeof (BoundServiceClientInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
