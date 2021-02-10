using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants", DoNotGenerateAcw=true)]
	public sealed partial class AuthenticationConstants : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants']/field[@name='ADAL_PACKAGE_NAME']"
		[Register ("ADAL_PACKAGE_NAME")]
		public const string AdalPackageName = (string) "com.microsoft.aad.adal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants']/field[@name='BUNDLE_MESSAGE']"
		[Register ("BUNDLE_MESSAGE")]
		public const string BundleMessage = (string) "Message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants']/field[@name='DEFAULT_EXPIRATION_TIME_SEC']"
		[Register ("DEFAULT_EXPIRATION_TIME_SEC")]
		public const int DefaultExpirationTimeSec = (int) 3600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants']/field[@name='ENCODING_UTF8']"
		[Register ("ENCODING_UTF8")]
		public const string EncodingUtf8 = (string) "UTF-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants']/field[@name='MS_FAMILY_ID']"
		[Register ("MS_FAMILY_ID")]
		public const string MsFamilyId = (string) "1";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$AAD", DoNotGenerateAcw=true)]
		public sealed partial class AAD : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_BROKER_VERSION']"
			[Register ("ADAL_BROKER_VERSION")]
			public const string AdalBrokerVersion = (string) "x-client-brkrver";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_ID_CPU']"
			[Register ("ADAL_ID_CPU")]
			public const string AdalIdCpu = (string) "x-client-CPU";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_ID_DM']"
			[Register ("ADAL_ID_DM")]
			public const string AdalIdDm = (string) "x-client-DM";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_ID_OS_VER']"
			[Register ("ADAL_ID_OS_VER")]
			public const string AdalIdOsVer = (string) "x-client-OS";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_ID_PLATFORM']"
			[Register ("ADAL_ID_PLATFORM")]
			public const string AdalIdPlatform = (string) "x-client-SKU";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_ID_PLATFORM_VALUE']"
			[Register ("ADAL_ID_PLATFORM_VALUE")]
			public const string AdalIdPlatformValue = (string) "Android";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='ADAL_ID_VERSION']"
			[Register ("ADAL_ID_VERSION")]
			public const string AdalIdVersion = (string) "x-client-Ver";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='APP_PACKAGE_NAME']"
			[Register ("APP_PACKAGE_NAME")]
			public const string AppPackageName = (string) "x-app-name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='APP_VERSION']"
			[Register ("APP_VERSION")]
			public const string AppVersion = (string) "x-app-ver";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='AUTHORIZATION']"
			[Register ("AUTHORIZATION")]
			public const string Authorization = (string) "authorization";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='AUTHORIZATION_URI']"
			[Register ("AUTHORIZATION_URI")]
			public const string AuthorizationUri = (string) "authorization_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='BEARER']"
			[Register ("BEARER")]
			public const string Bearer = (string) "Bearer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='CLIENT_REQUEST_ID']"
			[Register ("CLIENT_REQUEST_ID")]
			public const string ClientRequestId = (string) "client-request-id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='CORRELATION_ID']"
			[Register ("CORRELATION_ID")]
			public const string CorrelationId = (string) "correlation_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='LOGIN_HINT']"
			[Register ("LOGIN_HINT")]
			public const string LoginHint = (string) "login_hint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='QUERY_PROMPT']"
			[Register ("QUERY_PROMPT")]
			public const string QueryPrompt = (string) "prompt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='QUERY_PROMPT_REFRESH_SESSION_VALUE']"
			[Register ("QUERY_PROMPT_REFRESH_SESSION_VALUE")]
			public const string QueryPromptRefreshSessionValue = (string) "refresh_session";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='QUERY_PROMPT_VALUE']"
			[Register ("QUERY_PROMPT_VALUE")]
			public const string QueryPromptValue = (string) "login";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='REALM']"
			[Register ("REALM")]
			public const string Realm = (string) "realm";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='REQUEST_ID_HEADER']"
			[Register ("REQUEST_ID_HEADER")]
			public const string RequestIdHeader = (string) "x-ms-request-id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='RESOURCE']"
			[Register ("RESOURCE")]
			public const string Resource = (string) "resource";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='RETURN_CLIENT_REQUEST_ID']"
			[Register ("RETURN_CLIENT_REQUEST_ID")]
			public const string ReturnClientRequestId = (string) "return-client-request-id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AAD']/field[@name='WEB_UI_CANCEL']"
			[Register ("WEB_UI_CANCEL")]
			public const string WebUiCancel = (string) "access_denied";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$AAD", typeof (AAD));

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

			internal AAD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentAction']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$AuthorizationIntentAction", DoNotGenerateAcw=true)]
		public sealed partial class AuthorizationIntentAction : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentAction']/field[@name='CANCEL_INTERACTIVE_REQUEST']"
			[Register ("CANCEL_INTERACTIVE_REQUEST")]
			public const string CancelInteractiveRequest = (string) "cancel_interactive_request";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentAction']/field[@name='RETURN_INTERACTIVE_REQUEST_RESULT']"
			[Register ("RETURN_INTERACTIVE_REQUEST_RESULT")]
			public const string ReturnInteractiveRequestResult = (string) "return_interactive_request_result";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$AuthorizationIntentAction", typeof (AuthorizationIntentAction));

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

			internal AuthorizationIntentAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentAction']/constructor[@name='AuthenticationConstants.AuthorizationIntentAction' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AuthorizationIntentAction () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$AuthorizationIntentKey", DoNotGenerateAcw=true)]
		public sealed partial class AuthorizationIntentKey : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='AUTHORIZATION_AGENT']"
			[Register ("AUTHORIZATION_AGENT")]
			public const string AuthorizationAgent = (string) "com.microsoft.identity.client.authorization.agent";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='AUTHORIZATION_FINAL_URL']"
			[Register ("AUTHORIZATION_FINAL_URL")]
			public const string AuthorizationFinalUrl = (string) "com.microsoft.identity.client.final.url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='AUTH_INTENT']"
			[Register ("AUTH_INTENT")]
			public const string AuthIntent = (string) "com.microsoft.identity.auth.intent";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='POST_PAGE_LOADED_URL']"
			[Register ("POST_PAGE_LOADED_URL")]
			public const string PostPageLoadedUrl = (string) "com.microsoft.identity.post.page.loaded.url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='REDIRECT_URI']"
			[Register ("REDIRECT_URI")]
			public const string RedirectUri = (string) "com.microsoft.identity.request.redirect.uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='REQUEST_CANCELLED_BY_USER']"
			[Register ("REQUEST_CANCELLED_BY_USER")]
			public const string RequestCancelledByUser = (string) "com.microsoft.identity.client.request.cancelled.by.user";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='REQUEST_CODE']"
			[Register ("REQUEST_CODE")]
			public const string RequestCode = (string) "com.microsoft.identity.client.request.code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='REQUEST_HEADERS']"
			[Register ("REQUEST_HEADERS")]
			public const string RequestHeaders = (string) "com.microsoft.identity.request.headers";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='REQUEST_ID']"
			[Register ("REQUEST_ID")]
			public const string RequestId = (string) "com.microsoft.identity.request.id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='REQUEST_URL']"
			[Register ("REQUEST_URL")]
			public const string RequestUrl = (string) "com.microsoft.identity.request.url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='RESULT_CODE']"
			[Register ("RESULT_CODE")]
			public const string ResultCode = (string) "com.microsoft.identity.client.result.code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='WEB_VIEW_ZOOM_CONTROLS_ENABLED']"
			[Register ("WEB_VIEW_ZOOM_CONTROLS_ENABLED")]
			public const string WebViewZoomControlsEnabled = (string) "com.microsoft.identity.web.view.zoom.controls.enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/field[@name='WEB_VIEW_ZOOM_ENABLED']"
			[Register ("WEB_VIEW_ZOOM_ENABLED")]
			public const string WebViewZoomEnabled = (string) "com.microsoft.identity.web.view.zoom.enabled";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$AuthorizationIntentKey", typeof (AuthorizationIntentKey));

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

			internal AuthorizationIntentKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.AuthorizationIntentKey']/constructor[@name='AuthenticationConstants.AuthorizationIntentKey' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AuthorizationIntentKey () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$Broker", DoNotGenerateAcw=true)]
		public sealed partial class Broker : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_ACCESS_TOKEN']"
			[Register ("ACCOUNT_ACCESS_TOKEN")]
			public const string AccountAccessToken = (string) "account.access.token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_ADD_NEW']"
			[Register ("ACCOUNT_ADD_NEW")]
			public const string AccountAddNew = (string) "account.add.new";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_AUTHORITY']"
			[Register ("ACCOUNT_AUTHORITY")]
			public const string AccountAuthority = (string) "account.authority";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_CLAIMS']"
			[Register ("ACCOUNT_CLAIMS")]
			public const string AccountClaims = (string) "account.claims";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_CLIENTID_KEY']"
			[Register ("ACCOUNT_CLIENTID_KEY")]
			public const string AccountClientidKey = (string) "account.clientid.key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_CLIENT_SECRET_KEY']"
			[Register ("ACCOUNT_CLIENT_SECRET_KEY")]
			public const string AccountClientSecretKey = (string) "account.client.secret.key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_CORRELATIONID']"
			[Register ("ACCOUNT_CORRELATIONID")]
			public const string AccountCorrelationid = (string) "account.correlationid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_DEFAULT_NAME']"
			[Register ("ACCOUNT_DEFAULT_NAME")]
			public const string AccountDefaultName = (string) "Default";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_EXPIREDATE']"
			[Register ("ACCOUNT_EXPIREDATE")]
			public const string AccountExpiredate = (string) "account.expiredate";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_EXTRA_QUERY_PARAM']"
			[Register ("ACCOUNT_EXTRA_QUERY_PARAM")]
			public const string AccountExtraQueryParam = (string) "account.extra.query.param";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_HOME_ACCOUNT_ID']"
			[Register ("ACCOUNT_HOME_ACCOUNT_ID")]
			public const string AccountHomeAccountId = (string) "account.home.account.id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_IDTOKEN']"
			[Register ("ACCOUNT_IDTOKEN")]
			public const string AccountIdtoken = (string) "account.idtoken";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_INITIAL_NAME']"
			[Register ("ACCOUNT_INITIAL_NAME")]
			public const string AccountInitialName = (string) "aad";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_INITIAL_REQUEST']"
			[Register ("ACCOUNT_INITIAL_REQUEST")]
			public const string AccountInitialRequest = (string) "account.initial.request";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_LOGIN_HINT']"
			[Register ("ACCOUNT_LOGIN_HINT")]
			public const string AccountLoginHint = (string) "account.login.hint";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_MANAGER_REMOVE_ACCOUNT_TIMEOUT_IN_MILLISECONDS']"
			[Register ("ACCOUNT_MANAGER_REMOVE_ACCOUNT_TIMEOUT_IN_MILLISECONDS")]
			public const int AccountManagerRemoveAccountTimeoutInMilliseconds = (int) 5000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_NAME']"
			[Register ("ACCOUNT_NAME")]
			public const string AccountName = (string) "account.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_PROMPT']"
			[Register ("ACCOUNT_PROMPT")]
			public const string AccountPrompt = (string) "account.prompt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_REDIRECT']"
			[Register ("ACCOUNT_REDIRECT")]
			public const string AccountRedirect = (string) "account.redirect";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_REFRESH_TOKEN']"
			[Register ("ACCOUNT_REFRESH_TOKEN")]
			public const string AccountRefreshToken = (string) "account.refresh.token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_REMOVE_TOKENS']"
			[Register ("ACCOUNT_REMOVE_TOKENS")]
			public const string AccountRemoveTokens = (string) "account.remove.tokens";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_REMOVE_TOKENS_VALUE']"
			[Register ("ACCOUNT_REMOVE_TOKENS_VALUE")]
			public const string AccountRemoveTokensValue = (string) "account.remove.tokens.value";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_REQUEST_TYPE']"
			[Register ("ACCOUNT_REQUEST_TYPE")]
			public const string AccountRequestType = (string) "broker.request.type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_RESOLVE_INTERRUPT']"
			[Register ("ACCOUNT_RESOLVE_INTERRUPT")]
			public const string AccountResolveInterrupt = (string) "account.resolve.interrupt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_RESOURCE']"
			[Register ("ACCOUNT_RESOURCE")]
			public const string AccountResource = (string) "account.resource";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_RESULT']"
			[Register ("ACCOUNT_RESULT")]
			public const string AccountResult = (string) "account.result";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_UID_CACHES']"
			[Register ("ACCOUNT_UID_CACHES")]
			public const string AccountUidCaches = (string) "account.uid.caches";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_AUTHORITY_TYPE']"
			[Register ("ACCOUNT_USERINFO_AUTHORITY_TYPE")]
			public const string AccountUserinfoAuthorityType = (string) "account.userinfo.authority.type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_ENVIRONMENT']"
			[Register ("ACCOUNT_USERINFO_ENVIRONMENT")]
			public const string AccountUserinfoEnvironment = (string) "account.userinfo.environment";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_FAMILY_NAME']"
			[Register ("ACCOUNT_USERINFO_FAMILY_NAME")]
			public const string AccountUserinfoFamilyName = (string) "account.userinfo.family.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_GIVEN_NAME']"
			[Register ("ACCOUNT_USERINFO_GIVEN_NAME")]
			public const string AccountUserinfoGivenName = (string) "account.userinfo.given.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_IDENTITY_PROVIDER']"
			[Register ("ACCOUNT_USERINFO_IDENTITY_PROVIDER")]
			public const string AccountUserinfoIdentityProvider = (string) "account.userinfo.identity.provider";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_ID_TOKEN']"
			[Register ("ACCOUNT_USERINFO_ID_TOKEN")]
			public const string AccountUserinfoIdToken = (string) "account.userinfo.id.token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_TENANTID']"
			[Register ("ACCOUNT_USERINFO_TENANTID")]
			public const string AccountUserinfoTenantid = (string) "account.userinfo.tenantid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_USERID']"
			[Register ("ACCOUNT_USERINFO_USERID")]
			public const string AccountUserinfoUserid = (string) "account.userinfo.userid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_USERID_DISPLAYABLE']"
			[Register ("ACCOUNT_USERINFO_USERID_DISPLAYABLE")]
			public const string AccountUserinfoUseridDisplayable = (string) "account.userinfo.userid.displayable";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ACCOUNT_USERINFO_USERID_LIST']"
			[Register ("ACCOUNT_USERINFO_USERID_LIST")]
			public const string AccountUserinfoUseridList = (string) "account.userinfo.userid.list";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ADAL_VERSION_KEY']"
			[Register ("ADAL_VERSION_KEY")]
			public const string AdalVersionKey = (string) "adal.version.key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AUTHTOKEN_TYPE']"
			[Register ("AUTHTOKEN_TYPE")]
			public const string AuthtokenType = (string) "adal.authtoken.type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AUTH_RESPONSE_TYPE']"
			[Register ("AUTH_RESPONSE_TYPE")]
			public const string AuthResponseType = (string) "response_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AUTH_SCHEME_PARAMS_POP']"
			[Register ("AUTH_SCHEME_PARAMS_POP")]
			public const string AuthSchemeParamsPop = (string) "pop_parameters";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AUTH_SCOPE']"
			[Register ("AUTH_SCOPE")]
			public const string AuthScope = (string) "scope";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AUTH_STATE']"
			[Register ("AUTH_STATE")]
			public const string AuthState = (string) "state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AZURE_AUTHENTICATOR_APP_PACKAGE_NAME']"
			[Register ("AZURE_AUTHENTICATOR_APP_PACKAGE_NAME")]
			public const string AzureAuthenticatorAppPackageName = (string) "com.azure.authenticator";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AZURE_AUTHENTICATOR_APP_SIGNATURE']"
			[Register ("AZURE_AUTHENTICATOR_APP_SIGNATURE")]
			public const string AzureAuthenticatorAppSignature = (string) "ho040S3ffZkmxqtQrSwpTVOn9r0=";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='AZURE_AUTHENTICATOR_PROD_APP_SIGNATURE']"
			[Register ("AZURE_AUTHENTICATOR_PROD_APP_SIGNATURE")]
			public const string AzureAuthenticatorProdAppSignature = (string) "ho040S3ffZkmxqtQrSwpTVOn9r0=";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BACKGROUND_REQUEST_MESSAGE']"
			[Register ("BACKGROUND_REQUEST_MESSAGE")]
			public const string BackgroundRequestMessage = (string) "background.request";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_ACCOUNTS']"
			[Register ("BROKER_ACCOUNTS")]
			public const string BrokerAccounts = (string) "broker_accounts";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_ACCOUNTS_COMPRESSED']"
			[Register ("BROKER_ACCOUNTS_COMPRESSED")]
			public const string BrokerAccountsCompressed = (string) "broker_accounts_compressed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_ACCOUNT_MANAGER_OPERATION_KEY']"
			[Register ("BROKER_ACCOUNT_MANAGER_OPERATION_KEY")]
			public const string BrokerAccountManagerOperationKey = (string) "com.microsoft.broker_accountmanager_operation_key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_ACCOUNT_TYPE']"
			[Register ("BROKER_ACCOUNT_TYPE")]
			public const string BrokerAccountType = (string) "com.microsoft.workaccount";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_ACTIVITY_NAME']"
			[Register ("BROKER_ACTIVITY_NAME")]
			public const string BrokerActivityName = (string) "broker.activity.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_API_TO_BROKER_PROTOCOL_NAME']"
			[Register ("BROKER_API_TO_BROKER_PROTOCOL_NAME")]
			public const string BrokerApiToBrokerProtocolName = (string) "broker.api.to.broker";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_API_TO_BROKER_PROTOCOL_VERSION_CODE']"
			[Register ("BROKER_API_TO_BROKER_PROTOCOL_VERSION_CODE")]
			public const string BrokerApiToBrokerProtocolVersionCode = (string) "1.0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_CLIENT_ID']"
			[Register ("BROKER_CLIENT_ID")]
			public const string BrokerClientId = (string) "29d9ed98-a469-4536-ade2-f981bc1d605e";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_DEVICE_MODE']"
			[Register ("BROKER_DEVICE_MODE")]
			public const string BrokerDeviceMode = (string) "broker_device_mode";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_FEATURE_MULTI_USER']"
			[Register ("BROKER_FEATURE_MULTI_USER")]
			public const string BrokerFeatureMultiUser = (string) "broker.feature.multi.user";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_FINAL_URL']"
			[Register ("BROKER_FINAL_URL")]
			public const string BrokerFinalUrl = (string) "adal.final.url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_FORCE_REFRESH']"
			[Register ("BROKER_FORCE_REFRESH")]
			public const string BrokerForceRefresh = (string) "force.refresh";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_GENERATE_SHR_RESULT']"
			[Register ("BROKER_GENERATE_SHR_RESULT")]
			public const string BrokerGenerateShrResult = (string) "broker_generate_shr_result";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_KEYSTORE_SYMMETRIC_KEY']"
			[Register ("BROKER_KEYSTORE_SYMMETRIC_KEY")]
			public const string BrokerKeystoreSymmetricKey = (string) "broker_keystore_symmetric_key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_PACKAGE_NAME']"
			[Register ("BROKER_PACKAGE_NAME")]
			public const string BrokerPackageName = (string) "broker.package.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_PROTOCOL_VERSION']"
			[Register ("BROKER_PROTOCOL_VERSION")]
			public const string BrokerProtocolVersion = (string) "v2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REDIRECT_URI']"
			[Register ("BROKER_REDIRECT_URI")]
			public const string BrokerRedirectUri = (string) "urn:ietf:wg:oauth:2.0:oob";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REQUEST']"
			[Register ("BROKER_REQUEST")]
			public const string BrokerRequest = (string) "com.microsoft.aadbroker.adal.broker.request";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REQUEST_ID']"
			[Register ("BROKER_REQUEST_ID")]
			public const int BrokerRequestId = (int) 1177;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REQUEST_RESUME']"
			[Register ("BROKER_REQUEST_RESUME")]
			public const string BrokerRequestResume = (string) "com.microsoft.aadbroker.adal.broker.request.resume";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REQUEST_V2']"
			[Register ("BROKER_REQUEST_V2")]
			public const string BrokerRequestV2 = (string) "broker_request_v2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REQUEST_V2_COMPRESSED']"
			[Register ("BROKER_REQUEST_V2_COMPRESSED")]
			public const string BrokerRequestV2Compressed = (string) "broker_request_v2_compressed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_REQUEST_V2_SUCCESS']"
			[Register ("BROKER_REQUEST_V2_SUCCESS")]
			public const string BrokerRequestV2Success = (string) "broker_request_v2_success";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_RESULT_RETURNED']"
			[Register ("BROKER_RESULT_RETURNED")]
			public const string BrokerResultReturned = (string) "broker.result.returned";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_RESULT_V2']"
			[Register ("BROKER_RESULT_V2")]
			public const string BrokerResultV2 = (string) "broker_result_v2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_RESULT_V2_COMPRESSED']"
			[Register ("BROKER_RESULT_V2_COMPRESSED")]
			public const string BrokerResultV2Compressed = (string) "broker_result_v2_compressed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_RETURN_JSON']"
			[Register ("BROKER_RETURN_JSON")]
			public const string BrokerReturnJson = (string) "broker.json";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_SKIP_CACHE']"
			[Register ("BROKER_SKIP_CACHE")]
			public const string BrokerSkipCache = (string) "skip.cache";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROKER_VERSION']"
			[Register ("BROKER_VERSION")]
			public const string BrokerVersion = (string) "broker.version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROWSER_DEVICE_CA_URL_QUERY_STRING_PARAMETER']"
			[Register ("BROWSER_DEVICE_CA_URL_QUERY_STRING_PARAMETER")]
			public const string BrowserDeviceCaUrlQueryStringParameter = (string) "&ismdmurl=1";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROWSER_EXT_INSTALL_PREFIX']"
			[Register ("BROWSER_EXT_INSTALL_PREFIX")]
			public const string BrowserExtInstallPrefix = (string) "msauth://";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROWSER_EXT_PREFIX']"
			[Register ("BROWSER_EXT_PREFIX")]
			public const string BrowserExtPrefix = (string) "browser://";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='BROWSER_EXT_WEB_CP']"
			[Register ("BROWSER_EXT_WEB_CP")]
			public const string BrowserExtWebCp = (string) "companyportal://";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CALLER_CACHEKEY_PREFIX']"
			[Register ("CALLER_CACHEKEY_PREFIX")]
			public const string CallerCachekeyPrefix = (string) "|";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CALLER_INFO_PACKAGE']"
			[Register ("CALLER_INFO_PACKAGE")]
			public const string CallerInfoPackage = (string) "caller.info.package";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CALLER_INFO_UID']"
			[Register ("CALLER_INFO_UID")]
			public const string CallerInfoUid = (string) "caller.info.uid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_REQUEST_CERT_AUTH_DELIMETER']"
			[Register ("CHALLENGE_REQUEST_CERT_AUTH_DELIMETER")]
			public const string ChallengeRequestCertAuthDelimeter = (string) ";";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_REQUEST_HEADER']"
			[Register ("CHALLENGE_REQUEST_HEADER")]
			public const string ChallengeRequestHeader = (string) "WWW-Authenticate";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_RESPONSE_CONTEXT']"
			[Register ("CHALLENGE_RESPONSE_CONTEXT")]
			public const string ChallengeResponseContext = (string) "Context";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_RESPONSE_HEADER']"
			[Register ("CHALLENGE_RESPONSE_HEADER")]
			public const string ChallengeResponseHeader = (string) "Authorization";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_RESPONSE_TOKEN']"
			[Register ("CHALLENGE_RESPONSE_TOKEN")]
			public const string ChallengeResponseToken = (string) "AuthToken";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_RESPONSE_TYPE']"
			[Register ("CHALLENGE_RESPONSE_TYPE")]
			public const string ChallengeResponseType = (string) "PKeyAuth";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_TLS_INCAPABLE']"
			[Register ("CHALLENGE_TLS_INCAPABLE")]
			public const string ChallengeTlsIncapable = (string) "x-ms-PKeyAuth";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CHALLENGE_TLS_INCAPABLE_VERSION']"
			[Register ("CHALLENGE_TLS_INCAPABLE_VERSION")]
			public const string ChallengeTlsIncapableVersion = (string) "1.0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CLIENT_ADVERTISED_MAXIMUM_BP_VERSION_KEY']"
			[Register ("CLIENT_ADVERTISED_MAXIMUM_BP_VERSION_KEY")]
			public const string ClientAdvertisedMaximumBpVersionKey = (string) "broker.protocol.version.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CLIENT_APP_PACKAGE_NAME']"
			[Register ("CLIENT_APP_PACKAGE_NAME")]
			public const string ClientAppPackageName = (string) "client_app_package_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CLIENT_CONFIGURED_MINIMUM_BP_VERSION_KEY']"
			[Register ("CLIENT_CONFIGURED_MINIMUM_BP_VERSION_KEY")]
			public const string ClientConfiguredMinimumBpVersionKey = (string) "required.broker.protocol.version.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='CLIENT_TLS_NOT_SUPPORTED']"
			[Register ("CLIENT_TLS_NOT_SUPPORTED")]
			public const string ClientTlsNotSupported = (string) " PKeyAuth/1.0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='COMPANY_PORTAL_APP_LAUNCH_ACTIVITY_NAME']"
			[Register ("COMPANY_PORTAL_APP_LAUNCH_ACTIVITY_NAME")]
			public const string CompanyPortalAppLaunchActivityName = (string) "com.microsoft.windowsintune.companyportal.views.SplashActivity";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='COMPANY_PORTAL_APP_PACKAGE_NAME']"
			[Register ("COMPANY_PORTAL_APP_PACKAGE_NAME")]
			public const string CompanyPortalAppPackageName = (string) "com.microsoft.windowsintune.companyportal";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='COMPANY_PORTAL_APP_SIGNATURE']"
			[Register ("COMPANY_PORTAL_APP_SIGNATURE")]
			public const string CompanyPortalAppSignature = (string) "1L4Z9FJCgn5c0VLhyAxC5O9LdlE=";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='COMPANY_PORTAL_PROD_APP_PACKAGE_NAME']"
			[Register ("COMPANY_PORTAL_PROD_APP_PACKAGE_NAME")]
			public const string CompanyPortalProdAppPackageName = (string) "com.microsoft.windowsintune.companyportal";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='COMPANY_PORTAL_PROD_APP_SIGNATURE']"
			[Register ("COMPANY_PORTAL_PROD_APP_SIGNATURE")]
			public const string CompanyPortalProdAppSignature = (string) "1L4Z9FJCgn5c0VLhyAxC5O9LdlE=";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='DEFAULT_BROWSER_PACKAGE_NAME']"
			[Register ("DEFAULT_BROWSER_PACKAGE_NAME")]
			public const string DefaultBrowserPackageName = (string) "default.browser.package.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='DEVICE_REGISTRATION_REDIRECT_URI_HOSTNAME']"
			[Register ("DEVICE_REGISTRATION_REDIRECT_URI_HOSTNAME")]
			public const string DeviceRegistrationRedirectUriHostname = (string) "wpj";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='ENVIRONMENT']"
			[Register ("ENVIRONMENT")]
			public const string Environment = (string) "environment";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='EXPIRATION_BUFFER']"
			[Register ("EXPIRATION_BUFFER")]
			public const string ExpirationBuffer = (string) "expiration.buffer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='INSTALL_UPN_KEY']"
			[Register ("INSTALL_UPN_KEY")]
			public const string InstallUpnKey = (string) "username";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='INSTALL_URL_KEY']"
			[Register ("INSTALL_URL_KEY")]
			public const string InstallUrlKey = (string) "app_link";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='IPPHONE_APP_PACKAGE_NAME']"
			[Register ("IPPHONE_APP_PACKAGE_NAME")]
			public const string IpphoneAppPackageName = (string) "com.microsoft.skype.teams.ipphone";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='IPPHONE_APP_SIGNATURE']"
			[Register ("IPPHONE_APP_SIGNATURE")]
			public const string IpphoneAppSignature = (string) "fcg80qvoM1YMKJZibjBwQcDfOno=";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='LIB_NAME']"
			[Register ("LIB_NAME")]
			public const string LibName = (string) "library_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='LIB_VERSION']"
			[Register ("LIB_VERSION")]
			public const string LibVersion = (string) "library_version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='MSAL_TO_BROKER_PROTOCOL_NAME']"
			[Register ("MSAL_TO_BROKER_PROTOCOL_NAME")]
			public const string MsalToBrokerProtocolName = (string) "msal.to.broker";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='MSAL_TO_BROKER_PROTOCOL_VERSION_CODE']"
			[Register ("MSAL_TO_BROKER_PROTOCOL_VERSION_CODE")]
			public const string MsalToBrokerProtocolVersionCode = (string) "6.0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='MULTI_RESOURCE_TOKEN']"
			[Register ("MULTI_RESOURCE_TOKEN")]
			public const string MultiResourceToken = (string) "account.multi.resource.token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='NEGOTIATED_BP_VERSION_KEY']"
			[Register ("NEGOTIATED_BP_VERSION_KEY")]
			public const string NegotiatedBpVersionKey = (string) "common.broker.protocol.version.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='PKCE_CHALLENGE']"
			[Register ("PKCE_CHALLENGE")]
			public const string PkceChallenge = (string) "PkceChallenge";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='PKEYAUTH_REDIRECT']"
			[Register ("PKEYAUTH_REDIRECT")]
			public const string PkeyauthRedirect = (string) "urn:http-auth:PKeyAuth";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='PRT_NONCE']"
			[Register ("PRT_NONCE")]
			public const string PrtNonce = (string) "nonce";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='PRT_RESPONSE_HEADER']"
			[Register ("PRT_RESPONSE_HEADER")]
			public const string PrtResponseHeader = (string) "x-ms-RefreshTokenCredential";


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='REDIRECT_DELIMETER_ENCODED']"
			[Register ("REDIRECT_DELIMETER_ENCODED")]
			public static global::Java.Lang.Object RedirectDelimeterEncoded {
				get {
					const string __id = "REDIRECT_DELIMETER_ENCODED.Ljava/lang/Object;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='REDIRECT_PREFIX']"
			[Register ("REDIRECT_PREFIX")]
			public const string RedirectPrefix = (string) "msauth";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='REDIRECT_SSL_PREFIX']"
			[Register ("REDIRECT_SSL_PREFIX")]
			public const string RedirectSslPrefix = (string) "https://";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='REMOVE_BROKER_ACCOUNT_SUCCEEDED']"
			[Register ("REMOVE_BROKER_ACCOUNT_SUCCEEDED")]
			public const string RemoveBrokerAccountSucceeded = (string) "remove_broker_account_succeeded";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='UPDATE_BROKER_RT_SUCCEEDED']"
			[Register ("UPDATE_BROKER_RT_SUCCEEDED")]
			public const string UpdateBrokerRtSucceeded = (string) "update_broker_rt_succeeded";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='USERDATA_BROKER_PRT_RT']"
			[Register ("USERDATA_BROKER_PRT_RT")]
			public const string UserdataBrokerPrtRt = (string) "userdata.broker.prt.rt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='USERDATA_BROKER_PRT_SESSION_KEY']"
			[Register ("USERDATA_BROKER_PRT_SESSION_KEY")]
			public const string UserdataBrokerPrtSessionKey = (string) "userdata.broker.prt.session.key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='USERDATA_BROKER_RT']"
			[Register ("USERDATA_BROKER_RT")]
			public const string UserdataBrokerRt = (string) "userdata.broker.rt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='USERDATA_CALLER_CACHEKEYS']"
			[Register ("USERDATA_CALLER_CACHEKEYS")]
			public const string UserdataCallerCachekeys = (string) "userdata.caller.cachekeys";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='USERDATA_PREFIX']"
			[Register ("USERDATA_PREFIX")]
			public const string UserdataPrefix = (string) "userdata.prefix";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='USERDATA_UID_KEY']"
			[Register ("USERDATA_UID_KEY")]
			public const string UserdataUidKey = (string) "calling.uid.key";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker']/field[@name='WEBCP_LAUNCH_COMPANY_PORTAL_URL']"
			[Register ("WEBCP_LAUNCH_COMPANY_PORTAL_URL")]
			public const string WebcpLaunchCompanyPortalUrl = (string) "companyportal://enrollment";

			// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker.CliTelemInfo']"
			[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$Broker$CliTelemInfo", DoNotGenerateAcw=true)]
			public sealed partial class CliTelemInfo : global::Java.Lang.Object {
				// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker.CliTelemInfo']/field[@name='RT_AGE']"
				[Register ("RT_AGE")]
				public const string RtAge = (string) "cliteleminfo.rt_age";

				// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker.CliTelemInfo']/field[@name='SERVER_ERROR']"
				[Register ("SERVER_ERROR")]
				public const string ServerError = (string) "cliteleminfo.server_error";

				// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker.CliTelemInfo']/field[@name='SERVER_SUBERROR']"
				[Register ("SERVER_SUBERROR")]
				public const string ServerSuberror = (string) "cliteleminfo.server_suberror";

				// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker.CliTelemInfo']/field[@name='SPE_RING']"
				[Register ("SPE_RING")]
				public const string SpeRing = (string) "cliteleminfo.spe_ring";

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$Broker$CliTelemInfo", typeof (CliTelemInfo));

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

				internal CliTelemInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Broker.CliTelemInfo']/constructor[@name='AuthenticationConstants.Broker.CliTelemInfo' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe CliTelemInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$Broker", typeof (Broker));

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

			internal Broker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$BrokerAccountManagerOperation", DoNotGenerateAcw=true)]
		public sealed partial class BrokerAccountManagerOperation : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='ACQUIRE_TOKEN_SILENT']"
			[Register ("ACQUIRE_TOKEN_SILENT")]
			public const string AcquireTokenSilent = (string) "ACQUIRE_TOKEN_SILENT";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='GENERATE_SHR']"
			[Register ("GENERATE_SHR")]
			public const string GenerateShr = (string) "GENERATE_SHR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='GET_ACCOUNTS']"
			[Register ("GET_ACCOUNTS")]
			public const string GetAccounts = (string) "GET_ACCOUNTS";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='GET_CURRENT_ACCOUNT']"
			[Register ("GET_CURRENT_ACCOUNT")]
			public const string GetCurrentAccount = (string) "GET_CURRENT_ACCOUNT";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='GET_DEVICE_MODE']"
			[Register ("GET_DEVICE_MODE")]
			public const string GetDeviceMode = (string) "GET_DEVICE_MODE";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='GET_INTENT_FOR_INTERACTIVE_REQUEST']"
			[Register ("GET_INTENT_FOR_INTERACTIVE_REQUEST")]
			public const string GetIntentForInteractiveRequest = (string) "GET_INTENT_FOR_INTERACTIVE_REQUEST";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='HELLO']"
			[Register ("HELLO")]
			public const string Hello = (string) "HELLO";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='REMOVE_ACCOUNT']"
			[Register ("REMOVE_ACCOUNT")]
			public const string RemoveAccount = (string) "REMOVE_ACCOUNT";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerAccountManagerOperation']/field[@name='REMOVE_ACCOUNT_FROM_SHARED_DEVICE']"
			[Register ("REMOVE_ACCOUNT_FROM_SHARED_DEVICE")]
			public const string RemoveAccountFromSharedDevice = (string) "REMOVE_ACCOUNT_FROM_SHARED_DEVICE";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$BrokerAccountManagerOperation", typeof (BrokerAccountManagerOperation));

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

			internal BrokerAccountManagerOperation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$BrokerContentProvider", DoNotGenerateAcw=true)]
		public sealed partial class BrokerContentProvider : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='AUTHORITY']"
			[Register ("AUTHORITY")]
			public const string Authority = (string) "microsoft.identity.broker";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_GET_BROKER_ACCOUNTS_CODE']"
			[Register ("BROKER_API_GET_BROKER_ACCOUNTS_CODE")]
			public const int BrokerApiGetBrokerAccountsCode = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_GET_BROKER_ACCOUNTS_PATH']"
			[Register ("BROKER_API_GET_BROKER_ACCOUNTS_PATH")]
			public const string BrokerApiGetBrokerAccountsPath = (string) "/brokerApi/getBrokerAccounts";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_HELLO_PATH']"
			[Register ("BROKER_API_HELLO_PATH")]
			public const string BrokerApiHelloPath = (string) "/brokerApi/hello";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_HELLO_URI_CODE']"
			[Register ("BROKER_API_HELLO_URI_CODE")]
			public const int BrokerApiHelloUriCode = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_REMOVE_BROKER_ACCOUNT_CODE']"
			[Register ("BROKER_API_REMOVE_BROKER_ACCOUNT_CODE")]
			public const int BrokerApiRemoveBrokerAccountCode = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_REMOVE_BROKER_ACCOUNT_PATH']"
			[Register ("BROKER_API_REMOVE_BROKER_ACCOUNT_PATH")]
			public const string BrokerApiRemoveBrokerAccountPath = (string) "/brokerApi/removeBrokerAccount";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_UPDATE_BRT_CODE']"
			[Register ("BROKER_API_UPDATE_BRT_CODE")]
			public const int BrokerApiUpdateBrtCode = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='BROKER_API_UPDATE_BRT_PATH']"
			[Register ("BROKER_API_UPDATE_BRT_PATH")]
			public const string BrokerApiUpdateBrtPath = (string) "/brokerApi/updateBrt";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='CONTENT_SCHEME']"
			[Register ("CONTENT_SCHEME")]
			public const string ContentScheme = (string) "content://";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='GENERATE_SHR_PATH']"
			[Register ("GENERATE_SHR_PATH")]
			public const string GenerateShrPath = (string) "/generateShr";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_ACQUIRE_TOKEN_INTERACTIVE_CODE']"
			[Register ("MSAL_ACQUIRE_TOKEN_INTERACTIVE_CODE")]
			public const int MsalAcquireTokenInteractiveCode = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_ACQUIRE_TOKEN_INTERACTIVE_PATH']"
			[Register ("MSAL_ACQUIRE_TOKEN_INTERACTIVE_PATH")]
			public const string MsalAcquireTokenInteractivePath = (string) "/acquireTokenInteractive";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_ACQUIRE_TOKEN_SILENT_CODE']"
			[Register ("MSAL_ACQUIRE_TOKEN_SILENT_CODE")]
			public const int MsalAcquireTokenSilentCode = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_ACQUIRE_TOKEN_SILENT_PATH']"
			[Register ("MSAL_ACQUIRE_TOKEN_SILENT_PATH")]
			public const string MsalAcquireTokenSilentPath = (string) "/acquireTokenSilent";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GENERATE_SHR_CODE']"
			[Register ("MSAL_GENERATE_SHR_CODE")]
			public const int MsalGenerateShrCode = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GET_ACCOUNTS_CODE']"
			[Register ("MSAL_GET_ACCOUNTS_CODE")]
			public const int MsalGetAccountsCode = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GET_ACCOUNTS_PATH']"
			[Register ("MSAL_GET_ACCOUNTS_PATH")]
			public const string MsalGetAccountsPath = (string) "/getAccounts";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GET_CURRENT_ACCOUNT_SHARED_DEVICE_CODE']"
			[Register ("MSAL_GET_CURRENT_ACCOUNT_SHARED_DEVICE_CODE")]
			public const int MsalGetCurrentAccountSharedDeviceCode = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GET_CURRENT_ACCOUNT_SHARED_DEVICE_PATH']"
			[Register ("MSAL_GET_CURRENT_ACCOUNT_SHARED_DEVICE_PATH")]
			public const string MsalGetCurrentAccountSharedDevicePath = (string) "/getCurrentAccountSharedDevice";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GET_DEVICE_MODE_CODE']"
			[Register ("MSAL_GET_DEVICE_MODE_CODE")]
			public const int MsalGetDeviceModeCode = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_GET_DEVICE_MODE_PATH']"
			[Register ("MSAL_GET_DEVICE_MODE_PATH")]
			public const string MsalGetDeviceModePath = (string) "/getDeviceMode";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_HELLO_PATH']"
			[Register ("MSAL_HELLO_PATH")]
			public const string MsalHelloPath = (string) "/hello";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_HELLO_URI_CODE']"
			[Register ("MSAL_HELLO_URI_CODE")]
			public const int MsalHelloUriCode = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_REMOVE_ACCOUNTS_CODE']"
			[Register ("MSAL_REMOVE_ACCOUNTS_CODE")]
			public const int MsalRemoveAccountsCode = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_REMOVE_ACCOUNTS_PATH']"
			[Register ("MSAL_REMOVE_ACCOUNTS_PATH")]
			public const string MsalRemoveAccountsPath = (string) "/removeAccounts";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_SIGN_OUT_FROM_SHARED_DEVICE_CODE']"
			[Register ("MSAL_SIGN_OUT_FROM_SHARED_DEVICE_CODE")]
			public const int MsalSignOutFromSharedDeviceCode = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.BrokerContentProvider']/field[@name='MSAL_SIGN_OUT_FROM_SHARED_DEVICE_PATH']"
			[Register ("MSAL_SIGN_OUT_FROM_SHARED_DEVICE_PATH")]
			public const string MsalSignOutFromSharedDevicePath = (string) "/signOutFromSharedDevice";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$BrokerContentProvider", typeof (BrokerContentProvider));

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

			internal BrokerContentProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$Browser", DoNotGenerateAcw=true)]
		public sealed partial class Browser : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='ACTION_CANCEL']"
			[Register ("ACTION_CANCEL")]
			public const string ActionCancel = (string) "com.microsoft.aad.adal:BrowserCancel";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='LOGOUT_ENDPOINT_V2']"
			[Register ("LOGOUT_ENDPOINT_V2")]
			public const string LogoutEndpointV2 = (string) "https://login.microsoftonline.com/common/oauth2/v2.0/logout";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='REQUEST_ID']"
			[Register ("REQUEST_ID")]
			public const string RequestId = (string) "com.microsoft.aad.adal:RequestId";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='REQUEST_MESSAGE']"
			[Register ("REQUEST_MESSAGE")]
			public const string RequestMessage = (string) "com.microsoft.aad.adal:BrowserRequestMessage";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE']"
			[Register ("RESPONSE")]
			public const string Response = (string) "com.microsoft.aad.adal:BrokerResponse";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE_AUTHENTICATION_EXCEPTION']"
			[Register ("RESPONSE_AUTHENTICATION_EXCEPTION")]
			public const string ResponseAuthenticationException = (string) "com.microsoft.aad.adal:AuthenticationException";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE_ERROR_CODE']"
			[Register ("RESPONSE_ERROR_CODE")]
			public const string ResponseErrorCode = (string) "com.microsoft.aad.adal:BrowserErrorCode";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE_ERROR_MESSAGE']"
			[Register ("RESPONSE_ERROR_MESSAGE")]
			public const string ResponseErrorMessage = (string) "com.microsoft.aad.adal:BrowserErrorMessage";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE_ERROR_SUBCODE']"
			[Register ("RESPONSE_ERROR_SUBCODE")]
			public const string ResponseErrorSubcode = (string) "com.microsoft.aad.adal:BrowserErrorSubCode";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE_FINAL_URL']"
			[Register ("RESPONSE_FINAL_URL")]
			public const string ResponseFinalUrl = (string) "com.microsoft.aad.adal:BrowserFinalUrl";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='RESPONSE_REQUEST_INFO']"
			[Register ("RESPONSE_REQUEST_INFO")]
			public const string ResponseRequestInfo = (string) "com.microsoft.aad.adal:BrowserRequestInfo";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='SSL_HELP_URL']"
			[Register ("SSL_HELP_URL")]
			public const string SslHelpUrl = (string) "https://go.microsoft.com/fwlink/?linkid=2138180";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='SUB_ERROR_UI_CANCEL']"
			[Register ("SUB_ERROR_UI_CANCEL")]
			public const string SubErrorUiCancel = (string) "cancel";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.Browser']/field[@name='WEBVIEW_INVALID_REQUEST']"
			[Register ("WEBVIEW_INVALID_REQUEST")]
			public const string WebviewInvalidRequest = (string) "Invalid request";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$Browser", typeof (Browser));

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

			internal Browser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.HeaderField']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$HeaderField", DoNotGenerateAcw=true)]
		public sealed partial class HeaderField : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.HeaderField']/field[@name='ACCEPT']"
			[Register ("ACCEPT")]
			public const string Accept = (string) "Accept";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.HeaderField']/field[@name='X_MS_CLITELEM']"
			[Register ("X_MS_CLITELEM")]
			public const string XMsClitelem = (string) "x-ms-clitelem";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$HeaderField", typeof (HeaderField));

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

			internal HeaderField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.HeaderField']/constructor[@name='AuthenticationConstants.HeaderField' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HeaderField () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.MediaType']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$MediaType", DoNotGenerateAcw=true)]
		public sealed partial class MediaType : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.MediaType']/field[@name='APPLICATION_JSON']"
			[Register ("APPLICATION_JSON")]
			public const string ApplicationJson = (string) "application/json";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$MediaType", typeof (MediaType));

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

			internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.MediaType']/constructor[@name='AuthenticationConstants.MediaType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MediaType () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2", DoNotGenerateAcw=true)]
		public sealed partial class OAuth2 : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='AAD_PREFERRED_USERNAME']"
			[Register ("AAD_PREFERRED_USERNAME")]
			public const string AadPreferredUsername = (string) "preferred_username";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='AAD_VERSION']"
			[Register ("AAD_VERSION")]
			public const string AadVersion = (string) "ver";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='AAD_VERSION_V1']"
			[Register ("AAD_VERSION_V1")]
			public const string AadVersionV1 = (string) "1.0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='AAD_VERSION_V2']"
			[Register ("AAD_VERSION_V2")]
			public const string AadVersionV2 = (string) "2.0";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ACCESS_TOKEN']"
			[Register ("ACCESS_TOKEN")]
			public const string AccessToken = (string) "access_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ADAL_CLIENT_FAMILY_ID']"
			[Register ("ADAL_CLIENT_FAMILY_ID")]
			public const string AdalClientFamilyId = (string) "foci";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='AUTHORITY']"
			[Register ("AUTHORITY")]
			public const string Authority = (string) "authority";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='AUTHORIZATION_CODE']"
			[Register ("AUTHORIZATION_CODE")]
			public const string AuthorizationCode = (string) "authorization_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLAIMS']"
			[Register ("CLAIMS")]
			public const string Claims = (string) "claims";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLIENT_CAPABILITIES_CLAIMS_LIST']"
			[Register ("CLIENT_CAPABILITIES_CLAIMS_LIST")]
			public const string ClientCapabilitiesClaimsList = (string) "xms_cc";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLIENT_CAPABILITY_ACCESS_TOKEN']"
			[Register ("CLIENT_CAPABILITY_ACCESS_TOKEN")]
			public const string ClientCapabilityAccessToken = (string) "access_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public const string ClientId = (string) "client_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLIENT_INFO']"
			[Register ("CLIENT_INFO")]
			public const string ClientInfo = (string) "client_info";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLIENT_INFO_TRUE']"
			[Register ("CLIENT_INFO_TRUE")]
			public const string ClientInfoTrue = (string) "1";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLIENT_SECRET']"
			[Register ("CLIENT_SECRET")]
			public const string ClientSecret = (string) "client_secret";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CLOUD_INSTANCE_HOST_NAME']"
			[Register ("CLOUD_INSTANCE_HOST_NAME")]
			public const string CloudInstanceHostName = (string) "cloud_instance_host_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='CODE']"
			[Register ("CODE")]
			public const string Code = (string) "code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const string Error = (string) "error";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ERROR_CODES']"
			[Register ("ERROR_CODES")]
			public const string ErrorCodes = (string) "error_codes";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ERROR_DESCRIPTION']"
			[Register ("ERROR_DESCRIPTION")]
			public const string ErrorDescription = (string) "error_description";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='EXPIRES_IN']"
			[Register ("EXPIRES_IN")]
			public const string ExpiresIn = (string) "expires_in";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='EXT_EXPIRES_IN']"
			[Register ("EXT_EXPIRES_IN")]
			public const string ExtExpiresIn = (string) "ext_expires_in";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='GRANT_TYPE']"
			[Register ("GRANT_TYPE")]
			public const string GrantType = (string) "grant_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='HAS_CHROME']"
			[Register ("HAS_CHROME")]
			public const string HasChrome = (string) "haschrome";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='HTTP_RESPONSE_BODY']"
			[Register ("HTTP_RESPONSE_BODY")]
			public const string HttpResponseBody = (string) "response_body";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='HTTP_RESPONSE_HEADER']"
			[Register ("HTTP_RESPONSE_HEADER")]
			public const string HttpResponseHeader = (string) "response_headers";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='HTTP_STATUS_CODE']"
			[Register ("HTTP_STATUS_CODE")]
			public const string HttpStatusCode = (string) "status_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN']"
			[Register ("ID_TOKEN")]
			public const string IdToken = (string) "id_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_EMAIL']"
			[Register ("ID_TOKEN_EMAIL")]
			public const string IdTokenEmail = (string) "email";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_FAMILY_NAME']"
			[Register ("ID_TOKEN_FAMILY_NAME")]
			public const string IdTokenFamilyName = (string) "family_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_GIVEN_NAME']"
			[Register ("ID_TOKEN_GIVEN_NAME")]
			public const string IdTokenGivenName = (string) "given_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_IDENTITY_PROVIDER']"
			[Register ("ID_TOKEN_IDENTITY_PROVIDER")]
			public const string IdTokenIdentityProvider = (string) "idp";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_OBJECT_ID']"
			[Register ("ID_TOKEN_OBJECT_ID")]
			public const string IdTokenObjectId = (string) "oid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_PASSWORD_CHANGE_URL']"
			[Register ("ID_TOKEN_PASSWORD_CHANGE_URL")]
			public const string IdTokenPasswordChangeUrl = (string) "pwd_url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_PASSWORD_EXPIRATION']"
			[Register ("ID_TOKEN_PASSWORD_EXPIRATION")]
			public const string IdTokenPasswordExpiration = (string) "pwd_exp";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_SUBJECT']"
			[Register ("ID_TOKEN_SUBJECT")]
			public const string IdTokenSubject = (string) "sub";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_TENANTID']"
			[Register ("ID_TOKEN_TENANTID")]
			public const string IdTokenTenantid = (string) "tid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_UNIQUE_NAME']"
			[Register ("ID_TOKEN_UNIQUE_NAME")]
			public const string IdTokenUniqueName = (string) "unique_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='ID_TOKEN_UPN']"
			[Register ("ID_TOKEN_UPN")]
			public const string IdTokenUpn = (string) "upn";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='IT_VER_PARAM']"
			[Register ("IT_VER_PARAM")]
			public const string ItVerParam = (string) "itver";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='REDIRECT_URI']"
			[Register ("REDIRECT_URI")]
			public const string RedirectUri = (string) "redirect_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='REFRESH_TOKEN']"
			[Register ("REFRESH_TOKEN")]
			public const string RefreshToken = (string) "refresh_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='RESPONSE_TYPE']"
			[Register ("RESPONSE_TYPE")]
			public const string ResponseType = (string) "response_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='SCOPE']"
			[Register ("SCOPE")]
			public const string Scope = (string) "scope";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='SESSION_KEY_JWE']"
			[Register ("SESSION_KEY_JWE")]
			public const string SessionKeyJwe = (string) "session_key_jwe";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='STATE']"
			[Register ("STATE")]
			public const string State = (string) "state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='SUBERROR']"
			[Register ("SUBERROR")]
			public const string Suberror = (string) "suberror";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2']/field[@name='TOKEN_TYPE']"
			[Register ("TOKEN_TYPE")]
			public const string TokenType = (string) "token_type";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2", typeof (OAuth2));

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

			internal OAuth2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2ErrorCode']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2ErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class OAuth2ErrorCode : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2ErrorCode']/field[@name='INTERACTION_REQUIRED']"
			[Register ("INTERACTION_REQUIRED")]
			public const string InteractionRequired = (string) "interaction_required";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2ErrorCode']/field[@name='INVALID_GRANT']"
			[Register ("INVALID_GRANT")]
			public const string InvalidGrant = (string) "invalid_grant";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2ErrorCode']/field[@name='UNAUTHORIZED_CLIENT']"
			[Register ("UNAUTHORIZED_CLIENT")]
			public const string UnauthorizedClient = (string) "unauthorized_client";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2ErrorCode", typeof (OAuth2ErrorCode));

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

			internal OAuth2ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2ErrorCode']/constructor[@name='AuthenticationConstants.OAuth2ErrorCode' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OAuth2ErrorCode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2Scopes']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2Scopes", DoNotGenerateAcw=true)]
		public sealed partial class OAuth2Scopes : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2Scopes']/field[@name='AZA_SCOPE']"
			[Register ("AZA_SCOPE")]
			public const string AzaScope = (string) "aza";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2Scopes']/field[@name='EMAIL']"
			[Register ("EMAIL")]
			public const string Email = (string) "email";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2Scopes']/field[@name='OFFLINE_ACCESS_SCOPE']"
			[Register ("OFFLINE_ACCESS_SCOPE")]
			public const string OfflineAccessScope = (string) "offline_access";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2Scopes']/field[@name='OPEN_ID_SCOPE']"
			[Register ("OPEN_ID_SCOPE")]
			public const string OpenIdScope = (string) "openid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2Scopes']/field[@name='PROFILE_SCOPE']"
			[Register ("PROFILE_SCOPE")]
			public const string ProfileScope = (string) "profile";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2Scopes", typeof (OAuth2Scopes));

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

			internal OAuth2Scopes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2SubErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class OAuth2SubErrorCode : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='ADDITIONAL_ACTION']"
			[Register ("ADDITIONAL_ACTION")]
			public const string AdditionalAction = (string) "additional_action";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='BAD_TOKEN']"
			[Register ("BAD_TOKEN")]
			public const string BadToken = (string) "bad_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='BASIC_ACTION']"
			[Register ("BASIC_ACTION")]
			public const string BasicAction = (string) "basic_action";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='CLIENT_MISMATCH']"
			[Register ("CLIENT_MISMATCH")]
			public const string ClientMismatch = (string) "client_mismatch";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='CONSENT_REQUIRED']"
			[Register ("CONSENT_REQUIRED")]
			public const string ConsentRequired = (string) "consent_required";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='DEVICE_AUTHENTICATION_FAILED']"
			[Register ("DEVICE_AUTHENTICATION_FAILED")]
			public const string DeviceAuthenticationFailed = (string) "device_authentication_failed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='MESSAGE_ONLY']"
			[Register ("MESSAGE_ONLY")]
			public const string MessageOnly = (string) "message_only";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='PROTECTION_POLICY_REQUIRED']"
			[Register ("PROTECTION_POLICY_REQUIRED")]
			public const string ProtectionPolicyRequired = (string) "protection_policy_required";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='TOKEN_EXPIRED']"
			[Register ("TOKEN_EXPIRED")]
			public const string TokenExpired = (string) "token_expired";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/field[@name='USER_PASSWORD_EXPIRED']"
			[Register ("USER_PASSWORD_EXPIRED")]
			public const string UserPasswordExpired = (string) "user_password_expired";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$OAuth2SubErrorCode", typeof (OAuth2SubErrorCode));

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

			internal OAuth2SubErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.OAuth2SubErrorCode']/constructor[@name='AuthenticationConstants.OAuth2SubErrorCode' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OAuth2SubErrorCode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.SdkPlatformFields']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$SdkPlatformFields", DoNotGenerateAcw=true)]
		public sealed partial class SdkPlatformFields : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.SdkPlatformFields']/field[@name='PRODUCT']"
			[Register ("PRODUCT")]
			public const string Product = (string) "x-client-SKU";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.SdkPlatformFields']/field[@name='PRODUCT_NAME_MSAL']"
			[Register ("PRODUCT_NAME_MSAL")]
			public const string ProductNameMsal = (string) "MSAL.Android";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.SdkPlatformFields']/field[@name='PRODUCT_NAME_MSAL_CPP']"
			[Register ("PRODUCT_NAME_MSAL_CPP")]
			public const string ProductNameMsalCpp = (string) "MSAL.xplat.Android";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.SdkPlatformFields']/field[@name='VERSION']"
			[Register ("VERSION")]
			public const string Version = (string) "x-client-Ver";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$SdkPlatformFields", typeof (SdkPlatformFields));

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

			internal SdkPlatformFields (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.SdkPlatformFields']/constructor[@name='AuthenticationConstants.SdkPlatformFields' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SdkPlatformFields () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$TelemetryEvents", DoNotGenerateAcw=true)]
		public sealed partial class TelemetryEvents : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='DECRYPTION_ERROR']"
			[Register ("DECRYPTION_ERROR")]
			public const string DecryptionError = (string) "decryption_error_v2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEYCHAIN_READ_END']"
			[Register ("KEYCHAIN_READ_END")]
			public const string KeychainReadEnd = (string) "keychain_read_v2_end";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEYCHAIN_READ_START']"
			[Register ("KEYCHAIN_READ_START")]
			public const string KeychainReadStart = (string) "keychain_read_v2_start";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEYCHAIN_WRITE_END']"
			[Register ("KEYCHAIN_WRITE_END")]
			public const string KeychainWriteEnd = (string) "keychain_write_v2_end";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEYCHAIN_WRITE_START']"
			[Register ("KEYCHAIN_WRITE_START")]
			public const string KeychainWriteStart = (string) "keychain_write_v2_start";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEY_CREATED']"
			[Register ("KEY_CREATED")]
			public const string KeyCreated = (string) "key_created_v2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEY_DISTRIBUTION_END']"
			[Register ("KEY_DISTRIBUTION_END")]
			public const string KeyDistributionEnd = (string) "key_distribution_v2_end";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEY_DISTRIBUTION_START']"
			[Register ("KEY_DISTRIBUTION_START")]
			public const string KeyDistributionStart = (string) "key_distribution_v2_start";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEY_RETRIEVAL_END']"
			[Register ("KEY_RETRIEVAL_END")]
			public const string KeyRetrievalEnd = (string) "key_retrieval_v2_end";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='KEY_RETRIEVAL_START']"
			[Register ("KEY_RETRIEVAL_START")]
			public const string KeyRetrievalStart = (string) "key_retrieval_v2_start";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='SHARED_DEVICE_REGISTERED']"
			[Register ("SHARED_DEVICE_REGISTERED")]
			public const string SharedDeviceRegistered = (string) "shared_device_registered";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='USER_SIGNED_INTO_SHARED_DEVICE']"
			[Register ("USER_SIGNED_INTO_SHARED_DEVICE")]
			public const string UserSignedIntoSharedDevice = (string) "user_signed_into_shared_device";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/field[@name='USER_SIGNED_OUT_FROM_SHARED_DEVICE']"
			[Register ("USER_SIGNED_OUT_FROM_SHARED_DEVICE")]
			public const string UserSignedOutFromSharedDevice = (string) "user_signed_out_from_shared_device";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$TelemetryEvents", typeof (TelemetryEvents));

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

			internal TelemetryEvents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.TelemetryEvents']/constructor[@name='AuthenticationConstants.TelemetryEvents' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TelemetryEvents () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIRequest']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$UIRequest", DoNotGenerateAcw=true)]
		public sealed partial class UIRequest : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIRequest']/field[@name='BROKER_FLOW']"
			[Register ("BROKER_FLOW")]
			public const int BrokerFlow = (int) 1003;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIRequest']/field[@name='BROWSER_FLOW']"
			[Register ("BROWSER_FLOW")]
			public const int BrowserFlow = (int) 1001;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIRequest']/field[@name='TOKEN_FLOW']"
			[Register ("TOKEN_FLOW")]
			public const int TokenFlow = (int) 1002;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$UIRequest", typeof (UIRequest));

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

			internal UIRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$UIResponse", DoNotGenerateAcw=true)]
		public sealed partial class UIResponse : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROKER_REQUEST_RESUME']"
			[Register ("BROKER_REQUEST_RESUME")]
			public const int BrokerRequestResume = (int) 2006;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_AUTHENTICATION_EXCEPTION']"
			[Register ("BROWSER_CODE_AUTHENTICATION_EXCEPTION")]
			public const int BrowserCodeAuthenticationException = (int) 2005;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_CANCEL']"
			[Register ("BROWSER_CODE_CANCEL")]
			public const int BrowserCodeCancel = (int) 2001;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_COMPLETE']"
			[Register ("BROWSER_CODE_COMPLETE")]
			public const int BrowserCodeComplete = (int) 2003;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_DEVICE_REGISTER']"
			[Register ("BROWSER_CODE_DEVICE_REGISTER")]
			public const int BrowserCodeDeviceRegister = (int) 2007;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_ERROR']"
			[Register ("BROWSER_CODE_ERROR")]
			public const int BrowserCodeError = (int) 2002;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_MDM']"
			[Register ("BROWSER_CODE_MDM")]
			public const int BrowserCodeMdm = (int) 2009;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='BROWSER_CODE_SDK_CANCEL']"
			[Register ("BROWSER_CODE_SDK_CANCEL")]
			public const int BrowserCodeSdkCancel = (int) 2008;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='AuthenticationConstants.UIResponse']/field[@name='TOKEN_BROKER_RESPONSE']"
			[Register ("TOKEN_BROKER_RESPONSE")]
			public const int TokenBrokerResponse = (int) 2004;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants$UIResponse", typeof (UIResponse));

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

			internal UIResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/AuthenticationConstants", typeof (AuthenticationConstants));

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

		internal AuthenticationConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
