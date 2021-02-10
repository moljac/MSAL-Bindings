using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/SharedPreferencesAccountCredentialCache", DoNotGenerateAcw=true)]
	public partial class SharedPreferencesAccountCredentialCache : global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractAccountCredentialCache {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/field[@name='BROKER_FOCI_ACCOUNT_CREDENTIAL_SHARED_PREFERENCES']"
		[Register ("BROKER_FOCI_ACCOUNT_CREDENTIAL_SHARED_PREFERENCES")]
		public const string BrokerFociAccountCredentialSharedPreferences = (string) "com.microsoft.identity.client.account_credential_cache.foci-1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/field[@name='DEFAULT_ACCOUNT_CREDENTIAL_SHARED_PREFERENCES']"
		[Register ("DEFAULT_ACCOUNT_CREDENTIAL_SHARED_PREFERENCES")]
		public const string DefaultAccountCredentialSharedPreferences = (string) "com.microsoft.identity.client.account_credential_cache";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/SharedPreferencesAccountCredentialCache", typeof (SharedPreferencesAccountCredentialCache));

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

		protected SharedPreferencesAccountCredentialCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/constructor[@name='SharedPreferencesAccountCredentialCache' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheKeyValueDelegate'] and parameter[2][@type='com.microsoft.identity.common.internal.cache.ISharedPreferencesFileManager']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/cache/ICacheKeyValueDelegate;Lcom/microsoft/identity/common/internal/cache/ISharedPreferencesFileManager;)V", "")]
		public unsafe SharedPreferencesAccountCredentialCache (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate accountCacheValueDelegate, global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager sharedPreferencesFileManager) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/cache/ICacheKeyValueDelegate;Lcom/microsoft/identity/common/internal/cache/ISharedPreferencesFileManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((accountCacheValueDelegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accountCacheValueDelegate).Handle);
				__args [1] = new JniArgumentValue ((sharedPreferencesFileManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedPreferencesFileManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (accountCacheValueDelegate);
				global::System.GC.KeepAlive (sharedPreferencesFileManager);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.Accounts);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler")]
			get {
				const string __id = "getAccounts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Ljava/util/List;", "GetGetCredentialsHandler")]
			get {
				const string __id = "getCredentials.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public override unsafe void ClearAll ()
		{
			const string __id = "clearAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccount_Ljava_lang_String_Handler ()
		{
			if (cb_getAccount_Ljava_lang_String_ == null)
				cb_getAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccount_Ljava_lang_String_);
			return cb_getAccount_Ljava_lang_String_;
		}

		static IntPtr n_GetAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheKey = JNIEnv.GetString (native_cacheKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (cacheKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccount_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string cacheKey)
		{
			const string __id = "getAccount.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			IntPtr native_cacheKey = JNIEnv.NewString (cacheKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cacheKey);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheKey);
			}
		}

		static Delegate cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_homeAccountId, IntPtr native_environment, IntPtr native_realm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			var realm = JNIEnv.GetString (native_realm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.GetAccountsFilteredBy (homeAccountId, environment, realm));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getAccountsFilteredBy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccountsFilteredBy (string homeAccountId, string environment, string realm)
		{
			const string __id = "getAccountsFilteredBy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
			IntPtr native_environment = JNIEnv.NewString (environment);
			IntPtr native_realm = JNIEnv.NewString (realm);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_homeAccountId);
				__args [1] = new JniArgumentValue (native_environment);
				__args [2] = new JniArgumentValue (native_realm);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_homeAccountId);
				JNIEnv.DeleteLocalRef (native_environment);
				JNIEnv.DeleteLocalRef (native_realm);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getBrokerUidSequesteredFilename' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBrokerUidSequesteredFilename", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetBrokerUidSequesteredFilename (int uid)
		{
			const string __id = "getBrokerUidSequesteredFilename.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (uid);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCredential_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCredential_Ljava_lang_String_Handler ()
		{
			if (cb_getCredential_Ljava_lang_String_ == null)
				cb_getCredential_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCredential_Ljava_lang_String_);
			return cb_getCredential_Ljava_lang_String_;
		}

		static IntPtr n_GetCredential_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheKey = JNIEnv.GetString (native_cacheKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCredential (cacheKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getCredential' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCredential", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;", "GetGetCredential_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.Credential GetCredential (string cacheKey)
		{
			const string __id = "getCredential.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;";
			IntPtr native_cacheKey = JNIEnv.NewString (cacheKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cacheKey);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheKey);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getCredentialTypeForCredentialCacheKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCredentialTypeForCredentialCacheKey", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/CredentialType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType GetCredentialTypeForCredentialCacheKey (string cacheKey)
		{
			const string __id = "getCredentialTypeForCredentialCacheKey.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/CredentialType;";
			IntPtr native_cacheKey = JNIEnv.NewString (cacheKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cacheKey);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheKey);
			}
		}

		static Delegate cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLL_L) n_GetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_homeAccountId, IntPtr native_environment, IntPtr native_credentialType, IntPtr native_clientId, IntPtr native_realm, IntPtr native_target, IntPtr native_authScheme)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			var credentialType = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (native_credentialType, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			var realm = JNIEnv.GetString (native_realm, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			var authScheme = JNIEnv.GetString (native_authScheme, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (__this.GetCredentialsFilteredBy (homeAccountId, environment, credentialType, clientId, realm, target, authScheme));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='getCredentialsFilteredBy' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.CredentialType'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("getCredentialsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> GetCredentialsFilteredBy (string homeAccountId, string environment, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType credentialType, string clientId, string realm, string target, string authScheme)
		{
			const string __id = "getCredentialsFilteredBy.(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
			IntPtr native_environment = JNIEnv.NewString (environment);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_realm = JNIEnv.NewString (realm);
			IntPtr native_target = JNIEnv.NewString (target);
			IntPtr native_authScheme = JNIEnv.NewString (authScheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_homeAccountId);
				__args [1] = new JniArgumentValue (native_environment);
				__args [2] = new JniArgumentValue ((credentialType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialType).Handle);
				__args [3] = new JniArgumentValue (native_clientId);
				__args [4] = new JniArgumentValue (native_realm);
				__args [5] = new JniArgumentValue (native_target);
				__args [6] = new JniArgumentValue (native_authScheme);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_homeAccountId);
				JNIEnv.DeleteLocalRef (native_environment);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_realm);
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_authScheme);
				global::System.GC.KeepAlive (credentialType);
			}
		}

		static Delegate cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static bool n_RemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountToRemove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accountToRemove = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_accountToRemove, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (accountToRemove);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public override unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord accountToRemove)
		{
			const string __id = "removeAccount.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accountToRemove == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accountToRemove).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (accountToRemove);
			}
		}

		static Delegate cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static bool n_RemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialToRemove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credentialToRemove = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_credentialToRemove, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCredential (credentialToRemove);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='removeCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("removeCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Z", "GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public override unsafe bool RemoveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential credentialToRemove)
		{
			const string __id = "removeCredential.(Lcom/microsoft/identity/common/internal/dto/Credential;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credentialToRemove == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialToRemove).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (credentialToRemove);
			}
		}

		static Delegate cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetSaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static void n_SaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_account, JniHandleOwnership.DoNotTransfer);
			__this.SaveAccount (account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='saveAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("saveAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V", "GetSaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public override unsafe void SaveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord account)
		{
			const string __id = "saveAccount.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (account);
			}
		}

		static Delegate cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetSaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static void n_SaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credential)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credential = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_credential, JniHandleOwnership.DoNotTransfer);
			__this.SaveCredential (credential);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesAccountCredentialCache']/method[@name='saveCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("saveCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)V", "GetSaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public override unsafe void SaveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential credential)
		{
			const string __id = "saveCredential.(Lcom/microsoft/identity/common/internal/dto/Credential;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credential == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credential).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (credential);
			}
		}

	}
}
