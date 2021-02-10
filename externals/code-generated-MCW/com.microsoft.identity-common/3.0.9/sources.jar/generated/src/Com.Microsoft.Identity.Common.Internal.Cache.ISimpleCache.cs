using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISimpleCache']"
	[Register ("com/microsoft/identity/common/internal/cache/ISimpleCache", "", "Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCacheInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ISimpleCache : IJavaObject, IJavaPeerable {
		global::System.Collections.IList All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISimpleCache']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/List;", "GetGetAllHandler:Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCacheInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISimpleCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Z", "GetClearHandler:Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCacheInvoker, Microsoft.Identity.Common")]
		bool Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISimpleCache']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("insert", "(Ljava/lang/Object;)Z", "GetInsert_Ljava_lang_Object_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCacheInvoker, Microsoft.Identity.Common")]
		bool Insert (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISimpleCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("remove", "(Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCacheInvoker, Microsoft.Identity.Common")]
		bool Remove (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/ISimpleCache", DoNotGenerateAcw=true)]
	internal partial class ISimpleCacheInvoker : global::Java.Lang.Object, ISimpleCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/ISimpleCache", typeof (ISimpleCacheInvoker));

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

		public static ISimpleCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISimpleCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.ISimpleCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISimpleCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
