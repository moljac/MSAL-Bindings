using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Claims {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/claims/ClaimsRequest", DoNotGenerateAcw=true)]
	public partial class ClaimsRequest : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/field[@name='ACCESS_TOKEN']"
		[Register ("ACCESS_TOKEN")]
		public const string AccessToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/field[@name='ID_TOKEN']"
		[Register ("ID_TOKEN")]
		public const string IdToken = (string) "id_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/field[@name='USERINFO']"
		[Register ("USERINFO")]
		public const string Userinfo = (string) "userinfo";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/claims/ClaimsRequest", typeof (ClaimsRequest));

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

		protected ClaimsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/constructor[@name='ClaimsRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClaimsRequest () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAccessTokenClaimsRequested;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenClaimsRequestedHandler ()
		{
			if (cb_getAccessTokenClaimsRequested == null)
				cb_getAccessTokenClaimsRequested = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccessTokenClaimsRequested);
			return cb_getAccessTokenClaimsRequested;
		}

		static IntPtr n_GetAccessTokenClaimsRequested (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim>.ToLocalJniHandle (__this.AccessTokenClaimsRequested);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> AccessTokenClaimsRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='getAccessTokenClaimsRequested' and count(parameter)=0]"
			[Register ("getAccessTokenClaimsRequested", "()Ljava/util/List;", "GetGetAccessTokenClaimsRequestedHandler")]
			get {
				const string __id = "getAccessTokenClaimsRequested.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdTokenClaimsRequested;
#pragma warning disable 0169
		static Delegate GetGetIdTokenClaimsRequestedHandler ()
		{
			if (cb_getIdTokenClaimsRequested == null)
				cb_getIdTokenClaimsRequested = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdTokenClaimsRequested);
			return cb_getIdTokenClaimsRequested;
		}

		static IntPtr n_GetIdTokenClaimsRequested (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim>.ToLocalJniHandle (__this.IdTokenClaimsRequested);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> IdTokenClaimsRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='getIdTokenClaimsRequested' and count(parameter)=0]"
			[Register ("getIdTokenClaimsRequested", "()Ljava/util/List;", "GetGetIdTokenClaimsRequestedHandler")]
			get {
				const string __id = "getIdTokenClaimsRequested.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserInfoClaimsRequested;
#pragma warning disable 0169
		static Delegate GetGetUserInfoClaimsRequestedHandler ()
		{
			if (cb_getUserInfoClaimsRequested == null)
				cb_getUserInfoClaimsRequested = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserInfoClaimsRequested);
			return cb_getUserInfoClaimsRequested;
		}

		static IntPtr n_GetUserInfoClaimsRequested (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim>.ToLocalJniHandle (__this.UserInfoClaimsRequested);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> UserInfoClaimsRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='getUserInfoClaimsRequested' and count(parameter)=0]"
			[Register ("getUserInfoClaimsRequested", "()Ljava/util/List;", "GetGetUserInfoClaimsRequestedHandler")]
			get {
				const string __id = "getUserInfoClaimsRequested.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='getClaimsRequestFromJsonString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClaimsRequestFromJsonString", "(Ljava/lang/String;)Lcom/microsoft/identity/client/claims/ClaimsRequest;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest GetClaimsRequestFromJsonString (string claimsRequestJson)
		{
			const string __id = "getClaimsRequestFromJsonString.(Ljava/lang/String;)Lcom/microsoft/identity/client/claims/ClaimsRequest;";
			IntPtr native_claimsRequestJson = JNIEnv.NewString (claimsRequestJson);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_claimsRequestJson);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_claimsRequestJson);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='getJsonStringFromClaimsRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.claims.ClaimsRequest']]"
		[Register ("getJsonStringFromClaimsRequest", "(Lcom/microsoft/identity/client/claims/ClaimsRequest;)Ljava/lang/String;", "")]
		public static unsafe string GetJsonStringFromClaimsRequest (global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest claimsRequest)
		{
			const string __id = "getJsonStringFromClaimsRequest.(Lcom/microsoft/identity/client/claims/ClaimsRequest;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((claimsRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) claimsRequest).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (claimsRequest);
			}
		}

		static Delegate cb_requestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
#pragma warning disable 0169
		static Delegate GetRequestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler ()
		{
			if (cb_requestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ == null)
				cb_requestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RequestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_);
			return cb_requestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
		}

		static void n_RequestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_additionalInformation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var additionalInformation = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (native_additionalInformation, JniHandleOwnership.DoNotTransfer);
			__this.RequestClaimInAccessToken (name, additionalInformation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='requestClaimInAccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.client.claims.RequestedClaimAdditionalInformation']]"
		[Register ("requestClaimInAccessToken", "(Ljava/lang/String;Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V", "GetRequestClaimInAccessToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler")]
		public virtual unsafe void RequestClaimInAccessToken (string name, global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation additionalInformation)
		{
			const string __id = "requestClaimInAccessToken.(Ljava/lang/String;Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((additionalInformation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalInformation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (additionalInformation);
			}
		}

		static Delegate cb_requestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
#pragma warning disable 0169
		static Delegate GetRequestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler ()
		{
			if (cb_requestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ == null)
				cb_requestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RequestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_);
			return cb_requestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
		}

		static void n_RequestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_additionalInformation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var additionalInformation = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (native_additionalInformation, JniHandleOwnership.DoNotTransfer);
			__this.RequestClaimInIdToken (name, additionalInformation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='requestClaimInIdToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.client.claims.RequestedClaimAdditionalInformation']]"
		[Register ("requestClaimInIdToken", "(Ljava/lang/String;Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V", "GetRequestClaimInIdToken_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler")]
		public virtual unsafe void RequestClaimInIdToken (string name, global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation additionalInformation)
		{
			const string __id = "requestClaimInIdToken.(Ljava/lang/String;Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((additionalInformation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalInformation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (additionalInformation);
			}
		}

		static Delegate cb_requestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
#pragma warning disable 0169
		static Delegate GetRequestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler ()
		{
			if (cb_requestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ == null)
				cb_requestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RequestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_);
			return cb_requestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
		}

		static void n_RequestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_additionalInformation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var additionalInformation = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (native_additionalInformation, JniHandleOwnership.DoNotTransfer);
			__this.RequestClaimInUserInfo (name, additionalInformation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='ClaimsRequest']/method[@name='requestClaimInUserInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.client.claims.RequestedClaimAdditionalInformation']]"
		[Register ("requestClaimInUserInfo", "(Ljava/lang/String;Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V", "GetRequestClaimInUserInfo_Ljava_lang_String_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler")]
		public virtual unsafe void RequestClaimInUserInfo (string name, global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation additionalInformation)
		{
			const string __id = "requestClaimInUserInfo.(Ljava/lang/String;Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((additionalInformation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalInformation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (additionalInformation);
			}
		}

	}
}
