using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='HttpConfiguration']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/configuration/HttpConfiguration", DoNotGenerateAcw=true)]
	public partial class HttpConfiguration : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/configuration/HttpConfiguration", typeof (HttpConfiguration));

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

		protected HttpConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='HttpConfiguration']/constructor[@name='HttpConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getConnectTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectTimeoutHandler ()
		{
			if (cb_getConnectTimeout == null)
				cb_getConnectTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetConnectTimeout);
			return cb_getConnectTimeout;
		}

		static int n_GetConnectTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.HttpConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectTimeout_IHandler ()
		{
			if (cb_setConnectTimeout_I == null)
				cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetConnectTimeout_I);
			return cb_setConnectTimeout_I;
		}

		static void n_SetConnectTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.HttpConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectTimeout = timeout;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='HttpConfiguration']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()I", "GetGetConnectTimeoutHandler")]
			get {
				const string __id = "getConnectTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='HttpConfiguration']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler")]
			set {
				const string __id = "setConnectTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReadTimeout;
#pragma warning disable 0169
		static Delegate GetGetReadTimeoutHandler ()
		{
			if (cb_getReadTimeout == null)
				cb_getReadTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetReadTimeout);
			return cb_getReadTimeout;
		}

		static int n_GetReadTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.HttpConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setReadTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeout_IHandler ()
		{
			if (cb_setReadTimeout_I == null)
				cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetReadTimeout_I);
			return cb_setReadTimeout_I;
		}

		static void n_SetReadTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.HttpConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadTimeout = timeout;
		}
#pragma warning restore 0169

		public virtual unsafe int ReadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='HttpConfiguration']/method[@name='getReadTimeout' and count(parameter)=0]"
			[Register ("getReadTimeout", "()I", "GetGetReadTimeoutHandler")]
			get {
				const string __id = "getReadTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='HttpConfiguration']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler")]
			set {
				const string __id = "setReadTimeout.(I)V";
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
