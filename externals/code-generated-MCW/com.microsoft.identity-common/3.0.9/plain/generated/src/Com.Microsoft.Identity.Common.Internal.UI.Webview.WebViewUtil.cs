using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='WebViewUtil']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/WebViewUtil", DoNotGenerateAcw=true)]
	public partial class WebViewUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/WebViewUtil", typeof (WebViewUtil));

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

		protected WebViewUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='WebViewUtil']/constructor[@name='WebViewUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebViewUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='WebViewUtil']/method[@name='removeCookiesFromWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("removeCookiesFromWebView", "(Landroid/content/Context;)V", "")]
		public static unsafe void RemoveCookiesFromWebView (global::Android.Content.Context context)
		{
			const string __id = "removeCookiesFromWebView.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='WebViewUtil']/method[@name='removeSessionCookiesFromWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("removeSessionCookiesFromWebView", "(Landroid/content/Context;)V", "")]
		public static unsafe void RemoveSessionCookiesFromWebView (global::Android.Content.Context context)
		{
			const string __id = "removeSessionCookiesFromWebView.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='WebViewUtil']/method[@name='setAcceptCookie' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='android.content.Context']]"
		[Register ("setAcceptCookie", "(ZLandroid/content/Context;)V", "")]
		public static unsafe void SetAcceptCookie (bool acceptCookie, global::Android.Content.Context context)
		{
			const string __id = "setAcceptCookie.(ZLandroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (acceptCookie);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='WebViewUtil']/method[@name='setDataDirectorySuffix' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setDataDirectorySuffix", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetDataDirectorySuffix (global::Android.Content.Context context)
		{
			const string __id = "setDataDirectorySuffix.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
