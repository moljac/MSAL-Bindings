using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Keys {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='ClientCertificateMetadata']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/keys/ClientCertificateMetadata", DoNotGenerateAcw=true)]
	public partial class ClientCertificateMetadata : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/keys/ClientCertificateMetadata", typeof (ClientCertificateMetadata));

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

		protected ClientCertificateMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='ClientCertificateMetadata']/constructor[@name='ClientCertificateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]']]"
		[Register (".ctor", "(Ljava/lang/String;[C)V", "")]
		public unsafe ClientCertificateMetadata (string alias, char[] password) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[C)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_alias = JNIEnv.NewString (alias);
			IntPtr native_password = JNIEnv.NewArray (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_alias);
				__args [1] = new JniArgumentValue (native_password);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
				if (password != null) {
					JNIEnv.CopyArray (native_password, password);
					JNIEnv.DeleteLocalRef (native_password);
				}
				global::System.GC.KeepAlive (password);
			}
		}

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.ClientCertificateMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		public virtual unsafe string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='ClientCertificateMetadata']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				const string __id = "getAlias.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.ClientCertificateMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPassword ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='ClientCertificateMetadata']/method[@name='getPassword' and count(parameter)=0]"
		[Register ("getPassword", "()[C", "GetGetPasswordHandler")]
		public virtual unsafe char[] GetPassword ()
		{
			const string __id = "getPassword.()[C";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

	}
}
