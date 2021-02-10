using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/ADALUserInfo", DoNotGenerateAcw=true)]
	public partial class ADALUserInfo : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/ADALUserInfo", typeof (ADALUserInfo));

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

		protected ADALUserInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/constructor[@name='ADALUserInfo' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)V", "")]
		public unsafe ADALUserInfo (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult localAuthenticationResult) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((localAuthenticationResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localAuthenticationResult).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (localAuthenticationResult);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/constructor[@name='ADALUserInfo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ADALUserInfo (string userid, string givenName, string familyName, string identityProvider, string displayableId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userid = JNIEnv.NewString (userid);
			IntPtr native_givenName = JNIEnv.NewString (givenName);
			IntPtr native_familyName = JNIEnv.NewString (familyName);
			IntPtr native_identityProvider = JNIEnv.NewString (identityProvider);
			IntPtr native_displayableId = JNIEnv.NewString (displayableId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_userid);
				__args [1] = new JniArgumentValue (native_givenName);
				__args [2] = new JniArgumentValue (native_familyName);
				__args [3] = new JniArgumentValue (native_identityProvider);
				__args [4] = new JniArgumentValue (native_displayableId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userid);
				JNIEnv.DeleteLocalRef (native_givenName);
				JNIEnv.DeleteLocalRef (native_familyName);
				JNIEnv.DeleteLocalRef (native_identityProvider);
				JNIEnv.DeleteLocalRef (native_displayableId);
			}
		}

		static Delegate cb_getDisplayableId;
#pragma warning disable 0169
		static Delegate GetGetDisplayableIdHandler ()
		{
			if (cb_getDisplayableId == null)
				cb_getDisplayableId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDisplayableId);
			return cb_getDisplayableId;
		}

		static IntPtr n_GetDisplayableId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayableId);
		}
#pragma warning restore 0169

		public virtual unsafe string DisplayableId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getDisplayableId' and count(parameter)=0]"
			[Register ("getDisplayableId", "()Ljava/lang/String;", "GetGetDisplayableIdHandler")]
			get {
				const string __id = "getDisplayableId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyName);
		}
#pragma warning restore 0169

		public virtual unsafe string FamilyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getFamilyName' and count(parameter)=0]"
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler")]
			get {
				const string __id = "getFamilyName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGivenName;
#pragma warning disable 0169
		static Delegate GetGetGivenNameHandler ()
		{
			if (cb_getGivenName == null)
				cb_getGivenName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGivenName);
			return cb_getGivenName;
		}

		static IntPtr n_GetGivenName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GivenName);
		}
#pragma warning restore 0169

		public virtual unsafe string GivenName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getGivenName' and count(parameter)=0]"
			[Register ("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler")]
			get {
				const string __id = "getGivenName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdentityProvider;
#pragma warning disable 0169
		static Delegate GetGetIdentityProviderHandler ()
		{
			if (cb_getIdentityProvider == null)
				cb_getIdentityProvider = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdentityProvider);
			return cb_getIdentityProvider;
		}

		static IntPtr n_GetIdentityProvider (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdentityProvider);
		}
#pragma warning restore 0169

		public virtual unsafe string IdentityProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getIdentityProvider' and count(parameter)=0]"
			[Register ("getIdentityProvider", "()Ljava/lang/String;", "GetGetIdentityProviderHandler")]
			get {
				const string __id = "getIdentityProvider.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPasswordChangeUrl;
#pragma warning disable 0169
		static Delegate GetGetPasswordChangeUrlHandler ()
		{
			if (cb_getPasswordChangeUrl == null)
				cb_getPasswordChangeUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPasswordChangeUrl);
			return cb_getPasswordChangeUrl;
		}

		static IntPtr n_GetPasswordChangeUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PasswordChangeUrl);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Net.Uri PasswordChangeUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getPasswordChangeUrl' and count(parameter)=0]"
			[Register ("getPasswordChangeUrl", "()Landroid/net/Uri;", "GetGetPasswordChangeUrlHandler")]
			get {
				const string __id = "getPasswordChangeUrl.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPasswordExpiresOn;
#pragma warning disable 0169
		static Delegate GetGetPasswordExpiresOnHandler ()
		{
			if (cb_getPasswordExpiresOn == null)
				cb_getPasswordExpiresOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPasswordExpiresOn);
			return cb_getPasswordExpiresOn;
		}

		static IntPtr n_GetPasswordExpiresOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PasswordExpiresOn);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date PasswordExpiresOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getPasswordExpiresOn' and count(parameter)=0]"
			[Register ("getPasswordExpiresOn", "()Ljava/util/Date;", "GetGetPasswordExpiresOnHandler")]
			get {
				const string __id = "getPasswordExpiresOn.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.ADALUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='ADALUserInfo']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				const string __id = "getUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
