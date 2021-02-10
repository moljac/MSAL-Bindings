using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationStrategyFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/AuthorizationStrategyFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericAuthorizationStrategy extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationStrategy"})]
	public partial class AuthorizationStrategyFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/AuthorizationStrategyFactory", typeof (AuthorizationStrategyFactory));

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

		protected AuthorizationStrategyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationStrategyFactory']/constructor[@name='AuthorizationStrategyFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizationStrategyFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationStrategyFactory Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationStrategyFactory']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/internal/ui/AuthorizationStrategyFactory;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/internal/ui/AuthorizationStrategyFactory;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationStrategyFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler ()
		{
			if (cb_getAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ == null)
				cb_getAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_);
			return cb_getAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_;
		}

		static IntPtr n_GetAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationStrategyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthorizationStrategy (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='AuthorizationStrategyFactory']/method[@name='getAuthorizationStrategy' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.InteractiveTokenCommandParameters']]"
		[Register ("getAuthorizationStrategy", "(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy;", "GetGetAuthorizationStrategy_Lcom_microsoft_identity_common_internal_commands_parameters_InteractiveTokenCommandParameters_Handler")]
		public virtual unsafe global::Java.Lang.Object GetAuthorizationStrategy (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters parameters)
		{
			const string __id = "getAuthorizationStrategy.(Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

	}
}
