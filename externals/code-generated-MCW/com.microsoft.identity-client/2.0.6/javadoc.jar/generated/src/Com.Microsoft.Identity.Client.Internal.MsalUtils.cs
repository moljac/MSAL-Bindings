using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/MsalUtils", DoNotGenerateAcw=true)]
	public sealed partial class MsalUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/field[@name='CHROME_PACKAGE']"
		[Register ("CHROME_PACKAGE")]
		public const string ChromePackage = (string) "com.android.chrome";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/field[@name='DEFAULT_EXPIRATION_TIME_SEC']"
		[Register ("DEFAULT_EXPIRATION_TIME_SEC")]
		public const int DefaultExpirationTimeSec = (int) 3600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/field[@name='ENCODING_UTF8']"
		[Register ("ENCODING_UTF8")]
		public const string EncodingUtf8 = (string) "UTF-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/field[@name='QUERY_STRING_DELIMITER']"
		[Register ("QUERY_STRING_DELIMITER")]
		public const string QueryStringDelimiter = (string) "&";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/field[@name='QUERY_STRING_SYMBOL']"
		[Register ("QUERY_STRING_SYMBOL")]
		public const string QueryStringSymbol = (string) "?";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/MsalUtils", typeof (MsalUtils));

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

		internal MsalUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='appendQueryParameterToUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='base64UrlEncodeToString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='calculateExpiresOn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("calculateExpiresOn", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date CalculateExpiresOn (string expiresIn)
		{
			const string __id = "calculateExpiresOn.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_expiresIn = JNIEnv.NewString (expiresIn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_expiresIn);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_expiresIn);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='convertArrayToSet' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("convertArrayToSet", "([Ljava/lang/String;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> ConvertArrayToSet (string[] values)
		{
			const string __id = "convertArrayToSet.([Ljava/lang/String;)Ljava/util/Set;";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
				global::System.GC.KeepAlive (values);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='createHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='decodeUrlToMap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decodeUrlToMap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> DecodeUrlToMap (string url, string delimiter)
		{
			const string __id = "decodeUrlToMap.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_delimiter = JNIEnv.NewString (delimiter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_delimiter);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_delimiter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='extractJsonObjectIntoMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getApplicationInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getApplicationInfo", "(Landroid/content/Context;)Landroid/content/pm/ApplicationInfo;", "")]
		public static unsafe global::Android.Content.PM.ApplicationInfo GetApplicationInfo (global::Android.Content.Context context)
		{
			const string __id = "getApplicationInfo.(Landroid/content/Context;)Landroid/content/pm/ApplicationInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getChromePackage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getChromePackage", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetChromePackage (global::Android.Content.Context context)
		{
			const string __id = "getChromePackage.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getChromePackageWithCustomTabSupport' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getChromePackageWithCustomTabSupport", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetChromePackageWithCustomTabSupport (global::Android.Content.Context context)
		{
			const string __id = "getChromePackageWithCustomTabSupport.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getExpiresOn' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getExpiresOn", "(J)J", "")]
		public static unsafe long GetExpiresOn (long expiresIn)
		{
			const string __id = "getExpiresOn.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expiresIn);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getExpiryOrDefault' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExpiryOrDefault", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetExpiryOrDefault (string expiresIn)
		{
			const string __id = "getExpiryOrDefault.(Ljava/lang/String;)I";
			IntPtr native_expiresIn = JNIEnv.NewString (expiresIn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_expiresIn);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_expiresIn);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getScopesAsSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getScopesAsSet", "(Ljava/lang/String;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> GetScopesAsSet (string scopes)
		{
			const string __id = "getScopesAsSet.(Ljava/lang/String;)Ljava/util/Set;";
			IntPtr native_scopes = JNIEnv.NewString (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_scopes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_scopes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getUniqueUserIdentifier' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getUniqueUserIdentifier", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetUniqueUserIdentifier (string uid, string utid)
		{
			const string __id = "getUniqueUserIdentifier.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_uid = JNIEnv.NewString (uid);
			IntPtr native_utid = JNIEnv.NewString (utid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uid);
				__args [1] = new JniArgumentValue (native_utid);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uid);
				JNIEnv.DeleteLocalRef (native_utid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='hasCustomTabRedirectActivity' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("hasCustomTabRedirectActivity", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool HasCustomTabRedirectActivity (global::Android.Content.Context context, string url)
		{
			const string __id = "hasCustomTabRedirectActivity.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmpty (string message)
		{
			const string __id = "isEmpty.(Ljava/lang/String;)Z";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='isScopeIntersects' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("isScopeIntersects", "(Ljava/util/Set;Ljava/util/Set;)Z", "")]
		public static unsafe bool IsScopeIntersects (global::System.Collections.Generic.ICollection<string> scopes, global::System.Collections.Generic.ICollection<string> otherScopes)
		{
			const string __id = "isScopeIntersects.(Ljava/util/Set;Ljava/util/Set;)Z";
			IntPtr native_scopes = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (scopes);
			IntPtr native_otherScopes = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (otherScopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scopes);
				__args [1] = new JniArgumentValue (native_otherScopes);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_scopes);
				JNIEnv.DeleteLocalRef (native_otherScopes);
				global::System.GC.KeepAlive (scopes);
				global::System.GC.KeepAlive (otherScopes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='throwOnMainThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("throwOnMainThread", "(Ljava/lang/String;)V", "")]
		public static unsafe void ThrowOnMainThread (string methodName)
		{
			const string __id = "throwOnMainThread.(Ljava/lang/String;)V";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_methodName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='urlFormDecode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='urlFormEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlFormEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlFormEncode (string stringToEncode)
		{
			const string __id = "urlFormEncode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_stringToEncode = JNIEnv.NewString (stringToEncode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringToEncode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringToEncode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='validateNonNullArg' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("validateNonNullArg", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public static unsafe void ValidateNonNullArg (global::Java.Lang.Object o, string argName)
		{
			const string __id = "validateNonNullArg.(Ljava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_argName = JNIEnv.NewString (argName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				__args [1] = new JniArgumentValue (native_argName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_argName);
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='MsalUtils']/method[@name='validateNonNullArgument' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("validateNonNullArgument", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public static unsafe void ValidateNonNullArgument (global::Java.Lang.Object o, string argName)
		{
			const string __id = "validateNonNullArgument.(Ljava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_argName = JNIEnv.NewString (argName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				__args [1] = new JniArgumentValue (native_argName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_argName);
				global::System.GC.KeepAlive (o);
			}
		}

	}
}
