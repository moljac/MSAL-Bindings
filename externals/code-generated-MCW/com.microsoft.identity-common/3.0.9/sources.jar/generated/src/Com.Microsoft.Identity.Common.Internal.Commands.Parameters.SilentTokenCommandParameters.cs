using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands.Parameters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='SilentTokenCommandParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters", DoNotGenerateAcw=true)]
	public partial class SilentTokenCommandParameters : global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters", typeof (SilentTokenCommandParameters));

		internal static new IntPtr class_ref {
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

		protected SilentTokenCommandParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
