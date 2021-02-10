using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/interface[@name='IChallengeHandler']"
	[Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/IChallengeHandler", "", "Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandlerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericChallenge", "GenericResponse"})]
	public partial interface IChallengeHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/interface[@name='IChallengeHandler']/method[@name='processChallenge' and count(parameter)=1 and parameter[1][@type='GenericChallenge']]"
		[Register ("processChallenge", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetProcessChallenge_Ljava_lang_Object_Handler:Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandlerInvoker, Microsoft.Identity.Common")]
		global::Java.Lang.Object ProcessChallenge (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/IChallengeHandler", DoNotGenerateAcw=true)]
	internal partial class IChallengeHandlerInvoker : global::Java.Lang.Object, IChallengeHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/IChallengeHandler", typeof (IChallengeHandlerInvoker));

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

		public static IChallengeHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChallengeHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.ui.webview.challengehandlers.IChallengeHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChallengeHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_processChallenge_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetProcessChallenge_Ljava_lang_Object_Handler ()
		{
			if (cb_processChallenge_Ljava_lang_Object_ == null)
				cb_processChallenge_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ProcessChallenge_Ljava_lang_Object_);
			return cb_processChallenge_Ljava_lang_Object_;
		}

		static IntPtr n_ProcessChallenge_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessChallenge (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_processChallenge_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object ProcessChallenge (global::Java.Lang.Object p0)
		{
			if (id_processChallenge_Ljava_lang_Object_ == IntPtr.Zero)
				id_processChallenge_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "processChallenge", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processChallenge_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
