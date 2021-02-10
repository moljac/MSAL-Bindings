using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AccessToken", DoNotGenerateAcw=true)]
	public partial class AccessToken : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AccessToken", typeof (AccessToken));

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

		protected AccessToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/constructor[@name='AccessToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResponse']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V", "")]
		public unsafe AccessToken (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse response) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (response);
			}
		}

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static long n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		static Delegate cb_setExpiresIn_J;
#pragma warning disable 0169
		static Delegate GetSetExpiresIn_JHandler ()
		{
			if (cb_setExpiresIn_J == null)
				cb_setExpiresIn_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetExpiresIn_J);
			return cb_setExpiresIn_J;
		}

		static void n_SetExpiresIn_J (IntPtr jnienv, IntPtr native__this, long expiresIn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpiresIn = expiresIn;
		}
#pragma warning restore 0169

		public virtual unsafe long ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()J", "GetGetExpiresInHandler")]
			get {
				const string __id = "getExpiresIn.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='setExpiresIn' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExpiresIn", "(J)V", "GetSetExpiresIn_JHandler")]
			set {
				const string __id = "setExpiresIn.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='isExpired' and count(parameter)=0]"
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

		static Delegate cb_getRawAccessToken;
#pragma warning disable 0169
		static Delegate GetGetRawAccessTokenHandler ()
		{
			if (cb_getRawAccessToken == null)
				cb_getRawAccessToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawAccessToken);
			return cb_getRawAccessToken;
		}

		static IntPtr n_GetRawAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawAccessToken);
		}
#pragma warning restore 0169

		static Delegate cb_setRawAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRawAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setRawAccessToken_Ljava_lang_String_ == null)
				cb_setRawAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRawAccessToken_Ljava_lang_String_);
			return cb_setRawAccessToken_Ljava_lang_String_;
		}

		static void n_SetRawAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rawAccessToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rawAccessToken = JNIEnv.GetString (native_rawAccessToken, JniHandleOwnership.DoNotTransfer);
			__this.RawAccessToken = rawAccessToken;
		}
#pragma warning restore 0169

		public virtual unsafe string RawAccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='getRawAccessToken' and count(parameter)=0]"
			[Register ("getRawAccessToken", "()Ljava/lang/String;", "GetGetRawAccessTokenHandler")]
			get {
				const string __id = "getRawAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='setRawAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRawAccessToken", "(Ljava/lang/String;)V", "GetSetRawAccessToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRawAccessToken.(Ljava/lang/String;)V";
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

		static Delegate cb_getTokenExpiredBuffer;
#pragma warning disable 0169
		static Delegate GetGetTokenExpiredBufferHandler ()
		{
			if (cb_getTokenExpiredBuffer == null)
				cb_getTokenExpiredBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTokenExpiredBuffer);
			return cb_getTokenExpiredBuffer;
		}

		static long n_GetTokenExpiredBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TokenExpiredBuffer;
		}
#pragma warning restore 0169

		public virtual unsafe long TokenExpiredBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='getTokenExpiredBuffer' and count(parameter)=0]"
			[Register ("getTokenExpiredBuffer", "()J", "GetGetTokenExpiredBufferHandler")]
			get {
				const string __id = "getTokenExpiredBuffer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTokenReceivedTime;
#pragma warning disable 0169
		static Delegate GetGetTokenReceivedTimeHandler ()
		{
			if (cb_getTokenReceivedTime == null)
				cb_getTokenReceivedTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTokenReceivedTime);
			return cb_getTokenReceivedTime;
		}

		static long n_GetTokenReceivedTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TokenReceivedTime;
		}
#pragma warning restore 0169

		static Delegate cb_setTokenReceivedTime_J;
#pragma warning disable 0169
		static Delegate GetSetTokenReceivedTime_JHandler ()
		{
			if (cb_setTokenReceivedTime_J == null)
				cb_setTokenReceivedTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetTokenReceivedTime_J);
			return cb_setTokenReceivedTime_J;
		}

		static void n_SetTokenReceivedTime_J (IntPtr jnienv, IntPtr native__this, long tokenReceivedTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TokenReceivedTime = tokenReceivedTime;
		}
#pragma warning restore 0169

		public virtual unsafe long TokenReceivedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='getTokenReceivedTime' and count(parameter)=0]"
			[Register ("getTokenReceivedTime", "()J", "GetGetTokenReceivedTimeHandler")]
			get {
				const string __id = "getTokenReceivedTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='setTokenReceivedTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTokenReceivedTime", "(J)V", "GetSetTokenReceivedTime_JHandler")]
			set {
				const string __id = "setTokenReceivedTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenType);
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenType = JNIEnv.GetString (native_tokenType, JniHandleOwnership.DoNotTransfer);
			__this.TokenType = tokenType;
		}
#pragma warning restore 0169

		public virtual unsafe string TokenType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='getTokenType' and count(parameter)=0]"
			[Register ("getTokenType", "()Ljava/lang/String;", "GetGetTokenTypeHandler")]
			get {
				const string __id = "getTokenType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='setTokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenType", "(Ljava/lang/String;)V", "GetSetTokenType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTokenType.(Ljava/lang/String;)V";
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

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetAccessToken ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AccessToken']/method[@name='getAccessToken' and count(parameter)=0]"
		[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
		public virtual unsafe string GetAccessToken ()
		{
			const string __id = "getAccessToken.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
