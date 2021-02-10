using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Browser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserDescriptor']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/browser/BrowserDescriptor", DoNotGenerateAcw=true)]
	public partial class BrowserDescriptor : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/browser/BrowserDescriptor", typeof (BrowserDescriptor));

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

		protected BrowserDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserDescriptor']/constructor[@name='BrowserDescriptor' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BrowserDescriptor (string packageName, string signatureHash, string versionLowerBound, string versionUpperBound) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_packageName = JNIEnv.NewString (packageName);
			IntPtr native_signatureHash = JNIEnv.NewString (signatureHash);
			IntPtr native_versionLowerBound = JNIEnv.NewString (versionLowerBound);
			IntPtr native_versionUpperBound = JNIEnv.NewString (versionUpperBound);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_signatureHash);
				__args [2] = new JniArgumentValue (native_versionLowerBound);
				__args [3] = new JniArgumentValue (native_versionUpperBound);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				JNIEnv.DeleteLocalRef (native_signatureHash);
				JNIEnv.DeleteLocalRef (native_versionLowerBound);
				JNIEnv.DeleteLocalRef (native_versionUpperBound);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserDescriptor']/constructor[@name='BrowserDescriptor' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BrowserDescriptor (string packageName, global::System.Collections.Generic.ICollection<string> signatureHashes, string versionLowerBound, string versionUpperBound) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_packageName = JNIEnv.NewString (packageName);
			IntPtr native_signatureHashes = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (signatureHashes);
			IntPtr native_versionLowerBound = JNIEnv.NewString (versionLowerBound);
			IntPtr native_versionUpperBound = JNIEnv.NewString (versionUpperBound);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_signatureHashes);
				__args [2] = new JniArgumentValue (native_versionLowerBound);
				__args [3] = new JniArgumentValue (native_versionUpperBound);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				JNIEnv.DeleteLocalRef (native_signatureHashes);
				JNIEnv.DeleteLocalRef (native_versionLowerBound);
				JNIEnv.DeleteLocalRef (native_versionUpperBound);
				global::System.GC.KeepAlive (signatureHashes);
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

		static bool n_Matches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_browser)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var browser = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (native_browser, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (browser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserDescriptor']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.browser.Browser']]"
		[Register ("matches", "(Lcom/microsoft/identity/common/internal/ui/browser/Browser;)Z", "GetMatches_Lcom_microsoft_identity_common_internal_ui_browser_Browser_Handler")]
		public virtual unsafe bool Matches (global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser browser)
		{
			const string __id = "matches.(Lcom/microsoft/identity/common/internal/ui/browser/Browser;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((browser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) browser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (browser);
			}
		}

	}
}
