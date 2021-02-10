using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter", DoNotGenerateAcw=true)]
	public sealed partial class OpenIdConnectPromptParameter : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/field[@name='CONSENT']"
		[Register ("CONSENT")]
		public static global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter Consent {
			get {
				const string __id = "CONSENT.Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/field[@name='LOGIN']"
		[Register ("LOGIN")]
		public static global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter Login {
			get {
				const string __id = "LOGIN.Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter None {
			get {
				const string __id = "NONE.Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/field[@name='SELECT_ACCOUNT']"
		[Register ("SELECT_ACCOUNT")]
		public static global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter SelectAccount {
			get {
				const string __id = "SELECT_ACCOUNT.Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/field[@name='UNSET']"
		[Register ("UNSET")]
		public static global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter Unset {
			get {
				const string __id = "UNSET.Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter", typeof (OpenIdConnectPromptParameter));

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

		internal OpenIdConnectPromptParameter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/method[@name='_fromPromptBehavior' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("_fromPromptBehavior", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter _fromPromptBehavior (string promptBehavior)
		{
			const string __id = "_fromPromptBehavior.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";
			IntPtr native_promptBehavior = JNIEnv.NewString (promptBehavior);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_promptBehavior);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_promptBehavior);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='OpenIdConnectPromptParameter']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter));
			} finally {
			}
		}

	}
}
