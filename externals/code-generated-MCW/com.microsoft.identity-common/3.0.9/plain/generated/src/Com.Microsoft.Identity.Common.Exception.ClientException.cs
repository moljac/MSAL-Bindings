using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/ClientException", DoNotGenerateAcw=true)]
	public partial class ClientException : global::Com.Microsoft.Identity.Common.Exception.BaseException {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='ACCESS_DENIED']"
		[Register ("ACCESS_DENIED")]
		public const string AccessDenied = (string) "access_denied";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='ACCOUNT_MANAGER_OPERATION_ERROR']"
		[Register ("ACCOUNT_MANAGER_OPERATION_ERROR")]
		public const string AccountManagerOperationError = (string) "account_manager_operation_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='ACCOUNT_NOT_FOUND']"
		[Register ("ACCOUNT_NOT_FOUND")]
		public const string AccountNotFound = (string) "account_not_found";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='ANDROID_KEYSTORE_UNAVAILABLE']"
		[Register ("ANDROID_KEYSTORE_UNAVAILABLE")]
		public const string AndroidKeystoreUnavailable = (string) "android_keystore_unavailable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='AUTHORITY_VALIDATION_NOT_SUPPORTED']"
		[Register ("AUTHORITY_VALIDATION_NOT_SUPPORTED")]
		public const string AuthorityValidationNotSupported = (string) "authority_validation_not_supported";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='AUTH_SCHEME_MISMATCH']"
		[Register ("AUTH_SCHEME_MISMATCH")]
		public const string AuthSchemeMismatch = (string) "auth_scheme_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='BAD_KEY_SIZE']"
		[Register ("BAD_KEY_SIZE")]
		public const string BadKeySize = (string) "keystore_produced_invalid_cert";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='BOUND_SERVICE_UNAVAILABLE_OR_NOT_SUPPORTED']"
		[Register ("BOUND_SERVICE_UNAVAILABLE_OR_NOT_SUPPORTED")]
		public const string BoundServiceUnavailableOrNotSupported = (string) "bound_service_unavaliable_or_not_supported";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='BRT_TENANT_MISMATCH']"
		[Register ("BRT_TENANT_MISMATCH")]
		public const string BrtTenantMismatch = (string) "brt_tenant_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='CERTIFICATE_LOAD_FAILURE']"
		[Register ("CERTIFICATE_LOAD_FAILURE")]
		public const string CertificateLoadFailure = (string) "certificate_load_failure";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='CHROME_NOT_INSTALLED']"
		[Register ("CHROME_NOT_INSTALLED")]
		public const string ChromeNotInstalled = (string) "chrome_not_installed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='DEVICE_NETWORK_NOT_AVAILABLE']"
		[Register ("DEVICE_NETWORK_NOT_AVAILABLE")]
		public const string DeviceNetworkNotAvailable = (string) "device_network_not_available";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='DUPLICATE_COMMAND']"
		[Register ("DUPLICATE_COMMAND")]
		public const string DuplicateCommand = (string) "duplicate_command";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='DUPLICATE_QUERY_PARAMETER']"
		[Register ("DUPLICATE_QUERY_PARAMETER")]
		public const string DuplicateQueryParameter = (string) "duplicate_query_parameter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INTERRUPTED_OPERATION']"
		[Register ("INTERRUPTED_OPERATION")]
		public const string InterruptedOperation = (string) "operation_interrupted";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INVALID_ALG']"
		[Register ("INVALID_ALG")]
		public const string InvalidAlg = (string) "keystore_initialization_failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INVALID_BROKER_BUNDLE']"
		[Register ("INVALID_BROKER_BUNDLE")]
		public const string InvalidBrokerBundle = (string) "invalid_broker_bundle";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INVALID_JWT']"
		[Register ("INVALID_JWT")]
		public const string InvalidJwt = (string) "invalid_jwt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INVALID_KEY']"
		[Register ("INVALID_KEY")]
		public const string InvalidKey = (string) "invalid_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INVALID_KEY_MISSING']"
		[Register ("INVALID_KEY_MISSING")]
		public const string InvalidKeyMissing = (string) "invalid_key_private_key_missing";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='INVALID_PROTECTION_PARAMS']"
		[Register ("INVALID_PROTECTION_PARAMS")]
		public const string InvalidProtectionParams = (string) "protection_params_invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='IO_ERROR']"
		[Register ("IO_ERROR")]
		public const string IoError = (string) "io_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='JSON_CONSTRUCTION_FAILED']"
		[Register ("JSON_CONSTRUCTION_FAILED")]
		public const string JsonConstructionFailed = (string) "json_construction_failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='JSON_PARSE_FAILURE']"
		[Register ("JSON_PARSE_FAILURE")]
		public const string JsonParseFailure = (string) "json_parse_failure";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='JWT_SIGNING_FAILURE']"
		[Register ("JWT_SIGNING_FAILURE")]
		public const string JwtSigningFailure = (string) "failed_to_sign_jwt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='KEYSTORE_NOT_INITIALIZED']"
		[Register ("KEYSTORE_NOT_INITIALIZED")]
		public const string KeystoreNotInitialized = (string) "keystore_not_initialized";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='MALFORMED_URL']"
		[Register ("MALFORMED_URL")]
		public const string MalformedUrl = (string) "malformed_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='MISSING_PARAMETER']"
		[Register ("MISSING_PARAMETER")]
		public const string MissingParameter = (string) "missing_parameter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='MULTIPLE_MATCHING_TOKENS_DETECTED']"
		[Register ("MULTIPLE_MATCHING_TOKENS_DETECTED")]
		public const string MultipleMatchingTokensDetected = (string) "multiple_matching_tokens_detected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='NO_SUCH_ALGORITHM']"
		[Register ("NO_SUCH_ALGORITHM")]
		public const string NoSuchAlgorithm = (string) "no_such_algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='NO_SUCH_PADDING']"
		[Register ("NO_SUCH_PADDING")]
		public const string NoSuchPadding = (string) "no_such_padding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='SCOPE_EMPTY_OR_NULL']"
		[Register ("SCOPE_EMPTY_OR_NULL")]
		public const string ScopeEmptyOrNull = (string) "scope_empty_or_null";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='SIGNING_FAILURE']"
		[Register ("SIGNING_FAILURE")]
		public const string SigningFailure = (string) "failed_to_sign";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='STATE_MISMATCH']"
		[Register ("STATE_MISMATCH")]
		public const string StateMismatch = (string) "state_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='THUMBPRINT_COMPUTATION_FAILURE']"
		[Register ("THUMBPRINT_COMPUTATION_FAILURE")]
		public const string ThumbprintComputationFailure = (string) "failed_to_compute_thumbprint_with_sha256";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='TOKEN_CACHE_ITEM_NOT_FOUND']"
		[Register ("TOKEN_CACHE_ITEM_NOT_FOUND")]
		public const string TokenCacheItemNotFound = (string) "token_cache_item_not_found";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='TOKEN_SHARING_DESERIALIZATION_ERROR']"
		[Register ("TOKEN_SHARING_DESERIALIZATION_ERROR")]
		public const string TokenSharingDeserializationError = (string) "token_sharing_deserialization_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='TOKEN_SHARING_MSA_PERSISTENCE_ERROR']"
		[Register ("TOKEN_SHARING_MSA_PERSISTENCE_ERROR")]
		public const string TokenSharingMsaPersistenceError = (string) "failed_to_persist_msa_credential";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='UNKNOWN_AUTHORITY']"
		[Register ("UNKNOWN_AUTHORITY")]
		public const string UnknownAuthority = (string) "unknown_authority";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const string UnknownError = (string) "unknown_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='UNKNOWN_EXPORT_FORMAT']"
		[Register ("UNKNOWN_EXPORT_FORMAT")]
		public const string UnknownExportFormat = (string) "unknown_public_key_export_format";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='UNSUPPORTED_ENCODING']"
		[Register ("UNSUPPORTED_ENCODING")]
		public const string UnsupportedEncoding = (string) "unsupported_encoding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='UNSUPPORTED_URL']"
		[Register ("UNSUPPORTED_URL")]
		public const string UnsupportedUrl = (string) "unsupported_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='USER_MISMATCH']"
		[Register ("USER_MISMATCH")]
		public const string UserMismatch = (string) "user_mismatch";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/field[@name='sName']"
		[Register ("sName")]
		public static string SName {
			get {
				const string __id = "sName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/ClientException", typeof (ClientException));

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

		protected ClientException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/constructor[@name='ClientException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ClientException (string errorCode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/constructor[@name='ClientException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ClientException (string errorCode, string errorMessage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ClientException']/constructor[@name='ClientException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe ClientException (string errorCode, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
