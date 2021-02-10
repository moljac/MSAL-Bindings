using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='AsyncResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/AsyncResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class AsyncResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/AsyncResult", typeof (AsyncResult));

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

		protected AsyncResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='AsyncResult']/constructor[@name='AsyncResult' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register (".ctor", "(Ljava/lang/Object;Lcom/microsoft/identity/client/exception/MsalException;)V", "")]
		public unsafe AsyncResult (global::Java.Lang.Object result, global::Com.Microsoft.Identity.Client.Exception.MsalException exception) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Lcom/microsoft/identity/client/exception/MsalException;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_result = JNIEnv.ToLocalJniHandle (result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_result);
				__args [1] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_result);
				global::System.GC.KeepAlive (result);
				global::System.GC.KeepAlive (exception);
			}
		}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Internal.AsyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Exception.MsalException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='AsyncResult']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Lcom/microsoft/identity/client/exception/MsalException;", "GetGetExceptionHandler")]
			get {
				const string __id = "getException.()Lcom/microsoft/identity/client/exception/MsalException;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Internal.AsyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='AsyncResult']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuccess;
#pragma warning disable 0169
		static Delegate GetGetSuccessHandler ()
		{
			if (cb_getSuccess == null)
				cb_getSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetSuccess);
			return cb_getSuccess;
		}

		static bool n_GetSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Internal.AsyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Success;
		}
#pragma warning restore 0169

		public virtual unsafe bool Success {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='AsyncResult']/method[@name='getSuccess' and count(parameter)=0]"
			[Register ("getSuccess", "()Z", "GetGetSuccessHandler")]
			get {
				const string __id = "getSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
