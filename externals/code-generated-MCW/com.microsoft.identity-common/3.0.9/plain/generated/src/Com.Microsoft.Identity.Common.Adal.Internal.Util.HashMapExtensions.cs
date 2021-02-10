using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='HashMapExtensions']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/util/HashMapExtensions", DoNotGenerateAcw=true)]
	public sealed partial class HashMapExtensions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/util/HashMapExtensions", typeof (HashMapExtensions));

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

		internal HashMapExtensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='HashMapExtensions']/method[@name='getJsonResponse' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.adal.internal.net.HttpWebResponse']]"
		[Register ("getJsonResponse", "(Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetJsonResponse (global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse webResponse)
		{
			const string __id = "getJsonResponse.(Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;)Ljava/util/HashMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webResponse).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (webResponse);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='HashMapExtensions']/method[@name='jsonStringAsMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonStringAsMap", "(Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> JsonStringAsMap (string jsonString)
		{
			const string __id = "jsonStringAsMap.(Ljava/lang/String;)Ljava/util/HashMap;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='HashMapExtensions']/method[@name='jsonStringAsMapList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonStringAsMapList", "(Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> JsonStringAsMapList (string jsonString)
		{
			const string __id = "jsonStringAsMapList.(Ljava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_jsonString = JNIEnv.NewString (jsonString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='HashMapExtensions']/method[@name='urlFormDecode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlFormDecode", "(Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> UrlFormDecode (string parameters)
		{
			const string __id = "urlFormDecode.(Ljava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_parameters = JNIEnv.NewString (parameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_parameters);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_parameters);
			}
		}

	}
}
