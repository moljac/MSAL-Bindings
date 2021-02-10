using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryAggregationRules']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/rules/TelemetryAggregationRules", DoNotGenerateAcw=true)]
	public partial class TelemetryAggregationRules : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/rules/TelemetryAggregationRules", typeof (TelemetryAggregationRules));

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

		protected TelemetryAggregationRules (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Rules.TelemetryAggregationRules Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryAggregationRules']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/internal/telemetry/rules/TelemetryAggregationRules;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/internal/telemetry/rules/TelemetryAggregationRules;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Rules.TelemetryAggregationRules> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRedundant_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsRedundant_Ljava_lang_String_Handler ()
		{
			if (cb_isRedundant_Ljava_lang_String_ == null)
				cb_isRedundant_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsRedundant_Ljava_lang_String_);
			return cb_isRedundant_Ljava_lang_String_;
		}

		static bool n_IsRedundant_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_propertyName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Rules.TelemetryAggregationRules> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var propertyName = JNIEnv.GetString (native_propertyName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRedundant (propertyName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.rules']/class[@name='TelemetryAggregationRules']/method[@name='isRedundant' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isRedundant", "(Ljava/lang/String;)Z", "GetIsRedundant_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsRedundant (string propertyName)
		{
			const string __id = "isRedundant.(Ljava/lang/String;)Z";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_propertyName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

	}
}
