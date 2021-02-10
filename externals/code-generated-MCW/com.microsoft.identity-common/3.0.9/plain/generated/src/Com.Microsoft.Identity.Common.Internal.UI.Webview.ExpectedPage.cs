using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='ExpectedPage']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/ExpectedPage", DoNotGenerateAcw=true)]
	public partial class ExpectedPage : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/ExpectedPage", typeof (ExpectedPage));

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

		protected ExpectedPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='ExpectedPage']/constructor[@name='ExpectedPage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.ui.webview.OnPageLoadedCallback']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback;)V", "")]
		public unsafe ExpectedPage (string expectedUrlStartsWith, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.IOnPageLoadedCallback @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_expectedUrlStartsWith = JNIEnv.NewString (expectedUrlStartsWith);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expectedUrlStartsWith);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_expectedUrlStartsWith);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
