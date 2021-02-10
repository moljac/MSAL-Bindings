using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallengeFactory", DoNotGenerateAcw=true)]
	public partial class PKeyAuthChallengeFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallengeFactory", typeof (PKeyAuthChallengeFactory));

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

		protected PKeyAuthChallengeFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeFactory']/constructor[@name='PKeyAuthChallengeFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKeyAuthChallengeFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getPKeyAuthChallenge_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPKeyAuthChallenge_Ljava_lang_String_Handler ()
		{
			if (cb_getPKeyAuthChallenge_Ljava_lang_String_ == null)
				cb_getPKeyAuthChallenge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPKeyAuthChallenge_Ljava_lang_String_);
			return cb_getPKeyAuthChallenge_Ljava_lang_String_;
		}

		static IntPtr n_GetPKeyAuthChallenge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirectUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallengeFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var redirectUri = JNIEnv.GetString (native_redirectUri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPKeyAuthChallenge (redirectUri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeFactory']/method[@name='getPKeyAuthChallenge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPKeyAuthChallenge", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;", "GetGetPKeyAuthChallenge_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge GetPKeyAuthChallenge (string redirectUri)
		{
			const string __id = "getPKeyAuthChallenge.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;";
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_redirectUri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_redirectUri);
			}
		}

		static Delegate cb_getPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_);
			return cb_getPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_header, IntPtr native_authority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallengeFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var header = JNIEnv.GetString (native_header, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPKeyAuthChallenge (header, authority));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeFactory']/method[@name='getPKeyAuthChallenge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPKeyAuthChallenge", "(Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;", "GetGetPKeyAuthChallenge_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge GetPKeyAuthChallenge (string header, string authority)
		{
			const string __id = "getPKeyAuthChallenge.(Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;";
			IntPtr native_header = JNIEnv.NewString (header);
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_header);
				__args [1] = new JniArgumentValue (native_authority);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_header);
				JNIEnv.DeleteLocalRef (native_authority);
			}
		}

	}
}
