using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerStartEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/BrokerStartEvent", DoNotGenerateAcw=true)]
	public partial class BrokerStartEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/BrokerStartEvent", typeof (BrokerStartEvent));

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

		protected BrokerStartEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerStartEvent']/constructor[@name='BrokerStartEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerStartEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_putAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutAction_Ljava_lang_String_Handler ()
		{
			if (cb_putAction_Ljava_lang_String_ == null)
				cb_putAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutAction_Ljava_lang_String_);
			return cb_putAction_Ljava_lang_String_;
		}

		static IntPtr n_PutAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actionName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var actionName = JNIEnv.GetString (native_actionName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutAction (actionName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerStartEvent']/method[@name='putAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putAction", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerStartEvent;", "GetPutAction_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerStartEvent PutAction (string actionName)
		{
			const string __id = "putAction.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerStartEvent;";
			IntPtr native_actionName = JNIEnv.NewString (actionName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_actionName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_actionName);
			}
		}

		static Delegate cb_putStrategy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutStrategy_Ljava_lang_String_Handler ()
		{
			if (cb_putStrategy_Ljava_lang_String_ == null)
				cb_putStrategy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutStrategy_Ljava_lang_String_);
			return cb_putStrategy_Ljava_lang_String_;
		}

		static IntPtr n_PutStrategy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategyName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategyName = JNIEnv.GetString (native_strategyName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStrategy (strategyName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerStartEvent']/method[@name='putStrategy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStrategy", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerStartEvent;", "GetPutStrategy_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerStartEvent PutStrategy (string strategyName)
		{
			const string __id = "putStrategy.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerStartEvent;";
			IntPtr native_strategyName = JNIEnv.NewString (strategyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strategyName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_strategyName);
			}
		}

	}
}
