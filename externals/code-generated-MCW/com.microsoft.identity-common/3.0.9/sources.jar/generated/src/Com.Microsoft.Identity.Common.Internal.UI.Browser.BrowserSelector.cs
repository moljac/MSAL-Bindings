using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Browser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserSelector']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/browser/BrowserSelector", DoNotGenerateAcw=true)]
	public partial class BrowserSelector : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/browser/BrowserSelector", typeof (BrowserSelector));

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

		protected BrowserSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserSelector']/constructor[@name='BrowserSelector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrowserSelector () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserSelector']/method[@name='getAllBrowsers' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAllBrowsers", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> GetAllBrowsers (global::Android.Content.Context context)
		{
			const string __id = "getAllBrowsers.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserSelector']/method[@name='select' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.microsoft.identity.common.internal.ui.browser.BrowserDescriptor&gt;']]"
		[Register ("select", "(Landroid/content/Context;Ljava/util/List;)Lcom/microsoft/identity/common/internal/ui/browser/Browser;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser Select (global::Android.Content.Context context, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor> browserSafeList)
		{
			const string __id = "select.(Landroid/content/Context;Ljava/util/List;)Lcom/microsoft/identity/common/internal/ui/browser/Browser;";
			IntPtr native_browserSafeList = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.ToLocalJniHandle (browserSafeList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_browserSafeList);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_browserSafeList);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (browserSafeList);
			}
		}

	}
}
