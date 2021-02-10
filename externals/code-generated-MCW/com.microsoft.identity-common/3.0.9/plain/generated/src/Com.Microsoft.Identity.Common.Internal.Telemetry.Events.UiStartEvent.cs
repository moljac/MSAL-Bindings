using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiStartEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/UiStartEvent", DoNotGenerateAcw=true)]
	public partial class UiStartEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/UiStartEvent", typeof (UiStartEvent));

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

		protected UiStartEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiStartEvent']/constructor[@name='UiStartEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UiStartEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isForcePrompt_Z;
#pragma warning disable 0169
		static Delegate GetIsForcePrompt_ZHandler ()
		{
			if (cb_isForcePrompt_Z == null)
				cb_isForcePrompt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsForcePrompt_Z);
			return cb_isForcePrompt_Z;
		}

		static IntPtr n_IsForcePrompt_Z (IntPtr jnienv, IntPtr native__this, bool isForcePrompt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsForcePrompt (isForcePrompt));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiStartEvent']/method[@name='isForcePrompt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isForcePrompt", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/UiStartEvent;", "GetIsForcePrompt_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent IsForcePrompt (bool isForcePrompt)
		{
			const string __id = "isForcePrompt.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/UiStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isForcePrompt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putLoginHint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutLoginHint_Ljava_lang_String_Handler ()
		{
			if (cb_putLoginHint_Ljava_lang_String_ == null)
				cb_putLoginHint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutLoginHint_Ljava_lang_String_);
			return cb_putLoginHint_Ljava_lang_String_;
		}

		static IntPtr n_PutLoginHint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loginHint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutLoginHint (loginHint));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiStartEvent']/method[@name='putLoginHint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putLoginHint", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/UiStartEvent;", "GetPutLoginHint_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent PutLoginHint (string loginHint)
		{
			const string __id = "putLoginHint.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/UiStartEvent;";
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_loginHint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_loginHint);
			}
		}

		static Delegate cb_putUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_;
#pragma warning disable 0169
		static Delegate GetPutUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_Handler ()
		{
			if (cb_putUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_ == null)
				cb_putUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_);
			return cb_putUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_;
		}

		static IntPtr n_PutUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userAgent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userAgent = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent> (native_userAgent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutUserAgent (userAgent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='UiStartEvent']/method[@name='putUserAgent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.AuthorizationAgent']]"
		[Register ("putUserAgent", "(Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;)Lcom/microsoft/identity/common/internal/telemetry/events/UiStartEvent;", "GetPutUserAgent_Lcom_microsoft_identity_common_internal_ui_AuthorizationAgent_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent PutUserAgent (global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent userAgent)
		{
			const string __id = "putUserAgent.(Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;)Lcom/microsoft/identity/common/internal/telemetry/events/UiStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((userAgent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userAgent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.UiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (userAgent);
			}
		}

	}
}
