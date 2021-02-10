using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/ResultFuture", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ResultFuture : global::Java.Lang.Object, global::Java.Util.Concurrent.IFuture {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/ResultFuture", typeof (ResultFuture));

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

		protected ResultFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/constructor[@name='ResultFuture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultFuture () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				const string __id = "isCancelled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler")]
			get {
				const string __id = "isDone.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "GetCancel_ZHandler")]
		public virtual unsafe bool Cancel (bool b)
		{
			const string __id = "cancel.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			const string __id = "get.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long l, IntPtr native_timeUnit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeUnit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_timeUnit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (l, timeUnit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (long l, global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			const string __id = "get.(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (l);
				__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeUnit);
			}
		}

		static Delegate cb_setException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetSetException_Ljava_lang_Exception_Handler ()
		{
			if (cb_setException_Ljava_lang_Exception_ == null)
				cb_setException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetException_Ljava_lang_Exception_);
			return cb_setException_Ljava_lang_Exception_;
		}

		static void n_SetException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.SetException (exception);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='setException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("setException", "(Ljava/lang/Exception;)V", "GetSetException_Ljava_lang_Exception_Handler")]
		public virtual unsafe void SetException (global::Java.Lang.Exception exception)
		{
			const string __id = "setException.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

		static Delegate cb_setResult_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetResult_Ljava_lang_Object_Handler ()
		{
			if (cb_setResult_Ljava_lang_Object_ == null)
				cb_setResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResult_Ljava_lang_Object_);
			return cb_setResult_Ljava_lang_Object_;
		}

		static void n_SetResult_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.SetResult (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("setResult", "(Ljava/lang/Object;)V", "GetSetResult_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetResult (global::Java.Lang.Object result)
		{
			const string __id = "setResult.(Ljava/lang/Object;)V";
			IntPtr native_result = JNIEnv.ToLocalJniHandle (result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_result);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_result);
				global::System.GC.KeepAlive (result);
			}
		}

		static Delegate cb_whenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_;
#pragma warning disable 0169
		static Delegate GetWhenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_Handler ()
		{
			if (cb_whenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_ == null)
				cb_whenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WhenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_);
			return cb_whenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_;
		}

		static void n_WhenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumerToAdd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var consumerToAdd = (global::Com.Microsoft.Identity.Common.Internal.Util.IBiConsumer)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IBiConsumer> (native_consumerToAdd, JniHandleOwnership.DoNotTransfer);
			__this.WhenComplete (consumerToAdd);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='ResultFuture']/method[@name='whenComplete' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.util.BiConsumer&lt;T, java.lang.Throwable&gt;']]"
		[Register ("whenComplete", "(Lcom/microsoft/identity/common/internal/util/BiConsumer;)V", "GetWhenComplete_Lcom_microsoft_identity_common_internal_util_BiConsumer_Handler")]
		public virtual unsafe void WhenComplete (global::Com.Microsoft.Identity.Common.Internal.Util.IBiConsumer consumerToAdd)
		{
			const string __id = "whenComplete.(Lcom/microsoft/identity/common/internal/util/BiConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumerToAdd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumerToAdd).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (consumerToAdd);
			}
		}

	}
}
