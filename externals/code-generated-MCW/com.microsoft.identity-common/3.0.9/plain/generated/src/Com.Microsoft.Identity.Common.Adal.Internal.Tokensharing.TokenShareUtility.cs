using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/tokensharing/TokenShareUtility", DoNotGenerateAcw=true)]
	public partial class TokenShareUtility : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/tokensharing/TokenShareUtility", typeof (TokenShareUtility));

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

		protected TokenShareUtility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getMsaFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsaFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_getMsaFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_getMsaFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMsaFamilyRefreshToken_Ljava_lang_String_);
			return cb_getMsaFamilyRefreshToken_Ljava_lang_String_;
		}

		static IntPtr n_GetMsaFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMsaFamilyRefreshToken (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']/method[@name='getMsaFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsaFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMsaFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe string GetMsaFamilyRefreshToken (string identifier)
		{
			const string __id = "getMsaFamilyRefreshToken.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler ()
		{
			if (cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == null)
				cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_);
			return cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		}

		static IntPtr n_GetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMsaFamilyRefreshTokenWithMetadata (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']/method[@name='getMsaFamilyRefreshTokenWithMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsaFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;", "GetGetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal GetMsaFamilyRefreshTokenWithMetadata (string identifier)
		{
			const string __id = "getMsaFamilyRefreshTokenWithMetadata.(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOrgIdFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrgIdFamilyRefreshToken_Ljava_lang_String_);
			return cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
		}

		static IntPtr n_GetOrgIdFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetOrgIdFamilyRefreshToken (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']/method[@name='getOrgIdFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrgIdFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetOrgIdFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe string GetOrgIdFamilyRefreshToken (string identifier)
		{
			const string __id = "getOrgIdFamilyRefreshToken.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler ()
		{
			if (cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == null)
				cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_);
			return cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		}

		static IntPtr n_GetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrgIdFamilyRefreshTokenWithMetadata (identifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']/method[@name='getOrgIdFamilyRefreshTokenWithMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrgIdFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;", "GetGetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal GetOrgIdFamilyRefreshTokenWithMetadata (string identifier)
		{
			const string __id = "getOrgIdFamilyRefreshTokenWithMetadata.(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;";
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_saveMsaFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveMsaFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveMsaFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_saveMsaFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveMsaFamilyRefreshToken_Ljava_lang_String_);
			return cb_saveMsaFamilyRefreshToken_Ljava_lang_String_;
		}

		static void n_SaveMsaFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			__this.SaveMsaFamilyRefreshToken (refreshToken);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']/method[@name='saveMsaFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveMsaFamilyRefreshToken", "(Ljava/lang/String;)V", "GetSaveMsaFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveMsaFamilyRefreshToken (string refreshToken)
		{
			const string __id = "saveMsaFamilyRefreshToken.(Ljava/lang/String;)V";
			IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refreshToken);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refreshToken);
			}
		}

		static Delegate cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveOrgIdFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveOrgIdFamilyRefreshToken_Ljava_lang_String_);
			return cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
		}

		static void n_SaveOrgIdFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ssoStateSerializerBlob)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ssoStateSerializerBlob = JNIEnv.GetString (native_ssoStateSerializerBlob, JniHandleOwnership.DoNotTransfer);
			__this.SaveOrgIdFamilyRefreshToken (ssoStateSerializerBlob);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareUtility']/method[@name='saveOrgIdFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveOrgIdFamilyRefreshToken", "(Ljava/lang/String;)V", "GetSaveOrgIdFamilyRefreshToken_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveOrgIdFamilyRefreshToken (string ssoStateSerializerBlob)
		{
			const string __id = "saveOrgIdFamilyRefreshToken.(Ljava/lang/String;)V";
			IntPtr native_ssoStateSerializerBlob = JNIEnv.NewString (ssoStateSerializerBlob);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ssoStateSerializerBlob);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ssoStateSerializerBlob);
			}
		}

	}
}
