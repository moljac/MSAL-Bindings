using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='IntuneAcquireTokenParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/IntuneAcquireTokenParameters", DoNotGenerateAcw=true)]
	public partial class IntuneAcquireTokenParameters : global::Com.Microsoft.Identity.Client.AcquireTokenParameters {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='IntuneAcquireTokenParameters.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/IntuneAcquireTokenParameters$Builder", DoNotGenerateAcw=true)]
		public new partial class Builder : global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/IntuneAcquireTokenParameters$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='IntuneAcquireTokenParameters.Builder']/constructor[@name='IntuneAcquireTokenParameters.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_brokerBrowserSupportEnabled_Z;
#pragma warning disable 0169
			static Delegate GetBrokerBrowserSupportEnabled_ZHandler ()
			{
				if (cb_brokerBrowserSupportEnabled_Z == null)
					cb_brokerBrowserSupportEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_BrokerBrowserSupportEnabled_Z);
				return cb_brokerBrowserSupportEnabled_Z;
			}

			static IntPtr n_BrokerBrowserSupportEnabled_Z (IntPtr jnienv, IntPtr native__this, bool brokerBrowserSupportEnabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Internal.IntuneAcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BrokerBrowserSupportEnabled (brokerBrowserSupportEnabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='IntuneAcquireTokenParameters.Builder']/method[@name='brokerBrowserSupportEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("brokerBrowserSupportEnabled", "(Z)Lcom/microsoft/identity/client/internal/IntuneAcquireTokenParameters$Builder;", "GetBrokerBrowserSupportEnabled_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.Internal.IntuneAcquireTokenParameters.Builder BrokerBrowserSupportEnabled (bool brokerBrowserSupportEnabled)
			{
				const string __id = "brokerBrowserSupportEnabled.(Z)Lcom/microsoft/identity/client/internal/IntuneAcquireTokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (brokerBrowserSupportEnabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Internal.IntuneAcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/IntuneAcquireTokenParameters", typeof (IntuneAcquireTokenParameters));

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

		protected IntuneAcquireTokenParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_isBrokerBrowserSupportEnabled;
#pragma warning disable 0169
		static Delegate GetIsBrokerBrowserSupportEnabledHandler ()
		{
			if (cb_isBrokerBrowserSupportEnabled == null)
				cb_isBrokerBrowserSupportEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBrokerBrowserSupportEnabled);
			return cb_isBrokerBrowserSupportEnabled;
		}

		static bool n_IsBrokerBrowserSupportEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Internal.IntuneAcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBrokerBrowserSupportEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBrokerBrowserSupportEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='IntuneAcquireTokenParameters']/method[@name='isBrokerBrowserSupportEnabled' and count(parameter)=0]"
			[Register ("isBrokerBrowserSupportEnabled", "()Z", "GetIsBrokerBrowserSupportEnabledHandler")]
			get {
				const string __id = "isBrokerBrowserSupportEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
