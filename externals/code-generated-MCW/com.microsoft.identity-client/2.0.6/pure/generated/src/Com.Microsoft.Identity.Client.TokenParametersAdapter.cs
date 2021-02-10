using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParametersAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenParametersAdapter", DoNotGenerateAcw=true)]
	public partial class TokenParametersAdapter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenParametersAdapter", typeof (TokenParametersAdapter));

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

		protected TokenParametersAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParametersAdapter']/constructor[@name='TokenParametersAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenParametersAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenParametersAdapter']/method[@name='silentParametersFromInteractive' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenParameters'] and parameter[2][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult']]"
		[Register ("silentParametersFromInteractive", "(Lcom/microsoft/identity/client/AcquireTokenParameters;Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)Lcom/microsoft/identity/client/AcquireTokenSilentParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters SilentParametersFromInteractive (global::Com.Microsoft.Identity.Client.AcquireTokenParameters acquireTokenParameters, global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult localAuthenticationResult)
		{
			const string __id = "silentParametersFromInteractive.(Lcom/microsoft/identity/client/AcquireTokenParameters;Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)Lcom/microsoft/identity/client/AcquireTokenSilentParameters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((acquireTokenParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenParameters).Handle);
				__args [1] = new JniArgumentValue ((localAuthenticationResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localAuthenticationResult).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (acquireTokenParameters);
				global::System.GC.KeepAlive (localAuthenticationResult);
			}
		}

	}
}
