using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Keys {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='KeyStoreConfiguration']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/keys/KeyStoreConfiguration", DoNotGenerateAcw=true)]
	public partial class KeyStoreConfiguration : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/keys/KeyStoreConfiguration", typeof (KeyStoreConfiguration));

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

		protected KeyStoreConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='KeyStoreConfiguration']/constructor[@name='KeyStoreConfiguration' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;[C)V", "")]
		public unsafe KeyStoreConfiguration (string keyStoreType, string keyStoreProvider, char[] keyStorePassword) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;[C)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyStoreType = JNIEnv.NewString (keyStoreType);
			IntPtr native_keyStoreProvider = JNIEnv.NewString (keyStoreProvider);
			IntPtr native_keyStorePassword = JNIEnv.NewArray (keyStorePassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_keyStoreType);
				__args [1] = new JniArgumentValue (native_keyStoreProvider);
				__args [2] = new JniArgumentValue (native_keyStorePassword);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyStoreType);
				JNIEnv.DeleteLocalRef (native_keyStoreProvider);
				if (keyStorePassword != null) {
					JNIEnv.CopyArray (native_keyStorePassword, keyStorePassword);
					JNIEnv.DeleteLocalRef (native_keyStorePassword);
				}
				global::System.GC.KeepAlive (keyStorePassword);
			}
		}

		static Delegate cb_getKeyStoreProvider;
#pragma warning disable 0169
		static Delegate GetGetKeyStoreProviderHandler ()
		{
			if (cb_getKeyStoreProvider == null)
				cb_getKeyStoreProvider = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKeyStoreProvider);
			return cb_getKeyStoreProvider;
		}

		static IntPtr n_GetKeyStoreProvider (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.KeyStoreConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyStoreProvider);
		}
#pragma warning restore 0169

		public virtual unsafe string KeyStoreProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='KeyStoreConfiguration']/method[@name='getKeyStoreProvider' and count(parameter)=0]"
			[Register ("getKeyStoreProvider", "()Ljava/lang/String;", "GetGetKeyStoreProviderHandler")]
			get {
				const string __id = "getKeyStoreProvider.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeyStoreType;
#pragma warning disable 0169
		static Delegate GetGetKeyStoreTypeHandler ()
		{
			if (cb_getKeyStoreType == null)
				cb_getKeyStoreType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKeyStoreType);
			return cb_getKeyStoreType;
		}

		static IntPtr n_GetKeyStoreType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.KeyStoreConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyStoreType);
		}
#pragma warning restore 0169

		public virtual unsafe string KeyStoreType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='KeyStoreConfiguration']/method[@name='getKeyStoreType' and count(parameter)=0]"
			[Register ("getKeyStoreType", "()Ljava/lang/String;", "GetGetKeyStoreTypeHandler")]
			get {
				const string __id = "getKeyStoreType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeyStorePassword;
#pragma warning disable 0169
		static Delegate GetGetKeyStorePasswordHandler ()
		{
			if (cb_getKeyStorePassword == null)
				cb_getKeyStorePassword = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKeyStorePassword);
			return cb_getKeyStorePassword;
		}

		static IntPtr n_GetKeyStorePassword (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Keys.KeyStoreConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetKeyStorePassword ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.keys']/class[@name='KeyStoreConfiguration']/method[@name='getKeyStorePassword' and count(parameter)=0]"
		[Register ("getKeyStorePassword", "()[C", "GetGetKeyStorePasswordHandler")]
		public virtual unsafe char[] GetKeyStorePassword ()
		{
			const string __id = "getKeyStorePassword.()[C";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

	}
}
