using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='LastRequestTelemetry']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/LastRequestTelemetry", DoNotGenerateAcw=true)]
	public partial class LastRequestTelemetry : global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/LastRequestTelemetry", typeof (LastRequestTelemetry));

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

		protected LastRequestTelemetry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getHeaderStringForFields;
#pragma warning disable 0169
		static Delegate GetGetHeaderStringForFieldsHandler ()
		{
			if (cb_getHeaderStringForFields == null)
				cb_getHeaderStringForFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeaderStringForFields);
			return cb_getHeaderStringForFields;
		}

		static IntPtr n_GetHeaderStringForFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.LastRequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderStringForFields);
		}
#pragma warning restore 0169

		public override unsafe string HeaderStringForFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='LastRequestTelemetry']/method[@name='getHeaderStringForFields' and count(parameter)=0]"
			[Register ("getHeaderStringForFields", "()Ljava/lang/String;", "GetGetHeaderStringForFieldsHandler")]
			get {
				const string __id = "getHeaderStringForFields.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
