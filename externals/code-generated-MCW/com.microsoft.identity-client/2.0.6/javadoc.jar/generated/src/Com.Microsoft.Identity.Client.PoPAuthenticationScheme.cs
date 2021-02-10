using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/PoPAuthenticationScheme", DoNotGenerateAcw=true)]
	public partial class PoPAuthenticationScheme : global::Com.Microsoft.Identity.Client.AuthenticationScheme, global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/PoPAuthenticationScheme$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PoPAuthenticationScheme$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/client/PoPAuthenticationScheme;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/client/PoPAuthenticationScheme;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withClientClaims_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithClientClaims_Ljava_lang_String_Handler ()
			{
				if (cb_withClientClaims_Ljava_lang_String_ == null)
					cb_withClientClaims_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithClientClaims_Ljava_lang_String_);
				return cb_withClientClaims_Ljava_lang_String_;
			}

			static IntPtr n_WithClientClaims_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientClaims)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var clientClaims = JNIEnv.GetString (native_clientClaims, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithClientClaims (clientClaims));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme.Builder']/method[@name='withClientClaims' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withClientClaims", "(Ljava/lang/String;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;", "GetWithClientClaims_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder WithClientClaims (string clientClaims)
			{
				const string __id = "withClientClaims.(Ljava/lang/String;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;";
				IntPtr native_clientClaims = JNIEnv.NewString (clientClaims);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientClaims);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientClaims);
				}
			}

			static Delegate cb_withHttpMethod_Lcom_microsoft_identity_client_HttpMethod_;
#pragma warning disable 0169
			static Delegate GetWithHttpMethod_Lcom_microsoft_identity_client_HttpMethod_Handler ()
			{
				if (cb_withHttpMethod_Lcom_microsoft_identity_client_HttpMethod_ == null)
					cb_withHttpMethod_Lcom_microsoft_identity_client_HttpMethod_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithHttpMethod_Lcom_microsoft_identity_client_HttpMethod_);
				return cb_withHttpMethod_Lcom_microsoft_identity_client_HttpMethod_;
			}

			static IntPtr n_WithHttpMethod_Lcom_microsoft_identity_client_HttpMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var method = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (native_method, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithHttpMethod (method));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme.Builder']/method[@name='withHttpMethod' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.HttpMethod']]"
			[Register ("withHttpMethod", "(Lcom/microsoft/identity/client/HttpMethod;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;", "GetWithHttpMethod_Lcom_microsoft_identity_client_HttpMethod_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder WithHttpMethod (global::Com.Microsoft.Identity.Client.HttpMethod method)
			{
				const string __id = "withHttpMethod.(Lcom/microsoft/identity/client/HttpMethod;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (method);
				}
			}

			static Delegate cb_withNonce_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithNonce_Ljava_lang_String_Handler ()
			{
				if (cb_withNonce_Ljava_lang_String_ == null)
					cb_withNonce_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithNonce_Ljava_lang_String_);
				return cb_withNonce_Ljava_lang_String_;
			}

			static IntPtr n_WithNonce_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nonce)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var nonce = JNIEnv.GetString (native_nonce, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithNonce (nonce));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme.Builder']/method[@name='withNonce' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withNonce", "(Ljava/lang/String;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;", "GetWithNonce_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder WithNonce (string nonce)
			{
				const string __id = "withNonce.(Ljava/lang/String;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;";
				IntPtr native_nonce = JNIEnv.NewString (nonce);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_nonce);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_nonce);
				}
			}

			static Delegate cb_withUrl_Ljava_net_URL_;
#pragma warning disable 0169
			static Delegate GetWithUrl_Ljava_net_URL_Handler ()
			{
				if (cb_withUrl_Ljava_net_URL_ == null)
					cb_withUrl_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithUrl_Ljava_net_URL_);
				return cb_withUrl_Ljava_net_URL_;
			}

			static IntPtr n_WithUrl_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithUrl (url));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme.Builder']/method[@name='withUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("withUrl", "(Ljava/net/URL;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;", "GetWithUrl_Ljava_net_URL_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder WithUrl (global::Java.Net.URL url)
			{
				const string __id = "withUrl.(Ljava/net/URL;)Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (url);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PoPAuthenticationScheme", typeof (PoPAuthenticationScheme));

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

		protected PoPAuthenticationScheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientClaims);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientClaims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme']/method[@name='getClientClaims' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HttpMethod);
		}
#pragma warning restore 0169

		public virtual unsafe string HttpMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme']/method[@name='getHttpMethod' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nonce);
		}
#pragma warning restore 0169

		public virtual unsafe string Nonce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme']/method[@name='getNonce' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme']/method[@name='getUrl' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PoPAuthenticationScheme']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lcom/microsoft/identity/client/PoPAuthenticationScheme$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
