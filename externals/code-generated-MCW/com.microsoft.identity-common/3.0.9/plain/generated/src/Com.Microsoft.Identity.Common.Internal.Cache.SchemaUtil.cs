using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/SchemaUtil", DoNotGenerateAcw=true)]
	public sealed partial class SchemaUtil : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/field[@name='MISSING_FROM_THE_TOKEN_RESPONSE']"
		[Register ("MISSING_FROM_THE_TOKEN_RESPONSE")]
		public const string MissingFromTheTokenResponse = (string) "Missing from the token response";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/SchemaUtil", typeof (SchemaUtil));

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

		internal SchemaUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getAlternativeAccountId' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.IDToken']]"
		[Register ("getAlternativeAccountId", "(Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)Ljava/lang/String;", "")]
		public static unsafe string GetAlternativeAccountId (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken idToken)
		{
			const string __id = "getAlternativeAccountId.(Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((idToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idToken).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (idToken);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getAuthority' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.IDToken']]"
		[Register ("getAuthority", "(Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)Ljava/lang/String;", "")]
		public static unsafe string GetAuthority (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken idToken)
		{
			const string __id = "getAuthority.(Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((idToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idToken).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (idToken);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getAvatarUrl' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.IDToken']]"
		[Register ("getAvatarUrl", "(Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)Ljava/lang/String;", "")]
		public static unsafe string GetAvatarUrl (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken idToken)
		{
			const string __id = "getAvatarUrl.(Lcom/microsoft/identity/common/internal/providers/oauth2/IDToken;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((idToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idToken).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (idToken);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getCredentialTypeFromVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCredentialTypeFromVersion", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCredentialTypeFromVersion (string idTokenString)
		{
			const string __id = "getCredentialTypeFromVersion.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_idTokenString = JNIEnv.NewString (idTokenString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_idTokenString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_idTokenString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getDisplayableId' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ?&gt;']]"
		[Register ("getDisplayableId", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetDisplayableId (global::System.Collections.Generic.IDictionary<string, object> claims)
		{
			const string __id = "getDisplayableId.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_claims = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (claims);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_claims);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_claims);
				global::System.GC.KeepAlive (claims);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getIdentityProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIdentityProvider", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetIdentityProvider (string idTokenString)
		{
			const string __id = "getIdentityProvider.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_idTokenString = JNIEnv.NewString (idTokenString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_idTokenString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_idTokenString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SchemaUtil']/method[@name='getTenantId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getTenantId", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetTenantId (string clientInfoString, string idTokenString)
		{
			const string __id = "getTenantId.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_clientInfoString = JNIEnv.NewString (clientInfoString);
			IntPtr native_idTokenString = JNIEnv.NewString (idTokenString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientInfoString);
				__args [1] = new JniArgumentValue (native_idTokenString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientInfoString);
				JNIEnv.DeleteLocalRef (native_idTokenString);
			}
		}

	}
}
