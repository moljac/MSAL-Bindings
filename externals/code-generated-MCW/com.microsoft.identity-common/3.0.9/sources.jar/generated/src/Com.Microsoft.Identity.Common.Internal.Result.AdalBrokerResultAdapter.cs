using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AdalBrokerResultAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/AdalBrokerResultAdapter", DoNotGenerateAcw=true)]
	public partial class AdalBrokerResultAdapter : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/AdalBrokerResultAdapter", typeof (AdalBrokerResultAdapter));

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

		protected AdalBrokerResultAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AdalBrokerResultAdapter']/constructor[@name='AdalBrokerResultAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdalBrokerResultAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_authenticationResultFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAuthenticationResultFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_authenticationResultFromBundle_Landroid_os_Bundle_ == null)
				cb_authenticationResultFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AuthenticationResultFromBundle_Landroid_os_Bundle_);
			return cb_authenticationResultFromBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_AuthenticationResultFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AdalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AuthenticationResultFromBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AdalBrokerResultAdapter']/method[@name='authenticationResultFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("authenticationResultFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;", "GetAuthenticationResultFromBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult AuthenticationResultFromBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "authenticationResultFromBundle.(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

		static Delegate cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_Handler ()
		{
			if (cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ == null)
				cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_BundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_);
			return cb_bundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_;
		}

		static IntPtr n_BundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authenticationResult, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AdalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authenticationResult = (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (native_authenticationResult, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromAuthenticationResult (authenticationResult, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AdalBrokerResultAdapter']/method[@name='bundleFromAuthenticationResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromAuthenticationResult", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromAuthenticationResult_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle BundleFromAuthenticationResult (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult authenticationResult, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "bundleFromAuthenticationResult.(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((authenticationResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationResult).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (authenticationResult);
			}
		}

		static Delegate cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_Handler ()
		{
			if (cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ == null)
				cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_BundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_);
			return cb_bundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_;
		}

		static IntPtr n_BundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseException, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AdalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var baseException = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (native_baseException, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromBaseException (baseException, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AdalBrokerResultAdapter']/method[@name='bundleFromBaseException' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.exception.BaseException'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromBaseException", "(Lcom/microsoft/identity/common/exception/BaseException;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle BundleFromBaseException (global::Com.Microsoft.Identity.Common.Exception.BaseException baseException, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "bundleFromBaseException.(Lcom/microsoft/identity/common/exception/BaseException;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((baseException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) baseException).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (baseException);
			}
		}

		static Delegate cb_getBaseExceptionFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetBaseExceptionFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getBaseExceptionFromBundle_Landroid_os_Bundle_ == null)
				cb_getBaseExceptionFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetBaseExceptionFromBundle_Landroid_os_Bundle_);
			return cb_getBaseExceptionFromBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetBaseExceptionFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AdalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBaseExceptionFromBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='AdalBrokerResultAdapter']/method[@name='getBaseExceptionFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getBaseExceptionFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/exception/BaseException;", "GetGetBaseExceptionFromBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Exception.BaseException GetBaseExceptionFromBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "getBaseExceptionFromBundle.(Landroid/os/Bundle;)Lcom/microsoft/identity/common/exception/BaseException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

	}
}
