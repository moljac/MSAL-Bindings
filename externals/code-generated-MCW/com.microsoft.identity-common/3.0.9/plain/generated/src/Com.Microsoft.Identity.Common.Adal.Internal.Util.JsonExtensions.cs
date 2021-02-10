using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='JsonExtensions']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/util/JsonExtensions", DoNotGenerateAcw=true)]
	public sealed partial class JsonExtensions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/util/JsonExtensions", typeof (JsonExtensions));

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

		internal JsonExtensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='JsonExtensions']/method[@name='extractJsonObjectIntoMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("extractJsonObjectIntoMap", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> ExtractJsonObjectIntoMap (string jsonString)
		{
			const string __id = "extractJsonObjectIntoMap.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_jsonString = JNIEnv.NewString (jsonString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='JsonExtensions']/method[@name='getBrokerResultFromJsonString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBrokerResultFromJsonString", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult GetBrokerResultFromJsonString (string jsonString)
		{
			const string __id = "getBrokerResultFromJsonString.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/broker/BrokerResult;";
			IntPtr native_jsonString = JNIEnv.NewString (jsonString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='JsonExtensions']/method[@name='getICacheRecordListFromJsonString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getICacheRecordListFromJsonString", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> GetICacheRecordListFromJsonString (string accountJson)
		{
			const string __id = "getICacheRecordListFromJsonString.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_accountJson = JNIEnv.NewString (accountJson);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_accountJson);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountJson);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='JsonExtensions']/method[@name='getJsonStringFromICacheRecordList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.common.internal.cache.ICacheRecord&gt;']]"
		[Register ("getJsonStringFromICacheRecordList", "(Ljava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string GetJsonStringFromICacheRecordList (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> cacheRecords)
		{
			const string __id = "getJsonStringFromICacheRecordList.(Ljava/util/List;)Ljava/lang/String;";
			IntPtr native_cacheRecords = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord>.ToLocalJniHandle (cacheRecords);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cacheRecords);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheRecords);
				global::System.GC.KeepAlive (cacheRecords);
			}
		}

	}
}
