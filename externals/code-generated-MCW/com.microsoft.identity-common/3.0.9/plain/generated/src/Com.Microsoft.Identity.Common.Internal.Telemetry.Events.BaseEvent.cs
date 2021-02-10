using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BaseEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/BaseEvent", DoNotGenerateAcw=true)]
	public partial class BaseEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Properties {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/BaseEvent", typeof (BaseEvent));

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

		protected BaseEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BaseEvent']/constructor[@name='BaseEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_correlationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCorrelationId_Ljava_lang_String_Handler ()
		{
			if (cb_correlationId_Ljava_lang_String_ == null)
				cb_correlationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CorrelationId_Ljava_lang_String_);
			return cb_correlationId_Ljava_lang_String_;
		}

		static IntPtr n_CorrelationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CorrelationId (correlationId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BaseEvent']/method[@name='correlationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("correlationId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;", "GetCorrelationId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent CorrelationId (string correlationId)
		{
			const string __id = "correlationId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;";
			IntPtr native_correlationId = JNIEnv.NewString (correlationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_correlationId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_correlationId);
			}
		}

		static Delegate cb_names_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNames_Ljava_lang_String_Handler ()
		{
			if (cb_names_Ljava_lang_String_ == null)
				cb_names_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Names_Ljava_lang_String_);
			return cb_names_Ljava_lang_String_;
		}

		static IntPtr n_Names_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventName = JNIEnv.GetString (native_eventName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Names (eventName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BaseEvent']/method[@name='names' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("names", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;", "GetNames_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent Names (string eventName)
		{
			const string __id = "names.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
			}
		}

		static Delegate cb_occurs_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetOccurs_Ljava_lang_Long_Handler ()
		{
			if (cb_occurs_Ljava_lang_Long_ == null)
				cb_occurs_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Occurs_Ljava_lang_Long_);
			return cb_occurs_Ljava_lang_Long_;
		}

		static IntPtr n_Occurs_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventStartTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventStartTime = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_eventStartTime, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Occurs (eventStartTime));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BaseEvent']/method[@name='occurs' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("occurs", "(Ljava/lang/Long;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;", "GetOccurs_Ljava_lang_Long_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent Occurs (global::Java.Lang.Long eventStartTime)
		{
			const string __id = "occurs.(Ljava/lang/Long;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventStartTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventStartTime).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (eventStartTime);
			}
		}

		static Delegate cb_types_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTypes_Ljava_lang_String_Handler ()
		{
			if (cb_types_Ljava_lang_String_ == null)
				cb_types_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Types_Ljava_lang_String_);
			return cb_types_Ljava_lang_String_;
		}

		static IntPtr n_Types_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventType = JNIEnv.GetString (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Types (eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BaseEvent']/method[@name='types' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("types", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;", "GetTypes_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent Types (string eventType)
		{
			const string __id = "types.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;";
			IntPtr native_eventType = JNIEnv.NewString (eventType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventType);
			}
		}

	}
}
