using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.adapter']/interface[@name='ITelemetryAdapter']"
	[Register ("com/microsoft/identity/common/internal/telemetry/adapter/ITelemetryAdapter", "", "Com.Microsoft.Identity.Common.Internal.Telemetry.Adapter.ITelemetryAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITelemetryAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.adapter']/interface[@name='ITelemetryAdapter']/method[@name='process' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("process", "(Ljava/lang/Object;)V", "GetProcess_Ljava_lang_Object_Handler:Com.Microsoft.Identity.Common.Internal.Telemetry.Adapter.ITelemetryAdapterInvoker, Microsoft.Identity.Common")]
		void Process (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/adapter/ITelemetryAdapter", DoNotGenerateAcw=true)]
	internal partial class ITelemetryAdapterInvoker : global::Java.Lang.Object, ITelemetryAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/adapter/ITelemetryAdapter", typeof (ITelemetryAdapterInvoker));

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

		public static ITelemetryAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITelemetryAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.telemetry.adapter.ITelemetryAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITelemetryAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_process_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetProcess_Ljava_lang_Object_Handler ()
		{
			if (cb_process_Ljava_lang_Object_ == null)
				cb_process_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Process_Ljava_lang_Object_);
			return cb_process_Ljava_lang_Object_;
		}

		static void n_Process_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Adapter.ITelemetryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Process (p0);
		}
#pragma warning restore 0169

		IntPtr id_process_Ljava_lang_Object_;
		public unsafe void Process (global::Java.Lang.Object p0)
		{
			if (id_process_Ljava_lang_Object_ == IntPtr.Zero)
				id_process_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "process", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
