using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='AuthenticationSchemeFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/AuthenticationSchemeFactory", DoNotGenerateAcw=true)]
	public partial class AuthenticationSchemeFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/AuthenticationSchemeFactory", typeof (AuthenticationSchemeFactory));

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

		protected AuthenticationSchemeFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='AuthenticationSchemeFactory']/constructor[@name='AuthenticationSchemeFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthenticationSchemeFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='AuthenticationSchemeFactory']/method[@name='createScheme' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.microsoft.identity.common.internal.authscheme.INameable']]"
		[Register ("createScheme", "(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authscheme/INameable;)Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme CreateScheme (global::Android.Content.Context context, global::Com.Microsoft.Identity.Common.Internal.Authscheme.INameable nameable)
		{
			const string __id = "createScheme.(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authscheme/INameable;)Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((nameable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nameable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (nameable);
			}
		}

	}
}
