using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal.api']/class[@name='BrokerClientIdRefreshTokenAccessor']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/api/BrokerClientIdRefreshTokenAccessor", DoNotGenerateAcw=true)]
	public sealed partial class BrokerClientIdRefreshTokenAccessor : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/api/BrokerClientIdRefreshTokenAccessor", typeof (BrokerClientIdRefreshTokenAccessor));

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

		internal BrokerClientIdRefreshTokenAccessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.internal.api']/class[@name='BrokerClientIdRefreshTokenAccessor']/constructor[@name='BrokerClientIdRefreshTokenAccessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerClientIdRefreshTokenAccessor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal.api']/class[@name='BrokerClientIdRefreshTokenAccessor']/method[@name='get' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Get (global::Android.Content.Context context, string accountObjectId)
		{
			const string __id = "get.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_accountObjectId = JNIEnv.NewString (accountObjectId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_accountObjectId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountObjectId);
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
