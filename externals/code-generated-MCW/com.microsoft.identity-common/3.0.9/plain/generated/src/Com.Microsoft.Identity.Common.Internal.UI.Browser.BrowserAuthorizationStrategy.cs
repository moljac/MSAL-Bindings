using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Browser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserAuthorizationStrategy']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/browser/BrowserAuthorizationStrategy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericOAuth2Strategy extends com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy", "GenericAuthorizationRequest extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest"})]
	public partial class BrowserAuthorizationStrategy : global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/browser/BrowserAuthorizationStrategy", typeof (BrowserAuthorizationStrategy));

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

		protected BrowserAuthorizationStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserAuthorizationStrategy']/constructor[@name='BrowserAuthorizationStrategy' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='androidx.fragment.app.Fragment'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/app/Activity;Landroidx/fragment/app/Fragment;Z)V", "")]
		public unsafe BrowserAuthorizationStrategy (global::Android.Content.Context applicationContext, global::Android.App.Activity activity, global::AndroidX.Fragment.App.Fragment fragment, bool isRequestFromBroker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/app/Activity;Landroidx/fragment/app/Fragment;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				__args [1] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [2] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
				__args [3] = new JniArgumentValue (isRequestFromBroker);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (applicationContext);
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (fragment);
			}
		}

		static Delegate cb_completeAuthorization_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCompleteAuthorization_IILandroid_content_Intent_Handler ()
		{
			if (cb_completeAuthorization_IILandroid_content_Intent_ == null)
				cb_completeAuthorization_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_CompleteAuthorization_IILandroid_content_Intent_);
			return cb_completeAuthorization_IILandroid_content_Intent_;
		}

		static void n_CompleteAuthorization_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int requestCode, int resultCode, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserAuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.CompleteAuthorization (requestCode, resultCode, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserAuthorizationStrategy']/method[@name='completeAuthorization' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeAuthorization", "(IILandroid/content/Intent;)V", "GetCompleteAuthorization_IILandroid_content_Intent_Handler")]
		public override unsafe void CompleteAuthorization (int requestCode, int resultCode, global::Android.Content.Intent data)
		{
			const string __id = "completeAuthorization.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestCode);
				__args [1] = new JniArgumentValue (resultCode);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserAuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserAuthorizationStrategy']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_;
#pragma warning disable 0169
		static Delegate GetRequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Handler ()
		{
			if (cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_ == null)
				cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_RequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_);
			return cb_requestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_;
		}

		static IntPtr n_RequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorizationRequest, IntPtr native_oAuth2Strategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserAuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorizationRequest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_authorizationRequest, JniHandleOwnership.DoNotTransfer);
			var oAuth2Strategy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_oAuth2Strategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestAuthorization (authorizationRequest, oAuth2Strategy));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserAuthorizationStrategy']/method[@name='requestAuthorization' and count(parameter)=2 and parameter[1][@type='GenericAuthorizationRequest'] and parameter[2][@type='GenericOAuth2Strategy']]"
		[Register ("requestAuthorization", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;)Ljava/util/concurrent/Future;", "GetRequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Handler")]
		public override unsafe global::Java.Util.Concurrent.IFuture RequestAuthorization (global::Java.Lang.Object authorizationRequest, global::Java.Lang.Object oAuth2Strategy)
		{
			const string __id = "requestAuthorization.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;)Ljava/util/concurrent/Future;";
			IntPtr native_authorizationRequest = JNIEnv.ToLocalJniHandle (authorizationRequest);
			IntPtr native_oAuth2Strategy = JNIEnv.ToLocalJniHandle (oAuth2Strategy);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_authorizationRequest);
				__args [1] = new JniArgumentValue (native_oAuth2Strategy);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authorizationRequest);
				JNIEnv.DeleteLocalRef (native_oAuth2Strategy);
				global::System.GC.KeepAlive (authorizationRequest);
				global::System.GC.KeepAlive (oAuth2Strategy);
			}
		}

		static Delegate cb_setBrowserSafeList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetBrowserSafeList_Ljava_util_List_Handler ()
		{
			if (cb_setBrowserSafeList_Ljava_util_List_ == null)
				cb_setBrowserSafeList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBrowserSafeList_Ljava_util_List_);
			return cb_setBrowserSafeList_Ljava_util_List_;
		}

		static void n_SetBrowserSafeList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_browserSafeList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserAuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var browserSafeList = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.FromJniHandle (native_browserSafeList, JniHandleOwnership.DoNotTransfer);
			__this.SetBrowserSafeList (browserSafeList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='BrowserAuthorizationStrategy']/method[@name='setBrowserSafeList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.common.internal.ui.browser.BrowserDescriptor&gt;']]"
		[Register ("setBrowserSafeList", "(Ljava/util/List;)V", "GetSetBrowserSafeList_Ljava_util_List_Handler")]
		public virtual unsafe void SetBrowserSafeList (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor> browserSafeList)
		{
			const string __id = "setBrowserSafeList.(Ljava/util/List;)V";
			IntPtr native_browserSafeList = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.BrowserDescriptor>.ToLocalJniHandle (browserSafeList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_browserSafeList);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_browserSafeList);
				global::System.GC.KeepAlive (browserSafeList);
			}
		}

	}
}
