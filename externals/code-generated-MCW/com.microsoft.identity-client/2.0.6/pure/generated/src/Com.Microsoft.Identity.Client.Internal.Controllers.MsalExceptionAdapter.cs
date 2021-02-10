using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MsalExceptionAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/controllers/MsalExceptionAdapter", DoNotGenerateAcw=true)]
	public partial class MsalExceptionAdapter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/controllers/MsalExceptionAdapter", typeof (MsalExceptionAdapter));

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

		protected MsalExceptionAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MsalExceptionAdapter']/constructor[@name='MsalExceptionAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MsalExceptionAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MsalExceptionAdapter']/method[@name='msalExceptionFromBaseException' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.exception.BaseException']]"
		[Register ("msalExceptionFromBaseException", "(Lcom/microsoft/identity/common/exception/BaseException;)Lcom/microsoft/identity/client/exception/MsalException;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.Exception.MsalException MsalExceptionFromBaseException (global::Com.Microsoft.Identity.Common.Exception.BaseException e)
		{
			const string __id = "msalExceptionFromBaseException.(Lcom/microsoft/identity/common/exception/BaseException;)Lcom/microsoft/identity/client/exception/MsalException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

	}
}
