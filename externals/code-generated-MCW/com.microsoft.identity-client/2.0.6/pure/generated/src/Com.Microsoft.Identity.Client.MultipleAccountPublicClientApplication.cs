using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/MultipleAccountPublicClientApplication", DoNotGenerateAcw=true)]
	public partial class MultipleAccountPublicClientApplication : global::Com.Microsoft.Identity.Client.PublicClientApplication, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/MultipleAccountPublicClientApplication", typeof (MultipleAccountPublicClientApplication));

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

		protected MultipleAccountPublicClientApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/constructor[@name='MultipleAccountPublicClientApplication' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)V", "")]
		protected unsafe MultipleAccountPublicClientApplication (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration config) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (config);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.IAccount>.ToLocalJniHandle (__this.Accounts);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.IAccount> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler")]
			get {
				const string __id = "getAccounts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.IAccount>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetAcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler ()
		{
			if (cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == null)
				cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_AcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_);
			return cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		}

		static void n_AcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_scopes, IntPtr native_loginHint, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (activity, scopes, loginHint, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='acquireToken' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetAcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler")]
		public virtual unsafe void AcquireToken (global::Android.App.Activity activity, string[] scopes, string loginHint, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			const string __id = "acquireToken.(Landroid/app/Activity;[Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_scopes);
				__args [2] = new JniArgumentValue (native_loginHint);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				JNIEnv.DeleteLocalRef (native_loginHint);
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Handler ()
		{
			if (cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ == null)
				cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_AcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_);
			return cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_;
		}

		static IntPtr n_AcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes, IntPtr native_account, IntPtr native_authority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (scopes, account, authority));
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='acquireTokenSilent' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IAccount'] and parameter[3][@type='java.lang.String']]"
		[Register ("acquireTokenSilent", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;", "GetAcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] scopes, global::Com.Microsoft.Identity.Client.IAccount account, string authority)
		{
			const string __id = "acquireTokenSilent.([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				__args [2] = new JniArgumentValue (native_authority);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				JNIEnv.DeleteLocalRef (native_authority);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (account);
			}
		}

		static Delegate cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler ()
		{
			if (cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == null)
				cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_AcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_);
			return cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		}

		static void n_AcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes, IntPtr native_account, IntPtr native_authority, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (scopes, account, authority, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IAccount'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("acquireTokenSilentAsync", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V", "GetAcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler")]
		public virtual unsafe void AcquireTokenSilentAsync (string[] scopes, global::Com.Microsoft.Identity.Client.IAccount account, string authority, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback @callback)
		{
			const string __id = "acquireTokenSilentAsync.([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				__args [2] = new JniArgumentValue (native_authority);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				JNIEnv.DeleteLocalRef (native_authority);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (account);
				global::System.GC.KeepAlive (@callback);
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

		static IntPtr n_GetAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/client/IAccount;", "GetGetAccount_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Client.IAccount GetAccount (string identifier)
		{
			const string __id = "getAccount.(Ljava/lang/String;)Lcom/microsoft/identity/client/IAccount;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_;
#pragma warning disable 0169
		static Delegate GetGetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_Handler ()
		{
			if (cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ == null)
				cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_);
			return cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_;
		}

		static void n_GetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAccount (identifier, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='getAccount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.client.IMultipleAccountPublicClientApplication.GetAccountCallback']]"
		[Register ("getAccount", "(Ljava/lang/String;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback;)V", "GetGetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_Handler")]
		public virtual unsafe void GetAccount (string identifier, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback @callback)
		{
			const string __id = "getAccount.(Ljava/lang/String;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback;)V";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identifier);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_Handler ()
		{
			if (cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ == null)
				cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_);
			return cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_;
		}

		static void n_GetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAccounts (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IPublicClientApplication.LoadAccountsCallback']]"
		[Register ("getAccounts", "(Lcom/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback;)V", "GetGetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_Handler")]
		public virtual unsafe void GetAccounts (global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback @callback)
		{
			const string __id = "getAccounts.(Lcom/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_removeAccount_Lcom_microsoft_identity_client_IAccount_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_client_IAccount_ == null)
				cb_removeAccount_Lcom_microsoft_identity_client_IAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_);
			return cb_removeAccount_Lcom_microsoft_identity_client_IAccount_;
		}

		static bool n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (account);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAccount']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/client/IAccount;)Z", "GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Handler")]
		public virtual unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Client.IAccount account)
		{
			const string __id = "removeAccount.(Lcom/microsoft/identity/client/IAccount;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (account);
			}
		}

		static Delegate cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ == null)
				cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_);
			return cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_;
		}

		static void n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccount (account, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultipleAccountPublicClientApplication']/method[@name='removeAccount' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.IMultipleAccountPublicClientApplication.RemoveAccountCallback']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback;)V", "GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_Handler")]
		public virtual unsafe void RemoveAccount (global::Com.Microsoft.Identity.Client.IAccount account, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback @callback)
		{
			const string __id = "removeAccount.(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (account);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
