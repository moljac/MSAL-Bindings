using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authorities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/Authority", DoNotGenerateAcw=true)]
	public abstract partial class Authority : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/field[@name='B2C']"
		[Register ("B2C")]
		public const string B2c = (string) "B2C";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/field[@name='mAuthorityTypeString']"
		[Register ("mAuthorityTypeString")]
		protected string MAuthorityTypeString {
			get {
				const string __id = "mAuthorityTypeString.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAuthorityTypeString.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/field[@name='mAuthorityUrl']"
		[Register ("mAuthorityUrl")]
		protected string MAuthorityUrl {
			get {
				const string __id = "mAuthorityUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAuthorityUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/field[@name='mIsDefault']"
		[Register ("mIsDefault")]
		protected bool MIsDefault {
			get {
				const string __id = "mIsDefault.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsDefault.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/field[@name='mKnownToDeveloper']"
		[Register ("mKnownToDeveloper")]
		protected bool MKnownToDeveloper {
			get {
				const string __id = "mKnownToDeveloper.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mKnownToDeveloper.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/field[@name='mKnownToMicrosoft']"
		[Register ("mKnownToMicrosoft")]
		protected bool MKnownToMicrosoft {
			get {
				const string __id = "mKnownToMicrosoft.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mKnownToMicrosoft.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority.KnownAuthorityResult']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/Authority$KnownAuthorityResult", DoNotGenerateAcw=true)]
		public partial class KnownAuthorityResult : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/Authority$KnownAuthorityResult", typeof (KnownAuthorityResult));

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

			protected KnownAuthorityResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate cb_getClientException;
#pragma warning disable 0169
			static Delegate GetGetClientExceptionHandler ()
			{
				if (cb_getClientException == null)
					cb_getClientException = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientException);
				return cb_getClientException;
			}

			static IntPtr n_GetClientException (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority.KnownAuthorityResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ClientException);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Microsoft.Identity.Common.Exception.ClientException ClientException {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority.KnownAuthorityResult']/method[@name='getClientException' and count(parameter)=0]"
				[Register ("getClientException", "()Lcom/microsoft/identity/common/exception/ClientException;", "GetGetClientExceptionHandler")]
				get {
					const string __id = "getClientException.()Lcom/microsoft/identity/common/exception/ClientException;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ClientException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getKnown;
#pragma warning disable 0169
			static Delegate GetGetKnownHandler ()
			{
				if (cb_getKnown == null)
					cb_getKnown = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetKnown);
				return cb_getKnown;
			}

			static bool n_GetKnown (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority.KnownAuthorityResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Known;
			}
#pragma warning restore 0169

			public virtual unsafe bool Known {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority.KnownAuthorityResult']/method[@name='getKnown' and count(parameter)=0]"
				[Register ("getKnown", "()Z", "GetGetKnownHandler")]
				get {
					const string __id = "getKnown.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/Authority", typeof (Authority));

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

		protected Authority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/constructor[@name='Authority' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Authority () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAuthorityTypeString;
#pragma warning disable 0169
		static Delegate GetGetAuthorityTypeStringHandler ()
		{
			if (cb_getAuthorityTypeString == null)
				cb_getAuthorityTypeString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityTypeString);
			return cb_getAuthorityTypeString;
		}

		static IntPtr n_GetAuthorityTypeString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorityTypeString);
		}
#pragma warning restore 0169

		public virtual unsafe string AuthorityTypeString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getAuthorityTypeString' and count(parameter)=0]"
			[Register ("getAuthorityTypeString", "()Ljava/lang/String;", "GetGetAuthorityTypeStringHandler")]
			get {
				const string __id = "getAuthorityTypeString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorityURL;
#pragma warning disable 0169
		static Delegate GetGetAuthorityURLHandler ()
		{
			if (cb_getAuthorityURL == null)
				cb_getAuthorityURL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityURL);
			return cb_getAuthorityURL;
		}

		static IntPtr n_GetAuthorityURL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorityURL);
		}
#pragma warning restore 0169

		public abstract global::Java.Net.URL AuthorityURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getAuthorityURL' and count(parameter)=0]"
			[Register ("getAuthorityURL", "()Ljava/net/URL;", "GetGetAuthorityURLHandler")]
			get; 
		}

		static Delegate cb_getAuthorityUri;
#pragma warning disable 0169
		static Delegate GetGetAuthorityUriHandler ()
		{
			if (cb_getAuthorityUri == null)
				cb_getAuthorityUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorityUri);
			return cb_getAuthorityUri;
		}

		static IntPtr n_GetAuthorityUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthorityUri);
		}
#pragma warning restore 0169

		public abstract global::Android.Net.Uri AuthorityUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getAuthorityUri' and count(parameter)=0]"
			[Register ("getAuthorityUri", "()Landroid/net/Uri;", "GetGetAuthorityUriHandler")]
			get; 
		}

		static Delegate cb_getDefault;
#pragma warning disable 0169
		static Delegate GetGetDefaultHandler ()
		{
			if (cb_getDefault == null)
				cb_getDefault = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetDefault);
			return cb_getDefault;
		}

		static bool n_GetDefault (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Default;
		}
#pragma warning restore 0169

		public virtual unsafe bool Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Z", "GetGetDefaultHandler")]
			get {
				const string __id = "getDefault.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getKnownToDeveloper;
#pragma warning disable 0169
		static Delegate GetGetKnownToDeveloperHandler ()
		{
			if (cb_getKnownToDeveloper == null)
				cb_getKnownToDeveloper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetKnownToDeveloper);
			return cb_getKnownToDeveloper;
		}

		static bool n_GetKnownToDeveloper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KnownToDeveloper;
		}
#pragma warning restore 0169

		protected virtual unsafe bool KnownToDeveloper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getKnownToDeveloper' and count(parameter)=0]"
			[Register ("getKnownToDeveloper", "()Z", "GetGetKnownToDeveloperHandler")]
			get {
				const string __id = "getKnownToDeveloper.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getKnownToMicrosoft;
#pragma warning disable 0169
		static Delegate GetGetKnownToMicrosoftHandler ()
		{
			if (cb_getKnownToMicrosoft == null)
				cb_getKnownToMicrosoft = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetKnownToMicrosoft);
			return cb_getKnownToMicrosoft;
		}

		static bool n_GetKnownToMicrosoft (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KnownToMicrosoft;
		}
#pragma warning restore 0169

		protected virtual unsafe bool KnownToMicrosoft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getKnownToMicrosoft' and count(parameter)=0]"
			[Register ("getKnownToMicrosoft", "()Z", "GetGetKnownToMicrosoftHandler")]
			get {
				const string __id = "getKnownToMicrosoft.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='addKnownAuthorities' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microsoft.identity.common.internal.authorities.Authority&gt;']]"
		[Register ("addKnownAuthorities", "(Ljava/util/List;)V", "")]
		public static unsafe void AddKnownAuthorities (global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> authorities)
		{
			const string __id = "addKnownAuthorities.(Ljava/util/List;)V";
			IntPtr native_authorities = global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority>.ToLocalJniHandle (authorities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authorities);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authorities);
				global::System.GC.KeepAlive (authorities);
			}
		}

		static Delegate cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_;
#pragma warning disable 0169
		static Delegate GetCreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_Handler ()
		{
			if (cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_ == null)
				cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_);
			return cb_createOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_;
		}

		static IntPtr n_CreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOAuth2Strategy (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='createOAuth2Strategy' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2StrategyParameters']]"
		[Register ("createOAuth2Strategy", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;", "GetCreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_Handler")]
		public abstract global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy CreateOAuth2Strategy (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getAuthorityFromAuthorityUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAuthorityFromAuthorityUrl", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/authorities/Authority;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority GetAuthorityFromAuthorityUrl (string authorityUrl)
		{
			const string __id = "getAuthorityFromAuthorityUrl.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/authorities/Authority;";
			IntPtr native_authorityUrl = JNIEnv.NewString (authorityUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authorityUrl);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authorityUrl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getKnownAuthorityResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.authorities.Authority']]"
		[Register ("getKnownAuthorityResult", "(Lcom/microsoft/identity/common/internal/authorities/Authority;)Lcom/microsoft/identity/common/internal/authorities/Authority$KnownAuthorityResult;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority.KnownAuthorityResult GetKnownAuthorityResult (global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority authority)
		{
			const string __id = "getKnownAuthorityResult.(Lcom/microsoft/identity/common/internal/authorities/Authority;)Lcom/microsoft/identity/common/internal/authorities/Authority$KnownAuthorityResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((authority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authority).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority.KnownAuthorityResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (authority);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='isKnownAuthority' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.authorities.Authority']]"
		[Register ("isKnownAuthority", "(Lcom/microsoft/identity/common/internal/authorities/Authority;)Z", "")]
		public static unsafe bool IsKnownAuthority (global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority authority)
		{
			const string __id = "isKnownAuthority.(Lcom/microsoft/identity/common/internal/authorities/Authority;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((authority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authority).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (authority);
			}
		}

		static Delegate cb_setDefault_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetDefault_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setDefault_Ljava_lang_Boolean_ == null)
				cb_setDefault_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDefault_Ljava_lang_Boolean_);
			return cb_setDefault_Ljava_lang_Boolean_;
		}

		static void n_SetDefault_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_isDefault)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var isDefault = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_isDefault, JniHandleOwnership.DoNotTransfer);
			__this.SetDefault (isDefault);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='setDefault' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setDefault", "(Ljava/lang/Boolean;)V", "GetSetDefault_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetDefault (global::Java.Lang.Boolean isDefault)
		{
			const string __id = "setDefault.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((isDefault == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isDefault).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (isDefault);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/Authority", DoNotGenerateAcw=true)]
	internal partial class AuthorityInvoker : Authority {
		public AuthorityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/Authority", typeof (AuthorityInvoker));

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

		public override unsafe global::Java.Net.URL AuthorityURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getAuthorityURL' and count(parameter)=0]"
			[Register ("getAuthorityURL", "()Ljava/net/URL;", "GetGetAuthorityURLHandler")]
			get {
				const string __id = "getAuthorityURL.()Ljava/net/URL;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Net.Uri AuthorityUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='getAuthorityUri' and count(parameter)=0]"
			[Register ("getAuthorityUri", "()Landroid/net/Uri;", "GetGetAuthorityUriHandler")]
			get {
				const string __id = "getAuthorityUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='Authority']/method[@name='createOAuth2Strategy' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.OAuth2StrategyParameters']]"
		[Register ("createOAuth2Strategy", "(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;", "GetCreateOAuth2Strategy_Lcom_microsoft_identity_common_internal_providers_oauth2_OAuth2StrategyParameters_Handler")]
		public override unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy CreateOAuth2Strategy (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2StrategyParameters p0)
		{
			const string __id = "createOAuth2Strategy.(Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2StrategyParameters;)Lcom/microsoft/identity/common/internal/providers/oauth2/OAuth2Strategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.OAuth2Strategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
