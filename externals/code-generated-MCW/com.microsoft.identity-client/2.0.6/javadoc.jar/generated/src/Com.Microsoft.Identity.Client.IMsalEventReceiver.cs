using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMsalEventReceiver']"
	[Register ("com/microsoft/identity/client/IMsalEventReceiver", "", "Com.Microsoft.Identity.Client.IMsalEventReceiverInvoker")]
	public partial interface IMsalEventReceiver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMsalEventReceiver']/method[@name='onEventsReceived' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Map&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("onEventsReceived", "(Ljava/util/List;)V", "GetOnEventsReceived_Ljava_util_List_Handler:Com.Microsoft.Identity.Client.IMsalEventReceiverInvoker, Microsoft.Identity.Client")]
		void OnEventsReceived (global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>> p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMsalEventReceiver", DoNotGenerateAcw=true)]
	internal partial class IMsalEventReceiverInvoker : global::Java.Lang.Object, IMsalEventReceiver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMsalEventReceiver", typeof (IMsalEventReceiverInvoker));

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

		public static IMsalEventReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMsalEventReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IMsalEventReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMsalEventReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEventsReceived_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnEventsReceived_Ljava_util_List_Handler ()
		{
			if (cb_onEventsReceived_Ljava_util_List_ == null)
				cb_onEventsReceived_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEventsReceived_Ljava_util_List_);
			return cb_onEventsReceived_Ljava_util_List_;
		}

		static void n_OnEventsReceived_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMsalEventReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEventsReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEventsReceived_Ljava_util_List_;
		public unsafe void OnEventsReceived (global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>> p0)
		{
			if (id_onEventsReceived_Ljava_util_List_ == IntPtr.Zero)
				id_onEventsReceived_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onEventsReceived", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEventsReceived_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
