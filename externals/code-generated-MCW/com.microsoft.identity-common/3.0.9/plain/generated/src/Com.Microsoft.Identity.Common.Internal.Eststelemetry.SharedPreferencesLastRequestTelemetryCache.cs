using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SharedPreferencesLastRequestTelemetryCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/SharedPreferencesLastRequestTelemetryCache", DoNotGenerateAcw=true)]
	public partial class SharedPreferencesLastRequestTelemetryCache : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/SharedPreferencesLastRequestTelemetryCache", typeof (SharedPreferencesLastRequestTelemetryCache));

		internal static IntPtr class_ref {
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

		protected SharedPreferencesLastRequestTelemetryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getRequestTelemetryFromCache;
#pragma warning disable 0169
		static Delegate GetGetRequestTelemetryFromCacheHandler ()
		{
			if (cb_getRequestTelemetryFromCache == null)
				cb_getRequestTelemetryFromCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestTelemetryFromCache);
			return cb_getRequestTelemetryFromCache;
		}

		static IntPtr n_GetRequestTelemetryFromCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.SharedPreferencesLastRequestTelemetryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestTelemetryFromCache);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry RequestTelemetryFromCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SharedPreferencesLastRequestTelemetryCache']/method[@name='getRequestTelemetryFromCache' and count(parameter)=0]"
			[Register ("getRequestTelemetryFromCache", "()Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;", "GetGetRequestTelemetryFromCacheHandler")]
			get {
				const string __id = "getRequestTelemetryFromCache.()Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_;
#pragma warning disable 0169
		static Delegate GetSaveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_Handler ()
		{
			if (cb_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ == null)
				cb_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_);
			return cb_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_;
		}

		static void n_SaveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestTelemetry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.SharedPreferencesLastRequestTelemetryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestTelemetry = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (native_requestTelemetry, JniHandleOwnership.DoNotTransfer);
			__this.SaveRequestTelemetryToCache (requestTelemetry);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SharedPreferencesLastRequestTelemetryCache']/method[@name='saveRequestTelemetryToCache' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.eststelemetry.RequestTelemetry']]"
		[Register ("saveRequestTelemetryToCache", "(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)V", "GetSaveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_Handler")]
		public virtual unsafe void SaveRequestTelemetryToCache (global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry requestTelemetry)
		{
			const string __id = "saveRequestTelemetryToCache.(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestTelemetry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestTelemetry).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (requestTelemetry);
			}
		}

	}
}
