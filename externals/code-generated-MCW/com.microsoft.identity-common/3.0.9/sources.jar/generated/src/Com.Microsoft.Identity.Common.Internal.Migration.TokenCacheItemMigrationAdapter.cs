using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/migration/TokenCacheItemMigrationAdapter", DoNotGenerateAcw=true)]
	public partial class TokenCacheItemMigrationAdapter : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/field[@name='sBackgroundExecutor']"
		[Register ("sBackgroundExecutor")]
		public static global::Java.Util.Concurrent.IExecutorService SBackgroundExecutor {
			get {
				const string __id = "sBackgroundExecutor.Ljava/util/concurrent/ExecutorService;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/migration/TokenCacheItemMigrationAdapter", typeof (TokenCacheItemMigrationAdapter));

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

		protected TokenCacheItemMigrationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/constructor[@name='TokenCacheItemMigrationAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenCacheItemMigrationAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/method[@name='getScopeFromResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getScopeFromResource", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetScopeFromResource (string resource)
		{
			const string __id = "getScopeFromResource.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_resource = JNIEnv.NewString (resource);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_resource);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_resource);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/method[@name='getScopesForTokenRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getScopesForTokenRequest", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetScopesForTokenRequest (string v1Resource)
		{
			const string __id = "getScopesForTokenRequest.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_v1Resource = JNIEnv.NewString (v1Resource);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_v1Resource);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_v1Resource);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/method[@name='logTokenResultError' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResult']]"
		[Register ("logTokenResultError", "(Ljava/util/UUID;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;)V", "")]
		public static unsafe void LogTokenResultError (global::Java.Util.UUID correlationId, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult tokenResult)
		{
			const string __id = "logTokenResultError.(Ljava/util/UUID;Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((correlationId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) correlationId).Handle);
				__args [1] = new JniArgumentValue ((tokenResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenResult).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (correlationId);
				global::System.GC.KeepAlive (tokenResult);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/method[@name='renewToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.common.internal.cache.ITokenCacheItem']]"
		[Register ("renewToken", "(Ljava/lang/String;Lcom/microsoft/identity/common/internal/cache/ITokenCacheItem;)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair RenewToken (string redirectUri, global::Com.Microsoft.Identity.Common.Internal.Cache.ITokenCacheItem targetCacheItemToRenew)
		{
			const string __id = "renewToken.(Ljava/lang/String;Lcom/microsoft/identity/common/internal/cache/ITokenCacheItem;)Landroid/util/Pair;";
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_redirectUri);
				__args [1] = new JniArgumentValue ((targetCacheItemToRenew == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetCacheItemToRenew).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_redirectUri);
				global::System.GC.KeepAlive (targetCacheItemToRenew);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenCacheItemMigrationAdapter']/method[@name='tryFociTokenWithGivenClientId' and count(parameter)=5 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microsoft.identity.common.internal.dto.RefreshTokenRecord'] and parameter[5][@type='com.microsoft.identity.common.internal.dto.IAccountRecord']]"
		[Register ("tryFociTokenWithGivenClientId", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)Z", "")]
		public static unsafe bool TryFociTokenWithGivenClientId (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache brokerOAuth2TokenCache, string clientId, string redirectUri, global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord refreshTokenRecord, global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord accountRecord)
		{
			const string __id = "tryFociTokenWithGivenClientId.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Ljava/lang/String;Ljava/lang/String;Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;Lcom/microsoft/identity/common/internal/dto/IAccountRecord;)Z";
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((brokerOAuth2TokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) brokerOAuth2TokenCache).Handle);
				__args [1] = new JniArgumentValue (native_clientId);
				__args [2] = new JniArgumentValue (native_redirectUri);
				__args [3] = new JniArgumentValue ((refreshTokenRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshTokenRecord).Handle);
				__args [4] = new JniArgumentValue ((accountRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accountRecord).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_redirectUri);
				global::System.GC.KeepAlive (brokerOAuth2TokenCache);
				global::System.GC.KeepAlive (refreshTokenRecord);
				global::System.GC.KeepAlive (accountRecord);
			}
		}

	}
}
