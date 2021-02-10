using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/BaseCommand", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class BaseCommand : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommand {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/BaseCommand", typeof (BaseCommand));

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

		protected BaseCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/constructor[@name='BaseCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.BaseController'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.CommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V", "")]
		public unsafe BaseCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters, global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController controller, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Lcom/microsoft/identity/common/internal/controllers/BaseController;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/constructor[@name='BaseCommand' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters'] and parameter[2][@type='java.util.List&lt;com.microsoft.identity.common.internal.controllers.BaseController&gt;'] and parameter[3][@type='com.microsoft.identity.common.internal.commands.CommandCallback'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Ljava/util/List;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V", "")]
		public unsafe BaseCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters, global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> controllers, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback @callback, string publicApiId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;Ljava/util/List;Lcom/microsoft/identity/common/internal/commands/CommandCallback;Ljava/lang/String;)V";

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

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/microsoft/identity/common/internal/commands/CommandCallback;", "GetGetCallbackHandler")]
			get {
				const string __id = "getCallback.()Lcom/microsoft/identity/common/internal/commands/CommandCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllers;
#pragma warning disable 0169
		static Delegate GetGetControllersHandler ()
		{
			if (cb_getControllers == null)
				cb_getControllers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetControllers);
			return cb_getControllers;
		}

		static IntPtr n_GetControllers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController>.ToLocalJniHandle (__this.Controllers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> Controllers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='getControllers' and count(parameter)=0]"
			[Register ("getControllers", "()Ljava/util/List;", "GetGetControllersHandler")]
			get {
				const string __id = "getControllers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultController;
#pragma warning disable 0169
		static Delegate GetGetDefaultControllerHandler ()
		{
			if (cb_getDefaultController == null)
				cb_getDefaultController = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultController);
			return cb_getDefaultController;
		}

		static IntPtr n_GetDefaultController (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultController);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController DefaultController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='getDefaultController' and count(parameter)=0]"
			[Register ("getDefaultController", "()Lcom/microsoft/identity/common/internal/controllers/BaseController;", "GetGetDefaultControllerHandler")]
			get {
				const string __id = "getDefaultController.()Lcom/microsoft/identity/common/internal/controllers/BaseController;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEligibleForCaching;
#pragma warning disable 0169
		static Delegate GetIsEligibleForCachingHandler ()
		{
			if (cb_isEligibleForCaching == null)
				cb_isEligibleForCaching = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEligibleForCaching);
			return cb_isEligibleForCaching;
		}

		static bool n_IsEligibleForCaching (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEligibleForCaching;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEligibleForCaching {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='isEligibleForCaching' and count(parameter)=0]"
			[Register ("isEligibleForCaching", "()Z", "GetIsEligibleForCachingHandler")]
			get {
				const string __id = "isEligibleForCaching.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;", "GetGetParametersHandler")]
			get {
				const string __id = "getParameters.()Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPublicApiId;
#pragma warning disable 0169
		static Delegate GetGetPublicApiIdHandler ()
		{
			if (cb_getPublicApiId == null)
				cb_getPublicApiId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublicApiId);
			return cb_getPublicApiId;
		}

		static IntPtr n_GetPublicApiId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PublicApiId);
		}
#pragma warning restore 0169

		public virtual unsafe string PublicApiId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='getPublicApiId' and count(parameter)=0]"
			[Register ("getPublicApiId", "()Ljava/lang/String;", "GetGetPublicApiIdHandler")]
			get {
				const string __id = "getPublicApiId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canEqual_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCanEqual_Ljava_lang_Object_Handler ()
		{
			if (cb_canEqual_Ljava_lang_Object_ == null)
				cb_canEqual_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanEqual_Ljava_lang_Object_);
			return cb_canEqual_Ljava_lang_Object_;
		}

		static bool n_CanEqual_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanEqual (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='canEqual' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("canEqual", "(Ljava/lang/Object;)Z", "GetCanEqual_Ljava_lang_Object_Handler")]
		protected virtual unsafe bool CanEqual (global::Java.Lang.Object other)
		{
			const string __id = "canEqual.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/Object;", "GetExecuteHandler")]
		public abstract global::Java.Lang.Object Execute ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEligibleForEstsTelemetry;
		}
#pragma warning restore 0169

		public abstract bool IsEligibleForEstsTelemetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/class[@name='BaseCommand']/method[@name='isEligibleForEstsTelemetry' and count(parameter)=0]"
			[Register ("isEligibleForEstsTelemetry", "()Z", "GetIsEligibleForEstsTelemetryHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/BaseCommand", DoNotGenerateAcw=true)]
	internal partial class BaseCommandInvoker : BaseCommand, global::Com.Microsoft.Identity.Common.Internal.Commands.ICommand {
		public BaseCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/BaseCommand", typeof (BaseCommandInvoker));

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
