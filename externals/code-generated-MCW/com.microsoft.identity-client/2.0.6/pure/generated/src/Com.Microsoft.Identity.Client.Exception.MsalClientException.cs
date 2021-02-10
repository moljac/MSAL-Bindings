using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/exception/MsalClientException", DoNotGenerateAcw=true)]
	public sealed partial class MsalClientException : global::Com.Microsoft.Identity.Client.Exception.MsalException {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='APP_MANIFEST_VALIDATION_ERROR']"
		[Register ("APP_MANIFEST_VALIDATION_ERROR")]
		public const string AppManifestValidationError = (string) "app_manifest_validation_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='AUTHORITY_VALIDATION_NOT_SUPPORTED']"
		[Register ("AUTHORITY_VALIDATION_NOT_SUPPORTED")]
		public const string AuthorityValidationNotSupported = (string) "authority_validation_not_supported";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='BROKER_BIND_FAILURE']"
		[Register ("BROKER_BIND_FAILURE")]
		public const string BrokerBindFailure = (string) "Failed to bind the service in broker app";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='BROKER_NOT_INSTALLED']"
		[Register ("BROKER_NOT_INSTALLED")]
		public const string BrokerNotInstalled = (string) "broker_not_installed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='CHROME_NOT_INSTALLED']"
		[Register ("CHROME_NOT_INSTALLED")]
		public const string ChromeNotInstalled = (string) "chrome_not_installed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='CURRENT_ACCOUNT_MISMATCH']"
		[Register ("CURRENT_ACCOUNT_MISMATCH")]
		public const string CurrentAccountMismatch = (string) "current_account_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='CURRENT_ACCOUNT_MISMATCH_ERROR_MESSAGE']"
		[Register ("CURRENT_ACCOUNT_MISMATCH_ERROR_MESSAGE")]
		public const string CurrentAccountMismatchErrorMessage = (string) "The signed in account does not match with the provided account.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='DEVICE_NETWORK_NOT_AVAILABLE']"
		[Register ("DEVICE_NETWORK_NOT_AVAILABLE")]
		public const string DeviceNetworkNotAvailable = (string) "device_network_not_available";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='DUPLICATE_COMMAND']"
		[Register ("DUPLICATE_COMMAND")]
		public const string DuplicateCommand = (string) "duplicate_command";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='DUPLICATE_QUERY_PARAMETER']"
		[Register ("DUPLICATE_QUERY_PARAMETER")]
		public const string DuplicateQueryParameter = (string) "duplicate_query_parameter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='INVALID_JWT']"
		[Register ("INVALID_JWT")]
		public const string InvalidJwt = (string) "invalid_jwt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='INVALID_PARAMETER']"
		[Register ("INVALID_PARAMETER")]
		public const string InvalidParameter = (string) "invalid_parameter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='IO_ERROR']"
		[Register ("IO_ERROR")]
		public const string IoError = (string) "io_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='JSON_PARSE_FAILURE']"
		[Register ("JSON_PARSE_FAILURE")]
		public const string JsonParseFailure = (string) "json_parse_failure";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='MALFORMED_URL']"
		[Register ("MALFORMED_URL")]
		public const string MalformedUrl = (string) "malformed_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='MULTIPLE_MATCHING_TOKENS_DETECTED']"
		[Register ("MULTIPLE_MATCHING_TOKENS_DETECTED")]
		public const string MultipleMatchingTokensDetected = (string) "multiple_matching_tokens_detected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='NOT_ELIGIBLE_TO_USE_BROKER']"
		[Register ("NOT_ELIGIBLE_TO_USE_BROKER")]
		public const string NotEligibleToUseBroker = (string) "not_eligible_to_use_broker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='NO_CURRENT_ACCOUNT']"
		[Register ("NO_CURRENT_ACCOUNT")]
		public const string NoCurrentAccount = (string) "no_current_account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='NO_CURRENT_ACCOUNT_ERROR_MESSAGE']"
		[Register ("NO_CURRENT_ACCOUNT_ERROR_MESSAGE")]
		public const string NoCurrentAccountErrorMessage = (string) "There is no signed in account.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='NO_SUCH_ALGORITHM']"
		[Register ("NO_SUCH_ALGORITHM")]
		public const string NoSuchAlgorithm = (string) "no_such_algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='REDIRECT_URI_VALIDATION_ERROR']"
		[Register ("REDIRECT_URI_VALIDATION_ERROR")]
		public const string RedirectUriValidationError = (string) "redirect_uri_validation_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='SAPCA_USE_WITH_MULTI_POLICY_B2C']"
		[Register ("SAPCA_USE_WITH_MULTI_POLICY_B2C")]
		public const string SapcaUseWithMultiPolicyB2c = (string) "SingleAccountPublicClientApplication cannot be used with multiple B2C policies.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='SCOPE_EMPTY_OR_NULL']"
		[Register ("SCOPE_EMPTY_OR_NULL")]
		public const string ScopeEmptyOrNull = (string) "scope_empty_or_null";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='STATE_MISMATCH']"
		[Register ("STATE_MISMATCH")]
		public const string StateMismatch = (string) "state_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='UNKNOWN_AUTHORITY']"
		[Register ("UNKNOWN_AUTHORITY")]
		public const string UnknownAuthority = (string) "unknown_authority";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const string UnknownError = (string) "unknown_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='UNSUPPORTED_ENCODING']"
		[Register ("UNSUPPORTED_ENCODING")]
		public const string UnsupportedEncoding = (string) "unsupported_encoding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='UNSUPPORTED_URL']"
		[Register ("UNSUPPORTED_URL")]
		public const string UnsupportedUrl = (string) "unsupported_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/field[@name='USER_MISMATCH']"
		[Register ("USER_MISMATCH")]
		public const string UserMismatch = (string) "user_mismatch";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/exception/MsalClientException", typeof (MsalClientException));

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

		internal MsalClientException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/constructor[@name='MsalClientException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MsalClientException (string errorCode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errorCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/constructor[@name='MsalClientException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MsalClientException (string errorCode, string errorMessage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalClientException']/constructor[@name='MsalClientException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MsalClientException (string errorCode, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (throwable);
			}
		}

	}
}
