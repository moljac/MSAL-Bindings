using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']"
	[Register ("com/microsoft/identity/common/internal/cache/ISharedPreferencesFileManager", "", "Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker")]
	public partial interface ISharedPreferencesFileManager : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IDictionary<string, string> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string SharedPreferencesFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='getSharedPreferencesFileName' and count(parameter)=0]"
			[Register ("getSharedPreferencesFileName", "()Ljava/lang/String;", "GetGetSharedPreferencesFileNameHandler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		bool Contains (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		long GetLong (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		string GetString (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putLong", "(Ljava/lang/String;J)V", "GetPutLong_Ljava_lang_String_JHandler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		void PutLong (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		void PutString (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='ISharedPreferencesFileManager']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManagerInvoker, Microsoft.Identity.Common")]
		void Remove (string p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/ISharedPreferencesFileManager", DoNotGenerateAcw=true)]
	internal partial class ISharedPreferencesFileManagerInvoker : global::Java.Lang.Object, ISharedPreferencesFileManager {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/ISharedPreferencesFileManager", typeof (ISharedPreferencesFileManagerInvoker));

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

		public static ISharedPreferencesFileManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISharedPreferencesFileManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.ISharedPreferencesFileManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISharedPreferencesFileManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		IntPtr id_getAll;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> All {
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSharedPreferencesFileName;
#pragma warning disable 0169
		static Delegate GetGetSharedPreferencesFileNameHandler ()
		{
			if (cb_getSharedPreferencesFileName == null)
				cb_getSharedPreferencesFileName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSharedPreferencesFileName);
			return cb_getSharedPreferencesFileName;
		}

		static IntPtr n_GetSharedPreferencesFileName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SharedPreferencesFileName);
		}
#pragma warning restore 0169

		IntPtr id_getSharedPreferencesFileName;
		public unsafe string SharedPreferencesFileName {
			get {
				if (id_getSharedPreferencesFileName == IntPtr.Zero)
					id_getSharedPreferencesFileName = JNIEnv.GetMethodID (class_ref, "getSharedPreferencesFileName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSharedPreferencesFileName), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_String_;
		public unsafe bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLong_Ljava_lang_String_;
		public unsafe long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_;
		public unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_putLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_JHandler ()
		{
			if (cb_putLong_Ljava_lang_String_J == null)
				cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_PutLong_Ljava_lang_String_J);
			return cb_putLong_Ljava_lang_String_J;
		}

		static void n_PutLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putLong_Ljava_lang_String_J;
		public unsafe void PutLong (string p0, long p1)
		{
			if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
				id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putLong_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void PutString (string p0, string p1)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ISharedPreferencesFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
