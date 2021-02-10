using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge", DoNotGenerateAcw=true)]
	public partial class PKeyAuthChallenge : global::Java.Lang.Object, global::Java.IO.ISerializable {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/constructor[@name='PKeyAuthChallenge.Builder' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Self ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='self' and count(parameter)=0]"
			[Register ("self", "()Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSelfHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder Self ()
			{
				const string __id = "self.()Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCertAuthorities_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetCertAuthorities_Ljava_util_List_Handler ()
			{
				if (cb_setCertAuthorities_Ljava_util_List_ == null)
					cb_setCertAuthorities_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCertAuthorities_Ljava_util_List_);
				return cb_setCertAuthorities_Ljava_util_List_;
			}

			static IntPtr n_SetCertAuthorities_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certAuthorities)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var certAuthorities = global::Android.Runtime.JavaList<string>.FromJniHandle (native_certAuthorities, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCertAuthorities (certAuthorities));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='setCertAuthorities' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setCertAuthorities", "(Ljava/util/List;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSetCertAuthorities_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder SetCertAuthorities (global::System.Collections.Generic.IList<string> certAuthorities)
			{
				const string __id = "setCertAuthorities.(Ljava/util/List;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				IntPtr native_certAuthorities = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (certAuthorities);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_certAuthorities);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_certAuthorities);
					global::System.GC.KeepAlive (certAuthorities);
				}
			}

			static Delegate cb_setContext_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetContext_Ljava_lang_String_Handler ()
			{
				if (cb_setContext_Ljava_lang_String_ == null)
					cb_setContext_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContext_Ljava_lang_String_);
				return cb_setContext_Ljava_lang_String_;
			}

			static IntPtr n_SetContext_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = JNIEnv.GetString (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContext (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContext", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSetContext_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder SetContext (string context)
			{
				const string __id = "setContext.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				IntPtr native_context = JNIEnv.NewString (context);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_context);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_context);
				}
			}

			static Delegate cb_setNonce_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNonce_Ljava_lang_String_Handler ()
			{
				if (cb_setNonce_Ljava_lang_String_ == null)
					cb_setNonce_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNonce_Ljava_lang_String_);
				return cb_setNonce_Ljava_lang_String_;
			}

			static IntPtr n_SetNonce_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nonce)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var nonce = JNIEnv.GetString (native_nonce, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNonce (nonce));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='setNonce' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNonce", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSetNonce_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder SetNonce (string nonce)
			{
				const string __id = "setNonce.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				IntPtr native_nonce = JNIEnv.NewString (nonce);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_nonce);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_nonce);
				}
			}

			static Delegate cb_setSubmitUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSubmitUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setSubmitUrl_Ljava_lang_String_ == null)
					cb_setSubmitUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSubmitUrl_Ljava_lang_String_);
				return cb_setSubmitUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetSubmitUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_submitUrl)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var submitUrl = JNIEnv.GetString (native_submitUrl, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSubmitUrl (submitUrl));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='setSubmitUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubmitUrl", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSetSubmitUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder SetSubmitUrl (string submitUrl)
			{
				const string __id = "setSubmitUrl.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				IntPtr native_submitUrl = JNIEnv.NewString (submitUrl);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_submitUrl);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_submitUrl);
				}
			}

			static Delegate cb_setThumbprint_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetThumbprint_Ljava_lang_String_Handler ()
			{
				if (cb_setThumbprint_Ljava_lang_String_ == null)
					cb_setThumbprint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetThumbprint_Ljava_lang_String_);
				return cb_setThumbprint_Ljava_lang_String_;
			}

			static IntPtr n_SetThumbprint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thumbprint)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var thumbprint = JNIEnv.GetString (native_thumbprint, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetThumbprint (thumbprint));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='setThumbprint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setThumbprint", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSetThumbprint_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder SetThumbprint (string thumbprint)
			{
				const string __id = "setThumbprint.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				IntPtr native_thumbprint = JNIEnv.NewString (thumbprint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_thumbprint);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_thumbprint);
				}
			}

			static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetVersion_Ljava_lang_String_Handler ()
			{
				if (cb_setVersion_Ljava_lang_String_ == null)
					cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVersion_Ljava_lang_String_);
				return cb_setVersion_Ljava_lang_String_;
			}

			static IntPtr n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var version = JNIEnv.GetString (native_version, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVersion (version));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge.Builder']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;", "GetSetVersion_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder SetVersion (string version)
			{
				const string __id = "setVersion.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;";
				IntPtr native_version = JNIEnv.NewString (version);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_version);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_version);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge", typeof (PKeyAuthChallenge));

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

		protected PKeyAuthChallenge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/constructor[@name='PKeyAuthChallenge' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.ui.webview.challengehandlers.PKeyAuthChallenge.Builder']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;)V", "")]
		protected unsafe PKeyAuthChallenge (global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge.Builder builder) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/ui/webview/challengehandlers/PKeyAuthChallenge$Builder;)V";

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

		static Delegate cb_getCertAuthorities;
#pragma warning disable 0169
		static Delegate GetGetCertAuthoritiesHandler ()
		{
			if (cb_getCertAuthorities == null)
				cb_getCertAuthorities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCertAuthorities);
			return cb_getCertAuthorities;
		}

		static IntPtr n_GetCertAuthorities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CertAuthorities);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> CertAuthorities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/method[@name='getCertAuthorities' and count(parameter)=0]"
			[Register ("getCertAuthorities", "()Ljava/util/List;", "GetGetCertAuthoritiesHandler")]
			get {
				const string __id = "getCertAuthorities.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe string Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Ljava/lang/String;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNonce;
#pragma warning disable 0169
		static Delegate GetGetNonceHandler ()
		{
			if (cb_getNonce == null)
				cb_getNonce = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNonce);
			return cb_getNonce;
		}

		static IntPtr n_GetNonce (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nonce);
		}
#pragma warning restore 0169

		public virtual unsafe string Nonce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/method[@name='getNonce' and count(parameter)=0]"
			[Register ("getNonce", "()Ljava/lang/String;", "GetGetNonceHandler")]
			get {
				const string __id = "getNonce.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubmitUrl;
#pragma warning disable 0169
		static Delegate GetGetSubmitUrlHandler ()
		{
			if (cb_getSubmitUrl == null)
				cb_getSubmitUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubmitUrl);
			return cb_getSubmitUrl;
		}

		static IntPtr n_GetSubmitUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubmitUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string SubmitUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/method[@name='getSubmitUrl' and count(parameter)=0]"
			[Register ("getSubmitUrl", "()Ljava/lang/String;", "GetGetSubmitUrlHandler")]
			get {
				const string __id = "getSubmitUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThumbprint;
#pragma warning disable 0169
		static Delegate GetGetThumbprintHandler ()
		{
			if (cb_getThumbprint == null)
				cb_getThumbprint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThumbprint);
			return cb_getThumbprint;
		}

		static IntPtr n_GetThumbprint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Thumbprint);
		}
#pragma warning restore 0169

		public virtual unsafe string Thumbprint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/method[@name='getThumbprint' and count(parameter)=0]"
			[Register ("getThumbprint", "()Ljava/lang/String;", "GetGetThumbprintHandler")]
			get {
				const string __id = "getThumbprint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers.PKeyAuthChallenge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.webview.challengehandlers']/class[@name='PKeyAuthChallenge']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
