using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/cache/StorageHelper", DoNotGenerateAcw=true)]
	public partial class StorageHelper : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.IStorageHelper {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/field[@name='DATA_KEY_LENGTH']"
		[Register ("DATA_KEY_LENGTH")]
		public const int DataKeyLength = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/field[@name='HMAC_LENGTH']"
		[Register ("HMAC_LENGTH")]
		public const int HmacLength = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/field[@name='VERSION_ANDROID_KEY_STORE']"
		[Register ("VERSION_ANDROID_KEY_STORE")]
		public const string VersionAndroidKeyStore = (string) "A001";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/field[@name='VERSION_USER_DEFINED']"
		[Register ("VERSION_USER_DEFINED")]
		public const string VersionUserDefined = (string) "U001";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/field[@name='sShouldEncryptWithKeyStoreKey']"
		[Register ("sShouldEncryptWithKeyStoreKey")]
		public const bool SShouldEncryptWithKeyStoreKey = (bool) false;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.EncryptionType']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType", DoNotGenerateAcw=true)]
		public sealed partial class EncryptionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.EncryptionType']/field[@name='ANDROID_KEY_STORE']"
			[Register ("ANDROID_KEY_STORE")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType AndroidKeyStore {
				get {
					const string __id = "ANDROID_KEY_STORE.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.EncryptionType']/field[@name='UNENCRYPTED']"
			[Register ("UNENCRYPTED")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType Unencrypted {
				get {
					const string __id = "UNENCRYPTED.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.EncryptionType']/field[@name='USER_DEFINED']"
			[Register ("USER_DEFINED")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType UserDefined {
				get {
					const string __id = "USER_DEFINED.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType", typeof (EncryptionType));

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

			internal EncryptionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.EncryptionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.EncryptionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType", DoNotGenerateAcw=true)]
		public sealed partial class KeyType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']/field[@name='ADAL_USER_DEFINED_KEY']"
			[Register ("ADAL_USER_DEFINED_KEY")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType AdalUserDefinedKey {
				get {
					const string __id = "ADAL_USER_DEFINED_KEY.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']/field[@name='KEYSTORE_ENCRYPTED_KEY']"
			[Register ("KEYSTORE_ENCRYPTED_KEY")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType KeystoreEncryptedKey {
				get {
					const string __id = "KEYSTORE_ENCRYPTED_KEY.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']/field[@name='LEGACY_AUTHENTICATOR_APP_KEY']"
			[Register ("LEGACY_AUTHENTICATOR_APP_KEY")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType LegacyAuthenticatorAppKey {
				get {
					const string __id = "LEGACY_AUTHENTICATOR_APP_KEY.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']/field[@name='LEGACY_COMPANY_PORTAL_KEY']"
			[Register ("LEGACY_COMPANY_PORTAL_KEY")]
			public static global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType LegacyCompanyPortalKey {
				get {
					const string __id = "LEGACY_COMPANY_PORTAL_KEY.Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType", typeof (KeyType));

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

			internal KeyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper.KeyType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/cache/StorageHelper", typeof (StorageHelper));

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

		protected StorageHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/constructor[@name='StorageHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe StorageHelper (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/constructor[@name='StorageHelper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.microsoft.identity.common.adal.internal.cache.IWpjTelemetryCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/microsoft/identity/common/adal/internal/cache/IWpjTelemetryCallback;)V", "")]
		public unsafe StorageHelper (global::Android.Content.Context context, global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.IWpjTelemetryCallback telemetryCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/microsoft/identity/common/adal/internal/cache/IWpjTelemetryCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((telemetryCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) telemetryCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (telemetryCallback);
			}
		}

		static Delegate cb_isBrokerProcess;
#pragma warning disable 0169
		static Delegate GetIsBrokerProcessHandler ()
		{
			if (cb_isBrokerProcess == null)
				cb_isBrokerProcess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBrokerProcess);
			return cb_isBrokerProcess;
		}

		static bool n_IsBrokerProcess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBrokerProcess;
		}
#pragma warning restore 0169

		protected virtual unsafe bool IsBrokerProcess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='isBrokerProcess' and count(parameter)=0]"
			[Register ("isBrokerProcess", "()Z", "GetIsBrokerProcessHandler")]
			get {
				const string __id = "isBrokerProcess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		protected virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='applyKeyStoreLocaleWorkarounds' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("applyKeyStoreLocaleWorkarounds", "(Ljava/util/Locale;)V", "")]
		public static unsafe void ApplyKeyStoreLocaleWorkarounds (global::Java.Util.Locale currentLocale)
		{
			const string __id = "applyKeyStoreLocaleWorkarounds.(Ljava/util/Locale;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((currentLocale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) currentLocale).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (currentLocale);
			}
		}

		static Delegate cb_decrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_lang_String_Handler ()
		{
			if (cb_decrypt_Ljava_lang_String_ == null)
				cb_decrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_Ljava_lang_String_);
			return cb_decrypt_Ljava_lang_String_;
		}

		static IntPtr n_Decrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encryptedBlob)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var encryptedBlob = JNIEnv.GetString (native_encryptedBlob, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decrypt (encryptedBlob));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecrypt_Ljava_lang_String_Handler")]
		public virtual unsafe string Decrypt (string encryptedBlob)
		{
			const string __id = "decrypt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_encryptedBlob = JNIEnv.NewString (encryptedBlob);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_encryptedBlob);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_encryptedBlob);
			}
		}

		static Delegate cb_deleteKeyFile;
#pragma warning disable 0169
		static Delegate GetDeleteKeyFileHandler ()
		{
			if (cb_deleteKeyFile == null)
				cb_deleteKeyFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DeleteKeyFile);
			return cb_deleteKeyFile;
		}

		static void n_DeleteKeyFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteKeyFile ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='deleteKeyFile' and count(parameter)=0]"
		[Register ("deleteKeyFile", "()V", "GetDeleteKeyFileHandler")]
		public virtual unsafe void DeleteKeyFile ()
		{
			const string __id = "deleteKeyFile.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deserializeSecretKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeserializeSecretKey_Ljava_lang_String_Handler ()
		{
			if (cb_deserializeSecretKey_Ljava_lang_String_ == null)
				cb_deserializeSecretKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeserializeSecretKey_Ljava_lang_String_);
			return cb_deserializeSecretKey_Ljava_lang_String_;
		}

		static IntPtr n_DeserializeSecretKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serializedKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serializedKey = JNIEnv.GetString (native_serializedKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeserializeSecretKey (serializedKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='deserializeSecretKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deserializeSecretKey", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", "GetDeserializeSecretKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Javax.Crypto.ISecretKey DeserializeSecretKey (string serializedKey)
		{
			const string __id = "deserializeSecretKey.(Ljava/lang/String;)Ljavax/crypto/SecretKey;";
			IntPtr native_serializedKey = JNIEnv.NewString (serializedKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serializedKey);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_serializedKey);
			}
		}

		static Delegate cb_encrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncrypt_Ljava_lang_String_Handler ()
		{
			if (cb_encrypt_Ljava_lang_String_ == null)
				cb_encrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_Ljava_lang_String_);
			return cb_encrypt_Ljava_lang_String_;
		}

		static IntPtr n_Encrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clearText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clearText = JNIEnv.GetString (native_clearText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encrypt (clearText));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncrypt_Ljava_lang_String_Handler")]
		public virtual unsafe string Encrypt (string clearText)
		{
			const string __id = "encrypt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_clearText = JNIEnv.NewString (clearText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_clearText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_clearText);
			}
		}

		static Delegate cb_generateKeyStoreEncryptedKey;
#pragma warning disable 0169
		static Delegate GetGenerateKeyStoreEncryptedKeyHandler ()
		{
			if (cb_generateKeyStoreEncryptedKey == null)
				cb_generateKeyStoreEncryptedKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GenerateKeyStoreEncryptedKey);
			return cb_generateKeyStoreEncryptedKey;
		}

		static IntPtr n_GenerateKeyStoreEncryptedKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateKeyStoreEncryptedKey ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='generateKeyStoreEncryptedKey' and count(parameter)=0]"
		[Register ("generateKeyStoreEncryptedKey", "()Ljavax/crypto/SecretKey;", "GetGenerateKeyStoreEncryptedKeyHandler")]
		public virtual unsafe global::Javax.Crypto.ISecretKey GenerateKeyStoreEncryptedKey ()
		{
			const string __id = "generateKeyStoreEncryptedKey.()Ljavax/crypto/SecretKey;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_generateSecretKey;
#pragma warning disable 0169
		static Delegate GetGenerateSecretKeyHandler ()
		{
			if (cb_generateSecretKey == null)
				cb_generateSecretKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GenerateSecretKey);
			return cb_generateSecretKey;
		}

		static IntPtr n_GenerateSecretKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateSecretKey ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='generateSecretKey' and count(parameter)=0]"
		[Register ("generateSecretKey", "()Ljavax/crypto/SecretKey;", "GetGenerateSecretKeyHandler")]
		protected virtual unsafe global::Javax.Crypto.ISecretKey GenerateSecretKey ()
		{
			const string __id = "generateSecretKey.()Ljavax/crypto/SecretKey;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEncryptionType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEncryptionType_Ljava_lang_String_Handler ()
		{
			if (cb_getEncryptionType_Ljava_lang_String_ == null)
				cb_getEncryptionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEncryptionType_Ljava_lang_String_);
			return cb_getEncryptionType_Ljava_lang_String_;
		}

		static IntPtr n_GetEncryptionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEncryptionType (data));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='getEncryptionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEncryptionType", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;", "GetGetEncryptionType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType GetEncryptionType (string data)
		{
			const string __id = "getEncryptionType.(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$EncryptionType;";
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.EncryptionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static Delegate cb_getKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_);
			return cb_getKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encryptedBlob, IntPtr native_packageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var encryptedBlob = JNIEnv.GetString (native_encryptedBlob, JniHandleOwnership.DoNotTransfer);
			var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType>.ToLocalJniHandle (__this.GetKeysForDecryptionType (encryptedBlob, packageName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='getKeysForDecryptionType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getKeysForDecryptionType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetKeysForDecryptionType_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> GetKeysForDecryptionType (string encryptedBlob, string packageName)
		{
			const string __id = "getKeysForDecryptionType.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_encryptedBlob = JNIEnv.NewString (encryptedBlob);
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_encryptedBlob);
				__args [1] = new JniArgumentValue (native_packageName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_encryptedBlob);
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_loadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_;
#pragma warning disable 0169
		static Delegate GetLoadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_Handler ()
		{
			if (cb_loadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_ == null)
				cb_loadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LoadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_);
			return cb_loadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_;
		}

		static IntPtr n_LoadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_keyType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var keyType = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType> (native_keyType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadSecretKey (keyType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='loadSecretKey' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.adal.internal.cache.StorageHelper.KeyType']]"
		[Register ("loadSecretKey", "(Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;)Ljavax/crypto/SecretKey;", "GetLoadSecretKey_Lcom_microsoft_identity_common_adal_internal_cache_StorageHelper_KeyType_Handler")]
		public virtual unsafe global::Javax.Crypto.ISecretKey LoadSecretKey (global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper.KeyType keyType)
		{
			const string __id = "loadSecretKey.(Lcom/microsoft/identity/common/adal/internal/cache/StorageHelper$KeyType;)Ljavax/crypto/SecretKey;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (keyType);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadSecretKeyForEncryption ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='loadSecretKeyForEncryption' and count(parameter)=0]"
		[Register ("loadSecretKeyForEncryption", "()Ljavax/crypto/SecretKey;", "GetLoadSecretKeyForEncryptionHandler")]
		public virtual unsafe global::Javax.Crypto.ISecretKey LoadSecretKeyForEncryption ()
		{
			const string __id = "loadSecretKeyForEncryption.()Ljavax/crypto/SecretKey;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resetKeyPairFromAndroidKeyStore;
#pragma warning disable 0169
		static Delegate GetResetKeyPairFromAndroidKeyStoreHandler ()
		{
			if (cb_resetKeyPairFromAndroidKeyStore == null)
				cb_resetKeyPairFromAndroidKeyStore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetKeyPairFromAndroidKeyStore);
			return cb_resetKeyPairFromAndroidKeyStore;
		}

		static void n_ResetKeyPairFromAndroidKeyStore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetKeyPairFromAndroidKeyStore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='resetKeyPairFromAndroidKeyStore' and count(parameter)=0]"
		[Register ("resetKeyPairFromAndroidKeyStore", "()V", "GetResetKeyPairFromAndroidKeyStoreHandler")]
		protected virtual unsafe void ResetKeyPairFromAndroidKeyStore ()
		{
			const string __id = "resetKeyPairFromAndroidKeyStore.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_saveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_;
#pragma warning disable 0169
		static Delegate GetSaveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_Handler ()
		{
			if (cb_saveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_ == null)
				cb_saveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_);
			return cb_saveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_;
		}

		static void n_SaveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unencryptedKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unencryptedKey = (global::Javax.Crypto.ISecretKey)global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (native_unencryptedKey, JniHandleOwnership.DoNotTransfer);
			__this.SaveKeyStoreEncryptedKey (unencryptedKey);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='saveKeyStoreEncryptedKey' and count(parameter)=1 and parameter[1][@type='javax.crypto.SecretKey']]"
		[Register ("saveKeyStoreEncryptedKey", "(Ljavax/crypto/SecretKey;)V", "GetSaveKeyStoreEncryptedKey_Ljavax_crypto_SecretKey_Handler")]
		public virtual unsafe void SaveKeyStoreEncryptedKey (global::Javax.Crypto.ISecretKey unencryptedKey)
		{
			const string __id = "saveKeyStoreEncryptedKey.(Ljavax/crypto/SecretKey;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unencryptedKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unencryptedKey).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (unencryptedKey);
			}
		}

		static Delegate cb_serializeSecretKey_Ljavax_crypto_SecretKey_;
#pragma warning disable 0169
		static Delegate GetSerializeSecretKey_Ljavax_crypto_SecretKey_Handler ()
		{
			if (cb_serializeSecretKey_Ljavax_crypto_SecretKey_ == null)
				cb_serializeSecretKey_Ljavax_crypto_SecretKey_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SerializeSecretKey_Ljavax_crypto_SecretKey_);
			return cb_serializeSecretKey_Ljavax_crypto_SecretKey_;
		}

		static IntPtr n_SerializeSecretKey_Ljavax_crypto_SecretKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = (global::Javax.Crypto.ISecretKey)global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SerializeSecretKey (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='serializeSecretKey' and count(parameter)=1 and parameter[1][@type='javax.crypto.SecretKey']]"
		[Register ("serializeSecretKey", "(Ljavax/crypto/SecretKey;)Ljava/lang/String;", "GetSerializeSecretKey_Ljavax_crypto_SecretKey_Handler")]
		public virtual unsafe string SerializeSecretKey (global::Javax.Crypto.ISecretKey key)
		{
			const string __id = "serializeSecretKey.(Ljavax/crypto/SecretKey;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

		static Delegate cb_setBlobVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBlobVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setBlobVersion_Ljava_lang_String_ == null)
				cb_setBlobVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBlobVersion_Ljava_lang_String_);
			return cb_setBlobVersion_Ljava_lang_String_;
		}

		static void n_SetBlobVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_blobVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.StorageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var blobVersion = JNIEnv.GetString (native_blobVersion, JniHandleOwnership.DoNotTransfer);
			__this.SetBlobVersion (blobVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='StorageHelper']/method[@name='setBlobVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBlobVersion", "(Ljava/lang/String;)V", "GetSetBlobVersion_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetBlobVersion (string blobVersion)
		{
			const string __id = "setBlobVersion.(Ljava/lang/String;)V";
			IntPtr native_blobVersion = JNIEnv.NewString (blobVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_blobVersion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_blobVersion);
			}
		}

	}
}
