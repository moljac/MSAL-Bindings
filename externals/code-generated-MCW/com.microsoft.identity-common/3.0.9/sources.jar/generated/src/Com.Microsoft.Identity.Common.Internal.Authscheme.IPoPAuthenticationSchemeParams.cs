using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='IPoPAuthenticationSchemeParams']"
	[Register ("com/microsoft/identity/common/internal/authscheme/IPoPAuthenticationSchemeParams", "", "Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParamsInvoker")]
	public partial interface IPoPAuthenticationSchemeParams : global::Com.Microsoft.Identity.Common.Internal.Authscheme.INonced {
		string ClientClaims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='IPoPAuthenticationSchemeParams']/method[@name='getClientClaims' and count(parameter)=0]"
			[Register ("getClientClaims", "()Ljava/lang/String;", "GetGetClientClaimsHandler:Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParamsInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string HttpMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='IPoPAuthenticationSchemeParams']/method[@name='getHttpMethod' and count(parameter)=0]"
			[Register ("getHttpMethod", "()Ljava/lang/String;", "GetGetHttpMethodHandler:Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParamsInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='IPoPAuthenticationSchemeParams']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/net/URL;", "GetGetUrlHandler:Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParamsInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/IPoPAuthenticationSchemeParams", DoNotGenerateAcw=true)]
	internal partial class IPoPAuthenticationSchemeParamsInvoker : global::Java.Lang.Object, IPoPAuthenticationSchemeParams {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/IPoPAuthenticationSchemeParams", typeof (IPoPAuthenticationSchemeParamsInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPoPAuthenticationSchemeParams GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPoPAuthenticationSchemeParams> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.authscheme.IPoPAuthenticationSchemeParams"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPoPAuthenticationSchemeParamsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientClaims);
		}
#pragma warning restore 0169

		IntPtr id_getClientClaims;
		public unsafe string ClientClaims {
			get {
				if (id_getClientClaims == IntPtr.Zero)
					id_getClientClaims = JNIEnv.GetMethodID (class_ref, "getClientClaims", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientClaims), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HttpMethod);
		}
#pragma warning restore 0169

		IntPtr id_getHttpMethod;
		public unsafe string HttpMethod {
			get {
				if (id_getHttpMethod == IntPtr.Zero)
					id_getHttpMethod = JNIEnv.GetMethodID (class_ref, "getHttpMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHttpMethod), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		IntPtr id_getUrl;
		public unsafe global::Java.Net.URL Url {
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/net/URL;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nonce);
		}
#pragma warning restore 0169

		IntPtr id_getNonce;
		public unsafe string Nonce {
			get {
				if (id_getNonce == IntPtr.Zero)
					id_getNonce = JNIEnv.GetMethodID (class_ref, "getNonce", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNonce), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
