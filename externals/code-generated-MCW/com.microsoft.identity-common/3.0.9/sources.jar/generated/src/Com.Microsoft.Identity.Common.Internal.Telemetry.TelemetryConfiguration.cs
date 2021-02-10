using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryConfiguration", DoNotGenerateAcw=true)]
	public partial class TelemetryConfiguration : global::Java.Lang.Object, global::Java.IO.ISerializable {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryConfiguration$SerializedNames", DoNotGenerateAcw=true)]
		public sealed partial class SerializedNames : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration.SerializedNames']/field[@name='DEBUG_ENABLED']"
			[Register ("DEBUG_ENABLED")]
			public const string DebugEnabled = (string) "debug_enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration.SerializedNames']/field[@name='NOTIFY_ON_FAILTURE_ONLY']"
			[Register ("NOTIFY_ON_FAILTURE_ONLY")]
			public const string NotifyOnFailtureOnly = (string) "notify_on_failure_only";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration.SerializedNames']/field[@name='PII_ENABLED']"
			[Register ("PII_ENABLED")]
			public const string PiiEnabled = (string) "pii_enabled";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryConfiguration$SerializedNames", typeof (SerializedNames));

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

			internal SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration.SerializedNames']/constructor[@name='TelemetryConfiguration.SerializedNames' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SerializedNames () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryConfiguration", typeof (TelemetryConfiguration));

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

		protected TelemetryConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/constructor[@name='TelemetryConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TelemetryConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isDebugEnabled;
#pragma warning disable 0169
		static Delegate GetIsDebugEnabledHandler ()
		{
			if (cb_isDebugEnabled == null)
				cb_isDebugEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDebugEnabled);
			return cb_isDebugEnabled;
		}

		static bool n_IsDebugEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DebugEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDebugEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugEnabled_ZHandler ()
		{
			if (cb_setDebugEnabled_Z == null)
				cb_setDebugEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDebugEnabled_Z);
			return cb_setDebugEnabled_Z;
		}

		static void n_SetDebugEnabled_Z (IntPtr jnienv, IntPtr native__this, bool debugEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DebugEnabled = debugEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/method[@name='isDebugEnabled' and count(parameter)=0]"
			[Register ("isDebugEnabled", "()Z", "GetIsDebugEnabledHandler")]
			get {
				const string __id = "isDebugEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/method[@name='setDebugEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugEnabled", "(Z)V", "GetSetDebugEnabled_ZHandler")]
			set {
				const string __id = "setDebugEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isPiiEnabled;
#pragma warning disable 0169
		static Delegate GetIsPiiEnabledHandler ()
		{
			if (cb_isPiiEnabled == null)
				cb_isPiiEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPiiEnabled);
			return cb_isPiiEnabled;
		}

		static bool n_IsPiiEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PiiEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setPiiEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetPiiEnabled_ZHandler ()
		{
			if (cb_setPiiEnabled_Z == null)
				cb_setPiiEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPiiEnabled_Z);
			return cb_setPiiEnabled_Z;
		}

		static void n_SetPiiEnabled_Z (IntPtr jnienv, IntPtr native__this, bool piiEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PiiEnabled = piiEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool PiiEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/method[@name='isPiiEnabled' and count(parameter)=0]"
			[Register ("isPiiEnabled", "()Z", "GetIsPiiEnabledHandler")]
			get {
				const string __id = "isPiiEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/method[@name='setPiiEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPiiEnabled", "(Z)V", "GetSetPiiEnabled_ZHandler")]
			set {
				const string __id = "setPiiEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setNotifyOnFailureOnly_Z;
#pragma warning disable 0169
		static Delegate GetSetNotifyOnFailureOnly_ZHandler ()
		{
			if (cb_setNotifyOnFailureOnly_Z == null)
				cb_setNotifyOnFailureOnly_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNotifyOnFailureOnly_Z);
			return cb_setNotifyOnFailureOnly_Z;
		}

		static void n_SetNotifyOnFailureOnly_Z (IntPtr jnienv, IntPtr native__this, bool notifyOnFailureOnly)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNotifyOnFailureOnly (notifyOnFailureOnly);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/method[@name='setNotifyOnFailureOnly' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNotifyOnFailureOnly", "(Z)V", "GetSetNotifyOnFailureOnly_ZHandler")]
		public virtual unsafe void SetNotifyOnFailureOnly (bool notifyOnFailureOnly)
		{
			const string __id = "setNotifyOnFailureOnly.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (notifyOnFailureOnly);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldNotifyOnFailureOnly;
#pragma warning disable 0169
		static Delegate GetShouldNotifyOnFailureOnlyHandler ()
		{
			if (cb_shouldNotifyOnFailureOnly == null)
				cb_shouldNotifyOnFailureOnly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldNotifyOnFailureOnly);
			return cb_shouldNotifyOnFailureOnly;
		}

		static bool n_ShouldNotifyOnFailureOnly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldNotifyOnFailureOnly ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryConfiguration']/method[@name='shouldNotifyOnFailureOnly' and count(parameter)=0]"
		[Register ("shouldNotifyOnFailureOnly", "()Z", "GetShouldNotifyOnFailureOnlyHandler")]
		public virtual unsafe bool ShouldNotifyOnFailureOnly ()
		{
			const string __id = "shouldNotifyOnFailureOnly.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
