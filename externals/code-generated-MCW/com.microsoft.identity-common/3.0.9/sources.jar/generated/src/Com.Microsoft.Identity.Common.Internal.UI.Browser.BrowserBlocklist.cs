using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Browser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserBlocklist']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/browser/BrowserBlocklist", DoNotGenerateAcw=true)]
	public partial class BrowserBlocklist : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/browser/BrowserBlocklist", typeof (BrowserBlocklist));

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

		protected BrowserBlocklist (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserBlocklist']/constructor[@name='BrowserBlocklist' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.browser.Browser...']]"
		[Register (".ctor", "([Lcom/microsoft/identity/common/internal/ui/browser/Browser;)V", "")]
		public unsafe BrowserBlocklist (params global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser[] browsers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/microsoft/identity/common/internal/ui/browser/Browser;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_browsers = JNIEnv.NewArray (browsers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_browsers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (browsers != null) {
					JNIEnv.CopyArray (native_browsers, browsers);
					JNIEnv.DeleteLocalRef (native_browsers);
				}
				global::System.GC.KeepAlive (browsers);
			}
		}

		static Delegate cb_matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_;
#pragma warning disable 0169
		static Delegate GetMatches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_Handler ()
		{
			if (cb_matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_ == null)
				cb_matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_);
			return cb_matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_;
		}

		static bool n_Matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetBrowser)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserBlocklist> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetBrowser = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (native_targetBrowser, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (targetBrowser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserBlocklist']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.browser.Browser']]"
		[Register ("matches", "(Lcom/microsoft/identity/common/internal/ui/browser/Browser;)Z", "GetMatches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_Handler")]
		public virtual unsafe bool Matches (global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser targetBrowser)
		{
			const string __id = "matches.(Lcom/microsoft/identity/common/internal/ui/browser/Browser;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetBrowser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetBrowser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (targetBrowser);
			}
		}

	}
}
