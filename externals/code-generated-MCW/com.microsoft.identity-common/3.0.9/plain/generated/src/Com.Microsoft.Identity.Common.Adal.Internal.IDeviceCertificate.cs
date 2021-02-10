using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/interface[@name='IDeviceCertificate']"
	[Register ("com/microsoft/identity/common/adal/internal/IDeviceCertificate", "", "Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificateInvoker")]
	public partial interface IDeviceCertificate : IJavaObject, IJavaPeerable {
		global::Java.Security.Cert.X509Certificate Certificate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/interface[@name='IDeviceCertificate']/method[@name='getCertificate' and count(parameter)=0]"
			[Register ("getCertificate", "()Ljava/security/cert/X509Certificate;", "GetGetCertificateHandler:Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificateInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Java.Security.Interfaces.IRSAPrivateKey RSAPrivateKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/interface[@name='IDeviceCertificate']/method[@name='getRSAPrivateKey' and count(parameter)=0]"
			[Register ("getRSAPrivateKey", "()Ljava/security/interfaces/RSAPrivateKey;", "GetGetRSAPrivateKeyHandler:Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificateInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Java.Security.Interfaces.IRSAPublicKey RSAPublicKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/interface[@name='IDeviceCertificate']/method[@name='getRSAPublicKey' and count(parameter)=0]"
			[Register ("getRSAPublicKey", "()Ljava/security/interfaces/RSAPublicKey;", "GetGetRSAPublicKeyHandler:Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificateInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string ThumbPrint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/interface[@name='IDeviceCertificate']/method[@name='getThumbPrint' and count(parameter)=0]"
			[Register ("getThumbPrint", "()Ljava/lang/String;", "GetGetThumbPrintHandler:Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificateInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/interface[@name='IDeviceCertificate']/method[@name='isValidIssuer' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("isValidIssuer", "(Ljava/util/List;)Z", "GetIsValidIssuer_Ljava_util_List_Handler:Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificateInvoker, Microsoft.Identity.Common")]
		bool IsValidIssuer (global::System.Collections.Generic.IList<string> p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/IDeviceCertificate", DoNotGenerateAcw=true)]
	internal partial class IDeviceCertificateInvoker : global::Java.Lang.Object, IDeviceCertificate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/IDeviceCertificate", typeof (IDeviceCertificateInvoker));

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

		public static IDeviceCertificate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceCertificate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.IDeviceCertificate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceCertificateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCertificate;
#pragma warning disable 0169
		static Delegate GetGetCertificateHandler ()
		{
			if (cb_getCertificate == null)
				cb_getCertificate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCertificate);
			return cb_getCertificate;
		}

		static IntPtr n_GetCertificate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Certificate);
		}
#pragma warning restore 0169

		IntPtr id_getCertificate;
		public unsafe global::Java.Security.Cert.X509Certificate Certificate {
			get {
				if (id_getCertificate == IntPtr.Zero)
					id_getCertificate = JNIEnv.GetMethodID (class_ref, "getCertificate", "()Ljava/security/cert/X509Certificate;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRSAPrivateKey;
#pragma warning disable 0169
		static Delegate GetGetRSAPrivateKeyHandler ()
		{
			if (cb_getRSAPrivateKey == null)
				cb_getRSAPrivateKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRSAPrivateKey);
			return cb_getRSAPrivateKey;
		}

		static IntPtr n_GetRSAPrivateKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSAPrivateKey);
		}
#pragma warning restore 0169

		IntPtr id_getRSAPrivateKey;
		public unsafe global::Java.Security.Interfaces.IRSAPrivateKey RSAPrivateKey {
			get {
				if (id_getRSAPrivateKey == IntPtr.Zero)
					id_getRSAPrivateKey = JNIEnv.GetMethodID (class_ref, "getRSAPrivateKey", "()Ljava/security/interfaces/RSAPrivateKey;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.Interfaces.IRSAPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSAPrivateKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRSAPublicKey;
#pragma warning disable 0169
		static Delegate GetGetRSAPublicKeyHandler ()
		{
			if (cb_getRSAPublicKey == null)
				cb_getRSAPublicKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRSAPublicKey);
			return cb_getRSAPublicKey;
		}

		static IntPtr n_GetRSAPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSAPublicKey);
		}
#pragma warning restore 0169

		IntPtr id_getRSAPublicKey;
		public unsafe global::Java.Security.Interfaces.IRSAPublicKey RSAPublicKey {
			get {
				if (id_getRSAPublicKey == IntPtr.Zero)
					id_getRSAPublicKey = JNIEnv.GetMethodID (class_ref, "getRSAPublicKey", "()Ljava/security/interfaces/RSAPublicKey;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.Interfaces.IRSAPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSAPublicKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThumbPrint;
#pragma warning disable 0169
		static Delegate GetGetThumbPrintHandler ()
		{
			if (cb_getThumbPrint == null)
				cb_getThumbPrint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThumbPrint);
			return cb_getThumbPrint;
		}

		static IntPtr n_GetThumbPrint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThumbPrint);
		}
#pragma warning restore 0169

		IntPtr id_getThumbPrint;
		public unsafe string ThumbPrint {
			get {
				if (id_getThumbPrint == IntPtr.Zero)
					id_getThumbPrint = JNIEnv.GetMethodID (class_ref, "getThumbPrint", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThumbPrint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isValidIssuer_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetIsValidIssuer_Ljava_util_List_Handler ()
		{
			if (cb_isValidIssuer_Ljava_util_List_ == null)
				cb_isValidIssuer_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsValidIssuer_Ljava_util_List_);
			return cb_isValidIssuer_Ljava_util_List_;
		}

		static bool n_IsValidIssuer_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.IDeviceCertificate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsValidIssuer (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isValidIssuer_Ljava_util_List_;
		public unsafe bool IsValidIssuer (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_isValidIssuer_Ljava_util_List_ == IntPtr.Zero)
				id_isValidIssuer_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "isValidIssuer", "(Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValidIssuer_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
