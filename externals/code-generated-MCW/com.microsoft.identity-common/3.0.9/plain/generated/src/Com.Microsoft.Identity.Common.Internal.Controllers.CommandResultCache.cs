using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/CommandResultCache", DoNotGenerateAcw=true)]
	public partial class CommandResultCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/CommandResultCache", typeof (CommandResultCache));

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

		protected CommandResultCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']/constructor[@name='CommandResultCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandResultCache () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']/constructor[@name='CommandResultCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe CommandResultCache (int maxItemCount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxItemCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResultCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResultCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_Lcom_microsoft_identity_common_internal_commands_BaseCommand_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Handler ()
		{
			if (cb_get_Lcom_microsoft_identity_common_internal_commands_BaseCommand_ == null)
				cb_get_Lcom_microsoft_identity_common_internal_commands_BaseCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Lcom_microsoft_identity_common_internal_commands_BaseCommand_);
			return cb_get_Lcom_microsoft_identity_common_internal_commands_BaseCommand_;
		}

		static IntPtr n_Get_Lcom_microsoft_identity_common_internal_commands_BaseCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResultCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.BaseCommand']]"
		[Register ("get", "(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)Lcom/microsoft/identity/common/internal/controllers/CommandResult;", "GetGet_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult Get (global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand key)
		{
			const string __id = "get.(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)Lcom/microsoft/identity/common/internal/controllers/CommandResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

		static Delegate cb_put_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_Handler ()
		{
			if (cb_put_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_ == null)
				cb_put_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_);
			return cb_put_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_;
		}

		static void n_Put_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResultCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (native_key, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResultCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.BaseCommand'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.CommandResult']]"
		[Register ("put", "(Lcom/microsoft/identity/common/internal/commands/BaseCommand;Lcom/microsoft/identity/common/internal/controllers/CommandResult;)V", "GetPut_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_Handler")]
		public virtual unsafe void Put (global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand key, global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult value)
		{
			const string __id = "put.(Lcom/microsoft/identity/common/internal/commands/BaseCommand;Lcom/microsoft/identity/common/internal/controllers/CommandResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (key);
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
