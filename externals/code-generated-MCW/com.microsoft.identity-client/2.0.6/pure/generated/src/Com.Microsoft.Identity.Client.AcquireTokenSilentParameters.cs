using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/AcquireTokenSilentParameters", DoNotGenerateAcw=true)]
	public partial class AcquireTokenSilentParameters : global::Com.Microsoft.Identity.Client.TokenParameters {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/AcquireTokenSilentParameters$Builder", DoNotGenerateAcw=true)]
		public new partial class Builder : global::Com.Microsoft.Identity.Client.TokenParameters.Builder {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AcquireTokenSilentParameters$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters.Builder']/constructor[@name='AcquireTokenSilentParameters.Builder' and count(parameter)=0]"
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/client/AcquireTokenSilentParameters;", "GetBuildHandler")]
			public override unsafe global::Com.Microsoft.Identity.Client.TokenParameters Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/client/AcquireTokenSilentParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_forceRefresh_Z;
#pragma warning disable 0169
			static Delegate GetForceRefresh_ZHandler ()
			{
				if (cb_forceRefresh_Z == null)
					cb_forceRefresh_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ForceRefresh_Z);
				return cb_forceRefresh_Z;
			}

			static IntPtr n_ForceRefresh_Z (IntPtr jnienv, IntPtr native__this, bool forceRefresh)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ForceRefresh (forceRefresh));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters.Builder']/method[@name='forceRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("forceRefresh", "(Z)Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;", "GetForceRefresh_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder ForceRefresh (bool forceRefresh)
			{
				const string __id = "forceRefresh.(Z)Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (forceRefresh);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_self;
#pragma warning disable 0169
			static Delegate GetSelfHandler ()
			{
				if (cb_self == null)
					cb_self = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Self);
				return cb_self;
			}

			static IntPtr n_Self (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Self ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;", "GetSelfHandler")]
			public override unsafe global::Java.Lang.Object Self ()
			{
				const string __id = "self.()Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
#pragma warning disable 0169
			static Delegate GetWithCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler ()
			{
				if (cb_withCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ == null)
					cb_withCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_);
				return cb_withCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_;
			}

			static IntPtr n_WithCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authenticationCallback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authenticationCallback = (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (native_authenticationCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCallback (authenticationCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters.Builder']/method[@name='withCallback' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.SilentAuthenticationCallback']]"
			[Register ("withCallback", "(Lcom/microsoft/identity/client/SilentAuthenticationCallback;)Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;", "GetWithCallback_Lcom_microsoft_identity_client_SilentAuthenticationCallback_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder WithCallback (global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback authenticationCallback)
			{
				const string __id = "withCallback.(Lcom/microsoft/identity/client/SilentAuthenticationCallback;)Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((authenticationCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (authenticationCallback);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AcquireTokenSilentParameters", typeof (AcquireTokenSilentParameters));

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

		protected AcquireTokenSilentParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters']/constructor[@name='AcquireTokenSilentParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenSilentParameters.Builder']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;)V", "")]
		public unsafe AcquireTokenSilentParameters (global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters.Builder builder) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/client/AcquireTokenSilentParameters$Builder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/microsoft/identity/client/SilentAuthenticationCallback;", "GetGetCallbackHandler")]
			get {
				const string __id = "getCallback.()Lcom/microsoft/identity/client/SilentAuthenticationCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ISilentAuthenticationCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getForceRefresh;
#pragma warning disable 0169
		static Delegate GetGetForceRefreshHandler ()
		{
			if (cb_getForceRefresh == null)
				cb_getForceRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetForceRefresh);
			return cb_getForceRefresh;
		}

		static bool n_GetForceRefresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForceRefresh;
		}
#pragma warning restore 0169

		static Delegate cb_setForceRefresh_Z;
#pragma warning disable 0169
		static Delegate GetSetForceRefresh_ZHandler ()
		{
			if (cb_setForceRefresh_Z == null)
				cb_setForceRefresh_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetForceRefresh_Z);
			return cb_setForceRefresh_Z;
		}

		static void n_SetForceRefresh_Z (IntPtr jnienv, IntPtr native__this, bool forceRefresh)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceRefresh = forceRefresh;
		}
#pragma warning restore 0169

		public virtual unsafe bool ForceRefresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters']/method[@name='getForceRefresh' and count(parameter)=0]"
			[Register ("getForceRefresh", "()Z", "GetGetForceRefreshHandler")]
			get {
				const string __id = "getForceRefresh.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenSilentParameters']/method[@name='setForceRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForceRefresh", "(Z)V", "GetSetForceRefresh_ZHandler")]
			set {
				const string __id = "setForceRefresh.(Z)V";
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
