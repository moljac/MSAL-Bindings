using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/AccessTokenRecord", DoNotGenerateAcw=true)]
	public partial class AccessTokenRecord : global::Com.Microsoft.Identity.Common.Internal.Dto.Credential {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/AccessTokenRecord$SerializedNames", DoNotGenerateAcw=true)]
		public new partial class SerializedNames : global::Com.Microsoft.Identity.Common.Internal.Dto.Credential.SerializedNames {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='ACCESS_TOKEN_TYPE']"
			[Register ("ACCESS_TOKEN_TYPE")]
			[Obsolete ("deprecated")]
			public const string AccessTokenType = (string) "access_token_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='AUTHORITY']"
			[Register ("AUTHORITY")]
			public const string Authority = (string) "authority";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='EXTENDED_EXPIRES_ON']"
			[Register ("EXTENDED_EXPIRES_ON")]
			public const string ExtendedExpiresOn = (string) "extended_expires_on";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='KID']"
			[Register ("KID")]
			public const string Kid = (string) "kid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='REALM']"
			[Register ("REALM")]
			public const string Realm = (string) "realm";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='TARGET']"
			[Register ("TARGET")]
			public const string Target = (string) "target";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/field[@name='TOKEN_TYPE']"
			[Register ("TOKEN_TYPE")]
			public const string TokenType = (string) "token_type";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/AccessTokenRecord$SerializedNames", typeof (SerializedNames));

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

			protected SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord.SerializedNames']/constructor[@name='AccessTokenRecord.SerializedNames' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/AccessTokenRecord", typeof (AccessTokenRecord));

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

		protected AccessTokenRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/constructor[@name='AccessTokenRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccessTokenRecord () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAccessTokenType;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenTypeHandler ()
		{
			if (cb_getAccessTokenType == null)
				cb_getAccessTokenType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccessTokenType);
			return cb_getAccessTokenType;
		}

		static IntPtr n_GetAccessTokenType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessTokenType);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessTokenType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessTokenType_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessTokenType_Ljava_lang_String_ == null)
				cb_setAccessTokenType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccessTokenType_Ljava_lang_String_);
			return cb_setAccessTokenType_Ljava_lang_String_;
		}

		static void n_SetAccessTokenType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessTokenType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accessTokenType = JNIEnv.GetString (native_accessTokenType, JniHandleOwnership.DoNotTransfer);
			__this.AccessTokenType = accessTokenType;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessTokenType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getAccessTokenType' and count(parameter)=0]"
			[Register ("getAccessTokenType", "()Ljava/lang/String;", "GetGetAccessTokenTypeHandler")]
			get {
				const string __id = "getAccessTokenType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setAccessTokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessTokenType", "(Ljava/lang/String;)V", "GetSetAccessTokenType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessTokenType.(Ljava/lang/String;)V";
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

		static Delegate cb_getAuthority;
#pragma warning disable 0169
		static Delegate GetGetAuthorityHandler ()
		{
			if (cb_getAuthority == null)
				cb_getAuthority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthority);
			return cb_getAuthority;
		}

		static IntPtr n_GetAuthority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Authority);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthority_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthority_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthority_Ljava_lang_String_ == null)
				cb_setAuthority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthority_Ljava_lang_String_);
			return cb_setAuthority_Ljava_lang_String_;
		}

		static void n_SetAuthority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			__this.Authority = authority;
		}
#pragma warning restore 0169

		public virtual unsafe string Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getAuthority' and count(parameter)=0]"
			[Register ("getAuthority", "()Ljava/lang/String;", "GetGetAuthorityHandler")]
			get {
				const string __id = "getAuthority.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setAuthority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthority", "(Ljava/lang/String;)V", "GetSetAuthority_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthority.(Ljava/lang/String;)V";
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

		static Delegate cb_getExpiresOn;
#pragma warning disable 0169
		static Delegate GetGetExpiresOnHandler ()
		{
			if (cb_getExpiresOn == null)
				cb_getExpiresOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExpiresOn);
			return cb_getExpiresOn;
		}

		static IntPtr n_GetExpiresOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpiresOn);
		}
#pragma warning restore 0169

		static Delegate cb_setExpiresOn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpiresOn_Ljava_lang_String_Handler ()
		{
			if (cb_setExpiresOn_Ljava_lang_String_ == null)
				cb_setExpiresOn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpiresOn_Ljava_lang_String_);
			return cb_setExpiresOn_Ljava_lang_String_;
		}

		static void n_SetExpiresOn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expiresOn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var expiresOn = JNIEnv.GetString (native_expiresOn, JniHandleOwnership.DoNotTransfer);
			__this.ExpiresOn = expiresOn;
		}
#pragma warning restore 0169

		public virtual unsafe string ExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getExpiresOn' and count(parameter)=0]"
			[Register ("getExpiresOn", "()Ljava/lang/String;", "GetGetExpiresOnHandler")]
			get {
				const string __id = "getExpiresOn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setExpiresOn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExpiresOn", "(Ljava/lang/String;)V", "GetSetExpiresOn_Ljava_lang_String_Handler")]
			set {
				const string __id = "setExpiresOn.(Ljava/lang/String;)V";
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

		static Delegate cb_getExtendedExpiresOn;
#pragma warning disable 0169
		static Delegate GetGetExtendedExpiresOnHandler ()
		{
			if (cb_getExtendedExpiresOn == null)
				cb_getExtendedExpiresOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtendedExpiresOn);
			return cb_getExtendedExpiresOn;
		}

		static IntPtr n_GetExtendedExpiresOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExtendedExpiresOn);
		}
#pragma warning restore 0169

		static Delegate cb_setExtendedExpiresOn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtendedExpiresOn_Ljava_lang_String_Handler ()
		{
			if (cb_setExtendedExpiresOn_Ljava_lang_String_ == null)
				cb_setExtendedExpiresOn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExtendedExpiresOn_Ljava_lang_String_);
			return cb_setExtendedExpiresOn_Ljava_lang_String_;
		}

		static void n_SetExtendedExpiresOn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extendedExpiresOn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var extendedExpiresOn = JNIEnv.GetString (native_extendedExpiresOn, JniHandleOwnership.DoNotTransfer);
			__this.ExtendedExpiresOn = extendedExpiresOn;
		}
#pragma warning restore 0169

		public virtual unsafe string ExtendedExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getExtendedExpiresOn' and count(parameter)=0]"
			[Register ("getExtendedExpiresOn", "()Ljava/lang/String;", "GetGetExtendedExpiresOnHandler")]
			get {
				const string __id = "getExtendedExpiresOn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setExtendedExpiresOn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExtendedExpiresOn", "(Ljava/lang/String;)V", "GetSetExtendedExpiresOn_Ljava_lang_String_Handler")]
			set {
				const string __id = "setExtendedExpiresOn.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		public override unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				const string __id = "isExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getKid;
#pragma warning disable 0169
		static Delegate GetGetKidHandler ()
		{
			if (cb_getKid == null)
				cb_getKid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKid);
			return cb_getKid;
		}

		static IntPtr n_GetKid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kid);
		}
#pragma warning restore 0169

		static Delegate cb_setKid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKid_Ljava_lang_String_Handler ()
		{
			if (cb_setKid_Ljava_lang_String_ == null)
				cb_setKid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetKid_Ljava_lang_String_);
			return cb_setKid_Ljava_lang_String_;
		}

		static void n_SetKid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_kid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var kid = JNIEnv.GetString (native_kid, JniHandleOwnership.DoNotTransfer);
			__this.Kid = kid;
		}
#pragma warning restore 0169

		public virtual unsafe string Kid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getKid' and count(parameter)=0]"
			[Register ("getKid", "()Ljava/lang/String;", "GetGetKidHandler")]
			get {
				const string __id = "getKid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setKid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKid", "(Ljava/lang/String;)V", "GetSetKid_Ljava_lang_String_Handler")]
			set {
				const string __id = "setKid.(Ljava/lang/String;)V";
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

		static Delegate cb_getRealm;
#pragma warning disable 0169
		static Delegate GetGetRealmHandler ()
		{
			if (cb_getRealm == null)
				cb_getRealm = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRealm);
			return cb_getRealm;
		}

		static IntPtr n_GetRealm (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Realm);
		}
#pragma warning restore 0169

		static Delegate cb_setRealm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRealm_Ljava_lang_String_Handler ()
		{
			if (cb_setRealm_Ljava_lang_String_ == null)
				cb_setRealm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRealm_Ljava_lang_String_);
			return cb_setRealm_Ljava_lang_String_;
		}

		static void n_SetRealm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_realm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var realm = JNIEnv.GetString (native_realm, JniHandleOwnership.DoNotTransfer);
			__this.Realm = realm;
		}
#pragma warning restore 0169

		public virtual unsafe string Realm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getRealm' and count(parameter)=0]"
			[Register ("getRealm", "()Ljava/lang/String;", "GetGetRealmHandler")]
			get {
				const string __id = "getRealm.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setRealm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRealm", "(Ljava/lang/String;)V", "GetSetRealm_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRealm.(Ljava/lang/String;)V";
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

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Target);
		}
#pragma warning restore 0169

		static Delegate cb_setTarget_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Ljava_lang_String_Handler ()
		{
			if (cb_setTarget_Ljava_lang_String_ == null)
				cb_setTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTarget_Ljava_lang_String_);
			return cb_setTarget_Ljava_lang_String_;
		}

		static void n_SetTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			__this.Target = target;
		}
#pragma warning restore 0169

		public virtual unsafe string Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/String;", "GetGetTargetHandler")]
			get {
				const string __id = "getTarget.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTarget", "(Ljava/lang/String;)V", "GetSetTarget_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTarget.(Ljava/lang/String;)V";
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

		static Delegate cb_canEqual_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCanEqual_Ljava_lang_Object_Handler ()
		{
			if (cb_canEqual_Ljava_lang_Object_ == null)
				cb_canEqual_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanEqual_Ljava_lang_Object_);
			return cb_canEqual_Ljava_lang_Object_;
		}

		static bool n_CanEqual_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanEqual (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccessTokenRecord']/method[@name='canEqual' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("canEqual", "(Ljava/lang/Object;)Z", "GetCanEqual_Ljava_lang_Object_Handler")]
		protected virtual unsafe bool CanEqual (global::Java.Lang.Object other)
		{
			const string __id = "canEqual.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

	}
}
