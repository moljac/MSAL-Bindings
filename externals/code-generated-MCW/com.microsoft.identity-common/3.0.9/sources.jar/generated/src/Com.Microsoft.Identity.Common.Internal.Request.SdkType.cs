using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/request/SdkType", DoNotGenerateAcw=true)]
	public sealed partial class SdkType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/field[@name='ADAL']"
		[Register ("ADAL")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.SdkType Adal {
			get {
				const string __id = "ADAL.Lcom/microsoft/identity/common/internal/request/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/field[@name='MSAL']"
		[Register ("MSAL")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.SdkType Msal {
			get {
				const string __id = "MSAL.Lcom/microsoft/identity/common/internal/request/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/field[@name='MSAL_CPP']"
		[Register ("MSAL_CPP")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.SdkType MsalCpp {
			get {
				const string __id = "MSAL_CPP.Lcom/microsoft/identity/common/internal/request/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.SdkType Unknown {
			get {
				const string __id = "UNKNOWN.Lcom/microsoft/identity/common/internal/request/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/request/SdkType", typeof (SdkType));

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

		internal SdkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsCapableOfMSA {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/method[@name='isCapableOfMSA' and count(parameter)=0]"
			[Register ("isCapableOfMSA", "()Z", "")]
			get {
				const string __id = "isCapableOfMSA.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string ProductName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/method[@name='getProductName' and count(parameter)=0]"
			[Register ("getProductName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getProductName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/request/SdkType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Request.SdkType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/request/SdkType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.SdkType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='SdkType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/internal/request/SdkType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Request.SdkType[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/internal/request/SdkType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Internal.Request.SdkType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Request.SdkType));
			} finally {
			}
		}

	}
}
