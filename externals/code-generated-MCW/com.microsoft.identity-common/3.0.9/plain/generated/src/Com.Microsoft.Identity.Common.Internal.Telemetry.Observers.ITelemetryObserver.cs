using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Observers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.observers']/interface[@name='ITelemetryObserver']"
	[Register ("com/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver", "", "Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserverInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITelemetryObserver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.observers']/interface[@name='ITelemetryObserver']/method[@name='onReceived' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onReceived", "(Ljava/lang/Object;)V", "GetOnReceived_Ljava_lang_Object_Handler:Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserverInvoker, Microsoft.Identity.Common")]
		void OnReceived (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver", DoNotGenerateAcw=true)]
	internal partial class ITelemetryObserverInvoker : global::Java.Lang.Object, ITelemetryObserver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver", typeof (ITelemetryObserverInvoker));

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

		public static ITelemetryObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITelemetryObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.telemetry.observers.ITelemetryObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITelemetryObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onReceived_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnReceived_Ljava_lang_Object_Handler ()
		{
			if (cb_onReceived_Ljava_lang_Object_ == null)
				cb_onReceived_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnReceived_Ljava_lang_Object_);
			return cb_onReceived_Ljava_lang_Object_;
		}

		static void n_OnReceived_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceived_Ljava_lang_Object_;
		public unsafe void OnReceived (global::Java.Lang.Object p0)
		{
			if (id_onReceived_Ljava_lang_Object_ == IntPtr.Zero)
				id_onReceived_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onReceived", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceived_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
