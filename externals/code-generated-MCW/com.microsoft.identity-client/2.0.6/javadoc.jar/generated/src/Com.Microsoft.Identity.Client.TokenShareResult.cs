using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenShareResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenShareResult", DoNotGenerateAcw=true)]
	public partial class TokenShareResult : global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareResultInternal {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenShareResult.TokenShareExportFormat']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/TokenShareResult$TokenShareExportFormat", DoNotGenerateAcw=true)]
		public partial class TokenShareExportFormat : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenShareResult.TokenShareExportFormat']/field[@name='RAW']"
			[Register ("RAW")]
			public const string Raw = (string) "RAW";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenShareResult.TokenShareExportFormat']/field[@name='SSO_STATE_SERIALIZER_BLOB']"
			[Register ("SSO_STATE_SERIALIZER_BLOB")]
			public const string SsoStateSerializerBlob = (string) "SSO_STATE_SERIALIZER_BLOB";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenShareResult$TokenShareExportFormat", typeof (TokenShareExportFormat));

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

			protected TokenShareExportFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='TokenShareResult.TokenShareExportFormat']/constructor[@name='TokenShareResult.TokenShareExportFormat' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TokenShareExportFormat () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/TokenShareResult", typeof (TokenShareResult));

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

		protected TokenShareResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
