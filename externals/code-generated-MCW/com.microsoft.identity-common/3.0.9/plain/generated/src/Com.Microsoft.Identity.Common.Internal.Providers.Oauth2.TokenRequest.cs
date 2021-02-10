using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/TokenRequest", DoNotGenerateAcw=true)]
	public partial class TokenRequest : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.GrantTypes']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/TokenRequest$GrantTypes", DoNotGenerateAcw=true)]
		public partial class GrantTypes : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.GrantTypes']/field[@name='AUTHORIZATION_CODE']"
			[Register ("AUTHORIZATION_CODE")]
			public const string AuthorizationCode = (string) "authorization_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.GrantTypes']/field[@name='DEVICE_CODE']"
			[Register ("DEVICE_CODE")]
			public const string DeviceCode = (string) "urn:ietf:params:oauth:grant-type:device_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.GrantTypes']/field[@name='PASSWORD']"
			[Register ("PASSWORD")]
			public const string Password = (string) "password";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.GrantTypes']/field[@name='REFRESH_TOKEN']"
			[Register ("REFRESH_TOKEN")]
			public const string RefreshToken = (string) "refresh_token";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/TokenRequest$GrantTypes", typeof (GrantTypes));

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

			protected GrantTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.GrantTypes']/constructor[@name='TokenRequest.GrantTypes' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe GrantTypes () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.TokenType']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/TokenRequest$TokenType", DoNotGenerateAcw=true)]
		public partial class TokenType : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.TokenType']/field[@name='POP']"
			[Register ("POP")]
			public const string Pop = (string) "pop";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/TokenRequest$TokenType", typeof (TokenType));

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

			protected TokenType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest.TokenType']/constructor[@name='TokenRequest.TokenType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TokenType () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/TokenRequest", typeof (TokenRequest));

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

		protected TokenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/constructor[@name='TokenRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenRequest () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getClientAssertion;
#pragma warning disable 0169
		static Delegate GetGetClientAssertionHandler ()
		{
			if (cb_getClientAssertion == null)
				cb_getClientAssertion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientAssertion);
			return cb_getClientAssertion;
		}

		static IntPtr n_GetClientAssertion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAssertion);
		}
#pragma warning restore 0169

		static Delegate cb_setClientAssertion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAssertion_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAssertion_Ljava_lang_String_ == null)
				cb_setClientAssertion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientAssertion_Ljava_lang_String_);
			return cb_setClientAssertion_Ljava_lang_String_;
		}

		static void n_SetClientAssertion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientAssertion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientAssertion = JNIEnv.GetString (native_clientAssertion, JniHandleOwnership.DoNotTransfer);
			__this.ClientAssertion = clientAssertion;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientAssertion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getClientAssertion' and count(parameter)=0]"
			[Register ("getClientAssertion", "()Ljava/lang/String;", "GetGetClientAssertionHandler")]
			get {
				const string __id = "getClientAssertion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setClientAssertion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientAssertion", "(Ljava/lang/String;)V", "GetSetClientAssertion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientAssertion.(Ljava/lang/String;)V";
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

		static Delegate cb_getClientAssertionType;
#pragma warning disable 0169
		static Delegate GetGetClientAssertionTypeHandler ()
		{
			if (cb_getClientAssertionType == null)
				cb_getClientAssertionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientAssertionType);
			return cb_getClientAssertionType;
		}

		static IntPtr n_GetClientAssertionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAssertionType);
		}
#pragma warning restore 0169

		static Delegate cb_setClientAssertionType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAssertionType_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAssertionType_Ljava_lang_String_ == null)
				cb_setClientAssertionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientAssertionType_Ljava_lang_String_);
			return cb_setClientAssertionType_Ljava_lang_String_;
		}

		static void n_SetClientAssertionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientAssertionType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientAssertionType = JNIEnv.GetString (native_clientAssertionType, JniHandleOwnership.DoNotTransfer);
			__this.ClientAssertionType = clientAssertionType;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientAssertionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getClientAssertionType' and count(parameter)=0]"
			[Register ("getClientAssertionType", "()Ljava/lang/String;", "GetGetClientAssertionTypeHandler")]
			get {
				const string __id = "getClientAssertionType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setClientAssertionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientAssertionType", "(Ljava/lang/String;)V", "GetSetClientAssertionType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientAssertionType.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = clientId;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getClientSecret;
#pragma warning disable 0169
		static Delegate GetGetClientSecretHandler ()
		{
			if (cb_getClientSecret == null)
				cb_getClientSecret = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientSecret);
			return cb_getClientSecret;
		}

		static IntPtr n_GetClientSecret (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setClientSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setClientSecret_Ljava_lang_String_ == null)
				cb_setClientSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientSecret_Ljava_lang_String_);
			return cb_setClientSecret_Ljava_lang_String_;
		}

		static void n_SetClientSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientSecret)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			__this.ClientSecret = clientSecret;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler")]
			get {
				const string __id = "getClientSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setClientSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientSecret", "(Ljava/lang/String;)V", "GetSetClientSecret_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientSecret.(Ljava/lang/String;)V";
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

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCode_Ljava_lang_String_ == null)
				cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCode_Ljava_lang_String_);
			return cb_setCode_Ljava_lang_String_;
		}

		static void n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_code)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var code = JNIEnv.GetString (native_code, JniHandleOwnership.DoNotTransfer);
			__this.Code = code;
		}
#pragma warning restore 0169

		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				const string __id = "getCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)V", "GetSetCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getGrantType;
#pragma warning disable 0169
		static Delegate GetGetGrantTypeHandler ()
		{
			if (cb_getGrantType == null)
				cb_getGrantType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGrantType);
			return cb_getGrantType;
		}

		static IntPtr n_GetGrantType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantType);
		}
#pragma warning restore 0169

		static Delegate cb_setGrantType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGrantType_Ljava_lang_String_Handler ()
		{
			if (cb_setGrantType_Ljava_lang_String_ == null)
				cb_setGrantType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGrantType_Ljava_lang_String_);
			return cb_setGrantType_Ljava_lang_String_;
		}

		static void n_SetGrantType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_grantType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var grantType = JNIEnv.GetString (native_grantType, JniHandleOwnership.DoNotTransfer);
			__this.GrantType = grantType;
		}
#pragma warning restore 0169

		public virtual unsafe string GrantType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getGrantType' and count(parameter)=0]"
			[Register ("getGrantType", "()Ljava/lang/String;", "GetGetGrantTypeHandler")]
			get {
				const string __id = "getGrantType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setGrantType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGrantType", "(Ljava/lang/String;)V", "GetSetGrantType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setGrantType.(Ljava/lang/String;)V";
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

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		static Delegate cb_setRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRedirectUri_Ljava_lang_String_Handler ()
		{
			if (cb_setRedirectUri_Ljava_lang_String_ == null)
				cb_setRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRedirectUri_Ljava_lang_String_);
			return cb_setRedirectUri_Ljava_lang_String_;
		}

		static void n_SetRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirectUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var redirectUri = JNIEnv.GetString (native_redirectUri, JniHandleOwnership.DoNotTransfer);
			__this.RedirectUri = redirectUri;
		}
#pragma warning restore 0169

		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				const string __id = "getRedirectUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUri", "(Ljava/lang/String;)V", "GetSetRedirectUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRedirectUri.(Ljava/lang/String;)V";
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

		static Delegate cb_getRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenHandler ()
		{
			if (cb_getRefreshToken == null)
				cb_getRefreshToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshToken);
			return cb_getRefreshToken;
		}

		static IntPtr n_GetRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		static Delegate cb_setRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_setRefreshToken_Ljava_lang_String_ == null)
				cb_setRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefreshToken_Ljava_lang_String_);
			return cb_setRefreshToken_Ljava_lang_String_;
		}

		static void n_SetRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			__this.RefreshToken = refreshToken;
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				const string __id = "getRefreshToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefreshToken", "(Ljava/lang/String;)V", "GetSetRefreshToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRefreshToken.(Ljava/lang/String;)V";
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

		static Delegate cb_getRequestConfirmation;
#pragma warning disable 0169
		static Delegate GetGetRequestConfirmationHandler ()
		{
			if (cb_getRequestConfirmation == null)
				cb_getRequestConfirmation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestConfirmation);
			return cb_getRequestConfirmation;
		}

		static IntPtr n_GetRequestConfirmation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestConfirmation);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestConfirmation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestConfirmation_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestConfirmation_Ljava_lang_String_ == null)
				cb_setRequestConfirmation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestConfirmation_Ljava_lang_String_);
			return cb_setRequestConfirmation_Ljava_lang_String_;
		}

		static void n_SetRequestConfirmation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestConfirmation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestConfirmation = JNIEnv.GetString (native_requestConfirmation, JniHandleOwnership.DoNotTransfer);
			__this.RequestConfirmation = requestConfirmation;
		}
#pragma warning restore 0169

		public virtual unsafe string RequestConfirmation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getRequestConfirmation' and count(parameter)=0]"
			[Register ("getRequestConfirmation", "()Ljava/lang/String;", "GetGetRequestConfirmationHandler")]
			get {
				const string __id = "getRequestConfirmation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setRequestConfirmation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestConfirmation", "(Ljava/lang/String;)V", "GetSetRequestConfirmation_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRequestConfirmation.(Ljava/lang/String;)V";
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

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static Delegate cb_setScope_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScope_Ljava_lang_String_Handler ()
		{
			if (cb_setScope_Ljava_lang_String_ == null)
				cb_setScope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScope_Ljava_lang_String_);
			return cb_setScope_Ljava_lang_String_;
		}

		static void n_SetScope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scope)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
			__this.Scope = scope;
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScope", "(Ljava/lang/String;)V", "GetSetScope_Ljava_lang_String_Handler")]
			set {
				const string __id = "setScope.(Ljava/lang/String;)V";
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

		static Delegate cb_getTokenType;
#pragma warning disable 0169
		static Delegate GetGetTokenTypeHandler ()
		{
			if (cb_getTokenType == null)
				cb_getTokenType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenType);
			return cb_getTokenType;
		}

		static IntPtr n_GetTokenType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTokenType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='getTokenType' and count(parameter)=0]"
		[Register ("getTokenType", "()Ljava/lang/String;", "GetGetTokenTypeHandler")]
		public virtual unsafe string GetTokenType ()
		{
			const string __id = "getTokenType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTokenType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenType_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenType_Ljava_lang_String_ == null)
				cb_setTokenType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTokenType_Ljava_lang_String_);
			return cb_setTokenType_Ljava_lang_String_;
		}

		static void n_SetTokenType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenType = JNIEnv.GetString (native_tokenType, JniHandleOwnership.DoNotTransfer);
			__this.SetTokenType (tokenType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenRequest']/method[@name='setTokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTokenType", "(Ljava/lang/String;)V", "GetSetTokenType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTokenType (string tokenType)
		{
			const string __id = "setTokenType.(Ljava/lang/String;)V";
			IntPtr native_tokenType = JNIEnv.NewString (tokenType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tokenType);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tokenType);
			}
		}

	}
}
