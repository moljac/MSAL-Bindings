using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultiTenantAccount']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/MultiTenantAccount", DoNotGenerateAcw=true)]
	public partial class MultiTenantAccount : global::Com.Microsoft.Identity.Client.Account, global::Com.Microsoft.Identity.Client.IMultiTenantAccount {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/MultiTenantAccount", typeof (MultiTenantAccount));

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

		protected MultiTenantAccount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getTenantProfiles;
#pragma warning disable 0169
		static Delegate GetGetTenantProfilesHandler ()
		{
			if (cb_getTenantProfiles == null)
				cb_getTenantProfiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantProfiles);
			return cb_getTenantProfiles;
		}

		static IntPtr n_GetTenantProfiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MultiTenantAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Microsoft.Identity.Client.ITenantProfile>.ToLocalJniHandle (__this.TenantProfiles);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Microsoft.Identity.Client.ITenantProfile> TenantProfiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MultiTenantAccount']/method[@name='getTenantProfiles' and count(parameter)=0]"
			[Register ("getTenantProfiles", "()Ljava/util/Map;", "GetGetTenantProfilesHandler")]
			get {
				const string __id = "getTenantProfiles.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Com.Microsoft.Identity.Client.ITenantProfile>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
