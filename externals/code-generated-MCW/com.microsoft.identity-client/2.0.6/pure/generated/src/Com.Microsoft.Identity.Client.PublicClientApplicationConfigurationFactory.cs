using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfigurationFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/PublicClientApplicationConfigurationFactory", DoNotGenerateAcw=true)]
	public partial class PublicClientApplicationConfigurationFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/PublicClientApplicationConfigurationFactory", typeof (PublicClientApplicationConfigurationFactory));

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

		protected PublicClientApplicationConfigurationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfigurationFactory']/constructor[@name='PublicClientApplicationConfigurationFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PublicClientApplicationConfigurationFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfigurationFactory']/method[@name='initializeConfiguration' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initializeConfiguration", "(Landroid/content/Context;)Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration InitializeConfiguration (global::Android.Content.Context context)
		{
			const string __id = "initializeConfiguration.(Landroid/content/Context;)Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfigurationFactory']/method[@name='initializeConfiguration' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("initializeConfiguration", "(Landroid/content/Context;I)Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration InitializeConfiguration (global::Android.Content.Context context, int configResourceId)
		{
			const string __id = "initializeConfiguration.(Landroid/content/Context;I)Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (configResourceId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='PublicClientApplicationConfigurationFactory']/method[@name='initializeConfiguration' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("initializeConfiguration", "(Landroid/content/Context;Ljava/io/File;)Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration InitializeConfiguration (global::Android.Content.Context context, global::Java.IO.File configFile)
		{
			const string __id = "initializeConfiguration.(Landroid/content/Context;Ljava/io/File;)Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((configFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configFile).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (configFile);
			}
		}

	}
}
