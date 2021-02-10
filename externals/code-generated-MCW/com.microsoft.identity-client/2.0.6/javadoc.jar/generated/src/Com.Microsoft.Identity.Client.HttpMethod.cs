using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/HttpMethod", DoNotGenerateAcw=true)]
	public sealed partial class HttpMethod : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='CONNECT']"
		[Register ("CONNECT")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Connect {
			get {
				const string __id = "CONNECT.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='DELETE']"
		[Register ("DELETE")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Delete {
			get {
				const string __id = "DELETE.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='GET']"
		[Register ("GET")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Get {
			get {
				const string __id = "GET.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='HEAD']"
		[Register ("HEAD")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Head {
			get {
				const string __id = "HEAD.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='OPTIONS']"
		[Register ("OPTIONS")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Options {
			get {
				const string __id = "OPTIONS.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='PATCH']"
		[Register ("PATCH")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Patch {
			get {
				const string __id = "PATCH.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='POST']"
		[Register ("POST")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Post {
			get {
				const string __id = "POST.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='PUT']"
		[Register ("PUT")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Put {
			get {
				const string __id = "PUT.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/field[@name='TRACE']"
		[Register ("TRACE")]
		public static global::Com.Microsoft.Identity.Client.HttpMethod Trace {
			get {
				const string __id = "TRACE.Lcom/microsoft/identity/client/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/HttpMethod", typeof (HttpMethod));

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

		internal HttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/client/HttpMethod;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.HttpMethod ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/client/HttpMethod;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.HttpMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='HttpMethod']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/client/HttpMethod;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.HttpMethod[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/client/HttpMethod;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Client.HttpMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Client.HttpMethod));
			} finally {
			}
		}

	}
}
