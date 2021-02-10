using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']"
	[Register ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareInternal", "", "Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker")]
	public partial interface ITokenShareInternal : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']/method[@name='getMsaFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsaFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMsaFamilyRefreshToken_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker, Microsoft.Identity.Common")]
		string GetMsaFamilyRefreshToken (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']/method[@name='getMsaFamilyRefreshTokenWithMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsaFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;", "GetGetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal GetMsaFamilyRefreshTokenWithMetadata (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']/method[@name='getOrgIdFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrgIdFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetOrgIdFamilyRefreshToken_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker, Microsoft.Identity.Common")]
		string GetOrgIdFamilyRefreshToken (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']/method[@name='getOrgIdFamilyRefreshTokenWithMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrgIdFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;", "GetGetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal GetOrgIdFamilyRefreshTokenWithMetadata (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']/method[@name='saveMsaFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveMsaFamilyRefreshToken", "(Ljava/lang/String;)V", "GetSaveMsaFamilyRefreshToken_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker, Microsoft.Identity.Common")]
		void SaveMsaFamilyRefreshToken (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareInternal']/method[@name='saveOrgIdFamilyRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveOrgIdFamilyRefreshToken", "(Ljava/lang/String;)V", "GetSaveOrgIdFamilyRefreshToken_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternalInvoker, Microsoft.Identity.Common")]
		void SaveOrgIdFamilyRefreshToken (string p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareInternal", DoNotGenerateAcw=true)]
	internal partial class ITokenShareInternalInvoker : global::Java.Lang.Object, ITokenShareInternal {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareInternal", typeof (ITokenShareInternalInvoker));

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

		public static ITokenShareInternal GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenShareInternal> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.tokensharing.ITokenShareInternal"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenShareInternalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMsaFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsaFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_getMsaFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_getMsaFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMsaFamilyRefreshToken_Ljava_lang_String_);
			return cb_getMsaFamilyRefreshToken_Ljava_lang_String_;
		}

		static IntPtr n_GetMsaFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMsaFamilyRefreshToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMsaFamilyRefreshToken_Ljava_lang_String_;
		public unsafe string GetMsaFamilyRefreshToken (string p0)
		{
			if (id_getMsaFamilyRefreshToken_Ljava_lang_String_ == IntPtr.Zero)
				id_getMsaFamilyRefreshToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMsaFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsaFamilyRefreshToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler ()
		{
			if (cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == null)
				cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_);
			return cb_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		}

		static IntPtr n_GetMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMsaFamilyRefreshTokenWithMetadata (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal GetMsaFamilyRefreshTokenWithMetadata (string p0)
		{
			if (id_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == IntPtr.Zero)
				id_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMsaFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsaFamilyRefreshTokenWithMetadata_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOrgIdFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrgIdFamilyRefreshToken_Ljava_lang_String_);
			return cb_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
		}

		static IntPtr n_GetOrgIdFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetOrgIdFamilyRefreshToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOrgIdFamilyRefreshToken_Ljava_lang_String_;
		public unsafe string GetOrgIdFamilyRefreshToken (string p0)
		{
			if (id_getOrgIdFamilyRefreshToken_Ljava_lang_String_ == IntPtr.Zero)
				id_getOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getOrgIdFamilyRefreshToken", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrgIdFamilyRefreshToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_Handler ()
		{
			if (cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == null)
				cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_);
			return cb_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		}

		static IntPtr n_GetOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrgIdFamilyRefreshTokenWithMetadata (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal GetOrgIdFamilyRefreshTokenWithMetadata (string p0)
		{
			if (id_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ == IntPtr.Zero)
				id_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getOrgIdFamilyRefreshTokenWithMetadata", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrgIdFamilyRefreshTokenWithMetadata_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_saveMsaFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveMsaFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveMsaFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_saveMsaFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveMsaFamilyRefreshToken_Ljava_lang_String_);
			return cb_saveMsaFamilyRefreshToken_Ljava_lang_String_;
		}

		static void n_SaveMsaFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveMsaFamilyRefreshToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveMsaFamilyRefreshToken_Ljava_lang_String_;
		public unsafe void SaveMsaFamilyRefreshToken (string p0)
		{
			if (id_saveMsaFamilyRefreshToken_Ljava_lang_String_ == IntPtr.Zero)
				id_saveMsaFamilyRefreshToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveMsaFamilyRefreshToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveMsaFamilyRefreshToken_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveOrgIdFamilyRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ == null)
				cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveOrgIdFamilyRefreshToken_Ljava_lang_String_);
			return cb_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
		}

		static void n_SaveOrgIdFamilyRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveOrgIdFamilyRefreshToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveOrgIdFamilyRefreshToken_Ljava_lang_String_;
		public unsafe void SaveOrgIdFamilyRefreshToken (string p0)
		{
			if (id_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ == IntPtr.Zero)
				id_saveOrgIdFamilyRefreshToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveOrgIdFamilyRefreshToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveOrgIdFamilyRefreshToken_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
