using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands.Parameters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters", DoNotGenerateAcw=true)]
	public partial class TokenCommandParameters : global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/parameters/TokenCommandParameters", typeof (TokenCommandParameters));

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

		protected TokenCommandParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/microsoft/identity/common/internal/dto/IAccountRecord;", "GetGetAccountHandler")]
			get {
				const string __id = "getAccount.()Lcom/microsoft/identity/common/internal/dto/IAccountRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IAccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthenticationScheme;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationSchemeHandler ()
		{
			if (cb_getAuthenticationScheme == null)
				cb_getAuthenticationScheme = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthenticationScheme);
			return cb_getAuthenticationScheme;
		}

		static IntPtr n_GetAuthenticationScheme (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthenticationScheme);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme AuthenticationScheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='getAuthenticationScheme' and count(parameter)=0]"
			[Register ("getAuthenticationScheme", "()Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;", "GetGetAuthenticationSchemeHandler")]
			get {
				const string __id = "getAuthenticationScheme.()Lcom/microsoft/identity/common/internal/authscheme/AbstractAuthenticationScheme;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthority;
#pragma warning disable 0169
		static Delegate GetGetAuthorityHandler ()
		{
			if (cb_getAuthority == null)
				cb_getAuthority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthority);
			return cb_getAuthority;
		}

		static IntPtr n_GetAuthority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Authority);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='getAuthority' and count(parameter)=0]"
			[Register ("getAuthority", "()Lcom/microsoft/identity/common/internal/authorities/Authority;", "GetGetAuthorityHandler")]
			get {
				const string __id = "getAuthority.()Lcom/microsoft/identity/common/internal/authorities/Authority;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClaimsRequestJson;
#pragma warning disable 0169
		static Delegate GetGetClaimsRequestJsonHandler ()
		{
			if (cb_getClaimsRequestJson == null)
				cb_getClaimsRequestJson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaimsRequestJson);
			return cb_getClaimsRequestJson;
		}

		static IntPtr n_GetClaimsRequestJson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClaimsRequestJson);
		}
#pragma warning restore 0169

		public virtual unsafe string ClaimsRequestJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='getClaimsRequestJson' and count(parameter)=0]"
			[Register ("getClaimsRequestJson", "()Ljava/lang/String;", "GetGetClaimsRequestJsonHandler")]
			get {
				const string __id = "getClaimsRequestJson.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isForceRefresh;
#pragma warning disable 0169
		static Delegate GetIsForceRefreshHandler ()
		{
			if (cb_isForceRefresh == null)
				cb_isForceRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsForceRefresh);
			return cb_isForceRefresh;
		}

		static bool n_IsForceRefresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForceRefresh;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsForceRefresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='isForceRefresh' and count(parameter)=0]"
			[Register ("isForceRefresh", "()Z", "GetIsForceRefreshHandler")]
			get {
				const string __id = "isForceRefresh.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Scopes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/Set;", "GetGetScopesHandler")]
			get {
				const string __id = "getScopes.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_validate;
#pragma warning disable 0169
		static Delegate GetValidateHandler ()
		{
			if (cb_validate == null)
				cb_validate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Validate);
			return cb_validate;
		}

		static void n_Validate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.TokenCommandParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Validate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands.parameters']/class[@name='TokenCommandParameters']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "GetValidateHandler")]
		public virtual unsafe void Validate ()
		{
			const string __id = "validate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
