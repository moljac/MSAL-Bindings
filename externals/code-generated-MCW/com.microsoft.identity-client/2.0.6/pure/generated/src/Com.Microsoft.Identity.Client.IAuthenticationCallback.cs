using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='AuthenticationCallback']"
	[Register ("com/microsoft/identity/client/AuthenticationCallback", "", "Com.Microsoft.Identity.Client.IAuthenticationCallbackInvoker")]
	public partial interface IAuthenticationCallback : global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='AuthenticationCallback']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Microsoft.Identity.Client.IAuthenticationCallbackInvoker, Microsoft.Identity.Client")]
		void OnCancel ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/AuthenticationCallback", DoNotGenerateAcw=true)]
	internal partial class IAuthenticationCallbackInvoker : global::Java.Lang.Object, IAuthenticationCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AuthenticationCallback", typeof (IAuthenticationCallbackInvoker));

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

		public static IAuthenticationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.AuthenticationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_Handler ()
		{
			if (cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ == null)
				cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_);
			return cb_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_;
		}

		static void n_OnSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Client.IAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_;
		public unsafe void OnSuccess (global::Com.Microsoft.Identity.Client.IAuthenticationResult p0)
		{
			if (id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ == IntPtr.Zero)
				id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/microsoft/identity/client/IAuthenticationResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_microsoft_identity_client_IAuthenticationResult_, __args);
		}

	}
}
