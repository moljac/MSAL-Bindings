using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TenantProfile']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/TenantProfile", DoNotGenerateAcw=true)]
	public partial class TenantProfile : global::Com.Microsoft.Identity.Client.Account, global::Com.Microsoft.Identity.Client.ITenantProfile {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TenantProfile", typeof (TenantProfile));

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

		protected TenantProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TenantProfile']/constructor[@name='TenantProfile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.IDToken']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)V", "")]
		public unsafe TenantProfile (string clientInfo, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken idToken) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_clientInfo = JNIEnv.NewString (clientInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientInfo);
				__args [1] = new JniArgumentValue ((idToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idToken).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientInfo);
				global::System.GC.KeepAlive (idToken);
			}
		}

	}
}
