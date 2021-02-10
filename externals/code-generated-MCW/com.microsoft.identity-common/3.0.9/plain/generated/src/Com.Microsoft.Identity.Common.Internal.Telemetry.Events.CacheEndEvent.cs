using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/CacheEndEvent", DoNotGenerateAcw=true)]
	public partial class CacheEndEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/CacheEndEvent", typeof (CacheEndEvent));

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

		protected CacheEndEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']/constructor[@name='CacheEndEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CacheEndEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_putAtStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutAtStatus_Ljava_lang_String_Handler ()
		{
			if (cb_putAtStatus_Ljava_lang_String_ == null)
				cb_putAtStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutAtStatus_Ljava_lang_String_);
			return cb_putAtStatus_Ljava_lang_String_;
		}

		static IntPtr n_PutAtStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rtStatus = JNIEnv.GetString (native_rtStatus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutAtStatus (rtStatus));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']/method[@name='putAtStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putAtStatus", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;", "GetPutAtStatus_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent PutAtStatus (string rtStatus)
		{
			const string __id = "putAtStatus.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;";
			IntPtr native_rtStatus = JNIEnv.NewString (rtStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rtStatus);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rtStatus);
			}
		}

		static Delegate cb_putCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_;
#pragma warning disable 0169
		static Delegate GetPutCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_Handler ()
		{
			if (cb_putCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_ == null)
				cb_putCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_);
			return cb_putCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_;
		}

		static IntPtr n_PutCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheRecord = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord> (native_cacheRecord, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCacheRecordStatus (cacheRecord));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']/method[@name='putCacheRecordStatus' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.cache.CacheRecord']]"
		[Register ("putCacheRecordStatus", "(Lcom/microsoft/identity/common/internal/cache/CacheRecord;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;", "GetPutCacheRecordStatus_Lcom_microsoft_identity_common_internal_cache_CacheRecord_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent PutCacheRecordStatus (global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord cacheRecord)
		{
			const string __id = "putCacheRecordStatus.(Lcom/microsoft/identity/common/internal/cache/CacheRecord;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cacheRecord);
			}
		}

		static Delegate cb_putFrtStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutFrtStatus_Ljava_lang_String_Handler ()
		{
			if (cb_putFrtStatus_Ljava_lang_String_ == null)
				cb_putFrtStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutFrtStatus_Ljava_lang_String_);
			return cb_putFrtStatus_Ljava_lang_String_;
		}

		static IntPtr n_PutFrtStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frtStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frtStatus = JNIEnv.GetString (native_frtStatus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutFrtStatus (frtStatus));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']/method[@name='putFrtStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putFrtStatus", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;", "GetPutFrtStatus_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent PutFrtStatus (string frtStatus)
		{
			const string __id = "putFrtStatus.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;";
			IntPtr native_frtStatus = JNIEnv.NewString (frtStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_frtStatus);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_frtStatus);
			}
		}

		static Delegate cb_putRtStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutRtStatus_Ljava_lang_String_Handler ()
		{
			if (cb_putRtStatus_Ljava_lang_String_ == null)
				cb_putRtStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutRtStatus_Ljava_lang_String_);
			return cb_putRtStatus_Ljava_lang_String_;
		}

		static IntPtr n_PutRtStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rtStatus = JNIEnv.GetString (native_rtStatus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutRtStatus (rtStatus));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']/method[@name='putRtStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putRtStatus", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;", "GetPutRtStatus_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent PutRtStatus (string rtStatus)
		{
			const string __id = "putRtStatus.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;";
			IntPtr native_rtStatus = JNIEnv.NewString (rtStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rtStatus);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rtStatus);
			}
		}

		static Delegate cb_putSpeInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutSpeInfo_Ljava_lang_String_Handler ()
		{
			if (cb_putSpeInfo_Ljava_lang_String_ == null)
				cb_putSpeInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutSpeInfo_Ljava_lang_String_);
			return cb_putSpeInfo_Ljava_lang_String_;
		}

		static IntPtr n_PutSpeInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_speInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var speInfo = JNIEnv.GetString (native_speInfo, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSpeInfo (speInfo));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='CacheEndEvent']/method[@name='putSpeInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSpeInfo", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;", "GetPutSpeInfo_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent PutSpeInfo (string speInfo)
		{
			const string __id = "putSpeInfo.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/CacheEndEvent;";
			IntPtr native_speInfo = JNIEnv.NewString (speInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_speInfo);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.CacheEndEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_speInfo);
			}
		}

	}
}
