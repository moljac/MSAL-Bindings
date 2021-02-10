using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/PopAuthenticationSchemeInternal", DoNotGenerateAcw=true)]
	public partial class PopAuthenticationSchemeInternal : global::Com.Microsoft.Identity.Common.Internal.Authscheme.TokenAuthenticationScheme, global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/field[@name='SCHEME_POP']"
		[Register ("SCHEME_POP")]
		public const string SchemePop = (string) "PoP";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/PopAuthenticationSchemeInternal$SerializedNames", DoNotGenerateAcw=true)]
		public new sealed partial class SerializedNames : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal.SerializedNames']/field[@name='CLIENT_CLAIMS']"
			[Register ("CLIENT_CLAIMS")]
			public const string ClientClaims = (string) "client_claims";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal.SerializedNames']/field[@name='HTTP_METHOD']"
			[Register ("HTTP_METHOD")]
			public const string HttpMethod = (string) "http_method";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal.SerializedNames']/field[@name='NONCE']"
			[Register ("NONCE")]
			public const string Nonce = (string) "nonce";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal.SerializedNames']/field[@name='URL']"
			[Register ("URL")]
			public const string Url = (string) "url";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/PopAuthenticationSchemeInternal$SerializedNames", typeof (SerializedNames));

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

			internal SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal.SerializedNames']/constructor[@name='PopAuthenticationSchemeInternal.SerializedNames' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/PopAuthenticationSchemeInternal", typeof (PopAuthenticationSchemeInternal));

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

		protected PopAuthenticationSchemeInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/constructor[@name='PopAuthenticationSchemeInternal' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.util.IClockSkewManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.net.URL'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/util/IClockSkewManager;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe PopAuthenticationSchemeInternal (global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager clockSkewManager, string httpMethod, global::Java.Net.URL url, string nonce) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/util/IClockSkewManager;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpMethod = JNIEnv.NewString (httpMethod);
			IntPtr native_nonce = JNIEnv.NewString (nonce);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((clockSkewManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clockSkewManager).Handle);
				__args [1] = new JniArgumentValue (native_httpMethod);
				__args [2] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [3] = new JniArgumentValue (native_nonce);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_httpMethod);
				JNIEnv.DeleteLocalRef (native_nonce);
				global::System.GC.KeepAlive (clockSkewManager);
				global::System.GC.KeepAlive (url);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/constructor[@name='PopAuthenticationSchemeInternal' and count(parameter)=5 and parameter[1][@type='com.microsoft.identity.common.internal.util.IClockSkewManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.net.URL'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/util/IClockSkewManager;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PopAuthenticationSchemeInternal (global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager clockSkewManager, string httpMethod, global::Java.Net.URL url, string nonce, string clientClaims) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/util/IClockSkewManager;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpMethod = JNIEnv.NewString (httpMethod);
			IntPtr native_nonce = JNIEnv.NewString (nonce);
			IntPtr native_clientClaims = JNIEnv.NewString (clientClaims);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((clockSkewManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clockSkewManager).Handle);
				__args [1] = new JniArgumentValue (native_httpMethod);
				__args [2] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [3] = new JniArgumentValue (native_nonce);
				__args [4] = new JniArgumentValue (native_clientClaims);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_httpMethod);
				JNIEnv.DeleteLocalRef (native_nonce);
				JNIEnv.DeleteLocalRef (native_clientClaims);
				global::System.GC.KeepAlive (clockSkewManager);
				global::System.GC.KeepAlive (url);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/constructor[@name='PopAuthenticationSchemeInternal' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URL'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PopAuthenticationSchemeInternal (string httpMethod, global::Java.Net.URL url, string nonce, string clientClaims) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpMethod = JNIEnv.NewString (httpMethod);
			IntPtr native_nonce = JNIEnv.NewString (nonce);
			IntPtr native_clientClaims = JNIEnv.NewString (clientClaims);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_httpMethod);
				__args [1] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [2] = new JniArgumentValue (native_nonce);
				__args [3] = new JniArgumentValue (native_clientClaims);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_httpMethod);
				JNIEnv.DeleteLocalRef (native_nonce);
				JNIEnv.DeleteLocalRef (native_clientClaims);
				global::System.GC.KeepAlive (url);
			}
		}

		static Delegate cb_getClientClaims;
#pragma warning disable 0169
		static Delegate GetGetClientClaimsHandler ()
		{
			if (cb_getClientClaims == null)
				cb_getClientClaims = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientClaims);
			return cb_getClientClaims;
		}

		static IntPtr n_GetClientClaims (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.PopAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientClaims);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientClaims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/method[@name='getClientClaims' and count(parameter)=0]"
			[Register ("getClientClaims", "()Ljava/lang/String;", "GetGetClientClaimsHandler")]
			get {
				const string __id = "getClientClaims.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpMethod;
#pragma warning disable 0169
		static Delegate GetGetHttpMethodHandler ()
		{
			if (cb_getHttpMethod == null)
				cb_getHttpMethod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpMethod);
			return cb_getHttpMethod;
		}

		static IntPtr n_GetHttpMethod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.PopAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HttpMethod);
		}
#pragma warning restore 0169

		public virtual unsafe string HttpMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/method[@name='getHttpMethod' and count(parameter)=0]"
			[Register ("getHttpMethod", "()Ljava/lang/String;", "GetGetHttpMethodHandler")]
			get {
				const string __id = "getHttpMethod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNonce;
#pragma warning disable 0169
		static Delegate GetGetNonceHandler ()
		{
			if (cb_getNonce == null)
				cb_getNonce = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNonce);
			return cb_getNonce;
		}

		static IntPtr n_GetNonce (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.PopAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nonce);
		}
#pragma warning restore 0169

		public virtual unsafe string Nonce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/method[@name='getNonce' and count(parameter)=0]"
			[Register ("getNonce", "()Ljava/lang/String;", "GetGetNonceHandler")]
			get {
				const string __id = "getNonce.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.PopAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/net/URL;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/net/URL;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccessTokenForScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenForScheme_Ljava_lang_String_Handler ()
		{
			if (cb_getAccessTokenForScheme_Ljava_lang_String_ == null)
				cb_getAccessTokenForScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccessTokenForScheme_Ljava_lang_String_);
			return cb_getAccessTokenForScheme_Ljava_lang_String_;
		}

		static IntPtr n_GetAccessTokenForScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.PopAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAccessTokenForScheme (accessToken));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/method[@name='getAccessTokenForScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccessTokenForScheme", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAccessTokenForScheme_Ljava_lang_String_Handler")]
		public override unsafe string GetAccessTokenForScheme (string accessToken)
		{
			const string __id = "getAccessTokenForScheme.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_accessToken);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
			}
		}

		static Delegate cb_setClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_;
#pragma warning disable 0169
		static Delegate GetSetClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_Handler ()
		{
			if (cb_setClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_ == null)
				cb_setClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_);
			return cb_setClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_;
		}

		static void n_SetClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clockSkewManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.PopAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clockSkewManager = (global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (native_clockSkewManager, JniHandleOwnership.DoNotTransfer);
			__this.SetClockSkewManager (clockSkewManager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='PopAuthenticationSchemeInternal']/method[@name='setClockSkewManager' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.util.IClockSkewManager']]"
		[Register ("setClockSkewManager", "(Lcom/microsoft/identity/common/internal/util/IClockSkewManager;)V", "GetSetClockSkewManager_Lcom_microsoft_identity_common_internal_util_IClockSkewManager_Handler")]
		public virtual unsafe void SetClockSkewManager (global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager clockSkewManager)
		{
			const string __id = "setClockSkewManager.(Lcom/microsoft/identity/common/internal/util/IClockSkewManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clockSkewManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clockSkewManager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (clockSkewManager);
			}
		}

	}
}
