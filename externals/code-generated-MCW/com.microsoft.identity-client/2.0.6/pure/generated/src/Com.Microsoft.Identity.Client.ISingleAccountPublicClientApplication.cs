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
		void OnAccountChanged (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.IAccount p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.CurrentAccountCallback']/method[@name='onAccountLoaded' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAccount']]"
		[Register ("onAccountLoaded", "(Lcom/microsoft/identity/client/IAccount;)V", "GetOnAccountLoaded_Lcom_microsoft_identity_client_IAccount_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnAccountLoaded (global::Com.Microsoft.Identity.Client.IAccount p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.CurrentAccountCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0);

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

		static void n_OnAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAccountChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_;
		public unsafe void OnAccountChanged (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.IAccount p1)
		{
			if (id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ == IntPtr.Zero)
				id_onAccountChanged_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IAccount_ = JNIEnv.GetMethodID (class_ref, "onAccountChanged", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IAccount;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
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

		static void n_OnAccountLoaded_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccountLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_;
		public unsafe void OnAccountLoaded (global::Com.Microsoft.Identity.Client.IAccount p0)
		{
			if (id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_ == IntPtr.Zero)
				id_onAccountLoaded_Lcom_microsoft_identity_client_IAccount_ = JNIEnv.GetMethodID (class_ref, "onAccountLoaded", "(Lcom/microsoft/identity/client/IAccount;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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

		static void n_OnError_Lcom_microsoft_identity_client_exception_MsalException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		public unsafe void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0)
		{
			if (id_onError_Lcom_microsoft_identity_client_exception_MsalException_ == IntPtr.Zero)
				id_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_microsoft_identity_client_exception_MsalException_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.SignOutCallback']"
	[Register ("com/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback", "", "Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallbackInvoker")]
	public partial interface ISingleAccountPublicClientApplicationSignOutCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication.SignOutCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0);

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

		static void n_OnError_Lcom_microsoft_identity_client_exception_MsalException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		public unsafe void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0)
		{
			if (id_onError_Lcom_microsoft_identity_client_exception_MsalException_ == IntPtr.Zero)
				id_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
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
		global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("acquireTokenSilentAsync", "([Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V", "GetAcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireTokenSilentAsync (string[] p0, string p1, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='getCurrentAccountAsync' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication.CurrentAccountCallback']]"
		[Register ("getCurrentAccountAsync", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback;)V", "GetGetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void GetCurrentAccountAsync (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signIn' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignIn (global::Android.App.Activity p0, string p1, string[] p2, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signIn' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.microsoft.identity.client.Prompt'] and parameter[5][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignIn (global::Android.App.Activity p0, string p1, string[] p2, global::Com.Microsoft.Identity.Client.Prompt p3, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signInAgain' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.microsoft.identity.client.Prompt'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("signInAgain", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetSignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignInAgain (global::Android.App.Activity p0, string[] p1, global::Com.Microsoft.Identity.Client.Prompt p2, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signOut' and count(parameter)=0]"
		[Register ("signOut", "()Z", "GetSignOutHandler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		bool SignOut ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ISingleAccountPublicClientApplication']/method[@name='signOut' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication.SignOutCallback']]"
		[Register ("signOut", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback;)V", "GetSignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_Handler:Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void SignOut (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback p0);

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

		static IntPtr n_AcquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] p0, string p1)
		{
			if (id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilent", "([Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilent_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
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

		static void n_AcquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		public unsafe void AcquireTokenSilentAsync (string[] p0, string p1, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback p2)
		{
			if (id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == IntPtr.Zero)
				id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilentAsync", "([Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilentAsync_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_Handler ()
		{
			if (cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ == null)
				cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_);
			return cb_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_;
		}

		static void n_GetCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCurrentAccountAsync (p0);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_;
		public unsafe void GetCurrentAccountAsync (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationCurrentAccountCallback p0)
		{
			if (id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ == IntPtr.Zero)
				id_getCurrentAccountAsync_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_CurrentAccountCallback_ = JNIEnv.GetMethodID (class_ref, "getCurrentAccountAsync", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$CurrentAccountCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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

		static void n_SignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p3 = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SignIn (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void SignIn (global::Android.App.Activity p0, string p1, string[] p2, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p3)
		{
			if (id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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

		static void n_SignIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SignIn (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void SignIn (global::Android.App.Activity p0, string p1, string[] p2, global::Com.Microsoft.Identity.Client.Prompt p3, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p4)
		{
			if (id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "signIn", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signIn_Landroid_app_Activity_Ljava_lang_String_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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

		static void n_SignInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SignInAgain (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void SignInAgain (global::Android.App.Activity p0, string[] p1, global::Com.Microsoft.Identity.Client.Prompt p2, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p3)
		{
			if (id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "signInAgain", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/Prompt;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signInAgain_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_Prompt_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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

		static void n_SignOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SignOut (p0);
		}
#pragma warning restore 0169

		IntPtr id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_;
		public unsafe void SignOut (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplicationSignOutCallback p0)
		{
			if (id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ == IntPtr.Zero)
				id_signOut_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_SignOutCallback_ = JNIEnv.GetMethodID (class_ref, "signOut", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication$SignOutCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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

		static void n_AcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p2 = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void AcquireToken (global::Android.App.Activity p0, string[] p1, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p2)
		{
			if (id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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

		static void n_AcquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_;
		public unsafe void AcquireToken (global::Com.Microsoft.Identity.Client.AcquireTokenParameters p0)
		{
			if (id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ == IntPtr.Zero)
				id_acquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_ = JNIEnv.GetMethodID (class_ref, "acquireToken", "(Lcom/microsoft/identity/client/AcquireTokenParameters;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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

		static IntPtr n_AcquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		public unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters p0)
		{
			if (id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == IntPtr.Zero)
				id_acquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilent", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/client/IAuthenticationResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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

		static void n_AcquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (p0);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		public unsafe void AcquireTokenSilentAsync (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters p0)
		{
			if (id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == IntPtr.Zero)
				id_acquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilentAsync", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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

		static void n_AcquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenWithDeviceCode (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_;
		public unsafe void AcquireTokenWithDeviceCode (string[] p0, global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback p1)
		{
			if (id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ == IntPtr.Zero)
				id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_ = JNIEnv.GetMethodID (class_ref, "acquireTokenWithDeviceCode", "([Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
