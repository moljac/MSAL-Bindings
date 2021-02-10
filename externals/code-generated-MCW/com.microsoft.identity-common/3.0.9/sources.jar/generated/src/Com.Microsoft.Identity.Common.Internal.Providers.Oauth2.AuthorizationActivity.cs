using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationActivity']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationActivity", DoNotGenerateAcw=true)]
	public partial class AuthorizationActivity : global::Com.Microsoft.Identity.Common.Internal.UI.DualScreenActivity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationActivity", typeof (AuthorizationActivity));

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

		protected AuthorizationActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationActivity']/constructor[@name='AuthorizationActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizationActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationActivity']/method[@name='createStartIntent' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;'] and parameter[6][@type='com.microsoft.identity.common.internal.ui.AuthorizationAgent'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean']]"
		[Register ("createStartIntent", "(Landroid/content/Context;Landroid/content/Intent;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;ZZ)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateStartIntent (global::Android.Content.Context context, global::Android.Content.Intent authIntent, string requestUrl, string redirectUri, global::System.Collections.Generic.IDictionary<string, string> requestHeaders, global::Com.Microsoft.Identity.Common.Internal.UI.AuthorizationAgent authorizationAgent, bool webViewZoomEnabled, bool webViewZoomControlsEnabled)
		{
			const string __id = "createStartIntent.(Landroid/content/Context;Landroid/content/Intent;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;Lcom/microsoft/identity/common/internal/ui/AuthorizationAgent;ZZ)Landroid/content/Intent;";
			IntPtr native_requestUrl = JNIEnv.NewString (requestUrl);
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			IntPtr native_requestHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((authIntent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authIntent).Handle);
				__args [2] = new JniArgumentValue (native_requestUrl);
				__args [3] = new JniArgumentValue (native_redirectUri);
				__args [4] = new JniArgumentValue (native_requestHeaders);
				__args [5] = new JniArgumentValue ((authorizationAgent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authorizationAgent).Handle);
				__args [6] = new JniArgumentValue (webViewZoomEnabled);
				__args [7] = new JniArgumentValue (webViewZoomControlsEnabled);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestUrl);
				JNIEnv.DeleteLocalRef (native_redirectUri);
				JNIEnv.DeleteLocalRef (native_requestHeaders);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (authIntent);
				global::System.GC.KeepAlive (requestHeaders);
				global::System.GC.KeepAlive (authorizationAgent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationActivity']/method[@name='getAuthorizationFragmentFromStartIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getAuthorizationFragmentFromStartIntent", "(Landroid/content/Intent;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationFragment;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationFragment GetAuthorizationFragmentFromStartIntent (global::Android.Content.Intent intent)
		{
			const string __id = "getAuthorizationFragmentFromStartIntent.(Landroid/content/Intent;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (intent);
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (savedInstanceState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle savedInstanceState)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((savedInstanceState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) savedInstanceState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (savedInstanceState);
			}
		}

	}
}
