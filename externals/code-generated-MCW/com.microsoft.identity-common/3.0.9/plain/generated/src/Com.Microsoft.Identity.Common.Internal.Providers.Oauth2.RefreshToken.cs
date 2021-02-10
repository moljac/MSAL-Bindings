using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/RefreshToken", DoNotGenerateAcw=true)]
	public abstract partial class RefreshToken : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/RefreshToken", typeof (RefreshToken));

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

		protected RefreshToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResponse']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V", "")]
		public unsafe RefreshToken (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResponse response) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResponse;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (response);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RefreshToken (string rawRefreshToken) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawRefreshToken = JNIEnv.NewString (rawRefreshToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawRefreshToken);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawRefreshToken);
			}
		}

		static Delegate cb_getTokenReceivedTime;
#pragma warning disable 0169
		static Delegate GetGetTokenReceivedTimeHandler ()
		{
			if (cb_getTokenReceivedTime == null)
				cb_getTokenReceivedTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTokenReceivedTime);
			return cb_getTokenReceivedTime;
		}

		static long n_GetTokenReceivedTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TokenReceivedTime;
		}
#pragma warning restore 0169

		public virtual unsafe long TokenReceivedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getTokenReceivedTime' and count(parameter)=0]"
			[Register ("getTokenReceivedTime", "()J", "GetGetTokenReceivedTimeHandler")]
			get {
				const string __id = "getTokenReceivedTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenHandler ()
		{
			if (cb_getRefreshToken == null)
				cb_getRefreshToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshToken);
			return cb_getRefreshToken;
		}

		static IntPtr n_GetRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetRefreshToken ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getRefreshToken' and count(parameter)=0]"
		[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
		public virtual unsafe string GetRefreshToken ()
		{
			const string __id = "getRefreshToken.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRawRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRawRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_setRawRefreshToken_Ljava_lang_String_ == null)
				cb_setRawRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRawRefreshToken_Ljava_lang_String_);
			return cb_setRawRefreshToken_Ljava_lang_String_;
		}

		static void n_SetRawRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rawRefreshToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rawRefreshToken = JNIEnv.GetString (native_rawRefreshToken, JniHandleOwnership.DoNotTransfer);
			__this.SetRawRefreshToken (rawRefreshToken);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='setRawRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRawRefreshToken", "(Ljava/lang/String;)V", "GetSetRawRefreshToken_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetRawRefreshToken (string rawRefreshToken)
		{
			const string __id = "setRawRefreshToken.(Ljava/lang/String;)V";
			IntPtr native_rawRefreshToken = JNIEnv.NewString (rawRefreshToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawRefreshToken);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawRefreshToken);
			}
		}

		static Delegate cb_setTokenReceivedTime_J;
#pragma warning disable 0169
		static Delegate GetSetTokenReceivedTime_JHandler ()
		{
			if (cb_setTokenReceivedTime_J == null)
				cb_setTokenReceivedTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetTokenReceivedTime_J);
			return cb_setTokenReceivedTime_J;
		}

		static void n_SetTokenReceivedTime_J (IntPtr jnienv, IntPtr native__this, long tokenReceivedTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTokenReceivedTime (tokenReceivedTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='setTokenReceivedTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTokenReceivedTime", "(J)V", "GetSetTokenReceivedTime_JHandler")]
		protected virtual unsafe void SetTokenReceivedTime (long tokenReceivedTime)
		{
			const string __id = "setTokenReceivedTime.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tokenReceivedTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public abstract string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get; 
		}

		static Delegate cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnvironment);
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		public abstract string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get; 
		}

		static Delegate cb_getFamilyId;
#pragma warning disable 0169
		static Delegate GetGetFamilyIdHandler ()
		{
			if (cb_getFamilyId == null)
				cb_getFamilyId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFamilyId);
			return cb_getFamilyId;
		}

		static IntPtr n_GetFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyId);
		}
#pragma warning restore 0169

		public abstract string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler")]
			get; 
		}

		static Delegate cb_getHomeAccountId;
#pragma warning disable 0169
		static Delegate GetGetHomeAccountIdHandler ()
		{
			if (cb_getHomeAccountId == null)
				cb_getHomeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHomeAccountId);
			return cb_getHomeAccountId;
		}

		static IntPtr n_GetHomeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		public abstract string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get; 
		}

		static Delegate cb_getSecret;
#pragma warning disable 0169
		static Delegate GetGetSecretHandler ()
		{
			if (cb_getSecret == null)
				cb_getSecret = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecret);
			return cb_getSecret;
		}

		static IntPtr n_GetSecret (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Secret);
		}
#pragma warning restore 0169

		public abstract string Secret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getSecret' and count(parameter)=0]"
			[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
			get; 
		}

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Target);
		}
#pragma warning restore 0169

		public abstract string Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/String;", "GetGetTargetHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/RefreshToken", DoNotGenerateAcw=true)]
	internal partial class RefreshTokenInvoker : RefreshToken {
		public RefreshTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/RefreshToken", typeof (RefreshTokenInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get {
				const string __id = "getEnvironment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler")]
			get {
				const string __id = "getFamilyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler")]
			get {
				const string __id = "getHomeAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Secret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getSecret' and count(parameter)=0]"
			[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
			get {
				const string __id = "getSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='RefreshToken']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/String;", "GetGetTargetHandler")]
			get {
				const string __id = "getTarget.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
