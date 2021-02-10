using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/MsalBrokerResultAdapter", DoNotGenerateAcw=true)]
	public partial class MsalBrokerResultAdapter : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/MsalBrokerResultAdapter", typeof (MsalBrokerResultAdapter));

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

		protected MsalBrokerResultAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/constructor[@name='MsalBrokerResultAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MsalBrokerResultAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getExceptionForEmptyResultBundle;
#pragma warning disable 0169
		static Delegate GetGetExceptionForEmptyResultBundleHandler ()
		{
			if (cb_getExceptionForEmptyResultBundle == null)
				cb_getExceptionForEmptyResultBundle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExceptionForEmptyResultBundle);
			return cb_getExceptionForEmptyResultBundle;
		}

		static IntPtr n_GetExceptionForEmptyResultBundle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExceptionForEmptyResultBundle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Exception.ClientException ExceptionForEmptyResultBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getExceptionForEmptyResultBundle' and count(parameter)=0]"
			[Register ("getExceptionForEmptyResultBundle", "()Lcom/microsoft/identity/common/exception/ClientException;", "GetGetExceptionForEmptyResultBundleHandler")]
			get {
				const string __id = "getExceptionForEmptyResultBundle.()Lcom/microsoft/identity/common/exception/ClientException;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ClientException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AuthenticationResultFromBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='authenticationResultFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static Delegate cb_brokerResultFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetBrokerResultFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_brokerResultFromBundle_Landroid_os_Bundle_ == null)
				cb_brokerResultFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BrokerResultFromBundle_Landroid_os_Bundle_);
			return cb_brokerResultFromBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_BrokerResultFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BrokerResultFromBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='brokerResultFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("brokerResultFromBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/broker/BrokerResult;", "GetBrokerResultFromBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult BrokerResultFromBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "brokerResultFromBundle.(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/broker/BrokerResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

		static Delegate cb_bundleFromAccounts_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBundleFromAccounts_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_bundleFromAccounts_Ljava_util_List_Ljava_lang_String_ == null)
				cb_bundleFromAccounts_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_BundleFromAccounts_Ljava_util_List_Ljava_lang_String_);
			return cb_bundleFromAccounts_Ljava_util_List_Ljava_lang_String_;
		}

		static IntPtr n_BundleFromAccounts_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheRecords, IntPtr native_negotiatedProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheRecords = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (native_cacheRecords, JniHandleOwnership.DoNotTransfer);
			var negotiatedProtocolVersion = JNIEnv.GetString (native_negotiatedProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromAccounts (cacheRecords, negotiatedProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='bundleFromAccounts' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.common.internal.cache.ICacheRecord&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromAccounts", "(Ljava/util/List;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromAccounts_Ljava_util_List_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle BundleFromAccounts (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> cacheRecords, string negotiatedProtocolVersion)
		{
			const string __id = "bundleFromAccounts.(Ljava/util/List;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_cacheRecords = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (cacheRecords);
			IntPtr native_negotiatedProtocolVersion = JNIEnv.NewString (negotiatedProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cacheRecords);
				__args [1] = new JniArgumentValue (native_negotiatedProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheRecords);
				JNIEnv.DeleteLocalRef (native_negotiatedProtocolVersion);
				global::System.GC.KeepAlive (cacheRecords);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authenticationResult = (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (native_authenticationResult, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromAuthenticationResult (authenticationResult, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='bundleFromAuthenticationResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult'] and parameter[2][@type='java.lang.String']]"
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

		static IntPtr n_BundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (native_exception, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromBaseException (exception, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='bundleFromBaseException' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.exception.BaseException'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromBaseException", "(Lcom/microsoft/identity/common/exception/BaseException;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromBaseException_Lcom_microsoft_identity_common_exception_BaseException_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle BundleFromBaseException (global::Com.Microsoft.Identity.Common.Exception.BaseException exception, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "bundleFromBaseException.(Lcom/microsoft/identity/common/exception/BaseException;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (exception);
			}
		}

		static Delegate cb_bundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_Handler ()
		{
			if (cb_bundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_ == null)
				cb_bundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_BundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_);
			return cb_bundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_;
		}

		static IntPtr n_BundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brokerResult, IntPtr native_negotiatedBrokerProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var brokerResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (native_brokerResult, JniHandleOwnership.DoNotTransfer);
			var negotiatedBrokerProtocolVersion = JNIEnv.GetString (native_negotiatedBrokerProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BundleFromBrokerResult (brokerResult, negotiatedBrokerProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='bundleFromBrokerResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.broker.BrokerResult'] and parameter[2][@type='java.lang.String']]"
		[Register ("bundleFromBrokerResult", "(Lcom/microsoft/identity/common/internal/broker/BrokerResult;Ljava/lang/String;)Landroid/os/Bundle;", "GetBundleFromBrokerResult_Lcom_microsoft_identity_common_internal_broker_BrokerResult_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle BundleFromBrokerResult (global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult brokerResult, string negotiatedBrokerProtocolVersion)
		{
			const string __id = "bundleFromBrokerResult.(Lcom/microsoft/identity/common/internal/broker/BrokerResult;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_negotiatedBrokerProtocolVersion = JNIEnv.NewString (negotiatedBrokerProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((brokerResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) brokerResult).Handle);
				__args [1] = new JniArgumentValue (native_negotiatedBrokerProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_negotiatedBrokerProtocolVersion);
				global::System.GC.KeepAlive (brokerResult);
			}
		}

		static Delegate cb_bundleFromDeviceMode_Z;
#pragma warning disable 0169
		static Delegate GetBundleFromDeviceMode_ZHandler ()
		{
			if (cb_bundleFromDeviceMode_Z == null)
				cb_bundleFromDeviceMode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_BundleFromDeviceMode_Z);
			return cb_bundleFromDeviceMode_Z;
		}

		static IntPtr n_BundleFromDeviceMode_Z (IntPtr jnienv, IntPtr native__this, bool isSharedDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BundleFromDeviceMode (isSharedDevice));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='bundleFromDeviceMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("bundleFromDeviceMode", "(Z)Landroid/os/Bundle;", "GetBundleFromDeviceMode_ZHandler")]
		public virtual unsafe global::Android.OS.Bundle BundleFromDeviceMode (bool isSharedDevice)
		{
			const string __id = "bundleFromDeviceMode.(Z)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isSharedDevice);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetExtractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_extractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_ == null)
				cb_extractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExtractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_);
			return cb_extractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_ExtractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractInteractiveRequestBundleFromResultBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='extractInteractiveRequestBundleFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extractInteractiveRequestBundleFromResultBundle", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetExtractInteractiveRequestBundleFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle ExtractInteractiveRequestBundleFromResultBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "extractInteractiveRequestBundleFromResultBundle.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

		static Delegate cb_getAccountsFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAccountsFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getAccountsFromResultBundle_Landroid_os_Bundle_ == null)
				cb_getAccountsFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccountsFromResultBundle_Landroid_os_Bundle_);
			return cb_getAccountsFromResultBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetAccountsFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (__this.GetAccountsFromResultBundle (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getAccountsFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getAccountsFromResultBundle", "(Landroid/os/Bundle;)Ljava/util/List;", "GetGetAccountsFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetAccountsFromResultBundle (global::Android.OS.Bundle bundle)
		{
			const string __id = "getAccountsFromResultBundle.(Landroid/os/Bundle;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_getAcquireTokenResultFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAcquireTokenResultFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getAcquireTokenResultFromResultBundle_Landroid_os_Bundle_ == null)
				cb_getAcquireTokenResultFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAcquireTokenResultFromResultBundle_Landroid_os_Bundle_);
			return cb_getAcquireTokenResultFromResultBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetAcquireTokenResultFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAcquireTokenResultFromResultBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getAcquireTokenResultFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getAcquireTokenResultFromResultBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetGetAcquireTokenResultFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult GetAcquireTokenResultFromResultBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "getAcquireTokenResultFromResultBundle.(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBaseExceptionFromBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getBaseExceptionFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static Delegate cb_getDeviceModeFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetDeviceModeFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getDeviceModeFromResultBundle_Landroid_os_Bundle_ == null)
				cb_getDeviceModeFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_GetDeviceModeFromResultBundle_Landroid_os_Bundle_);
			return cb_getDeviceModeFromResultBundle_Landroid_os_Bundle_;
		}

		static bool n_GetDeviceModeFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetDeviceModeFromResultBundle (bundle);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getDeviceModeFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getDeviceModeFromResultBundle", "(Landroid/os/Bundle;)Z", "GetGetDeviceModeFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe bool GetDeviceModeFromResultBundle (global::Android.OS.Bundle bundle)
		{
			const string __id = "getDeviceModeFromResultBundle.(Landroid/os/Bundle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_getGenerateShrResultFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetGenerateShrResultFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getGenerateShrResultFromResultBundle_Landroid_os_Bundle_ == null)
				cb_getGenerateShrResultFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetGenerateShrResultFromResultBundle_Landroid_os_Bundle_);
			return cb_getGenerateShrResultFromResultBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetGenerateShrResultFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetGenerateShrResultFromResultBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getGenerateShrResultFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getGenerateShrResultFromResultBundle", "(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;", "GetGetGenerateShrResultFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult GetGenerateShrResultFromResultBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "getGenerateShrResultFromResultBundle.(Landroid/os/Bundle;)Lcom/microsoft/identity/common/internal/result/GenerateShrResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

		static Delegate cb_getIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_ == null)
				cb_getIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_);
			return cb_getIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIntentForInteractiveRequestFromResultBundle (resultBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='getIntentForInteractiveRequestFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getIntentForInteractiveRequestFromResultBundle", "(Landroid/os/Bundle;)Landroid/content/Intent;", "GetGetIntentForInteractiveRequestFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.Content.Intent GetIntentForInteractiveRequestFromResultBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "getIntentForInteractiveRequestFromResultBundle.(Landroid/os/Bundle;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

		static Delegate cb_verifyHelloFromResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetVerifyHelloFromResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_verifyHelloFromResultBundle_Landroid_os_Bundle_ == null)
				cb_verifyHelloFromResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_VerifyHelloFromResultBundle_Landroid_os_Bundle_);
			return cb_verifyHelloFromResultBundle_Landroid_os_Bundle_;
		}

		static IntPtr n_VerifyHelloFromResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.VerifyHelloFromResultBundle (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='verifyHelloFromResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("verifyHelloFromResultBundle", "(Landroid/os/Bundle;)Ljava/lang/String;", "GetVerifyHelloFromResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe string VerifyHelloFromResultBundle (global::Android.OS.Bundle bundle)
		{
			const string __id = "verifyHelloFromResultBundle.(Landroid/os/Bundle;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_verifyRemoveAccountResultFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetVerifyRemoveAccountResultFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_verifyRemoveAccountResultFromBundle_Landroid_os_Bundle_ == null)
				cb_verifyRemoveAccountResultFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_VerifyRemoveAccountResultFromBundle_Landroid_os_Bundle_);
			return cb_verifyRemoveAccountResultFromBundle_Landroid_os_Bundle_;
		}

		static void n_VerifyRemoveAccountResultFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.MsalBrokerResultAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.VerifyRemoveAccountResultFromBundle (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='MsalBrokerResultAdapter']/method[@name='verifyRemoveAccountResultFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("verifyRemoveAccountResultFromBundle", "(Landroid/os/Bundle;)V", "GetVerifyRemoveAccountResultFromBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe void VerifyRemoveAccountResultFromBundle (global::Android.OS.Bundle bundle)
		{
			const string __id = "verifyRemoveAccountResultFromBundle.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

	}
}
