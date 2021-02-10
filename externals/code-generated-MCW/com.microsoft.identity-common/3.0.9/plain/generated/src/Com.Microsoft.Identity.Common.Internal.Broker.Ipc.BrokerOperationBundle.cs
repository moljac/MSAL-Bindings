using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker.Ipc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle", DoNotGenerateAcw=true)]
	public partial class BrokerOperationBundle : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation", DoNotGenerateAcw=true)]
		public sealed partial class Operation : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='BROKER_API_GET_BROKER_ACCOUNTS']"
			[Register ("BROKER_API_GET_BROKER_ACCOUNTS")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation BrokerApiGetBrokerAccounts {
				get {
					const string __id = "BROKER_API_GET_BROKER_ACCOUNTS.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='BROKER_API_HELLO']"
			[Register ("BROKER_API_HELLO")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation BrokerApiHello {
				get {
					const string __id = "BROKER_API_HELLO.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='BROKER_API_REMOVE_BROKER_ACCOUNT']"
			[Register ("BROKER_API_REMOVE_BROKER_ACCOUNT")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation BrokerApiRemoveBrokerAccount {
				get {
					const string __id = "BROKER_API_REMOVE_BROKER_ACCOUNT.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='BROKER_API_UPDATE_BRT']"
			[Register ("BROKER_API_UPDATE_BRT")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation BrokerApiUpdateBrt {
				get {
					const string __id = "BROKER_API_UPDATE_BRT.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='BROKER_GET_KEY_FROM_INACTIVE_BROKER']"
			[Register ("BROKER_GET_KEY_FROM_INACTIVE_BROKER")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation BrokerGetKeyFromInactiveBroker {
				get {
					const string __id = "BROKER_GET_KEY_FROM_INACTIVE_BROKER.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_ACQUIRE_TOKEN_SILENT']"
			[Register ("MSAL_ACQUIRE_TOKEN_SILENT")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalAcquireTokenSilent {
				get {
					const string __id = "MSAL_ACQUIRE_TOKEN_SILENT.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_GENERATE_SHR']"
			[Register ("MSAL_GENERATE_SHR")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalGenerateShr {
				get {
					const string __id = "MSAL_GENERATE_SHR.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_GET_ACCOUNTS']"
			[Register ("MSAL_GET_ACCOUNTS")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalGetAccounts {
				get {
					const string __id = "MSAL_GET_ACCOUNTS.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_GET_CURRENT_ACCOUNT_IN_SHARED_DEVICE']"
			[Register ("MSAL_GET_CURRENT_ACCOUNT_IN_SHARED_DEVICE")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalGetCurrentAccountInSharedDevice {
				get {
					const string __id = "MSAL_GET_CURRENT_ACCOUNT_IN_SHARED_DEVICE.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_GET_DEVICE_MODE']"
			[Register ("MSAL_GET_DEVICE_MODE")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalGetDeviceMode {
				get {
					const string __id = "MSAL_GET_DEVICE_MODE.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_GET_INTENT_FOR_INTERACTIVE_REQUEST']"
			[Register ("MSAL_GET_INTENT_FOR_INTERACTIVE_REQUEST")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalGetIntentForInteractiveRequest {
				get {
					const string __id = "MSAL_GET_INTENT_FOR_INTERACTIVE_REQUEST.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_HELLO']"
			[Register ("MSAL_HELLO")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalHello {
				get {
					const string __id = "MSAL_HELLO.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_REMOVE_ACCOUNT']"
			[Register ("MSAL_REMOVE_ACCOUNT")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalRemoveAccount {
				get {
					const string __id = "MSAL_REMOVE_ACCOUNT.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/field[@name='MSAL_SIGN_OUT_FROM_SHARED_DEVICE']"
			[Register ("MSAL_SIGN_OUT_FROM_SHARED_DEVICE")]
			public static global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation MsalSignOutFromSharedDevice {
				get {
					const string __id = "MSAL_SIGN_OUT_FROM_SHARED_DEVICE.Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation", typeof (Operation));

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

			internal Operation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle.Operation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle", typeof (BrokerOperationBundle));

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

		protected BrokerOperationBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']/constructor[@name='BrokerOperationBundle' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.common.internal.broker.ipc.BrokerOperationBundle.Operation'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public unsafe BrokerOperationBundle (global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation operation, string targetBrokerAppPackageName, global::Android.OS.Bundle bundle) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;Ljava/lang/String;Landroid/os/Bundle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_targetBrokerAppPackageName = JNIEnv.NewString (targetBrokerAppPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((operation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) operation).Handle);
				__args [1] = new JniArgumentValue (native_targetBrokerAppPackageName);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetBrokerAppPackageName);
				global::System.GC.KeepAlive (operation);
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_getAccountManagerBundle;
#pragma warning disable 0169
		static Delegate GetGetAccountManagerBundleHandler ()
		{
			if (cb_getAccountManagerBundle == null)
				cb_getAccountManagerBundle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccountManagerBundle);
			return cb_getAccountManagerBundle;
		}

		static IntPtr n_GetAccountManagerBundle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountManagerBundle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle AccountManagerBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']/method[@name='getAccountManagerBundle' and count(parameter)=0]"
			[Register ("getAccountManagerBundle", "()Landroid/os/Bundle;", "GetGetAccountManagerBundleHandler")]
			get {
				const string __id = "getAccountManagerBundle.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bundle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle Bundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']/method[@name='getBundle' and count(parameter)=0]"
			[Register ("getBundle", "()Landroid/os/Bundle;", "GetGetBundleHandler")]
			get {
				const string __id = "getBundle.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentProviderPath;
#pragma warning disable 0169
		static Delegate GetGetContentProviderPathHandler ()
		{
			if (cb_getContentProviderPath == null)
				cb_getContentProviderPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentProviderPath);
			return cb_getContentProviderPath;
		}

		static IntPtr n_GetContentProviderPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentProviderPath);
		}
#pragma warning restore 0169

		public virtual unsafe string ContentProviderPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']/method[@name='getContentProviderPath' and count(parameter)=0]"
			[Register ("getContentProviderPath", "()Ljava/lang/String;", "GetGetContentProviderPathHandler")]
			get {
				const string __id = "getContentProviderPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetBrokerAppPackageName;
#pragma warning disable 0169
		static Delegate GetGetTargetBrokerAppPackageNameHandler ()
		{
			if (cb_getTargetBrokerAppPackageName == null)
				cb_getTargetBrokerAppPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetBrokerAppPackageName);
			return cb_getTargetBrokerAppPackageName;
		}

		static IntPtr n_GetTargetBrokerAppPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetBrokerAppPackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string TargetBrokerAppPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']/method[@name='getTargetBrokerAppPackageName' and count(parameter)=0]"
			[Register ("getTargetBrokerAppPackageName", "()Ljava/lang/String;", "GetGetTargetBrokerAppPackageNameHandler")]
			get {
				const string __id = "getTargetBrokerAppPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOperation;
#pragma warning disable 0169
		static Delegate GetGetOperationHandler ()
		{
			if (cb_getOperation == null)
				cb_getOperation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOperation);
			return cb_getOperation;
		}

		static IntPtr n_GetOperation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOperation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker.ipc']/class[@name='BrokerOperationBundle']/method[@name='getOperation' and count(parameter)=0]"
		[Register ("getOperation", "()Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;", "GetGetOperationHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation GetOperation ()
		{
			const string __id = "getOperation.()Lcom/microsoft/identity/common/internal/broker/ipc/BrokerOperationBundle$Operation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.Ipc.BrokerOperationBundle.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
