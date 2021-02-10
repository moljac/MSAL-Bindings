using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authorities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AllAccounts']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/AllAccounts", DoNotGenerateAcw=true)]
	public partial class AllAccounts : global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AllAccounts']/field[@name='ALL_ACCOUNTS_TENANT_ID']"
		[Register ("ALL_ACCOUNTS_TENANT_ID")]
		public const string AllAccountsTenantId = (string) "common";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/AllAccounts", typeof (AllAccounts));

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

		protected AllAccounts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AllAccounts']/constructor[@name='AllAccounts' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AllAccounts () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AllAccounts']/constructor[@name='AllAccounts' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AllAccounts (string cloudUrl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cloudUrl = JNIEnv.NewString (cloudUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cloudUrl);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cloudUrl);
			}
		}

	}
}
