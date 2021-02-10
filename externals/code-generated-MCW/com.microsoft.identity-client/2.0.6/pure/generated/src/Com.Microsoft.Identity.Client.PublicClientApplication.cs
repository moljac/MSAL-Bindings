using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/PublicClientApplication", DoNotGenerateAcw=true)]
	public partial class PublicClientApplication : global::Java.Lang.Object, global::Com.Microsoft.Identity.Client.IPublicClientApplication, global::Com.Microsoft.Identity.Client.ITokenShare {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/field[@name='homeAccountMatcher']"
		[Register ("homeAccountMatcher")]
		protected global::Com.Microsoft.Identity.Client.PublicClientApplication.AccountMatcher HomeAccountMatcher {
			get {
				const string __id = "homeAccountMatcher.Lcom/microsoft/identity/client/PublicClientApplication$AccountMatcher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication.AccountMatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "homeAccountMatcher.Lcom/microsoft/identity/client/PublicClientApplication$AccountMatcher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/field[@name='localAccountMatcher']"
		[Register ("localAccountMatcher")]
		protected global::Com.Microsoft.Identity.Client.PublicClientApplication.AccountMatcher LocalAccountMatcher {
			get {
				const string __id = "localAccountMatcher.Lcom/microsoft/identity/client/PublicClientApplication$AccountMatcher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication.AccountMatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "localAccountMatcher.Lcom/microsoft/identity/client/PublicClientApplication$AccountMatcher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/field[@name='mPublicClientConfiguration']"
		[Register ("mPublicClientConfiguration")]
		protected global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration MPublicClientConfiguration {
			get {
				const string __id = "mPublicClientConfiguration.Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPublicClientConfiguration.Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/field[@name='mTokenShareUtility']"
		[Register ("mTokenShareUtility")]
		protected global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility MTokenShareUtility {
			get {
				const string __id = "mTokenShareUtility.Lcom/microsoft/identity/common/adal/internal/tokensharing/TokenShareUtility;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTokenShareUtility.Lcom/microsoft/identity/common/adal/internal/tokensharing/TokenShareUtility;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/field[@name='usernameMatcher']"
		[Register ("usernameMatcher")]
		protected global::Com.Microsoft.Identity.Client.PublicClientApplication.AccountMatcher UsernameMatcher {
			get {
				const string __id = "usernameMatcher.Lcom/microsoft/identity/client/PublicClientApplication$AccountMatcher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication.AccountMatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "usernameMatcher.Lcom/microsoft/identity/client/PublicClientApplication$AccountMatcher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication.AccountMatcher']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/PublicClientApplication$AccountMatcher", DoNotGenerateAcw=true)]
		protected internal partial class AccountMatcher : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PublicClientApplication$AccountMatcher", typeof (AccountMatcher));

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

			protected AccountMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='PublicClientApplication.BrokerDeviceModeCallback']"
		[Register ("com/microsoft/identity/client/PublicClientApplication$BrokerDeviceModeCallback", "", "Com.Microsoft.Identity.Client.PublicClientApplication/IBrokerDeviceModeCallbackInvoker")]
		public partial interface IBrokerDeviceModeCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='PublicClientApplication.BrokerDeviceModeCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.exception.MsalException']]"
			[Register ("onError", "(Lcom/microsoft/identity/client/exception/MsalException;)V", "GetOnError_Lcom_microsoft_identity_client_exception_MsalException_Handler:Com.Microsoft.Identity.Client.PublicClientApplication/IBrokerDeviceModeCallbackInvoker, Microsoft.Identity.Client")]
			void OnError (global::Com.Microsoft.Identity.Client.Exception.MsalException p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='PublicClientApplication.BrokerDeviceModeCallback']/method[@name='onGetMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onGetMode", "(Z)V", "GetOnGetMode_ZHandler:Com.Microsoft.Identity.Client.PublicClientApplication/IBrokerDeviceModeCallbackInvoker, Microsoft.Identity.Client")]
			void OnGetMode (bool p0);

		}

		[global::Android.Runtime.Register ("com/microsoft/identity/client/PublicClientApplication$BrokerDeviceModeCallback", DoNotGenerateAcw=true)]
		internal partial class IBrokerDeviceModeCallbackInvoker : global::Java.Lang.Object, IBrokerDeviceModeCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PublicClientApplication$BrokerDeviceModeCallback", typeof (IBrokerDeviceModeCallbackInvoker));

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

			public static IBrokerDeviceModeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBrokerDeviceModeCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.PublicClientApplication.BrokerDeviceModeCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBrokerDeviceModeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication.IBrokerDeviceModeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onGetMode_Z;
#pragma warning disable 0169
			static Delegate GetOnGetMode_ZHandler ()
			{
				if (cb_onGetMode_Z == null)
					cb_onGetMode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnGetMode_Z);
				return cb_onGetMode_Z;
			}

			static void n_OnGetMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication.IBrokerDeviceModeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnGetMode (p0);
			}
#pragma warning restore 0169

			IntPtr id_onGetMode_Z;
			public unsafe void OnGetMode (bool p0)
			{
				if (id_onGetMode_Z == IntPtr.Zero)
					id_onGetMode_Z = JNIEnv.GetMethodID (class_ref, "onGetMode", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetMode_Z, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PublicClientApplication", typeof (PublicClientApplication));

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

		protected PublicClientApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/constructor[@name='PublicClientApplication' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)V", "")]
		protected unsafe PublicClientApplication (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration configFile) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (configFile);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;", "GetGetConfigurationHandler")]
			get {
				const string __id = "getConfiguration.()Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSharedDevice;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSharedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='isSharedDevice' and count(parameter)=0]"
			[Register ("isSharedDevice", "()Z", "GetIsSharedDeviceHandler")]
			get {
				const string __id = "isSharedDevice.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var @callback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (activity, scopes, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='acquireToken' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.microsoft.identity.client.AuthenticationCallback']]"
		[Register ("acquireToken", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V", "GetAcquireToken_Landroid_app_Activity_arrayLjava_lang_String_Lcom_microsoft_identity_client_AuthenticationCallback_Handler")]
		public virtual unsafe void AcquireToken (global::Android.App.Activity activity, string[] scopes, global::Com.Microsoft.Identity.Client.IAuthenticationCallback @callback)
		{
			const string __id = "acquireToken.(Landroid/app/Activity;[Ljava/lang/String;Lcom/microsoft/identity/client/AuthenticationCallback;)V";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_scopes);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (@callback);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acquireTokenParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (native_acquireTokenParameters, JniHandleOwnership.DoNotTransfer);
			__this.AcquireToken (acquireTokenParameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='acquireToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenParameters']]"
		[Register ("acquireToken", "(Lcom/microsoft/identity/client/AcquireTokenParameters;)V", "GetAcquireToken_Lcom_microsoft_identity_client_AcquireTokenParameters_Handler")]
		public virtual unsafe void AcquireToken (global::Com.Microsoft.Identity.Client.AcquireTokenParameters acquireTokenParameters)
		{
			const string __id = "acquireToken.(Lcom/microsoft/identity/client/AcquireTokenParameters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((acquireTokenParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenParameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (acquireTokenParameters);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acquireTokenSilentParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_acquireTokenSilentParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilent (acquireTokenSilentParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='acquireTokenSilent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register ("acquireTokenSilent", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/client/IAuthenticationResult;", "GetAcquireTokenSilent_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Client.IAuthenticationResult AcquireTokenSilent (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters acquireTokenSilentParameters)
		{
			const string __id = "acquireTokenSilent.(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/client/IAuthenticationResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((acquireTokenSilentParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenSilentParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (acquireTokenSilentParameters);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var acquireTokenSilentParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_acquireTokenSilentParameters, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenSilentAsync (acquireTokenSilentParameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='acquireTokenSilentAsync' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register ("acquireTokenSilentAsync", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V", "GetAcquireTokenSilentAsync_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler")]
		public virtual unsafe void AcquireTokenSilentAsync (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters acquireTokenSilentParameters)
		{
			const string __id = "acquireTokenSilentAsync.(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((acquireTokenSilentParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acquireTokenSilentParameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (acquireTokenSilentParameters);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var @callback = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.AcquireTokenWithDeviceCode (scopes, @callback);
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='acquireTokenWithDeviceCode' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IPublicClientApplication.DeviceCodeFlowCallback']]"
		[Register ("acquireTokenWithDeviceCode", "([Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback;)V", "GetAcquireTokenWithDeviceCode_arrayLjava_lang_String_Lcom_microsoft_identity_client_IPublicClientApplication_DeviceCodeFlowCallback_Handler")]
		public virtual unsafe void AcquireTokenWithDeviceCode (string[] scopes, global::Com.Microsoft.Identity.Client.IPublicClientApplicationDeviceCodeFlowCallback @callback)
		{
			const string __id = "acquireTokenWithDeviceCode.([Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$DeviceCodeFlowCallback;)V";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_buildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetBuildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler ()
		{
			if (cb_buildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == null)
				cb_buildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZLL_L) n_BuildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_);
			return cb_buildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		}

		static IntPtr n_BuildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes, IntPtr native_account, IntPtr native_authority, bool forceRefresh, IntPtr native_claimsRequest, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			var claimsRequest = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (native_claimsRequest, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildAcquireTokenSilentParameters (scopes, account, authority, forceRefresh, claimsRequest, @callback));
			if (scopes != null)
				JNIEnv.CopyArray (scopes, native_scopes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='buildAcquireTokenSilentParameters' and count(parameter)=6 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.microsoft.identity.client.IAccount'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='com.microsoft.identity.client.claims.ClaimsRequest'] and parameter[6][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("buildAcquireTokenSilentParameters", "([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;ZLcom/microsoft/identity/client/claims/ClaimsRequest;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)Lcom/microsoft/identity/client/AcquireTokenSilentParameters;", "GetBuildAcquireTokenSilentParameters_arrayLjava_lang_String_Lcom_microsoft_identity_client_IAccount_Ljava_lang_String_ZLcom_microsoft_identity_client_claims_ClaimsRequest_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler")]
		protected virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters BuildAcquireTokenSilentParameters (string[] scopes, global::Com.Microsoft.Identity.Client.IAccount account, string authority, bool forceRefresh, global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest claimsRequest, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback @callback)
		{
			const string __id = "buildAcquireTokenSilentParameters.([Ljava/lang/String;Lcom/microsoft/identity/client/IAccount;Ljava/lang/String;ZLcom/microsoft/identity/client/claims/ClaimsRequest;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)Lcom/microsoft/identity/client/AcquireTokenSilentParameters;";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				__args [2] = new JniArgumentValue (native_authority);
				__args [3] = new JniArgumentValue (forceRefresh);
				__args [4] = new JniArgumentValue ((claimsRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) claimsRequest).Handle);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				JNIEnv.DeleteLocalRef (native_authority);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (account);
				global::System.GC.KeepAlive (claimsRequest);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("create", "(Landroid/content/Context;I)Lcom/microsoft/identity/client/IPublicClientApplication;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.IPublicClientApplication Create (global::Android.Content.Context context, int configFileResourceId)
		{
			const string __id = "create.(Landroid/content/Context;I)Lcom/microsoft/identity/client/IPublicClientApplication;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configFileResourceId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='create' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.ApplicationCreatedListener']]"
		[Register ("create", "(Landroid/content/Context;ILcom/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener;)V", "")]
		public static unsafe void Create (global::Android.Content.Context context, int configFileResourceId, global::Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListener listener)
		{
			const string __id = "create.(Landroid/content/Context;ILcom/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configFileResourceId);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='create' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.ApplicationCreatedListener']]"
		[Register ("create", "(Landroid/content/Context;Ljava/io/File;Lcom/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener;)V", "")]
		public static unsafe void Create (global::Android.Content.Context context, global::Java.IO.File configFile, global::Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListener listener)
		{
			const string __id = "create.(Landroid/content/Context;Ljava/io/File;Lcom/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (configFile);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='create' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.microsoft.identity.client.IPublicClientApplication.ApplicationCreatedListener']]"
		[Register ("create", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener;)V", "")]
		public static unsafe void Create (global::Android.Content.Context context, string clientId, string authority, string redirectUri, global::Com.Microsoft.Identity.Client.IPublicClientApplicationApplicationCreatedListener listener)
		{
			const string __id = "create.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/client/IPublicClientApplication$ApplicationCreatedListener;)V";
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_clientId);
				__args [2] = new JniArgumentValue (native_authority);
				__args [3] = new JniArgumentValue (native_redirectUri);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_redirectUri);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createMultipleAccountPublicClientApplication' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("createMultipleAccountPublicClientApplication", "(Landroid/content/Context;I)Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication CreateMultipleAccountPublicClientApplication (global::Android.Content.Context context, int configFileResourceId)
		{
			const string __id = "createMultipleAccountPublicClientApplication.(Landroid/content/Context;I)Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configFileResourceId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createMultipleAccountPublicClientApplication' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.IMultipleAccountApplicationCreatedListener']]"
		[Register ("createMultipleAccountPublicClientApplication", "(Landroid/content/Context;ILcom/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener;)V", "")]
		public static unsafe void CreateMultipleAccountPublicClientApplication (global::Android.Content.Context context, int configFileResourceId, global::Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListener listener)
		{
			const string __id = "createMultipleAccountPublicClientApplication.(Landroid/content/Context;ILcom/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configFileResourceId);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createMultipleAccountPublicClientApplication' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("createMultipleAccountPublicClientApplication", "(Landroid/content/Context;Ljava/io/File;)Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication CreateMultipleAccountPublicClientApplication (global::Android.Content.Context context, global::Java.IO.File configFile)
		{
			const string __id = "createMultipleAccountPublicClientApplication.(Landroid/content/Context;Ljava/io/File;)Lcom/microsoft/identity/client/IMultipleAccountPublicClientApplication;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMultipleAccountPublicClientApplication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (configFile);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createMultipleAccountPublicClientApplication' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.IMultipleAccountApplicationCreatedListener']]"
		[Register ("createMultipleAccountPublicClientApplication", "(Landroid/content/Context;Ljava/io/File;Lcom/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener;)V", "")]
		public static unsafe void CreateMultipleAccountPublicClientApplication (global::Android.Content.Context context, global::Java.IO.File configFile, global::Com.Microsoft.Identity.Client.IPublicClientApplicationMultipleAccountApplicationCreatedListener listener)
		{
			const string __id = "createMultipleAccountPublicClientApplication.(Landroid/content/Context;Ljava/io/File;Lcom/microsoft/identity/client/IPublicClientApplication$IMultipleAccountApplicationCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (configFile);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createSingleAccountPublicClientApplication' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("createSingleAccountPublicClientApplication", "(Landroid/content/Context;I)Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication CreateSingleAccountPublicClientApplication (global::Android.Content.Context context, int configFileResourceId)
		{
			const string __id = "createSingleAccountPublicClientApplication.(Landroid/content/Context;I)Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configFileResourceId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createSingleAccountPublicClientApplication' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.ISingleAccountApplicationCreatedListener']]"
		[Register ("createSingleAccountPublicClientApplication", "(Landroid/content/Context;ILcom/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener;)V", "")]
		public static unsafe void CreateSingleAccountPublicClientApplication (global::Android.Content.Context context, int configFileResourceId, global::Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListener listener)
		{
			const string __id = "createSingleAccountPublicClientApplication.(Landroid/content/Context;ILcom/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configFileResourceId);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createSingleAccountPublicClientApplication' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("createSingleAccountPublicClientApplication", "(Landroid/content/Context;Ljava/io/File;)Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication CreateSingleAccountPublicClientApplication (global::Android.Content.Context context, global::Java.IO.File configFile)
		{
			const string __id = "createSingleAccountPublicClientApplication.(Landroid/content/Context;Ljava/io/File;)Lcom/microsoft/identity/client/ISingleAccountPublicClientApplication;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISingleAccountPublicClientApplication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (configFile);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='createSingleAccountPublicClientApplication' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.ISingleAccountApplicationCreatedListener']]"
		[Register ("createSingleAccountPublicClientApplication", "(Landroid/content/Context;Ljava/io/File;Lcom/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener;)V", "")]
		public static unsafe void CreateSingleAccountPublicClientApplication (global::Android.Content.Context context, global::Java.IO.File configFile, global::Com.Microsoft.Identity.Client.IPublicClientApplicationSingleAccountApplicationCreatedListener listener)
		{
			const string __id = "createSingleAccountPublicClientApplication.(Landroid/content/Context;Ljava/io/File;Lcom/microsoft/identity/client/IPublicClientApplication$ISingleAccountApplicationCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (configFile);
				global::System.GC.KeepAlive (listener);
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

		static IntPtr n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account, IntPtr native_popParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			var popParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (native_popParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateSignedHttpRequest (account, popParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='generateSignedHttpRequest' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.PoPAuthenticationScheme']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;)Ljava/lang/String;", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Handler")]
		public virtual unsafe string GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Client.IAccount account, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme popParameters)
		{
			const string __id = "generateSignedHttpRequest.(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				__args [1] = new JniArgumentValue ((popParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) popParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (account);
				global::System.GC.KeepAlive (popParameters);
			}
		}

		static Delegate cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_Handler ()
		{
			if (cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ == null)
				cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_);
			return cb_generateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_;
		}

		static void n_GenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account, IntPtr native_popParameters, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = (global::Com.Microsoft.Identity.Client.IAccount)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (native_account, JniHandleOwnership.DoNotTransfer);
			var popParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (native_popParameters, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GenerateSignedHttpRequest (account, popParameters, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='generateSignedHttpRequest' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.PoPAuthenticationScheme'] and parameter[3][@type='com.microsoft.identity.client.IPublicClientApplication.SignedHttpRequestRequestCallback']]"
		[Register ("generateSignedHttpRequest", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;Lcom/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback;)V", "GetGenerateSignedHttpRequest_Lcom_microsoft_identity_client_IAccount_Lcom_microsoft_identity_client_PoPAuthenticationScheme_Lcom_microsoft_identity_client_IPublicClientApplication_SignedHttpRequestRequestCallback_Handler")]
		public virtual unsafe void GenerateSignedHttpRequest (global::Com.Microsoft.Identity.Client.IAccount account, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme popParameters, global::Com.Microsoft.Identity.Client.IPublicClientApplicationSignedHttpRequestRequestCallback @callback)
		{
			const string __id = "generateSignedHttpRequest.(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/PoPAuthenticationScheme;Lcom/microsoft/identity/client/IPublicClientApplication$SignedHttpRequestRequestCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				__args [1] = new JniArgumentValue ((popParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) popParameters).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (account);
				global::System.GC.KeepAlive (popParameters);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_getCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_;
#pragma warning disable 0169
		static Delegate GetGetCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_Handler ()
		{
			if (cb_getCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_ == null)
				cb_getCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_);
			return cb_getCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_;
		}

		static IntPtr n_GetCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authenticationCallback, IntPtr native_tokenParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authenticationCallback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native_authenticationCallback, JniHandleOwnership.DoNotTransfer);
			var tokenParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (native_tokenParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCommandCallback (authenticationCallback, tokenParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getCommandCallback' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.SilentAuthenticationCallback'] and parameter[2][@type='com.microsoft.identity.client.TokenParameters']]"
		[Register ("getCommandCallback", "(Lcom/microsoft/identity/client/SilentAuthenticationCallback;Lcom/microsoft/identity/client/TokenParameters;)Lcom/microsoft/identity/common/internal/commands/CommandCallback;", "GetGetCommandCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Lcom_microsoft_identity_client_TokenParameters_Handler")]
		protected virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback GetCommandCallback (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback authenticationCallback, global::Com.Microsoft.Identity.Client.TokenParameters tokenParameters)
		{
			const string __id = "getCommandCallback.(Lcom/microsoft/identity/client/SilentAuthenticationCallback;Lcom/microsoft/identity/client/TokenParameters;)Lcom/microsoft/identity/common/internal/commands/CommandCallback;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((authenticationCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationCallback).Handle);
				__args [1] = new JniArgumentValue ((tokenParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (authenticationCallback);
				global::System.GC.KeepAlive (tokenParameters);
			}
		}

		static Delegate cb_getMsaFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsaFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_getMsaFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_getMsaFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMsaFamilyRefreshToken_Ljava_lang_String_);
			return cb_getMsaFamilyRefreshToken_Ljava_lang_String_;
		}

		static IntPtr n_GetMsaFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMsaFamilyRefreshToken (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getMsaFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsaFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMsaFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe string GetMsaFamilyRefreshToken (string identifier)
		{
			const string __id = "getMsaFamilyRefreshToken.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler ()
		{
			if (cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == null)
				cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_);
			return cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		}

		static IntPtr n_GetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMsaFamilyRefreshTokenWithMetadata (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getMsaFamilyRefreshTokenWithMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsaFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenShareResult;", "GetGetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Client.TokenShareResult GetMsaFamilyRefreshTokenWithMetadata (string identifier)
		{
			const string __id = "getMsaFamilyRefreshTokenWithMetadata.(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenShareResult;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenShareResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOrgIdFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrgIdFamilyRefreshToken_Ljava_lang_String_);
			return cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
		}

		static IntPtr n_GetOrgIdFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetOrgIdFamilyRefreshToken (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getOrgIdFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrgIdFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetOrgIdFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe string GetOrgIdFamilyRefreshToken (string identifier)
		{
			const string __id = "getOrgIdFamilyRefreshToken.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler ()
		{
			if (cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == null)
				cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_);
			return cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		}

		static IntPtr n_GetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrgIdFamilyRefreshTokenWithMetadata (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='getOrgIdFamilyRefreshTokenWithMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrgIdFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenShareResult;", "GetGetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Client.TokenShareResult GetOrgIdFamilyRefreshTokenWithMetadata (string identifier)
		{
			const string __id = "getOrgIdFamilyRefreshTokenWithMetadata.(Ljava/lang/String;)Lcom/microsoft/identity/client/TokenShareResult;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenShareResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_postAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetPostAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler ()
		{
			if (cb_postAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == null)
				cb_postAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PostAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_);
			return cb_postAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
		}

		static void n_PostAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_localAuthenticationResult, IntPtr native_requestParameters, IntPtr native_authenticationCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var localAuthenticationResult = (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (native_localAuthenticationResult, JniHandleOwnership.DoNotTransfer);
			var requestParameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (native_requestParameters, JniHandleOwnership.DoNotTransfer);
			var authenticationCallback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native_authenticationCallback, JniHandleOwnership.DoNotTransfer);
			__this.PostAuthResult (localAuthenticationResult, requestParameters, authenticationCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='postAuthResult' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult'] and parameter[2][@type='com.microsoft.identity.client.TokenParameters'] and parameter[3][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
		[Register ("postAuthResult", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;Lcom/microsoft/identity/client/TokenParameters;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V", "GetPostAuthResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Lcom_microsoft_identity_client_TokenParameters_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler")]
		protected virtual unsafe void PostAuthResult (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult localAuthenticationResult, global::Com.Microsoft.Identity.Client.TokenParameters requestParameters, global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback authenticationCallback)
		{
			const string __id = "postAuthResult.(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;Lcom/microsoft/identity/client/TokenParameters;Lcom/microsoft/identity/client/SilentAuthenticationCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((localAuthenticationResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localAuthenticationResult).Handle);
				__args [1] = new JniArgumentValue ((requestParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestParameters).Handle);
				__args [2] = new JniArgumentValue ((authenticationCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (localAuthenticationResult);
				global::System.GC.KeepAlive (requestParameters);
				global::System.GC.KeepAlive (authenticationCallback);
			}
		}

		static Delegate cb_saveMsaFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveMsaFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveMsaFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_saveMsaFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveMsaFamilyRefreshToken_Ljava_lang_String_);
			return cb_saveMsaFamilyRefreshToken_Ljava_lang_String_;
		}

		static void n_SaveMsaFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			__this.SaveMsaFamilyRefreshToken (refreshToken);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='saveMsaFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveMsaFamilyRefreshToken", "(Ljava/lang/String;)V", "GetSaveMsaFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveMsaFamilyRefreshToken (string refreshToken)
		{
			const string __id = "saveMsaFamilyRefreshToken.(Ljava/lang/String;)V";
			IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refreshToken);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refreshToken);
			}
		}

		static Delegate cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveOrgIdFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveOrgIdFamilyRefreshToken_Ljava_lang_String_);
			return cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
		}

		static void n_SaveOrgIdFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ssoStateSerializerBlob)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ssoStateSerializerBlob = JNIEnv.GetString (native_ssoStateSerializerBlob, JniHandleOwnership.DoNotTransfer);
			__this.SaveOrgIdFamilyRefreshToken (ssoStateSerializerBlob);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='saveOrgIdFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveOrgIdFamilyRefreshToken", "(Ljava/lang/String;)V", "GetSaveOrgIdFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveOrgIdFamilyRefreshToken (string ssoStateSerializerBlob)
		{
			const string __id = "saveOrgIdFamilyRefreshToken.(Ljava/lang/String;)V";
			IntPtr native_ssoStateSerializerBlob = JNIEnv.NewString (ssoStateSerializerBlob);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ssoStateSerializerBlob);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ssoStateSerializerBlob);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='showExpectedMsalRedirectUriInfo' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("showExpectedMsalRedirectUriInfo", "(Landroid/app/Activity;)V", "")]
		public static unsafe void ShowExpectedMsalRedirectUriInfo (global::Android.App.Activity activity)
		{
			const string __id = "showExpectedMsalRedirectUriInfo.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_validateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_;
#pragma warning disable 0169
		static Delegate GetValidateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_Handler ()
		{
			if (cb_validateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_ == null)
				cb_validateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ValidateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_);
			return cb_validateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_;
		}

		static void n_ValidateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			__this.ValidateAcquireTokenParameters (parameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='validateAcquireTokenParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenParameters']]"
		[Register ("validateAcquireTokenParameters", "(Lcom/microsoft/identity/client/AcquireTokenParameters;)V", "GetValidateAcquireTokenParameters_Lcom_microsoft_identity_client_AcquireTokenParameters_Handler")]
		protected virtual unsafe void ValidateAcquireTokenParameters (global::Com.Microsoft.Identity.Client.AcquireTokenParameters parameters)
		{
			const string __id = "validateAcquireTokenParameters.(Lcom/microsoft/identity/client/AcquireTokenParameters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_validateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
#pragma warning disable 0169
		static Delegate GetValidateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler ()
		{
			if (cb_validateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ == null)
				cb_validateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ValidateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_);
			return cb_validateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_;
		}

		static void n_ValidateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			__this.ValidateAcquireTokenSilentParameters (parameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplication']/method[@name='validateAcquireTokenSilentParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register ("validateAcquireTokenSilentParameters", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V", "GetValidateAcquireTokenSilentParameters_Lcom_microsoft_identity_client_AcquireTokenSilentParameters_Handler")]
		protected virtual unsafe void ValidateAcquireTokenSilentParameters (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters parameters)
		{
			const string __id = "validateAcquireTokenSilentParameters.(Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

	}
}
