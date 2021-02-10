using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='BrokerRequestType']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/request/BrokerRequestType", DoNotGenerateAcw=true)]
	public sealed partial class BrokerRequestType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='BrokerRequestType']/field[@name='BROKER_RT_REQUEST']"
		[Register ("BROKER_RT_REQUEST")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType BrokerRtRequest {
			get {
				const string __id = "BROKER_RT_REQUEST.Lcom/microsoft/identity/common/internal/request/BrokerRequestType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='BrokerRequestType']/field[@name='REGULAR']"
		[Register ("REGULAR")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType Regular {
			get {
				const string __id = "REGULAR.Lcom/microsoft/identity/common/internal/request/BrokerRequestType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='BrokerRequestType']/field[@name='RESOLVE_INTERRUPT']"
		[Register ("RESOLVE_INTERRUPT")]
		public static global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType ResolveInterrupt {
			get {
				const string __id = "RESOLVE_INTERRUPT.Lcom/microsoft/identity/common/internal/request/BrokerRequestType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/request/BrokerRequestType", typeof (BrokerRequestType));

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

		internal BrokerRequestType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='BrokerRequestType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/request/BrokerRequestType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/request/BrokerRequestType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/class[@name='BrokerRequestType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/internal/request/BrokerRequestType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/internal/request/BrokerRequestType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Request.BrokerRequestType));
			} finally {
			}
		}

	}
}
