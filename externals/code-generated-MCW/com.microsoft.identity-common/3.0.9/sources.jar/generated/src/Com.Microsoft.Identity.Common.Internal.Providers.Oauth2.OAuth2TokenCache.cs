using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy", "U extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest", "V extends com.microsoft.identity.common.internal.providers.oauth2.TokenResponse"})]
	public abstract partial class OAuth2TokenCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache", typeof (OAuth2TokenCache));

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

		protected OAuth2TokenCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/constructor[@name='OAuth2TokenCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe OAuth2TokenCache (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getAllClientIds;
#pragma warning disable 0169
		static Delegate GetGetAllClientIdsHandler ()
		{
			if (cb_getAllClientIds == null)
				cb_getAllClientIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllClientIds);
			return cb_getAllClientIds;
		}

		static IntPtr n_GetAllClientIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllClientIds);
		}
#pragma warning restore 0169

		protected abstract global::System.Collections.Generic.ICollection<string> AllClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAllClientIds' and count(parameter)=0]"
			[Register ("getAllClientIds", "()Ljava/util/Set;", "GetGetAllClientIdsHandler")]
			get; 
		}

		protected unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public abstract void ClearAll ();

		static Delegate cb_getAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccount' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string p0, string p1, string p2, string p3);

		static Delegate cb_getAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountByHomeAccountId (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountByHomeAccountId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountByHomeAccountId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccountByHomeAccountId (string p0, string p1, string p2);

		static Delegate cb_getAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountByLocalAccountId (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountByLocalAccountId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountByLocalAccountId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccountByLocalAccountId (string p0, string p1, string p2);

		static Delegate cb_getAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountWithAggregatedAccountDataByLocalAccountId (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountWithAggregatedAccountDataByLocalAccountId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountWithAggregatedAccountDataByLocalAccountId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetGetAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord GetAccountWithAggregatedAccountDataByLocalAccountId (string p0, string p1, string p2);

		static Delegate cb_getAccounts_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccounts_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccounts_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAccounts_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccounts_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccounts_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.GetAccounts (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccounts' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAccounts", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccounts_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccounts (string p0, string p1);

		static Delegate cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetAccountsWithAggregatedAccountData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountsWithAggregatedAccountData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAccountsWithAggregatedAccountData", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccountsWithAggregatedAccountData (string p0, string p1);

		static Delegate cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetAccountsWithAggregatedAccountData (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountsWithAggregatedAccountData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountsWithAggregatedAccountData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccountsWithAggregatedAccountData (string p0, string p1, string p2);

		static Delegate cb_getAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetGetAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_getAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_getAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_getAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_GetAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.GetAllTenantAccountsForAccountByClientId (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAllTenantAccountsForAccountByClientId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("getAllTenantAccountsForAccountByClientId", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/util/List;", "GetGetAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAllTenantAccountsForAccountByClientId (string p0, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p1);

		static Delegate cb_getIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetGetIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_getIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_getIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_getIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_GetIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord>.ToLocalJniHandle (__this.GetIdTokensForAccountRecord (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getIdTokensForAccountRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("getIdTokensForAccountRecord", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/util/List;", "GetGetIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> GetIdTokensForAccountRecord (string p0, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p1);

		static Delegate cb_load_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler ()
		{
			if (cb_load_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ == null)
				cb_load_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_Load_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_);
			return cb_load_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
		}

		static IntPtr n_Load_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='load' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.AccountRecord'] and parameter[4][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("load", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetLoad_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord Load (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p2, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p3);

		static Delegate cb_loadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
#pragma warning disable 0169
		static Delegate GetLoadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler ()
		{
			if (cb_loadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ == null)
				cb_loadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_LoadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_);
			return cb_loadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_;
		}

		static IntPtr n_LoadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.LoadWithAggregatedAccountData (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='loadWithAggregatedAccountData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.AccountRecord'] and parameter[4][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("loadWithAggregatedAccountData", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Ljava/util/List;", "GetLoadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> LoadWithAggregatedAccountData (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p2, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p3);

		static Delegate cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_RemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_RemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccount (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='removeAccount' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("removeAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/cache/AccountDeletionRecord;", "GetRemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord RemoveAccount (string p0, string p1, string p2, string p3);

		static Delegate cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_Handler ()
		{
			if (cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_ == null)
				cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_RemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_);
			return cb_removeAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_;
		}

		static IntPtr n_RemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccount (p0, p1, p2, p3, p4));
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='removeAccount' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.microsoft.identity.common.internal.dto.CredentialType...']]"
		[Register ("removeAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Lcom/microsoft/identity/common/internal/dto/CredentialType;)Lcom/microsoft/identity/common/internal/cache/AccountDeletionRecord;", "GetRemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord RemoveAccount (string p0, string p1, string p2, string p3, params global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType[] p4);

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCredential (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='removeCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("removeCredential", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Z", "GetRemoveCredential_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public abstract bool RemoveCredential (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

		static Delegate cb_save_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_;
#pragma warning disable 0169
		static Delegate GetSave_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler ()
		{
			if (cb_save_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ == null)
				cb_save_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Save_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_);
			return cb_save_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_;
		}

		static IntPtr n_Save_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Save (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='save' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.IdTokenRecord']]"
		[Register ("save", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetSave_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord Save (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0, global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord p1);

		static Delegate cb_save_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetSave_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_save_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_save_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Save_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_save_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_Save_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Save (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='save' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("save", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetSave_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord Save (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

		static Delegate cb_saveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetSaveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_saveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_saveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_SaveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_saveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_SaveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.SaveAndLoadAggregatedAccountData (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='saveAndLoadAggregatedAccountData' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("saveAndLoadAggregatedAccountData", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Ljava/util/List;", "GetSaveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> SaveAndLoadAggregatedAccountData (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache", DoNotGenerateAcw=true)]
	internal partial class OAuth2TokenCacheInvoker : OAuth2TokenCache {
		public OAuth2TokenCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache", typeof (OAuth2TokenCacheInvoker));

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

		protected override unsafe global::System.Collections.Generic.ICollection<string> AllClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAllClientIds' and count(parameter)=0]"
			[Register ("getAllClientIds", "()Ljava/util/Set;", "GetGetAllClientIdsHandler")]
			get {
				const string __id = "getAllClientIds.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public override unsafe void ClearAll ()
		{
			const string __id = "clearAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccount' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccount (string p0, string p1, string p2, string p3)
		{
			const string __id = "getAccount.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountByHomeAccountId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountByHomeAccountId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccountByHomeAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccountByHomeAccountId (string p0, string p1, string p2)
		{
			const string __id = "getAccountByHomeAccountId.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountByLocalAccountId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountByLocalAccountId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccountByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord GetAccountByLocalAccountId (string p0, string p1, string p2)
		{
			const string __id = "getAccountByLocalAccountId.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountWithAggregatedAccountDataByLocalAccountId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountWithAggregatedAccountDataByLocalAccountId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetGetAccountWithAggregatedAccountDataByLocalAccountId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord GetAccountWithAggregatedAccountDataByLocalAccountId (string p0, string p1, string p2)
		{
			const string __id = "getAccountWithAggregatedAccountDataByLocalAccountId.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccounts' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAccounts", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccounts_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAccounts (string p0, string p1)
		{
			const string __id = "getAccounts.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountsWithAggregatedAccountData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAccountsWithAggregatedAccountData", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccountsWithAggregatedAccountData (string p0, string p1)
		{
			const string __id = "getAccountsWithAggregatedAccountData.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAccountsWithAggregatedAccountData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccountsWithAggregatedAccountData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetAccountsWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccountsWithAggregatedAccountData (string p0, string p1, string p2)
		{
			const string __id = "getAccountsWithAggregatedAccountData.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getAllTenantAccountsForAccountByClientId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("getAllTenantAccountsForAccountByClientId", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/util/List;", "GetGetAllTenantAccountsForAccountByClientId_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> GetAllTenantAccountsForAccountByClientId (string p0, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p1)
		{
			const string __id = "getAllTenantAccountsForAccountByClientId.(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='getIdTokensForAccountRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("getIdTokensForAccountRecord", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/util/List;", "GetGetIdTokensForAccountRecord_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> GetIdTokensForAccountRecord (string p0, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p1)
		{
			const string __id = "getIdTokensForAccountRecord.(Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='load' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.AccountRecord'] and parameter[4][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("load", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetLoad_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord Load (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p2, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p3)
		{
			const string __id = "load.(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='loadWithAggregatedAccountData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.AccountRecord'] and parameter[4][@type='com.microsoft.identity.common.internal.authscheme.AbstractAuthenticationScheme']]"
		[Register ("loadWithAggregatedAccountData", "(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Ljava/util/List;", "GetLoadWithAggregatedAccountData_Ljava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_authscheme_AbstractAuthenticationScheme_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> LoadWithAggregatedAccountData (string p0, string p1, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p2, global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme p3)
		{
			const string __id = "loadWithAggregatedAccountData.(Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='removeAccount' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("removeAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/cache/AccountDeletionRecord;", "GetRemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord RemoveAccount (string p0, string p1, string p2, string p3)
		{
			const string __id = "removeAccount.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/cache/AccountDeletionRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='removeAccount' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.microsoft.identity.common.internal.dto.CredentialType...']]"
		[Register ("removeAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Lcom/microsoft/identity/common/internal/dto/CredentialType;)Lcom/microsoft/identity/common/internal/cache/AccountDeletionRecord;", "GetRemoveAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLcom_microsoft_identity_common_internal_dto_CredentialType_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord RemoveAccount (string p0, string p1, string p2, string p3, params global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType[] p4)
		{
			const string __id = "removeAccount.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Lcom/microsoft/identity/common/internal/dto/CredentialType;)Lcom/microsoft/identity/common/internal/cache/AccountDeletionRecord;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='removeCredential' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='save' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.IdTokenRecord']]"
		[Register ("save", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetSave_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord Save (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0, global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord p1)
		{
			const string __id = "save.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='save' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("save", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetSave_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord Save (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			const string __id = "save.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/cache/ICacheRecord;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OAuth2TokenCache']/method[@name='saveAndLoadAggregatedAccountData' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("saveAndLoadAggregatedAccountData", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Ljava/util/List;", "GetSaveAndLoadAggregatedAccountData_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> SaveAndLoadAggregatedAccountData (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			const string __id = "saveAndLoadAggregatedAccountData.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
