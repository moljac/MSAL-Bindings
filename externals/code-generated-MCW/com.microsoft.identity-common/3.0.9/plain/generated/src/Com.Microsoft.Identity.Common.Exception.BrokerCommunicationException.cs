using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/BrokerCommunicationException", DoNotGenerateAcw=true)]
	public partial class BrokerCommunicationException : global::Com.Microsoft.Identity.Common.Exception.BaseException {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException.Category']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/BrokerCommunicationException$Category", DoNotGenerateAcw=true)]
		public sealed partial class Category : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException.Category']/field[@name='CONNECTION_ERROR']"
			[Register ("CONNECTION_ERROR")]
			public static global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category ConnectionError {
				get {
					const string __id = "CONNECTION_ERROR.Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException.Category']/field[@name='OPERATION_NOT_SUPPORTED_ON_CLIENT_SIDE']"
			[Register ("OPERATION_NOT_SUPPORTED_ON_CLIENT_SIDE")]
			public static global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category OperationNotSupportedOnClientSide {
				get {
					const string __id = "OPERATION_NOT_SUPPORTED_ON_CLIENT_SIDE.Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException.Category']/field[@name='OPERATION_NOT_SUPPORTED_ON_SERVER_SIDE']"
			[Register ("OPERATION_NOT_SUPPORTED_ON_SERVER_SIDE")]
			public static global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category OperationNotSupportedOnServerSide {
				get {
					const string __id = "OPERATION_NOT_SUPPORTED_ON_SERVER_SIDE.Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/BrokerCommunicationException$Category", typeof (Category));

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

			internal Category (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException.Category']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException.Category']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/BrokerCommunicationException", typeof (BrokerCommunicationException));

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

		protected BrokerCommunicationException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException']/constructor[@name='BrokerCommunicationException' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.exception.BrokerCommunicationException.Category'] and parameter[2][@type='com.microsoft.identity.common.internal.broker.ipc.IIpcStrategy.Type'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe BrokerCommunicationException (global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category category, global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType strategyType, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((category == null) ? IntPtr.Zero : ((global::Java.Lang.Object) category).Handle);
				__args [1] = new JniArgumentValue ((strategyType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategyType).Handle);
				__args [2] = new JniArgumentValue (native_errorMessage);
				__args [3] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (category);
				global::System.GC.KeepAlive (strategyType);
				global::System.GC.KeepAlive (throwable);
			}
		}

		static Delegate cb_getStrategyType;
#pragma warning disable 0169
		static Delegate GetGetStrategyTypeHandler ()
		{
			if (cb_getStrategyType == null)
				cb_getStrategyType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStrategyType);
			return cb_getStrategyType;
		}

		static IntPtr n_GetStrategyType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StrategyType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType StrategyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException']/method[@name='getStrategyType' and count(parameter)=0]"
			[Register ("getStrategyType", "()Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;", "GetGetStrategyTypeHandler")]
			get {
				const string __id = "getStrategyType.()Lcom/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCategory;
#pragma warning disable 0169
		static Delegate GetGetCategoryHandler ()
		{
			if (cb_getCategory == null)
				cb_getCategory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCategory);
			return cb_getCategory;
		}

		static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCategory ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BrokerCommunicationException']/method[@name='getCategory' and count(parameter)=0]"
		[Register ("getCategory", "()Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;", "GetGetCategoryHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category GetCategory ()
		{
			const string __id = "getCategory.()Lcom/microsoft/identity/common/exception/BrokerCommunicationException$Category;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BrokerCommunicationException.Category> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
