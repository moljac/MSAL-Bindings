using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/CommandResult", DoNotGenerateAcw=true)]
	public partial class CommandResult : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult.ResultStatus']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus", DoNotGenerateAcw=true)]
		public sealed partial class ResultStatus : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult.ResultStatus']/field[@name='CANCEL']"
			[Register ("CANCEL")]
			public static global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus Cancel {
				get {
					const string __id = "CANCEL.Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult.ResultStatus']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus Completed {
				get {
					const string __id = "COMPLETED.Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult.ResultStatus']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus Error {
				get {
					const string __id = "ERROR.Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus", typeof (ResultStatus));

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

			internal ResultStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult.ResultStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult.ResultStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/CommandResult", typeof (CommandResult));

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

		protected CommandResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult']/constructor[@name='CommandResult' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.controllers.CommandResult.ResultStatus'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;Ljava/lang/Object;)V", "")]
		public unsafe CommandResult (global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus status, global::Java.Lang.Object result) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (status);
				global::System.GC.KeepAlive (result);
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='CommandResult']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lcom/microsoft/identity/common/internal/controllers/CommandResult$ResultStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult.ResultStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
