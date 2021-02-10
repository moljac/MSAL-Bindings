using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='DeviceCodeFlowCommand']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/DeviceCodeFlowCommand", DoNotGenerateAcw=true)]
	public partial class DeviceCodeFlowCommand : global::Com.Microsoft.Identity.Common.Internal.Commands.TokenCommand {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/DeviceCodeFlowCommand", typeof (DeviceCodeFlowCommand));

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

		protected DeviceCodeFlowCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='DeviceCodeFlowCommand']/constructor[@name='DeviceCodeFlowCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.DeviceCodeFlowCommandParameters'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.BaseController'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.DeviceCodeFlowCommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/DeviceCodeFlowCommandCallback;Ljava/lang/String;)V", "")]
		public unsafe DeviceCodeFlowCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters parameters, global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController controller, global::Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/DeviceCodeFlowCommandCallback;Ljava/lang/String;)V";

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.DeviceCodeFlowCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEligibleForEstsTelemetry;
		}
#pragma warning restore 0169

		public override unsafe bool IsEligibleForEstsTelemetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='DeviceCodeFlowCommand']/method[@name='isEligibleForEstsTelemetry' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.DeviceCodeFlowCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='DeviceCodeFlowCommand']/method[@name='execute' and count(parameter)=0]"
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

	}
}