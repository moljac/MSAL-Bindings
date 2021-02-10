using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='TokenCommand']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/TokenCommand", DoNotGenerateAcw=true)]
	public abstract partial class TokenCommand : global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/TokenCommand", typeof (TokenCommand));

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

		protected TokenCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='TokenCommand']/constructor[@name='TokenCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.TokenCommandParameters'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.BaseController'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.CommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V", "")]
		public unsafe TokenCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters parameters, global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController controller, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='TokenCommand']/constructor[@name='TokenCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.TokenCommandParameters'] and parameter[2][@type='java.util.List&lt;com.microsoft.identity.common.internal.controllers.BaseController&gt;'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.CommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;Ljava/util/List;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V", "")]
		public unsafe TokenCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters parameters, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> controllers, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters;Ljava/util/List;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V";

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

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/TokenCommand", DoNotGenerateAcw=true)]
	internal partial class TokenCommandInvoker : TokenCommand {
		public TokenCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/TokenCommand", typeof (TokenCommandInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/Object;", "GetExecuteHandler")]
		public override unsafe global::Java.Lang.Object Execute ()
		{
			const string __id = "execute.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public override unsafe bool IsEligibleForEstsTelemetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='isEligibleForEstsTelemetry' and count(parameter)=0]"
			[Register ("isEligibleForEstsTelemetry", "()Z", "GetIsEligibleForEstsTelemetryHandler")]
			get {
				const string __id = "isEligibleForEstsTelemetry.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
