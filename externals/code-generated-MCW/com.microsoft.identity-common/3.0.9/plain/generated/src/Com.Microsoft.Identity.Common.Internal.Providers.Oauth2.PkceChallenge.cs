using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='PkceChallenge']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/PkceChallenge", DoNotGenerateAcw=true)]
	public sealed partial class PkceChallenge : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/PkceChallenge", typeof (PkceChallenge));

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

		internal PkceChallenge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string CodeChallenge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='PkceChallenge']/method[@name='getCodeChallenge' and count(parameter)=0]"
			[Register ("getCodeChallenge", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCodeChallenge.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CodeChallengeMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='PkceChallenge']/method[@name='getCodeChallengeMethod' and count(parameter)=0]"
			[Register ("getCodeChallengeMethod", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCodeChallengeMethod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CodeVerifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='PkceChallenge']/method[@name='getCodeVerifier' and count(parameter)=0]"
			[Register ("getCodeVerifier", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCodeVerifier.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='PkceChallenge']/method[@name='newPkceChallenge' and count(parameter)=0]"
		[Register ("newPkceChallenge", "()Lcom/microsoft/identity/common/internal/providers/oauth2/PkceChallenge;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.PkceChallenge NewPkceChallenge ()
		{
			const string __id = "newPkceChallenge.()Lcom/microsoft/identity/common/internal/providers/oauth2/PkceChallenge;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.PkceChallenge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
