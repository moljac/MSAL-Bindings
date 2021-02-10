using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent", DoNotGenerateAcw=true)]
	public partial class BrokerEndEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent", typeof (BrokerEndEvent));

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

		protected BrokerEndEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']/constructor[@name='BrokerEndEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerEndEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isSuccessful_Z;
#pragma warning disable 0169
		static Delegate GetIsSuccessful_ZHandler ()
		{
			if (cb_isSuccessful_Z == null)
				cb_isSuccessful_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsSuccessful_Z);
			return cb_isSuccessful_Z;
		}

		static IntPtr n_IsSuccessful_Z (IntPtr jnienv, IntPtr native__this, bool isSuccessful)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsSuccessful (isSuccessful));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']/method[@name='isSuccessful' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isSuccessful", "(Z)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;", "GetIsSuccessful_ZHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent IsSuccessful (bool isSuccessful)
		{
			const string __id = "isSuccessful.(Z)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isSuccessful);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var actionName = JNIEnv.GetString (native_actionName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutAction (actionName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']/method[@name='putAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putAction", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;", "GetPutAction_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent PutAction (string actionName)
		{
			const string __id = "putAction.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;";
			IntPtr native_actionName = JNIEnv.NewString (actionName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_actionName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_actionName);
			}
		}

		static Delegate cb_putErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_putErrorCode_Ljava_lang_String_ == null)
				cb_putErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutErrorCode_Ljava_lang_String_);
			return cb_putErrorCode_Ljava_lang_String_;
		}

		static IntPtr n_PutErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutErrorCode (errorCode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']/method[@name='putErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putErrorCode", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;", "GetPutErrorCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent PutErrorCode (string errorCode)
		{
			const string __id = "putErrorCode.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;";
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errorCode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		static Delegate cb_putErrorDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutErrorDescription_Ljava_lang_String_Handler ()
		{
			if (cb_putErrorDescription_Ljava_lang_String_ == null)
				cb_putErrorDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutErrorDescription_Ljava_lang_String_);
			return cb_putErrorDescription_Ljava_lang_String_;
		}

		static IntPtr n_PutErrorDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorDescription)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorDescription = JNIEnv.GetString (native_errorDescription, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutErrorDescription (errorDescription));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']/method[@name='putErrorDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putErrorDescription", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;", "GetPutErrorDescription_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent PutErrorDescription (string errorDescription)
		{
			const string __id = "putErrorDescription.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;";
			IntPtr native_errorDescription = JNIEnv.NewString (errorDescription);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errorDescription);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorDescription);
			}
		}

		static Delegate cb_putException_Lcom_microsoft_identity_common_exception_BaseException_;
#pragma warning disable 0169
		static Delegate GetPutException_Lcom_microsoft_identity_common_exception_BaseException_Handler ()
		{
			if (cb_putException_Lcom_microsoft_identity_common_exception_BaseException_ == null)
				cb_putException_Lcom_microsoft_identity_common_exception_BaseException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutException_Lcom_microsoft_identity_common_exception_BaseException_);
			return cb_putException_Lcom_microsoft_identity_common_exception_BaseException_;
		}

		static IntPtr n_PutException_Lcom_microsoft_identity_common_exception_BaseException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (native_exception, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutException (exception));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='BrokerEndEvent']/method[@name='putException' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.exception.BaseException']]"
		[Register ("putException", "(Lcom/microsoft/identity/common/exception/BaseException;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;", "GetPutException_Lcom_microsoft_identity_common_exception_BaseException_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent PutException (global::Com.Microsoft.Identity.Common.Exception.BaseException exception)
		{
			const string __id = "putException.(Lcom/microsoft/identity/common/exception/BaseException;)Lcom/microsoft/identity/common/internal/telemetry/events/BrokerEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BrokerEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

	}
}
