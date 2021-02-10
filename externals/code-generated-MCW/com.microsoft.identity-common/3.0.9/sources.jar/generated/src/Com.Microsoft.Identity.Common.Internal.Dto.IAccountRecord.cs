using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']"
	[Register ("com/microsoft/identity/common/internal/dto/IAccountRecord", "", "Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker")]
	public partial interface IAccountRecord : IJavaObject, IJavaPeerable {
		string AlternativeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getAlternativeAccountId' and count(parameter)=0]"
			[Register ("getAlternativeAccountId", "()Ljava/lang/String;", "GetGetAlternativeAccountIdHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string AuthorityType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getAuthorityType' and count(parameter)=0]"
			[Register ("getAuthorityType", "()Ljava/lang/String;", "GetGetAuthorityTypeHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getAvatarUrl' and count(parameter)=0]"
			[Register ("getAvatarUrl", "()Ljava/lang/String;", "GetGetAvatarUrlHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string ClientInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getClientInfo' and count(parameter)=0]"
			[Register ("getClientInfo", "()Ljava/lang/String;", "GetGetClientInfoHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string FamilyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getFamilyName' and count(parameter)=0]"
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string LocalAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getLocalAccountId' and count(parameter)=0]"
			[Register ("getLocalAccountId", "()Ljava/lang/String;", "GetGetLocalAccountIdHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Realm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getRealm' and count(parameter)=0]"
			[Register ("getRealm", "()Ljava/lang/String;", "GetGetRealmHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IAccountRecord']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler:Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/IAccountRecord", DoNotGenerateAcw=true)]
	internal partial class IAccountRecordInvoker : global::Java.Lang.Object, IAccountRecord {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/IAccountRecord", typeof (IAccountRecordInvoker));

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

		public static IAccountRecord GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccountRecord> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.dto.IAccountRecord"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccountRecordInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAlternativeAccountId;
#pragma warning disable 0169
		static Delegate GetGetAlternativeAccountIdHandler ()
		{
			if (cb_getAlternativeAccountId == null)
				cb_getAlternativeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAlternativeAccountId);
			return cb_getAlternativeAccountId;
		}

		static IntPtr n_GetAlternativeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlternativeAccountId);
		}
#pragma warning restore 0169

		IntPtr id_getAlternativeAccountId;
		public unsafe string AlternativeAccountId {
			get {
				if (id_getAlternativeAccountId == IntPtr.Zero)
					id_getAlternativeAccountId = JNIEnv.GetMethodID (class_ref, "getAlternativeAccountId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlternativeAccountId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAuthorityType;
#pragma warning disable 0169
		static Delegate GetGetAuthorityTypeHandler ()
		{
			if (cb_getAuthorityType == null)
				cb_getAuthorityType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityType);
			return cb_getAuthorityType;
		}

		static IntPtr n_GetAuthorityType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityType);
		}
#pragma warning restore 0169

		IntPtr id_getAuthorityType;
		public unsafe string AuthorityType {
			get {
				if (id_getAuthorityType == IntPtr.Zero)
					id_getAuthorityType = JNIEnv.GetMethodID (class_ref, "getAuthorityType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthorityType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAvatarUrl;
#pragma warning disable 0169
		static Delegate GetGetAvatarUrlHandler ()
		{
			if (cb_getAvatarUrl == null)
				cb_getAvatarUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAvatarUrl);
			return cb_getAvatarUrl;
		}

		static IntPtr n_GetAvatarUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvatarUrl);
		}
#pragma warning restore 0169

		IntPtr id_getAvatarUrl;
		public unsafe string AvatarUrl {
			get {
				if (id_getAvatarUrl == IntPtr.Zero)
					id_getAvatarUrl = JNIEnv.GetMethodID (class_ref, "getAvatarUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAvatarUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getClientInfo;
#pragma warning disable 0169
		static Delegate GetGetClientInfoHandler ()
		{
			if (cb_getClientInfo == null)
				cb_getClientInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientInfo);
			return cb_getClientInfo;
		}

		static IntPtr n_GetClientInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientInfo);
		}
#pragma warning restore 0169

		IntPtr id_getClientInfo;
		public unsafe string ClientInfo {
			get {
				if (id_getClientInfo == IntPtr.Zero)
					id_getClientInfo = JNIEnv.GetMethodID (class_ref, "getClientInfo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnvironment);
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		IntPtr id_getEnvironment;
		public unsafe string Environment {
			get {
				if (id_getEnvironment == IntPtr.Zero)
					id_getEnvironment = JNIEnv.GetMethodID (class_ref, "getEnvironment", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnvironment), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFamilyName;
#pragma warning disable 0169
		static Delegate GetGetFamilyNameHandler ()
		{
			if (cb_getFamilyName == null)
				cb_getFamilyName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFamilyName);
			return cb_getFamilyName;
		}

		static IntPtr n_GetFamilyName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyName);
		}
#pragma warning restore 0169

		IntPtr id_getFamilyName;
		public unsafe string FamilyName {
			get {
				if (id_getFamilyName == IntPtr.Zero)
					id_getFamilyName = JNIEnv.GetMethodID (class_ref, "getFamilyName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFamilyName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		IntPtr id_getFirstName;
		public unsafe string FirstName {
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHomeAccountId;
#pragma warning disable 0169
		static Delegate GetGetHomeAccountIdHandler ()
		{
			if (cb_getHomeAccountId == null)
				cb_getHomeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHomeAccountId);
			return cb_getHomeAccountId;
		}

		static IntPtr n_GetHomeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		IntPtr id_getHomeAccountId;
		public unsafe string HomeAccountId {
			get {
				if (id_getHomeAccountId == IntPtr.Zero)
					id_getHomeAccountId = JNIEnv.GetMethodID (class_ref, "getHomeAccountId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHomeAccountId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocalAccountId;
#pragma warning disable 0169
		static Delegate GetGetLocalAccountIdHandler ()
		{
			if (cb_getLocalAccountId == null)
				cb_getLocalAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalAccountId);
			return cb_getLocalAccountId;
		}

		static IntPtr n_GetLocalAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalAccountId);
		}
#pragma warning restore 0169

		IntPtr id_getLocalAccountId;
		public unsafe string LocalAccountId {
			get {
				if (id_getLocalAccountId == IntPtr.Zero)
					id_getLocalAccountId = JNIEnv.GetMethodID (class_ref, "getLocalAccountId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalAccountId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMiddleName;
#pragma warning disable 0169
		static Delegate GetGetMiddleNameHandler ()
		{
			if (cb_getMiddleName == null)
				cb_getMiddleName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiddleName);
			return cb_getMiddleName;
		}

		static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		IntPtr id_getMiddleName;
		public unsafe string MiddleName {
			get {
				if (id_getMiddleName == IntPtr.Zero)
					id_getMiddleName = JNIEnv.GetMethodID (class_ref, "getMiddleName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddleName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRealm;
#pragma warning disable 0169
		static Delegate GetGetRealmHandler ()
		{
			if (cb_getRealm == null)
				cb_getRealm = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRealm);
			return cb_getRealm;
		}

		static IntPtr n_GetRealm (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Realm);
		}
#pragma warning restore 0169

		IntPtr id_getRealm;
		public unsafe string Realm {
			get {
				if (id_getRealm == IntPtr.Zero)
					id_getRealm = JNIEnv.GetMethodID (class_ref, "getRealm", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRealm), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		IntPtr id_getUsername;
		public unsafe string Username {
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
