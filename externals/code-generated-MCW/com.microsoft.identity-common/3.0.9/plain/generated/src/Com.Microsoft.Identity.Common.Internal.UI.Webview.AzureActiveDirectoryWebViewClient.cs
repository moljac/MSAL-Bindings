using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='AzureActiveDirectoryWebViewClient']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/AzureActiveDirectoryWebViewClient", DoNotGenerateAcw=true)]
	public partial class AzureActiveDirectoryWebViewClient : global::Com.Microsoft.Identity.Common.Internal.UI.Webview.OAuth2WebViewClient {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='AzureActiveDirectoryWebViewClient']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const string Error = (string) "error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='AzureActiveDirectoryWebViewClient']/field[@name='ERROR_DESCRIPTION']"
		[Register ("ERROR_DESCRIPTION")]
		public const string ErrorDescription = (string) "error_description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='AzureActiveDirectoryWebViewClient']/field[@name='ERROR_SUBCODE']"
		[Register ("ERROR_SUBCODE")]
		public const string ErrorSubcode = (string) "error_subcode";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/AzureActiveDirectoryWebViewClient", typeof (AzureActiveDirectoryWebViewClient));

		internal static new IntPtr class_ref {
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

		protected AzureActiveDirectoryWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='AzureActiveDirectoryWebViewClient']/constructor[@name='AzureActiveDirectoryWebViewClient' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.IAuthorizationCompletionCallback'] and parameter[3][@type='com.microsoft.identity.common.internal.ui.webview.OnPageLoadedCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback;Lcom/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback;Ljava/lang/String;)V", "")]
		public unsafe AzureActiveDirectoryWebViewClient (global::Android.App.Activity activity, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.IAuthorizationCompletionCallback completionCallback, global::Com.Microsoft.Identity.Common.Internal.UI.Webview.IOnPageLoadedCallback pageLoadedCallback, string redirectUrl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/IAuthorizationCompletionCallback;Lcom/microsoft/identity/common/internal/ui/webview/OnPageLoadedCallback;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_redirectUrl = JNIEnv.NewString (redirectUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((completionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionCallback).Handle);
				__args [2] = new JniArgumentValue ((pageLoadedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pageLoadedCallback).Handle);
				__args [3] = new JniArgumentValue (native_redirectUrl);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_redirectUrl);
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (completionCallback);
				global::System.GC.KeepAlive (pageLoadedCallback);
			}
		}

		static Delegate cb_processRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_Handler ()
		{
			if (cb_processRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_ == null)
				cb_processRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_ProcessRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_);
			return cb_processRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_;
		}

		static bool n_ProcessRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.AzureActiveDirectoryWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessRedirectUrl (view, url);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview']/class[@name='AzureActiveDirectoryWebViewClient']/method[@name='processRedirectUrl' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("processRedirectUrl", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", "GetProcessRedirectUrl_Landroid_webkit_WebView_Ljava_lang_String_Handler")]
		protected virtual unsafe bool ProcessRedirectUrl (global::Android.Webkit.WebView view, string url)
		{
			const string __id = "processRedirectUrl.(Landroid/webkit/WebView;Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
