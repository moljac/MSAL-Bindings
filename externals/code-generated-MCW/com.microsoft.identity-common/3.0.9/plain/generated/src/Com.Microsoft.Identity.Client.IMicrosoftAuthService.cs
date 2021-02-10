using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMicrosoftAuthService$Default", DoNotGenerateAcw=true)]
	public partial class MicrosoftAuthServiceDefault : global::Java.Lang.Object, global::Com.Microsoft.Identity.Client.IMicrosoftAuthService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMicrosoftAuthService$Default", typeof (MicrosoftAuthServiceDefault));

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

		protected MicrosoftAuthServiceDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/constructor[@name='IMicrosoftAuthService.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MicrosoftAuthServiceDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDeviceMode;
#pragma warning disable 0169
		static Delegate GetGetDeviceModeHandler ()
		{
			if (cb_getDeviceMode == null)
				cb_getDeviceMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceMode);
			return cb_getDeviceMode;
		}

		static IntPtr n_GetDeviceMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle DeviceMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='getDeviceMode' and count(parameter)=0]"
			[Register ("getDeviceMode", "()Landroid/os/Bundle;", "GetGetDeviceModeHandler")]
			get {
				const string __id = "getDeviceMode.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIntentForInteractiveRequest;
#pragma warning disable 0169
		static Delegate GetGetIntentForInteractiveRequestHandler ()
		{
			if (cb_getIntentForInteractiveRequest == null)
				cb_getIntentForInteractiveRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIntentForInteractiveRequest);
			return cb_getIntentForInteractiveRequest;
		}

		static IntPtr n_GetIntentForInteractiveRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntentForInteractiveRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
			[Register ("getIntentForInteractiveRequest", "()Landroid/content/Intent;", "GetGetIntentForInteractiveRequestHandler")]
			get {
				const string __id = "getIntentForInteractiveRequest.()Landroid/content/Intent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquireTokenSilently_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilently_Landroid_os_Bundle_Handler ()
		{
			if (cb_acquireTokenSilently_Landroid_os_Bundle_ == null)
				cb_acquireTokenSilently_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilently_Landroid_os_Bundle_);
			return cb_acquireTokenSilently_Landroid_os_Bundle_;
		}

		static IntPtr n_AcquireTokenSilently_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestBundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestBundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_requestBundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilently (requestBundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("acquireTokenSilently", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle AcquireTokenSilently (global::Android.OS.Bundle requestBundle)
		{
			const string __id = "acquireTokenSilently.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestBundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestBundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (requestBundle);
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_generateSignedHttpRequest_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler ()
		{
			if (cb_generateSignedHttpRequest_Landroid_os_Bundle_ == null)
				cb_generateSignedHttpRequest_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateSignedHttpRequest_Landroid_os_Bundle_);
			return cb_generateSignedHttpRequest_Landroid_os_Bundle_;
		}

		static IntPtr n_GenerateSignedHttpRequest_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateSignedHttpRequest (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("generateSignedHttpRequest", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle GenerateSignedHttpRequest (global::Android.OS.Bundle bundle)
		{
			const string __id = "generateSignedHttpRequest.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_getAccounts_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Landroid_os_Bundle_Handler ()
		{
			if (cb_getAccounts_Landroid_os_Bundle_ == null)
				cb_getAccounts_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccounts_Landroid_os_Bundle_);
			return cb_getAccounts_Landroid_os_Bundle_;
		}

		static IntPtr n_GetAccounts_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccounts (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getAccounts", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetAccounts_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetAccounts (global::Android.OS.Bundle bundle)
		{
			const string __id = "getAccounts.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_getCurrentAccount_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccount_Landroid_os_Bundle_Handler ()
		{
			if (cb_getCurrentAccount_Landroid_os_Bundle_ == null)
				cb_getCurrentAccount_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCurrentAccount_Landroid_os_Bundle_);
			return cb_getCurrentAccount_Landroid_os_Bundle_;
		}

		static IntPtr n_GetCurrentAccount_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCurrentAccount (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getCurrentAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetCurrentAccount_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetCurrentAccount (global::Android.OS.Bundle bundle)
		{
			const string __id = "getCurrentAccount.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_hello_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetHello_Landroid_os_Bundle_Handler ()
		{
			if (cb_hello_Landroid_os_Bundle_ == null)
				cb_hello_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Hello_Landroid_os_Bundle_);
			return cb_hello_Landroid_os_Bundle_;
		}

		static IntPtr n_Hello_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hello (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("hello", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetHello_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle Hello (global::Android.OS.Bundle bundle)
		{
			const string __id = "hello.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_removeAccount_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Landroid_os_Bundle_Handler ()
		{
			if (cb_removeAccount_Landroid_os_Bundle_ == null)
				cb_removeAccount_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveAccount_Landroid_os_Bundle_);
			return cb_removeAccount_Landroid_os_Bundle_;
		}

		static IntPtr n_RemoveAccount_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccount (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccount_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle RemoveAccount (global::Android.OS.Bundle bundle)
		{
			const string __id = "removeAccount.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_removeAccountFromSharedDevice_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler ()
		{
			if (cb_removeAccountFromSharedDevice_Landroid_os_Bundle_ == null)
				cb_removeAccountFromSharedDevice_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveAccountFromSharedDevice_Landroid_os_Bundle_);
			return cb_removeAccountFromSharedDevice_Landroid_os_Bundle_;
		}

		static IntPtr n_RemoveAccountFromSharedDevice_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccountFromSharedDevice (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Default']/method[@name='removeAccountFromSharedDevice' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccountFromSharedDevice", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle RemoveAccountFromSharedDevice (global::Android.OS.Bundle bundle)
		{
			const string __id = "removeAccountFromSharedDevice.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMicrosoftAuthService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class MicrosoftAuthServiceStub : global::Android.OS.Binder, global::Com.Microsoft.Identity.Client.IMicrosoftAuthService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMicrosoftAuthService$Stub", typeof (MicrosoftAuthServiceStub));

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

		protected MicrosoftAuthServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/constructor[@name='IMicrosoftAuthService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MicrosoftAuthServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Microsoft.Identity.Client.IMicrosoftAuthService DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/microsoft/identity/client/IMicrosoftAuthService;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/microsoft/identity/client/IMicrosoftAuthService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/microsoft/identity/client/IMicrosoftAuthService;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.IMicrosoftAuthService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/microsoft/identity/client/IMicrosoftAuthService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLI_Z) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (reply);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.IMicrosoftAuthService']]"
		[Register ("setDefaultImpl", "(Lcom/microsoft/identity/client/IMicrosoftAuthService;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Microsoft.Identity.Client.IMicrosoftAuthService impl)
		{
			const string __id = "setDefaultImpl.(Lcom/microsoft/identity/client/IMicrosoftAuthService;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_acquireTokenSilently_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilently_Landroid_os_Bundle_Handler ()
		{
			if (cb_acquireTokenSilently_Landroid_os_Bundle_ == null)
				cb_acquireTokenSilently_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilently_Landroid_os_Bundle_);
			return cb_acquireTokenSilently_Landroid_os_Bundle_;
		}

		static IntPtr n_AcquireTokenSilently_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilently (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("acquireTokenSilently", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle AcquireTokenSilently (global::Android.OS.Bundle p0);

		static Delegate cb_generateSignedHttpRequest_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler ()
		{
			if (cb_generateSignedHttpRequest_Landroid_os_Bundle_ == null)
				cb_generateSignedHttpRequest_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateSignedHttpRequest_Landroid_os_Bundle_);
			return cb_generateSignedHttpRequest_Landroid_os_Bundle_;
		}

		static IntPtr n_GenerateSignedHttpRequest_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateSignedHttpRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("generateSignedHttpRequest", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GenerateSignedHttpRequest (global::Android.OS.Bundle p0);

		static Delegate cb_getAccounts_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Landroid_os_Bundle_Handler ()
		{
			if (cb_getAccounts_Landroid_os_Bundle_ == null)
				cb_getAccounts_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccounts_Landroid_os_Bundle_);
			return cb_getAccounts_Landroid_os_Bundle_;
		}

		static IntPtr n_GetAccounts_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccounts (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getAccounts", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetAccounts_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetAccounts (global::Android.OS.Bundle p0);

		static Delegate cb_getCurrentAccount_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccount_Landroid_os_Bundle_Handler ()
		{
			if (cb_getCurrentAccount_Landroid_os_Bundle_ == null)
				cb_getCurrentAccount_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCurrentAccount_Landroid_os_Bundle_);
			return cb_getCurrentAccount_Landroid_os_Bundle_;
		}

		static IntPtr n_GetCurrentAccount_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCurrentAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getCurrentAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetCurrentAccount_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetCurrentAccount (global::Android.OS.Bundle p0);

		static Delegate cb_hello_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetHello_Landroid_os_Bundle_Handler ()
		{
			if (cb_hello_Landroid_os_Bundle_ == null)
				cb_hello_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Hello_Landroid_os_Bundle_);
			return cb_hello_Landroid_os_Bundle_;
		}

		static IntPtr n_Hello_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hello (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("hello", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetHello_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle Hello (global::Android.OS.Bundle p0);

		static Delegate cb_removeAccount_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Landroid_os_Bundle_Handler ()
		{
			if (cb_removeAccount_Landroid_os_Bundle_ == null)
				cb_removeAccount_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveAccount_Landroid_os_Bundle_);
			return cb_removeAccount_Landroid_os_Bundle_;
		}

		static IntPtr n_RemoveAccount_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccount_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle RemoveAccount (global::Android.OS.Bundle p0);

		static Delegate cb_removeAccountFromSharedDevice_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler ()
		{
			if (cb_removeAccountFromSharedDevice_Landroid_os_Bundle_ == null)
				cb_removeAccountFromSharedDevice_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveAccountFromSharedDevice_Landroid_os_Bundle_);
			return cb_removeAccountFromSharedDevice_Landroid_os_Bundle_;
		}

		static IntPtr n_RemoveAccountFromSharedDevice_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccountFromSharedDevice (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='removeAccountFromSharedDevice' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccountFromSharedDevice", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle RemoveAccountFromSharedDevice (global::Android.OS.Bundle p0);

		static Delegate cb_getDeviceMode;
#pragma warning disable 0169
		static Delegate GetGetDeviceModeHandler ()
		{
			if (cb_getDeviceMode == null)
				cb_getDeviceMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceMode);
			return cb_getDeviceMode;
		}

		static IntPtr n_GetDeviceMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceMode);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.Bundle DeviceMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='getDeviceMode' and count(parameter)=0]"
			[Register ("getDeviceMode", "()Landroid/os/Bundle;", "GetGetDeviceModeHandler")]
			get; 
		}

		static Delegate cb_getIntentForInteractiveRequest;
#pragma warning disable 0169
		static Delegate GetGetIntentForInteractiveRequestHandler ()
		{
			if (cb_getIntentForInteractiveRequest == null)
				cb_getIntentForInteractiveRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIntentForInteractiveRequest);
			return cb_getIntentForInteractiveRequest;
		}

		static IntPtr n_GetIntentForInteractiveRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntentForInteractiveRequest);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
			[Register ("getIntentForInteractiveRequest", "()Landroid/content/Intent;", "GetGetIntentForInteractiveRequestHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMicrosoftAuthService$Stub", DoNotGenerateAcw=true)]
	internal partial class MicrosoftAuthServiceStubInvoker : MicrosoftAuthServiceStub {
		public MicrosoftAuthServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMicrosoftAuthService$Stub", typeof (MicrosoftAuthServiceStubInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Android.OS.Bundle DeviceMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='getDeviceMode' and count(parameter)=0]"
			[Register ("getDeviceMode", "()Landroid/os/Bundle;", "GetGetDeviceModeHandler")]
			get {
				const string __id = "getDeviceMode.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='IMicrosoftAuthService.Stub']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
			[Register ("getIntentForInteractiveRequest", "()Landroid/content/Intent;", "GetGetIntentForInteractiveRequestHandler")]
			get {
				const string __id = "getIntentForInteractiveRequest.()Landroid/content/Intent;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("acquireTokenSilently", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle AcquireTokenSilently (global::Android.OS.Bundle p0)
		{
			const string __id = "acquireTokenSilently.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("generateSignedHttpRequest", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GenerateSignedHttpRequest (global::Android.OS.Bundle p0)
		{
			const string __id = "generateSignedHttpRequest.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getAccounts", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetAccounts_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetAccounts (global::Android.OS.Bundle p0)
		{
			const string __id = "getAccounts.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getCurrentAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetCurrentAccount_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetCurrentAccount (global::Android.OS.Bundle p0)
		{
			const string __id = "getCurrentAccount.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("hello", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetHello_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle Hello (global::Android.OS.Bundle p0)
		{
			const string __id = "hello.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccount_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle RemoveAccount (global::Android.OS.Bundle p0)
		{
			const string __id = "removeAccount.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='removeAccountFromSharedDevice' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccountFromSharedDevice", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle RemoveAccountFromSharedDevice (global::Android.OS.Bundle p0)
		{
			const string __id = "removeAccountFromSharedDevice.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']"
	[Register ("com/microsoft/identity/client/IMicrosoftAuthService", "", "Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker")]
	public partial interface IMicrosoftAuthService : global::Android.OS.IInterface {
		global::Android.OS.Bundle DeviceMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getDeviceMode' and count(parameter)=0]"
			[Register ("getDeviceMode", "()Landroid/os/Bundle;", "GetGetDeviceModeHandler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
			[Register ("getIntentForInteractiveRequest", "()Landroid/content/Intent;", "GetGetIntentForInteractiveRequestHandler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("acquireTokenSilently", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle AcquireTokenSilently (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='generateSignedHttpRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("generateSignedHttpRequest", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle GenerateSignedHttpRequest (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getAccounts' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getAccounts", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetAccounts_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle GetAccounts (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='getCurrentAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getCurrentAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetCurrentAccount_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle GetCurrentAccount (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("hello", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetHello_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle Hello (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='removeAccount' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccount_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle RemoveAccount (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IMicrosoftAuthService']/method[@name='removeAccountFromSharedDevice' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("removeAccountFromSharedDevice", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler:Com.Microsoft.Identity.Client.IMicrosoftAuthServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle RemoveAccountFromSharedDevice (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IMicrosoftAuthService", DoNotGenerateAcw=true)]
	internal partial class IMicrosoftAuthServiceInvoker : global::Java.Lang.Object, IMicrosoftAuthService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IMicrosoftAuthService", typeof (IMicrosoftAuthServiceInvoker));

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

		public static IMicrosoftAuthService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMicrosoftAuthService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IMicrosoftAuthService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMicrosoftAuthServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeviceMode;
#pragma warning disable 0169
		static Delegate GetGetDeviceModeHandler ()
		{
			if (cb_getDeviceMode == null)
				cb_getDeviceMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceMode);
			return cb_getDeviceMode;
		}

		static IntPtr n_GetDeviceMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceMode);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceMode;
		public unsafe global::Android.OS.Bundle DeviceMode {
			get {
				if (id_getDeviceMode == IntPtr.Zero)
					id_getDeviceMode = JNIEnv.GetMethodID (class_ref, "getDeviceMode", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceMode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIntentForInteractiveRequest;
#pragma warning disable 0169
		static Delegate GetGetIntentForInteractiveRequestHandler ()
		{
			if (cb_getIntentForInteractiveRequest == null)
				cb_getIntentForInteractiveRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIntentForInteractiveRequest);
			return cb_getIntentForInteractiveRequest;
		}

		static IntPtr n_GetIntentForInteractiveRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntentForInteractiveRequest);
		}
#pragma warning restore 0169

		IntPtr id_getIntentForInteractiveRequest;
		public unsafe global::Android.Content.Intent IntentForInteractiveRequest {
			get {
				if (id_getIntentForInteractiveRequest == IntPtr.Zero)
					id_getIntentForInteractiveRequest = JNIEnv.GetMethodID (class_ref, "getIntentForInteractiveRequest", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntentForInteractiveRequest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_acquireTokenSilently_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilently_Landroid_os_Bundle_Handler ()
		{
			if (cb_acquireTokenSilently_Landroid_os_Bundle_ == null)
				cb_acquireTokenSilently_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilently_Landroid_os_Bundle_);
			return cb_acquireTokenSilently_Landroid_os_Bundle_;
		}

		static IntPtr n_AcquireTokenSilently_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilently (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilently_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle AcquireTokenSilently (global::Android.OS.Bundle p0)
		{
			if (id_acquireTokenSilently_Landroid_os_Bundle_ == IntPtr.Zero)
				id_acquireTokenSilently_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilently", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilently_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_generateSignedHttpRequest_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGenerateSignedHttpRequest_Landroid_os_Bundle_Handler ()
		{
			if (cb_generateSignedHttpRequest_Landroid_os_Bundle_ == null)
				cb_generateSignedHttpRequest_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GenerateSignedHttpRequest_Landroid_os_Bundle_);
			return cb_generateSignedHttpRequest_Landroid_os_Bundle_;
		}

		static IntPtr n_GenerateSignedHttpRequest_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateSignedHttpRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateSignedHttpRequest_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GenerateSignedHttpRequest (global::Android.OS.Bundle p0)
		{
			if (id_generateSignedHttpRequest_Landroid_os_Bundle_ == IntPtr.Zero)
				id_generateSignedHttpRequest_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "generateSignedHttpRequest", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateSignedHttpRequest_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getAccounts_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAccounts_Landroid_os_Bundle_Handler ()
		{
			if (cb_getAccounts_Landroid_os_Bundle_ == null)
				cb_getAccounts_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccounts_Landroid_os_Bundle_);
			return cb_getAccounts_Landroid_os_Bundle_;
		}

		static IntPtr n_GetAccounts_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccounts (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccounts_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetAccounts (global::Android.OS.Bundle p0)
		{
			if (id_getAccounts_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getAccounts_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getAccounts", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccounts_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getCurrentAccount_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetCurrentAccount_Landroid_os_Bundle_Handler ()
		{
			if (cb_getCurrentAccount_Landroid_os_Bundle_ == null)
				cb_getCurrentAccount_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCurrentAccount_Landroid_os_Bundle_);
			return cb_getCurrentAccount_Landroid_os_Bundle_;
		}

		static IntPtr n_GetCurrentAccount_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCurrentAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAccount_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetCurrentAccount (global::Android.OS.Bundle p0)
		{
			if (id_getCurrentAccount_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getCurrentAccount_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getCurrentAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAccount_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_hello_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetHello_Landroid_os_Bundle_Handler ()
		{
			if (cb_hello_Landroid_os_Bundle_ == null)
				cb_hello_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Hello_Landroid_os_Bundle_);
			return cb_hello_Landroid_os_Bundle_;
		}

		static IntPtr n_Hello_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hello (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hello_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle Hello (global::Android.OS.Bundle p0)
		{
			if (id_hello_Landroid_os_Bundle_ == IntPtr.Zero)
				id_hello_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "hello", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hello_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_removeAccount_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveAccount_Landroid_os_Bundle_Handler ()
		{
			if (cb_removeAccount_Landroid_os_Bundle_ == null)
				cb_removeAccount_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveAccount_Landroid_os_Bundle_);
			return cb_removeAccount_Landroid_os_Bundle_;
		}

		static IntPtr n_RemoveAccount_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAccount_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle RemoveAccount (global::Android.OS.Bundle p0)
		{
			if (id_removeAccount_Landroid_os_Bundle_ == IntPtr.Zero)
				id_removeAccount_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "removeAccount", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeAccount_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_removeAccountFromSharedDevice_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveAccountFromSharedDevice_Landroid_os_Bundle_Handler ()
		{
			if (cb_removeAccountFromSharedDevice_Landroid_os_Bundle_ == null)
				cb_removeAccountFromSharedDevice_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveAccountFromSharedDevice_Landroid_os_Bundle_);
			return cb_removeAccountFromSharedDevice_Landroid_os_Bundle_;
		}

		static IntPtr n_RemoveAccountFromSharedDevice_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAccountFromSharedDevice (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAccountFromSharedDevice_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle RemoveAccountFromSharedDevice (global::Android.OS.Bundle p0)
		{
			if (id_removeAccountFromSharedDevice_Landroid_os_Bundle_ == IntPtr.Zero)
				id_removeAccountFromSharedDevice_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "removeAccountFromSharedDevice", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeAccountFromSharedDevice_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IMicrosoftAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
