using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IBrokerApplicationMetadataCache']"
	[Register ("com/microsoft/identity/common/internal/cache/IBrokerApplicationMetadataCache", "", "Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCacheInvoker")]
	public partial interface IBrokerApplicationMetadataCache : global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache {
		global::System.Collections.Generic.ICollection<string> AllClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IBrokerApplicationMetadataCache']/method[@name='getAllClientIds' and count(parameter)=0]"
			[Register ("getAllClientIds", "()Ljava/util/Set;", "GetGetAllClientIdsHandler:Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> AllFociApplicationMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IBrokerApplicationMetadataCache']/method[@name='getAllFociApplicationMetadata' and count(parameter)=0]"
			[Register ("getAllFociApplicationMetadata", "()Ljava/util/List;", "GetGetAllFociApplicationMetadataHandler:Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::System.Collections.Generic.ICollection<string> AllFociClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IBrokerApplicationMetadataCache']/method[@name='getAllFociClientIds' and count(parameter)=0]"
			[Register ("getAllFociClientIds", "()Ljava/util/Set;", "GetGetAllFociClientIdsHandler:Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::System.Collections.Generic.ICollection<string> AllNonFociClientIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IBrokerApplicationMetadataCache']/method[@name='getAllNonFociClientIds' and count(parameter)=0]"
			[Register ("getAllNonFociClientIds", "()Ljava/util/Set;", "GetGetAllNonFociClientIdsHandler:Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IBrokerApplicationMetadataCache']/method[@name='getMetadata' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getMetadata", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/microsoft/identity/common/internal/cache/BrokerApplicationMetadata;", "GetGetMetadata_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCacheInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata GetMetadata (string p0, string p1, int p2);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/IBrokerApplicationMetadataCache", DoNotGenerateAcw=true)]
	internal partial class IBrokerApplicationMetadataCacheInvoker : global::Java.Lang.Object, IBrokerApplicationMetadataCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/IBrokerApplicationMetadataCache", typeof (IBrokerApplicationMetadataCacheInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBrokerApplicationMetadataCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBrokerApplicationMetadataCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.IBrokerApplicationMetadataCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBrokerApplicationMetadataCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllClientIds);
		}
#pragma warning restore 0169

		IntPtr id_getAllClientIds;
		public unsafe global::System.Collections.Generic.ICollection<string> AllClientIds {
			get {
				if (id_getAllClientIds == IntPtr.Zero)
					id_getAllClientIds = JNIEnv.GetMethodID (class_ref, "getAllClientIds", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllClientIds), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata>.ToLocalJniHandle (__this.AllFociApplicationMetadata);
		}
#pragma warning restore 0169

		IntPtr id_getAllFociApplicationMetadata;
		public unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> AllFociApplicationMetadata {
			get {
				if (id_getAllFociApplicationMetadata == IntPtr.Zero)
					id_getAllFociApplicationMetadata = JNIEnv.GetMethodID (class_ref, "getAllFociApplicationMetadata", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllFociApplicationMetadata), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllFociClientIds);
		}
#pragma warning restore 0169

		IntPtr id_getAllFociClientIds;
		public unsafe global::System.Collections.Generic.ICollection<string> AllFociClientIds {
			get {
				if (id_getAllFociClientIds == IntPtr.Zero)
					id_getAllFociClientIds = JNIEnv.GetMethodID (class_ref, "getAllFociClientIds", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllFociClientIds), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AllNonFociClientIds);
		}
#pragma warning restore 0169

		IntPtr id_getAllNonFociClientIds;
		public unsafe global::System.Collections.Generic.ICollection<string> AllNonFociClientIds {
			get {
				if (id_getAllNonFociClientIds == IntPtr.Zero)
					id_getAllNonFociClientIds = JNIEnv.GetMethodID (class_ref, "getAllNonFociClientIds", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllNonFociClientIds), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_GetMetadata_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMetadata (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMetadata_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata GetMetadata (string p0, string p1, int p2)
		{
			if (id_getMetadata_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_getMetadata_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getMetadata", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/microsoft/identity/common/internal/cache/BrokerApplicationMetadata;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		IntPtr id_getAll;
		public unsafe global::System.Collections.IList All {
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Clear);
			return cb_clear;
		}

		static bool n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe bool Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_insert_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_Object_Handler ()
		{
			if (cb_insert_Ljava_lang_Object_ == null)
				cb_insert_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Insert_Ljava_lang_Object_);
			return cb_insert_Ljava_lang_Object_;
		}

		static bool n_Insert_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Insert (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_insert_Ljava_lang_Object_;
		public unsafe bool Insert (global::Java.Lang.Object p0)
		{
			if (id_insert_Ljava_lang_Object_ == IntPtr.Zero)
				id_insert_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_insert_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IBrokerApplicationMetadataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_Object_;
		public unsafe bool Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
