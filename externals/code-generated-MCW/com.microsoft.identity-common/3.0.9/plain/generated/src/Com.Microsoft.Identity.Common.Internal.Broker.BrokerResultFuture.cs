using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerResultFuture", DoNotGenerateAcw=true)]
	public partial class BrokerResultFuture : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerResultFuture", typeof (BrokerResultFuture));

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

		protected BrokerResultFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/constructor[@name='BrokerResultFuture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerResultFuture () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/method[@name='isCancelled' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/method[@name='isDone' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Landroid/os/Bundle;", "GetGetHandler")]
		public virtual unsafe global::Android.OS.Bundle Get ()
		{
			const string __id = "get.()Landroid/os/Bundle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeUnit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_timeUnit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (l, timeUnit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Landroid/os/Bundle;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Android.OS.Bundle Get (long l, global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			const string __id = "get.(JLjava/util/concurrent/TimeUnit;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (l);
				__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeUnit);
			}
		}

		static Delegate cb_setResultBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetResultBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_setResultBundle_Landroid_os_Bundle_ == null)
				cb_setResultBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResultBundle_Landroid_os_Bundle_);
			return cb_setResultBundle_Landroid_os_Bundle_;
		}

		static void n_SetResultBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_resultBundle, JniHandleOwnership.DoNotTransfer);
			__this.SetResultBundle (resultBundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerResultFuture']/method[@name='setResultBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setResultBundle", "(Landroid/os/Bundle;)V", "GetSetResultBundle_Landroid_os_Bundle_Handler")]
		public virtual unsafe void SetResultBundle (global::Android.OS.Bundle resultBundle)
		{
			const string __id = "setResultBundle.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultBundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (resultBundle);
			}
		}

	}
}
