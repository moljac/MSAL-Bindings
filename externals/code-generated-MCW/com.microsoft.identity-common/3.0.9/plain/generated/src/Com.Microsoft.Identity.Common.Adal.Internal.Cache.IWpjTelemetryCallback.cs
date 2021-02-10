using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/interface[@name='IWpjTelemetryCallback']"
	[Register ("com/microsoft/identity/common/adal/internal/cache/IWpjTelemetryCallback", "", "Com.Microsoft.Identity.Common.Adal.Internal.Cache.IWpjTelemetryCallbackInvoker")]
	public partial interface IWpjTelemetryCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/interface[@name='IWpjTelemetryCallback']/method[@name='logEvent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Boolean'] and parameter[4][@type='java.lang.String']]"
		[Register ("logEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;)V", "GetLogEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Cache.IWpjTelemetryCallbackInvoker, Microsoft.Identity.Common")]
		void LogEvent (global::Android.Content.Context p0, string p1, global::Java.Lang.Boolean p2, string p3);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/cache/IWpjTelemetryCallback", DoNotGenerateAcw=true)]
	internal partial class IWpjTelemetryCallbackInvoker : global::Java.Lang.Object, IWpjTelemetryCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/cache/IWpjTelemetryCallback", typeof (IWpjTelemetryCallbackInvoker));

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

		public static IWpjTelemetryCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWpjTelemetryCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.cache.IWpjTelemetryCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWpjTelemetryCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Handler ()
		{
			if (cb_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_ == null)
				cb_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_LogEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_);
			return cb_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_;
		}

		static void n_LogEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.IWpjTelemetryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LogEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_;
		public unsafe void LogEvent (global::Android.Content.Context p0, string p1, global::Java.Lang.Boolean p2, string p3)
		{
			if (id_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_ == IntPtr.Zero)
				id_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
