using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/SharedPreferencesSimpleCacheImpl", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class SharedPreferencesSimpleCacheImpl : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/SharedPreferencesSimpleCacheImpl", typeof (SharedPreferencesSimpleCacheImpl));

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

		protected SharedPreferencesSimpleCacheImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/constructor[@name='SharedPreferencesSimpleCacheImpl' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SharedPreferencesSimpleCacheImpl (global::Android.Content.Context context, string prefsName, string singleKey) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefsName = JNIEnv.NewString (prefsName);
			IntPtr native_singleKey = JNIEnv.NewString (singleKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_prefsName);
				__args [2] = new JniArgumentValue (native_singleKey);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefsName);
				JNIEnv.DeleteLocalRef (native_singleKey);
				global::System.GC.KeepAlive (context);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesSimpleCacheImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IList All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/List;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesSimpleCacheImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListTypeToken);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Reflect.IType ListTypeToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/method[@name='getListTypeToken' and count(parameter)=0]"
			[Register ("getListTypeToken", "()Ljava/lang/reflect/Type;", "GetGetListTypeTokenHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesSimpleCacheImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Z", "GetClearHandler")]
		public virtual unsafe bool Clear ()
		{
			const string __id = "clear.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_insert_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_Object_Handler ()
		{
			if (cb_insert_Ljava_lang_Object_ == null)
				cb_insert_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Insert_Ljava_lang_Object_);
			return cb_insert_Ljava_lang_Object_;
		}

		static bool n_Insert_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesSimpleCacheImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_t, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Insert (t);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("insert", "(Ljava/lang/Object;)Z", "GetInsert_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Insert (global::Java.Lang.Object t)
		{
			const string __id = "insert.(Ljava/lang/Object;)Z";
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_t);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.SharedPreferencesSimpleCacheImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_t, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (t);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("remove", "(Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Remove (global::Java.Lang.Object t)
		{
			const string __id = "remove.(Ljava/lang/Object;)Z";
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_t);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
				global::System.GC.KeepAlive (t);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/SharedPreferencesSimpleCacheImpl", DoNotGenerateAcw=true)]
	internal partial class SharedPreferencesSimpleCacheImplInvoker : SharedPreferencesSimpleCacheImpl, global::Com.Microsoft.Identity.Common.Internal.Cache.ISimpleCache {
		public SharedPreferencesSimpleCacheImplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/SharedPreferencesSimpleCacheImpl", typeof (SharedPreferencesSimpleCacheImplInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::Java.Lang.Reflect.IType ListTypeToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='SharedPreferencesSimpleCacheImpl']/method[@name='getListTypeToken' and count(parameter)=0]"
			[Register ("getListTypeToken", "()Ljava/lang/reflect/Type;", "GetGetListTypeTokenHandler")]
			get {
				const string __id = "getListTypeToken.()Ljava/lang/reflect/Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
