using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings", DoNotGenerateAcw=true)]
	public sealed partial class TelemetryEventStrings : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Api", DoNotGenerateAcw=true)]
		public sealed partial class Api : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_ACQUIRE_TOKEN_INTERACTIVE']"
			[Register ("BROKER_ACQUIRE_TOKEN_INTERACTIVE")]
			public const string BrokerAcquireTokenInteractive = (string) "201";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_ACQUIRE_TOKEN_SILENT']"
			[Register ("BROKER_ACQUIRE_TOKEN_SILENT")]
			public const string BrokerAcquireTokenSilent = (string) "203";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_COMPLETE_ACQUIRE_TOKEN_INTERACTIVE']"
			[Register ("BROKER_COMPLETE_ACQUIRE_TOKEN_INTERACTIVE")]
			public const string BrokerCompleteAcquireTokenInteractive = (string) "202";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_GET_ACCOUNTS']"
			[Register ("BROKER_GET_ACCOUNTS")]
			public const string BrokerGetAccounts = (string) "206";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_GET_CURRENT_ACCOUNT']"
			[Register ("BROKER_GET_CURRENT_ACCOUNT")]
			public const string BrokerGetCurrentAccount = (string) "205";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_REMOVE_ACCOUNT']"
			[Register ("BROKER_REMOVE_ACCOUNT")]
			public const string BrokerRemoveAccount = (string) "207";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='BROKER_REMOVE_ACCOUNT_FROM_SHARED_DEVICE']"
			[Register ("BROKER_REMOVE_ACCOUNT_FROM_SHARED_DEVICE")]
			public const string BrokerRemoveAccountFromSharedDevice = (string) "208";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='GET_BROKER_DEVICE_MODE']"
			[Register ("GET_BROKER_DEVICE_MODE")]
			public const string GetBrokerDeviceMode = (string) "204";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_ACQUIRE_TOKEN_INTERACTIVE']"
			[Register ("LOCAL_ACQUIRE_TOKEN_INTERACTIVE")]
			public const string LocalAcquireTokenInteractive = (string) "101";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_ACQUIRE_TOKEN_SILENT']"
			[Register ("LOCAL_ACQUIRE_TOKEN_SILENT")]
			public const string LocalAcquireTokenSilent = (string) "103";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_COMPLETE_ACQUIRE_TOKEN_INTERACTIVE']"
			[Register ("LOCAL_COMPLETE_ACQUIRE_TOKEN_INTERACTIVE")]
			public const string LocalCompleteAcquireTokenInteractive = (string) "1032";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_DEVICE_CODE_FLOW_ACQUIRE_URL_AND_CODE']"
			[Register ("LOCAL_DEVICE_CODE_FLOW_ACQUIRE_URL_AND_CODE")]
			public const string LocalDeviceCodeFlowAcquireUrlAndCode = (string) "108";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_DEVICE_CODE_FLOW_POLLING']"
			[Register ("LOCAL_DEVICE_CODE_FLOW_POLLING")]
			public const string LocalDeviceCodeFlowPolling = (string) "109";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_GET_ACCOUNTS']"
			[Register ("LOCAL_GET_ACCOUNTS")]
			public const string LocalGetAccounts = (string) "106";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/field[@name='LOCAL_REMOVE_ACCOUNT']"
			[Register ("LOCAL_REMOVE_ACCOUNT")]
			public const string LocalRemoveAccount = (string) "107";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Api", typeof (Api));

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

			internal Api (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Api']/constructor[@name='TelemetryEventStrings.Api' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Api () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.App']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$App", DoNotGenerateAcw=true)]
		public sealed partial class App : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.App']/field[@name='BUILD']"
			[Register ("BUILD")]
			public const string Build = (string) "Microsoft.MSAL.application_build";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.App']/field[@name='NAME']"
			[Register ("NAME")]
			public const string Name = (string) "Microsoft.MSAL.application_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.App']/field[@name='VERSION']"
			[Register ("VERSION")]
			public const string Version = (string) "Microsoft.MSAL.application_version";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$App", typeof (App));

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

			internal App (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.App']/constructor[@name='TelemetryEventStrings.App' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe App () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Device", DoNotGenerateAcw=true)]
		public sealed partial class Device : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']/field[@name='ID']"
			[Register ("ID")]
			public const string Id = (string) "Microsoft.MSAL.device_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']/field[@name='MANUFACTURER']"
			[Register ("MANUFACTURER")]
			public const string Manufacturer = (string) "Microsoft.MSAL.device_manufacturer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']/field[@name='MODEL']"
			[Register ("MODEL")]
			public const string Model = (string) "Microsoft.MSAL.device_model";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']/field[@name='NAME']"
			[Register ("NAME")]
			public const string Name = (string) "Microsoft.MSAL.device_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']/field[@name='TIMEZONE']"
			[Register ("TIMEZONE")]
			public const string Timezone = (string) "Microsoft.MSAL.time_zone";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Device", typeof (Device));

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

			internal Device (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Device']/constructor[@name='TelemetryEventStrings.Device' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Device () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Event", DoNotGenerateAcw=true)]
		public sealed partial class Event : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='API_END_EVENT']"
			[Register ("API_END_EVENT")]
			public const string ApiEndEvent = (string) "api_end_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='API_START_EVENT']"
			[Register ("API_START_EVENT")]
			public const string ApiStartEvent = (string) "api_start_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='BROKER_END_EVENT']"
			[Register ("BROKER_END_EVENT")]
			public const string BrokerEndEvent = (string) "broker_end_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='BROKER_START_EVENT']"
			[Register ("BROKER_START_EVENT")]
			public const string BrokerStartEvent = (string) "broker_start_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='CACHE_END_EVENT']"
			[Register ("CACHE_END_EVENT")]
			public const string CacheEndEvent = (string) "cache_end_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='CACHE_START_EVENT']"
			[Register ("CACHE_START_EVENT")]
			public const string CacheStartEvent = (string) "cache_start_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='HTTP_END_EVENT']"
			[Register ("HTTP_END_EVENT")]
			public const string HttpEndEvent = (string) "http_end_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='HTTP_START_EVENT']"
			[Register ("HTTP_START_EVENT")]
			public const string HttpStartEvent = (string) "http_start_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='UI_END_EVENT']"
			[Register ("UI_END_EVENT")]
			public const string UiEndEvent = (string) "ui_end_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/field[@name='UI_START_EVENT']"
			[Register ("UI_START_EVENT")]
			public const string UiStartEvent = (string) "ui_start_event";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Event", typeof (Event));

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

			internal Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Event']/constructor[@name='TelemetryEventStrings.Event' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Event () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$EventType", DoNotGenerateAcw=true)]
		public sealed partial class EventType : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']/field[@name='API_EVENT']"
			[Register ("API_EVENT")]
			public const string ApiEvent = (string) "Microsoft.MSAL.api_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']/field[@name='BROKER_EVENT']"
			[Register ("BROKER_EVENT")]
			public const string BrokerEvent = (string) "Microsoft.MSAL.broker_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']/field[@name='CACHE_EVENT']"
			[Register ("CACHE_EVENT")]
			public const string CacheEvent = (string) "Microsoft.MSAL.cache_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']/field[@name='HTTP_EVENT']"
			[Register ("HTTP_EVENT")]
			public const string HttpEvent = (string) "Microsoft.MSAL.http_event";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']/field[@name='UI_EVENT']"
			[Register ("UI_EVENT")]
			public const string UiEvent = (string) "Microsoft.MSAL.ui_event";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$EventType", typeof (EventType));

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

			internal EventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.EventType']/constructor[@name='TelemetryEventStrings.EventType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe EventType () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Key", DoNotGenerateAcw=true)]
		public sealed partial class Key : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='ACCOUNTS_NUMBER']"
			[Register ("ACCOUNTS_NUMBER")]
			public const string AccountsNumber = (string) "Microsoft.MSAL.accounts_number";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='ACCOUNT_STATUS']"
			[Register ("ACCOUNT_STATUS")]
			public const string AccountStatus = (string) "Microsoft.MSAL.account_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='API_ID']"
			[Register ("API_ID")]
			public const string ApiId = (string) "Microsoft.MSAL.api_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='AT_STATUS']"
			[Register ("AT_STATUS")]
			public const string AtStatus = (string) "Microsoft.MSAL.at_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='AUTHENTICATION_SCHEME']"
			[Register ("AUTHENTICATION_SCHEME")]
			public const string AuthenticationScheme = (string) "Microsoft.MSAL.authentication_scheme";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='AUTHORITY']"
			[Register ("AUTHORITY")]
			public const string Authority = (string) "Microsoft.MSAL.authority";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='AUTHORITY_NAME']"
			[Register ("AUTHORITY_NAME")]
			public const string AuthorityName = (string) "Microsoft.MSAL.authority_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='AUTHORITY_TYPE']"
			[Register ("AUTHORITY_TYPE")]
			public const string AuthorityType = (string) "Microsoft.MSAL.authority_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='AUTHORITY_VALIDATION_STATUS']"
			[Register ("AUTHORITY_VALIDATION_STATUS")]
			public const string AuthorityValidationStatus = (string) "Microsoft.MSAL.authority_validation_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='BROKER_ACTION']"
			[Register ("BROKER_ACTION")]
			public const string BrokerAction = (string) "Microsoft.MSAL.broker_action";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='BROKER_APP']"
			[Register ("BROKER_APP")]
			public const string BrokerApp = (string) "Microsoft.MSAL.broker_app";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='BROKER_APP_USED']"
			[Register ("BROKER_APP_USED")]
			public const string BrokerAppUsed = (string) "Microsoft.MSAL.broker_app_used";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='BROKER_PROTOCOL_VERSION']"
			[Register ("BROKER_PROTOCOL_VERSION")]
			public const string BrokerProtocolVersion = (string) "Microsoft.MSAL.broker_protocol_version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='BROKER_STRATEGY']"
			[Register ("BROKER_STRATEGY")]
			public const string BrokerStrategy = (string) "Microsoft.MSAL.broker_strategy";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='BROKER_VERSION']"
			[Register ("BROKER_VERSION")]
			public const string BrokerVersion = (string) "Microsoft.MSAL.broker_version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='CACHE_EVENT_COUNT']"
			[Register ("CACHE_EVENT_COUNT")]
			public const string CacheEventCount = (string) "Microsoft.MSAL.cache_event_count";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='CLAIM_REQUEST']"
			[Register ("CLAIM_REQUEST")]
			public const string ClaimRequest = (string) "Microsoft.MSAL.claim_request";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public const string ClientId = (string) "Microsoft.MSAL.client_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='CORRELATION_ID']"
			[Register ("CORRELATION_ID")]
			public const string CorrelationId = (string) "Microsoft.MSAL.correlation_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='END_TIME']"
			[Register ("END_TIME")]
			public const string EndTime = (string) "Microsoft.MSAL.stop_time";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='ERROR_CODE']"
			[Register ("ERROR_CODE")]
			public const string ErrorCode = (string) "Microsoft.MSAL.api_error_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='ERROR_DESCRIPTION']"
			[Register ("ERROR_DESCRIPTION")]
			public const string ErrorDescription = (string) "Microsoft.MSAL.error_description";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='ERROR_DOMAIN']"
			[Register ("ERROR_DOMAIN")]
			public const string ErrorDomain = (string) "Microsoft.MSAL.error_domain";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='EVENT_NAME']"
			[Register ("EVENT_NAME")]
			public const string EventName = (string) "Microsoft.MSAL.event_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='EVENT_TYPE']"
			[Register ("EVENT_TYPE")]
			public const string EventType = (string) "Microsoft.MSAL.event_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='EXTENDED_EXPIRES_ON_SETTING']"
			[Register ("EXTENDED_EXPIRES_ON_SETTING")]
			public const string ExtendedExpiresOnSetting = (string) "Microsoft.MSAL.extended_expires_on_setting";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='FRT_STATUS']"
			[Register ("FRT_STATUS")]
			public const string FrtStatus = (string) "Microsoft.MSAL.frt_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='GRANT_TYPE']"
			[Register ("GRANT_TYPE")]
			public const string GrantType = (string) "Microsoft.MSAL.grant_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='HTTP_ERROR_DOMAIN']"
			[Register ("HTTP_ERROR_DOMAIN")]
			public const string HttpErrorDomain = (string) "Microsoft.MSAL.http_error_domain";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='HTTP_EVENT_COUNT']"
			[Register ("HTTP_EVENT_COUNT")]
			public const string HttpEventCount = (string) "Microsoft.MSAL.http_event_count";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='HTTP_METHOD']"
			[Register ("HTTP_METHOD")]
			public const string HttpMethod = (string) "Microsoft.MSAL.method";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='HTTP_PATH']"
			[Register ("HTTP_PATH")]
			public const string HttpPath = (string) "Microsoft.MSAL.http_path";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='HTTP_REQUEST_ID_HEADER']"
			[Register ("HTTP_REQUEST_ID_HEADER")]
			public const string HttpRequestIdHeader = (string) "Microsoft.MSAL.x_ms_request_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='HTTP_RESPONSE_CODE']"
			[Register ("HTTP_RESPONSE_CODE")]
			public const string HttpResponseCode = (string) "Microsoft.MSAL.response_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IDP_NAME']"
			[Register ("IDP_NAME")]
			public const string IdpName = (string) "Microsoft.MSAL.idp";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='ID_TOKEN_STATUS']"
			[Register ("ID_TOKEN_STATUS")]
			public const string IdTokenStatus = (string) "Microsoft.MSAL.id_token_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_AT']"
			[Register ("IS_AT")]
			public const string IsAt = (string) "Microsoft.MSAL.is_at";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_DEVICE_SHARED']"
			[Register ("IS_DEVICE_SHARED")]
			public const string IsDeviceShared = (string) "Microsoft.MSAL.is_device_shared";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_FORCE_PROMPT']"
			[Register ("IS_FORCE_PROMPT")]
			public const string IsForcePrompt = (string) "Microsoft.MSAL.force_prompt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_FORCE_REFRESH']"
			[Register ("IS_FORCE_REFRESH")]
			public const string IsForceRefresh = (string) "Microsoft.MSAL.force_refresh";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_FRT']"
			[Register ("IS_FRT")]
			public const string IsFrt = (string) "Microsoft.MSAL.is_frt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_MRRT']"
			[Register ("IS_MRRT")]
			public const string IsMrrt = (string) "Microsoft.MSAL.is_mrrt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_RT']"
			[Register ("IS_RT")]
			public const string IsRt = (string) "Microsoft.MSAL.is_rt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='IS_SUCCESSFUL']"
			[Register ("IS_SUCCESSFUL")]
			public const string IsSuccessful = (string) "_is_successful";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='LOGIN_HINT']"
			[Register ("LOGIN_HINT")]
			public const string LoginHint = (string) "Microsoft.MSAL.login_hint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='MRRT_STATUS']"
			[Register ("MRRT_STATUS")]
			public const string MrrtStatus = (string) "Microsoft.MSAL.mrrt_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='NETWORK_CONNECTION']"
			[Register ("NETWORK_CONNECTION")]
			public const string NetworkConnection = (string) "Microsoft.MSAL.network_connection";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='NTLM_HANDLED']"
			[Register ("NTLM_HANDLED")]
			public const string NtlmHandled = (string) "Microsoft.MSAL.ntlm";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='OAUTH_ERROR_CODE']"
			[Register ("OAUTH_ERROR_CODE")]
			public const string OauthErrorCode = (string) "Microsoft.MSAL.oauth_error_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='OCCUR_TIME']"
			[Register ("OCCUR_TIME")]
			public const string OccurTime = (string) "Microsoft.MSAL.occur_time";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='POWER_OPTIMIZATION']"
			[Register ("POWER_OPTIMIZATION")]
			public const string PowerOptimization = (string) "Microsoft.MSAL.power_optimization";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='PROMPT_BEHAVIOR']"
			[Register ("PROMPT_BEHAVIOR")]
			public const string PromptBehavior = (string) "Microsoft.MSAL.prompt_behavior";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='REDIRECT_URI']"
			[Register ("REDIRECT_URI")]
			public const string RedirectUri = (string) "Microsoft.MSAL.redirect_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='REQUEST_CODE']"
			[Register ("REQUEST_CODE")]
			public const string RequestCode = (string) "Microsoft.MSAL.request_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='REQUEST_QUERY_PARAMS']"
			[Register ("REQUEST_QUERY_PARAMS")]
			public const string RequestQueryParams = (string) "Microsoft.MSAL.query_params";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='RESPONSE_TIME']"
			[Register ("RESPONSE_TIME")]
			public const string ResponseTime = (string) "response_time";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='RESULT_CODE']"
			[Register ("RESULT_CODE")]
			public const string ResultCode = (string) "Microsoft.MSAL.result_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='RT_AGE']"
			[Register ("RT_AGE")]
			public const string RtAge = (string) "Microsoft.MSAL.rt_age";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='RT_STATUS']"
			[Register ("RT_STATUS")]
			public const string RtStatus = (string) "Microsoft.MSAL.rt_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SCOPE']"
			[Register ("SCOPE")]
			public const string Scope = (string) "Microsoft.MSAL.scope_value";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SCOPE_SIZE']"
			[Register ("SCOPE_SIZE")]
			public const string ScopeSize = (string) "Microsoft.MSAL.scope_size";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SDK_NAME']"
			[Register ("SDK_NAME")]
			public const string SdkName = (string) "Microsoft.MSAL.sdk_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SDK_VERSION']"
			[Register ("SDK_VERSION")]
			public const string SdkVersion = (string) "Microsoft.MSAL.sdk_version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SERVER_ERROR_CODE']"
			[Register ("SERVER_ERROR_CODE")]
			public const string ServerErrorCode = (string) "Microsoft.MSAL.server_error_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SERVER_SUBERROR_CODE']"
			[Register ("SERVER_SUBERROR_CODE")]
			public const string ServerSuberrorCode = (string) "Microsoft.MSAL.server_sub_error_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SPE_INFO']"
			[Register ("SPE_INFO")]
			public const string SpeInfo = (string) "Microsoft.MSAL.spe_info";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='SPE_RING']"
			[Register ("SPE_RING")]
			public const string SpeRing = (string) "Microsoft.MSAL.spe_ring";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='START_TIME']"
			[Register ("START_TIME")]
			public const string StartTime = (string) "Microsoft.MSAL.start_time";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='TENANT_ID']"
			[Register ("TENANT_ID")]
			public const string TenantId = (string) "Microsoft.MSAL.tenant_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='TOKEN_TYPE']"
			[Register ("TOKEN_TYPE")]
			public const string TokenType = (string) "Microsoft.MSAL.token_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='UI_CANCELLED']"
			[Register ("UI_CANCELLED")]
			public const string UiCancelled = (string) "Microsoft.MSAL.ui_cancelled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='UI_COMPLETE']"
			[Register ("UI_COMPLETE")]
			public const string UiComplete = (string) "Microsoft.MSAL.ui_complete";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='UI_EVENT_COUNT']"
			[Register ("UI_EVENT_COUNT")]
			public const string UiEventCount = (string) "Microsoft.MSAL.ui_event_count";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='USER_AGENT']"
			[Register ("USER_AGENT")]
			public const string UserAgent = (string) "Microsoft.MSAL.user_agent";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='USER_CANCEL']"
			[Register ("USER_CANCEL")]
			public const string UserCancel = (string) "Microsoft.MSAL.user_cancel";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='USER_ID']"
			[Register ("USER_ID")]
			public const string UserId = (string) "Microsoft.MSAL.user_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='V1_ID_TOKEN_STATUS']"
			[Register ("V1_ID_TOKEN_STATUS")]
			public const string V1IdTokenStatus = (string) "Microsoft.MSAL.v1_id_token_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='WIPE_APP']"
			[Register ("WIPE_APP")]
			public const string WipeApp = (string) "Microsoft.MSAL.wipe_app";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/field[@name='WIPE_TIME']"
			[Register ("WIPE_TIME")]
			public const string WipeTime = (string) "Microsoft.MSAL.wipe_time";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Key", typeof (Key));

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

			internal Key (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Key']/constructor[@name='TelemetryEventStrings.Key' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Key () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Os']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Os", DoNotGenerateAcw=true)]
		public sealed partial class Os : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Os']/field[@name='NAME']"
			[Register ("NAME")]
			public const string Name = (string) "Microsoft.MSAL.os_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Os']/field[@name='OS_NAME']"
			[Register ("OS_NAME")]
			public const string OsName = (string) "android";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Os']/field[@name='SECURITY_PATCH']"
			[Register ("SECURITY_PATCH")]
			public const string SecurityPatch = (string) "Microsoft.MSAL.security_patch";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Os']/field[@name='VERSION']"
			[Register ("VERSION")]
			public const string Version = (string) "Microsoft.MSAL.os_version";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Os", typeof (Os));

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

			internal Os (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Os']/constructor[@name='TelemetryEventStrings.Os' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Os () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Value", DoNotGenerateAcw=true)]
		public sealed partial class Value : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='ACCESS_TOKEN']"
			[Register ("ACCESS_TOKEN")]
			public const string AccessToken = (string) "access_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='ACCOUNT_MANAGER']"
			[Register ("ACCOUNT_MANAGER")]
			public const string AccountManager = (string) "account_manager";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='ADFS_TOKEN']"
			[Register ("ADFS_TOKEN")]
			public const string AdfsToken = (string) "ADFS_access_token_refresh_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='AUTHORITY_AAD']"
			[Register ("AUTHORITY_AAD")]
			public const string AuthorityAad = (string) "aad";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='AUTHORITY_ADFS']"
			[Register ("AUTHORITY_ADFS")]
			public const string AuthorityAdfs = (string) "adfs";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='AUTHORITY_B2C']"
			[Register ("AUTHORITY_B2C")]
			public const string AuthorityB2c = (string) "b2c";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='BOUND_SERVICE']"
			[Register ("BOUND_SERVICE")]
			public const string BoundService = (string) "bound_service";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='BY_CODE']"
			[Register ("BY_CODE")]
			public const string ByCode = (string) "by_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='BY_REFRESH_TOKEN']"
			[Register ("BY_REFRESH_TOKEN")]
			public const string ByRefreshToken = (string) "by_refresh_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='CANCELLED']"
			[Register ("CANCELLED")]
			public const string Cancelled = (string) "cancelled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='CONTENT_PROVIDER']"
			[Register ("CONTENT_PROVIDER")]
			public const string ContentProvider = (string) "content_provider";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='FAILED']"
			[Register ("FAILED")]
			public const string Failed = (string) "failed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='FALSE']"
			[Register ("FALSE")]
			public const string False = (string) "false";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='FAMILY_REFRESH_TOKEN']"
			[Register ("FAMILY_REFRESH_TOKEN")]
			public const string FamilyRefreshToken = (string) "family_refresh_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='MULTI_RESOURCE_REFRESH_TOKEN']"
			[Register ("MULTI_RESOURCE_REFRESH_TOKEN")]
			public const string MultiResourceRefreshToken = (string) "multi_resource_refresh_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='NOT_FOUND']"
			[Register ("NOT_FOUND")]
			public const string NotFound = (string) "not_found";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='REFRESH_TOKEN']"
			[Register ("REFRESH_TOKEN")]
			public const string RefreshToken = (string) "refresh_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='SUCCEEDED']"
			[Register ("SUCCEEDED")]
			public const string Succeeded = (string) "succeeded";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='TRIED']"
			[Register ("TRIED")]
			public const string Tried = (string) "tried";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='TRUE']"
			[Register ("TRUE")]
			public const string True = (string) "true";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const string Unknown = (string) "unknown";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings$Value", typeof (Value));

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

			internal Value (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings.Value']/constructor[@name='TelemetryEventStrings.Value' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Value () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/TelemetryEventStrings", typeof (TelemetryEventStrings));

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

		internal TelemetryEventStrings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='TelemetryEventStrings']/constructor[@name='TelemetryEventStrings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TelemetryEventStrings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
}
