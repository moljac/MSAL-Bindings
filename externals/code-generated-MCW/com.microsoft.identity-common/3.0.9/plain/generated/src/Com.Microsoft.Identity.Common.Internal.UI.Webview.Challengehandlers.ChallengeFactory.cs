using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='ChallengeFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/ChallengeFactory", DoNotGenerateAcw=true)]
	public sealed partial class ChallengeFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/ChallengeFactory", typeof (ChallengeFactory));

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

		internal ChallengeFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='ChallengeFactory']/constructor[@name='ChallengeFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChallengeFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='ChallengeFactory']/method[@name='getNtlmChallenge' and count(parameter)=4 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='android.webkit.HttpAuthHandler'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getNtlmChallenge", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/NtlmChallenge;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.NtlmChallenge GetNtlmChallenge (global::Android.Webkit.WebView view, global::Android.Webkit.HttpAuthHandler handler, string host, string realm)
		{
			const string __id = "getNtlmChallenge.(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/NtlmChallenge;";
			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_realm = JNIEnv.NewString (realm);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [2] = new JniArgumentValue (native_host);
				__args [3] = new JniArgumentValue (native_realm);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.NtlmChallenge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_realm);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (handler);
			}
		}

	}
}
