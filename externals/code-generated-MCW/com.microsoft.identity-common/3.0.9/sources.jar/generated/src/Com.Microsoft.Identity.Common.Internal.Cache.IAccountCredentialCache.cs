using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']"
	[Register ("com/microsoft/identity/common/internal/cache/IAccountCredentialCache", "", "Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker")]
	public partial interface IAccountCredentialCache : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Ljava/util/List;", "GetGetCredentialsHandler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		void ClearAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccount_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getAccountsFilteredBy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccountsFilteredBy (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredential' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCredential", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;", "GetGetCredential_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.Credential GetCredential (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='getCredentialsFilteredBy' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.CredentialType'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("getCredentialsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> GetCredentialsFilteredBy (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType p2, string p3, string p4, string p5, string p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z", "GetRemoveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='removeCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("removeCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Z", "GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		bool RemoveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='saveAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("saveAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V", "GetSaveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		void SaveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialCache']/method[@name='saveCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("saveCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)V", "GetSaveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCacheInvoker, Microsoft.Identity.Common")]
		void SaveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/IAccountCredentialCache", DoNotGenerateAcw=true)]
	internal partial class IAccountCredentialCacheInvoker : global::Java.Lang.Object, IAccountCredentialCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/IAccountCredentialCache", typeof (IAccountCredentialCacheInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAccountCredentialCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccountCredentialCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.IAccountCredentialCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccountCredentialCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.Accounts);
		}
#pragma warning restore 0169

		IntPtr id_getAccounts;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> Accounts {
			get {
				if (id_getAccounts == IntPtr.Zero)
					id_getAccounts = JNIEnv.GetMethodID (class_ref, "getAccounts", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccounts), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		IntPtr id_getCredentials;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> Credentials {
			get {
				if (id_getCredentials == IntPtr.Zero)
					id_getCredentials = JNIEnv.GetMethodID (class_ref, "getCredentials", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCredentials), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		IntPtr id_clearAll;
		public unsafe void ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccount_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string p0)
		{
			if (id_getAccount_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccount_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.GetAccountsFilteredBy (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccountsFilteredBy (string p0, string p1, string p2)
		{
			if (id_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccountsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountsFilteredBy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCredential (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCredential_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.Credential GetCredential (string p0)
		{
			if (id_getCredential_Ljava_lang_String_ == IntPtr.Zero)
				id_getCredential_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCredential", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/Credential;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCredential_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		IntPtr id_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> GetCredentialsFilteredBy (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType p2, string p3, string p4, string p5, string p6)
		{
			if (id_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCredentialsFilteredBy", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/CredentialType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			var __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCredentialsFilteredBy_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_CredentialType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		public unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0)
		{
			if (id_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == IntPtr.Zero)
				id_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNIEnv.GetMethodID (class_ref, "removeAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_, __args);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCredential (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
		public unsafe bool RemoveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0)
		{
			if (id_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ == IntPtr.Zero)
				id_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNIEnv.GetMethodID (class_ref, "removeCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeCredential_Lcom_microsoft_identity_common_internal_dto_Credential_, __args);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveAccount (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		public unsafe void SaveAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0)
		{
			if (id_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == IntPtr.Zero)
				id_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNIEnv.GetMethodID (class_ref, "saveAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_, __args);
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveCredential (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_;
		public unsafe void SaveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0)
		{
			if (id_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ == IntPtr.Zero)
				id_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNIEnv.GetMethodID (class_ref, "saveCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_, __args);
		}

	}
}
