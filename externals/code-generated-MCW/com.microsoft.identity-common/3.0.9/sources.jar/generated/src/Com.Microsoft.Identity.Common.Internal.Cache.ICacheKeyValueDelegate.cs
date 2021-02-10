using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheKeyValueDelegate']"
	[Register ("com/microsoft/identity/common/internal/cache/ICacheKeyValueDelegate", "", "Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegateInvoker")]
	public partial interface ICacheKeyValueDelegate : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheKeyValueDelegate']/method[@name='fromCacheValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;? extends com.microsoft.identity.common.internal.dto.AccountCredentialBase&gt;']]"
		[Register ("fromCacheValue", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/microsoft/identity/common/internal/dto/AccountCredentialBase;", "GetFromCacheValue_Ljava_lang_String_Ljava_lang_Class_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegateInvoker, Microsoft.Identity.Common")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.internal.dto.AccountCredentialBase"})]
		global::Java.Lang.Object FromCacheValue (string p0, global::Java.Lang.Class p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheKeyValueDelegate']/method[@name='generateCacheKey' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("generateCacheKey", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;", "GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegateInvoker, Microsoft.Identity.Common")]
		string GenerateCacheKey (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheKeyValueDelegate']/method[@name='generateCacheKey' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("generateCacheKey", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;", "GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegateInvoker, Microsoft.Identity.Common")]
		string GenerateCacheKey (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheKeyValueDelegate']/method[@name='generateCacheValue' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("generateCacheValue", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;", "GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegateInvoker, Microsoft.Identity.Common")]
		string GenerateCacheValue (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheKeyValueDelegate']/method[@name='generateCacheValue' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("generateCacheValue", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;", "GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegateInvoker, Microsoft.Identity.Common")]
		string GenerateCacheValue (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/ICacheKeyValueDelegate", DoNotGenerateAcw=true)]
	internal partial class ICacheKeyValueDelegateInvoker : global::Java.Lang.Object, ICacheKeyValueDelegate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/ICacheKeyValueDelegate", typeof (ICacheKeyValueDelegateInvoker));

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

		public static ICacheKeyValueDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICacheKeyValueDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.ICacheKeyValueDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheKeyValueDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetFromCacheValue_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FromCacheValue_Ljava_lang_String_Ljava_lang_Class_);
			return cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_FromCacheValue_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromCacheValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_;
		public unsafe global::Java.Lang.Object FromCacheValue (string p0, global::Java.Lang.Class p1)
		{
			if (id_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromCacheValue", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/microsoft/identity/common/internal/dto/AccountCredentialBase;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		public unsafe string GenerateCacheKey (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0)
		{
			if (id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == IntPtr.Zero)
				id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNIEnv.GetMethodID (class_ref, "generateCacheKey", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static IntPtr n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_;
		public unsafe string GenerateCacheKey (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0)
		{
			if (id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ == IntPtr.Zero)
				id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNIEnv.GetMethodID (class_ref, "generateCacheKey", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		public unsafe string GenerateCacheValue (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord p0)
		{
			if (id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == IntPtr.Zero)
				id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNIEnv.GetMethodID (class_ref, "generateCacheValue", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static IntPtr n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_;
		public unsafe string GenerateCacheValue (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential p0)
		{
			if (id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ == IntPtr.Zero)
				id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNIEnv.GetMethodID (class_ref, "generateCacheValue", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
