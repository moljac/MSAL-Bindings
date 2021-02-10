using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/AcquireTokenParameters", DoNotGenerateAcw=true)]
	public partial class AcquireTokenParameters : global::Com.Microsoft.Identity.Client.TokenParameters {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/AcquireTokenParameters$Builder", DoNotGenerateAcw=true)]
		public new partial class Builder : global::Com.Microsoft.Identity.Client.TokenParameters.Builder {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AcquireTokenParameters$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/constructor[@name='AcquireTokenParameters.Builder' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/client/AcquireTokenParameters;", "GetBuildHandler")]
			public override unsafe global::Com.Microsoft.Identity.Client.TokenParameters Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/client/AcquireTokenParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.TokenParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Self ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetSelfHandler")]
			public override unsafe global::Java.Lang.Object Self ()
			{
				const string __id = "self.()Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_startAuthorizationFromActivity_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetStartAuthorizationFromActivity_Landroid_app_Activity_Handler ()
			{
				if (cb_startAuthorizationFromActivity_Landroid_app_Activity_ == null)
					cb_startAuthorizationFromActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_StartAuthorizationFromActivity_Landroid_app_Activity_);
				return cb_startAuthorizationFromActivity_Landroid_app_Activity_;
			}

			static IntPtr n_StartAuthorizationFromActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartAuthorizationFromActivity (activity));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='startAuthorizationFromActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("startAuthorizationFromActivity", "(Landroid/app/Activity;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetStartAuthorizationFromActivity_Landroid_app_Activity_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder StartAuthorizationFromActivity (global::Android.App.Activity activity)
			{
				const string __id = "startAuthorizationFromActivity.(Landroid/app/Activity;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (activity);
				}
			}

			static Delegate cb_withAuthorizationQueryStringParameters_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetWithAuthorizationQueryStringParameters_Ljava_util_List_Handler ()
			{
				if (cb_withAuthorizationQueryStringParameters_Ljava_util_List_ == null)
					cb_withAuthorizationQueryStringParameters_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithAuthorizationQueryStringParameters_Ljava_util_List_);
				return cb_withAuthorizationQueryStringParameters_Ljava_util_List_;
			}

			static IntPtr n_WithAuthorizationQueryStringParameters_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var parameters = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (native_parameters, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAuthorizationQueryStringParameters (parameters));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='withAuthorizationQueryStringParameters' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("withAuthorizationQueryStringParameters", "(Ljava/util/List;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetWithAuthorizationQueryStringParameters_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder WithAuthorizationQueryStringParameters (global::System.Collections.Generic.IList<global::Android.Util.Pair> parameters)
			{
				const string __id = "withAuthorizationQueryStringParameters.(Ljava/util/List;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				IntPtr native_parameters = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (parameters);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_parameters);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_parameters);
					global::System.GC.KeepAlive (parameters);
				}
			}

			static Delegate cb_withCallback_Lcom_microsoft_identity_client_AuthenticationCallback_;
#pragma warning disable 0169
			static Delegate GetWithCallback_Lcom_microsoft_identity_client_AuthenticationCallback_Handler ()
			{
				if (cb_withCallback_Lcom_microsoft_identity_client_AuthenticationCallback_ == null)
					cb_withCallback_Lcom_microsoft_identity_client_AuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithCallback_Lcom_microsoft_identity_client_AuthenticationCallback_);
				return cb_withCallback_Lcom_microsoft_identity_client_AuthenticationCallback_;
			}

			static IntPtr n_WithCallback_Lcom_microsoft_identity_client_AuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authenticationCallback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var authenticationCallback = (global::Com.Microsoft.Identity.Client.IAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (native_authenticationCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCallback (authenticationCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='withCallback' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AuthenticationCallback']]"
			[Register ("withCallback", "(Lcom/microsoft/identity/client/AuthenticationCallback;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetWithCallback_Lcom_microsoft_identity_client_AuthenticationCallback_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder WithCallback (global::Com.Microsoft.Identity.Client.IAuthenticationCallback authenticationCallback)
			{
				const string __id = "withCallback.(Lcom/microsoft/identity/client/AuthenticationCallback;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((authenticationCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticationCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (authenticationCallback);
				}
			}

			static Delegate cb_withFragment_Landroidx_fragment_app_Fragment_;
#pragma warning disable 0169
			static Delegate GetWithFragment_Landroidx_fragment_app_Fragment_Handler ()
			{
				if (cb_withFragment_Landroidx_fragment_app_Fragment_ == null)
					cb_withFragment_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithFragment_Landroidx_fragment_app_Fragment_);
				return cb_withFragment_Landroidx_fragment_app_Fragment_;
			}

			static IntPtr n_WithFragment_Landroidx_fragment_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var fragment = global::Java.Lang.Object.GetObject<global::AndroidX.Fragment.App.Fragment> (native_fragment, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFragment (fragment));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='withFragment' and count(parameter)=1 and parameter[1][@type='androidx.fragment.app.Fragment']]"
			[Register ("withFragment", "(Landroidx/fragment/app/Fragment;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetWithFragment_Landroidx_fragment_app_Fragment_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder WithFragment (global::AndroidX.Fragment.App.Fragment fragment)
			{
				const string __id = "withFragment.(Landroidx/fragment/app/Fragment;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (fragment);
				}
			}

			static Delegate cb_withLoginHint_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithLoginHint_Ljava_lang_String_Handler ()
			{
				if (cb_withLoginHint_Ljava_lang_String_ == null)
					cb_withLoginHint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithLoginHint_Ljava_lang_String_);
				return cb_withLoginHint_Ljava_lang_String_;
			}

			static IntPtr n_WithLoginHint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loginHint)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLoginHint (loginHint));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='withLoginHint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withLoginHint", "(Ljava/lang/String;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetWithLoginHint_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder WithLoginHint (string loginHint)
			{
				const string __id = "withLoginHint.(Ljava/lang/String;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				IntPtr native_loginHint = JNIEnv.NewString (loginHint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_loginHint);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_loginHint);
				}
			}

			static Delegate cb_withOtherScopesToAuthorize_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetWithOtherScopesToAuthorize_Ljava_util_List_Handler ()
			{
				if (cb_withOtherScopesToAuthorize_Ljava_util_List_ == null)
					cb_withOtherScopesToAuthorize_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithOtherScopesToAuthorize_Ljava_util_List_);
				return cb_withOtherScopesToAuthorize_Ljava_util_List_;
			}

			static IntPtr n_WithOtherScopesToAuthorize_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scopes = global::Android.Runtime.JavaList<string>.FromJniHandle (native_scopes, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOtherScopesToAuthorize (scopes));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='withOtherScopesToAuthorize' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("withOtherScopesToAuthorize", "(Ljava/util/List;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetWithOtherScopesToAuthorize_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder WithOtherScopesToAuthorize (global::System.Collections.Generic.IList<string> scopes)
			{
				const string __id = "withOtherScopesToAuthorize.(Ljava/util/List;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				IntPtr native_scopes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (scopes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scopes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_scopes);
					global::System.GC.KeepAlive (scopes);
				}
			}

			static Delegate cb_withPrompt_Lcom_microsoft_identity_client_Prompt_;
#pragma warning disable 0169
			static Delegate GetWithPrompt_Lcom_microsoft_identity_client_Prompt_Handler ()
			{
				if (cb_withPrompt_Lcom_microsoft_identity_client_Prompt_ == null)
					cb_withPrompt_Lcom_microsoft_identity_client_Prompt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithPrompt_Lcom_microsoft_identity_client_Prompt_);
				return cb_withPrompt_Lcom_microsoft_identity_client_Prompt_;
			}

			static IntPtr n_WithPrompt_Lcom_microsoft_identity_client_Prompt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prompt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var prompt = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (native_prompt, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithPrompt (prompt));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters.Builder']/method[@name='withPrompt' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.Prompt']]"
			[Register ("withPrompt", "(Lcom/microsoft/identity/client/Prompt;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;", "GetWithPrompt_Lcom_microsoft_identity_client_Prompt_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder WithPrompt (global::Com.Microsoft.Identity.Client.Prompt prompt)
			{
				const string __id = "withPrompt.(Lcom/microsoft/identity/client/Prompt;)Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((prompt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prompt).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (prompt);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AcquireTokenParameters", typeof (AcquireTokenParameters));

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

		protected AcquireTokenParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/constructor[@name='AcquireTokenParameters' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.AcquireTokenParameters.Builder']]"
		[Register (".ctor", "(Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;)V", "")]
		public unsafe AcquireTokenParameters (global::Com.Microsoft.Identity.Client.AcquireTokenParameters.Builder builder) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/client/AcquireTokenParameters$Builder;)V";

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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.IAuthenticationCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/microsoft/identity/client/AuthenticationCallback;", "GetGetCallbackHandler")]
			get {
				const string __id = "getCallback.()Lcom/microsoft/identity/client/AuthenticationCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IAuthenticationCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraQueryStringParameters;
#pragma warning disable 0169
		static Delegate GetGetExtraQueryStringParametersHandler ()
		{
			if (cb_getExtraQueryStringParameters == null)
				cb_getExtraQueryStringParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtraQueryStringParameters);
			return cb_getExtraQueryStringParameters;
		}

		static IntPtr n_GetExtraQueryStringParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.ExtraQueryStringParameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> ExtraQueryStringParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getExtraQueryStringParameters' and count(parameter)=0]"
			[Register ("getExtraQueryStringParameters", "()Ljava/util/List;", "GetGetExtraQueryStringParametersHandler")]
			get {
				const string __id = "getExtraQueryStringParameters.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraScopesToConsent;
#pragma warning disable 0169
		static Delegate GetGetExtraScopesToConsentHandler ()
		{
			if (cb_getExtraScopesToConsent == null)
				cb_getExtraScopesToConsent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtraScopesToConsent);
			return cb_getExtraScopesToConsent;
		}

		static IntPtr n_GetExtraScopesToConsent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ExtraScopesToConsent);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ExtraScopesToConsent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getExtraScopesToConsent' and count(parameter)=0]"
			[Register ("getExtraScopesToConsent", "()Ljava/util/List;", "GetGetExtraScopesToConsentHandler")]
			get {
				const string __id = "getExtraScopesToConsent.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFragment;
#pragma warning disable 0169
		static Delegate GetGetFragmentHandler ()
		{
			if (cb_getFragment == null)
				cb_getFragment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFragment);
			return cb_getFragment;
		}

		static IntPtr n_GetFragment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fragment);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Fragment.App.Fragment Fragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getFragment' and count(parameter)=0]"
			[Register ("getFragment", "()Landroidx/fragment/app/Fragment;", "GetGetFragmentHandler")]
			get {
				const string __id = "getFragment.()Landroidx/fragment/app/Fragment;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Fragment.App.Fragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLoginHint;
#pragma warning disable 0169
		static Delegate GetGetLoginHintHandler ()
		{
			if (cb_getLoginHint == null)
				cb_getLoginHint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoginHint);
			return cb_getLoginHint;
		}

		static IntPtr n_GetLoginHint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LoginHint);
		}
#pragma warning restore 0169

		public virtual unsafe string LoginHint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getLoginHint' and count(parameter)=0]"
			[Register ("getLoginHint", "()Ljava/lang/String;", "GetGetLoginHintHandler")]
			get {
				const string __id = "getLoginHint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrompt;
#pragma warning disable 0169
		static Delegate GetGetPromptHandler ()
		{
			if (cb_getPrompt == null)
				cb_getPrompt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrompt);
			return cb_getPrompt;
		}

		static IntPtr n_GetPrompt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Prompt);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Prompt Prompt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AcquireTokenParameters']/method[@name='getPrompt' and count(parameter)=0]"
			[Register ("getPrompt", "()Lcom/microsoft/identity/client/Prompt;", "GetGetPromptHandler")]
			get {
				const string __id = "getPrompt.()Lcom/microsoft/identity/client/Prompt;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
