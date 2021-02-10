using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authorities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectorySlice']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectorySlice", DoNotGenerateAcw=true)]
	public partial class AzureActiveDirectorySlice : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectorySlice", typeof (AzureActiveDirectorySlice));

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

		protected AzureActiveDirectorySlice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectorySlice']/constructor[@name='AzureActiveDirectorySlice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AzureActiveDirectorySlice () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDC;
#pragma warning disable 0169
		static Delegate GetGetDCHandler ()
		{
			if (cb_getDC == null)
				cb_getDC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDC);
			return cb_getDC;
		}

		static IntPtr n_GetDC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectorySlice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DC);
		}
#pragma warning restore 0169

		public virtual unsafe string DC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectorySlice']/method[@name='getDC' and count(parameter)=0]"
			[Register ("getDC", "()Ljava/lang/String;", "GetGetDCHandler")]
			get {
				const string __id = "getDC.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSlice;
#pragma warning disable 0169
		static Delegate GetGetSliceHandler ()
		{
			if (cb_getSlice == null)
				cb_getSlice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSlice);
			return cb_getSlice;
		}

		static IntPtr n_GetSlice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectorySlice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Slice);
		}
#pragma warning restore 0169

		public virtual unsafe string Slice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectorySlice']/method[@name='getSlice' and count(parameter)=0]"
			[Register ("getSlice", "()Ljava/lang/String;", "GetGetSliceHandler")]
			get {
				const string __id = "getSlice.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
