using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='DefaultConnectionService']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/net/DefaultConnectionService", DoNotGenerateAcw=true)]
	public partial class DefaultConnectionService : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IConnectionService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/net/DefaultConnectionService", typeof (DefaultConnectionService));

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

		protected DefaultConnectionService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='DefaultConnectionService']/constructor[@name='DefaultConnectionService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DefaultConnectionService (global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (ctx);
			}
		}

		static Delegate cb_isConnectionAvailable;
#pragma warning disable 0169
		static Delegate GetIsConnectionAvailableHandler ()
		{
			if (cb_isConnectionAvailable == null)
				cb_isConnectionAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnectionAvailable);
			return cb_isConnectionAvailable;
		}

		static bool n_IsConnectionAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.DefaultConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnectionAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnectionAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='DefaultConnectionService']/method[@name='isConnectionAvailable' and count(parameter)=0]"
			[Register ("isConnectionAvailable", "()Z", "GetIsConnectionAvailableHandler")]
			get {
				const string __id = "isConnectionAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNetworkDisabledFromOptimizations;
#pragma warning disable 0169
		static Delegate GetIsNetworkDisabledFromOptimizationsHandler ()
		{
			if (cb_isNetworkDisabledFromOptimizations == null)
				cb_isNetworkDisabledFromOptimizations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNetworkDisabledFromOptimizations);
			return cb_isNetworkDisabledFromOptimizations;
		}

		static bool n_IsNetworkDisabledFromOptimizations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.DefaultConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNetworkDisabledFromOptimizations;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNetworkDisabledFromOptimizations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='DefaultConnectionService']/method[@name='isNetworkDisabledFromOptimizations' and count(parameter)=0]"
			[Register ("isNetworkDisabledFromOptimizations", "()Z", "GetIsNetworkDisabledFromOptimizationsHandler")]
			get {
				const string __id = "isNetworkDisabledFromOptimizations.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
