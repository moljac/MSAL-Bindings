using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.helper']/class[@name='BrokerHelperActivity']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/helper/BrokerHelperActivity", DoNotGenerateAcw=true)]
	public partial class BrokerHelperActivity : global::Android.App.Activity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/helper/BrokerHelperActivity", typeof (BrokerHelperActivity));

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

		protected BrokerHelperActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.helper']/class[@name='BrokerHelperActivity']/constructor[@name='BrokerHelperActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerHelperActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.helper']/class[@name='BrokerHelperActivity']/method[@name='createStartIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createStartIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateStartIntent (global::Android.Content.Context context)
		{
			const string __id = "createStartIntent.(Landroid/content/Context;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
