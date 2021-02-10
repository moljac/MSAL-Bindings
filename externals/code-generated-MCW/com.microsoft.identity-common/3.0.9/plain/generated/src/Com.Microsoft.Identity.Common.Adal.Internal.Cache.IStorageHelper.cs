using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/interface[@name='IStorageHelper']"
	[Register ("com/microsoft/identity/common/adal/internal/cache/IStorageHelper", "", "Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelperInvoker")]
	public partial interface IStorageHelper : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/interface[@name='IStorageHelper']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecrypt_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelperInvoker, Microsoft.Identity.Common")]
		string Decrypt (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/interface[@name='IStorageHelper']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncrypt_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelperInvoker, Microsoft.Identity.Common")]
		string Encrypt (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/interface[@name='IStorageHelper']/method[@name='loadSecretKeyForEncryption' and count(parameter)=0]"
		[Register ("loadSecretKeyForEncryption", "()Ljavax/crypto/SecretKey;", "GetLoadSecretKeyForEncryptionHandler:Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelperInvoker, Microsoft.Identity.Common")]
		global::Javax.Crypto.ISecretKey LoadSecretKeyForEncryption ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/cache/IStorageHelper", DoNotGenerateAcw=true)]
	internal partial class IStorageHelperInvoker : global::Java.Lang.Object, IStorageHelper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/cache/IStorageHelper", typeof (IStorageHelperInvoker));

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

		public static IStorageHelper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorageHelper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.cache.IStorageHelper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorageHelperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_decrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_lang_String_Handler ()
		{
			if (cb_decrypt_Ljava_lang_String_ == null)
				cb_decrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_Ljava_lang_String_);
			return cb_decrypt_Ljava_lang_String_;
		}

		static IntPtr n_Decrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decrypt_Ljava_lang_String_;
		public unsafe string Decrypt (string p0)
		{
			if (id_decrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_encrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncrypt_Ljava_lang_String_Handler ()
		{
			if (cb_encrypt_Ljava_lang_String_ == null)
				cb_encrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_Ljava_lang_String_);
			return cb_encrypt_Ljava_lang_String_;
		}

		static IntPtr n_Encrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encrypt_Ljava_lang_String_;
		public unsafe string Encrypt (string p0)
		{
			if (id_encrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_loadSecretKeyForEncryption;
#pragma warning disable 0169
		static Delegate GetLoadSecretKeyForEncryptionHandler ()
		{
			if (cb_loadSecretKeyForEncryption == null)
				cb_loadSecretKeyForEncryption = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LoadSecretKeyForEncryption);
			return cb_loadSecretKeyForEncryption;
		}

		static IntPtr n_LoadSecretKeyForEncryption (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadSecretKeyForEncryption ());
		}
#pragma warning restore 0169

		IntPtr id_loadSecretKeyForEncryption;
		public unsafe global::Javax.Crypto.ISecretKey LoadSecretKeyForEncryption ()
		{
			if (id_loadSecretKeyForEncryption == IntPtr.Zero)
				id_loadSecretKeyForEncryption = JNIEnv.GetMethodID (class_ref, "loadSecretKeyForEncryption", "()Ljavax/crypto/SecretKey;");
			return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadSecretKeyForEncryption), JniHandleOwnership.TransferLocalRef);
		}

	}
}
