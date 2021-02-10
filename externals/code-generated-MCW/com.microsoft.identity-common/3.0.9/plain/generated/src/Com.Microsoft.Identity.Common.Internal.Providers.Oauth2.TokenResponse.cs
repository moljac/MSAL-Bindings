using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/TokenResponse", DoNotGenerateAcw=true)]
	public partial class TokenResponse : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/TokenResponse", typeof (TokenResponse));

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

		protected TokenResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/constructor[@name='TokenResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			__this.AccessToken = accessToken;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessToken.(Ljava/lang/String;)V";
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

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static IntPtr n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpiresIn);
		}
#pragma warning restore 0169

		static Delegate cb_setExpiresIn_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetExpiresIn_Ljava_lang_Long_Handler ()
		{
			if (cb_setExpiresIn_Ljava_lang_Long_ == null)
				cb_setExpiresIn_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpiresIn_Ljava_lang_Long_);
			return cb_setExpiresIn_Ljava_lang_Long_;
		}

		static void n_SetExpiresIn_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expiresIn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var expiresIn = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_expiresIn, JniHandleOwnership.DoNotTransfer);
			__this.ExpiresIn = expiresIn;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()Ljava/lang/Long;", "GetGetExpiresInHandler")]
			get {
				const string __id = "getExpiresIn.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setExpiresIn' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setExpiresIn", "(Ljava/lang/Long;)V", "GetSetExpiresIn_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setExpiresIn.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getIdToken;
#pragma warning disable 0169
		static Delegate GetGetIdTokenHandler ()
		{
			if (cb_getIdToken == null)
				cb_getIdToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdToken);
			return cb_getIdToken;
		}

		static IntPtr n_GetIdToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdToken);
		}
#pragma warning restore 0169

		static Delegate cb_setIdToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdToken_Ljava_lang_String_Handler ()
		{
			if (cb_setIdToken_Ljava_lang_String_ == null)
				cb_setIdToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIdToken_Ljava_lang_String_);
			return cb_setIdToken_Ljava_lang_String_;
		}

		static void n_SetIdToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var idToken = JNIEnv.GetString (native_idToken, JniHandleOwnership.DoNotTransfer);
			__this.IdToken = idToken;
		}
#pragma warning restore 0169

		public virtual unsafe string IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Ljava/lang/String;", "GetGetIdTokenHandler")]
			get {
				const string __id = "getIdToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setIdToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdToken", "(Ljava/lang/String;)V", "GetSetIdToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIdToken.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			__this.RefreshToken = refreshToken;
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				const string __id = "getRefreshToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getResponseReceivedTime;
#pragma warning disable 0169
		static Delegate GetGetResponseReceivedTimeHandler ()
		{
			if (cb_getResponseReceivedTime == null)
				cb_getResponseReceivedTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetResponseReceivedTime);
			return cb_getResponseReceivedTime;
		}

		static long n_GetResponseReceivedTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseReceivedTime;
		}
#pragma warning restore 0169

		public virtual unsafe long ResponseReceivedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getResponseReceivedTime' and count(parameter)=0]"
			[Register ("getResponseReceivedTime", "()J", "GetGetResponseReceivedTimeHandler")]
			get {
				const string __id = "getResponseReceivedTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
			__this.Scope = scope;
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetState_Ljava_lang_String_Handler ()
		{
			if (cb_setState_Ljava_lang_String_ == null)
				cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetState_Ljava_lang_String_);
			return cb_setState_Ljava_lang_String_;
		}

		static void n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
			__this.State = state;
		}
#pragma warning restore 0169

		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)V", "GetSetState_Ljava_lang_String_Handler")]
			set {
				const string __id = "setState.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tokenType = JNIEnv.GetString (native_tokenType, JniHandleOwnership.DoNotTransfer);
			__this.TokenType = tokenType;
		}
#pragma warning restore 0169

		public virtual unsafe string TokenType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='getTokenType' and count(parameter)=0]"
			[Register ("getTokenType", "()Ljava/lang/String;", "GetGetTokenTypeHandler")]
			get {
				const string __id = "getTokenType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setTokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setResponseReceivedTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetResponseReceivedTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setResponseReceivedTime_Ljava_lang_Long_ == null)
				cb_setResponseReceivedTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseReceivedTime_Ljava_lang_Long_);
			return cb_setResponseReceivedTime_Ljava_lang_Long_;
		}

		static void n_SetResponseReceivedTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseReceivedTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseReceivedTime = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_responseReceivedTime, JniHandleOwnership.DoNotTransfer);
			__this.SetResponseReceivedTime (responseReceivedTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='TokenResponse']/method[@name='setResponseReceivedTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("setResponseReceivedTime", "(Ljava/lang/Long;)V", "GetSetResponseReceivedTime_Ljava_lang_Long_Handler")]
		public virtual unsafe void SetResponseReceivedTime (global::Java.Lang.Long responseReceivedTime)
		{
			const string __id = "setResponseReceivedTime.(Ljava/lang/Long;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseReceivedTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseReceivedTime).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (responseReceivedTime);
			}
		}

	}
}
