using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/LocalAuthenticationResult", DoNotGenerateAcw=true)]
	public partial class LocalAuthenticationResult : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/LocalAuthenticationResult", typeof (LocalAuthenticationResult));

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

		protected LocalAuthenticationResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/constructor[@name='LocalAuthenticationResult' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheRecord'] and parameter[2][@type='java.util.List&lt;com.microsoft.identity.common.internal.cache.ICacheRecord&gt;'] and parameter[3][@type='com.microsoft.identity.common.internal.request.SdkType'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Ljava/util/List;Lcom/microsoft/identity/common/internal/request/SdkType;Z)V", "")]
		public unsafe LocalAuthenticationResult (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord lastAuthorized, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> completeResultFromCache, global::Com.Microsoft.Identity.Common.Internal.Request.SdkType sdkType, bool isServicedFromCache) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Ljava/util/List;Lcom/microsoft/identity/common/internal/request/SdkType;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_completeResultFromCache = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (completeResultFromCache);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((lastAuthorized == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lastAuthorized).Handle);
				__args [1] = new JniArgumentValue (native_completeResultFromCache);
				__args [2] = new JniArgumentValue ((sdkType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdkType).Handle);
				__args [3] = new JniArgumentValue (isServicedFromCache);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_completeResultFromCache);
				global::System.GC.KeepAlive (lastAuthorized);
				global::System.GC.KeepAlive (completeResultFromCache);
				global::System.GC.KeepAlive (sdkType);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccessTokenRecord);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord AccessTokenRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getAccessTokenRecord' and count(parameter)=0]"
			[Register ("getAccessTokenRecord", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;", "GetGetAccessTokenRecordHandler")]
			get {
				const string __id = "getAccessTokenRecord.()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountRecord);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord AccountRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getAccountRecord' and count(parameter)=0]"
			[Register ("getAccountRecord", "()Lcom/microsoft/identity/common/internal/dto/IAccountRecord;", "GetGetAccountRecordHandler")]
			get {
				const string __id = "getAccountRecord.()Lcom/microsoft/identity/common/internal/dto/IAccountRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.CacheRecordWithTenantProfileData);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> CacheRecordWithTenantProfileData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getCacheRecordWithTenantProfileData' and count(parameter)=0]"
			[Register ("getCacheRecordWithTenantProfileData", "()Ljava/util/List;", "GetGetCacheRecordWithTenantProfileDataHandler")]
			get {
				const string __id = "getCacheRecordWithTenantProfileData.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		static Delegate cb_setCorrelationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCorrelationId_Ljava_lang_String_Handler ()
		{
			if (cb_setCorrelationId_Ljava_lang_String_ == null)
				cb_setCorrelationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCorrelationId_Ljava_lang_String_);
			return cb_setCorrelationId_Ljava_lang_String_;
		}

		static void n_SetCorrelationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
			__this.CorrelationId = correlationId;
		}
#pragma warning restore 0169

		public virtual unsafe string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getCorrelationId' and count(parameter)=0]"
			[Register ("getCorrelationId", "()Ljava/lang/String;", "GetGetCorrelationIdHandler")]
			get {
				const string __id = "getCorrelationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='setCorrelationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCorrelationId", "(Ljava/lang/String;)V", "GetSetCorrelationId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCorrelationId.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpiresOn);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date ExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getExpiresOn' and count(parameter)=0]"
			[Register ("getExpiresOn", "()Ljava/util/Date;", "GetGetExpiresOnHandler")]
			get {
				const string __id = "getExpiresOn.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyId);
		}
#pragma warning restore 0169

		public virtual unsafe string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler")]
			get {
				const string __id = "getFamilyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdToken);
		}
#pragma warning restore 0169

		public virtual unsafe string IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Ljava/lang/String;", "GetGetIdTokenHandler")]
			get {
				const string __id = "getIdToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsServicedFromCache;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsServicedFromCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='isServicedFromCache' and count(parameter)=0]"
			[Register ("isServicedFromCache", "()Z", "GetIsServicedFromCacheHandler")]
			get {
				const string __id = "isServicedFromCache.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				const string __id = "getRefreshToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshTokenAge);
		}
#pragma warning restore 0169

		static Delegate cb_setRefreshTokenAge_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefreshTokenAge_Ljava_lang_String_Handler ()
		{
			if (cb_setRefreshTokenAge_Ljava_lang_String_ == null)
				cb_setRefreshTokenAge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefreshTokenAge_Ljava_lang_String_);
			return cb_setRefreshTokenAge_Ljava_lang_String_;
		}

		static void n_SetRefreshTokenAge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshTokenAge)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshTokenAge = JNIEnv.GetString (native_refreshTokenAge, JniHandleOwnership.DoNotTransfer);
			__this.RefreshTokenAge = refreshTokenAge;
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshTokenAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getRefreshTokenAge' and count(parameter)=0]"
			[Register ("getRefreshTokenAge", "()Ljava/lang/String;", "GetGetRefreshTokenAgeHandler")]
			get {
				const string __id = "getRefreshTokenAge.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='setRefreshTokenAge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefreshTokenAge", "(Ljava/lang/String;)V", "GetSetRefreshTokenAge_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRefreshTokenAge.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpeRing);
		}
#pragma warning restore 0169

		static Delegate cb_setSpeRing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSpeRing_Ljava_lang_String_Handler ()
		{
			if (cb_setSpeRing_Ljava_lang_String_ == null)
				cb_setSpeRing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSpeRing_Ljava_lang_String_);
			return cb_setSpeRing_Ljava_lang_String_;
		}

		static void n_SetSpeRing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_speRing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var speRing = JNIEnv.GetString (native_speRing, JniHandleOwnership.DoNotTransfer);
			__this.SpeRing = speRing;
		}
#pragma warning restore 0169

		public virtual unsafe string SpeRing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getSpeRing' and count(parameter)=0]"
			[Register ("getSpeRing", "()Ljava/lang/String;", "GetGetSpeRingHandler")]
			get {
				const string __id = "getSpeRing.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='setSpeRing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSpeRing", "(Ljava/lang/String;)V", "GetSetSpeRing_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSpeRing.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		public virtual unsafe string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler")]
			get {
				const string __id = "getTenantId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueId);
		}
#pragma warning restore 0169

		public virtual unsafe string UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Ljava/lang/String;", "GetGetUniqueIdHandler")]
			get {
				const string __id = "getUniqueId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.LocalAuthenticationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetScope ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='LocalAuthenticationResult']/method[@name='getScope' and count(parameter)=0]"
		[Register ("getScope", "()[Ljava/lang/String;", "GetGetScopeHandler")]
		public virtual unsafe string[] GetScope ()
		{
			const string __id = "getScope.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
