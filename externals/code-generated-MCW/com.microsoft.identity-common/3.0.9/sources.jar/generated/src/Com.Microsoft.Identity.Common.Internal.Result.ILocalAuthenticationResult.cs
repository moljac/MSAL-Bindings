using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']"
	[Register ("com/microsoft/identity/common/internal/result/ILocalAuthenticationResult", "", "Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker")]
	public partial interface ILocalAuthenticationResult : IJavaObject, IJavaPeerable {
		string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord AccessTokenRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getAccessTokenRecord' and count(parameter)=0]"
			[Register ("getAccessTokenRecord", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;", "GetGetAccessTokenRecordHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord AccountRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getAccountRecord' and count(parameter)=0]"
			[Register ("getAccountRecord", "()Lcom/microsoft/identity/common/internal/dto/IAccountRecord;", "GetGetAccountRecordHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> CacheRecordWithTenantProfileData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getCacheRecordWithTenantProfileData' and count(parameter)=0]"
			[Register ("getCacheRecordWithTenantProfileData", "()Ljava/util/List;", "GetGetCacheRecordWithTenantProfileDataHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getCorrelationId' and count(parameter)=0]"
			[Register ("getCorrelationId", "()Ljava/lang/String;", "GetGetCorrelationIdHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Java.Util.Date ExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getExpiresOn' and count(parameter)=0]"
			[Register ("getExpiresOn", "()Ljava/util/Date;", "GetGetExpiresOnHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Ljava/lang/String;", "GetGetIdTokenHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		bool IsServicedFromCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='isServicedFromCache' and count(parameter)=0]"
			[Register ("isServicedFromCache", "()Z", "GetIsServicedFromCacheHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string RefreshTokenAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getRefreshTokenAge' and count(parameter)=0]"
			[Register ("getRefreshTokenAge", "()Ljava/lang/String;", "GetGetRefreshTokenAgeHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string SpeRing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getSpeRing' and count(parameter)=0]"
			[Register ("getSpeRing", "()Ljava/lang/String;", "GetGetSpeRingHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Ljava/lang/String;", "GetGetUniqueIdHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='ILocalAuthenticationResult']/method[@name='getScope' and count(parameter)=0]"
		[Register ("getScope", "()[Ljava/lang/String;", "GetGetScopeHandler:Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResultInvoker, Microsoft.Identity.Common")]
		string[] GetScope ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/ILocalAuthenticationResult", DoNotGenerateAcw=true)]
	internal partial class ILocalAuthenticationResultInvoker : global::Java.Lang.Object, ILocalAuthenticationResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/ILocalAuthenticationResult", typeof (ILocalAuthenticationResultInvoker));

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

		public static ILocalAuthenticationResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocalAuthenticationResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.result.ILocalAuthenticationResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocalAuthenticationResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getAccessTokenRecord;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenRecordHandler ()
		{
			if (cb_getAccessTokenRecord == null)
				cb_getAccessTokenRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccessTokenRecord);
			return cb_getAccessTokenRecord;
		}

		static IntPtr n_GetAccessTokenRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccessTokenRecord);
		}
#pragma warning restore 0169

		IntPtr id_getAccessTokenRecord;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord AccessTokenRecord {
			get {
				if (id_getAccessTokenRecord == IntPtr.Zero)
					id_getAccessTokenRecord = JNIEnv.GetMethodID (class_ref, "getAccessTokenRecord", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessTokenRecord), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAccountRecord;
#pragma warning disable 0169
		static Delegate GetGetAccountRecordHandler ()
		{
			if (cb_getAccountRecord == null)
				cb_getAccountRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccountRecord);
			return cb_getAccountRecord;
		}

		static IntPtr n_GetAccountRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountRecord);
		}
#pragma warning restore 0169

		IntPtr id_getAccountRecord;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord AccountRecord {
			get {
				if (id_getAccountRecord == IntPtr.Zero)
					id_getAccountRecord = JNIEnv.GetMethodID (class_ref, "getAccountRecord", "()Lcom/microsoft/identity/common/internal/dto/IAccountRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountRecord), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCacheRecordWithTenantProfileData;
#pragma warning disable 0169
		static Delegate GetGetCacheRecordWithTenantProfileDataHandler ()
		{
			if (cb_getCacheRecordWithTenantProfileData == null)
				cb_getCacheRecordWithTenantProfileData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCacheRecordWithTenantProfileData);
			return cb_getCacheRecordWithTenantProfileData;
		}

		static IntPtr n_GetCacheRecordWithTenantProfileData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.CacheRecordWithTenantProfileData);
		}
#pragma warning restore 0169

		IntPtr id_getCacheRecordWithTenantProfileData;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> CacheRecordWithTenantProfileData {
			get {
				if (id_getCacheRecordWithTenantProfileData == IntPtr.Zero)
					id_getCacheRecordWithTenantProfileData = JNIEnv.GetMethodID (class_ref, "getCacheRecordWithTenantProfileData", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheRecordWithTenantProfileData), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		IntPtr id_getCorrelationId;
		public unsafe string CorrelationId {
			get {
				if (id_getCorrelationId == IntPtr.Zero)
					id_getCorrelationId = JNIEnv.GetMethodID (class_ref, "getCorrelationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCorrelationId), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getFamilyId;
#pragma warning disable 0169
		static Delegate GetGetFamilyIdHandler ()
		{
			if (cb_getFamilyId == null)
				cb_getFamilyId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFamilyId);
			return cb_getFamilyId;
		}

		static IntPtr n_GetFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyId);
		}
#pragma warning restore 0169

		IntPtr id_getFamilyId;
		public unsafe string FamilyId {
			get {
				if (id_getFamilyId == IntPtr.Zero)
					id_getFamilyId = JNIEnv.GetMethodID (class_ref, "getFamilyId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFamilyId), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdToken);
		}
#pragma warning restore 0169

		IntPtr id_getIdToken;
		public unsafe string IdToken {
			get {
				if (id_getIdToken == IntPtr.Zero)
					id_getIdToken = JNIEnv.GetMethodID (class_ref, "getIdToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isServicedFromCache;
#pragma warning disable 0169
		static Delegate GetIsServicedFromCacheHandler ()
		{
			if (cb_isServicedFromCache == null)
				cb_isServicedFromCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsServicedFromCache);
			return cb_isServicedFromCache;
		}

		static bool n_IsServicedFromCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsServicedFromCache;
		}
#pragma warning restore 0169

		IntPtr id_isServicedFromCache;
		public unsafe bool IsServicedFromCache {
			get {
				if (id_isServicedFromCache == IntPtr.Zero)
					id_isServicedFromCache = JNIEnv.GetMethodID (class_ref, "isServicedFromCache", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isServicedFromCache);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshToken;
		public unsafe string RefreshToken {
			get {
				if (id_getRefreshToken == IntPtr.Zero)
					id_getRefreshToken = JNIEnv.GetMethodID (class_ref, "getRefreshToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefreshTokenAge;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenAgeHandler ()
		{
			if (cb_getRefreshTokenAge == null)
				cb_getRefreshTokenAge = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshTokenAge);
			return cb_getRefreshTokenAge;
		}

		static IntPtr n_GetRefreshTokenAge (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshTokenAge);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshTokenAge;
		public unsafe string RefreshTokenAge {
			get {
				if (id_getRefreshTokenAge == IntPtr.Zero)
					id_getRefreshTokenAge = JNIEnv.GetMethodID (class_ref, "getRefreshTokenAge", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshTokenAge), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSpeRing;
#pragma warning disable 0169
		static Delegate GetGetSpeRingHandler ()
		{
			if (cb_getSpeRing == null)
				cb_getSpeRing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSpeRing);
			return cb_getSpeRing;
		}

		static IntPtr n_GetSpeRing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpeRing);
		}
#pragma warning restore 0169

		IntPtr id_getSpeRing;
		public unsafe string SpeRing {
			get {
				if (id_getSpeRing == IntPtr.Zero)
					id_getSpeRing = JNIEnv.GetMethodID (class_ref, "getSpeRing", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpeRing), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getUniqueId;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdHandler ()
		{
			if (cb_getUniqueId == null)
				cb_getUniqueId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUniqueId);
			return cb_getUniqueId;
		}

		static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueId);
		}
#pragma warning restore 0169

		IntPtr id_getUniqueId;
		public unsafe string UniqueId {
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
