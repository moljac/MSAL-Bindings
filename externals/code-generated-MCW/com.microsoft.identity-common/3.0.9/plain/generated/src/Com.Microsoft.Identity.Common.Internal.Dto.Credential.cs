using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/Credential", DoNotGenerateAcw=true)]
	public abstract partial class Credential : global::Com.Microsoft.Identity.Common.Internal.Dto.AccountCredentialBase {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/Credential$SerializedNames", DoNotGenerateAcw=true)]
		public partial class SerializedNames : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='CACHED_AT']"
			[Register ("CACHED_AT")]
			public const string CachedAt = (string) "cached_at";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public const string ClientId = (string) "client_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='CREDENTIAL_TYPE']"
			[Register ("CREDENTIAL_TYPE")]
			public const string CredentialType = (string) "credential_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='ENVIRONMENT']"
			[Register ("ENVIRONMENT")]
			public const string Environment = (string) "environment";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='EXPIRES_ON']"
			[Register ("EXPIRES_ON")]
			public const string ExpiresOn = (string) "expires_on";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='HOME_ACCOUNT_ID']"
			[Register ("HOME_ACCOUNT_ID")]
			public const string HomeAccountId = (string) "home_account_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/field[@name='SECRET']"
			[Register ("SECRET")]
			public const string Secret = (string) "secret";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/Credential$SerializedNames", typeof (SerializedNames));

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

			protected SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential.SerializedNames']/constructor[@name='Credential.SerializedNames' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SerializedNames () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/Credential", typeof (Credential));

		internal static new IntPtr class_ref {
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

		protected Credential (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/constructor[@name='Credential' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Credential () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCachedAt;
#pragma warning disable 0169
		static Delegate GetGetCachedAtHandler ()
		{
			if (cb_getCachedAt == null)
				cb_getCachedAt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCachedAt);
			return cb_getCachedAt;
		}

		static IntPtr n_GetCachedAt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CachedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCachedAt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCachedAt_Ljava_lang_String_Handler ()
		{
			if (cb_setCachedAt_Ljava_lang_String_ == null)
				cb_setCachedAt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCachedAt_Ljava_lang_String_);
			return cb_setCachedAt_Ljava_lang_String_;
		}

		static void n_SetCachedAt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cachedAt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cachedAt = JNIEnv.GetString (native_cachedAt, JniHandleOwnership.DoNotTransfer);
			__this.CachedAt = cachedAt;
		}
#pragma warning restore 0169

		public virtual unsafe string CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()Ljava/lang/String;", "GetGetCachedAtHandler")]
			get {
				const string __id = "getCachedAt.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='setCachedAt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCachedAt", "(Ljava/lang/String;)V", "GetSetCachedAt_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCachedAt.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientId_Ljava_lang_String_ == null)
				cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientId_Ljava_lang_String_);
			return cb_setClientId_Ljava_lang_String_;
		}

		static void n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = clientId;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientId", "(Ljava/lang/String;)V", "GetSetClientId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCredentialType;
#pragma warning disable 0169
		static Delegate GetGetCredentialTypeHandler ()
		{
			if (cb_getCredentialType == null)
				cb_getCredentialType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCredentialType);
			return cb_getCredentialType;
		}

		static IntPtr n_GetCredentialType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CredentialType);
		}
#pragma warning restore 0169

		static Delegate cb_setCredentialType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCredentialType_Ljava_lang_String_Handler ()
		{
			if (cb_setCredentialType_Ljava_lang_String_ == null)
				cb_setCredentialType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCredentialType_Ljava_lang_String_);
			return cb_setCredentialType_Ljava_lang_String_;
		}

		static void n_SetCredentialType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credentialType = JNIEnv.GetString (native_credentialType, JniHandleOwnership.DoNotTransfer);
			__this.CredentialType = credentialType;
		}
#pragma warning restore 0169

		public virtual unsafe string CredentialType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='getCredentialType' and count(parameter)=0]"
			[Register ("getCredentialType", "()Ljava/lang/String;", "GetGetCredentialTypeHandler")]
			get {
				const string __id = "getCredentialType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='setCredentialType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCredentialType", "(Ljava/lang/String;)V", "GetSetCredentialType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCredentialType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnvironment);
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		static Delegate cb_setEnvironment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEnvironment_Ljava_lang_String_Handler ()
		{
			if (cb_setEnvironment_Ljava_lang_String_ == null)
				cb_setEnvironment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEnvironment_Ljava_lang_String_);
			return cb_setEnvironment_Ljava_lang_String_;
		}

		static void n_SetEnvironment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_environment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			__this.Environment = environment;
		}
#pragma warning restore 0169

		public virtual unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get {
				const string __id = "getEnvironment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEnvironment", "(Ljava/lang/String;)V", "GetSetEnvironment_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEnvironment.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHomeAccountId;
#pragma warning disable 0169
		static Delegate GetGetHomeAccountIdHandler ()
		{
			if (cb_getHomeAccountId == null)
				cb_getHomeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHomeAccountId);
			return cb_getHomeAccountId;
		}

		static IntPtr n_GetHomeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		static Delegate cb_setHomeAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHomeAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_setHomeAccountId_Ljava_lang_String_ == null)
				cb_setHomeAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHomeAccountId_Ljava_lang_String_);
			return cb_setHomeAccountId_Ljava_lang_String_;
		}

		static void n_SetHomeAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_homeAccountId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
			__this.HomeAccountId = homeAccountId;
		}
#pragma warning restore 0169

		public virtual unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get {
				const string __id = "getHomeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='setHomeAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHomeAccountId", "(Ljava/lang/String;)V", "GetSetHomeAccountId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHomeAccountId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isExpired;
#pragma warning disable 0169
		static Delegate GetIsExpiredHandler ()
		{
			if (cb_isExpired == null)
				cb_isExpired = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExpired);
			return cb_isExpired;
		}

		static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		public abstract bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get; 
		}

		static Delegate cb_getSecret;
#pragma warning disable 0169
		static Delegate GetGetSecretHandler ()
		{
			if (cb_getSecret == null)
				cb_getSecret = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecret);
			return cb_getSecret;
		}

		static IntPtr n_GetSecret (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Secret);
		}
#pragma warning restore 0169

		static Delegate cb_setSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setSecret_Ljava_lang_String_ == null)
				cb_setSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSecret_Ljava_lang_String_);
			return cb_setSecret_Ljava_lang_String_;
		}

		static void n_SetSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secret)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.Credential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var secret = JNIEnv.GetString (native_secret, JniHandleOwnership.DoNotTransfer);
			__this.Secret = secret;
		}
#pragma warning restore 0169

		public virtual unsafe string Secret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='getSecret' and count(parameter)=0]"
			[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
			get {
				const string __id = "getSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='setSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecret", "(Ljava/lang/String;)V", "GetSetSecret_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecret.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/Credential", DoNotGenerateAcw=true)]
	internal partial class CredentialInvoker : Credential {
		public CredentialInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/Credential", typeof (CredentialInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='Credential']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				const string __id = "isExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
