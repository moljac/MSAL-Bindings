using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='IBrokerResultAdapter']"
	[Register ("com/microsoft/identity/common/internal/result/IBrokerResultAdapter", "", "Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapterInvoker")]
	public partial interface IBrokerResultAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='IBrokerResultAdapter']/method[@name='authenticationResultFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("authenticationResultFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;", "GetAuthenticationResultFromBundle_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult AuthenticationResultFromBundle (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='IBrokerResultAdapter']/method[@name='bundleFromAuthenticationResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromAuthenticationResult", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapterInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle BundleFromAuthenticationResult (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='IBrokerResultAdapter']/method[@name='bundleFromBaseException' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.exception.BaseException'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromBaseException", "(Lcom/microsoft/identity/common/exception/BaseException;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapterInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle BundleFromBaseException (global::Com.Microsoft.Identity.Common.Exception.BaseException p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/interface[@name='IBrokerResultAdapter']/method[@name='getBaseExceptionFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getBaseExceptionFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/exception/BaseException;", "GetGetBaseExceptionFromBundle_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapterInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Exception.BaseException GetBaseExceptionFromBundle (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/IBrokerResultAdapter", DoNotGenerateAcw=true)]
	internal partial class IBrokerResultAdapterInvoker : global::Java.Lang.Object, IBrokerResultAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/IBrokerResultAdapter", typeof (IBrokerResultAdapterInvoker));

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

		public static IBrokerResultAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBrokerResultAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.result.IBrokerResultAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBrokerResultAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_authenticationResultFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAuthenticationResultFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_authenticationResultFromBundle_Landroid_os_Bundle_ == null)
				cb_authenticationResultFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AuthenticationResultFromBundle_Landroid_os_Bundle_);
			return cb_authenticationResultFromBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_AuthenticationResultFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AuthenticationResultFromBundle (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_authenticationResultFromBundle_Landroid_os_Bundle_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult AuthenticationResultFromBundle (global::Android.OS.Bundle p0)
		{
			if (id_authenticationResultFromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_authenticationResultFromBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "authenticationResultFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticationResultFromBundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_Handler ()
		{
			if (cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ == null)
				cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_BundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_);
			return cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_;
		}

		static IntPtr n_BundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromAuthenticationResult (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_;
		public unsafe global::Android.OS.Bundle BundleFromAuthenticationResult (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult p0, string p1)
		{
			if (id_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ == IntPtr.Zero)
				id_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bundleFromAuthenticationResult", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_Handler ()
		{
			if (cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ == null)
				cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_BundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_);
			return cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_;
		}

		static IntPtr n_BundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromBaseException (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_;
		public unsafe global::Android.OS.Bundle BundleFromBaseException (global::Com.Microsoft.Identity.Common.Exception.BaseException p0, string p1)
		{
			if (id_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ == IntPtr.Zero)
				id_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bundleFromBaseException", "(Lcom/microsoft/identity/common/exception/BaseException;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getBaseExceptionFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetBaseExceptionFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getBaseExceptionFromBundle_Landroid_os_Bundle_ == null)
				cb_getBaseExceptionFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetBaseExceptionFromBundle_Landroid_os_Bundle_);
			return cb_getBaseExceptionFromBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetBaseExceptionFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBaseExceptionFromBundle (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBaseExceptionFromBundle_Landroid_os_Bundle_;
		public unsafe global::Com.Microsoft.Identity.Common.Exception.BaseException GetBaseExceptionFromBundle (global::Android.OS.Bundle p0)
		{
			if (id_getBaseExceptionFromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getBaseExceptionFromBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getBaseExceptionFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/exception/BaseException;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseExceptionFromBundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
