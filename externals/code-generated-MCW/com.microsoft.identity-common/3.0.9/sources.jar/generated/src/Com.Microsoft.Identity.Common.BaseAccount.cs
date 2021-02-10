using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/BaseAccount", DoNotGenerateAcw=true)]
	public abstract partial class BaseAccount : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/BaseAccount", typeof (BaseAccount));

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

		protected BaseAccount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/constructor[@name='BaseAccount' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseAccount () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCacheIdentifiers;
#pragma warning disable 0169
		static Delegate GetGetCacheIdentifiersHandler ()
		{
			if (cb_getCacheIdentifiers == null)
				cb_getCacheIdentifiers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCacheIdentifiers);
			return cb_getCacheIdentifiers;
		}

		static IntPtr n_GetCacheIdentifiers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CacheIdentifiers);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<string> CacheIdentifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getCacheIdentifiers' and count(parameter)=0]"
			[Register ("getCacheIdentifiers", "()Ljava/util/List;", "GetGetCacheIdentifiersHandler")]
			get; 
		}

		static Delegate cb_getUniqueIdentifier;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdentifierHandler ()
		{
			if (cb_getUniqueIdentifier == null)
				cb_getUniqueIdentifier = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUniqueIdentifier);
			return cb_getUniqueIdentifier;
		}

		static IntPtr n_GetUniqueIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueIdentifier);
		}
#pragma warning restore 0169

		public abstract string UniqueIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getUniqueIdentifier' and count(parameter)=0]"
			[Register ("getUniqueIdentifier", "()Ljava/lang/String;", "GetGetUniqueIdentifierHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlternativeAccountId);
		}
#pragma warning restore 0169

		public abstract string AlternativeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getAlternativeAccountId' and count(parameter)=0]"
			[Register ("getAlternativeAccountId", "()Ljava/lang/String;", "GetGetAlternativeAccountIdHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityType);
		}
#pragma warning restore 0169

		public abstract string AuthorityType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getAuthorityType' and count(parameter)=0]"
			[Register ("getAuthorityType", "()Ljava/lang/String;", "GetGetAuthorityTypeHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvatarUrl);
		}
#pragma warning restore 0169

		public abstract string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getAvatarUrl' and count(parameter)=0]"
			[Register ("getAvatarUrl", "()Ljava/lang/String;", "GetGetAvatarUrlHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientInfo);
		}
#pragma warning restore 0169

		public abstract string ClientInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getClientInfo' and count(parameter)=0]"
			[Register ("getClientInfo", "()Ljava/lang/String;", "GetGetClientInfoHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		public abstract string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyName);
		}
#pragma warning restore 0169

		public abstract string FamilyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getFamilyName' and count(parameter)=0]"
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		public abstract string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		public abstract string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalAccountId);
		}
#pragma warning restore 0169

		public abstract string LocalAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getLocalAccountId' and count(parameter)=0]"
			[Register ("getLocalAccountId", "()Ljava/lang/String;", "GetGetLocalAccountIdHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		public abstract string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Realm);
		}
#pragma warning restore 0169

		public abstract string Realm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getRealm' and count(parameter)=0]"
			[Register ("getRealm", "()Ljava/lang/String;", "GetGetRealmHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.BaseAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		public abstract string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/BaseAccount", DoNotGenerateAcw=true)]
	internal partial class BaseAccountInvoker : BaseAccount {
		public BaseAccountInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/BaseAccount", typeof (BaseAccountInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::System.Collections.Generic.IList<string> CacheIdentifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getCacheIdentifiers' and count(parameter)=0]"
			[Register ("getCacheIdentifiers", "()Ljava/util/List;", "GetGetCacheIdentifiersHandler")]
			get {
				const string __id = "getCacheIdentifiers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string UniqueIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getUniqueIdentifier' and count(parameter)=0]"
			[Register ("getUniqueIdentifier", "()Ljava/lang/String;", "GetGetUniqueIdentifierHandler")]
			get {
				const string __id = "getUniqueIdentifier.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string AlternativeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getAlternativeAccountId' and count(parameter)=0]"
			[Register ("getAlternativeAccountId", "()Ljava/lang/String;", "GetGetAlternativeAccountIdHandler")]
			get {
				const string __id = "getAlternativeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string AuthorityType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getAuthorityType' and count(parameter)=0]"
			[Register ("getAuthorityType", "()Ljava/lang/String;", "GetGetAuthorityTypeHandler")]
			get {
				const string __id = "getAuthorityType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getAvatarUrl' and count(parameter)=0]"
			[Register ("getAvatarUrl", "()Ljava/lang/String;", "GetGetAvatarUrlHandler")]
			get {
				const string __id = "getAvatarUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string ClientInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getClientInfo' and count(parameter)=0]"
			[Register ("getClientInfo", "()Ljava/lang/String;", "GetGetClientInfoHandler")]
			get {
				const string __id = "getClientInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get {
				const string __id = "getEnvironment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string FamilyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getFamilyName' and count(parameter)=0]"
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler")]
			get {
				const string __id = "getFamilyName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				const string __id = "getFirstName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get {
				const string __id = "getHomeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string LocalAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getLocalAccountId' and count(parameter)=0]"
			[Register ("getLocalAccountId", "()Ljava/lang/String;", "GetGetLocalAccountIdHandler")]
			get {
				const string __id = "getLocalAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler")]
			get {
				const string __id = "getMiddleName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Realm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getRealm' and count(parameter)=0]"
			[Register ("getRealm", "()Ljava/lang/String;", "GetGetRealmHandler")]
			get {
				const string __id = "getRealm.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BaseAccount']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				const string __id = "getUsername.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
