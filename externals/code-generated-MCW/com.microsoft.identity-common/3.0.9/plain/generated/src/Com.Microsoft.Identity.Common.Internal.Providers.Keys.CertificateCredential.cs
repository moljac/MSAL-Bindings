using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Keys {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/keys/CertificateCredential", DoNotGenerateAcw=true)]
	public sealed partial class CertificateCredential : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder", DoNotGenerateAcw=true)]
		public partial class CertificateCredentialBuilder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder", typeof (CertificateCredentialBuilder));

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

			protected CertificateCredentialBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']/constructor[@name='CertificateCredential.CertificateCredentialBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe CertificateCredentialBuilder (string clientId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientId = JNIEnv.NewString (clientId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientId);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_certificate_Ljava_security_cert_X509Certificate_;
#pragma warning disable 0169
			static Delegate GetCertificate_Ljava_security_cert_X509Certificate_Handler ()
			{
				if (cb_certificate_Ljava_security_cert_X509Certificate_ == null)
					cb_certificate_Ljava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Certificate_Ljava_security_cert_X509Certificate_);
				return cb_certificate_Ljava_security_cert_X509Certificate_;
			}

			static IntPtr n_Certificate_Ljava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var certificate = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_certificate, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Certificate (certificate));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']/method[@name='certificate' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
			[Register ("certificate", "(Ljava/security/cert/X509Certificate;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;", "GetCertificate_Ljava_security_cert_X509Certificate_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder Certificate (global::Java.Security.Cert.X509Certificate certificate)
			{
				const string __id = "certificate.(Ljava/security/cert/X509Certificate;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((certificate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificate).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (certificate);
				}
			}

			static Delegate cb_clientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_;
#pragma warning disable 0169
			static Delegate GetClientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_Handler ()
			{
				if (cb_clientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_ == null)
					cb_clientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ClientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_);
				return cb_clientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_;
			}

			static IntPtr n_ClientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientCertificateMetadata)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var clientCertificateMetadata = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.ClientCertificateMetadata> (native_clientCertificateMetadata, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClientCertificateMetadata (clientCertificateMetadata));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']/method[@name='clientCertificateMetadata' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.keys.ClientCertificateMetadata']]"
			[Register ("clientCertificateMetadata", "(Lcom/microsoft/identity/common/internal/providers/keys/ClientCertificateMetadata;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;", "GetClientCertificateMetadata_Lcom_microsoft_identity_common_internal_providers_keys_ClientCertificateMetadata_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder ClientCertificateMetadata (global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.ClientCertificateMetadata clientCertificateMetadata)
			{
				const string __id = "clientCertificateMetadata.(Lcom/microsoft/identity/common/internal/providers/keys/ClientCertificateMetadata;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((clientCertificateMetadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientCertificateMetadata).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (clientCertificateMetadata);
				}
			}

			static Delegate cb_keyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_;
#pragma warning disable 0169
			static Delegate GetKeyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_Handler ()
			{
				if (cb_keyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_ == null)
					cb_keyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_KeyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_);
				return cb_keyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_;
			}

			static IntPtr n_KeyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_keyStoreConfiguration)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var keyStoreConfiguration = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.KeyStoreConfiguration> (native_keyStoreConfiguration, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.KeyStoreConfiguration (keyStoreConfiguration));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']/method[@name='keyStoreConfiguration' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.keys.KeyStoreConfiguration']]"
			[Register ("keyStoreConfiguration", "(Lcom/microsoft/identity/common/internal/providers/keys/KeyStoreConfiguration;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;", "GetKeyStoreConfiguration_Lcom_microsoft_identity_common_internal_providers_keys_KeyStoreConfiguration_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder KeyStoreConfiguration (global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.KeyStoreConfiguration keyStoreConfiguration)
			{
				const string __id = "keyStoreConfiguration.(Lcom/microsoft/identity/common/internal/providers/keys/KeyStoreConfiguration;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((keyStoreConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyStoreConfiguration).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (keyStoreConfiguration);
				}
			}

			static Delegate cb_privateKey_Ljava_security_PrivateKey_;
#pragma warning disable 0169
			static Delegate GetPrivateKey_Ljava_security_PrivateKey_Handler ()
			{
				if (cb_privateKey_Ljava_security_PrivateKey_ == null)
					cb_privateKey_Ljava_security_PrivateKey_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PrivateKey_Ljava_security_PrivateKey_);
				return cb_privateKey_Ljava_security_PrivateKey_;
			}

			static IntPtr n_PrivateKey_Ljava_security_PrivateKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var key = (global::Java.Security.IPrivateKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (native_key, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrivateKey (key));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential.CertificateCredentialBuilder']/method[@name='privateKey' and count(parameter)=1 and parameter[1][@type='java.security.PrivateKey']]"
			[Register ("privateKey", "(Ljava/security/PrivateKey;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;", "GetPrivateKey_Ljava_security_PrivateKey_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder PrivateKey (global::Java.Security.IPrivateKey key)
			{
				const string __id = "privateKey.(Ljava/security/PrivateKey;)Lcom/microsoft/identity/common/internal/providers/keys/CertificateCredential$CertificateCredentialBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.CertificateCredential.CertificateCredentialBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (key);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/keys/CertificateCredential", typeof (CertificateCredential));

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

		internal CertificateCredential (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Security.IPrivateKey PrivateKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential']/method[@name='getPrivateKey' and count(parameter)=0]"
			[Register ("getPrivateKey", "()Ljava/security/PrivateKey;", "")]
			get {
				const string __id = "getPrivateKey.()Ljava/security/PrivateKey;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Security.Cert.X509Certificate PublicCertificate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='CertificateCredential']/method[@name='getPublicCertificate' and count(parameter)=0]"
			[Register ("getPublicCertificate", "()Ljava/security/cert/X509Certificate;", "")]
			get {
				const string __id = "getPublicCertificate.()Ljava/security/cert/X509Certificate;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
