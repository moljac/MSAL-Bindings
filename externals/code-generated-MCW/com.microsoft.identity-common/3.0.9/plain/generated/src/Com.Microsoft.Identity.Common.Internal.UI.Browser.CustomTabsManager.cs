using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Browser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='CustomTabsManager']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/browser/CustomTabsManager", DoNotGenerateAcw=true)]
	public partial class CustomTabsManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/browser/CustomTabsManager", typeof (CustomTabsManager));

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

		protected CustomTabsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='CustomTabsManager']/constructor[@name='CustomTabsManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CustomTabsManager (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.CustomTabsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Browser.CustomTabs.CustomTabsClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='CustomTabsManager']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Landroidx/browser/customtabs/CustomTabsClient;", "GetGetClientHandler")]
			get {
				const string __id = "getClient.()Landroidx/browser/customtabs/CustomTabsClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Browser.CustomTabs.CustomTabsClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomTabsIntent;
#pragma warning disable 0169
		static Delegate GetGetCustomTabsIntentHandler ()
		{
			if (cb_getCustomTabsIntent == null)
				cb_getCustomTabsIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCustomTabsIntent);
			return cb_getCustomTabsIntent;
		}

		static IntPtr n_GetCustomTabsIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.CustomTabsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomTabsIntent);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Browser.CustomTabs.CustomTabsIntent CustomTabsIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='CustomTabsManager']/method[@name='getCustomTabsIntent' and count(parameter)=0]"
			[Register ("getCustomTabsIntent", "()Landroidx/browser/customtabs/CustomTabsIntent;", "GetGetCustomTabsIntentHandler")]
			get {
				const string __id = "getCustomTabsIntent.()Landroidx/browser/customtabs/CustomTabsIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Browser.CustomTabs.CustomTabsIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bind_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBind_Ljava_lang_String_Handler ()
		{
			if (cb_bind_Ljava_lang_String_ == null)
				cb_bind_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Bind_Ljava_lang_String_);
			return cb_bind_Ljava_lang_String_;
		}

		static void n_Bind_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_browserPackage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.CustomTabsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var browserPackage = JNIEnv.GetString (native_browserPackage, JniHandleOwnership.DoNotTransfer);
			__this.Bind (browserPackage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='CustomTabsManager']/method[@name='bind' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bind", "(Ljava/lang/String;)V", "GetBind_Ljava_lang_String_Handler")]
		public virtual unsafe void Bind (string browserPackage)
		{
			const string __id = "bind.(Ljava/lang/String;)V";
			IntPtr native_browserPackage = JNIEnv.NewString (browserPackage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_browserPackage);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_browserPackage);
			}
		}

		static Delegate cb_unbind;
#pragma warning disable 0169
		static Delegate GetUnbindHandler ()
		{
			if (cb_unbind == null)
				cb_unbind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unbind);
			return cb_unbind;
		}

		static void n_Unbind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.CustomTabsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unbind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='CustomTabsManager']/method[@name='unbind' and count(parameter)=0]"
		[Register ("unbind", "()V", "GetUnbindHandler")]
		public virtual unsafe void Unbind ()
		{
			const string __id = "unbind.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
