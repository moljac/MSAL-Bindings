using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/interface[@name='OnPageLoadedCallback']"
	[Register ("com/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback", "", "Com.Microsoft.Identity.Common.Internal.UI.Webview.IOnPageLoadedCallbackInvoker")]
	public partial interface IOnPageLoadedCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/interface[@name='OnPageLoadedCallback']/method[@name='onPageLoaded' and count(parameter)=0]"
		[Register ("onPageLoaded", "()V", "GetOnPageLoadedHandler:Com.Microsoft.Identity.Common.Internal.UI.Webview.IOnPageLoadedCallbackInvoker, Microsoft.Identity.Common")]
		void OnPageLoaded ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback", DoNotGenerateAcw=true)]
	internal partial class IOnPageLoadedCallbackInvoker : global::Java.Lang.Object, IOnPageLoadedCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback", typeof (IOnPageLoadedCallbackInvoker));

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

		public static IOnPageLoadedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPageLoadedCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.ui.webview.OnPageLoadedCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPageLoadedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPageLoaded;
#pragma warning disable 0169
		static Delegate GetOnPageLoadedHandler ()
		{
			if (cb_onPageLoaded == null)
				cb_onPageLoaded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPageLoaded);
			return cb_onPageLoaded;
		}

		static void n_OnPageLoaded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.IOnPageLoadedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageLoaded ();
		}
#pragma warning restore 0169

		IntPtr id_onPageLoaded;
		public unsafe void OnPageLoaded ()
		{
			if (id_onPageLoaded == IntPtr.Zero)
				id_onPageLoaded = JNIEnv.GetMethodID (class_ref, "onPageLoaded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageLoaded);
		}

	}
}
