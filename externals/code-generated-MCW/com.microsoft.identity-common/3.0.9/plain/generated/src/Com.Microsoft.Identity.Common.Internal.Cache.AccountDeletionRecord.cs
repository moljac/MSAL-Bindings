using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/AccountDeletionRecord", DoNotGenerateAcw=true)]
	public partial class AccountDeletionRecord : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/AccountDeletionRecord", typeof (AccountDeletionRecord));

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

		protected AccountDeletionRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_add_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_add_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Add_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_add_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static bool n_Add_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accountRecord = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_accountRecord, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (accountRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("add", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z", "GetAdd_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public virtual unsafe bool Add (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord accountRecord)
		{
			const string __id = "add.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accountRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accountRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (accountRecord);
			}
		}

		static Delegate cb_add_ILcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetAdd_ILcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_add_ILcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_add_ILcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Add_ILcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_add_ILcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static void n_Add_ILcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_element, JniHandleOwnership.DoNotTransfer);
			__this.Add (index, element);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("add", "(ILcom/microsoft/identity/common/internal/dto/AccountRecord;)V", "GetAdd_ILcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public virtual unsafe void Add (int index, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord element)
		{
			const string __id = "add.(ILcom/microsoft/identity/common/internal/dto/AccountRecord;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (element);
			}
		}

		static Delegate cb_addAll_ILjava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_ILjava_util_Collection_Handler ()
		{
			if (cb_addAll_ILjava_util_Collection_ == null)
				cb_addAll_ILjava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_AddAll_ILjava_util_Collection_);
			return cb_addAll_ILjava_util_Collection_;
		}

		static bool n_AddAll_ILjava_util_Collection_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (index, c);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Collection&lt;? extends com.microsoft.identity.common.internal.dto.AccountRecord&gt;']]"
		[Register ("addAll", "(ILjava/util/Collection;)Z", "GetAddAll_ILjava_util_Collection_Handler")]
		public virtual unsafe bool AddAll (int index, global::System.Collections.Generic.ICollection<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> c)
		{
			const string __id = "addAll.(ILjava/util/Collection;)Z";
			IntPtr native_c = global::Android.Runtime.JavaCollection<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_addAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_util_Collection_Handler ()
		{
			if (cb_addAll_Ljava_util_Collection_ == null)
				cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddAll_Ljava_util_Collection_);
			return cb_addAll_Ljava_util_Collection_;
		}

		static bool n_AddAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (c);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends com.microsoft.identity.common.internal.dto.AccountRecord&gt;']]"
		[Register ("addAll", "(Ljava/util/Collection;)Z", "GetAddAll_Ljava_util_Collection_Handler")]
		public virtual unsafe bool AddAll (global::System.Collections.Generic.ICollection<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> c)
		{
			const string __id = "addAll.(Ljava/util/Collection;)Z";
			IntPtr native_c = global::Android.Runtime.JavaCollection<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
				global::System.GC.KeepAlive (c);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_contains_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_Object_Handler ()
		{
			if (cb_contains_Ljava_lang_Object_ == null)
				cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Ljava_lang_Object_);
			return cb_contains_Ljava_lang_Object_;
		}

		static bool n_Contains_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Z", "GetContains_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Contains (global::Java.Lang.Object o)
		{
			const string __id = "contains.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_containsAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetContainsAll_Ljava_util_Collection_Handler ()
		{
			if (cb_containsAll_Ljava_util_Collection_ == null)
				cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsAll_Ljava_util_Collection_);
			return cb_containsAll_Ljava_util_Collection_;
		}

		static bool n_ContainsAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAll (c);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='containsAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("containsAll", "(Ljava/util/Collection;)Z", "GetContainsAll_Ljava_util_Collection_Handler")]
		public virtual unsafe bool ContainsAll (global::System.Collections.Generic.ICollection<object> c)
		{
			const string __id = "containsAll.(Ljava/util/Collection;)Z";
			IntPtr native_c = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetGet_IHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord Get (int index)
		{
			const string __id = "get.(I)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_indexOf_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Ljava_lang_Object_Handler ()
		{
			if (cb_indexOf_Ljava_lang_Object_ == null)
				cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IndexOf_Ljava_lang_Object_);
			return cb_indexOf_Ljava_lang_Object_;
		}

		static int n_IndexOf_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("indexOf", "(Ljava/lang/Object;)I", "GetIndexOf_Ljava_lang_Object_Handler")]
		public virtual unsafe int IndexOf (global::Java.Lang.Object o)
		{
			const string __id = "indexOf.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_lastIndexOf_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Ljava_lang_Object_Handler ()
		{
			if (cb_lastIndexOf_Ljava_lang_Object_ == null)
				cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_LastIndexOf_Ljava_lang_Object_);
			return cb_lastIndexOf_Ljava_lang_Object_;
		}

		static int n_LastIndexOf_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("lastIndexOf", "(Ljava/lang/Object;)I", "GetLastIndexOf_Ljava_lang_Object_Handler")]
		public virtual unsafe int LastIndexOf (global::Java.Lang.Object o)
		{
			const string __id = "lastIndexOf.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_listIterator;
#pragma warning disable 0169
		static Delegate GetListIteratorHandler ()
		{
			if (cb_listIterator == null)
				cb_listIterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ListIterator);
			return cb_listIterator;
		}

		static IntPtr n_ListIterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListIterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='listIterator' and count(parameter)=0]"
		[Register ("listIterator", "()Ljava/util/ListIterator;", "GetListIteratorHandler")]
		public virtual unsafe global::Java.Util.IListIterator ListIterator ()
		{
			const string __id = "listIterator.()Ljava/util/ListIterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listIterator_I;
#pragma warning disable 0169
		static Delegate GetListIterator_IHandler ()
		{
			if (cb_listIterator_I == null)
				cb_listIterator_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ListIterator_I);
			return cb_listIterator_I;
		}

		static IntPtr n_ListIterator_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListIterator (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='listIterator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("listIterator", "(I)Ljava/util/ListIterator;", "GetListIterator_IHandler")]
		public virtual unsafe global::Java.Util.IListIterator ListIterator (int index)
		{
			const string __id = "listIterator.(I)Ljava/util/ListIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Remove_I);
			return cb_remove_I;
		}

		static IntPtr n_Remove_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetRemove_IHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord Remove (int index)
		{
			const string __id = "remove.(I)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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

		static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Remove (global::Java.Lang.Object o)
		{
			const string __id = "remove.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_removeAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_util_Collection_Handler ()
		{
			if (cb_removeAll_Ljava_util_Collection_ == null)
				cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAll_Ljava_util_Collection_);
			return cb_removeAll_Ljava_util_Collection_;
		}

		static bool n_RemoveAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAll (c);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("removeAll", "(Ljava/util/Collection;)Z", "GetRemoveAll_Ljava_util_Collection_Handler")]
		public virtual unsafe bool RemoveAll (global::System.Collections.Generic.ICollection<object> c)
		{
			const string __id = "removeAll.(Ljava/util/Collection;)Z";
			IntPtr native_c = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_retainAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRetainAll_Ljava_util_Collection_Handler ()
		{
			if (cb_retainAll_Ljava_util_Collection_ == null)
				cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RetainAll_Ljava_util_Collection_);
			return cb_retainAll_Ljava_util_Collection_;
		}

		static bool n_RetainAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RetainAll (c);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='retainAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("retainAll", "(Ljava/util/Collection;)Z", "GetRetainAll_Ljava_util_Collection_Handler")]
		public virtual unsafe bool RetainAll (global::System.Collections.Generic.ICollection<object> c)
		{
			const string __id = "retainAll.(Ljava/util/Collection;)Z";
			IntPtr native_c = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_set_ILcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
		static Delegate GetSet_ILcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
		{
			if (cb_set_ILcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
				cb_set_ILcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Set_ILcom_microsoft_identity_common_internal_dto_AccountRecord_);
			return cb_set_ILcom_microsoft_identity_common_internal_dto_AccountRecord_;
		}

		static IntPtr n_Set_ILcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_element, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (index, element));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("set", "(ILcom/microsoft/identity/common/internal/dto/AccountRecord;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "GetSet_ILcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord Set (int index, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord element)
		{
			const string __id = "set.(ILcom/microsoft/identity/common/internal/dto/AccountRecord;)Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (element);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_subList_II;
#pragma warning disable 0169
		static Delegate GetSubList_IIHandler ()
		{
			if (cb_subList_II == null)
				cb_subList_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SubList_II);
			return cb_subList_II;
		}

		static IntPtr n_SubList_II (IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.ToLocalJniHandle (__this.SubList (fromIndex, toIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='subList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("subList", "(II)Ljava/util/List;", "GetSubList_IIHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> SubList (int fromIndex, int toIndex)
		{
			const string __id = "subList.(II)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fromIndex);
				__args [1] = new JniArgumentValue (toIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/Object;", "GetToArrayHandler")]
		public virtual unsafe global::Java.Lang.Object[] ToArray ()
		{
			const string __id = "toArray.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_toArray_arrayLjava_lang_Object_ == null)
				cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ToArray_arrayLjava_lang_Object_);
			return cb_toArray_arrayLjava_lang_Object_;
		}

		static IntPtr n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.AccountDeletionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewArray (__this.ToArray (a));
			if (a != null)
				JNIEnv.CopyArray (a, native_a);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='AccountDeletionRecord']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "GetToArray_arrayLjava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] a)
		{
			const string __id = "toArray.([Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_a);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				global::System.GC.KeepAlive (a);
			}
		}

	}
}
