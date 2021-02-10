using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalIntuneAppProtectionPolicyRequiredException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/exception/MsalIntuneAppProtectionPolicyRequiredException", DoNotGenerateAcw=true)]
	public partial class MsalIntuneAppProtectionPolicyRequiredException : global::Com.Microsoft.Identity.Client.Exception.MsalServiceException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/exception/MsalIntuneAppProtectionPolicyRequiredException", typeof (MsalIntuneAppProtectionPolicyRequiredException));

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

		protected MsalIntuneAppProtectionPolicyRequiredException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalIntuneAppProtectionPolicyRequiredException']/constructor[@name='MsalIntuneAppProtectionPolicyRequiredException' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.exception.IntuneAppProtectionPolicyRequiredException']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/exception/IntuneAppProtectionPolicyRequiredException;)V", "")]
		public unsafe MsalIntuneAppProtectionPolicyRequiredException (global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException exception) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/exception/IntuneAppProtectionPolicyRequiredException;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

		static Delegate cb_getAccountUpn;
#pragma warning disable 0169
		static Delegate GetGetAccountUpnHandler ()
		{
			if (cb_getAccountUpn == null)
				cb_getAccountUpn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccountUpn);
			return cb_getAccountUpn;
		}

		static IntPtr n_GetAccountUpn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalIntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountUpn);
		}
#pragma warning restore 0169

		public virtual unsafe string AccountUpn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalIntuneAppProtectionPolicyRequiredException']/method[@name='getAccountUpn' and count(parameter)=0]"
			[Register ("getAccountUpn", "()Ljava/lang/String;", "GetGetAccountUpnHandler")]
			get {
				const string __id = "getAccountUpn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccountUserId;
#pragma warning disable 0169
		static Delegate GetGetAccountUserIdHandler ()
		{
			if (cb_getAccountUserId == null)
				cb_getAccountUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccountUserId);
			return cb_getAccountUserId;
		}

		static IntPtr n_GetAccountUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalIntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountUserId);
		}
#pragma warning restore 0169

		public virtual unsafe string AccountUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalIntuneAppProtectionPolicyRequiredException']/method[@name='getAccountUserId' and count(parameter)=0]"
			[Register ("getAccountUserId", "()Ljava/lang/String;", "GetGetAccountUserIdHandler")]
			get {
				const string __id = "getAccountUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorityUrl;
#pragma warning disable 0169
		static Delegate GetGetAuthorityUrlHandler ()
		{
			if (cb_getAuthorityUrl == null)
				cb_getAuthorityUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityUrl);
			return cb_getAuthorityUrl;
		}

		static IntPtr n_GetAuthorityUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalIntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorityUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalIntuneAppProtectionPolicyRequiredException']/method[@name='getAuthorityUrl' and count(parameter)=0]"
			[Register ("getAuthorityUrl", "()Ljava/lang/String;", "GetGetAuthorityUrlHandler")]
			get {
				const string __id = "getAuthorityUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTenantId;
#pragma warning disable 0169
		static Delegate GetGetTenantIdHandler ()
		{
			if (cb_getTenantId == null)
				cb_getTenantId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantId);
			return cb_getTenantId;
		}

		static IntPtr n_GetTenantId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalIntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		public virtual unsafe string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalIntuneAppProtectionPolicyRequiredException']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler")]
			get {
				const string __id = "getTenantId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
