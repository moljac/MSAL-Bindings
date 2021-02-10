using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Logging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/interface[@name='IRequestContext']"
	[Register ("com/microsoft/identity/common/internal/logging/IRequestContext", "", "Com.Microsoft.Identity.Common.Internal.Logging.IRequestContextInvoker")]
	public partial interface IRequestContext : global::Java.Util.IMap {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/interface[@name='IRequestContext']/method[@name='toJsonString' and count(parameter)=0]"
		[Register ("toJsonString", "()Ljava/lang/String;", "GetToJsonStringHandler:Com.Microsoft.Identity.Common.Internal.Logging.IRequestContextInvoker, Microsoft.Identity.Common")]
		string ToJsonString ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/logging/IRequestContext", DoNotGenerateAcw=true)]
	internal partial class IRequestContextInvoker : global::Java.Lang.Object, IRequestContext {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/logging/IRequestContext", typeof (IRequestContextInvoker));

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

		public static IRequestContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.logging.IRequestContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_toJsonString;
#pragma warning disable 0169
		static Delegate GetToJsonStringHandler ()
		{
			if (cb_toJsonString == null)
				cb_toJsonString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJsonString);
			return cb_toJsonString;
		}

		static IntPtr n_ToJsonString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJsonString ());
		}
#pragma warning restore 0169

		IntPtr id_toJsonString;
		public unsafe string ToJsonString ()
		{
			if (id_toJsonString == IntPtr.Zero)
				id_toJsonString = JNIEnv.GetMethodID (class_ref, "toJsonString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public unsafe global::System.Boolean IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_containsKey_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_Object_Handler ()
		{
			if (cb_containsKey_Ljava_lang_Object_ == null)
				cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsKey_Ljava_lang_Object_);
			return cb_containsKey_Ljava_lang_Object_;
		}

		static bool n_ContainsKey_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (key);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsKey_Ljava_lang_Object_;
		public unsafe global::System.Boolean ContainsKey (global::Java.Lang.Object key)
		{
			if (id_containsKey_Ljava_lang_Object_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsKey_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_containsValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsValue_Ljava_lang_Object_Handler ()
		{
			if (cb_containsValue_Ljava_lang_Object_ == null)
				cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsValue_Ljava_lang_Object_);
			return cb_containsValue_Ljava_lang_Object_;
		}

		static bool n_ContainsValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsValue (value);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsValue_Ljava_lang_Object_;
		public unsafe global::System.Boolean ContainsValue (global::Java.Lang.Object value)
		{
			if (id_containsValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_containsValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "containsValue", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsValue_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_entrySet;
#pragma warning disable 0169
		static Delegate GetEntrySetHandler ()
		{
			if (cb_entrySet == null)
				cb_entrySet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EntrySet);
			return cb_entrySet;
		}

		static IntPtr n_EntrySet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.EntrySet ());
		}
#pragma warning restore 0169

		IntPtr id_entrySet;
		public unsafe global::System.Collections.ICollection EntrySet ()
		{
			if (id_entrySet == IntPtr.Zero)
				id_entrySet = JNIEnv.GetMethodID (class_ref, "entrySet", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_entrySet), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (o);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object o)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Get (global::Java.Lang.Object key)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		IntPtr id_keySet;
		public unsafe global::System.Collections.ICollection KeySet ()
		{
			if (id_keySet == IntPtr.Zero)
				id_keySet = JNIEnv.GetMethodID (class_ref, "keySet", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keySet), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (key, value));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Put (global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
			__args [1] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_putAll_LSystem_Collections_IDictionary_;
#pragma warning disable 0169
		static Delegate GetPutAll_LSystem_Collections_IDictionary_Handler ()
		{
			if (cb_putAll_LSystem_Collections_IDictionary_ == null)
				cb_putAll_LSystem_Collections_IDictionary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutAll_LSystem_Collections_IDictionary_);
			return cb_putAll_LSystem_Collections_IDictionary_;
		}

		static void n_PutAll_LSystem_Collections_IDictionary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_m)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var m = global::Android.Runtime.JavaDictionary.FromJniHandle (native_m, JniHandleOwnership.DoNotTransfer);
			__this.PutAll (m);
		}
#pragma warning restore 0169

		IntPtr id_putAll_LSystem_Collections_IDictionary_;
		public unsafe void PutAll (global::System.Collections.IDictionary m)
		{
			if (id_putAll_LSystem_Collections_IDictionary_ == IntPtr.Zero)
				id_putAll_LSystem_Collections_IDictionary_ = JNIEnv.GetMethodID (class_ref, "putAll", "(LSystem/Collections/IDictionary;)V");
			IntPtr native_m = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (m);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_m);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putAll_LSystem_Collections_IDictionary_, __args);
			JNIEnv.DeleteLocalRef (native_m);
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static IntPtr n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (key));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Remove (global::Java.Lang.Object key)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public unsafe global::System.Int32 Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
		}

		static Delegate cb_values;
#pragma warning disable 0169
		static Delegate GetValuesHandler ()
		{
			if (cb_values == null)
				cb_values = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Values);
			return cb_values;
		}

		static IntPtr n_Values (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.Values ());
		}
#pragma warning restore 0169

		IntPtr id_values;
		public unsafe global::System.Collections.ICollection Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetMethodID (class_ref, "values", "()Ljava/util/Collection;");
			return global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_values), JniHandleOwnership.TransferLocalRef);
		}

	}
}
