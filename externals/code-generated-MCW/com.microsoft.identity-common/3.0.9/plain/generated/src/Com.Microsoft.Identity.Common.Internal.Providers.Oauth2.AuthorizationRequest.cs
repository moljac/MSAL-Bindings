using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest<T>"})]
	public abstract partial class AuthorizationRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/field[@name='mState']"
		[Register ("mState")]
		protected string MState {
			get {
				const string __id = "mState.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mState.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest.Builder<B>"})]
		public abstract partial class Builder : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/field[@name='mCorrelationId']"
			[Register ("mCorrelationId")]
			public global::Java.Util.UUID MCorrelationId {
				get {
					const string __id = "mCorrelationId.Ljava/util/UUID;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mCorrelationId.Ljava/util/UUID;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/field[@name='mExtraQueryParams']"
			[Register ("mExtraQueryParams")]
			public global::System.Collections.IList MExtraQueryParams {
				get {
					const string __id = "mExtraQueryParams.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mExtraQueryParams.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/field[@name='mLoginHint']"
			[Register ("mLoginHint")]
			public string MLoginHint {
				get {
					const string __id = "mLoginHint.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mLoginHint.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/field[@name='mPrompt']"
			[Register ("mPrompt")]
			public string MPrompt {
				get {
					const string __id = "mPrompt.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mPrompt.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/constructor[@name='AuthorizationRequest.Builder' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;", "GetBuildHandler")]
			public abstract global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest Build ();

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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Self ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSelfHandler")]
			public abstract global::Java.Lang.Object Self ();

			static Delegate cb_setClaims_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetClaims_Ljava_lang_String_Handler ()
			{
				if (cb_setClaims_Ljava_lang_String_ == null)
					cb_setClaims_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetClaims_Ljava_lang_String_);
				return cb_setClaims_Ljava_lang_String_;
			}

			static IntPtr n_SetClaims_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_claims)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var claims = JNIEnv.GetString (native_claims, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetClaims (claims));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setClaims' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClaims", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetClaims_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetClaims (string claims)
			{
				const string __id = "setClaims.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_claims = JNIEnv.NewString (claims);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_claims);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_claims);
				}
			}

			static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetClientId_Ljava_lang_String_Handler ()
			{
				if (cb_setClientId_Ljava_lang_String_ == null)
					cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetClientId_Ljava_lang_String_);
				return cb_setClientId_Ljava_lang_String_;
			}

			static IntPtr n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetClientId (clientId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetClientId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetClientId (string clientId)
			{
				const string __id = "setClientId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_clientId = JNIEnv.NewString (clientId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientId);
				}
			}

			static Delegate cb_setCorrelationId_Ljava_util_UUID_;
#pragma warning disable 0169
			static Delegate GetSetCorrelationId_Ljava_util_UUID_Handler ()
			{
				if (cb_setCorrelationId_Ljava_util_UUID_ == null)
					cb_setCorrelationId_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCorrelationId_Ljava_util_UUID_);
				return cb_setCorrelationId_Ljava_util_UUID_;
			}

			static IntPtr n_SetCorrelationId_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var correlationId = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_correlationId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCorrelationId (correlationId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setCorrelationId' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
			[Register ("setCorrelationId", "(Ljava/util/UUID;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetCorrelationId_Ljava_util_UUID_Handler")]
			public virtual unsafe global::Java.Lang.Object SetCorrelationId (global::Java.Util.UUID correlationId)
			{
				const string __id = "setCorrelationId.(Ljava/util/UUID;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((correlationId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) correlationId).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (correlationId);
				}
			}

			static Delegate cb_setCpInstallationDetail_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetSetCpInstallationDetail_Landroid_content_Context_Handler ()
			{
				if (cb_setCpInstallationDetail_Landroid_content_Context_ == null)
					cb_setCpInstallationDetail_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCpInstallationDetail_Landroid_content_Context_);
				return cb_setCpInstallationDetail_Landroid_content_Context_;
			}

			static IntPtr n_SetCpInstallationDetail_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCpInstallationDetail (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setCpInstallationDetail' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setCpInstallationDetail", "(Landroid/content/Context;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetCpInstallationDetail_Landroid_content_Context_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder SetCpInstallationDetail (global::Android.Content.Context context)
			{
				const string __id = "setCpInstallationDetail.(Landroid/content/Context;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_setExtraQueryParams_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetExtraQueryParams_Ljava_util_List_Handler ()
			{
				if (cb_setExtraQueryParams_Ljava_util_List_ == null)
					cb_setExtraQueryParams_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetExtraQueryParams_Ljava_util_List_);
				return cb_setExtraQueryParams_Ljava_util_List_;
			}

			static IntPtr n_SetExtraQueryParams_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extraQueryParams)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var extraQueryParams = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (native_extraQueryParams, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExtraQueryParams (extraQueryParams));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setExtraQueryParams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setExtraQueryParams", "(Ljava/util/List;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetExtraQueryParams_Ljava_util_List_Handler")]
			public virtual unsafe global::Java.Lang.Object SetExtraQueryParams (global::System.Collections.Generic.IList<global::Android.Util.Pair> extraQueryParams)
			{
				const string __id = "setExtraQueryParams.(Ljava/util/List;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_extraQueryParams = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (extraQueryParams);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_extraQueryParams);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_extraQueryParams);
					global::System.GC.KeepAlive (extraQueryParams);
				}
			}

			static Delegate cb_setLoginHint_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLoginHint_Ljava_lang_String_Handler ()
			{
				if (cb_setLoginHint_Ljava_lang_String_ == null)
					cb_setLoginHint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetLoginHint_Ljava_lang_String_);
				return cb_setLoginHint_Ljava_lang_String_;
			}

			static IntPtr n_SetLoginHint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loginHint)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLoginHint (loginHint));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setLoginHint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLoginHint", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetLoginHint_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetLoginHint (string loginHint)
			{
				const string __id = "setLoginHint.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_loginHint = JNIEnv.NewString (loginHint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_loginHint);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_loginHint);
				}
			}

			static Delegate cb_setPrompt_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPrompt_Ljava_lang_String_Handler ()
			{
				if (cb_setPrompt_Ljava_lang_String_ == null)
					cb_setPrompt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPrompt_Ljava_lang_String_);
				return cb_setPrompt_Ljava_lang_String_;
			}

			static IntPtr n_SetPrompt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prompt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var prompt = JNIEnv.GetString (native_prompt, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPrompt (prompt));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setPrompt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPrompt", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetPrompt_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetPrompt (string prompt)
			{
				const string __id = "setPrompt.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_prompt = JNIEnv.NewString (prompt);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_prompt);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_prompt);
				}
			}

			static Delegate cb_setRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetRedirectUri_Ljava_lang_String_Handler ()
			{
				if (cb_setRedirectUri_Ljava_lang_String_ == null)
					cb_setRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRedirectUri_Ljava_lang_String_);
				return cb_setRedirectUri_Ljava_lang_String_;
			}

			static IntPtr n_SetRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirectUri)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var redirectUri = JNIEnv.GetString (native_redirectUri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRedirectUri (redirectUri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUri", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetRedirectUri_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetRedirectUri (string redirectUri)
			{
				const string __id = "setRedirectUri.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_redirectUri);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_redirectUri);
				}
			}

			static Delegate cb_setRequestHeaders_Ljava_util_HashMap_;
#pragma warning disable 0169
			static Delegate GetSetRequestHeaders_Ljava_util_HashMap_Handler ()
			{
				if (cb_setRequestHeaders_Ljava_util_HashMap_ == null)
					cb_setRequestHeaders_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRequestHeaders_Ljava_util_HashMap_);
				return cb_setRequestHeaders_Ljava_util_HashMap_;
			}

			static IntPtr n_SetRequestHeaders_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestHeaders)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var requestHeaders = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_requestHeaders, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequestHeaders (requestHeaders));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setRequestHeaders' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setRequestHeaders", "(Ljava/util/HashMap;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetRequestHeaders_Ljava_util_HashMap_Handler")]
			public virtual unsafe global::Java.Lang.Object SetRequestHeaders (global::System.Collections.Generic.IDictionary<string, string> requestHeaders)
			{
				const string __id = "setRequestHeaders.(Ljava/util/HashMap;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_requestHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (requestHeaders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_requestHeaders);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_requestHeaders);
					global::System.GC.KeepAlive (requestHeaders);
				}
			}

			static Delegate cb_setResponseType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetResponseType_Ljava_lang_String_Handler ()
			{
				if (cb_setResponseType_Ljava_lang_String_ == null)
					cb_setResponseType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetResponseType_Ljava_lang_String_);
				return cb_setResponseType_Ljava_lang_String_;
			}

			static IntPtr n_SetResponseType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var responseType = JNIEnv.GetString (native_responseType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResponseType (responseType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setResponseType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseType", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetResponseType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetResponseType (string responseType)
			{
				const string __id = "setResponseType.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_responseType = JNIEnv.NewString (responseType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_responseType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_responseType);
				}
			}

			static Delegate cb_setScope_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetScope_Ljava_lang_String_Handler ()
			{
				if (cb_setScope_Ljava_lang_String_ == null)
					cb_setScope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetScope_Ljava_lang_String_);
				return cb_setScope_Ljava_lang_String_;
			}

			static IntPtr n_SetScope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scope)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetScope (scope));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScope", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetScope_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetScope (string scope)
			{
				const string __id = "setScope.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_scope = JNIEnv.NewString (scope);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scope);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_scope);
				}
			}

			static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetState_Ljava_lang_String_Handler ()
			{
				if (cb_setState_Ljava_lang_String_ == null)
					cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetState_Ljava_lang_String_);
				return cb_setState_Ljava_lang_String_;
			}

			static IntPtr n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetState (state));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetState_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object SetState (string state)
			{
				const string __id = "setState.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				IntPtr native_state = JNIEnv.NewString (state);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_state);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_state);
				}
			}

			static Delegate cb_setWebViewZoomControlsEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetWebViewZoomControlsEnabled_ZHandler ()
			{
				if (cb_setWebViewZoomControlsEnabled_Z == null)
					cb_setWebViewZoomControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetWebViewZoomControlsEnabled_Z);
				return cb_setWebViewZoomControlsEnabled_Z;
			}

			static IntPtr n_SetWebViewZoomControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool webViewZoomControlsEnabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetWebViewZoomControlsEnabled (webViewZoomControlsEnabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setWebViewZoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWebViewZoomControlsEnabled", "(Z)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetWebViewZoomControlsEnabled_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder SetWebViewZoomControlsEnabled (bool webViewZoomControlsEnabled)
			{
				const string __id = "setWebViewZoomControlsEnabled.(Z)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (webViewZoomControlsEnabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setWebViewZoomEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetWebViewZoomEnabled_ZHandler ()
			{
				if (cb_setWebViewZoomEnabled_Z == null)
					cb_setWebViewZoomEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetWebViewZoomEnabled_Z);
				return cb_setWebViewZoomEnabled_Z;
			}

			static IntPtr n_SetWebViewZoomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool webViewZoomEnabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetWebViewZoomEnabled (webViewZoomEnabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='setWebViewZoomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWebViewZoomEnabled", "(Z)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSetWebViewZoomEnabled_ZHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder SetWebViewZoomEnabled (bool webViewZoomEnabled)
			{
				const string __id = "setWebViewZoomEnabled.(Z)Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (webViewZoomEnabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder", DoNotGenerateAcw=true)]
		internal partial class BuilderInvoker : Builder {
			public BuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder", typeof (BuilderInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;", "GetBuildHandler")]
			public override unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;", "GetSelfHandler")]
			public override unsafe global::Java.Lang.Object Self ()
			{
				const string __id = "self.()Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.ResponseType']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$ResponseType", DoNotGenerateAcw=true)]
		public sealed partial class ResponseType : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.ResponseType']/field[@name='CODE']"
			[Register ("CODE")]
			public const string Code = (string) "code";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$ResponseType", typeof (ResponseType));

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

			internal ResponseType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest.ResponseType']/constructor[@name='AuthorizationRequest.ResponseType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ResponseType () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest", typeof (AuthorizationRequest));

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

		protected AuthorizationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/constructor[@name='AuthorizationRequest' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.AuthorizationRequest.Builder']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;)V", "")]
		protected unsafe AuthorizationRequest (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest.Builder builder) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest$Builder;)V";

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

		static Delegate cb_getAuthorizationEndpoint;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationEndpointHandler ()
		{
			if (cb_getAuthorizationEndpoint == null)
				cb_getAuthorizationEndpoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationEndpoint);
			return cb_getAuthorizationEndpoint;
		}

		static IntPtr n_GetAuthorizationEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationEndpoint);
		}
#pragma warning restore 0169

		public abstract string AuthorizationEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getAuthorizationEndpoint' and count(parameter)=0]"
			[Register ("getAuthorizationEndpoint", "()Ljava/lang/String;", "GetGetAuthorizationEndpointHandler")]
			get; 
		}

		static Delegate cb_getAuthorizationRequestAsHttpRequest;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationRequestAsHttpRequestHandler ()
		{
			if (cb_getAuthorizationRequestAsHttpRequest == null)
				cb_getAuthorizationRequestAsHttpRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorizationRequestAsHttpRequest);
			return cb_getAuthorizationRequestAsHttpRequest;
		}

		static IntPtr n_GetAuthorizationRequestAsHttpRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorizationRequestAsHttpRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Net.Uri AuthorizationRequestAsHttpRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getAuthorizationRequestAsHttpRequest' and count(parameter)=0]"
			[Register ("getAuthorizationRequestAsHttpRequest", "()Landroid/net/Uri;", "GetGetAuthorizationRequestAsHttpRequestHandler")]
			get {
				const string __id = "getAuthorizationRequestAsHttpRequest.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClaims;
#pragma warning disable 0169
		static Delegate GetGetClaimsHandler ()
		{
			if (cb_getClaims == null)
				cb_getClaims = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaims);
			return cb_getClaims;
		}

		static IntPtr n_GetClaims (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Claims);
		}
#pragma warning restore 0169

		public virtual unsafe string Claims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getClaims' and count(parameter)=0]"
			[Register ("getClaims", "()Ljava/lang/String;", "GetGetClaimsHandler")]
			get {
				const string __id = "getClaims.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraQueryParams;
#pragma warning disable 0169
		static Delegate GetGetExtraQueryParamsHandler ()
		{
			if (cb_getExtraQueryParams == null)
				cb_getExtraQueryParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtraQueryParams);
			return cb_getExtraQueryParams;
		}

		static IntPtr n_GetExtraQueryParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.ExtraQueryParams);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> ExtraQueryParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getExtraQueryParams' and count(parameter)=0]"
			[Register ("getExtraQueryParams", "()Ljava/util/List;", "GetGetExtraQueryParamsHandler")]
			get {
				const string __id = "getExtraQueryParams.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isWebViewZoomControlsEnabled;
#pragma warning disable 0169
		static Delegate GetIsWebViewZoomControlsEnabledHandler ()
		{
			if (cb_isWebViewZoomControlsEnabled == null)
				cb_isWebViewZoomControlsEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWebViewZoomControlsEnabled);
			return cb_isWebViewZoomControlsEnabled;
		}

		static bool n_IsWebViewZoomControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWebViewZoomControlsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWebViewZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='isWebViewZoomControlsEnabled' and count(parameter)=0]"
			[Register ("isWebViewZoomControlsEnabled", "()Z", "GetIsWebViewZoomControlsEnabledHandler")]
			get {
				const string __id = "isWebViewZoomControlsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isWebViewZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsWebViewZoomEnabledHandler ()
		{
			if (cb_isWebViewZoomEnabled == null)
				cb_isWebViewZoomEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWebViewZoomEnabled);
			return cb_isWebViewZoomEnabled;
		}

		static bool n_IsWebViewZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWebViewZoomEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWebViewZoomEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='isWebViewZoomEnabled' and count(parameter)=0]"
			[Register ("isWebViewZoomEnabled", "()Z", "GetIsWebViewZoomEnabledHandler")]
			get {
				const string __id = "isWebViewZoomEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				const string __id = "getRedirectUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestHeaders;
#pragma warning disable 0169
		static Delegate GetGetRequestHeadersHandler ()
		{
			if (cb_getRequestHeaders == null)
				cb_getRequestHeaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestHeaders);
			return cb_getRequestHeaders;
		}

		static IntPtr n_GetRequestHeaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestHeaders);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/HashMap;", "GetGetRequestHeadersHandler")]
			get {
				const string __id = "getRequestHeaders.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseType;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeHandler ()
		{
			if (cb_getResponseType == null)
				cb_getResponseType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseType);
			return cb_getResponseType;
		}

		static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetResponseType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getResponseType' and count(parameter)=0]"
		[Register ("getResponseType", "()Ljava/lang/String;", "GetGetResponseTypeHandler")]
		public virtual unsafe string GetResponseType ()
		{
			const string __id = "getResponseType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest", DoNotGenerateAcw=true)]
	internal partial class AuthorizationRequestInvoker : AuthorizationRequest {
		public AuthorizationRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/AuthorizationRequest", typeof (AuthorizationRequestInvoker));

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

		public override unsafe string AuthorizationEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='AuthorizationRequest']/method[@name='getAuthorizationEndpoint' and count(parameter)=0]"
			[Register ("getAuthorizationEndpoint", "()Ljava/lang/String;", "GetGetAuthorizationEndpointHandler")]
			get {
				const string __id = "getAuthorizationEndpoint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
