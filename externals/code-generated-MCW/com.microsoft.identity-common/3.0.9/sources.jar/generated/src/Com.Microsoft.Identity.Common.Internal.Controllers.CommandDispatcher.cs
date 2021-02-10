using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/CommandDispatcher", DoNotGenerateAcw=true)]
	public partial class CommandDispatcher : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/CommandDispatcher", typeof (CommandDispatcher));

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

		protected CommandDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/constructor[@name='CommandDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandDispatcher () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe int CachedResultCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/method[@name='getCachedResultCount' and count(parameter)=0]"
			[Register ("getCachedResultCount", "()I", "")]
			get {
				const string __id = "getCachedResultCount.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/method[@name='beginInteractive' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.InteractiveTokenCommand']]"
		[Register ("beginInteractive", "(Lcom/microsoft/identity/common/internal/commands/InteractiveTokenCommand;)V", "")]
		public static unsafe void BeginInteractive (global::Com.Microsoft.Identity.Common.Internal.Commands.InteractiveTokenCommand command)
		{
			const string __id = "beginInteractive.(Lcom/microsoft/identity/common/internal/commands/InteractiveTokenCommand;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/method[@name='initializeDiagnosticContext' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("initializeDiagnosticContext", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string InitializeDiagnosticContext (string requestCorrelationId, string sdkType, string sdkVersion)
		{
			const string __id = "initializeDiagnosticContext.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_requestCorrelationId = JNIEnv.NewString (requestCorrelationId);
			IntPtr native_sdkType = JNIEnv.NewString (sdkType);
			IntPtr native_sdkVersion = JNIEnv.NewString (sdkVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_requestCorrelationId);
				__args [1] = new JniArgumentValue (native_sdkType);
				__args [2] = new JniArgumentValue (native_sdkVersion);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestCorrelationId);
				JNIEnv.DeleteLocalRef (native_sdkType);
				JNIEnv.DeleteLocalRef (native_sdkVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/method[@name='outstandingCommands' and count(parameter)=0]"
		[Register ("outstandingCommands", "()I", "")]
		public static unsafe int OutstandingCommands ()
		{
			const string __id = "outstandingCommands.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/method[@name='submitSilent' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.BaseCommand']]"
		[Register ("submitSilent", "(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)V", "")]
		public static unsafe void SubmitSilent (global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand command)
		{
			const string __id = "submitSilent.(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandDispatcher']/method[@name='submitSilentReturningFuture' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.BaseCommand']]"
		[Register ("submitSilentReturningFuture", "(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)Lcom/microsoft/identity/common/internal/result/FinalizableResultFuture;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Result.FinalizableResultFuture SubmitSilentReturningFuture (global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand command)
		{
			const string __id = "submitSilentReturningFuture.(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)Lcom/microsoft/identity/common/internal/result/FinalizableResultFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.FinalizableResultFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (command);
			}
		}

	}
}
