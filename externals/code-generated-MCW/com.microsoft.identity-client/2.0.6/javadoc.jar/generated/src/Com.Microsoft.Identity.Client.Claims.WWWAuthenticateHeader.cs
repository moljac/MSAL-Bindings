using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Claims {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='WWWAuthenticateHeader']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/claims/WWWAuthenticateHeader", DoNotGenerateAcw=true)]
	public partial class WWWAuthenticateHeader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/claims/WWWAuthenticateHeader", typeof (WWWAuthenticateHeader));

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

		protected WWWAuthenticateHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='WWWAuthenticateHeader']/constructor[@name='WWWAuthenticateHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WWWAuthenticateHeader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='WWWAuthenticateHeader']/method[@name='getClaimsRequestFromWWWAuthenticateHeaderValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClaimsRequestFromWWWAuthenticateHeaderValue", "(Ljava/lang/String;)Lcom/microsoft/identity/client/claims/ClaimsRequest;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest GetClaimsRequestFromWWWAuthenticateHeaderValue (string headerValue)
		{
			const string __id = "getClaimsRequestFromWWWAuthenticateHeaderValue.(Ljava/lang/String;)Lcom/microsoft/identity/client/claims/ClaimsRequest;";
			IntPtr native_headerValue = JNIEnv.NewString (headerValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='WWWAuthenticateHeader']/method[@name='hasClaimsDirective' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasClaimsDirective", "(Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean HasClaimsDirective (string headerValue)
		{
			const string __id = "hasClaimsDirective.(Ljava/lang/String;)Ljava/lang/Boolean;";
			IntPtr native_headerValue = JNIEnv.NewString (headerValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerValue);
			}
		}

	}
}
