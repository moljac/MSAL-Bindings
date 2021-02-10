using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/AzureCloudInstance", DoNotGenerateAcw=true)]
	public sealed partial class AzureCloudInstance : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/field[@name='AzureChina']"
		[Register ("AzureChina")]
		public static global::Com.Microsoft.Identity.Client.AzureCloudInstance AzureChina {
			get {
				const string __id = "AzureChina.Lcom/microsoft/identity/client/AzureCloudInstance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/field[@name='AzureGermany']"
		[Register ("AzureGermany")]
		public static global::Com.Microsoft.Identity.Client.AzureCloudInstance AzureGermany {
			get {
				const string __id = "AzureGermany.Lcom/microsoft/identity/client/AzureCloudInstance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/field[@name='AzurePublic']"
		[Register ("AzurePublic")]
		public static global::Com.Microsoft.Identity.Client.AzureCloudInstance AzurePublic {
			get {
				const string __id = "AzurePublic.Lcom/microsoft/identity/client/AzureCloudInstance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/field[@name='AzureUsGov']"
		[Register ("AzureUsGov")]
		public static global::Com.Microsoft.Identity.Client.AzureCloudInstance AzureUsGov {
			get {
				const string __id = "AzureUsGov.Lcom/microsoft/identity/client/AzureCloudInstance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/AzureCloudInstance", typeof (AzureCloudInstance));

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

		internal AzureCloudInstance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string CloudInstanceUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/method[@name='getCloudInstanceUri' and count(parameter)=0]"
			[Register ("getCloudInstanceUri", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCloudInstanceUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/client/AzureCloudInstance;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.AzureCloudInstance ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/client/AzureCloudInstance;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AzureCloudInstance> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='AzureCloudInstance']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/client/AzureCloudInstance;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.AzureCloudInstance[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/client/AzureCloudInstance;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Client.AzureCloudInstance[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Client.AzureCloudInstance));
			} finally {
			}
		}

	}
}
