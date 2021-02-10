using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/IntuneAppProtectionPolicyRequiredException", DoNotGenerateAcw=true)]
	public partial class IntuneAppProtectionPolicyRequiredException : global::Com.Microsoft.Identity.Common.Exception.ServiceException {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/field[@name='sName']"
		[Register ("sName")]
		public static string SName {
			get {
				const string __id = "sName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/IntuneAppProtectionPolicyRequiredException", typeof (IntuneAppProtectionPolicyRequiredException));

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

		protected IntuneAppProtectionPolicyRequiredException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/constructor[@name='IntuneAppProtectionPolicyRequiredException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe IntuneAppProtectionPolicyRequiredException (string errorCode, string errorMessage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/constructor[@name='IntuneAppProtectionPolicyRequiredException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe IntuneAppProtectionPolicyRequiredException (string errorCode, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (throwable);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountUpn);
		}
#pragma warning restore 0169

		static Delegate cb_setAccountUpn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountUpn_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountUpn_Ljava_lang_String_ == null)
				cb_setAccountUpn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccountUpn_Ljava_lang_String_);
			return cb_setAccountUpn_Ljava_lang_String_;
		}

		static void n_SetAccountUpn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountUpn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accountUpn = JNIEnv.GetString (native_accountUpn, JniHandleOwnership.DoNotTransfer);
			__this.AccountUpn = accountUpn;
		}
#pragma warning restore 0169

		public virtual unsafe string AccountUpn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='getAccountUpn' and count(parameter)=0]"
			[Register ("getAccountUpn", "()Ljava/lang/String;", "GetGetAccountUpnHandler")]
			get {
				const string __id = "getAccountUpn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='setAccountUpn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountUpn", "(Ljava/lang/String;)V", "GetSetAccountUpn_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccountUpn.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountUserId);
		}
#pragma warning restore 0169

		static Delegate cb_setAccountUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountUserId_Ljava_lang_String_ == null)
				cb_setAccountUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccountUserId_Ljava_lang_String_);
			return cb_setAccountUserId_Ljava_lang_String_;
		}

		static void n_SetAccountUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountUserId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accountUserId = JNIEnv.GetString (native_accountUserId, JniHandleOwnership.DoNotTransfer);
			__this.AccountUserId = accountUserId;
		}
#pragma warning restore 0169

		public virtual unsafe string AccountUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='getAccountUserId' and count(parameter)=0]"
			[Register ("getAccountUserId", "()Ljava/lang/String;", "GetGetAccountUserIdHandler")]
			get {
				const string __id = "getAccountUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='setAccountUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountUserId", "(Ljava/lang/String;)V", "GetSetAccountUserId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccountUserId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorityUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthorityUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthorityUrl_Ljava_lang_String_ == null)
				cb_setAuthorityUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorityUrl_Ljava_lang_String_);
			return cb_setAuthorityUrl_Ljava_lang_String_;
		}

		static void n_SetAuthorityUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorityUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorityUrl = JNIEnv.GetString (native_authorityUrl, JniHandleOwnership.DoNotTransfer);
			__this.AuthorityUrl = authorityUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorityUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='getAuthorityUrl' and count(parameter)=0]"
			[Register ("getAuthorityUrl", "()Ljava/lang/String;", "GetGetAuthorityUrlHandler")]
			get {
				const string __id = "getAuthorityUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='setAuthorityUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthorityUrl", "(Ljava/lang/String;)V", "GetSetAuthorityUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthorityUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		static Delegate cb_setTenantId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTenantId_Ljava_lang_String_Handler ()
		{
			if (cb_setTenantId_Ljava_lang_String_ == null)
				cb_setTenantId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTenantId_Ljava_lang_String_);
			return cb_setTenantId_Ljava_lang_String_;
		}

		static void n_SetTenantId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tenantId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.IntuneAppProtectionPolicyRequiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tenantId = JNIEnv.GetString (native_tenantId, JniHandleOwnership.DoNotTransfer);
			__this.TenantId = tenantId;
		}
#pragma warning restore 0169

		public virtual unsafe string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler")]
			get {
				const string __id = "getTenantId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='IntuneAppProtectionPolicyRequiredException']/method[@name='setTenantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTenantId", "(Ljava/lang/String;)V", "GetSetTenantId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTenantId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
