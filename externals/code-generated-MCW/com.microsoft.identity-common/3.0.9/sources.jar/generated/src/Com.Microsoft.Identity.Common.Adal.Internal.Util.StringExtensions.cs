using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/util/StringExtensions", DoNotGenerateAcw=true)]
	public sealed partial class StringExtensions : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/field[@name='ENCODING_UTF8']"
		[Register ("ENCODING_UTF8")]
		public const string EncodingUtf8 = (string) "UTF-8";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/util/StringExtensions", typeof (StringExtensions));

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

		internal StringExtensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='appendQueryParameterToUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("appendQueryParameterToUrl", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string AppendQueryParameterToUrl (string url, global::System.Collections.Generic.IDictionary<string, string> requestParams)
		{
			const string __id = "appendQueryParameterToUrl.(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_requestParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (requestParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_requestParams);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_requestParams);
				global::System.GC.KeepAlive (requestParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='base64UrlEncodeToString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("base64UrlEncodeToString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Base64UrlEncodeToString (string message)
		{
			const string __id = "base64UrlEncodeToString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='createHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createHash", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateHash (string msg)
		{
			const string __id = "createHash.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='encodeBase64URLSafeString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64URLSafeString", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBase64URLSafeString (byte[] bytes)
		{
			const string __id = "encodeBase64URLSafeString.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='getStringTokens' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringTokens", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetStringTokens (string items, string delimiter)
		{
			const string __id = "getStringTokens.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_items = JNIEnv.NewString (items);
			IntPtr native_delimiter = JNIEnv.NewString (delimiter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_items);
				__args [1] = new JniArgumentValue (native_delimiter);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_items);
				JNIEnv.DeleteLocalRef (native_delimiter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUrl", "(Ljava/lang/String;)Ljava/net/URL;", "")]
		public static unsafe global::Java.Net.URL GetUrl (string endpoint)
		{
			const string __id = "getUrl.(Ljava/lang/String;)Ljava/net/URL;";
			IntPtr native_endpoint = JNIEnv.NewString (endpoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_endpoint);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_endpoint);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='getUrlParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUrlParameters", "(Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetUrlParameters (string finalUrl)
		{
			const string __id = "getUrlParameters.(Ljava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_finalUrl = JNIEnv.NewString (finalUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_finalUrl);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_finalUrl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='hasPrefixInHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hasPrefixInHeader", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool HasPrefixInHeader (string value, string prefix)
		{
			const string __id = "hasPrefixInHeader.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_value = JNIEnv.NewString (value);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (native_prefix);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='isNullOrBlank' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNullOrBlank", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNullOrBlank (string param)
		{
			const string __id = "isNullOrBlank.(Ljava/lang/String;)Z";
			IntPtr native_param = JNIEnv.NewString (param);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_param);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_param);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='removeQueryParameterFromUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeQueryParameterFromUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveQueryParameterFromUrl (string url)
		{
			const string __id = "removeQueryParameterFromUrl.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='removeQuoteInHeaderValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeQuoteInHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveQuoteInHeaderValue (string value)
		{
			const string __id = "removeQuoteInHeaderValue.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='splitWithQuotes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("splitWithQuotes", "(Ljava/lang/String;C)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> SplitWithQuotes (string input, char delimiter)
		{
			const string __id = "splitWithQuotes.(Ljava/lang/String;C)Ljava/util/ArrayList;";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (delimiter);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='urlFormDecode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlFormDecode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlFormDecode (string source)
		{
			const string __id = "urlFormDecode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_source);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.util']/class[@name='StringExtensions']/method[@name='urlFormEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlFormEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlFormEncode (string source)
		{
			const string __id = "urlFormEncode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_source);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

	}
}
