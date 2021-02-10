using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']"
	[Register ("com/microsoft/identity/common/internal/cache/IAccountCredentialAdapter", "", "Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy", "U extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest", "V extends com.microsoft.identity.common.internal.providers.oauth2.TokenResponse", "W extends com.microsoft.identity.common.BaseAccount", "X extends com.microsoft.identity.common.internal.providers.oauth2.RefreshToken"})]
	public partial interface IAccountCredentialAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='asAccount' and count(parameter)=1 and parameter[1][@type='W']]"
		[Register ("asAccount", "(Lcom/microsoft/identity/common/BaseAccount;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetAsAccount_Lcom_microsoft_identity_common_BaseAccount_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord AsAccount (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='asIdToken' and count(parameter)=2 and parameter[1][@type='W'] and parameter[2][@type='X']]"
		[Register ("asIdToken", "(Lcom/microsoft/identity/common/BaseAccount;Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;)Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "GetAsIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord AsIdToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='asRefreshToken' and count(parameter)=1 and parameter[1][@type='X']]"
		[Register ("asRefreshToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;)Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;", "GetAsRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord AsRefreshToken (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='createAccessToken' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("createAccessToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;", "GetCreateAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord CreateAccessToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='createAccount' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("createAccount", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetCreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord CreateAccount (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='createIdToken' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("createIdToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "GetCreateIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord CreateIdToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IAccountCredentialAdapter']/method[@name='createRefreshToken' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='U'] and parameter[3][@type='V']]"
		[Register ("createRefreshToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;", "GetCreateRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord CreateRefreshToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/IAccountCredentialAdapter", DoNotGenerateAcw=true)]
	internal partial class IAccountCredentialAdapterInvoker : global::Java.Lang.Object, IAccountCredentialAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/IAccountCredentialAdapter", typeof (IAccountCredentialAdapterInvoker));

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

		public static IAccountCredentialAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccountCredentialAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.IAccountCredentialAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccountCredentialAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asAccount_Lcom_microsoft_identity_common_BaseAccount_;
#pragma warning disable 0169
		static Delegate GetAsAccount_Lcom_microsoft_identity_common_BaseAccount_Handler ()
		{
			if (cb_asAccount_Lcom_microsoft_identity_common_BaseAccount_ == null)
				cb_asAccount_Lcom_microsoft_identity_common_BaseAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AsAccount_Lcom_microsoft_identity_common_BaseAccount_);
			return cb_asAccount_Lcom_microsoft_identity_common_BaseAccount_;
		}

		static IntPtr n_AsAccount_Lcom_microsoft_identity_common_BaseAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asAccount_Lcom_microsoft_identity_common_BaseAccount_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord AsAccount (global::Java.Lang.Object p0)
		{
			if (id_asAccount_Lcom_microsoft_identity_common_BaseAccount_ == IntPtr.Zero)
				id_asAccount_Lcom_microsoft_identity_common_BaseAccount_ = JNIEnv.GetMethodID (class_ref, "asAccount", "(Lcom/microsoft/identity/common/BaseAccount;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asAccount_Lcom_microsoft_identity_common_BaseAccount_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
#pragma warning disable 0169
		static Delegate GetAsIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_Handler ()
		{
			if (cb_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ == null)
				cb_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AsIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_);
			return cb_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
		}

		static IntPtr n_AsIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsIdToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord AsIdToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ == IntPtr.Zero)
				id_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ = JNIEnv.GetMethodID (class_ref, "asIdToken", "(Lcom/microsoft/identity/common/BaseAccount;Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;)Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asIdToken_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
#pragma warning disable 0169
		static Delegate GetAsRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_Handler ()
		{
			if (cb_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ == null)
				cb_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AsRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_);
			return cb_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
		}

		static IntPtr n_AsRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsRefreshToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord AsRefreshToken (global::Java.Lang.Object p0)
		{
			if (id_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ == IntPtr.Zero)
				id_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ = JNIEnv.GetMethodID (class_ref, "asRefreshToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;)Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetCreateAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_CreateAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAccessToken (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord CreateAccessToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == IntPtr.Zero)
				id_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNIEnv.GetMethodID (class_ref, "createAccessToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAccessToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetCreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_CreateAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAccount (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord CreateAccount (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == IntPtr.Zero)
				id_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNIEnv.GetMethodID (class_ref, "createAccount", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetCreateIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_CreateIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateIdToken (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord CreateIdToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == IntPtr.Zero)
				id_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNIEnv.GetMethodID (class_ref, "createIdToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createIdToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
#pragma warning disable 0169
		static Delegate GetCreateRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_Handler ()
		{
			if (cb_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == null)
				cb_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_);
			return cb_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		}

		static IntPtr n_CreateRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IAccountCredentialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRefreshToken (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord CreateRefreshToken (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ == IntPtr.Zero)
				id_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_ = JNIEnv.GetMethodID (class_ref, "createRefreshToken", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createRefreshToken_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_TokenResponse_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}
}
