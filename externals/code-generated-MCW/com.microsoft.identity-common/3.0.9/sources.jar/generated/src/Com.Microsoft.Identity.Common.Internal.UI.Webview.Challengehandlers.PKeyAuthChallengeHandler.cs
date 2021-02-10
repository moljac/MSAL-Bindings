using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeHandler']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallengeHandler", DoNotGenerateAcw=true)]
	public sealed partial class PKeyAuthChallengeHandler : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallengeHandler", typeof (PKeyAuthChallengeHandler));

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

		internal PKeyAuthChallengeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeHandler']/constructor[@name='PKeyAuthChallengeHandler' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.IAuthorizationCompletionCallback']]"
		[Register (".ctor", "(Landroid/webkit/WebView;Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback;)V", "")]
		public unsafe PKeyAuthChallengeHandler (global::Android.Webkit.WebView view, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallback completionCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/webkit/WebView;Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((completionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (completionCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeHandler']/method[@name='getChallengeHeader' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.PKeyAuthChallenge']]"
		[Register ("getChallengeHeader", "(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetChallengeHeader (global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge pKeyAuthChallenge)
		{
			const string __id = "getChallengeHeader.(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pKeyAuthChallenge == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pKeyAuthChallenge).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pKeyAuthChallenge);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallengeHandler']/method[@name='processChallenge' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.PKeyAuthChallenge']]"
		[Register ("processChallenge", "(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;)Ljava/lang/Void;", "")]
		public unsafe global::Java.Lang.Void ProcessChallenge (global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge pKeyAuthChallenge)
		{
			const string __id = "processChallenge.(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;)Ljava/lang/Void;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pKeyAuthChallenge == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pKeyAuthChallenge).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pKeyAuthChallenge);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler
		global::Java.Lang.Object global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler.ProcessChallenge (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(ProcessChallenge (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge>(p0)));
		}

	}
}
