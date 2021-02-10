using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheRecord']"
	[Register ("com/microsoft/identity/common/internal/cache/ICacheRecord", "", "Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecordInvoker")]
	public partial interface ICacheRecord : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheRecord']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;", "GetGetAccessTokenHandler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheRecord']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGetAccountHandler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheRecord']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "GetGetIdTokenHandler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheRecord']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;", "GetGetRefreshTokenHandler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord V1IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ICacheRecord']/method[@name='getV1IdToken' and count(parameter)=0]"
			[Register ("getV1IdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "GetGetV1IdTokenHandler:Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/ICacheRecord", DoNotGenerateAcw=true)]
	internal partial class ICacheRecordInvoker : global::Java.Lang.Object, ICacheRecord {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/ICacheRecord", typeof (ICacheRecordInvoker));

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

		public static ICacheRecord GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICacheRecord> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.ICacheRecord"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheRecordInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccessToken);
		}
#pragma warning restore 0169

		IntPtr id_getAccessToken;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord AccessToken {
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		IntPtr id_getAccount;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord Account {
			get {
				if (id_getAccount == IntPtr.Zero)
					id_getAccount = JNIEnv.GetMethodID (class_ref, "getAccount", "()Lcom/microsoft/identity/common/internal/dto/AccountRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccount), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdToken);
		}
#pragma warning restore 0169

		IntPtr id_getIdToken;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord IdToken {
			get {
				if (id_getIdToken == IntPtr.Zero)
					id_getIdToken = JNIEnv.GetMethodID (class_ref, "getIdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdToken), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshToken);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshToken;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord RefreshToken {
			get {
				if (id_getRefreshToken == IntPtr.Zero)
					id_getRefreshToken = JNIEnv.GetMethodID (class_ref, "getRefreshToken", "()Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getV1IdToken;
#pragma warning disable 0169
		static Delegate GetGetV1IdTokenHandler ()
		{
			if (cb_getV1IdToken == null)
				cb_getV1IdToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetV1IdToken);
			return cb_getV1IdToken;
		}

		static IntPtr n_GetV1IdToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.V1IdToken);
		}
#pragma warning restore 0169

		IntPtr id_getV1IdToken;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord V1IdToken {
			get {
				if (id_getV1IdToken == IntPtr.Zero)
					id_getV1IdToken = JNIEnv.GetMethodID (class_ref, "getV1IdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getV1IdToken), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
