using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.ApplicationCreatedListener']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListenerInvoker")]
	public partial interface IPublicClientApplicationApplicationCreatedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.ApplicationCreatedListener']/method[@name='onCreated' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IPublicClientApplication']]"
		[Register ("onCreated", "(Lcom/microsoft/identity/client/IPublicClientApplication;)V", "GetOnCreated_Lcom_microsoft_identity_client_IPublicClientApplication_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListenerInvoker, Microsoft.Identity.Client")]
		void OnCreated (global::Com.Microsoft.Identity.Client.IPublicClientApplication application);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.ApplicationCreatedListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListenerInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationApplicationCreatedListenerInvoker : global::Java.Lang.Object, IPublicClientApplicationApplicationCreatedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener", typeof (IPublicClientApplicationApplicationCreatedListenerInvoker));

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

		public static IPublicClientApplicationApplicationCreatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplicationApplicationCreatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication.ApplicationCreatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationApplicationCreatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_;
#pragma warning disable 0169
		static Delegate GetOnCreated_Lcom_microsoft_identity_client_IPublicClientApplication_Handler ()
		{
			if (cb_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_ == null)
				cb_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreated_Lcom_microsoft_identity_client_IPublicClientApplication_);
			return cb_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_;
		}

		static void n_OnCreated_Lcom_microsoft_identity_client_IPublicClientApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var application = (global::Com.Microsoft.Identity.Client.IPublicClientApplication)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (native_application, JniHandleOwnership.DoNotTransfer);
			__this.OnCreated (application);
		}
#pragma warning restore 0169

		IntPtr id_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_;
		public unsafe void OnCreated (global::Com.Microsoft.Identity.Client.IPublicClientApplication application)
		{
			if (id_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_ == IntPtr.Zero)
				id_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_ = JNIEnv.GetMethodID (class_ref, "onCreated", "(Lcom/microsoft/identity/client/IPublicClientApplication;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreated_Lcom_microsoft_identity_client_IPublicClientApplication_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/microsoft/identity/client/IPublicClientApplication_ApplicationCreatedListenerImplementor")]
	internal sealed partial class IPublicClientApplicationApplicationCreatedListenerImplementor : global::Java.Lang.Object, IPublicClientApplicationApplicationCreatedListener {

		object sender;

		public IPublicClientApplicationApplicationCreatedListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microsoft/identity/client/IPublicClientApplication_ApplicationCreatedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		public void OnCreated (global::Com.Microsoft.Identity.Client.IPublicClientApplication application)
		{
		}

		public void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception)
		{
		}

		internal static bool __IsEmpty (IPublicClientApplicationApplicationCreatedListenerImplementor value)
		{
			return true;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.DeviceCodeFlowCallback']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallbackInvoker")]
	public partial interface IPublicClientApplicationDeviceCodeFlowCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.DeviceCodeFlowCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.DeviceCodeFlowCallback']/method[@name='onTokenReceived' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AuthenticationResult']]"
		[Register ("onTokenReceived", "(Lcom/microsoft/identity/client/AuthenticationResult;)V", "GetOnTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallbackInvoker, Microsoft.Identity.Client")]
		void OnTokenReceived (global::Com.Microsoft.Identity.Client.AuthenticationResult authResult);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.DeviceCodeFlowCallback']/method[@name='onUserCodeReceived' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date']]"
		[Register ("onUserCodeReceived", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", "GetOnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallbackInvoker, Microsoft.Identity.Client")]
		void OnUserCodeReceived (string p0, string p1, string p2, global::Java.Util.Date p3);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationDeviceCodeFlowCallbackInvoker : global::Java.Lang.Object, IPublicClientApplicationDeviceCodeFlowCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback", typeof (IPublicClientApplicationDeviceCodeFlowCallbackInvoker));

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

		public static IPublicClientApplicationDeviceCodeFlowCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplicationDeviceCodeFlowCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication.DeviceCodeFlowCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationDeviceCodeFlowCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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

		static void n_OnError_Lcom_microsoft_identity_client_exception_MsalException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnError (error);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_microsoft_identity_client_exception_MsalException_;
		public unsafe void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException error)
		{
			if (id_onError_Lcom_microsoft_identity_client_exception_MsalException_ == IntPtr.Zero)
				id_onError_Lcom_microsoft_identity_client_exception_MsalException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_microsoft_identity_client_exception_MsalException_, __args);
		}

		static Delegate cb_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_;
#pragma warning disable 0169
		static Delegate GetOnTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_Handler ()
		{
			if (cb_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_ == null)
				cb_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_);
			return cb_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_;
		}

		static void n_OnTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AuthenticationResult> (native_authResult, JniHandleOwnership.DoNotTransfer);
			__this.OnTokenReceived (authResult);
		}
#pragma warning restore 0169

		IntPtr id_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_;
		public unsafe void OnTokenReceived (global::Com.Microsoft.Identity.Client.AuthenticationResult authResult)
		{
			if (id_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_ == IntPtr.Zero)
				id_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_ = JNIEnv.GetMethodID (class_ref, "onTokenReceived", "(Lcom/microsoft/identity/client/AuthenticationResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((authResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authResult).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTokenReceived_Lcom_microsoft_identity_client_AuthenticationResult_, __args);
		}

		static Delegate cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetOnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler ()
		{
			if (cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ == null)
				cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_);
			return cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		}

		static void n_OnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnUserCodeReceived (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		public unsafe void OnUserCodeReceived (string p0, string p1, string p2, global::Java.Util.Date p3)
		{
			if (id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "onUserCodeReceived", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.IMultipleAccountApplicationCreatedListener']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListenerInvoker")]
	public partial interface IPublicClientApplicationMultipleAccountApplicationCreatedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.IMultipleAccountApplicationCreatedListener']/method[@name='onCreated' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IMultipleAccountPublicClientApplication']]"
		[Register ("onCreated", "(Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication;)V", "GetOnCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListenerInvoker, Microsoft.Identity.Client")]
		void OnCreated (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication application);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.IMultipleAccountApplicationCreatedListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListenerInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationMultipleAccountApplicationCreatedListenerInvoker : global::Java.Lang.Object, IPublicClientApplicationMultipleAccountApplicationCreatedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener", typeof (IPublicClientApplicationMultipleAccountApplicationCreatedListenerInvoker));

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

		public static IPublicClientApplicationMultipleAccountApplicationCreatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplicationMultipleAccountApplicationCreatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication.IMultipleAccountApplicationCreatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationMultipleAccountApplicationCreatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_;
#pragma warning disable 0169
		static Delegate GetOnCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_Handler ()
		{
			if (cb_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_ == null)
				cb_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_);
			return cb_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_;
		}

		static void n_OnCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var application = (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (native_application, JniHandleOwnership.DoNotTransfer);
			__this.OnCreated (application);
		}
#pragma warning restore 0169

		IntPtr id_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_;
		public unsafe void OnCreated (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication application)
		{
			if (id_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_ == IntPtr.Zero)
				id_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_ = JNIEnv.GetMethodID (class_ref, "onCreated", "(Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreated_Lcom_microsoft_identity_client_IMultipleAccountPublicClientApplication_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/microsoft/identity/client/IPublicClientApplication_IMultipleAccountApplicationCreatedListenerImplementor")]
	internal sealed partial class IPublicClientApplicationMultipleAccountApplicationCreatedListenerImplementor : global::Java.Lang.Object, IPublicClientApplicationMultipleAccountApplicationCreatedListener {

		object sender;

		public IPublicClientApplicationMultipleAccountApplicationCreatedListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microsoft/identity/client/IPublicClientApplication_IMultipleAccountApplicationCreatedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		public void OnCreated (global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication application)
		{
		}

		public void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception)
		{
		}

		internal static bool __IsEmpty (IPublicClientApplicationMultipleAccountApplicationCreatedListenerImplementor value)
		{
			return true;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.ISingleAccountApplicationCreatedListener']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListenerInvoker")]
	public partial interface IPublicClientApplicationSingleAccountApplicationCreatedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.ISingleAccountApplicationCreatedListener']/method[@name='onCreated' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ISingleAccountPublicClientApplication']]"
		[Register ("onCreated", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication;)V", "GetOnCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListenerInvoker, Microsoft.Identity.Client")]
		void OnCreated (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication application);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.ISingleAccountApplicationCreatedListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListenerInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationSingleAccountApplicationCreatedListenerInvoker : global::Java.Lang.Object, IPublicClientApplicationSingleAccountApplicationCreatedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener", typeof (IPublicClientApplicationSingleAccountApplicationCreatedListenerInvoker));

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

		public static IPublicClientApplicationSingleAccountApplicationCreatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplicationSingleAccountApplicationCreatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication.ISingleAccountApplicationCreatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationSingleAccountApplicationCreatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_;
#pragma warning disable 0169
		static Delegate GetOnCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_Handler ()
		{
			if (cb_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_ == null)
				cb_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_);
			return cb_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_;
		}

		static void n_OnCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var application = (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (native_application, JniHandleOwnership.DoNotTransfer);
			__this.OnCreated (application);
		}
#pragma warning restore 0169

		IntPtr id_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_;
		public unsafe void OnCreated (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication application)
		{
			if (id_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_ == IntPtr.Zero)
				id_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_ = JNIEnv.GetMethodID (class_ref, "onCreated", "(Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreated_Lcom_microsoft_identity_client_ISingleAccountPublicClientApplication_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/microsoft/identity/client/IPublicClientApplication_ISingleAccountApplicationCreatedListenerImplementor")]
	internal sealed partial class IPublicClientApplicationSingleAccountApplicationCreatedListenerImplementor : global::Java.Lang.Object, IPublicClientApplicationSingleAccountApplicationCreatedListener {

		object sender;

		public IPublicClientApplicationSingleAccountApplicationCreatedListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microsoft/identity/client/IPublicClientApplication_ISingleAccountApplicationCreatedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		public void OnCreated (global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication application)
		{
		}

		public void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception)
		{
		}

		internal static bool __IsEmpty (IPublicClientApplicationSingleAccountApplicationCreatedListenerImplementor value)
		{
			return true;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.LoadAccountsCallback']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallbackInvoker")]
	public partial interface IPublicClientApplicationLoadAccountsCallback : global::Com.Microsoft.Identity.Common.Internal.Controllers.ITaskCompletedCallbackWithError {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.LoadAccountsCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.LoadAccountsCallback']/method[@name='onTaskCompleted' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.client.IAccount&gt;']]"
		[Register ("onTaskCompleted", "(Ljava/util/List;)V", "GetOnTaskCompleted_Ljava_util_List_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallbackInvoker, Microsoft.Identity.Client")]
		void OnTaskCompleted (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.IAccount> result);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationLoadAccountsCallbackInvoker : global::Java.Lang.Object, IPublicClientApplicationLoadAccountsCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication$LoadAccountsCallback", typeof (IPublicClientApplicationLoadAccountsCallbackInvoker));

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

		public static IPublicClientApplicationLoadAccountsCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplicationLoadAccountsCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication.LoadAccountsCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationLoadAccountsCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onTaskCompleted_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnTaskCompleted_Ljava_util_List_Handler ()
		{
			if (cb_onTaskCompleted_Ljava_util_List_ == null)
				cb_onTaskCompleted_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTaskCompleted_Ljava_util_List_);
			return cb_onTaskCompleted_Ljava_util_List_;
		}

		static void n_OnTaskCompleted_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.IAccount>.FromJniHandle (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskCompleted (result);
		}
#pragma warning restore 0169

		IntPtr id_onTaskCompleted_Ljava_util_List_;
		public unsafe void OnTaskCompleted (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.IAccount> result)
		{
			if (id_onTaskCompleted_Ljava_util_List_ == IntPtr.Zero)
				id_onTaskCompleted_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onTaskCompleted", "(Ljava/util/List;)V");
			IntPtr native_result = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.IAccount>.ToLocalJniHandle (result);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_result);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskCompleted_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_result);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationLoadAccountsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.SignedHttpRequestRequestCallback']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallbackInvoker")]
	public partial interface IPublicClientApplicationSignedHttpRequestRequestCallback : global::Com.Microsoft.Identity.Common.Internal.Controllers.ITaskCompletedCallbackWithError {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.SignedHttpRequestRequestCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
		[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallbackInvoker, Microsoft.Identity.Client")]
		void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication.SignedHttpRequestRequestCallback']/method[@name='onTaskCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onTaskCompleted", "(Ljava/lang/String;)V", "GetOnTaskCompleted_Ljava_lang_String_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallbackInvoker, Microsoft.Identity.Client")]
		void OnTaskCompleted (string p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationSignedHttpRequestRequestCallbackInvoker : global::Java.Lang.Object, IPublicClientApplicationSignedHttpRequestRequestCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback", typeof (IPublicClientApplicationSignedHttpRequestRequestCallbackInvoker));

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

		public static IPublicClientApplicationSignedHttpRequestRequestCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplicationSignedHttpRequestRequestCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication.SignedHttpRequestRequestCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationSignedHttpRequestRequestCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onTaskCompleted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnTaskCompleted_Ljava_lang_String_Handler ()
		{
			if (cb_onTaskCompleted_Ljava_lang_String_ == null)
				cb_onTaskCompleted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTaskCompleted_Ljava_lang_String_);
			return cb_onTaskCompleted_Ljava_lang_String_;
		}

		static void n_OnTaskCompleted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTaskCompleted_Ljava_lang_String_;
		public unsafe void OnTaskCompleted (string p0)
		{
			if (id_onTaskCompleted_Ljava_lang_String_ == IntPtr.Zero)
				id_onTaskCompleted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onTaskCompleted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskCompleted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']"
	[Register ("com/microsoft/identity/client/IPublicClientApplication", "", "Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker")]
	public partial interface IPublicClientApplication : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;", "GetGetConfigurationHandler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
			get; 
		}

		bool IsSharedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='isSharedDevice' and count(parameter)=0]"
			[Register ("isSharedDevice", "()Z", "GetIsSharedDeviceHandler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='acquireToken' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetAcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireToken (global::Android.App.Activity activity, string[] scopes, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='acquireToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenParameters']]"
		[Register ("acquireToken", "(Lcom/microsoft/identity/client/AcquireTokenParameters;)V", "GetAcquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireToken (global::Com.Microsoft.Identity.Client.AcquireTokenParameters acquireTokenParameters);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='acquireTokenSilent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register ("acquireTokenSilent", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/client/IAuthenticationResult;", "GetAcquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters acquireTokenSilentParameters);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register ("acquireTokenSilentAsync", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V", "GetAcquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireTokenSilentAsync (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters acquireTokenSilentParameters);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='acquireTokenWithDeviceCode' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IPublicClientApplication.DeviceCodeFlowCallback']]"
		[Register ("acquireTokenWithDeviceCode", "([Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback;)V", "GetAcquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void AcquireTokenWithDeviceCode (string[] scopes, global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='generateSignedHttpRequest' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.PoPAuthenticationScheme']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;)Ljava/lang/String;", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		string GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IPublicClientApplication']/method[@name='generateSignedHttpRequest' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.PoPAuthenticationScheme'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.SignedHttpRequestRequestCallback']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;Lcom/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback;)V", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_Handler:Com.Microsoft.Identity.Client.IPublicClientApplicationInvoker, Microsoft.Identity.Client")]
		void GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Client.IAccount p0, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme p1, global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback p2);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IPublicClientApplication", DoNotGenerateAcw=true)]
	internal partial class IPublicClientApplicationInvoker : global::Java.Lang.Object, IPublicClientApplication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IPublicClientApplication", typeof (IPublicClientApplicationInvoker));

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

		public static IPublicClientApplication GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublicClientApplication> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IPublicClientApplication"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicClientApplicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
