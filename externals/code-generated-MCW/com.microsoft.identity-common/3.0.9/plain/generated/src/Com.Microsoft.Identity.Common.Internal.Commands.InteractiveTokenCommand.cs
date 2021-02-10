using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='InteractiveTokenCommand']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/InteractiveTokenCommand", DoNotGenerateAcw=true)]
	public partial class InteractiveTokenCommand : global::Com.Microsoft.Identity.Common.Internal.Commands.TokenCommand {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/InteractiveTokenCommand", typeof (InteractiveTokenCommand));

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

		protected InteractiveTokenCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='InteractiveTokenCommand']/constructor[@name='InteractiveTokenCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.BaseController'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.CommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V", "")]
		public unsafe InteractiveTokenCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters, global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController controller, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_publicApiId = JNIEnv.NewString (publicApiId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue (native_publicApiId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicApiId);
				global::System.GC.KeepAlive (parameters);
				global::System.GC.KeepAlive (controller);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='InteractiveTokenCommand']/constructor[@name='InteractiveTokenCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters'] and parameter[2][@type='java.util.List&lt;com.microsoft.identity.common.internal.controllers.BaseController&gt;'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.CommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Ljava/util/List;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V", "")]
		public unsafe InteractiveTokenCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> controllers, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;Ljava/util/List;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_controllers = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController>.ToLocalJniHandle (controllers);
			IntPtr native_publicApiId = JNIEnv.NewString (publicApiId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue (native_controllers);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue (native_publicApiId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllers);
				JNIEnv.DeleteLocalRef (native_publicApiId);
				global::System.GC.KeepAlive (parameters);
				global::System.GC.KeepAlive (controllers);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_isEligibleForEstsTelemetry;
#pragma warning disable 0169
		static Delegate GetIsEligibleForEstsTelemetryHandler ()
		{
			if (cb_isEligibleForEstsTelemetry == null)
				cb_isEligibleForEstsTelemetry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEligibleForEstsTelemetry);
			return cb_isEligibleForEstsTelemetry;
		}

		static bool n_IsEligibleForEstsTelemetry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.InteractiveTokenCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEligibleForEstsTelemetry;
		}
#pragma warning restore 0169

		public override unsafe bool IsEligibleForEstsTelemetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='InteractiveTokenCommand']/method[@name='isEligibleForEstsTelemetry' and count(parameter)=0]"
			[Register ("isEligibleForEstsTelemetry", "()Z", "GetIsEligibleForEstsTelemetryHandler")]
			get {
				const string __id = "isEligibleForEstsTelemetry.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Execute);
			return cb_execute;
		}

		static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.InteractiveTokenCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='InteractiveTokenCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;", "GetExecuteHandler")]
		public override unsafe global::Java.Lang.Object Execute ()
		{
			const string __id = "execute.()Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notify_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetNotify_IILandroid_content_Intent_Handler ()
		{
			if (cb_notify_IILandroid_content_Intent_ == null)
				cb_notify_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_Notify_IILandroid_content_Intent_);
			return cb_notify_IILandroid_content_Intent_;
		}

		static void n_Notify_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int requestCode, int resultCode, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.InteractiveTokenCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Notify (requestCode, resultCode, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='InteractiveTokenCommand']/method[@name='notify' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("notify", "(IILandroid/content/Intent;)V", "GetNotify_IILandroid_content_Intent_Handler")]
		public virtual unsafe void Notify (int requestCode, int resultCode, global::Android.Content.Intent data)
		{
			const string __id = "notify.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestCode);
				__args [1] = new JniArgumentValue (resultCode);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
