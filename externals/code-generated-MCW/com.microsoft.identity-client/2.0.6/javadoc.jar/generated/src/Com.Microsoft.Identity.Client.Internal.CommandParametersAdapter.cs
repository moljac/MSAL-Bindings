using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/CommandParametersAdapter", DoNotGenerateAcw=true)]
	public partial class CommandParametersAdapter : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/field[@name='CLIENT_CAPABILITIES_CLAIM']"
		[Register ("CLIENT_CAPABILITIES_CLAIM")]
		public const string ClientCapabilitiesClaim = (string) "xms_cc";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/CommandParametersAdapter", typeof (CommandParametersAdapter));

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

		protected CommandParametersAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/constructor[@name='CommandParametersAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandParametersAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='addClientCapabilitiesToClaimsRequest' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.claims.ClaimsRequest'] and parameter[2][@type='java.lang.String']]"
		[Register ("addClientCapabilitiesToClaimsRequest", "(Lcom/microsoft/identity/client/claims/ClaimsRequest;Ljava/lang/String;)Lcom/microsoft/identity/client/claims/ClaimsRequest;", "")]
		public static unsafe global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest AddClientCapabilitiesToClaimsRequest (global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest cr, string clientCapabilities)
		{
			const string __id = "addClientCapabilitiesToClaimsRequest.(Lcom/microsoft/identity/client/claims/ClaimsRequest;Ljava/lang/String;)Lcom/microsoft/identity/client/claims/ClaimsRequest;";
			IntPtr native_clientCapabilities = JNIEnv.NewString (clientCapabilities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cr).Handle);
				__args [1] = new JniArgumentValue (native_clientCapabilities);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.ClaimsRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientCapabilities);
				global::System.GC.KeepAlive (cr);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='createCommandParameters' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache']]"
		[Register ("createCommandParameters", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;)Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters CreateCommandParameters (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration configuration, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache)
		{
			const string __id = "createCommandParameters.(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;)Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [1] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (tokenCache);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='createDeviceCodeFlowCommandParameters' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("createDeviceCodeFlowCommandParameters", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;[Ljava/lang/String;)Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters CreateDeviceCodeFlowCommandParameters (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration configuration, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache, string[] scopes)
		{
			const string __id = "createDeviceCodeFlowCommandParameters.(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;[Ljava/lang/String;)Lcom/microsoft/identity/common/internal/commands/parameters/DeviceCodeFlowCommandParameters;";
			IntPtr native_scopes = JNIEnv.NewArray (scopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [1] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				__args [2] = new JniArgumentValue (native_scopes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.DeviceCodeFlowCommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (scopes != null) {
					JNIEnv.CopyArray (native_scopes, scopes);
					JNIEnv.DeleteLocalRef (native_scopes);
				}
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (tokenCache);
				global::System.GC.KeepAlive (scopes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='createGenerateShrCommandParameters' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microsoft.identity.client.PoPAuthenticationScheme']]"
		[Register ("createGenerateShrCommandParameters", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Ljava/lang/String;Lcom/microsoft/identity/client/PoPAuthenticationScheme;)Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters CreateGenerateShrCommandParameters (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration clientConfig, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache oAuth2TokenCache, string homeAccountId, global::Com.Microsoft.Identity.Client.PoPAuthenticationScheme popParameters)
		{
			const string __id = "createGenerateShrCommandParameters.(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Ljava/lang/String;Lcom/microsoft/identity/client/PoPAuthenticationScheme;)Lcom/microsoft/identity/common/internal/commands/parameters/GenerateShrCommandParameters;";
			IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((clientConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientConfig).Handle);
				__args [1] = new JniArgumentValue ((oAuth2TokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oAuth2TokenCache).Handle);
				__args [2] = new JniArgumentValue (native_homeAccountId);
				__args [3] = new JniArgumentValue ((popParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) popParameters).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.GenerateShrCommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_homeAccountId);
				global::System.GC.KeepAlive (clientConfig);
				global::System.GC.KeepAlive (oAuth2TokenCache);
				global::System.GC.KeepAlive (popParameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='createInteractiveTokenCommandParameters' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[3][@type='com.microsoft.identity.client.AcquireTokenParameters']]"
		[Register ("createInteractiveTokenCommandParameters", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/client/AcquireTokenParameters;)Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters CreateInteractiveTokenCommandParameters (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration configuration, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache, global::Com.Microsoft.Identity.Client.AcquireTokenParameters parameters)
		{
			const string __id = "createInteractiveTokenCommandParameters.(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/client/AcquireTokenParameters;)Lcom/microsoft/identity/common/internal/commands/parameters/InteractiveTokenCommandParameters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [1] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				__args [2] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.InteractiveTokenCommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (tokenCache);
				global::System.GC.KeepAlive (parameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='createRemoveAccountCommandParameters' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[3][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
		[Register ("createRemoveAccountCommandParameters", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters CreateRemoveAccountCommandParameters (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration configuration, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache, global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord account)
		{
			const string __id = "createRemoveAccountCommandParameters.(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Lcom/microsoft/identity/common/internal/commands/parameters/RemoveAccountCommandParameters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [1] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				__args [2] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.RemoveAccountCommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (tokenCache);
				global::System.GC.KeepAlive (account);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal']/class[@name='CommandParametersAdapter']/method[@name='createSilentTokenCommandParameters' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration'] and parameter[2][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2TokenCache'] and parameter[3][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register ("createSilentTokenCommandParameters", "(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters CreateSilentTokenCommandParameters (global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration configuration, global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2TokenCache tokenCache, global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters parameters)
		{
			const string __id = "createSilentTokenCommandParameters.(Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2TokenCache;Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)Lcom/microsoft/identity/common/internal/commands/parameters/SilentTokenCommandParameters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [1] = new JniArgumentValue ((tokenCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenCache).Handle);
				__args [2] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.SilentTokenCommandParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (tokenCache);
				global::System.GC.KeepAlive (parameters);
			}
		}

	}
}
