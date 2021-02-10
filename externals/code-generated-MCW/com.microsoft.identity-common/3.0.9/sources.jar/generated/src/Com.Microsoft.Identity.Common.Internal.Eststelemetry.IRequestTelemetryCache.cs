using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetryCache']"
	[Register ("com/microsoft/identity/common/internal/eststelemetry/IRequestTelemetryCache", "", "Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryCacheInvoker")]
	public partial interface IRequestTelemetryCache : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry RequestTelemetryFromCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetryCache']/method[@name='getRequestTelemetryFromCache' and count(parameter)=0]"
			[Register ("getRequestTelemetryFromCache", "()Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;", "GetGetRequestTelemetryFromCacheHandler:Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetryCache']/method[@name='saveRequestTelemetryToCache' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.eststelemetry.RequestTelemetry']]"
		[Register ("saveRequestTelemetryToCache", "(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)V", "GetSaveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_Handler:Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryCacheInvoker, Microsoft.Identity.Common")]
		void SaveRequestTelemetryToCache (global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/IRequestTelemetryCache", DoNotGenerateAcw=true)]
	internal partial class IRequestTelemetryCacheInvoker : global::Java.Lang.Object, IRequestTelemetryCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/IRequestTelemetryCache", typeof (IRequestTelemetryCacheInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IRequestTelemetryCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestTelemetryCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.eststelemetry.IRequestTelemetryCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestTelemetryCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestTelemetryFromCache);
		}
#pragma warning restore 0169

		IntPtr id_getRequestTelemetryFromCache;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry RequestTelemetryFromCache {
			get {
				if (id_getRequestTelemetryFromCache == IntPtr.Zero)
					id_getRequestTelemetryFromCache = JNIEnv.GetMethodID (class_ref, "getRequestTelemetryFromCache", "()Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestTelemetryFromCache), JniHandleOwnership.TransferLocalRef);
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

		static void n_SaveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveRequestTelemetryToCache (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_;
		public unsafe void SaveRequestTelemetryToCache (global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry p0)
		{
			if (id_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ == IntPtr.Zero)
				id_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ = JNIEnv.GetMethodID (class_ref, "saveRequestTelemetryToCache", "(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveRequestTelemetryToCache_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_, __args);
		}

	}
}
