using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryContext']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryContext", DoNotGenerateAcw=true)]
	public partial class TelemetryContext : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Properties {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryContext", typeof (TelemetryContext));

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

		protected TelemetryContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_isNetworkConnected_Z;
#pragma warning disable 0169
		static Delegate GetIsNetworkConnected_ZHandler ()
		{
			if (cb_isNetworkConnected_Z == null)
				cb_isNetworkConnected_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_IsNetworkConnected_Z);
			return cb_isNetworkConnected_Z;
		}

		static void n_IsNetworkConnected_Z (IntPtr jnienv, IntPtr native__this, bool isConnected)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsNetworkConnected (isConnected);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryContext']/method[@name='isNetworkConnected' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isNetworkConnected", "(Z)V", "GetIsNetworkConnected_ZHandler")]
		public virtual unsafe void IsNetworkConnected (bool isConnected)
		{
			const string __id = "isNetworkConnected.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isConnected);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isNetworkDisabledFromOptimizations_Z;
#pragma warning disable 0169
		static Delegate GetIsNetworkDisabledFromOptimizations_ZHandler ()
		{
			if (cb_isNetworkDisabledFromOptimizations_Z == null)
				cb_isNetworkDisabledFromOptimizations_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_IsNetworkDisabledFromOptimizations_Z);
			return cb_isNetworkDisabledFromOptimizations_Z;
		}

		static void n_IsNetworkDisabledFromOptimizations_Z (IntPtr jnienv, IntPtr native__this, bool isDozed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsNetworkDisabledFromOptimizations (isDozed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryContext']/method[@name='isNetworkDisabledFromOptimizations' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isNetworkDisabledFromOptimizations", "(Z)V", "GetIsNetworkDisabledFromOptimizations_ZHandler")]
		public virtual unsafe void IsNetworkDisabledFromOptimizations (bool isDozed)
		{
			const string __id = "isNetworkDisabledFromOptimizations.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isDozed);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
