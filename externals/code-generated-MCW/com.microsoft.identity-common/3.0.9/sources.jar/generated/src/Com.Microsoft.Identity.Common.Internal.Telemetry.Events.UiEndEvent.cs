using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiEndEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/UiEndEvent", DoNotGenerateAcw=true)]
	public partial class UiEndEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/UiEndEvent", typeof (UiEndEvent));

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

		protected UiEndEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiEndEvent']/constructor[@name='UiEndEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UiEndEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isUiCancelled;
#pragma warning disable 0169
		static Delegate GetIsUiCancelledHandler ()
		{
			if (cb_isUiCancelled == null)
				cb_isUiCancelled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsUiCancelled);
			return cb_isUiCancelled;
		}

		static IntPtr n_IsUiCancelled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsUiCancelled ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiEndEvent']/method[@name='isUiCancelled' and count(parameter)=0]"
		[Register ("isUiCancelled", "()Lcom/microsoft/identity/common/internal/telemetry/events/UiEndEvent;", "GetIsUiCancelledHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent IsUiCancelled ()
		{
			const string __id = "isUiCancelled.()Lcom/microsoft/identity/common/internal/telemetry/events/UiEndEvent;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isUiComplete;
#pragma warning disable 0169
		static Delegate GetIsUiCompleteHandler ()
		{
			if (cb_isUiComplete == null)
				cb_isUiComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsUiComplete);
			return cb_isUiComplete;
		}

		static IntPtr n_IsUiComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsUiComplete ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiEndEvent']/method[@name='isUiComplete' and count(parameter)=0]"
		[Register ("isUiComplete", "()Lcom/microsoft/identity/common/internal/telemetry/events/UiEndEvent;", "GetIsUiCompleteHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent IsUiComplete ()
		{
			const string __id = "isUiComplete.()Lcom/microsoft/identity/common/internal/telemetry/events/UiEndEvent;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isUserCancelled;
#pragma warning disable 0169
		static Delegate GetIsUserCancelledHandler ()
		{
			if (cb_isUserCancelled == null)
				cb_isUserCancelled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsUserCancelled);
			return cb_isUserCancelled;
		}

		static IntPtr n_IsUserCancelled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsUserCancelled ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiEndEvent']/method[@name='isUserCancelled' and count(parameter)=0]"
		[Register ("isUserCancelled", "()Lcom/microsoft/identity/common/internal/telemetry/events/UiEndEvent;", "GetIsUserCancelledHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent IsUserCancelled ()
		{
			const string __id = "isUserCancelled.()Lcom/microsoft/identity/common/internal/telemetry/events/UiEndEvent;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
