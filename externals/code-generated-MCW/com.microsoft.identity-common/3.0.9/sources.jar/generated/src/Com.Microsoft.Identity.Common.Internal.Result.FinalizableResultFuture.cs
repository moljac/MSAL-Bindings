using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='FinalizableResultFuture']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/FinalizableResultFuture", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class FinalizableResultFuture : global::Com.Microsoft.Identity.Common.Internal.Result.ResultFuture {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/FinalizableResultFuture", typeof (FinalizableResultFuture));

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

		protected FinalizableResultFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='FinalizableResultFuture']/constructor[@name='FinalizableResultFuture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FinalizableResultFuture () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isCleanedUp;
#pragma warning disable 0169
		static Delegate GetIsCleanedUpHandler ()
		{
			if (cb_isCleanedUp == null)
				cb_isCleanedUp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCleanedUp);
			return cb_isCleanedUp;
		}

		static bool n_IsCleanedUp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.FinalizableResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCleanedUp;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCleanedUp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='FinalizableResultFuture']/method[@name='isCleanedUp' and count(parameter)=0]"
			[Register ("isCleanedUp", "()Z", "GetIsCleanedUpHandler")]
			get {
				const string __id = "isCleanedUp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_setCleanedUp;
#pragma warning disable 0169
		static Delegate GetSetCleanedUpHandler ()
		{
			if (cb_setCleanedUp == null)
				cb_setCleanedUp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetCleanedUp);
			return cb_setCleanedUp;
		}

		static void n_SetCleanedUp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.FinalizableResultFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCleanedUp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='FinalizableResultFuture']/method[@name='setCleanedUp' and count(parameter)=0]"
		[Register ("setCleanedUp", "()V", "GetSetCleanedUpHandler")]
		public virtual unsafe void SetCleanedUp ()
		{
			const string __id = "setCleanedUp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
