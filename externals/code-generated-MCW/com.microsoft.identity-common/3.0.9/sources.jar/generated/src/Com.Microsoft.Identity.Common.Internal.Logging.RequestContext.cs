using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='RequestContext']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/logging/RequestContext", DoNotGenerateAcw=true)]
	public partial class RequestContext : global::Java.Util.HashMap, global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/logging/RequestContext", typeof (RequestContext));

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

		protected RequestContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='RequestContext']/constructor[@name='RequestContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestContext () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toJsonString;
#pragma warning disable 0169
		static Delegate GetToJsonStringHandler ()
		{
			if (cb_toJsonString == null)
				cb_toJsonString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJsonString);
			return cb_toJsonString;
		}

		static IntPtr n_ToJsonString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.RequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJsonString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='RequestContext']/method[@name='toJsonString' and count(parameter)=0]"
		[Register ("toJsonString", "()Ljava/lang/String;", "GetToJsonStringHandler")]
		public virtual unsafe string ToJsonString ()
		{
			const string __id = "toJsonString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
