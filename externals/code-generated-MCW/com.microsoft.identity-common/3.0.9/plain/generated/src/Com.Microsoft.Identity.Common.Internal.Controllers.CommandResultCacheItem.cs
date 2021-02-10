using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCacheItem']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/CommandResultCacheItem", DoNotGenerateAcw=true)]
	public partial class CommandResultCacheItem : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/CommandResultCacheItem", typeof (CommandResultCacheItem));

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

		protected CommandResultCacheItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCacheItem']/constructor[@name='CommandResultCacheItem' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.controllers.CommandResult']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/controllers/CommandResult;)V", "")]
		public unsafe CommandResultCacheItem (global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult value) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/controllers/CommandResult;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (value);
			}
		}

		static Delegate cb_isExpired;
#pragma warning disable 0169
		static Delegate GetIsExpiredHandler ()
		{
			if (cb_isExpired == null)
				cb_isExpired = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExpired);
			return cb_isExpired;
		}

		static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResultCacheItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCacheItem']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				const string __id = "isExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResultCacheItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCacheItem']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Lcom/microsoft/identity/common/internal/controllers/CommandResult;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Lcom/microsoft/identity/common/internal/controllers/CommandResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
