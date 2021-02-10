using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.CurrentAccountCallback']"
	[Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback", "", "Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker")]
	public partial interface ISingleAccountPublicClientApplicationCurrentAccountCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.CurrentAccountCallback']/method[@name='onAccountChanged' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.IAccount']]"
		[Register ("onAccountChanged", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IAccount;)V", "GetOnAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnAccountChanged (global::Com.Microsoft.Identity.Client.IAccount priorAccount, global::Com.Microsoft.Identity.Client.IAccount currentAccount);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.CurrentAccountCallback']/method[@name='onAccountLoaded' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAccount']]"
		[Register ("onAccountLoaded", "(Lcom/microsoft/identity/client/IAccount;)V", "GetOnAccountLoaded_Lcom_microsoft_identity_client_IAccount_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnAccountLoaded (global::Com.Microsoft.Identity.Client.IAccount activeAccount);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.CurrentAccountCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback", DoNotGenerateAcw=true)]
	internal partial class ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker : global::Java.Lang.Object, ISingleAccountPublicClientApplicationCurrentAccountCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback", typeof (ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker));

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

		public static ISingleAccountPublicClientApplicationCurrentAccountCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleAccountPublicClientApplicationCurrentAccountCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.ISingleAccountPublicClientApplication.CurrentAccountCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_;
#pragma warning disable 0169
		static Delegate GetOnAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_Handler ()
		{
			if (cb_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ == null)
				cb_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_);
			return cb_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_;
		}

		static void n_OnAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_priorAccount, IntPtr native_currentAccount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var priorAccount = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_priorAccount, JniHandleOwnership.DoNotTransfer);
			var currentAccount = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_currentAccount, JniHandleOwnership.DoNotTransfer);
			__this.OnAccountChanged (priorAccount, currentAccount);
		}
#pragma warning restore 0169

		IntPtr id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_;
		public unsafe void OnAccountChanged (global::Com.Microsoft.Identity.Client.IAccount priorAccount, global::Com.Microsoft.Identity.Client.IAccount currentAccount)
		{
			if (id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ == IntPtr.Zero)
				id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ = JNIEnv.GetMethodID (class_ref, "onAccountChanged", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IAccount;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((priorAccount == null) ? IntPtr.Zero : ((global::Java.Lang.Object) priorAccount).Handle);
			__args [1] = new JValue ((currentAccount == null) ? IntPtr.Zero : ((global::Java.Lang.Object) currentAccount).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_, __args);
		}

		static Delegate cb_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_;
#pragma warning disable 0169
		static Delegate GetOnAccountLoaded_Lcom_microsoft_identity_client_IAccount_Handler ()
		{
			if (cb_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_ == null)
				cb_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAccountLoaded_Lcom_microsoft_identity_client_IAccount_);
			return cb_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_;
		}

		static void n_OnAccountLoaded_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activeAccount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activeAccount = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_activeAccount, JniHandleOwnership.DoNotTransfer);
			__this.OnAccountLoaded (activeAccount);
		}
#pragma warning restore 0169

		IntPtr id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_;
		public unsafe void OnAccountLoaded (global::Com.Microsoft.Identity.Client.IAccount activeAccount)
		{
			if (id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_ == IntPtr.Zero)
				id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_ = JNIEnv.GetMethodID (class_ref, "onAccountLoaded", "(Lcom/microsoft/identity/client/IAccount;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((activeAccount == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activeAccount).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_, __args);
		}

		static Delegate cb_onError_Lcom_microsoft_identity_client_exception_MsalException_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler ()
		{
			if (cb_onError_Lcom_microsoft_identity_client_exception_MsalException_ == null)
				cb_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_microsoft_identity_client_exception_MsalException_);
			return cb_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		}

		static void n_OnError_Lcom_microsoft_identity_client_exception_MsalException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnError (exception);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		public unsafe void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception)
		{
			if (id_onError_Lcom_microsoft_identity_client_exception_MsalException_ == IntPtr.Zero)
				id_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_microsoft_identity_client_exception_MsalException_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.SignOutCallback']"
	[Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback", "", "Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallbackInvoker")]
	public partial interface ISingleAccountPublicClientApplicationSignOutCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.SignOutCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.SignOutCallback']/method[@name='onSignOut' and count(parameter)=0]"
		[Register ("onSignOut", "()V", "GetOnSignOutHandler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallbackInvoker, Microsoft.Identity.Client")]
		void OnSignOut ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback", DoNotGenerateAcw=true)]
	internal partial class ISingleAccountPublicClientApplicationSignOutCallbackInvoker : global::Java.Lang.Object, ISingleAccountPublicClientApplicationSignOutCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback", typeof (ISingleAccountPublicClientApplicationSignOutCallbackInvoker));

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

		public static ISingleAccountPublicClientApplicationSignOutCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleAccountPublicClientApplicationSignOutCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.ISingleAccountPublicClientApplication.SignOutCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleAccountPublicClientApplicationSignOutCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_microsoft_identity_client_exception_MsalException_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler ()
		{
			if (cb_onError_Lcom_microsoft_identity_client_exception_MsalException_ == null)
				cb_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_microsoft_identity_client_exception_MsalException_);
			return cb_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		}

		static void n_OnError_Lcom_microsoft_identity_client_exception_MsalException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnError (exception);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		public unsafe void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception)
		{
			if (id_onError_Lcom_microsoft_identity_client_exception_MsalException_ == IntPtr.Zero)
				id_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_microsoft_identity_client_exception_MsalException_, __args);
		}

		static Delegate cb_onSignOut;
#pragma warning disable 0169
		static Delegate GetOnSignOutHandler ()
		{
			if (cb_onSignOut == null)
				cb_onSignOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSignOut);
			return cb_onSignOut;
		}

		static void n_OnSignOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSignOut ();
		}
#pragma warning restore 0169

		IntPtr id_onSignOut;
		public unsafe void OnSignOut ()
		{
			if (id_onSignOut == IntPtr.Zero)
				id_onSignOut = JNIEnv.GetMethodID (class_ref, "onSignOut", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSignOut);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']"
	[Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication", "", "Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker")]
	public partial interface ISingleAccountPublicClientApplication : global::Com.Microsoft.Identity.Client.IPublicClientApplication {
		global::Com.Microsoft.Identity.Client.ICurrentAccountResult CurrentAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='getCurrentAccount' and count(parameter)=0]"
			[Register ("getCurrentAccount", "()Lcom/microsoft/identity/client/ICurrentAccountResult;", "GetGetCurrentAccountHandler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='acquireTokenSilent' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("acquireTokenSilent", "([Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;", "GetAcquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] scopes, string authority);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("acquireTokenSilentAsync", "([Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V", "GetAcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireTokenSilentAsync (string[] scopes, string authority, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='getCurrentAccountAsync' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication.CurrentAccountCallback']]"
		[Register ("getCurrentAccountAsync", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback;)V", "GetGetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void GetCurrentAccountAsync (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signIn' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignIn (global::Android.App.Activity activity, string loginHint, string[] scopes, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signIn' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.microsoft.identity.client.Prompt'] and parameter[5][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignIn (global::Android.App.Activity activity, string loginHint, string[] scopes, global::Com.Microsoft.Identity.Client.Prompt prompt, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signInAgain' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.microsoft.identity.client.Prompt'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signInAgain", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignInAgain (global::Android.App.Activity activity, string[] scopes, global::Com.Microsoft.Identity.Client.Prompt prompt, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signOut' and count(parameter)=0]"
		[Register ("signOut", "()Z", "GetSignOutHandler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		bool SignOut ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signOut' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication.SignOutCallback']]"
		[Register ("signOut", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback;)V", "GetSignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignOut (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback @callback);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication", DoNotGenerateAcw=true)]
	internal partial class ISingleAccountPublicClientApplicationInvoker : global::Java.Lang.Object, ISingleAccountPublicClientApplication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/ISingleAccountPublicClientApplication", typeof (ISingleAccountPublicClientApplicationInvoker));

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

		public static ISingleAccountPublicClientApplication GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleAccountPublicClientApplication> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.ISingleAccountPublicClientApplication"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleAccountPublicClientApplicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentAccount);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAccount;
		public unsafe global::Com.Microsoft.Identity.Client.ICurrentAccountResult CurrentAccount {
			get {
				if (id_getCurrentAccount == IntPtr.Zero)
					id_getCurrentAccount = JNIEnv.GetMethodID (class_ref, "getCurrentAccount", "()Lcom/microsoft/identity/client/ICurrentAccountResult;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ICurrentAccountResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAccount), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (scopes, authority));
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] scopes, string authority)
		{
			if (id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilent", "([Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;");
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_scopes);
			__args [1] = new JValue (native_authority);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
			}
			JNIEnv.DeleteLocalRef (native_authority);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (scopes, authority, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		public unsafe void AcquireTokenSilentAsync (string[] scopes, string authority, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback @callback)
		{
			if (id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == IntPtr.Zero)
				id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilentAsync", "([Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V");
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_scopes);
			__args [1] = new JValue (native_authority);
			__args [2] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_, __args);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
			}
			JNIEnv.DeleteLocalRef (native_authority);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetCurrentAccountAsync (@callback);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_;
		public unsafe void GetCurrentAccountAsync (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback @callback)
		{
			if (id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ == IntPtr.Zero)
				id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ = JNIEnv.GetMethodID (class_ref, "getCurrentAccountAsync", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignIn (activity, loginHint, scopes, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		IntPtr id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void SignIn (global::Android.App.Activity activity, string loginHint, string[] scopes, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			if (id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
			__args [1] = new JValue (native_loginHint);
			__args [2] = new JValue (native_scopes);
			__args [3] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			JNIEnv.DeleteLocalRef (native_loginHint);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		IntPtr id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void SignIn (global::Android.App.Activity activity, string loginHint, string[] scopes, global::Com.Microsoft.Identity.Client.Prompt prompt, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			if (id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
			__args [1] = new JValue (native_loginHint);
			__args [2] = new JValue (native_scopes);
			__args [3] = new JValue ((prompt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prompt).Handle);
			__args [4] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			JNIEnv.DeleteLocalRef (native_loginHint);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var prompt = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (native_prompt, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignInAgain (activity, scopes, prompt, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		IntPtr id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void SignInAgain (global::Android.App.Activity activity, string[] scopes, global::Com.Microsoft.Identity.Client.Prompt prompt, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			if (id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "signInAgain", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
			__args [1] = new JValue (native_scopes);
			__args [2] = new JValue ((prompt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prompt).Handle);
			__args [3] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SignOut ();
		}
#pragma warning restore 0169

		IntPtr id_signOut;
		public unsafe bool SignOut ()
		{
			if (id_signOut == IntPtr.Zero)
				id_signOut = JNIEnv.GetMethodID (class_ref, "signOut", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_signOut);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SignOut (@callback);
		}
#pragma warning restore 0169

		IntPtr id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_;
		public unsafe void SignOut (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback @callback)
		{
			if (id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ == IntPtr.Zero)
				id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ = JNIEnv.GetMethodID (class_ref, "signOut", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_, __args);
		}

		static Delegate cb_getConfiguration;
#pragma warning disable 0169
		static Delegate GetGetConfigurationHandler ()
		{
			if (cb_getConfiguration == null)
				cb_getConfiguration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfiguration);
			return cb_getConfiguration;
		}

		static IntPtr n_GetConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		IntPtr id_getConfiguration;
		public unsafe global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration Configuration {
			get {
				if (id_getConfiguration == IntPtr.Zero)
					id_getConfiguration = JNIEnv.GetMethodID (class_ref, "getConfiguration", "()Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfiguration), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isSharedDevice;
#pragma warning disable 0169
		static Delegate GetIsSharedDeviceHandler ()
		{
			if (cb_isSharedDevice == null)
				cb_isSharedDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSharedDevice);
			return cb_isSharedDevice;
		}

		static bool n_IsSharedDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSharedDevice;
		}
#pragma warning restore 0169

		IntPtr id_isSharedDevice;
		public unsafe bool IsSharedDevice {
			get {
				if (id_isSharedDevice == IntPtr.Zero)
					id_isSharedDevice = JNIEnv.GetMethodID (class_ref, "isSharedDevice", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSharedDevice);
			}
		}

		static Delegate cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetAcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler ()
		{
			if (cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == null)
				cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_);
			return cb_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		}

		static void n_AcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_scopes, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (activity, scopes, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		IntPtr id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void AcquireToken (global::Android.App.Activity activity, string[] scopes, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			if (id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
			__args [1] = new JValue (native_scopes);
			__args [2] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
			}
		}

		static Delegate cb_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_Handler ()
		{
			if (cb_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ == null)
				cb_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AcquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_);
			return cb_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_;
		}

		static void n_AcquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_acquireTokenParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acquireTokenParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (native_acquireTokenParameters, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (acquireTokenParameters);
		}
#pragma warning restore 0169

		IntPtr id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_;
		public unsafe void AcquireToken (global::Com.Microsoft.Identity.Client.AcquireTokenParameters acquireTokenParameters)
		{
			if (id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ == IntPtr.Zero)
				id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ = JNIEnv.GetMethodID (class_ref, "acquireToken", "(Lcom/microsoft/identity/client/AcquireTokenParameters;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((acquireTokenParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenParameters).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_, __args);
		}

		static Delegate cb_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler ()
		{
			if (cb_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == null)
				cb_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_);
			return cb_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		}

		static IntPtr n_AcquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_acquireTokenSilentParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acquireTokenSilentParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_acquireTokenSilentParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (acquireTokenSilentParameters));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		public unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters acquireTokenSilentParameters)
		{
			if (id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == IntPtr.Zero)
				id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilent", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/client/IAuthenticationResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((acquireTokenSilentParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenSilentParameters).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler ()
		{
			if (cb_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == null)
				cb_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AcquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_);
			return cb_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		}

		static void n_AcquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_acquireTokenSilentParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acquireTokenSilentParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_acquireTokenSilentParameters, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (acquireTokenSilentParameters);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		public unsafe void AcquireTokenSilentAsync (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters acquireTokenSilentParameters)
		{
			if (id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == IntPtr.Zero)
				id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilentAsync", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((acquireTokenSilentParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenSilentParameters).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_, __args);
		}

		static Delegate cb_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_Handler ()
		{
			if (cb_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ == null)
				cb_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AcquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_);
			return cb_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_;
		}

		static void n_AcquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var @callback = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenWithDeviceCode (scopes, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_;
		public unsafe void AcquireTokenWithDeviceCode (string[] scopes, global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback @callback)
		{
			if (id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ == IntPtr.Zero)
				id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ = JNIEnv.GetMethodID (class_ref, "acquireTokenWithDeviceCode", "([Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback;)V");
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_scopes);
			__args [1] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_, __args);
			if (scopes != null) {
				JNIEnv.CopyArray (native_scopes, scopes);
				JNIEnv.DeleteLocalRef (native_scopes);
			}
		}

		static Delegate cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Handler ()
		{
			if (cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_ == null)
				cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_);
			return cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_;
		}

		static IntPtr n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateSignedHttpRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_;
		public unsafe string GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme p1)
		{
			if (id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_ == IntPtr.Zero)
				id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_ = JNIEnv.GetMethodID (class_ref, "generateSignedHttpRequest", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_Handler ()
		{
			if (cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ == null)
				cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_);
			return cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_;
		}

		static void n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GenerateSignedHttpRequest (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_;
		public unsafe void GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme p1, global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback p2)
		{
			if (id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ == IntPtr.Zero)
				id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ = JNIEnv.GetMethodID (class_ref, "generateSignedHttpRequest", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;Lcom/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_, __args);
		}

	}
}
