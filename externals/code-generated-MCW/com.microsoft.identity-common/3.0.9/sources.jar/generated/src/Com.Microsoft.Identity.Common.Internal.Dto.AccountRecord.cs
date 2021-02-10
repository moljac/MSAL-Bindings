using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/AccountRecord", DoNotGenerateAcw=true)]
	public partial class AccountRecord : global::Com.Microsoft.Identity.Common.Internal.Dto.AccountCredentialBase, global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/AccountRecord$SerializedNames", DoNotGenerateAcw=true)]
		public partial class SerializedNames : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='ALTERNATIVE_ACCOUNT_ID']"
			[Register ("ALTERNATIVE_ACCOUNT_ID")]
			public const string AlternativeAccountId = (string) "alternative_account_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='AUTHORITY_TYPE']"
			[Register ("AUTHORITY_TYPE")]
			public const string AuthorityType = (string) "authority_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='AVATAR_URL']"
			[Register ("AVATAR_URL")]
			public const string AvatarUrl = (string) "avatar_url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='CLIENT_INFO']"
			[Register ("CLIENT_INFO")]
			public const string ClientInfo = (string) "client_info";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='ENVIRONMENT']"
			[Register ("ENVIRONMENT")]
			public const string Environment = (string) "environment";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='FAMILY_NAME']"
			[Register ("FAMILY_NAME")]
			public const string FamilyName = (string) "family_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='FIRST_NAME']"
			[Register ("FIRST_NAME")]
			public const string FirstName = (string) "first_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='HOME_ACCOUNT_ID']"
			[Register ("HOME_ACCOUNT_ID")]
			public const string HomeAccountId = (string) "home_account_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='LOCAL_ACCOUNT_ID']"
			[Register ("LOCAL_ACCOUNT_ID")]
			public const string LocalAccountId = (string) "local_account_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='MIDDLE_NAME']"
			[Register ("MIDDLE_NAME")]
			public const string MiddleName = (string) "middle_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='NAME']"
			[Register ("NAME")]
			public const string Name = (string) "name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='REALM']"
			[Register ("REALM")]
			public const string Realm = (string) "realm";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/field[@name='USERNAME']"
			[Register ("USERNAME")]
			public const string Username = (string) "username";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/AccountRecord$SerializedNames", typeof (SerializedNames));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord.SerializedNames']/constructor[@name='AccountRecord.SerializedNames' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/AccountRecord", typeof (AccountRecord));

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

		protected AccountRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/constructor[@name='AccountRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccountRecord () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/constructor[@name='AccountRecord' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.IAccountRecord']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)V", "")]
		public unsafe AccountRecord (global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord copy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((copy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) copy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (copy);
			}
		}

		static Delegate cb_getAlternativeAccountId;
#pragma warning disable 0169
		static Delegate GetGetAlternativeAccountIdHandler ()
		{
			if (cb_getAlternativeAccountId == null)
				cb_getAlternativeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAlternativeAccountId);
			return cb_getAlternativeAccountId;
		}

		static IntPtr n_GetAlternativeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlternativeAccountId);
		}
#pragma warning restore 0169

		static Delegate cb_setAlternativeAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlternativeAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_setAlternativeAccountId_Ljava_lang_String_ == null)
				cb_setAlternativeAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAlternativeAccountId_Ljava_lang_String_);
			return cb_setAlternativeAccountId_Ljava_lang_String_;
		}

		static void n_SetAlternativeAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alternativeAccountId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var alternativeAccountId = JNIEnv.GetString (native_alternativeAccountId, JniHandleOwnership.DoNotTransfer);
			__this.AlternativeAccountId = alternativeAccountId;
		}
#pragma warning restore 0169

		public virtual unsafe string AlternativeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getAlternativeAccountId' and count(parameter)=0]"
			[Register ("getAlternativeAccountId", "()Ljava/lang/String;", "GetGetAlternativeAccountIdHandler")]
			get {
				const string __id = "getAlternativeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setAlternativeAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlternativeAccountId", "(Ljava/lang/String;)V", "GetSetAlternativeAccountId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAlternativeAccountId.(Ljava/lang/String;)V";
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

		static Delegate cb_getAuthorityType;
#pragma warning disable 0169
		static Delegate GetGetAuthorityTypeHandler ()
		{
			if (cb_getAuthorityType == null)
				cb_getAuthorityType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityType);
			return cb_getAuthorityType;
		}

		static IntPtr n_GetAuthorityType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityType);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorityType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthorityType_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthorityType_Ljava_lang_String_ == null)
				cb_setAuthorityType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthorityType_Ljava_lang_String_);
			return cb_setAuthorityType_Ljava_lang_String_;
		}

		static void n_SetAuthorityType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorityType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorityType = JNIEnv.GetString (native_authorityType, JniHandleOwnership.DoNotTransfer);
			__this.AuthorityType = authorityType;
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorityType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getAuthorityType' and count(parameter)=0]"
			[Register ("getAuthorityType", "()Ljava/lang/String;", "GetGetAuthorityTypeHandler")]
			get {
				const string __id = "getAuthorityType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setAuthorityType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthorityType", "(Ljava/lang/String;)V", "GetSetAuthorityType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthorityType.(Ljava/lang/String;)V";
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

		static Delegate cb_getAvatarUrl;
#pragma warning disable 0169
		static Delegate GetGetAvatarUrlHandler ()
		{
			if (cb_getAvatarUrl == null)
				cb_getAvatarUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAvatarUrl);
			return cb_getAvatarUrl;
		}

		static IntPtr n_GetAvatarUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvatarUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setAvatarUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAvatarUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAvatarUrl_Ljava_lang_String_ == null)
				cb_setAvatarUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAvatarUrl_Ljava_lang_String_);
			return cb_setAvatarUrl_Ljava_lang_String_;
		}

		static void n_SetAvatarUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_avatarUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var avatarUrl = JNIEnv.GetString (native_avatarUrl, JniHandleOwnership.DoNotTransfer);
			__this.AvatarUrl = avatarUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getAvatarUrl' and count(parameter)=0]"
			[Register ("getAvatarUrl", "()Ljava/lang/String;", "GetGetAvatarUrlHandler")]
			get {
				const string __id = "getAvatarUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setAvatarUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAvatarUrl", "(Ljava/lang/String;)V", "GetSetAvatarUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAvatarUrl.(Ljava/lang/String;)V";
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

		static Delegate cb_getClientInfo;
#pragma warning disable 0169
		static Delegate GetGetClientInfoHandler ()
		{
			if (cb_getClientInfo == null)
				cb_getClientInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientInfo);
			return cb_getClientInfo;
		}

		static IntPtr n_GetClientInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setClientInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setClientInfo_Ljava_lang_String_ == null)
				cb_setClientInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientInfo_Ljava_lang_String_);
			return cb_setClientInfo_Ljava_lang_String_;
		}

		static void n_SetClientInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientInfo = JNIEnv.GetString (native_clientInfo, JniHandleOwnership.DoNotTransfer);
			__this.ClientInfo = clientInfo;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getClientInfo' and count(parameter)=0]"
			[Register ("getClientInfo", "()Ljava/lang/String;", "GetGetClientInfoHandler")]
			get {
				const string __id = "getClientInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setClientInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientInfo", "(Ljava/lang/String;)V", "GetSetClientInfo_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientInfo.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			__this.Environment = environment;
		}
#pragma warning restore 0169

		public virtual unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get {
				const string __id = "getEnvironment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getFamilyName;
#pragma warning disable 0169
		static Delegate GetGetFamilyNameHandler ()
		{
			if (cb_getFamilyName == null)
				cb_getFamilyName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFamilyName);
			return cb_getFamilyName;
		}

		static IntPtr n_GetFamilyName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyName);
		}
#pragma warning restore 0169

		static Delegate cb_setFamilyName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFamilyName_Ljava_lang_String_Handler ()
		{
			if (cb_setFamilyName_Ljava_lang_String_ == null)
				cb_setFamilyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFamilyName_Ljava_lang_String_);
			return cb_setFamilyName_Ljava_lang_String_;
		}

		static void n_SetFamilyName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_familyName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var familyName = JNIEnv.GetString (native_familyName, JniHandleOwnership.DoNotTransfer);
			__this.FamilyName = familyName;
		}
#pragma warning restore 0169

		public virtual unsafe string FamilyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getFamilyName' and count(parameter)=0]"
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler")]
			get {
				const string __id = "getFamilyName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setFamilyName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFamilyName", "(Ljava/lang/String;)V", "GetSetFamilyName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFamilyName.(Ljava/lang/String;)V";
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

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_firstName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var firstName = JNIEnv.GetString (native_firstName, JniHandleOwnership.DoNotTransfer);
			__this.FirstName = firstName;
		}
#pragma warning restore 0169

		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				const string __id = "getFirstName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFirstName.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var homeAccountId = JNIEnv.GetString (native_homeAccountId, JniHandleOwnership.DoNotTransfer);
			__this.HomeAccountId = homeAccountId;
		}
#pragma warning restore 0169

		public virtual unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get {
				const string __id = "getHomeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setHomeAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLocalAccountId;
#pragma warning disable 0169
		static Delegate GetGetLocalAccountIdHandler ()
		{
			if (cb_getLocalAccountId == null)
				cb_getLocalAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalAccountId);
			return cb_getLocalAccountId;
		}

		static IntPtr n_GetLocalAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalAccountId);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocalAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_setLocalAccountId_Ljava_lang_String_ == null)
				cb_setLocalAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLocalAccountId_Ljava_lang_String_);
			return cb_setLocalAccountId_Ljava_lang_String_;
		}

		static void n_SetLocalAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_localAccountId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var localAccountId = JNIEnv.GetString (native_localAccountId, JniHandleOwnership.DoNotTransfer);
			__this.LocalAccountId = localAccountId;
		}
#pragma warning restore 0169

		public virtual unsafe string LocalAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getLocalAccountId' and count(parameter)=0]"
			[Register ("getLocalAccountId", "()Ljava/lang/String;", "GetGetLocalAccountIdHandler")]
			get {
				const string __id = "getLocalAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setLocalAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocalAccountId", "(Ljava/lang/String;)V", "GetSetLocalAccountId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLocalAccountId.(Ljava/lang/String;)V";
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

		static Delegate cb_getMiddleName;
#pragma warning disable 0169
		static Delegate GetGetMiddleNameHandler ()
		{
			if (cb_getMiddleName == null)
				cb_getMiddleName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiddleName);
			return cb_getMiddleName;
		}

		static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		static Delegate cb_setMiddleName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMiddleName_Ljava_lang_String_Handler ()
		{
			if (cb_setMiddleName_Ljava_lang_String_ == null)
				cb_setMiddleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMiddleName_Ljava_lang_String_);
			return cb_setMiddleName_Ljava_lang_String_;
		}

		static void n_SetMiddleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_middleName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var middleName = JNIEnv.GetString (native_middleName, JniHandleOwnership.DoNotTransfer);
			__this.MiddleName = middleName;
		}
#pragma warning restore 0169

		public virtual unsafe string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler")]
			get {
				const string __id = "getMiddleName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setMiddleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMiddleName", "(Ljava/lang/String;)V", "GetSetMiddleName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMiddleName.(Ljava/lang/String;)V";
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var realm = JNIEnv.GetString (native_realm, JniHandleOwnership.DoNotTransfer);
			__this.Realm = realm;
		}
#pragma warning restore 0169

		public virtual unsafe string Realm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getRealm' and count(parameter)=0]"
			[Register ("getRealm", "()Ljava/lang/String;", "GetGetRealmHandler")]
			get {
				const string __id = "getRealm.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setRealm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUsername_Ljava_lang_String_Handler ()
		{
			if (cb_setUsername_Ljava_lang_String_ == null)
				cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUsername_Ljava_lang_String_);
			return cb_setUsername_Ljava_lang_String_;
		}

		static void n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_username)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var username = JNIEnv.GetString (native_username, JniHandleOwnership.DoNotTransfer);
			__this.Username = username;
		}
#pragma warning restore 0169

		public virtual unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				const string __id = "getUsername.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='AccountRecord']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)V", "GetSetUsername_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUsername.(Ljava/lang/String;)V";
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
}
