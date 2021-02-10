using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/exception/MsalArgumentException", DoNotGenerateAcw=true)]
	public partial class MsalArgumentException : global::Com.Microsoft.Identity.Client.Exception.MsalException {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/field[@name='ACQUIRE_TOKEN_OPERATION_NAME']"
		[Register ("ACQUIRE_TOKEN_OPERATION_NAME")]
		public const string AcquireTokenOperationName = (string) "acquireToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/field[@name='ACQUIRE_TOKEN_SILENT_OPERATION_NAME']"
		[Register ("ACQUIRE_TOKEN_SILENT_OPERATION_NAME")]
		public const string AcquireTokenSilentOperationName = (string) "acquireTokenSilent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/field[@name='AUTHORITY_REQUIRED_FOR_SILENT']"
		[Register ("AUTHORITY_REQUIRED_FOR_SILENT")]
		public const string AuthorityRequiredForSilent = (string) "Authority must be specified for acquireTokenSilent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/field[@name='IACCOUNT_ARGUMENT_NAME']"
		[Register ("IACCOUNT_ARGUMENT_NAME")]
		public const string IaccountArgumentName = (string) "account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/field[@name='SCOPE_ARGUMENT_NAME']"
		[Register ("SCOPE_ARGUMENT_NAME")]
		public const string ScopeArgumentName = (string) "scopes";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/exception/MsalArgumentException", typeof (MsalArgumentException));

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

		protected MsalArgumentException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/constructor[@name='MsalArgumentException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MsalArgumentException (string argumentName, string message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_argumentName = JNIEnv.NewString (argumentName);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_argumentName);
				__args [1] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_argumentName);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/constructor[@name='MsalArgumentException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MsalArgumentException (string operationName, string argumentName, string message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_operationName = JNIEnv.NewString (operationName);
			IntPtr native_argumentName = JNIEnv.NewString (argumentName);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_operationName);
				__args [1] = new JniArgumentValue (native_argumentName);
				__args [2] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_operationName);
				JNIEnv.DeleteLocalRef (native_argumentName);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/constructor[@name='MsalArgumentException' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MsalArgumentException (string operationName, string argumentName, string message, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_operationName = JNIEnv.NewString (operationName);
			IntPtr native_argumentName = JNIEnv.NewString (argumentName);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_operationName);
				__args [1] = new JniArgumentValue (native_argumentName);
				__args [2] = new JniArgumentValue (native_message);
				__args [3] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_operationName);
				JNIEnv.DeleteLocalRef (native_argumentName);
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		static Delegate cb_getArgumentName;
#pragma warning disable 0169
		static Delegate GetGetArgumentNameHandler ()
		{
			if (cb_getArgumentName == null)
				cb_getArgumentName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArgumentName);
			return cb_getArgumentName;
		}

		static IntPtr n_GetArgumentName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalArgumentException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ArgumentName);
		}
#pragma warning restore 0169

		public virtual unsafe string ArgumentName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/method[@name='getArgumentName' and count(parameter)=0]"
			[Register ("getArgumentName", "()Ljava/lang/String;", "GetGetArgumentNameHandler")]
			get {
				const string __id = "getArgumentName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOperationName;
#pragma warning disable 0169
		static Delegate GetGetOperationNameHandler ()
		{
			if (cb_getOperationName == null)
				cb_getOperationName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOperationName);
			return cb_getOperationName;
		}

		static IntPtr n_GetOperationName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalArgumentException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OperationName);
		}
#pragma warning restore 0169

		public virtual unsafe string OperationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalArgumentException']/method[@name='getOperationName' and count(parameter)=0]"
			[Register ("getOperationName", "()Ljava/lang/String;", "GetGetOperationNameHandler")]
			get {
				const string __id = "getOperationName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
