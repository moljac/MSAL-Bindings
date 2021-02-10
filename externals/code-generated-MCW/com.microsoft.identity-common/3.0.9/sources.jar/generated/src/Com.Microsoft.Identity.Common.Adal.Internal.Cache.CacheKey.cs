using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/cache/CacheKey", DoNotGenerateAcw=true)]
	public partial class CacheKey : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/cache/CacheKey", typeof (CacheKey));

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

		protected CacheKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/constructor[@name='CacheKey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CacheKey () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAuthority;
#pragma warning disable 0169
		static Delegate GetGetAuthorityHandler ()
		{
			if (cb_getAuthority == null)
				cb_getAuthority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthority);
			return cb_getAuthority;
		}

		static IntPtr n_GetAuthority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.CacheKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Authority);
		}
#pragma warning restore 0169

		public virtual unsafe string Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='getAuthority' and count(parameter)=0]"
			[Register ("getAuthority", "()Ljava/lang/String;", "GetGetAuthorityHandler")]
			get {
				const string __id = "getAuthority.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.CacheKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIsMultipleResourceRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetIsMultipleResourceRefreshTokenHandler ()
		{
			if (cb_getIsMultipleResourceRefreshToken == null)
				cb_getIsMultipleResourceRefreshToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetIsMultipleResourceRefreshToken);
			return cb_getIsMultipleResourceRefreshToken;
		}

		static bool n_GetIsMultipleResourceRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.CacheKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMultipleResourceRefreshToken;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMultipleResourceRefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='getIsMultipleResourceRefreshToken' and count(parameter)=0]"
			[Register ("getIsMultipleResourceRefreshToken", "()Z", "GetGetIsMultipleResourceRefreshTokenHandler")]
			get {
				const string __id = "getIsMultipleResourceRefreshToken.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getResource;
#pragma warning disable 0169
		static Delegate GetGetResourceHandler ()
		{
			if (cb_getResource == null)
				cb_getResource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResource);
			return cb_getResource;
		}

		static IntPtr n_GetResource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.CacheKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Resource);
		}
#pragma warning restore 0169

		public virtual unsafe string Resource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='getResource' and count(parameter)=0]"
			[Register ("getResource", "()Ljava/lang/String;", "GetGetResourceHandler")]
			get {
				const string __id = "getResource.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Cache.CacheKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				const string __id = "getUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='createCacheKey' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("createCacheKey", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateCacheKey (string authority, string resource, string clientId, bool isMultiResourceRefreshToken, string userId, string familyClientId)
		{
			const string __id = "createCacheKey.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_resource = JNIEnv.NewString (resource);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_userId = JNIEnv.NewString (userId);
			IntPtr native_familyClientId = JNIEnv.NewString (familyClientId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_resource);
				__args [2] = new JniArgumentValue (native_clientId);
				__args [3] = new JniArgumentValue (isMultiResourceRefreshToken);
				__args [4] = new JniArgumentValue (native_userId);
				__args [5] = new JniArgumentValue (native_familyClientId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_resource);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_userId);
				JNIEnv.DeleteLocalRef (native_familyClientId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='createCacheKeyForFRT' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createCacheKeyForFRT", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateCacheKeyForFRT (string authority, string familyClientId, string userId)
		{
			const string __id = "createCacheKeyForFRT.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_familyClientId = JNIEnv.NewString (familyClientId);
			IntPtr native_userId = JNIEnv.NewString (userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_familyClientId);
				__args [2] = new JniArgumentValue (native_userId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_familyClientId);
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='createCacheKeyForMRRT' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createCacheKeyForMRRT", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateCacheKeyForMRRT (string authority, string clientId, string userId)
		{
			const string __id = "createCacheKeyForMRRT.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_userId = JNIEnv.NewString (userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_clientId);
				__args [2] = new JniArgumentValue (native_userId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.cache']/class[@name='CacheKey']/method[@name='createCacheKeyForRTEntry' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createCacheKeyForRTEntry", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateCacheKeyForRTEntry (string authority, string resource, string clientId, string userId)
		{
			const string __id = "createCacheKeyForRTEntry.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			IntPtr native_resource = JNIEnv.NewString (resource);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_userId = JNIEnv.NewString (userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_authority);
				__args [1] = new JniArgumentValue (native_resource);
				__args [2] = new JniArgumentValue (native_clientId);
				__args [3] = new JniArgumentValue (native_userId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
				JNIEnv.DeleteLocalRef (native_resource);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

	}
}
