using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/AbstractAccountCredentialCache", DoNotGenerateAcw=true)]
	public abstract partial class AbstractAccountCredentialCache : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/AbstractAccountCredentialCache", typeof (AbstractAccountCredentialCache));

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

		protected AbstractAccountCredentialCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/constructor[@name='AbstractAccountCredentialCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractAccountCredentialCache () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_getAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_homeAccountId, IntPtr native_environment, IntPtr native_realm, IntPtr native_allAccounts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			var realm = JNIEnv.GetString (native_realm, JniHandleOwnership.DoNotTransfer);
			var allAccounts = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (native_allAccounts, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.GetAccountsFilteredByInternal (homeAccountId, environment, realm, allAccounts));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getAccountsFilteredByInternal' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;com.microsoft.identity.common.internal.dto.AccountRecord&gt;']]"
		[Register ("getAccountsFilteredByInternal", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetAccountsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccountsFilteredByInternal (string homeAccountId, string environment, string realm, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> allAccounts)
		{
			const string __id = "getAccountsFilteredByInternal.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;";
			IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
			IntPtr native_environment = JNIEnv.NewString (environment);
			IntPtr native_realm = JNIEnv.NewString (realm);
			IntPtr native_allAccounts = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (allAccounts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_homeAccountId);
				__args [1] = new JniArgumentValue (native_environment);
				__args [2] = new JniArgumentValue (native_realm);
				__args [3] = new JniArgumentValue (native_allAccounts);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_homeAccountId);
				JNIEnv.DeleteLocalRef (native_environment);
				JNIEnv.DeleteLocalRef (native_realm);
				JNIEnv.DeleteLocalRef (native_allAccounts);
				global::System.GC.KeepAlive (allAccounts);
			}
		}

		static Delegate cb_getCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLLL_L) n_GetCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_getCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_homeAccountId, IntPtr native_environment, IntPtr native_credentialType, IntPtr native_clientId, IntPtr native_realm, IntPtr native_target, IntPtr native_authScheme, IntPtr native_allCredentials)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			var credentialType = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (native_credentialType, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			var realm = JNIEnv.GetString (native_realm, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			var authScheme = JNIEnv.GetString (native_authScheme, JniHandleOwnership.DoNotTransfer);
			var allCredentials = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (native_allCredentials, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (__this.GetCredentialsFilteredByInternal (homeAccountId, environment, credentialType, clientId, realm, target, authScheme, allCredentials));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getCredentialsFilteredByInternal' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.CredentialType'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.util.List&lt;com.microsoft.identity.common.internal.dto.Credential&gt;']]"
		[Register ("getCredentialsFilteredByInternal", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetCredentialsFilteredByInternal_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> GetCredentialsFilteredByInternal (string homeAccountId, string environment, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType credentialType, string clientId, string realm, string target, string authScheme, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> allCredentials)
		{
			const string __id = "getCredentialsFilteredByInternal.(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;";
			IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
			IntPtr native_environment = JNIEnv.NewString (environment);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_realm = JNIEnv.NewString (realm);
			IntPtr native_target = JNIEnv.NewString (target);
			IntPtr native_authScheme = JNIEnv.NewString (authScheme);
			IntPtr native_allCredentials = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (allCredentials);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_homeAccountId);
				__args [1] = new JniArgumentValue (native_environment);
				__args [2] = new JniArgumentValue ((credentialType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialType).Handle);
				__args [3] = new JniArgumentValue (native_clientId);
				__args [4] = new JniArgumentValue (native_realm);
				__args [5] = new JniArgumentValue (native_target);
				__args [6] = new JniArgumentValue (native_authScheme);
				__args [7] = new JniArgumentValue (native_allCredentials);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_homeAccountId);
				JNIEnv.DeleteLocalRef (native_environment);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_realm);
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_authScheme);
				JNIEnv.DeleteLocalRef (native_allCredentials);
				global::System.GC.KeepAlive (credentialType);
				global::System.GC.KeepAlive (allCredentials);
			}
		}

		static Delegate cb_getTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_;
#pragma warning disable 0169
		static Delegate GetGetTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Handler ()
		{
			if (cb_getTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_ == null)
				cb_getTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_);
			return cb_getTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_;
		}

		static IntPtr n_GetTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheKey, IntPtr native_targetType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheKey = JNIEnv.GetString (native_cacheKey, JniHandleOwnership.DoNotTransfer);
			var targetType = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (native_targetType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTargetClassForCredentialType (cacheKey, targetType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getTargetClassForCredentialType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.CredentialType']]"
		[Register ("getTargetClassForCredentialType", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;)Ljava/lang/Class;", "GetGetTargetClassForCredentialType_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Handler")]
		protected virtual unsafe global::Java.Lang.Class GetTargetClassForCredentialType (string cacheKey, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType targetType)
		{
			const string __id = "getTargetClassForCredentialType.(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;)Ljava/lang/Class;";
			IntPtr native_cacheKey = JNIEnv.NewString (cacheKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cacheKey);
				__args [1] = new JniArgumentValue ((targetType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheKey);
				global::System.GC.KeepAlive (targetType);
			}
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearAll);
			return cb_clearAll;
		}

		static void n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public abstract void ClearAll ();

		static Delegate cb_getAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccount_Ljava_lang_String_Handler ()
		{
			if (cb_getAccount_Ljava_lang_String_ == null)
				cb_getAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccount_Ljava_lang_String_);
			return cb_getAccount_Ljava_lang_String_;
		}

		static IntPtr n_GetAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccount_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string p0);

		static Delegate cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.GetAccountsFilteredBy (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccountsFilteredBy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccountsFilteredBy (string p0, string p1, string p2);

		static Delegate cb_getCredential_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCredential_Ljava_lang_String_Handler ()
		{
			if (cb_getCredential_Ljava_lang_String_ == null)
				cb_getCredential_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCredential_Ljava_lang_String_);
			return cb_getCredential_Ljava_lang_String_;
		}

		static IntPtr n_GetCredential_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCredential (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredential' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCredential", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;", "GetGetCredential_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Dto.Credential GetCredential (string p0);

		static Delegate cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLL_L) n_GetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (__this.GetCredentialsFilteredBy (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredentialsFilteredBy' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.CredentialType'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("getCredentialsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> GetCredentialsFilteredBy (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType p2, string p3, string p4, string p5, string p6);

		static Delegate cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static bool n_RemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public abstract bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0);

		static Delegate cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static bool n_RemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCredential (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='removeCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("removeCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Z", "GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public abstract bool RemoveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

		static Delegate cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetSaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static void n_SaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveAccount (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='saveAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("saveAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V", "GetSaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public abstract void SaveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0);

		static Delegate cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetSaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static void n_SaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveCredential (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='saveCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("saveCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)V", "GetSaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public abstract void SaveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

		static Delegate cb_getAccounts;
#pragma warning disable 0169
		static Delegate GetGetAccountsHandler ()
		{
			if (cb_getAccounts == null)
				cb_getAccounts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccounts);
			return cb_getAccounts;
		}

		static IntPtr n_GetAccounts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.Accounts);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler")]
			get; 
		}

		static Delegate cb_getCredentials;
#pragma warning disable 0169
		static Delegate GetGetCredentialsHandler ()
		{
			if (cb_getCredentials == null)
				cb_getCredentials = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCredentials);
			return cb_getCredentials;
		}

		static IntPtr n_GetCredentials (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Ljava/util/List;", "GetGetCredentialsHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/AbstractAccountCredentialCache", DoNotGenerateAcw=true)]
	internal partial class AbstractAccountCredentialCacheInvoker : AbstractAccountCredentialCache {
		public AbstractAccountCredentialCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/AbstractAccountCredentialCache", typeof (AbstractAccountCredentialCacheInvoker));

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

		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler")]
			get {
				const string __id = "getAccounts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AbstractAccountCredentialCache']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Ljava/util/List;", "GetGetCredentialsHandler")]
			get {
				const string __id = "getCredentials.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public override unsafe void ClearAll ()
		{
			const string __id = "clearAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccount_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string p0)
		{
			const string __id = "getAccount.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccountsFilteredBy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccountsFilteredBy (string p0, string p1, string p2)
		{
			const string __id = "getAccountsFilteredBy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredential' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCredential", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;", "GetGetCredential_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.Credential GetCredential (string p0)
		{
			const string __id = "getCredential.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredentialsFilteredBy' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.CredentialType'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("getCredentialsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> GetCredentialsFilteredBy (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "getCredentialsFilteredBy.(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public override unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0)
		{
			const string __id = "removeAccount.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='removeCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("removeCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Z", "GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public override unsafe bool RemoveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0)
		{
			const string __id = "removeCredential.(Lcom/microsoft/identity/common/internal/dto/Credential;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='saveAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("saveAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V", "GetSaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public override unsafe void SaveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0)
		{
			const string __id = "saveAccount.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='saveCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("saveCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)V", "GetSaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public override unsafe void SaveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0)
		{
			const string __id = "saveCredential.(Lcom/microsoft/identity/common/internal/dto/Credential;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
