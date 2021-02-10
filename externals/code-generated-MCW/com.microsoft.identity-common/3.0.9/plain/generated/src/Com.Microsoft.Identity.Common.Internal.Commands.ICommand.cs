using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='Command']"
	[Register ("com/microsoft/identity/common/internal/commands/Command", "", "Com.Microsoft.Identity.Common.Internal.Commands.ICommandInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICommand : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController DefaultController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='Command']/method[@name='getDefaultController' and count(parameter)=0]"
			[Register ("getDefaultController", "()Lcom/microsoft/identity/common/internal/controllers/BaseController;", "GetGetDefaultControllerHandler:Com.Microsoft.Identity.Common.Internal.Commands.ICommandInvoker, Microsoft.Identity.Common")]
			get; 
		}

		bool IsEligibleForCaching {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='Command']/method[@name='isEligibleForCaching' and count(parameter)=0]"
			[Register ("isEligibleForCaching", "()Z", "GetIsEligibleForCachingHandler:Com.Microsoft.Identity.Common.Internal.Commands.ICommandInvoker, Microsoft.Identity.Common")]
			get; 
		}

		bool IsEligibleForEstsTelemetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='Command']/method[@name='isEligibleForEstsTelemetry' and count(parameter)=0]"
			[Register ("isEligibleForEstsTelemetry", "()Z", "GetIsEligibleForEstsTelemetryHandler:Com.Microsoft.Identity.Common.Internal.Commands.ICommandInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='Command']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/Object;", "GetExecuteHandler:Com.Microsoft.Identity.Common.Internal.Commands.ICommandInvoker, Microsoft.Identity.Common")]
		global::Java.Lang.Object Execute ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/Command", DoNotGenerateAcw=true)]
	internal partial class ICommandInvoker : global::Java.Lang.Object, ICommand {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/Command", typeof (ICommandInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICommand GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommand> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.commands.Command"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultController);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultController;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController DefaultController {
			get {
				if (id_getDefaultController == IntPtr.Zero)
					id_getDefaultController = JNIEnv.GetMethodID (class_ref, "getDefaultController", "()Lcom/microsoft/identity/common/internal/controllers/BaseController;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultController), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEligibleForCaching;
		}
#pragma warning restore 0169

		IntPtr id_isEligibleForCaching;
		public unsafe bool IsEligibleForCaching {
			get {
				if (id_isEligibleForCaching == IntPtr.Zero)
					id_isEligibleForCaching = JNIEnv.GetMethodID (class_ref, "isEligibleForCaching", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEligibleForCaching);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEligibleForEstsTelemetry;
		}
#pragma warning restore 0169

		IntPtr id_isEligibleForEstsTelemetry;
		public unsafe bool IsEligibleForEstsTelemetry {
			get {
				if (id_isEligibleForEstsTelemetry == IntPtr.Zero)
					id_isEligibleForEstsTelemetry = JNIEnv.GetMethodID (class_ref, "isEligibleForEstsTelemetry", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEligibleForEstsTelemetry);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		IntPtr id_execute;
		public unsafe global::Java.Lang.Object Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute), JniHandleOwnership.TransferLocalRef);
		}

	}
}
