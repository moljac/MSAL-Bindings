using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='CurrentAccountResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/CurrentAccountResult", DoNotGenerateAcw=true)]
	public partial class CurrentAccountResult : global::Java.Lang.Object, global::Com.Microsoft.Identity.Client.ICurrentAccountResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/CurrentAccountResult", typeof (CurrentAccountResult));

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

		protected CurrentAccountResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='CurrentAccountResult']/constructor[@name='CurrentAccountResult' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.IAccount'] and parameter[2][@type='com.microsoft.identity.client.IAccount'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IAccount;Z)V", "")]
		public unsafe CurrentAccountResult (global::Com.Microsoft.Identity.Client.IAccount current, global::Com.Microsoft.Identity.Client.IAccount prior, bool changed) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/client/IAccount;Lcom/microsoft/identity/client/IAccount;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((current == null) ? IntPtr.Zero : ((global::Java.Lang.Object) current).Handle);
				__args [1] = new JniArgumentValue ((prior == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prior).Handle);
				__args [2] = new JniArgumentValue (changed);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (current);
				global::System.GC.KeepAlive (prior);
			}
		}

		static Delegate cb_getCurrentAccount;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccountHandler ()
		{
			if (cb_getCurrentAccount == null)
				cb_getCurrentAccount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentAccount);
			return cb_getCurrentAccount;
		}

		static IntPtr n_GetCurrentAccount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.CurrentAccountResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentAccount);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.IAccount CurrentAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='CurrentAccountResult']/method[@name='getCurrentAccount' and count(parameter)=0]"
			[Register ("getCurrentAccount", "()Lcom/microsoft/identity/client/IAccount;", "GetGetCurrentAccountHandler")]
			get {
				const string __id = "getCurrentAccount.()Lcom/microsoft/identity/client/IAccount;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPriorAccount;
#pragma warning disable 0169
		static Delegate GetGetPriorAccountHandler ()
		{
			if (cb_getPriorAccount == null)
				cb_getPriorAccount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPriorAccount);
			return cb_getPriorAccount;
		}

		static IntPtr n_GetPriorAccount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.CurrentAccountResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PriorAccount);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.IAccount PriorAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='CurrentAccountResult']/method[@name='getPriorAccount' and count(parameter)=0]"
			[Register ("getPriorAccount", "()Lcom/microsoft/identity/client/IAccount;", "GetGetPriorAccountHandler")]
			get {
				const string __id = "getPriorAccount.()Lcom/microsoft/identity/client/IAccount;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_didAccountChange;
#pragma warning disable 0169
		static Delegate GetDidAccountChangeHandler ()
		{
			if (cb_didAccountChange == null)
				cb_didAccountChange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DidAccountChange);
			return cb_didAccountChange;
		}

		static bool n_DidAccountChange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.CurrentAccountResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DidAccountChange ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='CurrentAccountResult']/method[@name='didAccountChange' and count(parameter)=0]"
		[Register ("didAccountChange", "()Z", "GetDidAccountChangeHandler")]
		public virtual unsafe bool DidAccountChange ()
		{
			const string __id = "didAccountChange.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
