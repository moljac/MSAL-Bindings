using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationSettings", DoNotGenerateAcw=true)]
	public sealed partial class AuthenticationSettings : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings Instance {
			get {
				const string __id = "INSTANCE.Lcom/microsoft/identity/common/adal/internal/AuthenticationSettings;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationSettings", typeof (AuthenticationSettings));

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

		internal AuthenticationSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string ActivityPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getActivityPackageName' and count(parameter)=0]"
			[Register ("getActivityPackageName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getActivityPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setActivityPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setActivityPackageName", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setActivityPackageName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string BrokerPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getBrokerPackageName' and count(parameter)=0]"
			[Register ("getBrokerPackageName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBrokerPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setBrokerPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBrokerPackageName", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setBrokerPackageName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, byte[]> BrokerSecretKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getBrokerSecretKeys' and count(parameter)=0]"
			[Register ("getBrokerSecretKeys", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getBrokerSecretKeys.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setBrokerSecretKeys' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, byte[]&gt;']]"
			[Register ("setBrokerSecretKeys", "(Ljava/util/Map;)V", "")]
			set {
				const string __id = "setBrokerSecretKeys.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, byte[]>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe string BrokerSignature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getBrokerSignature' and count(parameter)=0]"
			[Register ("getBrokerSignature", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBrokerSignature.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setBrokerSignature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBrokerSignature", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setBrokerSignature.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe int ConnectTimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getConnectTimeOut' and count(parameter)=0]"
			[Register ("getConnectTimeOut", "()I", "")]
			get {
				const string __id = "getConnectTimeOut.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setConnectTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectTimeOut", "(I)V", "")]
			set {
				const string __id = "setConnectTimeOut.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Class DeviceCertificateProxy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getDeviceCertificateProxy' and count(parameter)=0]"
			[Register ("getDeviceCertificateProxy", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getDeviceCertificateProxy.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool DisableWebViewHardwareAcceleration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getDisableWebViewHardwareAcceleration' and count(parameter)=0]"
			[Register ("getDisableWebViewHardwareAcceleration", "()Z", "")]
			get {
				const string __id = "getDisableWebViewHardwareAcceleration.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setDisableWebViewHardwareAcceleration' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDisableWebViewHardwareAcceleration", "(Z)V", "")]
			set {
				const string __id = "setDisableWebViewHardwareAcceleration.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int ExpirationBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getExpirationBuffer' and count(parameter)=0]"
			[Register ("getExpirationBuffer", "()I", "")]
			get {
				const string __id = "getExpirationBuffer.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setExpirationBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpirationBuffer", "(I)V", "")]
			set {
				const string __id = "setExpirationBuffer.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int ReadTimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getReadTimeOut' and count(parameter)=0]"
			[Register ("getReadTimeOut", "()I", "")]
			get {
				const string __id = "getReadTimeOut.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setReadTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeOut", "(I)V", "")]
			set {
				const string __id = "setReadTimeOut.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string SharedPrefPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getSharedPrefPackageName' and count(parameter)=0]"
			[Register ("getSharedPrefPackageName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSharedPrefPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setSharedPrefPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSharedPrefPackageName", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setSharedPrefPackageName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe bool SkipBroker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getSkipBroker' and count(parameter)=0]"
			[Register ("getSkipBroker", "()Z", "")]
			get {
				const string __id = "getSkipBroker.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setSkipBroker' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSkipBroker", "(Z)V", "")]
			set {
				const string __id = "setSkipBroker.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool UseBroker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getUseBroker' and count(parameter)=0]"
			[Register ("getUseBroker", "()Z", "")]
			get {
				const string __id = "getUseBroker.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setUseBroker' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseBroker", "(Z)V", "")]
			set {
				const string __id = "setUseBroker.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='clearBrokerSecretKeys' and count(parameter)=0]"
		[Register ("clearBrokerSecretKeys", "()V", "")]
		public unsafe void ClearBrokerSecretKeys ()
		{
			const string __id = "clearBrokerSecretKeys.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='clearSecretKeysForTestCases' and count(parameter)=0]"
		[Register ("clearSecretKeysForTestCases", "()V", "")]
		public unsafe void ClearSecretKeysForTestCases ()
		{
			const string __id = "clearSecretKeysForTestCases.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='getSecretKeyData' and count(parameter)=0]"
		[Register ("getSecretKeyData", "()[B", "")]
		public unsafe byte[] GetSecretKeyData ()
		{
			const string __id = "getSecretKeyData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setDeviceCertificateProxyClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("setDeviceCertificateProxyClass", "(Ljava/lang/Class;)V", "")]
		public unsafe void SetDeviceCertificateProxyClass (global::Java.Lang.Class clazz)
		{
			const string __id = "setDeviceCertificateProxyClass.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='setSecretKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setSecretKey", "([B)V", "")]
		public unsafe void SetSecretKey (byte[] rawKey)
		{
			const string __id = "setSecretKey.([B)V";
			IntPtr native_rawKey = JNIEnv.NewArray (rawKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawKey);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (rawKey != null) {
					JNIEnv.CopyArray (native_rawKey, rawKey);
					JNIEnv.DeleteLocalRef (native_rawKey);
				}
				global::System.GC.KeepAlive (rawKey);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/AuthenticationSettings;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/adal/internal/AuthenticationSettings;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationSettings']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/adal/internal/AuthenticationSettings;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/adal/internal/AuthenticationSettings;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Adal.Internal.AuthenticationSettings));
			} finally {
			}
		}

	}
}
