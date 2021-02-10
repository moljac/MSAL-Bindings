using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='ClientCertAuthChallengeHandler']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/ClientCertAuthChallengeHandler", DoNotGenerateAcw=true)]
	public sealed partial class ClientCertAuthChallengeHandler : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/ClientCertAuthChallengeHandler", typeof (ClientCertAuthChallengeHandler));

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

		internal ClientCertAuthChallengeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='ClientCertAuthChallengeHandler']/constructor[@name='ClientCertAuthChallengeHandler' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe ClientCertAuthChallengeHandler (global::Android.App.Activity activity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='ClientCertAuthChallengeHandler']/method[@name='processChallenge' and count(parameter)=1 and parameter[1][@type='android.webkit.ClientCertRequest']]"
		[Register ("processChallenge", "(Landroid/webkit/ClientCertRequest;)Ljava/lang/Void;", "")]
		public unsafe global::Java.Lang.Void ProcessChallenge (global::Android.Webkit.ClientCertRequest request)
		{
			const string __id = "processChallenge.(Landroid/webkit/ClientCertRequest;)Ljava/lang/Void;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (request);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler
		global::Java.Lang.Object global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IChallengeHandler.ProcessChallenge (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(ProcessChallenge (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Android.Webkit.ClientCertRequest>(p0)));
		}

	}
}
