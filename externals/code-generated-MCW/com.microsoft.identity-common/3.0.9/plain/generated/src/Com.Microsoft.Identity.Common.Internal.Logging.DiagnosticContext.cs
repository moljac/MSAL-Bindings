using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='DiagnosticContext']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/logging/DiagnosticContext", DoNotGenerateAcw=true)]
	public sealed partial class DiagnosticContext : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='DiagnosticContext']/field[@name='CORRELATION_ID']"
		[Register ("CORRELATION_ID")]
		public const string CorrelationId = (string) "correlation_id";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/logging/DiagnosticContext", typeof (DiagnosticContext));

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

		internal DiagnosticContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext RequestContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='DiagnosticContext']/method[@name='getRequestContext' and count(parameter)=0]"
			[Register ("getRequestContext", "()Lcom/microsoft/identity/common/internal/logging/IRequestContext;", "")]
			get {
				const string __id = "getRequestContext.()Lcom/microsoft/identity/common/internal/logging/IRequestContext;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.IRequestContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='DiagnosticContext']/method[@name='setRequestContext' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.logging.IRequestContext']]"
			[Register ("setRequestContext", "(Lcom/microsoft/identity/common/internal/logging/IRequestContext;)V", "")]
			set {
				const string __id = "setRequestContext.(Lcom/microsoft/identity/common/internal/logging/IRequestContext;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='DiagnosticContext']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public static unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
