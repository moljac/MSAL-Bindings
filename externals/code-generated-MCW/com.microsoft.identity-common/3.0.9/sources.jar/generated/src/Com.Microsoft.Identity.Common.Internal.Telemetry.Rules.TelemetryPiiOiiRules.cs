using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryPiiOiiRules']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/rules/TelemetryPiiOiiRules", DoNotGenerateAcw=true)]
	public sealed partial class TelemetryPiiOiiRules : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/rules/TelemetryPiiOiiRules", typeof (TelemetryPiiOiiRules));

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

		internal TelemetryPiiOiiRules (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Rules.TelemetryPiiOiiRules Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryPiiOiiRules']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/internal/telemetry/rules/TelemetryPiiOiiRules;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/internal/telemetry/rules/TelemetryPiiOiiRules;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Rules.TelemetryPiiOiiRules> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryPiiOiiRules']/method[@name='isOii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isOii", "(Ljava/lang/String;)Z", "")]
		public unsafe bool IsOii (string propertyName)
		{
			const string __id = "isOii.(Ljava/lang/String;)Z";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_propertyName);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryPiiOiiRules']/method[@name='isPii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPii", "(Ljava/lang/String;)Z", "")]
		public unsafe bool IsPii (string propertyName)
		{
			const string __id = "isPii.(Ljava/lang/String;)Z";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_propertyName);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryPiiOiiRules']/method[@name='isPiiOrOii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPiiOrOii", "(Ljava/lang/String;)Z", "")]
		public unsafe bool IsPiiOrOii (string propertyName)
		{
			const string __id = "isPiiOrOii.(Ljava/lang/String;)Z";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_propertyName);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

	}
}
