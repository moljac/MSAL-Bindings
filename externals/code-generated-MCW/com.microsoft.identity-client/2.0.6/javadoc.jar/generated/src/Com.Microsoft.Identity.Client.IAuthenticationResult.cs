using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']"
	[Register ("com/microsoft/identity/client/IAuthenticationResult", "", "Com.Microsoft.Identity.Client.IAuthenticationResultInvoker")]
	public partial interface IAuthenticationResult : IJavaObject, IJavaPeerable {
		string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		global::Com.Microsoft.Identity.Client.IAccount Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/microsoft/identity/client/IAccount;", "GetGetAccountHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		string AuthenticationScheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getAuthenticationScheme' and count(parameter)=0]"
			[Register ("getAuthenticationScheme", "()Ljava/lang/String;", "GetGetAuthenticationSchemeHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		string AuthorizationHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getAuthorizationHeader' and count(parameter)=0]"
			[Register ("getAuthorizationHeader", "()Ljava/lang/String;", "GetGetAuthorizationHeaderHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		global::Java.Util.UUID CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getCorrelationId' and count(parameter)=0]"
			[Register ("getCorrelationId", "()Ljava/util/UUID;", "GetGetCorrelationIdHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		global::Java.Util.Date ExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getExpiresOn' and count(parameter)=0]"
			[Register ("getExpiresOn", "()Ljava/util/Date;", "GetGetExpiresOnHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IAuthenticationResult']/method[@name='getScope' and count(parameter)=0]"
		[Register ("getScope", "()[Ljava/lang/String;", "GetGetScopeHandler:Com.Microsoft.Identity.Client.IAuthenticationResultInvoker, Microsoft.Identity.Client")]
		string[] GetScope ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IAuthenticationResult", DoNotGenerateAcw=true)]
	internal partial class IAuthenticationResultInvoker : global::Java.Lang.Object, IAuthenticationResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IAuthenticationResult", typeof (IAuthenticationResultInvoker));

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

		public static IAuthenticationResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticationResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IAuthenticationResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticationResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		IntPtr id_getAccessToken;
		public unsafe string AccessToken {
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		IntPtr id_getAccount;
		public unsafe global::Com.Microsoft.Identity.Client.IAccount Account {
			get {
				if (id_getAccount == IntPtr.Zero)
					id_getAccount = JNIEnv.GetMethodID (class_ref, "getAccount", "()Lcom/microsoft/identity/client/IAccount;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccount), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAuthenticationScheme;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationSchemeHandler ()
		{
			if (cb_getAuthenticationScheme == null)
				cb_getAuthenticationScheme = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthenticationScheme);
			return cb_getAuthenticationScheme;
		}

		static IntPtr n_GetAuthenticationScheme (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthenticationScheme);
		}
#pragma warning restore 0169

		IntPtr id_getAuthenticationScheme;
		public unsafe string AuthenticationScheme {
			get {
				if (id_getAuthenticationScheme == IntPtr.Zero)
					id_getAuthenticationScheme = JNIEnv.GetMethodID (class_ref, "getAuthenticationScheme", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthenticationScheme), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAuthorizationHeader;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationHeaderHandler ()
		{
			if (cb_getAuthorizationHeader == null)
				cb_getAuthorizationHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationHeader);
			return cb_getAuthorizationHeader;
		}

		static IntPtr n_GetAuthorizationHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationHeader);
		}
#pragma warning restore 0169

		IntPtr id_getAuthorizationHeader;
		public unsafe string AuthorizationHeader {
			get {
				if (id_getAuthorizationHeader == IntPtr.Zero)
					id_getAuthorizationHeader = JNIEnv.GetMethodID (class_ref, "getAuthorizationHeader", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthorizationHeader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCorrelationId;
#pragma warning disable 0169
		static Delegate GetGetCorrelationIdHandler ()
		{
			if (cb_getCorrelationId == null)
				cb_getCorrelationId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCorrelationId);
			return cb_getCorrelationId;
		}

		static IntPtr n_GetCorrelationId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CorrelationId);
		}
#pragma warning restore 0169

		IntPtr id_getCorrelationId;
		public unsafe global::Java.Util.UUID CorrelationId {
			get {
				if (id_getCorrelationId == IntPtr.Zero)
					id_getCorrelationId = JNIEnv.GetMethodID (class_ref, "getCorrelationId", "()Ljava/util/UUID;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCorrelationId), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpiresOn);
		}
#pragma warning restore 0169

		IntPtr id_getExpiresOn;
		public unsafe global::Java.Util.Date ExpiresOn {
			get {
				if (id_getExpiresOn == IntPtr.Zero)
					id_getExpiresOn = JNIEnv.GetMethodID (class_ref, "getExpiresOn", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpiresOn), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTenantId;
#pragma warning disable 0169
		static Delegate GetGetTenantIdHandler ()
		{
			if (cb_getTenantId == null)
				cb_getTenantId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantId);
			return cb_getTenantId;
		}

		static IntPtr n_GetTenantId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		IntPtr id_getTenantId;
		public unsafe string TenantId {
			get {
				if (id_getTenantId == IntPtr.Zero)
					id_getTenantId = JNIEnv.GetMethodID (class_ref, "getTenantId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTenantId), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetScope ());
		}
#pragma warning restore 0169

		IntPtr id_getScope;
		public unsafe string[] GetScope ()
		{
			if (id_getScope == IntPtr.Zero)
				id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScope), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

	}
}
