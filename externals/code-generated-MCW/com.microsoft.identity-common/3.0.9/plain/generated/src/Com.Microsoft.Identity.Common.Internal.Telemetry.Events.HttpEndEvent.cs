using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpEndEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/HttpEndEvent", DoNotGenerateAcw=true)]
	public partial class HttpEndEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/HttpEndEvent", typeof (HttpEndEvent));

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

		protected HttpEndEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpEndEvent']/constructor[@name='HttpEndEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpEndEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_putStatusCode_I;
#pragma warning disable 0169
		static Delegate GetPutStatusCode_IHandler ()
		{
			if (cb_putStatusCode_I == null)
				cb_putStatusCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_PutStatusCode_I);
			return cb_putStatusCode_I;
		}

		static IntPtr n_PutStatusCode_I (IntPtr jnienv, IntPtr native__this, int statusCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PutStatusCode (statusCode));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpEndEvent']/method[@name='putStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("putStatusCode", "(I)Lcom/microsoft/identity/common/internal/telemetry/events/HttpEndEvent;", "GetPutStatusCode_IHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpEndEvent PutStatusCode (int statusCode)
		{
			const string __id = "putStatusCode.(I)Lcom/microsoft/identity/common/internal/telemetry/events/HttpEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (statusCode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
