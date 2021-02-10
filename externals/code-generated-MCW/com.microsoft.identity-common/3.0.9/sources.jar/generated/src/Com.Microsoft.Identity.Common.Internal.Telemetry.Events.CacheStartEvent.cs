using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/CacheStartEvent", DoNotGenerateAcw=true)]
	public partial class CacheStartEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/CacheStartEvent", typeof (CacheStartEvent));

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

		protected CacheStartEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/constructor[@name='CacheStartEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CacheStartEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isAt_Z;
#pragma warning disable 0169
		static Delegate GetIsAt_ZHandler ()
		{
			if (cb_isAt_Z == null)
				cb_isAt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsAt_Z);
			return cb_isAt_Z;
		}

		static IntPtr n_IsAt_Z (IntPtr jnienv, IntPtr native__this, bool isAt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsAt (isAt));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/method[@name='isAt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isAt", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;", "GetIsAt_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent IsAt (bool isAt)
		{
			const string __id = "isAt.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isAt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isFrt_Z;
#pragma warning disable 0169
		static Delegate GetIsFrt_ZHandler ()
		{
			if (cb_isFrt_Z == null)
				cb_isFrt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsFrt_Z);
			return cb_isFrt_Z;
		}

		static IntPtr n_IsFrt_Z (IntPtr jnienv, IntPtr native__this, bool isFrt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsFrt (isFrt));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/method[@name='isFrt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isFrt", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;", "GetIsFrt_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent IsFrt (bool isFrt)
		{
			const string __id = "isFrt.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isFrt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isMrrt_Z;
#pragma warning disable 0169
		static Delegate GetIsMrrt_ZHandler ()
		{
			if (cb_isMrrt_Z == null)
				cb_isMrrt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsMrrt_Z);
			return cb_isMrrt_Z;
		}

		static IntPtr n_IsMrrt_Z (IntPtr jnienv, IntPtr native__this, bool isMrrt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsMrrt (isMrrt));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/method[@name='isMrrt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isMrrt", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;", "GetIsMrrt_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent IsMrrt (bool isMrrt)
		{
			const string __id = "isMrrt.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isMrrt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isRt_Z;
#pragma warning disable 0169
		static Delegate GetIsRt_ZHandler ()
		{
			if (cb_isRt_Z == null)
				cb_isRt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsRt_Z);
			return cb_isRt_Z;
		}

		static IntPtr n_IsRt_Z (IntPtr jnienv, IntPtr native__this, bool isRt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRt (isRt));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/method[@name='isRt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isRt", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;", "GetIsRt_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent IsRt (bool isRt)
		{
			const string __id = "isRt.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isRt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putTokenType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutTokenType_Ljava_lang_String_Handler ()
		{
			if (cb_putTokenType_Ljava_lang_String_ == null)
				cb_putTokenType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutTokenType_Ljava_lang_String_);
			return cb_putTokenType_Ljava_lang_String_;
		}

		static IntPtr n_PutTokenType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenType = JNIEnv.GetString (native_tokenType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutTokenType (tokenType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/method[@name='putTokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putTokenType", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;", "GetPutTokenType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent PutTokenType (string tokenType)
		{
			const string __id = "putTokenType.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;";
			IntPtr native_tokenType = JNIEnv.NewString (tokenType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tokenType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tokenType);
			}
		}

		static Delegate cb_putWipeApp_Z;
#pragma warning disable 0169
		static Delegate GetPutWipeApp_ZHandler ()
		{
			if (cb_putWipeApp_Z == null)
				cb_putWipeApp_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_PutWipeApp_Z);
			return cb_putWipeApp_Z;
		}

		static IntPtr n_PutWipeApp_Z (IntPtr jnienv, IntPtr native__this, bool appWiped)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PutWipeApp (appWiped));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheStartEvent']/method[@name='putWipeApp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("putWipeApp", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;", "GetPutWipeApp_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent PutWipeApp (bool appWiped)
		{
			const string __id = "putWipeApp.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/CacheStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (appWiped);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
