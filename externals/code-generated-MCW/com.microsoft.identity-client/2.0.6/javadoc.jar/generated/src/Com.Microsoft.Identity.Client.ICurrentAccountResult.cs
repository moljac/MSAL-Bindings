using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ICurrentAccountResult']"
	[Register ("com/microsoft/identity/client/ICurrentAccountResult", "", "Com.Microsoft.Identity.Client.ICurrentAccountResultInvoker")]
	public partial interface ICurrentAccountResult : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Client.IAccount CurrentAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ICurrentAccountResult']/method[@name='getCurrentAccount' and count(parameter)=0]"
			[Register ("getCurrentAccount", "()Lcom/microsoft/identity/client/IAccount;", "GetGetCurrentAccountHandler:Com.Microsoft.Identity.Client.ICurrentAccountResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		global::Com.Microsoft.Identity.Client.IAccount PriorAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ICurrentAccountResult']/method[@name='getPriorAccount' and count(parameter)=0]"
			[Register ("getPriorAccount", "()Lcom/microsoft/identity/client/IAccount;", "GetGetPriorAccountHandler:Com.Microsoft.Identity.Client.ICurrentAccountResultInvoker, Microsoft.Identity.Client")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ICurrentAccountResult']/method[@name='didAccountChange' and count(parameter)=0]"
		[Register ("didAccountChange", "()Z", "GetDidAccountChangeHandler:Com.Microsoft.Identity.Client.ICurrentAccountResultInvoker, Microsoft.Identity.Client")]
		bool DidAccountChange ();

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/ICurrentAccountResult", DoNotGenerateAcw=true)]
	internal partial class ICurrentAccountResultInvoker : global::Java.Lang.Object, ICurrentAccountResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/ICurrentAccountResult", typeof (ICurrentAccountResultInvoker));

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

		public static ICurrentAccountResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICurrentAccountResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.ICurrentAccountResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICurrentAccountResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ICurrentAccountResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentAccount);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAccount;
		public unsafe global::Com.Microsoft.Identity.Client.IAccount CurrentAccount {
			get {
				if (id_getCurrentAccount == IntPtr.Zero)
					id_getCurrentAccount = JNIEnv.GetMethodID (class_ref, "getCurrentAccount", "()Lcom/microsoft/identity/client/IAccount;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAccount), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ICurrentAccountResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PriorAccount);
		}
#pragma warning restore 0169

		IntPtr id_getPriorAccount;
		public unsafe global::Com.Microsoft.Identity.Client.IAccount PriorAccount {
			get {
				if (id_getPriorAccount == IntPtr.Zero)
					id_getPriorAccount = JNIEnv.GetMethodID (class_ref, "getPriorAccount", "()Lcom/microsoft/identity/client/IAccount;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAccount> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPriorAccount), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ICurrentAccountResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DidAccountChange ();
		}
#pragma warning restore 0169

		IntPtr id_didAccountChange;
		public unsafe bool DidAccountChange ()
		{
			if (id_didAccountChange == IntPtr.Zero)
				id_didAccountChange = JNIEnv.GetMethodID (class_ref, "didAccountChange", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_didAccountChange);
		}

	}
}
