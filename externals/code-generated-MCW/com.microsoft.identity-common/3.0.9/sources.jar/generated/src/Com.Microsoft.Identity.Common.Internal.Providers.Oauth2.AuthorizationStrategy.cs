using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"GenericOAuth2Strategy extends com.microsoft.identity.common.internal.providers.oauth2.OAuth2Strategy", "GenericAuthorizationRequest extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest"})]
	public abstract partial class AuthorizationStrategy : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy", typeof (AuthorizationStrategy));

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

		protected AuthorizationStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/constructor[@name='AuthorizationStrategy' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='androidx.fragment.app.Fragment']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/app/Activity;Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe AuthorizationStrategy (global::Android.Content.Context applicationContext, global::Android.App.Activity activity, global::AndroidX.Fragment.App.Fragment fragment) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/app/Activity;Landroidx/fragment/app/Fragment;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				__args [1] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [2] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (applicationContext);
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (fragment);
			}
		}

		static Delegate cb_getApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetApplicationContextHandler ()
		{
			if (cb_getApplicationContext == null)
				cb_getApplicationContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApplicationContext);
			return cb_getApplicationContext;
		}

		static IntPtr n_GetApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				const string __id = "getApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static void n_CompleteAuthorization_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CompleteAuthorization (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/method[@name='completeAuthorization' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeAuthorization", "(IILandroid/content/Intent;)V", "GetCompleteAuthorization_IILandroid_content_Intent_Handler")]
		public abstract void CompleteAuthorization (int p0, int p1, global::Android.Content.Intent p2);

		static Delegate cb_launchIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetLaunchIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_launchIntent_Landroid_content_Intent_ == null)
				cb_launchIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_LaunchIntent_Landroid_content_Intent_);
			return cb_launchIntent_Landroid_content_Intent_;
		}

		static void n_LaunchIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.LaunchIntent (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/method[@name='launchIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("launchIntent", "(Landroid/content/Intent;)V", "GetLaunchIntent_Landroid_content_Intent_Handler")]
		protected virtual unsafe void LaunchIntent (global::Android.Content.Intent intent)
		{
			const string __id = "launchIntent.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (intent);
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

		static IntPtr n_RequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestAuthorization (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/method[@name='requestAuthorization' and count(parameter)=2 and parameter[1][@type='GenericAuthorizationRequest'] and parameter[2][@type='GenericOAuth2Strategy']]"
		[Register ("requestAuthorization", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;)Ljava/util/concurrent/Future;", "GetRequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Handler")]
		public abstract global::Java.Util.Concurrent.IFuture RequestAuthorization (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy", DoNotGenerateAcw=true)]
	internal partial class AuthorizationStrategyInvoker : AuthorizationStrategy {
		public AuthorizationStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationStrategy", typeof (AuthorizationStrategyInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/method[@name='completeAuthorization' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeAuthorization", "(IILandroid/content/Intent;)V", "GetCompleteAuthorization_IILandroid_content_Intent_Handler")]
		public override unsafe void CompleteAuthorization (int p0, int p1, global::Android.Content.Intent p2)
		{
			const string __id = "completeAuthorization.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationStrategy']/method[@name='requestAuthorization' and count(parameter)=2 and parameter[1][@type='GenericAuthorizationRequest'] and parameter[2][@type='GenericOAuth2Strategy']]"
		[Register ("requestAuthorization", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;)Ljava/util/concurrent/Future;", "GetRequestAuthorization_Lcom_microsoft_identity_common_internal_providers_oauth2_AuthorizationRequest_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2Strategy_Handler")]
		public override unsafe global::Java.Util.Concurrent.IFuture RequestAuthorization (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "requestAuthorization.(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;)Ljava/util/concurrent/Future;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
