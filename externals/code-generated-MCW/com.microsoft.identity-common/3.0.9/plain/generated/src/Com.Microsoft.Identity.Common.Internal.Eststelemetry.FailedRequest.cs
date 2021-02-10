using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='FailedRequest']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/FailedRequest", DoNotGenerateAcw=true)]
	public partial class FailedRequest : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/FailedRequest", typeof (FailedRequest));

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

		protected FailedRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='FailedRequest']/constructor[@name='FailedRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FailedRequest (string mApiId, string mCorrelationId, string error) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mApiId = JNIEnv.NewString (mApiId);
			IntPtr native_mCorrelationId = JNIEnv.NewString (mCorrelationId);
			IntPtr native_error = JNIEnv.NewString (error);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mApiId);
				__args [1] = new JniArgumentValue (native_mCorrelationId);
				__args [2] = new JniArgumentValue (native_error);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mApiId);
				JNIEnv.DeleteLocalRef (native_mCorrelationId);
				JNIEnv.DeleteLocalRef (native_error);
			}
		}

		static Delegate cb_toApiIdCorrelationString;
#pragma warning disable 0169
		static Delegate GetToApiIdCorrelationStringHandler ()
		{
			if (cb_toApiIdCorrelationString == null)
				cb_toApiIdCorrelationString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToApiIdCorrelationString);
			return cb_toApiIdCorrelationString;
		}

		static IntPtr n_ToApiIdCorrelationString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.FailedRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToApiIdCorrelationString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='FailedRequest']/method[@name='toApiIdCorrelationString' and count(parameter)=0]"
		[Register ("toApiIdCorrelationString", "()Ljava/lang/String;", "GetToApiIdCorrelationStringHandler")]
		public virtual unsafe string ToApiIdCorrelationString ()
		{
			const string __id = "toApiIdCorrelationString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toErrorCodeString;
#pragma warning disable 0169
		static Delegate GetToErrorCodeStringHandler ()
		{
			if (cb_toErrorCodeString == null)
				cb_toErrorCodeString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToErrorCodeString);
			return cb_toErrorCodeString;
		}

		static IntPtr n_ToErrorCodeString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.FailedRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToErrorCodeString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='FailedRequest']/method[@name='toErrorCodeString' and count(parameter)=0]"
		[Register ("toErrorCodeString", "()Ljava/lang/String;", "GetToErrorCodeStringHandler")]
		public virtual unsafe string ToErrorCodeString ()
		{
			const string __id = "toErrorCodeString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
