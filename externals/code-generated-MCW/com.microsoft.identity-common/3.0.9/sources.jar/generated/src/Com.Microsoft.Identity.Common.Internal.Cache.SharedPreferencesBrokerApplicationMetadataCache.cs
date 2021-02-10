using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/SharedPreferencesBrokerApplicationMetadataCache", DoNotGenerateAcw=true)]
	public partial class SharedPreferencesBrokerApplicationMetadataCache : global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesSimpleCacheImpl, global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/SharedPreferencesBrokerApplicationMetadataCache", typeof (SharedPreferencesBrokerApplicationMetadataCache));

		internal static new IntPtr class_ref {
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

		protected SharedPreferencesBrokerApplicationMetadataCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/constructor[@name='SharedPreferencesBrokerApplicationMetadataCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SharedPreferencesBrokerApplicationMetadataCache (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getAllClientIds;
#pragma warning disable 0169
		static Delegate GetGetAllClientIdsHandler ()
		{
			if (cb_getAllClientIds == null)
				cb_getAllClientIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllClientIds);
			return cb_getAllClientIds;
		}

		static IntPtr n_GetAllClientIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllClientIds);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> AllClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/method[@name='getAllClientIds' and count(parameter)=0]"
			[Register ("getAllClientIds", "()Ljava/util/Set;", "GetGetAllClientIdsHandler")]
			get {
				const string __id = "getAllClientIds.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllFociApplicationMetadata;
#pragma warning disable 0169
		static Delegate GetGetAllFociApplicationMetadataHandler ()
		{
			if (cb_getAllFociApplicationMetadata == null)
				cb_getAllFociApplicationMetadata = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllFociApplicationMetadata);
			return cb_getAllFociApplicationMetadata;
		}

		static IntPtr n_GetAllFociApplicationMetadata (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata>.ToLocalJniHandle (__this.AllFociApplicationMetadata);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> AllFociApplicationMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/method[@name='getAllFociApplicationMetadata' and count(parameter)=0]"
			[Register ("getAllFociApplicationMetadata", "()Ljava/util/List;", "GetGetAllFociApplicationMetadataHandler")]
			get {
				const string __id = "getAllFociApplicationMetadata.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllFociClientIds;
#pragma warning disable 0169
		static Delegate GetGetAllFociClientIdsHandler ()
		{
			if (cb_getAllFociClientIds == null)
				cb_getAllFociClientIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllFociClientIds);
			return cb_getAllFociClientIds;
		}

		static IntPtr n_GetAllFociClientIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllFociClientIds);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> AllFociClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/method[@name='getAllFociClientIds' and count(parameter)=0]"
			[Register ("getAllFociClientIds", "()Ljava/util/Set;", "GetGetAllFociClientIdsHandler")]
			get {
				const string __id = "getAllFociClientIds.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllNonFociClientIds;
#pragma warning disable 0169
		static Delegate GetGetAllNonFociClientIdsHandler ()
		{
			if (cb_getAllNonFociClientIds == null)
				cb_getAllNonFociClientIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllNonFociClientIds);
			return cb_getAllNonFociClientIds;
		}

		static IntPtr n_GetAllNonFociClientIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllNonFociClientIds);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> AllNonFociClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/method[@name='getAllNonFociClientIds' and count(parameter)=0]"
			[Register ("getAllNonFociClientIds", "()Ljava/util/Set;", "GetGetAllNonFociClientIdsHandler")]
			get {
				const string __id = "getAllNonFociClientIds.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListTypeToken;
#pragma warning disable 0169
		static Delegate GetGetListTypeTokenHandler ()
		{
			if (cb_getListTypeToken == null)
				cb_getListTypeToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListTypeToken);
			return cb_getListTypeToken;
		}

		static IntPtr n_GetListTypeToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListTypeToken);
		}
#pragma warning restore 0169

		protected override unsafe global::Java.Lang.Reflect.IType ListTypeToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/method[@name='getListTypeToken' and count(parameter)=0]"
			[Register ("getListTypeToken", "()Ljava/lang/reflect/Type;", "GetGetListTypeTokenHandler")]
			get {
				const string __id = "getListTypeToken.()Ljava/lang/reflect/Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMetadata_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetMetadata_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_getMetadata_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_getMetadata_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_GetMetadata_Ljava_lang_String_Ljava_lang_String_I);
			return cb_getMetadata_Ljava_lang_String_Ljava_lang_String_I;
		}

		static IntPtr n_GetMetadata_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId, IntPtr native_environment, int processUid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			var environment = JNIEnv.GetString (native_environment, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMetadata (clientId, environment, processUid));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesBrokerApplicationMetadataCache']/method[@name='getMetadata' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getMetadata", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/microsoft/identity/common/internal/cache/BrokerApplicationMetadata;", "GetGetMetadata_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata GetMetadata (string clientId, string environment, int processUid)
		{
			const string __id = "getMetadata.(Ljava/lang/String;Ljava/lang/String;I)Lcom/microsoft/identity/common/internal/cache/BrokerApplicationMetadata;";
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_environment = JNIEnv.NewString (environment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_environment);
				__args [2] = new JniArgumentValue (processUid);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_environment);
			}
		}

	}
}
