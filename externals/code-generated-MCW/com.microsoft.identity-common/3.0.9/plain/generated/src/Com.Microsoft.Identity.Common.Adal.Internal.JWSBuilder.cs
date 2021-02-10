using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='JWSBuilder']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/JWSBuilder", DoNotGenerateAcw=true)]
	public partial class JWSBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/JWSBuilder", typeof (JWSBuilder));

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

		protected JWSBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='JWSBuilder']/constructor[@name='JWSBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JWSBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_generateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_Handler ()
		{
			if (cb_generateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_ == null)
				cb_generateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_GenerateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_);
			return cb_generateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_;
		}

		static IntPtr n_GenerateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nonce, IntPtr native_audience, IntPtr native_privateKey, IntPtr native_pubKey, IntPtr native_cert)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.JWSBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nonce = JNIEnv.GetString (native_nonce, JniHandleOwnership.DoNotTransfer);
			var audience = JNIEnv.GetString (native_audience, JniHandleOwnership.DoNotTransfer);
			var privateKey = (global::Java.Security.Interfaces.IRSAPrivateKey)global::Java.Lang.Object.GetObject<global::Java.Security.Interfaces.IRSAPrivateKey> (native_privateKey, JniHandleOwnership.DoNotTransfer);
			var pubKey = (global::Java.Security.Interfaces.IRSAPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.Interfaces.IRSAPublicKey> (native_pubKey, JniHandleOwnership.DoNotTransfer);
			var cert = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_cert, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateSignedJWT (nonce, audience, privateKey, pubKey, cert));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='JWSBuilder']/method[@name='generateSignedJWT' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.security.interfaces.RSAPrivateKey'] and parameter[4][@type='java.security.interfaces.RSAPublicKey'] and parameter[5][@type='java.security.cert.X509Certificate']]"
		[Register ("generateSignedJWT", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/interfaces/RSAPrivateKey;Ljava/security/interfaces/RSAPublicKey;Ljava/security/cert/X509Certificate;)Ljava/lang/String;", "GetGenerateSignedJWT_Ljava_lang_String_Ljava_lang_String_Ljava_security_interfaces_RSAPrivateKey_Ljava_security_interfaces_RSAPublicKey_Ljava_security_cert_X509Certificate_Handler")]
		public virtual unsafe string GenerateSignedJWT (string nonce, string audience, global::Java.Security.Interfaces.IRSAPrivateKey privateKey, global::Java.Security.Interfaces.IRSAPublicKey pubKey, global::Java.Security.Cert.X509Certificate cert)
		{
			const string __id = "generateSignedJWT.(Ljava/lang/String;Ljava/lang/String;Ljava/security/interfaces/RSAPrivateKey;Ljava/security/interfaces/RSAPublicKey;Ljava/security/cert/X509Certificate;)Ljava/lang/String;";
			IntPtr native_nonce = JNIEnv.NewString (nonce);
			IntPtr native_audience = JNIEnv.NewString (audience);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_nonce);
				__args [1] = new JniArgumentValue (native_audience);
				__args [2] = new JniArgumentValue ((privateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) privateKey).Handle);
				__args [3] = new JniArgumentValue ((pubKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pubKey).Handle);
				__args [4] = new JniArgumentValue ((cert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cert).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_nonce);
				JNIEnv.DeleteLocalRef (native_audience);
				global::System.GC.KeepAlive (privateKey);
				global::System.GC.KeepAlive (pubKey);
				global::System.GC.KeepAlive (cert);
			}
		}

	}
}
