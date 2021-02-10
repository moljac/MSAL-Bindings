using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericAuthorizationResult extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationResult", "GenericAuthorizationRequest extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest"})]
	public abstract partial class AuthorizationResultFactory : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/field[@name='CODE']"
		[Register ("CODE")]
		protected const string Code = (string) "code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/field[@name='ERROR']"
		[Register ("ERROR")]
		protected const string Error = (string) "error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/field[@name='ERROR_CODE']"
		[Register ("ERROR_CODE")]
		protected const string ErrorCode = (string) "error_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/field[@name='ERROR_DESCRIPTION']"
		[Register ("ERROR_DESCRIPTION")]
		protected const string ErrorDescription = (string) "error_description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/field[@name='ERROR_SUBCODE']"
		[Register ("ERROR_SUBCODE")]
		protected const string ErrorSubcode = (string) "error_subcode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/field[@name='STATE']"
		[Register ("STATE")]
		protected const string State = (string) "state";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory", typeof (AuthorizationResultFactory));

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

		protected AuthorizationResultFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/constructor[@name='AuthorizationResultFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizationResultFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_createAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_;
#pragma warning disable 0169
		static Delegate GetCreateAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler ()
		{
			if (cb_createAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ == null)
				cb_createAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_L) n_CreateAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_);
			return cb_createAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_;
		}

		static IntPtr n_CreateAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationResultFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAuthorizationResult (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/method[@name='createAuthorizationResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='GenericAuthorizationRequest']]"
		[Register ("createAuthorizationResult", "(ILandroid/content/Intent;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;", "GetCreateAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler")]
		public abstract global::Java.Lang.Object CreateAuthorizationResult (int p0, global::Android.Content.Intent p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory", DoNotGenerateAcw=true)]
	internal partial class AuthorizationResultFactoryInvoker : AuthorizationResultFactory {
		public AuthorizationResultFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationResultFactory", typeof (AuthorizationResultFactoryInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationResultFactory']/method[@name='createAuthorizationResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='GenericAuthorizationRequest']]"
		[Register ("createAuthorizationResult", "(ILandroid/content/Intent;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;", "GetCreateAuthorizationResult_ILandroid_content_Intent_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Handler")]
		public override unsafe global::Java.Lang.Object CreateAuthorizationResult (int p0, global::Android.Content.Intent p1, global::Java.Lang.Object p2)
		{
			const string __id = "createAuthorizationResult.(ILandroid/content/Intent;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationResult;";
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
