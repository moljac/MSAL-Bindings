using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache.Registry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache.registry']/class[@name='BrokerApplicationRegistryData']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/registry/BrokerApplicationRegistryData", DoNotGenerateAcw=true)]
	public partial class BrokerApplicationRegistryData : global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractApplicationMetadata {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/registry/BrokerApplicationRegistryData", typeof (BrokerApplicationRegistryData));

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

		protected BrokerApplicationRegistryData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache.registry']/class[@name='BrokerApplicationRegistryData']/constructor[@name='BrokerApplicationRegistryData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerApplicationRegistryData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isWpjAccountAccessAllowed;
#pragma warning disable 0169
		static Delegate GetIsWpjAccountAccessAllowedHandler ()
		{
			if (cb_isWpjAccountAccessAllowed == null)
				cb_isWpjAccountAccessAllowed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWpjAccountAccessAllowed);
			return cb_isWpjAccountAccessAllowed;
		}

		static bool n_IsWpjAccountAccessAllowed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.Registry.BrokerApplicationRegistryData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WpjAccountAccessAllowed;
		}
#pragma warning restore 0169

		static Delegate cb_setWpjAccountAccessAllowed_Z;
#pragma warning disable 0169
		static Delegate GetSetWpjAccountAccessAllowed_ZHandler ()
		{
			if (cb_setWpjAccountAccessAllowed_Z == null)
				cb_setWpjAccountAccessAllowed_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetWpjAccountAccessAllowed_Z);
			return cb_setWpjAccountAccessAllowed_Z;
		}

		static void n_SetWpjAccountAccessAllowed_Z (IntPtr jnienv, IntPtr native__this, bool allow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.Registry.BrokerApplicationRegistryData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WpjAccountAccessAllowed = allow;
		}
#pragma warning restore 0169

		public virtual unsafe bool WpjAccountAccessAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache.registry']/class[@name='BrokerApplicationRegistryData']/method[@name='isWpjAccountAccessAllowed' and count(parameter)=0]"
			[Register ("isWpjAccountAccessAllowed", "()Z", "GetIsWpjAccountAccessAllowedHandler")]
			get {
				const string __id = "isWpjAccountAccessAllowed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache.registry']/class[@name='BrokerApplicationRegistryData']/method[@name='setWpjAccountAccessAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWpjAccountAccessAllowed", "(Z)V", "GetSetWpjAccountAccessAllowed_ZHandler")]
			set {
				const string __id = "setWpjAccountAccessAllowed.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
