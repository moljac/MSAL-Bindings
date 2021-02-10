using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication.GetAccountCallback']"
	[Register ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback", "", "Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallbackInvoker")]
	public partial interface IMultipleAccountPublicClientApplicationGetAccountCallback : global::Com.Microsoft.Identity.Common.Internal.Controllers.ITaskCompletedCallbackWithError {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication.GetAccountCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication.GetAccountCallback']/method[@name='onTaskCompleted' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAccount']]"
		[Register ("onTaskCompleted", "(Lcom/microsoft/identity/client/IAccount;)V", "GetOnTaskCompleted_Lcom_microsoft_identity_client_IAccount_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnTaskCompleted (global::Com.Microsoft.Identity.Client.IAccount p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback", DoNotGenerateAcw=true)]
	internal partial class IMultipleAccountPublicClientApplicationGetAccountCallbackInvoker : global::Java.Lang.Object, IMultipleAccountPublicClientApplicationGetAccountCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback", typeof (IMultipleAccountPublicClientApplicationGetAccountCallbackInvoker));

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

		public static IMultipleAccountPublicClientApplicationGetAccountCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMultipleAccountPublicClientApplicationGetAccountCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IMultipleAccountPublicClientApplication.GetAccountCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMultipleAccountPublicClientApplicationGetAccountCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_;
#pragma warning disable 0169
		static Delegate GetOnTaskCompleted_Lcom_microsoft_identity_client_IAccount_Handler ()
		{
			if (cb_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_ == null)
				cb_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTaskCompleted_Lcom_microsoft_identity_client_IAccount_);
			return cb_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_;
		}

		static void n_OnTaskCompleted_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_;
		public unsafe void OnTaskCompleted (global::Com.Microsoft.Identity.Client.IAccount p0)
		{
			if (id_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_ == IntPtr.Zero)
				id_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_ = JNIEnv.GetMethodID (class_ref, "onTaskCompleted", "(Lcom/microsoft/identity/client/IAccount;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskCompleted_Lcom_microsoft_identity_client_IAccount_, __args);
		}

		static Delegate cb_onError_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Object_Handler ()
		{
			if (cb_onError_Ljava_lang_Object_ == null)
				cb_onError_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Object_);
			return cb_onError_Ljava_lang_Object_;
		}

		static void n_OnError_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Object_;
		public unsafe void OnError (global::Java.Lang.Object p0)
		{
			if (id_onError_Ljava_lang_Object_ == IntPtr.Zero)
				id_onError_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Object_, __args);
		}

		static Delegate cb_onTaskCompleted_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnTaskCompleted_Ljava_lang_Object_Handler ()
		{
			if (cb_onTaskCompleted_Ljava_lang_Object_ == null)
				cb_onTaskCompleted_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTaskCompleted_Ljava_lang_Object_);
			return cb_onTaskCompleted_Ljava_lang_Object_;
		}

		static void n_OnTaskCompleted_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTaskCompleted_Ljava_lang_Object_;
		public unsafe void OnTaskCompleted (global::Java.Lang.Object p0)
		{
			if (id_onTaskCompleted_Ljava_lang_Object_ == IntPtr.Zero)
				id_onTaskCompleted_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onTaskCompleted", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskCompleted_Ljava_lang_Object_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication.RemoveAccountCallback']"
	[Register ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback", "", "Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallbackInvoker")]
	public partial interface IMultipleAccountPublicClientApplicationRemoveAccountCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication.RemoveAccountCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication.RemoveAccountCallback']/method[@name='onRemoved' and count(parameter)=0]"
		[Register ("onRemoved", "()V", "GetOnRemovedHandler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallbackInvoker, Microsoft.Identity.Client")]
		void OnRemoved ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback", DoNotGenerateAcw=true)]
	internal partial class IMultipleAccountPublicClientApplicationRemoveAccountCallbackInvoker : global::Java.Lang.Object, IMultipleAccountPublicClientApplicationRemoveAccountCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback", typeof (IMultipleAccountPublicClientApplicationRemoveAccountCallbackInvoker));

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

		public static IMultipleAccountPublicClientApplicationRemoveAccountCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMultipleAccountPublicClientApplicationRemoveAccountCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IMultipleAccountPublicClientApplication.RemoveAccountCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMultipleAccountPublicClientApplicationRemoveAccountCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onRemoved;
#pragma warning disable 0169
		static Delegate GetOnRemovedHandler ()
		{
			if (cb_onRemoved == null)
				cb_onRemoved = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRemoved);
			return cb_onRemoved;
		}

		static void n_OnRemoved (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoved ();
		}
#pragma warning restore 0169

		IntPtr id_onRemoved;
		public unsafe void OnRemoved ()
		{
			if (id_onRemoved == IntPtr.Zero)
				id_onRemoved = JNIEnv.GetMethodID (class_ref, "onRemoved", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoved);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']"
	[Register ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication", "", "Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker")]
	public partial interface IMultipleAccountPublicClientApplication : global::Com.Microsoft.Identity.Client.IPublicClientApplication {
		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.IAccount> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='acquireToken' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetAcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireToken (global::Android.App.Activity p0, string[] p1, string p2, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='acquireTokenSilent' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IAccount'] and parameter[3][@type='java.lang.String']]"
		[Register ("acquireTokenSilent", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;", "GetAcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] p0, global::Com.Microsoft.Identity.Client.IAccount p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IAccount'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("acquireTokenSilentAsync", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V", "GetAcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireTokenSilentAsync (string[] p0, global::Com.Microsoft.Identity.Client.IAccount p1, string p2, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/client/IAccount;", "GetGetAccount_Ljava_lang_String_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		global::Com.Microsoft.Identity.Client.IAccount GetAccount (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='getAccount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.client.IMultipleAccountPublicClientApplication.GetAccountCallback']]"
		[Register ("getAccount", "(Ljava/lang/String;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback;)V", "GetGetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void GetAccount (string p0, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IPublicClientApplication.LoadAccountsCallback']]"
		[Register ("getAccounts", "(Lcom/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback;)V", "GetGetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void GetAccounts (global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAccount']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/client/IAccount;)Z", "GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		bool RemoveAccount (global::Com.Microsoft.Identity.Client.IAccount p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMultipleAccountPublicClientApplication']/method[@name='removeAccount' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.IMultipleAccountPublicClientApplication.RemoveAccountCallback']]"
		[Register ("removeAccount", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback;)V", "GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_Handler:Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void RemoveAccount (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback p1);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication", DoNotGenerateAcw=true)]
	internal partial class IMultipleAccountPublicClientApplicationInvoker : global::Java.Lang.Object, IMultipleAccountPublicClientApplication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMultipleAccountPublicClientApplication", typeof (IMultipleAccountPublicClientApplicationInvoker));

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

		public static IMultipleAccountPublicClientApplication GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMultipleAccountPublicClientApplication> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IMultipleAccountPublicClientApplication"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMultipleAccountPublicClientApplicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.IAccount>.ToLocalJniHandle (__this.Accounts);
		}
#pragma warning restore 0169

		IntPtr id_getAccounts;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.IAccount> Accounts {
			get {
				if (id_getAccounts == IntPtr.Zero)
					id_getAccounts = JNIEnv.GetMethodID (class_ref, "getAccounts", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.IAccount>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccounts), JniHandleOwnership.TransferLocalRef);
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

		static void n_AcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_;
		public unsafe void AcquireToken (global::Android.App.Activity p0, string[] p1, string p2, global::Com.Microsoft.Identity.Client.IAuthenticationCallback p3)
		{
			if (id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ == IntPtr.Zero)
				id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireToken_Landroid_app_Activity_arrayLjava_lang_String_Ljava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Handler ()
		{
			if (cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ == null)
				cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_AcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_);
			return cb_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_;
		}

		static IntPtr n_AcquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (string[] p0, global::Com.Microsoft.Identity.Client.IAccount p1, string p2)
		{
			if (id_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ == IntPtr.Zero)
				id_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilent", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;)Lcom/microsoft/identity/client/IAuthenticationResult;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilent_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler ()
		{
			if (cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == null)
				cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_AcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_);
			return cb_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		}

		static void n_AcquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		public unsafe void AcquireTokenSilentAsync (string[] p0, global::Com.Microsoft.Identity.Client.IAccount p1, string p2, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback p3)
		{
			if (id_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == IntPtr.Zero)
				id_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilentAsync", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilentAsync_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_Lcom_microsoft_identity_client_SilentAuthenticationCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p2);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccount_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Client.IAccount GetAccount (string p0)
		{
			if (id_getAccount_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccount", "(Ljava/lang/String;)Lcom/microsoft/identity/client/IAccount;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccount_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_;
#pragma warning disable 0169
		static Delegate GetGetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_Handler ()
		{
			if (cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ == null)
				cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_);
			return cb_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_;
		}

		static void n_GetAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetAccount (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_;
		public unsafe void GetAccount (string p0, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationGetAccountCallback p1)
		{
			if (id_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ == IntPtr.Zero)
				id_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_ = JNIEnv.GetMethodID (class_ref, "getAccount", "(Ljava/lang/String;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$GetAccountCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAccount_Ljava_lang_String_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_GetAccountCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_Handler ()
		{
			if (cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ == null)
				cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_);
			return cb_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_;
		}

		static void n_GetAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetAccounts (p0);
		}
#pragma warning restore 0169

		IntPtr id_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_;
		public unsafe void GetAccounts (global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback p0)
		{
			if (id_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ == IntPtr.Zero)
				id_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_ = JNIEnv.GetMethodID (class_ref, "getAccounts", "(Lcom/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAccounts_Lcom_microsoft_identity_client_IPublicClientApplication_LoadAccountsCallback_, __args);
		}

		static Delegate cb_removeAccount_Lcom_microsoft_identity_client_IAccount_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_client_IAccount_ == null)
				cb_removeAccount_Lcom_microsoft_identity_client_IAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_);
			return cb_removeAccount_Lcom_microsoft_identity_client_IAccount_;
		}

		static bool n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAccount (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAccount_Lcom_microsoft_identity_client_IAccount_;
		public unsafe bool RemoveAccount (global::Com.Microsoft.Identity.Client.IAccount p0)
		{
			if (id_removeAccount_Lcom_microsoft_identity_client_IAccount_ == IntPtr.Zero)
				id_removeAccount_Lcom_microsoft_identity_client_IAccount_ = JNIEnv.GetMethodID (class_ref, "removeAccount", "(Lcom/microsoft/identity/client/IAccount;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeAccount_Lcom_microsoft_identity_client_IAccount_, __args);
			return __ret;
		}

		static Delegate cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_Handler ()
		{
			if (cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ == null)
				cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_);
			return cb_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_;
		}

		static void n_RemoveAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccount (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_;
		public unsafe void RemoveAccount (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplicationRemoveAccountCallback p1)
		{
			if (id_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ == IntPtr.Zero)
				id_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_ = JNIEnv.GetMethodID (class_ref, "removeAccount", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication$RemoveAccountCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAccount_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_RemoveAccountCallback_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
