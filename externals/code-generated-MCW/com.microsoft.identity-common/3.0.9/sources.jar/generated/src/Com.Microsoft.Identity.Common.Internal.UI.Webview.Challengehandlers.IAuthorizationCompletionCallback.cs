using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/interface[@name='IAuthorizationCompletionCallback']"
	[Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback", "", "Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallbackInvoker")]
	public partial interface IAuthorizationCompletionCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/interface[@name='IAuthorizationCompletionCallback']/method[@name='onChallengeResponseReceived' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onChallengeResponseReceived", "(ILandroid/content/Intent;)V", "GetOnChallengeResponseReceived_ILandroid_content_Intent_Handler:Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallbackInvoker, Microsoft.Identity.Common")]
		void OnChallengeResponseReceived (int p0, global::Android.Content.Intent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/interface[@name='IAuthorizationCompletionCallback']/method[@name='setPKeyAuthStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPKeyAuthStatus", "(Z)V", "GetSetPKeyAuthStatus_ZHandler:Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallbackInvoker, Microsoft.Identity.Common")]
		void SetPKeyAuthStatus (bool p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback", DoNotGenerateAcw=true)]
	internal partial class IAuthorizationCompletionCallbackInvoker : global::Java.Lang.Object, IAuthorizationCompletionCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback", typeof (IAuthorizationCompletionCallbackInvoker));

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

		public static IAuthorizationCompletionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthorizationCompletionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.ui.webview.challengehandlers.IAuthorizationCompletionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthorizationCompletionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onChallengeResponseReceived_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnChallengeResponseReceived_ILandroid_content_Intent_Handler ()
		{
			if (cb_onChallengeResponseReceived_ILandroid_content_Intent_ == null)
				cb_onChallengeResponseReceived_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnChallengeResponseReceived_ILandroid_content_Intent_);
			return cb_onChallengeResponseReceived_ILandroid_content_Intent_;
		}

		static void n_OnChallengeResponseReceived_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChallengeResponseReceived (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onChallengeResponseReceived_ILandroid_content_Intent_;
		public unsafe void OnChallengeResponseReceived (int p0, global::Android.Content.Intent p1)
		{
			if (id_onChallengeResponseReceived_ILandroid_content_Intent_ == IntPtr.Zero)
				id_onChallengeResponseReceived_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onChallengeResponseReceived", "(ILandroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChallengeResponseReceived_ILandroid_content_Intent_, __args);
		}

		static Delegate cb_setPKeyAuthStatus_Z;
#pragma warning disable 0169
		static Delegate GetSetPKeyAuthStatus_ZHandler ()
		{
			if (cb_setPKeyAuthStatus_Z == null)
				cb_setPKeyAuthStatus_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPKeyAuthStatus_Z);
			return cb_setPKeyAuthStatus_Z;
		}

		static void n_SetPKeyAuthStatus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPKeyAuthStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPKeyAuthStatus_Z;
		public unsafe void SetPKeyAuthStatus (bool p0)
		{
			if (id_setPKeyAuthStatus_Z == IntPtr.Zero)
				id_setPKeyAuthStatus_Z = JNIEnv.GetMethodID (class_ref, "setPKeyAuthStatus", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPKeyAuthStatus_Z, __args);
		}

	}
}
