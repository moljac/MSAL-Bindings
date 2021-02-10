using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='BrokerResultAdapterFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/BrokerResultAdapterFactory", DoNotGenerateAcw=true)]
	public partial class BrokerResultAdapterFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/BrokerResultAdapterFactory", typeof (BrokerResultAdapterFactory));

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

		protected BrokerResultAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='BrokerResultAdapterFactory']/constructor[@name='BrokerResultAdapterFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerResultAdapterFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='BrokerResultAdapterFactory']/method[@name='getBrokerResultAdapter' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.request.SdkType']]"
		[Register ("getBrokerResultAdapter", "(Lcom/microsoft/identity/common/internal/request/SdkType;)Lcom/microsoft/identity/common/internal/result/IBrokerResultAdapter;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter GetBrokerResultAdapter (global::Com.Microsoft.Identity.Common.Internal.Request.SdkType sdkType)
		{
			const string __id = "getBrokerResultAdapter.(Lcom/microsoft/identity/common/internal/request/SdkType;)Lcom/microsoft/identity/common/internal/result/IBrokerResultAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sdkType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdkType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.IBrokerResultAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (sdkType);
			}
		}

	}
}
