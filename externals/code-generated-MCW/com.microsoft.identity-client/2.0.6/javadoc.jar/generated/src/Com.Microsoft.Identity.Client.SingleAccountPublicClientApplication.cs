using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/SingleAccountPublicClientApplication", DoNotGenerateAcw=true)]
	public partial class SingleAccountPublicClientApplication : global::Com.Microsoft.Identity.Client.PublicClientApplication, global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/field[@name='CURRENT_ACCOUNT_SHARED_PREFERENCE_KEY']"
		[Register ("CURRENT_ACCOUNT_SHARED_PREFERENCE_KEY")]
		public const string CurrentAccountSharedPreferenceKey = (string) "com.microsoft.identity.client.single_account_credential_cache.current_account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/field[@name='SINGLE_ACCOUNT_CREDENTIAL_SHARED_PREFERENCES']"
		[Register ("SINGLE_ACCOUNT_CREDENTIAL_SHARED_PREFERENCES")]
		public const string SingleAccountCredentialSharedPreferences = (string) "com.microsoft.identity.client.single_account_credential_cache";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/SingleAccountPublicClientApplication", typeof (SingleAccountPublicClientApplication));

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

		protected SingleAccountPublicClientApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/constructor[@name='SingleAccountPublicClientApplication' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)V", "")]
		protected unsafe SingleAccountPublicClientApplication (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration config) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCurrentAccount;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccountHandler ()
		{
			if (cb_getCurrentAccount == null)
				cb_getCurrentAccount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentAccount);
			return cb_getCurrentAccount;
		}

		static IntPtr n_GetCurrentAccount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentAccount);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.ICurrentAccountResult CurrentAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='getCurrentAccount' and count(parameter)=0]"
			[Register ("getCurrentAccount", "()Lcom/microsoft/identity/client/ICurrentAccountResult;", "GetGetCurrentAccountHandler")]
			get {
				const string __id = "getCurrentAccount.()Lcom/microsoft/identity/client/ICurrentAccountResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ICurrentAccountResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AcquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AcquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes, IntPtr native_authority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (scopes, authority));
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='acquireTokenSilent' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("acquireTokenSilent", "([Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;", "GetAcquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] scopes, string authority)
		{
			const string __id = "acquireTokenSilent.([Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue (native_authority);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				JNIEnv.DeleteLocalRef (native_authority);
				global::System.GC.KeepAlive (scopes);
			}
		}

		static Delegate cb_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler ()
		{
			if (cb_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == null)
				cb_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_);
			return cb_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		}

		static void n_AcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes, IntPtr native_authority, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (scopes, authority, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("acquireTokenSilentAsync", "([Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V", "GetAcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler")]
		public virtual unsafe void AcquireTokenSilentAsync (string[] scopes, string authority, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback @callback)
		{
			const string __id = "acquireTokenSilentAsync.([Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue (native_authority);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				JNIEnv.DeleteLocalRef (native_authority);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_Handler ()
		{
			if (cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ == null)
				cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_);
			return cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_;
		}

		static void n_GetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetCurrentAccountAsync (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='getCurrentAccountAsync' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication.CurrentAccountCallback']]"
		[Register ("getCurrentAccountAsync", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback;)V", "GetGetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_Handler")]
		public virtual unsafe void GetCurrentAccountAsync (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback @callback)
		{
			const string __id = "getCurrentAccountAsync.(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler ()
		{
			if (cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == null)
				cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_SignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_);
			return cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		}

		static void n_SignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_loginHint, IntPtr native_scopes, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignIn (activity, loginHint, scopes, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='signIn' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler")]
		public virtual unsafe void SignIn (global::Android.App.Activity activity, string loginHint, string[] scopes, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			const string __id = "signIn.(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V";
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_loginHint);
				__args [2] = new JniArgumentValue (native_scopes);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_loginHint);
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler ()
		{
			if (cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ == null)
				cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_SignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_);
			return cb_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
		}

		static void n_SignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_loginHint, IntPtr native_scopes, IntPtr native_prompt, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var prompt = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (native_prompt, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignIn (activity, loginHint, scopes, prompt, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='signIn' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.microsoft.identity.client.Prompt'] and parameter[5][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler")]
		public virtual unsafe void SignIn (global::Android.App.Activity activity, string loginHint, string[] scopes, global::Com.Microsoft.Identity.Client.Prompt prompt, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			const string __id = "signIn.(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V";
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_loginHint);
				__args [2] = new JniArgumentValue (native_scopes);
				__args [3] = new JniArgumentValue ((prompt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prompt).Handle);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_loginHint);
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (prompt);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetSignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler ()
		{
			if (cb_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ == null)
				cb_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_SignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_);
			return cb_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
		}

		static void n_SignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_scopes, IntPtr native_prompt, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var prompt = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (native_prompt, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignInAgain (activity, scopes, prompt, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='signInAgain' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.microsoft.identity.client.Prompt'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signInAgain", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler")]
		public virtual unsafe void SignInAgain (global::Android.App.Activity activity, string[] scopes, global::Com.Microsoft.Identity.Client.Prompt prompt, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			const string __id = "signInAgain.(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_scopes);
				__args [2] = new JniArgumentValue ((prompt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prompt).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (prompt);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_signOut;
#pragma warning disable 0169
		static Delegate GetSignOutHandler ()
		{
			if (cb_signOut == null)
				cb_signOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SignOut);
			return cb_signOut;
		}

		static bool n_SignOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SignOut ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='signOut' and count(parameter)=0]"
		[Register ("signOut", "()Z", "GetSignOutHandler")]
		public virtual unsafe bool SignOut ()
		{
			const string __id = "signOut.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_;
#pragma warning disable 0169
		static Delegate GetSignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_Handler ()
		{
			if (cb_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ == null)
				cb_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_);
			return cb_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_;
		}

		static void n_SignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.SingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignOut (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='SingleAccountPublicClientApplication']/method[@name='signOut' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication.SignOutCallback']]"
		[Register ("signOut", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback;)V", "GetSignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_Handler")]
		public virtual unsafe void SignOut (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback @callback)
		{
			const string __id = "signOut.(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
