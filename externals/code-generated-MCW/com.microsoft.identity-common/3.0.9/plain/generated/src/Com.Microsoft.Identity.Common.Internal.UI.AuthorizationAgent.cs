using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationAgent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/AuthorizationAgent", DoNotGenerateAcw=true)]
	public sealed partial class AuthorizationAgent : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationAgent']/field[@name='BROWSER']"
		[Register ("BROWSER")]
		public static global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent Browser {
			get {
				const string __id = "BROWSER.Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationAgent']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent Default {
			get {
				const string __id = "DEFAULT.Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationAgent']/field[@name='WEBVIEW']"
		[Register ("WEBVIEW")]
		public static global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent Webview {
			get {
				const string __id = "WEBVIEW.Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/AuthorizationAgent", typeof (AuthorizationAgent));

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

		internal AuthorizationAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationAgent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationAgent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent));
			} finally {
			}
		}

	}
}
