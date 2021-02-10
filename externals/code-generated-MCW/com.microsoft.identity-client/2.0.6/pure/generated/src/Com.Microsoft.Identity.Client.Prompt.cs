using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/Prompt", DoNotGenerateAcw=true)]
	public sealed partial class Prompt : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/field[@name='CONSENT']"
		[Register ("CONSENT")]
		public static global::Com.Microsoft.Identity.Client.Prompt Consent {
			get {
				const string __id = "CONSENT.Lcom/microsoft/identity/client/Prompt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/field[@name='LOGIN']"
		[Register ("LOGIN")]
		public static global::Com.Microsoft.Identity.Client.Prompt Login {
			get {
				const string __id = "LOGIN.Lcom/microsoft/identity/client/Prompt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/field[@name='SELECT_ACCOUNT']"
		[Register ("SELECT_ACCOUNT")]
		public static global::Com.Microsoft.Identity.Client.Prompt SelectAccount {
			get {
				const string __id = "SELECT_ACCOUNT.Lcom/microsoft/identity/client/Prompt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/field[@name='WHEN_REQUIRED']"
		[Register ("WHEN_REQUIRED")]
		public static global::Com.Microsoft.Identity.Client.Prompt WhenRequired {
			get {
				const string __id = "WHEN_REQUIRED.Lcom/microsoft/identity/client/Prompt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/Prompt", typeof (Prompt));

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

		internal Prompt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/method[@name='toOpenIdConnectPromptParameter' and count(parameter)=0]"
		[Register ("toOpenIdConnectPromptParameter", "()Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;", "")]
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter ToOpenIdConnectPromptParameter ()
		{
			const string __id = "toOpenIdConnectPromptParameter.()Lcom/microsoft/identity/common/internal/providers/oauth2/OpenIdConnectPromptParameter;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OpenIdConnectPromptParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/client/Prompt;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.Prompt ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/client/Prompt;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Prompt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Prompt']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/client/Prompt;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.Prompt[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/client/Prompt;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Client.Prompt[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Client.Prompt));
			} finally {
			}
		}

	}
}
