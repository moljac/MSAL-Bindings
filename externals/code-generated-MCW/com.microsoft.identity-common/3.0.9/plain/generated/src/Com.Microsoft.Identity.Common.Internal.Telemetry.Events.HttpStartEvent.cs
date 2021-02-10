using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/HttpStartEvent", DoNotGenerateAcw=true)]
	public partial class HttpStartEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/HttpStartEvent", typeof (HttpStartEvent));

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

		protected HttpStartEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']/constructor[@name='HttpStartEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpStartEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_putErrorDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutErrorDomain_Ljava_lang_String_Handler ()
		{
			if (cb_putErrorDomain_Ljava_lang_String_ == null)
				cb_putErrorDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutErrorDomain_Ljava_lang_String_);
			return cb_putErrorDomain_Ljava_lang_String_;
		}

		static IntPtr n_PutErrorDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorDomain)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorDomain = JNIEnv.GetString (native_errorDomain, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutErrorDomain (errorDomain));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']/method[@name='putErrorDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putErrorDomain", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;", "GetPutErrorDomain_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent PutErrorDomain (string errorDomain)
		{
			const string __id = "putErrorDomain.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;";
			IntPtr native_errorDomain = JNIEnv.NewString (errorDomain);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errorDomain);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorDomain);
			}
		}

		static Delegate cb_putMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutMethod_Ljava_lang_String_Handler ()
		{
			if (cb_putMethod_Ljava_lang_String_ == null)
				cb_putMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutMethod_Ljava_lang_String_);
			return cb_putMethod_Ljava_lang_String_;
		}

		static IntPtr n_PutMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutMethod (method));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']/method[@name='putMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putMethod", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;", "GetPutMethod_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent PutMethod (string method)
		{
			const string __id = "putMethod.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		static Delegate cb_putPath_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetPutPath_Ljava_net_URL_Handler ()
		{
			if (cb_putPath_Ljava_net_URL_ == null)
				cb_putPath_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutPath_Ljava_net_URL_);
			return cb_putPath_Ljava_net_URL_;
		}

		static IntPtr n_PutPath_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutPath (path));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']/method[@name='putPath' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("putPath", "(Ljava/net/URL;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;", "GetPutPath_Ljava_net_URL_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent PutPath (global::Java.Net.URL path)
		{
			const string __id = "putPath.(Ljava/net/URL;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_putRequestIdHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutRequestIdHeader_Ljava_lang_String_Handler ()
		{
			if (cb_putRequestIdHeader_Ljava_lang_String_ == null)
				cb_putRequestIdHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutRequestIdHeader_Ljava_lang_String_);
			return cb_putRequestIdHeader_Ljava_lang_String_;
		}

		static IntPtr n_PutRequestIdHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestIdHeader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestIdHeader = JNIEnv.GetString (native_requestIdHeader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutRequestIdHeader (requestIdHeader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']/method[@name='putRequestIdHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putRequestIdHeader", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;", "GetPutRequestIdHeader_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent PutRequestIdHeader (string requestIdHeader)
		{
			const string __id = "putRequestIdHeader.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;";
			IntPtr native_requestIdHeader = JNIEnv.NewString (requestIdHeader);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestIdHeader);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestIdHeader);
			}
		}

		static Delegate cb_putRequestQueryParams_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutRequestQueryParams_Ljava_lang_String_Handler ()
		{
			if (cb_putRequestQueryParams_Ljava_lang_String_ == null)
				cb_putRequestQueryParams_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutRequestQueryParams_Ljava_lang_String_);
			return cb_putRequestQueryParams_Ljava_lang_String_;
		}

		static IntPtr n_PutRequestQueryParams_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestQueryParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestQueryParams = JNIEnv.GetString (native_requestQueryParams, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutRequestQueryParams (requestQueryParams));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='HttpStartEvent']/method[@name='putRequestQueryParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putRequestQueryParams", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;", "GetPutRequestQueryParams_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent PutRequestQueryParams (string requestQueryParams)
		{
			const string __id = "putRequestQueryParams.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/HttpStartEvent;";
			IntPtr native_requestQueryParams = JNIEnv.NewString (requestQueryParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestQueryParams);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.HttpStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestQueryParams);
			}
		}

	}
}
