using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/CacheKeyValueDelegate", DoNotGenerateAcw=true)]
	public partial class CacheKeyValueDelegate : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheKeyValueDelegate {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/field[@name='CACHE_VALUE_SEPARATOR']"
		[Register ("CACHE_VALUE_SEPARATOR")]
		public const string CacheValueSeparator = (string) "-";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/CacheKeyValueDelegate", typeof (CacheKeyValueDelegate));

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

		protected CacheKeyValueDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/constructor[@name='CacheKeyValueDelegate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CacheKeyValueDelegate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetFromCacheValue_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FromCacheValue_Ljava_lang_String_Ljava_lang_Class_);
			return cb_fromCacheValue_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_FromCacheValue_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native__string, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @string = JNIEnv.GetString (native__string, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_t, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromCacheValue (@string, t));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/method[@name='fromCacheValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;? extends com.microsoft.identity.common.internal.dto.AccountCredentialBase&gt;']]"
		[Register ("fromCacheValue", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/microsoft/identity/common/internal/dto/AccountCredentialBase;", "GetFromCacheValue_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.internal.dto.AccountCredentialBase"})]
		public virtual unsafe global::Java.Lang.Object FromCacheValue (string @string, global::Java.Lang.Class t)
		{
			const string __id = "fromCacheValue.(Ljava/lang/String;Ljava/lang/Class;)Lcom/microsoft/identity/common/internal/dto/AccountCredentialBase;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_account, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheKey (account));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/method[@name='generateCacheKey' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("generateCacheKey", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;", "GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public virtual unsafe string GenerateCacheKey (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord account)
		{
			const string __id = "generateCacheKey.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (account);
			}
		}

		static Delegate cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_generateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static IntPtr n_GenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credential)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credential = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_credential, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheKey (credential));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/method[@name='generateCacheKey' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("generateCacheKey", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;", "GetGenerateCacheKey_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public virtual unsafe string GenerateCacheKey (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential credential)
		{
			const string __id = "generateCacheKey.(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credential == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credential).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (credential);
			}
		}

		static Delegate cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var account = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_account, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheValue (account));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/method[@name='generateCacheValue' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("generateCacheValue", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;", "GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public virtual unsafe string GenerateCacheValue (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord account)
		{
			const string __id = "generateCacheValue.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (account);
			}
		}

		static Delegate cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_;
#pragma warning disable 0169
		static Delegate GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_Handler ()
		{
			if (cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ == null)
				cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_);
			return cb_generateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_;
		}

		static IntPtr n_GenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credential)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheKeyValueDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credential = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (native_credential, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateCacheValue (credential));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheKeyValueDelegate']/method[@name='generateCacheValue' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.Credential']]"
		[Register ("generateCacheValue", "(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;", "GetGenerateCacheValue_Lcom_microsoft_identity_common_internal_dto_Credential_Handler")]
		public virtual unsafe string GenerateCacheValue (global::Com.Microsoft.Identity.Common.Internal.Dto.Credential credential)
		{
			const string __id = "generateCacheValue.(Lcom/microsoft/identity/common/internal/dto/Credential;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credential == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credential).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (credential);
			}
		}

	}
}
