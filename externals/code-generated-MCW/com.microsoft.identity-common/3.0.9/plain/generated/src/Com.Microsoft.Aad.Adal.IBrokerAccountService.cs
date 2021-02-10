using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Aad.Adal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']"
	[global::Android.Runtime.Register ("com/microsoft/aad/adal/IBrokerAccountService$Default", DoNotGenerateAcw=true)]
	public partial class BrokerAccountServiceDefault : global::Java.Lang.Object, global::Com.Microsoft.Aad.Adal.IBrokerAccountService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/aad/adal/IBrokerAccountService$Default", typeof (BrokerAccountServiceDefault));

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

		protected BrokerAccountServiceDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/constructor[@name='IBrokerAccountService.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerAccountServiceDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getBrokerUsers;
#pragma warning disable 0169
		static Delegate GetGetBrokerUsersHandler ()
		{
			if (cb_getBrokerUsers == null)
				cb_getBrokerUsers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBrokerUsers);
			return cb_getBrokerUsers;
		}

		static IntPtr n_GetBrokerUsers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BrokerUsers);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle BrokerUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/method[@name='getBrokerUsers' and count(parameter)=0]"
			[Register ("getBrokerUsers", "()Landroid/os/Bundle;", "GetGetBrokerUsersHandler")]
			get {
				const string __id = "getBrokerUsers.()Landroid/os/Bundle;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntentForInteractiveRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
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

		static Delegate cb_acquireTokenSilently_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilently_Ljava_util_Map_Handler ()
		{
			if (cb_acquireTokenSilently_Ljava_util_Map_ == null)
				cb_acquireTokenSilently_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilently_Ljava_util_Map_);
			return cb_acquireTokenSilently_Ljava_util_Map_;
		}

		static IntPtr n_AcquireTokenSilently_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestParameters = global::Android.Runtime.JavaDictionary.FromJniHandle (native_requestParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilently (requestParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("acquireTokenSilently", "(Ljava/util/Map;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Ljava_util_Map_Handler")]
		public virtual unsafe global::Android.OS.Bundle AcquireTokenSilently (global::System.Collections.IDictionary requestParameters)
		{
			const string __id = "acquireTokenSilently.(Ljava/util/Map;)Landroid/os/Bundle;";
			IntPtr native_requestParameters = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (requestParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestParameters);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestParameters);
				global::System.GC.KeepAlive (requestParameters);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_getInactiveBrokerKey_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler ()
		{
			if (cb_getInactiveBrokerKey_Landroid_os_Bundle_ == null)
				cb_getInactiveBrokerKey_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetInactiveBrokerKey_Landroid_os_Bundle_);
			return cb_getInactiveBrokerKey_Landroid_os_Bundle_;
		}

		static IntPtr n_GetInactiveBrokerKey_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInactiveBrokerKey (bundle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/method[@name='getInactiveBrokerKey' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getInactiveBrokerKey", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetInactiveBrokerKey (global::Android.OS.Bundle bundle)
		{
			const string __id = "getInactiveBrokerKey.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_removeAccounts;
#pragma warning disable 0169
		static Delegate GetRemoveAccountsHandler ()
		{
			if (cb_removeAccounts == null)
				cb_removeAccounts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAccounts);
			return cb_removeAccounts;
		}

		static void n_RemoveAccounts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccounts ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Default']/method[@name='removeAccounts' and count(parameter)=0]"
		[Register ("removeAccounts", "()V", "GetRemoveAccountsHandler")]
		public virtual unsafe void RemoveAccounts ()
		{
			const string __id = "removeAccounts.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']"
	[global::Android.Runtime.Register ("com/microsoft/aad/adal/IBrokerAccountService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class BrokerAccountServiceStub : global::Android.OS.Binder, global::Com.Microsoft.Aad.Adal.IBrokerAccountService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/aad/adal/IBrokerAccountService$Stub", typeof (BrokerAccountServiceStub));

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

		protected BrokerAccountServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/constructor[@name='IBrokerAccountService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerAccountServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Microsoft.Aad.Adal.IBrokerAccountService DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/microsoft/aad/adal/IBrokerAccountService;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/microsoft/aad/adal/IBrokerAccountService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/microsoft/aad/adal/IBrokerAccountService;", "")]
		public static unsafe global::Com.Microsoft.Aad.Adal.IBrokerAccountService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/microsoft/aad/adal/IBrokerAccountService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.microsoft.aad.adal.IBrokerAccountService']]"
		[Register ("setDefaultImpl", "(Lcom/microsoft/aad/adal/IBrokerAccountService;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Microsoft.Aad.Adal.IBrokerAccountService impl)
		{
			const string __id = "setDefaultImpl.(Lcom/microsoft/aad/adal/IBrokerAccountService;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_acquireTokenSilently_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilently_Ljava_util_Map_Handler ()
		{
			if (cb_acquireTokenSilently_Ljava_util_Map_ == null)
				cb_acquireTokenSilently_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilently_Ljava_util_Map_);
			return cb_acquireTokenSilently_Ljava_util_Map_;
		}

		static IntPtr n_AcquireTokenSilently_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilently (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("acquireTokenSilently", "(Ljava/util/Map;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Ljava_util_Map_Handler")]
		public abstract global::Android.OS.Bundle AcquireTokenSilently (global::System.Collections.IDictionary p0);

		static Delegate cb_getInactiveBrokerKey_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler ()
		{
			if (cb_getInactiveBrokerKey_Landroid_os_Bundle_ == null)
				cb_getInactiveBrokerKey_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetInactiveBrokerKey_Landroid_os_Bundle_);
			return cb_getInactiveBrokerKey_Landroid_os_Bundle_;
		}

		static IntPtr n_GetInactiveBrokerKey_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInactiveBrokerKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='getInactiveBrokerKey' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getInactiveBrokerKey", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetInactiveBrokerKey (global::Android.OS.Bundle p0);

		static Delegate cb_removeAccounts;
#pragma warning disable 0169
		static Delegate GetRemoveAccountsHandler ()
		{
			if (cb_removeAccounts == null)
				cb_removeAccounts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAccounts);
			return cb_removeAccounts;
		}

		static void n_RemoveAccounts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccounts ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='removeAccounts' and count(parameter)=0]"
		[Register ("removeAccounts", "()V", "GetRemoveAccountsHandler")]
		public abstract void RemoveAccounts ();

		static Delegate cb_getBrokerUsers;
#pragma warning disable 0169
		static Delegate GetGetBrokerUsersHandler ()
		{
			if (cb_getBrokerUsers == null)
				cb_getBrokerUsers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBrokerUsers);
			return cb_getBrokerUsers;
		}

		static IntPtr n_GetBrokerUsers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BrokerUsers);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.Bundle BrokerUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='getBrokerUsers' and count(parameter)=0]"
			[Register ("getBrokerUsers", "()Landroid/os/Bundle;", "GetGetBrokerUsersHandler")]
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.BrokerAccountServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntentForInteractiveRequest);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
			[Register ("getIntentForInteractiveRequest", "()Landroid/content/Intent;", "GetGetIntentForInteractiveRequestHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/aad/adal/IBrokerAccountService$Stub", DoNotGenerateAcw=true)]
	internal partial class BrokerAccountServiceStubInvoker : BrokerAccountServiceStub {
		public BrokerAccountServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/aad/adal/IBrokerAccountService$Stub", typeof (BrokerAccountServiceStubInvoker));

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

		public override unsafe global::Android.OS.Bundle BrokerUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='getBrokerUsers' and count(parameter)=0]"
			[Register ("getBrokerUsers", "()Landroid/os/Bundle;", "GetGetBrokerUsersHandler")]
			get {
				const string __id = "getBrokerUsers.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/class[@name='IBrokerAccountService.Stub']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("acquireTokenSilently", "(Ljava/util/Map;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Ljava_util_Map_Handler")]
		public override unsafe global::Android.OS.Bundle AcquireTokenSilently (global::System.Collections.IDictionary p0)
		{
			const string __id = "acquireTokenSilently.(Ljava/util/Map;)Landroid/os/Bundle;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='getInactiveBrokerKey' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getInactiveBrokerKey", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetInactiveBrokerKey (global::Android.OS.Bundle p0)
		{
			const string __id = "getInactiveBrokerKey.(Landroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='removeAccounts' and count(parameter)=0]"
		[Register ("removeAccounts", "()V", "GetRemoveAccountsHandler")]
		public override unsafe void RemoveAccounts ()
		{
			const string __id = "removeAccounts.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']"
	[Register ("com/microsoft/aad/adal/IBrokerAccountService", "", "Com.Microsoft.Aad.Adal.IBrokerAccountServiceInvoker")]
	public partial interface IBrokerAccountService : global::Android.OS.IInterface {
		global::Android.OS.Bundle BrokerUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='getBrokerUsers' and count(parameter)=0]"
			[Register ("getBrokerUsers", "()Landroid/os/Bundle;", "GetGetBrokerUsersHandler:Com.Microsoft.Aad.Adal.IBrokerAccountServiceInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Android.Content.Intent IntentForInteractiveRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='getIntentForInteractiveRequest' and count(parameter)=0]"
			[Register ("getIntentForInteractiveRequest", "()Landroid/content/Intent;", "GetGetIntentForInteractiveRequestHandler:Com.Microsoft.Aad.Adal.IBrokerAccountServiceInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='acquireTokenSilently' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("acquireTokenSilently", "(Ljava/util/Map;)Landroid/os/Bundle;", "GetAcquireTokenSilently_Ljava_util_Map_Handler:Com.Microsoft.Aad.Adal.IBrokerAccountServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle AcquireTokenSilently (global::System.Collections.IDictionary p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='getInactiveBrokerKey' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getInactiveBrokerKey", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler:Com.Microsoft.Aad.Adal.IBrokerAccountServiceInvoker, Microsoft.Identity.Common")]
		global::Android.OS.Bundle GetInactiveBrokerKey (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.aad.adal']/interface[@name='IBrokerAccountService']/method[@name='removeAccounts' and count(parameter)=0]"
		[Register ("removeAccounts", "()V", "GetRemoveAccountsHandler:Com.Microsoft.Aad.Adal.IBrokerAccountServiceInvoker, Microsoft.Identity.Common")]
		void RemoveAccounts ();

	}

	[global::Android.Runtime.Register ("com/microsoft/aad/adal/IBrokerAccountService", DoNotGenerateAcw=true)]
	internal partial class IBrokerAccountServiceInvoker : global::Java.Lang.Object, IBrokerAccountService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/aad/adal/IBrokerAccountService", typeof (IBrokerAccountServiceInvoker));

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

		public static IBrokerAccountService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBrokerAccountService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.aad.adal.IBrokerAccountService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBrokerAccountServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBrokerUsers;
#pragma warning disable 0169
		static Delegate GetGetBrokerUsersHandler ()
		{
			if (cb_getBrokerUsers == null)
				cb_getBrokerUsers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBrokerUsers);
			return cb_getBrokerUsers;
		}

		static IntPtr n_GetBrokerUsers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BrokerUsers);
		}
#pragma warning restore 0169

		IntPtr id_getBrokerUsers;
		public unsafe global::Android.OS.Bundle BrokerUsers {
			get {
				if (id_getBrokerUsers == IntPtr.Zero)
					id_getBrokerUsers = JNIEnv.GetMethodID (class_ref, "getBrokerUsers", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrokerUsers), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_acquireTokenSilently_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAcquireTokenSilently_Ljava_util_Map_Handler ()
		{
			if (cb_acquireTokenSilently_Ljava_util_Map_ == null)
				cb_acquireTokenSilently_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireTokenSilently_Ljava_util_Map_);
			return cb_acquireTokenSilently_Ljava_util_Map_;
		}

		static IntPtr n_AcquireTokenSilently_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireTokenSilently (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireTokenSilently_Ljava_util_Map_;
		public unsafe global::Android.OS.Bundle AcquireTokenSilently (global::System.Collections.IDictionary p0)
		{
			if (id_acquireTokenSilently_Ljava_util_Map_ == IntPtr.Zero)
				id_acquireTokenSilently_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "acquireTokenSilently", "(Ljava/util/Map;)Landroid/os/Bundle;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireTokenSilently_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInactiveBrokerKey_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetInactiveBrokerKey_Landroid_os_Bundle_Handler ()
		{
			if (cb_getInactiveBrokerKey_Landroid_os_Bundle_ == null)
				cb_getInactiveBrokerKey_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetInactiveBrokerKey_Landroid_os_Bundle_);
			return cb_getInactiveBrokerKey_Landroid_os_Bundle_;
		}

		static IntPtr n_GetInactiveBrokerKey_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInactiveBrokerKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInactiveBrokerKey_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetInactiveBrokerKey (global::Android.OS.Bundle p0)
		{
			if (id_getInactiveBrokerKey_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getInactiveBrokerKey_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getInactiveBrokerKey", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInactiveBrokerKey_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_removeAccounts;
#pragma warning disable 0169
		static Delegate GetRemoveAccountsHandler ()
		{
			if (cb_removeAccounts == null)
				cb_removeAccounts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAccounts);
			return cb_removeAccounts;
		}

		static void n_RemoveAccounts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccounts ();
		}
#pragma warning restore 0169

		IntPtr id_removeAccounts;
		public unsafe void RemoveAccounts ()
		{
			if (id_removeAccounts == IntPtr.Zero)
				id_removeAccounts = JNIEnv.GetMethodID (class_ref, "removeAccounts", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAccounts);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Aad.Adal.IBrokerAccountService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
