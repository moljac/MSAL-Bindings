using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/ErrorStrings", DoNotGenerateAcw=true)]
	public sealed partial class ErrorStrings : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='ACCESS_DENIED']"
		[Register ("ACCESS_DENIED")]
		public const string AccessDenied = (string) "access_denied";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='ACCOUNT_IS_SCHEMA_NONCOMPLIANT']"
		[Register ("ACCOUNT_IS_SCHEMA_NONCOMPLIANT")]
		public const string AccountIsSchemaNoncompliant = (string) "Account is missing schema-required fields.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='ANDROIDKEYSTORE_FAILED']"
		[Register ("ANDROIDKEYSTORE_FAILED")]
		public const string AndroidkeystoreFailed = (string) "android_keystore_failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='ANDROID_CONTEXT_IS_NULL']"
		[Register ("ANDROID_CONTEXT_IS_NULL")]
		public const string AndroidContextIsNull = (string) "Android Context is null.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='APP_PACKAGE_NAME_NOT_FOUND']"
		[Register ("APP_PACKAGE_NAME_NOT_FOUND")]
		public const string AppPackageNameNotFound = (string) "App package name is not found in the package manager";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='AUTHORITY_URL_NOT_VALID']"
		[Register ("AUTHORITY_URL_NOT_VALID")]
		public const string AuthorityUrlNotValid = (string) "authority_url_not_valid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='AUTHORITY_VALIDATION_NOT_SUPPORTED']"
		[Register ("AUTHORITY_VALIDATION_NOT_SUPPORTED")]
		public const string AuthorityValidationNotSupported = (string) "authority_validation_not_supported";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='AUTHORIZATION_INTENT_IS_NULL']"
		[Register ("AUTHORIZATION_INTENT_IS_NULL")]
		public const string AuthorizationIntentIsNull = (string) "Authorization intent is null.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='AUTH_REFRESH_FAILED']"
		[Register ("AUTH_REFRESH_FAILED")]
		public const string AuthRefreshFailed = (string) "Refresh token request failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BROKER_APP_NOT_RESPONDING']"
		[Register ("BROKER_APP_NOT_RESPONDING")]
		public const string BrokerAppNotResponding = (string) "Broker application is not responding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BROKER_APP_VERIFICATION_FAILED']"
		[Register ("BROKER_APP_VERIFICATION_FAILED")]
		public const string BrokerAppVerificationFailed = (string) "Calling app could not be verified";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BROKER_BIND_SERVICE_FAILED']"
		[Register ("BROKER_BIND_SERVICE_FAILED")]
		public const string BrokerBindServiceFailed = (string) "Failed to bind the service in broker app";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BROKER_PRT_REFRESH_FAILED']"
		[Register ("BROKER_PRT_REFRESH_FAILED")]
		public const string BrokerPrtRefreshFailed = (string) "Failed to refresh PRT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BROKER_REQUEST_CANCELLED']"
		[Register ("BROKER_REQUEST_CANCELLED")]
		public const string BrokerRequestCancelled = (string) "Broker request cancelled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BROKER_VERIFICATION_FAILED']"
		[Register ("BROKER_VERIFICATION_FAILED")]
		public const string BrokerVerificationFailed = (string) "Signature could not be verified";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BRT_TENANT_MISMATCH_ERROR_MESSAGE']"
		[Register ("BRT_TENANT_MISMATCH_ERROR_MESSAGE")]
		public const string BrtTenantMismatchErrorMessage = (string) "Requested account is from a different organization. Please make sure to use your organizational account. If that doesn\u2019t help, please return the device to your administrator.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='BRT_USER_MISMATCH_ERROR_MESSAGE']"
		[Register ("BRT_USER_MISMATCH_ERROR_MESSAGE")]
		public const string BrtUserMismatchErrorMessage = (string) "The signed in user doesn't match with the user this device is registered to.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='CERTIFICATE_ENCODING_ERROR']"
		[Register ("CERTIFICATE_ENCODING_ERROR")]
		public const string CertificateEncodingError = (string) "Certificate encoding is not generated";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='CHROME_NOT_INSTALLED']"
		[Register ("CHROME_NOT_INSTALLED")]
		public const string ChromeNotInstalled = (string) "chrome_not_installed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='CREDENTIAL_IS_SCHEMA_NONCOMPLIANT']"
		[Register ("CREDENTIAL_IS_SCHEMA_NONCOMPLIANT")]
		public const string CredentialIsSchemaNoncompliant = (string) "Credential is missing schema-required fields.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DECLINED_SCOPE_ERROR_CODE']"
		[Register ("DECLINED_SCOPE_ERROR_CODE")]
		public const string DeclinedScopeErrorCode = (string) "declined_scope_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DECLINED_SCOPE_ERROR_MESSAGE']"
		[Register ("DECLINED_SCOPE_ERROR_MESSAGE")]
		public const string DeclinedScopeErrorMessage = (string) "Some or all requested scopes have been declined by the Server";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DECRYPTION_ERROR']"
		[Register ("DECRYPTION_ERROR")]
		public const string DecryptionError = (string) "decryption_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DECRYPTION_FAILED']"
		[Register ("DECRYPTION_FAILED")]
		public const string DecryptionFailed = (string) "decryption_failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVELOPER_REDIRECTURI_INVALID']"
		[Register ("DEVELOPER_REDIRECTURI_INVALID")]
		public const string DeveloperRedirecturiInvalid = (string) "The redirectUri for broker is invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CERTIFICATE_API_EXCEPTION']"
		[Register ("DEVICE_CERTIFICATE_API_EXCEPTION")]
		public const string DeviceCertificateApiException = (string) "Device certificate API has exception";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CERTIFICATE_REQUEST_INVALID']"
		[Register ("DEVICE_CERTIFICATE_REQUEST_INVALID")]
		public const string DeviceCertificateRequestInvalid = (string) "Device certificate request is invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_AUTHORIZATION_DECLINED_ERROR_CODE']"
		[Register ("DEVICE_CODE_FLOW_AUTHORIZATION_DECLINED_ERROR_CODE")]
		public const string DeviceCodeFlowAuthorizationDeclinedErrorCode = (string) "authorization_declined";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_AUTHORIZATION_DECLINED_ERROR_MESSAGE']"
		[Register ("DEVICE_CODE_FLOW_AUTHORIZATION_DECLINED_ERROR_MESSAGE")]
		public const string DeviceCodeFlowAuthorizationDeclinedErrorMessage = (string) "The end user has denied the authorization request. Re-run the Device Code Flow Protocol with another user.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_AUTHORIZATION_PENDING_ERROR_CODE']"
		[Register ("DEVICE_CODE_FLOW_AUTHORIZATION_PENDING_ERROR_CODE")]
		public const string DeviceCodeFlowAuthorizationPendingErrorCode = (string) "authorization_pending";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_BAD_VERIFICATION_ERROR_CODE']"
		[Register ("DEVICE_CODE_FLOW_BAD_VERIFICATION_ERROR_CODE")]
		public const string DeviceCodeFlowBadVerificationErrorCode = (string) "bad_verification_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_BAD_VERIFICATION_ERROR_MESSAGE']"
		[Register ("DEVICE_CODE_FLOW_BAD_VERIFICATION_ERROR_MESSAGE")]
		public const string DeviceCodeFlowBadVerificationErrorMessage = (string) "The token request contains a device code that was not recognized. Verify that the client is sending the right device code.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_DEFAULT_ERROR_MESSAGE']"
		[Register ("DEVICE_CODE_FLOW_DEFAULT_ERROR_MESSAGE")]
		public const string DeviceCodeFlowDefaultErrorMessage = (string) "Device Code Flow has failed with an unexpected error. The error code shown was received from the result object.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_EXPIRED_TOKEN_ERROR_CODE']"
		[Register ("DEVICE_CODE_FLOW_EXPIRED_TOKEN_ERROR_CODE")]
		public const string DeviceCodeFlowExpiredTokenErrorCode = (string) "expired_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_EXPIRED_TOKEN_ERROR_MESSAGE']"
		[Register ("DEVICE_CODE_FLOW_EXPIRED_TOKEN_ERROR_MESSAGE")]
		public const string DeviceCodeFlowExpiredTokenErrorMessage = (string) "The token has expired, therefore authentication is no longer possible with this flow attempt. Re-run the Device Code Flow Protocol to try again.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_INVALID_GRANT_ERROR_MESSAGE']"
		[Register ("DEVICE_CODE_FLOW_INVALID_GRANT_ERROR_MESSAGE")]
		public const string DeviceCodeFlowInvalidGrantErrorMessage = (string) "The token for this device code has already been redeemed. To receive another access token, please re-run the Device Code Flow protocol.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_CODE_FLOW_INVALID_SCOPE_ERROR_MESSAGE']"
		[Register ("DEVICE_CODE_FLOW_INVALID_SCOPE_ERROR_MESSAGE")]
		public const string DeviceCodeFlowInvalidScopeErrorMessage = (string) "The scope attached to the device code flow request is invalid. Please re-try with a valid scope.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_DELETED_ON_SERVER_IRRECOVERABLE_ERROR_MESSAGE']"
		[Register ("DEVICE_DELETED_ON_SERVER_IRRECOVERABLE_ERROR_MESSAGE")]
		public const string DeviceDeletedOnServerIrrecoverableErrorMessage = (string) "This device was deleted from the tenant. This is an irrecoverable error. Only tenant administrator can re-register this device.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_NETWORK_NOT_AVAILABLE']"
		[Register ("DEVICE_NETWORK_NOT_AVAILABLE")]
		public const string DeviceNetworkNotAvailable = (string) "device_network_not_available";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_REGISTRATION_FAILED']"
		[Register ("DEVICE_REGISTRATION_FAILED")]
		public const string DeviceRegistrationFailed = (string) "Device registration failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DEVICE_REGISTRATION_MISSING_FROM_CLIENT']"
		[Register ("DEVICE_REGISTRATION_MISSING_FROM_CLIENT")]
		public const string DeviceRegistrationMissingFromClient = (string) "Device registration data not found.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='DUPLICATE_QUERY_PARAMETER']"
		[Register ("DUPLICATE_QUERY_PARAMETER")]
		public const string DuplicateQueryParameter = (string) "duplicate_query_parameter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='ENCRYPTION_ERROR']"
		[Register ("ENCRYPTION_ERROR")]
		public const string EncryptionError = (string) "encryption_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='ERROR_RETRIEVING_DEVICE_STATE']"
		[Register ("ERROR_RETRIEVING_DEVICE_STATE")]
		public const string ErrorRetrievingDeviceState = (string) "Error retrieving device state";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='FAILED_TO_GET_CAPABILITIES']"
		[Register ("FAILED_TO_GET_CAPABILITIES")]
		public const string FailedToGetCapabilities = (string) "Could not get the capabilities";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='INVALID_BROKER_REFRESH_TOKEN']"
		[Register ("INVALID_BROKER_REFRESH_TOKEN")]
		public const string InvalidBrokerRefreshToken = (string) "Broker refresh token is invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='INVALID_INSTANCE']"
		[Register ("INVALID_INSTANCE")]
		public const string InvalidInstance = (string) "invalid_instance";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='INVALID_JWT']"
		[Register ("INVALID_JWT")]
		public const string InvalidJwt = (string) "invalid_jwt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='INVALID_REQUEST']"
		[Register ("INVALID_REQUEST")]
		public const string InvalidRequest = (string) "invalid_request";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='INVALID_SCOPE']"
		[Register ("INVALID_SCOPE")]
		public const string InvalidScope = (string) "invalid_scope";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='IO_ERROR']"
		[Register ("IO_ERROR")]
		public const string IoError = (string) "io_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='JSON_PARSE_FAILURE']"
		[Register ("JSON_PARSE_FAILURE")]
		public const string JsonParseFailure = (string) "json_parse_failure";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='KEY_CHAIN_PRIVATE_KEY_EXCEPTION']"
		[Register ("KEY_CHAIN_PRIVATE_KEY_EXCEPTION")]
		public const string KeyChainPrivateKeyException = (string) "Key Chain private key exception";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='KEY_NOT_FOUND']"
		[Register ("KEY_NOT_FOUND")]
		public const string KeyNotFound = (string) "key_not_found";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MALFORMED_URL']"
		[Register ("MALFORMED_URL")]
		public const string MalformedUrl = (string) "malformed_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_CODE']"
		[Register ("MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_CODE")]
		public const string MultipleAccountPcaInitFailAccountModeErrorCode = (string) "multiple_account_pca_init_fail_account_mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_MESSAGE']"
		[Register ("MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_MESSAGE")]
		public const string MultipleAccountPcaInitFailAccountModeErrorMessage = (string) "AccountMode in configuration is not set to multiple. Cannot initialize multiple account PublicClientApplication.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ON_SHARED_DEVICE_ERROR_CODE']"
		[Register ("MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ON_SHARED_DEVICE_ERROR_CODE")]
		public const string MultipleAccountPcaInitFailOnSharedDeviceErrorCode = (string) "multiple_account_pca_init_fail_on_shared_device";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ON_SHARED_DEVICE_ERROR_MESSAGE']"
		[Register ("MULTIPLE_ACCOUNT_PCA_INIT_FAIL_ON_SHARED_DEVICE_ERROR_MESSAGE")]
		public const string MultipleAccountPcaInitFailOnSharedDeviceErrorMessage = (string) "This application is not supported in the shared device mode. Please contact application developer to update the app.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_CODE']"
		[Register ("MULTIPLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_CODE")]
		public const string MultipleAccountPcaInitFailUnknownReasonErrorCode = (string) "multiple_account_pca_init_fail_unknown_reason";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_MESSAGE']"
		[Register ("MULTIPLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_MESSAGE")]
		public const string MultipleAccountPcaInitFailUnknownReasonErrorMessage = (string) "Multiple account PublicClientApplication could not be created for unknown reasons";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='MULTIPLE_MATCHING_TOKENS_DETECTED']"
		[Register ("MULTIPLE_MATCHING_TOKENS_DETECTED")]
		public const string MultipleMatchingTokensDetected = (string) "multiple_matching_tokens_detected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='NO_ACCOUNT_FOUND']"
		[Register ("NO_ACCOUNT_FOUND")]
		public const string NoAccountFound = (string) "no_account_found";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='NO_AVAILABLE_BROWSER_FOUND']"
		[Register ("NO_AVAILABLE_BROWSER_FOUND")]
		public const string NoAvailableBrowserFound = (string) "No available browser installed on the device.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='NO_NETWORK_CONNECTION_POWER_OPTIMIZATION']"
		[Register ("NO_NETWORK_CONNECTION_POWER_OPTIMIZATION")]
		public const string NoNetworkConnectionPowerOptimization = (string) "device_network_not_available_doze_mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='NO_SUCH_ALGORITHM']"
		[Register ("NO_SUCH_ALGORITHM")]
		public const string NoSuchAlgorithm = (string) "no_such_algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='NO_TOKENS_FOUND']"
		[Register ("NO_TOKENS_FOUND")]
		public const string NoTokensFound = (string) "no_tokens_found";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='PACKAGE_NAME_NOT_FOUND']"
		[Register ("PACKAGE_NAME_NOT_FOUND")]
		public const string PackageNameNotFound = (string) "Package name is not resolved";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='REGISTERED_SHARED_DEVICE_DELETED_ON_SERVER_ERROR_CODE']"
		[Register ("REGISTERED_SHARED_DEVICE_DELETED_ON_SERVER_ERROR_CODE")]
		public const string RegisteredSharedDeviceDeletedOnServerErrorCode = (string) "registered_shared_device_deleted_on_server";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='REQUEST_TIMEOUT']"
		[Register ("REQUEST_TIMEOUT")]
		public const string RequestTimeout = (string) "request_timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SERVICE_NOT_AVAILABLE']"
		[Register ("SERVICE_NOT_AVAILABLE")]
		public const string ServiceNotAvailable = (string) "service_not_available";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SIGNATURE_EXCEPTION']"
		[Register ("SIGNATURE_EXCEPTION")]
		public const string SignatureException = (string) "Signature exception";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SINGLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_CODE']"
		[Register ("SINGLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_CODE")]
		public const string SingleAccountPcaInitFailAccountModeErrorCode = (string) "single_account_pca_init_fail_account_mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SINGLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_MESSAGE']"
		[Register ("SINGLE_ACCOUNT_PCA_INIT_FAIL_ACCOUNT_MODE_ERROR_MESSAGE")]
		public const string SingleAccountPcaInitFailAccountModeErrorMessage = (string) "AccountMode in configuration is not set to single. Cannot initialize single account PublicClientApplication.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SINGLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_CODE']"
		[Register ("SINGLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_CODE")]
		public const string SingleAccountPcaInitFailUnknownReasonErrorCode = (string) "single_account_pca_init_fail_unknown_reason";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SINGLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_MESSAGE']"
		[Register ("SINGLE_ACCOUNT_PCA_INIT_FAIL_UNKNOWN_REASON_ERROR_MESSAGE")]
		public const string SingleAccountPcaInitFailUnknownReasonErrorMessage = (string) "A single account public client application could not be created for unknown reasons.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='SOCKET_TIMEOUT']"
		[Register ("SOCKET_TIMEOUT")]
		public const string SocketTimeout = (string) "socket_timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='STATE_MISMATCH']"
		[Register ("STATE_MISMATCH")]
		public const string StateMismatch = (string) "state_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='STK_PATCHING_FAILED']"
		[Register ("STK_PATCHING_FAILED")]
		public const string StkPatchingFailed = (string) "STK patching failed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNAUTHORIZED_CLIENT']"
		[Register ("UNAUTHORIZED_CLIENT")]
		public const string UnauthorizedClient = (string) "unauthorized_client";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNKNOWN_CALLER']"
		[Register ("UNKNOWN_CALLER")]
		public const string UnknownCaller = (string) "unknown_caller";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const string UnknownError = (string) "unknown_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNRESOLVABLE_INTENT']"
		[Register ("UNRESOLVABLE_INTENT")]
		public const string UnresolvableIntent = (string) "unresolvable_intent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNSUPPORTED_BROKER_VERSION_ERROR_CODE']"
		[Register ("UNSUPPORTED_BROKER_VERSION_ERROR_CODE")]
		public const string UnsupportedBrokerVersionErrorCode = (string) "unsupported_broker_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNSUPPORTED_BROKER_VERSION_ERROR_MESSAGE']"
		[Register ("UNSUPPORTED_BROKER_VERSION_ERROR_MESSAGE")]
		public const string UnsupportedBrokerVersionErrorMessage = (string) "Please update Intune Company Portal and/or Microsoft Authenticator to the latest version.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNSUPPORTED_ENCODING']"
		[Register ("UNSUPPORTED_ENCODING")]
		public const string UnsupportedEncoding = (string) "unsupported_encoding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='UNSUPPORTED_URL']"
		[Register ("UNSUPPORTED_URL")]
		public const string UnsupportedUrl = (string) "unsupported_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='USERLESS_DEVICE_DELETED_ON_SERVER_ERROR_CODE']"
		[Register ("USERLESS_DEVICE_DELETED_ON_SERVER_ERROR_CODE")]
		public const string UserlessDeviceDeletedOnServerErrorCode = (string) "userless_device_deleted_on_server";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='USER_CANCELLED']"
		[Register ("USER_CANCELLED")]
		public const string UserCancelled = (string) "User cancelled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='USER_MISMATCH']"
		[Register ("USER_MISMATCH")]
		public const string UserMismatch = (string) "user_mismatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='WEBCP_URI_INVALID']"
		[Register ("WEBCP_URI_INVALID")]
		public const string WebcpUriInvalid = (string) "webcp_uri_invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='ErrorStrings']/field[@name='WEBVIEW_REDIRECTURL_NOT_SSL_PROTECTED']"
		[Register ("WEBVIEW_REDIRECTURL_NOT_SSL_PROTECTED")]
		public const string WebviewRedirecturlNotSslProtected = (string) "Redirect url scheme not SSL protected";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/ErrorStrings", typeof (ErrorStrings));

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

		internal ErrorStrings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
