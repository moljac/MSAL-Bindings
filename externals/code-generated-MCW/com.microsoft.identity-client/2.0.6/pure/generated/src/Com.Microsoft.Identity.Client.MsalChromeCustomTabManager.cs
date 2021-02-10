using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MsalChromeCustomTabManager']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/MsalChromeCustomTabManager", DoNotGenerateAcw=true)]
	public partial class MsalChromeCustomTabManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/MsalChromeCustomTabManager", typeof (MsalChromeCustomTabManager));

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

		protected MsalChromeCustomTabManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MsalChromeCustomTabManager']/constructor[@name='MsalChromeCustomTabManager' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe MsalChromeCustomTabManager (global::Android.App.Activity activity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_bindCustomTabsService;
#pragma warning disable 0169
		static Delegate GetBindCustomTabsServiceHandler ()
		{
			if (cb_bindCustomTabsService == null)
				cb_bindCustomTabsService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_BindCustomTabsService);
			return cb_bindCustomTabsService;
		}

		static void n_BindCustomTabsService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MsalChromeCustomTabManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BindCustomTabsService ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MsalChromeCustomTabManager']/method[@name='bindCustomTabsService' and count(parameter)=0]"
		[Register ("bindCustomTabsService", "()V", "GetBindCustomTabsServiceHandler")]
		public virtual unsafe void BindCustomTabsService ()
		{
			const string __id = "bindCustomTabsService.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_launchChromeTabOrBrowserForUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLaunchChromeTabOrBrowserForUrl_Ljava_lang_String_Handler ()
		{
			if (cb_launchChromeTabOrBrowserForUrl_Ljava_lang_String_ == null)
				cb_launchChromeTabOrBrowserForUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_LaunchChromeTabOrBrowserForUrl_Ljava_lang_String_);
			return cb_launchChromeTabOrBrowserForUrl_Ljava_lang_String_;
		}

		static void n_LaunchChromeTabOrBrowserForUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MsalChromeCustomTabManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestUrl = JNIEnv.GetString (native_requestUrl, JniHandleOwnership.DoNotTransfer);
			__this.LaunchChromeTabOrBrowserForUrl (requestUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MsalChromeCustomTabManager']/method[@name='launchChromeTabOrBrowserForUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("launchChromeTabOrBrowserForUrl", "(Ljava/lang/String;)V", "GetLaunchChromeTabOrBrowserForUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void LaunchChromeTabOrBrowserForUrl (string requestUrl)
		{
			const string __id = "launchChromeTabOrBrowserForUrl.(Ljava/lang/String;)V";
			IntPtr native_requestUrl = JNIEnv.NewString (requestUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestUrl);
			}
		}

		static Delegate cb_unbindCustomTabsService;
#pragma warning disable 0169
		static Delegate GetUnbindCustomTabsServiceHandler ()
		{
			if (cb_unbindCustomTabsService == null)
				cb_unbindCustomTabsService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnbindCustomTabsService);
			return cb_unbindCustomTabsService;
		}

		static void n_UnbindCustomTabsService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MsalChromeCustomTabManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnbindCustomTabsService ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MsalChromeCustomTabManager']/method[@name='unbindCustomTabsService' and count(parameter)=0]"
		[Register ("unbindCustomTabsService", "()V", "GetUnbindCustomTabsServiceHandler")]
		public virtual unsafe void UnbindCustomTabsService ()
		{
			const string __id = "unbindCustomTabsService.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_verifyChromeTabOrBrowser;
#pragma warning disable 0169
		static Delegate GetVerifyChromeTabOrBrowserHandler ()
		{
			if (cb_verifyChromeTabOrBrowser == null)
				cb_verifyChromeTabOrBrowser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_VerifyChromeTabOrBrowser);
			return cb_verifyChromeTabOrBrowser;
		}

		static void n_VerifyChromeTabOrBrowser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.MsalChromeCustomTabManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerifyChromeTabOrBrowser ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='MsalChromeCustomTabManager']/method[@name='verifyChromeTabOrBrowser' and count(parameter)=0]"
		[Register ("verifyChromeTabOrBrowser", "()V", "GetVerifyChromeTabOrBrowserHandler")]
		protected virtual unsafe void VerifyChromeTabOrBrowser ()
		{
			const string __id = "verifyChromeTabOrBrowser.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
