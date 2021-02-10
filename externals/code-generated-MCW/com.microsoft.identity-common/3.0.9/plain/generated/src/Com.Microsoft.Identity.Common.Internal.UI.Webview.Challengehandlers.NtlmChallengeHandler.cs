using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='NtlmChallengeHandler']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/NtlmChallengeHandler", DoNotGenerateAcw=true)]
	public sealed partial class NtlmChallengeHandler : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/NtlmChallengeHandler", typeof (NtlmChallengeHandler));

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

		internal NtlmChallengeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='NtlmChallengeHandler']/constructor[@name='NtlmChallengeHandler' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.IAuthorizationCompletionCallback']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback;)V", "")]
		public unsafe NtlmChallengeHandler (global::Android.App.Activity activity, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallback @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='NtlmChallengeHandler']/method[@name='processChallenge' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.NtlmChallenge']]"
		[Register ("processChallenge", "(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/NtlmChallenge;)Ljava/lang/Void;", "")]
		public unsafe global::Java.Lang.Void ProcessChallenge (global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.NtlmChallenge ntlmChallenge)
		{
			const string __id = "processChallenge.(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/NtlmChallenge;)Ljava/lang/Void;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ntlmChallenge == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ntlmChallenge).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ntlmChallenge);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler
		global::Java.Lang.Object global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler.ProcessChallenge (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(ProcessChallenge (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.NtlmChallenge>(p0)));
		}

	}
}
