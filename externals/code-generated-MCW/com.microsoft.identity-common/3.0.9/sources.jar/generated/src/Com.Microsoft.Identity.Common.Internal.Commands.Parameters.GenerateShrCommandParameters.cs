using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands.Parameters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='GenerateShrCommandParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters", DoNotGenerateAcw=true)]
	public partial class GenerateShrCommandParameters : global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters", typeof (GenerateShrCommandParameters));

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

		protected GenerateShrCommandParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getHomeAccountId;
#pragma warning disable 0169
		static Delegate GetGetHomeAccountIdHandler ()
		{
			if (cb_getHomeAccountId == null)
				cb_getHomeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHomeAccountId);
			return cb_getHomeAccountId;
		}

		static IntPtr n_GetHomeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='GenerateShrCommandParameters']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get {
				const string __id = "getHomeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPopParameters;
#pragma warning disable 0169
		static Delegate GetGetPopParametersHandler ()
		{
			if (cb_getPopParameters == null)
				cb_getPopParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPopParameters);
			return cb_getPopParameters;
		}

		static IntPtr n_GetPopParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PopParameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams PopParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='GenerateShrCommandParameters']/method[@name='getPopParameters' and count(parameter)=0]"
			[Register ("getPopParameters", "()Lcom/microsoft/identity/common/internal/authscheme/IPoPAuthenticationSchemeParams;", "GetGetPopParametersHandler")]
			get {
				const string __id = "getPopParameters.()Lcom/microsoft/identity/common/internal/authscheme/IPoPAuthenticationSchemeParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.IPoPAuthenticationSchemeParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
