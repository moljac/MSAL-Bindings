using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='SilentAuthenticationCallback']"
	[Register ("com/microsoft/identity/client/SilentAuthenticationCallback", "", "Com.Microsoft.Identity.Client.ISilentAuthenticationCallbackInvoker")]
	public partial interface ISilentAuthenticationCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='SilentAuthenticationCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.ISilentAuthenticationCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='SilentAuthenticationCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IAuthenticationResult']]"
		[Register ("onSuccess", "(Lcom/microsoft/identity/client/IAuthenticationResult;)V", "GetOnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_Handler:Com.Microsoft.Identity.Client.ISilentAuthenticationCallbackInvoker, Microsoft.Identity.Client")]
		void OnSuccess (global::Com.Microsoft.Identity.Client.IAuthenticationResult authenticationResult);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/SilentAuthenticationCallback", DoNotGenerateAcw=true)]
	internal partial class ISilentAuthenticationCallbackInvoker : global::Java.Lang.Object, ISilentAuthenticationCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/SilentAuthenticationCallback", typeof (ISilentAuthenticationCallbackInvoker));

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

		public static ISilentAuthenticationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISilentAuthenticationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.SilentAuthenticationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISilentAuthenticationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_Handler ()
		{
			if (cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ == null)
				cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_);
			return cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_;
		}

		static void n_OnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authenticationResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authenticationResult = (global::Com.Microsoft.Identity.Client.IAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (native_authenticationResult, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (authenticationResult);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_;
		public unsafe void OnSuccess (global::Com.Microsoft.Identity.Client.IAuthenticationResult authenticationResult)
		{
			if (id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ == IntPtr.Zero)
				id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/microsoft/identity/client/IAuthenticationResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((authenticationResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationResult).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_, __args);
		}

	}
}
