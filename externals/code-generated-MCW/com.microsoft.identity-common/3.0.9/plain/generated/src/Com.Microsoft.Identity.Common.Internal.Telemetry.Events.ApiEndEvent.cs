using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/ApiEndEvent", DoNotGenerateAcw=true)]
	public partial class ApiEndEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/ApiEndEvent", typeof (ApiEndEvent));

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

		protected ApiEndEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']/constructor[@name='ApiEndEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApiEndEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isApiCallSuccessful_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetIsApiCallSuccessful_Ljava_lang_Boolean_Handler ()
		{
			if (cb_isApiCallSuccessful_Ljava_lang_Boolean_ == null)
				cb_isApiCallSuccessful_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_IsApiCallSuccessful_Ljava_lang_Boolean_);
			return cb_isApiCallSuccessful_Ljava_lang_Boolean_;
		}

		static IntPtr n_IsApiCallSuccessful_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_isSuccessful)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var isSuccessful = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_isSuccessful, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsApiCallSuccessful (isSuccessful));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']/method[@name='isApiCallSuccessful' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("isApiCallSuccessful", "(Ljava/lang/Boolean;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;", "GetIsApiCallSuccessful_Ljava_lang_Boolean_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent IsApiCallSuccessful (global::Java.Lang.Boolean isSuccessful)
		{
			const string __id = "isApiCallSuccessful.(Ljava/lang/Boolean;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((isSuccessful == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isSuccessful).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (isSuccessful);
			}
		}

		static Delegate cb_putApiErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutApiErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_putApiErrorCode_Ljava_lang_String_ == null)
				cb_putApiErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutApiErrorCode_Ljava_lang_String_);
			return cb_putApiErrorCode_Ljava_lang_String_;
		}

		static IntPtr n_PutApiErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutApiErrorCode (errorCode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']/method[@name='putApiErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putApiErrorCode", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;", "GetPutApiErrorCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent PutApiErrorCode (string errorCode)
		{
			const string __id = "putApiErrorCode.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;";
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errorCode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		static Delegate cb_putApiId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutApiId_Ljava_lang_String_Handler ()
		{
			if (cb_putApiId_Ljava_lang_String_ == null)
				cb_putApiId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutApiId_Ljava_lang_String_);
			return cb_putApiId_Ljava_lang_String_;
		}

		static IntPtr n_PutApiId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var apiId = JNIEnv.GetString (native_apiId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutApiId (apiId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']/method[@name='putApiId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putApiId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;", "GetPutApiId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent PutApiId (string apiId)
		{
			const string __id = "putApiId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;";
			IntPtr native_apiId = JNIEnv.NewString (apiId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_apiId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_apiId);
			}
		}

		static Delegate cb_putException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetPutException_Ljava_lang_Exception_Handler ()
		{
			if (cb_putException_Ljava_lang_Exception_ == null)
				cb_putException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutException_Ljava_lang_Exception_);
			return cb_putException_Ljava_lang_Exception_;
		}

		static IntPtr n_PutException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutException (exception));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']/method[@name='putException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("putException", "(Ljava/lang/Exception;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;", "GetPutException_Ljava_lang_Exception_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent PutException (global::Java.Lang.Exception exception)
		{
			const string __id = "putException.(Ljava/lang/Exception;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

		static Delegate cb_putResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_;
#pragma warning disable 0169
		static Delegate GetPutResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Handler ()
		{
			if (cb_putResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_ == null)
				cb_putResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_);
			return cb_putResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_;
		}

		static IntPtr n_PutResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (native_result, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutResult (result));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiEndEvent']/method[@name='putResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.result.AcquireTokenResult']]"
		[Register ("putResult", "(Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;", "GetPutResult_Lcom_microsoft_identity_common_internal_result_AcquireTokenResult_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent PutResult (global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult result)
		{
			const string __id = "putResult.(Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (result);
			}
		}

	}
}
