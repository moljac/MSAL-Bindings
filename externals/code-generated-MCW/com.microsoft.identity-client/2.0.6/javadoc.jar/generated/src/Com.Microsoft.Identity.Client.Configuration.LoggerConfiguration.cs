using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/configuration/LoggerConfiguration", DoNotGenerateAcw=true)]
	public partial class LoggerConfiguration : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/configuration/LoggerConfiguration$SerializedNames", DoNotGenerateAcw=true)]
		public sealed partial class SerializedNames : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration.SerializedNames']/field[@name='LOGCAT_ENABLED']"
			[Register ("LOGCAT_ENABLED")]
			public const string LogcatEnabled = (string) "logcat_enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration.SerializedNames']/field[@name='LOG_LEVEL']"
			[Register ("LOG_LEVEL")]
			public const string LogLevel = (string) "log_level";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration.SerializedNames']/field[@name='PII_ENABLED']"
			[Register ("PII_ENABLED")]
			public const string PiiEnabled = (string) "pii_enabled";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/configuration/LoggerConfiguration$SerializedNames", typeof (SerializedNames));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration.SerializedNames']/constructor[@name='LoggerConfiguration.SerializedNames' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/configuration/LoggerConfiguration", typeof (LoggerConfiguration));

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

		protected LoggerConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration']/constructor[@name='LoggerConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggerConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isLogcatEnabled;
#pragma warning disable 0169
		static Delegate GetIsLogcatEnabledHandler ()
		{
			if (cb_isLogcatEnabled == null)
				cb_isLogcatEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLogcatEnabled);
			return cb_isLogcatEnabled;
		}

		static bool n_IsLogcatEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.LoggerConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLogcatEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLogcatEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration']/method[@name='isLogcatEnabled' and count(parameter)=0]"
			[Register ("isLogcatEnabled", "()Z", "GetIsLogcatEnabledHandler")]
			get {
				const string __id = "isLogcatEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.LoggerConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPiiEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPiiEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration']/method[@name='isPiiEnabled' and count(parameter)=0]"
			[Register ("isPiiEnabled", "()Z", "GetIsPiiEnabledHandler")]
			get {
				const string __id = "isPiiEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLogLevel;
#pragma warning disable 0169
		static Delegate GetGetLogLevelHandler ()
		{
			if (cb_getLogLevel == null)
				cb_getLogLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogLevel);
			return cb_getLogLevel;
		}

		static IntPtr n_GetLogLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Configuration.LoggerConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LogLevel);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Logger.LogLevel LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.configuration']/class[@name='LoggerConfiguration']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lcom/microsoft/identity/client/Logger$LogLevel;", "GetGetLogLevelHandler")]
			get {
				const string __id = "getLogLevel.()Lcom/microsoft/identity/client/Logger$LogLevel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
