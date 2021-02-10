using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfigurationClient']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient", DoNotGenerateAcw=true)]
	public partial class OpenIdProviderConfigurationClient : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='OpenIdProviderConfigurationClient.OpenIdProviderConfigurationCallback']"
		[Register ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient$OpenIdProviderConfigurationCallback", "", "Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient/IOpenIdProviderConfigurationCallbackInvoker")]
		public partial interface IOpenIdProviderConfigurationCallback : global::Com.Microsoft.Identity.Common.Internal.Controllers.ITaskCompletedCallbackWithError {
		}

		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient$OpenIdProviderConfigurationCallback", DoNotGenerateAcw=true)]
		internal partial class IOpenIdProviderConfigurationCallbackInvoker : global::Java.Lang.Object, IOpenIdProviderConfigurationCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient$OpenIdProviderConfigurationCallback", typeof (IOpenIdProviderConfigurationCallbackInvoker));

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

			public static IOpenIdProviderConfigurationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOpenIdProviderConfigurationCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.providers.oauth2.OpenIdProviderConfigurationClient.OpenIdProviderConfigurationCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOpenIdProviderConfigurationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient.IOpenIdProviderConfigurationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_Object_;
			public unsafe void OnError (global::Java.Lang.Object p0)
			{
				if (id_onError_Ljava_lang_Object_ == IntPtr.Zero)
					id_onError_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient.IOpenIdProviderConfigurationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTaskCompleted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTaskCompleted_Ljava_lang_Object_;
			public unsafe void OnTaskCompleted (global::Java.Lang.Object p0)
			{
				if (id_onTaskCompleted_Ljava_lang_Object_ == IntPtr.Zero)
					id_onTaskCompleted_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onTaskCompleted", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskCompleted_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient", typeof (OpenIdProviderConfigurationClient));

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

		protected OpenIdProviderConfigurationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfigurationClient']/constructor[@name='OpenIdProviderConfigurationClient' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe OpenIdProviderConfigurationClient (string issuer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_issuer = JNIEnv.NewString (issuer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_issuer);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_issuer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfigurationClient']/constructor[@name='OpenIdProviderConfigurationClient' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OpenIdProviderConfigurationClient (string authority, string path) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_path);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfigurationClient']/constructor[@name='OpenIdProviderConfigurationClient' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OpenIdProviderConfigurationClient (string authority, string path, string endpointVersion) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_endpointVersion = JNIEnv.NewString (endpointVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (native_endpointVersion);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_endpointVersion);
			}
		}

		static Delegate cb_loadOpenIdProviderConfiguration;
#pragma warning disable 0169
		static Delegate GetLoadOpenIdProviderConfigurationHandler ()
		{
			if (cb_loadOpenIdProviderConfiguration == null)
				cb_loadOpenIdProviderConfiguration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LoadOpenIdProviderConfiguration);
			return cb_loadOpenIdProviderConfiguration;
		}

		static IntPtr n_LoadOpenIdProviderConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadOpenIdProviderConfiguration ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfigurationClient']/method[@name='loadOpenIdProviderConfiguration' and count(parameter)=0]"
		[Register ("loadOpenIdProviderConfiguration", "()Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfiguration;", "GetLoadOpenIdProviderConfigurationHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration LoadOpenIdProviderConfiguration ()
		{
			const string __id = "loadOpenIdProviderConfiguration.()Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfiguration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_loadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_;
#pragma warning disable 0169
		static Delegate GetLoadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_Handler ()
		{
			if (cb_loadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_ == null)
				cb_loadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_LoadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_);
			return cb_loadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_;
		}

		static void n_LoadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient.IOpenIdProviderConfigurationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient.IOpenIdProviderConfigurationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.LoadOpenIdProviderConfiguration (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdProviderConfigurationClient']/method[@name='loadOpenIdProviderConfiguration' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OpenIdProviderConfigurationClient.OpenIdProviderConfigurationCallback']]"
		[Register ("loadOpenIdProviderConfiguration", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient$OpenIdProviderConfigurationCallback;)V", "GetLoadOpenIdProviderConfiguration_Lcom_microsoft_identity_common_internal_providers_oauth2_OpenIdProviderConfigurationClient_OpenIdProviderConfigurationCallback_Handler")]
		public virtual unsafe void LoadOpenIdProviderConfiguration (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdProviderConfigurationClient.IOpenIdProviderConfigurationCallback @callback)
		{
			const string __id = "loadOpenIdProviderConfiguration.(Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdProviderConfigurationClient$OpenIdProviderConfigurationCallback;)V";
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
