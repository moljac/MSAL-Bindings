using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/AadAuthorityAudience", DoNotGenerateAcw=true)]
	public sealed partial class AadAuthorityAudience : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/field[@name='AzureAdAndPersonalMicrosoftAccount']"
		[Register ("AzureAdAndPersonalMicrosoftAccount")]
		public static global::Com.Microsoft.Identity.Client.AadAuthorityAudience AzureAdAndPersonalMicrosoftAccount {
			get {
				const string __id = "AzureAdAndPersonalMicrosoftAccount.Lcom/microsoft/identity/client/AadAuthorityAudience;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/field[@name='AzureAdMultipleOrgs']"
		[Register ("AzureAdMultipleOrgs")]
		public static global::Com.Microsoft.Identity.Client.AadAuthorityAudience AzureAdMultipleOrgs {
			get {
				const string __id = "AzureAdMultipleOrgs.Lcom/microsoft/identity/client/AadAuthorityAudience;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/field[@name='AzureAdMyOrg']"
		[Register ("AzureAdMyOrg")]
		public static global::Com.Microsoft.Identity.Client.AadAuthorityAudience AzureAdMyOrg {
			get {
				const string __id = "AzureAdMyOrg.Lcom/microsoft/identity/client/AadAuthorityAudience;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/field[@name='PersonalMicrosoftAccount']"
		[Register ("PersonalMicrosoftAccount")]
		public static global::Com.Microsoft.Identity.Client.AadAuthorityAudience PersonalMicrosoftAccount {
			get {
				const string __id = "PersonalMicrosoftAccount.Lcom/microsoft/identity/client/AadAuthorityAudience;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AadAuthorityAudience", typeof (AadAuthorityAudience));

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

		internal AadAuthorityAudience (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string AudienceValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/method[@name='getAudienceValue' and count(parameter)=0]"
			[Register ("getAudienceValue", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAudienceValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/client/AadAuthorityAudience;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.AadAuthorityAudience ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/client/AadAuthorityAudience;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AadAuthorityAudience> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AadAuthorityAudience']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/client/AadAuthorityAudience;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.AadAuthorityAudience[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/client/AadAuthorityAudience;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Client.AadAuthorityAudience[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Client.AadAuthorityAudience));
			} finally {
			}
		}

	}
}
