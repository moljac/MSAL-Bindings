using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/SchemaConstants", DoNotGenerateAcw=true)]
	public partial class SchemaConstants : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='CURRENT_REQUEST_HEADER_NAME']"
		[Register ("CURRENT_REQUEST_HEADER_NAME")]
		public const string CurrentRequestHeaderName = (string) "x-client-current-telemetry";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='CURRENT_SCHEMA_VERSION']"
		[Register ("CURRENT_SCHEMA_VERSION")]
		public const string CurrentSchemaVersion = (string) "2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='HEADER_DATA_LIMIT']"
		[Register ("HEADER_DATA_LIMIT")]
		public const int HeaderDataLimit = (int) 3800;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='LAST_REQUEST_HEADER_NAME']"
		[Register ("LAST_REQUEST_HEADER_NAME")]
		public const string LastRequestHeaderName = (string) "x-client-last-telemetry";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='SCHEMA_VERSION_KEY']"
		[Register ("SCHEMA_VERSION_KEY")]
		public const string SchemaVersionKey = (string) "schema_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='SEPARATOR_COMMA']"
		[Register ("SEPARATOR_COMMA")]
		public const string SeparatorComma = (string) ",";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/field[@name='SEPARATOR_PIPE']"
		[Register ("SEPARATOR_PIPE")]
		public const string SeparatorPipe = (string) "|";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/SchemaConstants$Key", DoNotGenerateAcw=true)]
		public sealed partial class Key : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='ACCOUNT_STATUS']"
			[Register ("ACCOUNT_STATUS")]
			public const string AccountStatus = (string) "Microsoft.MSAL.account_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='ALL_TELEMETRY_DATA_SENT']"
			[Register ("ALL_TELEMETRY_DATA_SENT")]
			public const string AllTelemetryDataSent = (string) "is_all_telemetry_data_sent";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='API_ID']"
			[Register ("API_ID")]
			public const string ApiId = (string) "Microsoft.MSAL.api_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='AT_STATUS']"
			[Register ("AT_STATUS")]
			public const string AtStatus = (string) "Microsoft.MSAL.at_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='CORRELATION_ID']"
			[Register ("CORRELATION_ID")]
			public const string CorrelationId = (string) "Microsoft.MSAL.correlation_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='ERROR_CODE']"
			[Register ("ERROR_CODE")]
			public const string ErrorCode = (string) "Microsoft.MSAL.api_error_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='FORCE_REFRESH']"
			[Register ("FORCE_REFRESH")]
			public const string ForceRefresh = (string) "Microsoft.MSAL.force_refresh";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='FRT_STATUS']"
			[Register ("FRT_STATUS")]
			public const string FrtStatus = (string) "Microsoft.MSAL.frt_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='ID_TOKEN_STATUS']"
			[Register ("ID_TOKEN_STATUS")]
			public const string IdTokenStatus = (string) "Microsoft.MSAL.id_token_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='MRRT_STATUS']"
			[Register ("MRRT_STATUS")]
			public const string MrrtStatus = (string) "Microsoft.MSAL.mrrt_status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/field[@name='RT_STATUS']"
			[Register ("RT_STATUS")]
			public const string RtStatus = (string) "Microsoft.MSAL.rt_status";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/SchemaConstants$Key", typeof (Key));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Key']/constructor[@name='SchemaConstants.Key' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Value']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/SchemaConstants$Value", DoNotGenerateAcw=true)]
		public sealed partial class Value : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Value']/field[@name='EMPTY']"
			[Register ("EMPTY")]
			public const string Empty = (string) "";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Value']/field[@name='FALSE']"
			[Register ("FALSE")]
			public const string False = (string) "0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Value']/field[@name='TRUE']"
			[Register ("TRUE")]
			public const string True = (string) "1";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/SchemaConstants$Value", typeof (Value));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants.Value']/constructor[@name='SchemaConstants.Value' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/SchemaConstants", typeof (SchemaConstants));

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

		protected SchemaConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='SchemaConstants']/constructor[@name='SchemaConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SchemaConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
