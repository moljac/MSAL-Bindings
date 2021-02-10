using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/IDToken", DoNotGenerateAcw=true)]
	public partial class IDToken : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='ADDRESS']"
		[Register ("ADDRESS")]
		public const string Address = (string) "address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='BIRTHDATE']"
		[Register ("BIRTHDATE")]
		public const string Birthdate = (string) "birthdate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		public const string Email = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='EMAIL_VERIFIED']"
		[Register ("EMAIL_VERIFIED")]
		public const string EmailVerified = (string) "email_verified";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='FAMILY_NAME']"
		[Register ("FAMILY_NAME")]
		public const string FamilyName = (string) "family_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='GENDER']"
		[Register ("GENDER")]
		public const string Gender = (string) "gender";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='GIVEN_NAME']"
		[Register ("GIVEN_NAME")]
		public const string GivenName = (string) "given_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='LOCALE']"
		[Register ("LOCALE")]
		public const string Locale = (string) "locale";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='MIDDLE_NAME']"
		[Register ("MIDDLE_NAME")]
		public const string MiddleName = (string) "middle_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='NAME']"
		[Register ("NAME")]
		public const string Name = (string) "name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='NICKNAME']"
		[Register ("NICKNAME")]
		public const string Nickname = (string) "nickname";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='PHONE_NUMBER']"
		[Register ("PHONE_NUMBER")]
		public const string PhoneNumber = (string) "phone_number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='PHONE_NUMBER_VERIFIED']"
		[Register ("PHONE_NUMBER_VERIFIED")]
		public const string PhoneNumberVerified = (string) "phone_number_verified";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='PICTURE']"
		[Register ("PICTURE")]
		public const string Picture = (string) "picture";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='PREFERRED_USERNAME']"
		[Register ("PREFERRED_USERNAME")]
		public const string PreferredUsername = (string) "preferred_username";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='PROFILE']"
		[Register ("PROFILE")]
		public const string Profile = (string) "profile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='SUBJECT']"
		[Register ("SUBJECT")]
		public const string Subject = (string) "sub";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='UPDATED_AT']"
		[Register ("UPDATED_AT")]
		public const string UpdatedAt = (string) "updated_at";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='WEBSITE']"
		[Register ("WEBSITE")]
		public const string Website = (string) "website";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/field[@name='ZONEINFO']"
		[Register ("ZONEINFO")]
		public const string Zoneinfo = (string) "zoneinfo";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/IDToken", typeof (IDToken));

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

		protected IDToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/constructor[@name='IDToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe IDToken (string rawIdToken) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawIdToken = JNIEnv.NewString (rawIdToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawIdToken);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawIdToken);
			}
		}

		static Delegate cb_getRawIDToken;
#pragma warning disable 0169
		static Delegate GetGetRawIDTokenHandler ()
		{
			if (cb_getRawIDToken == null)
				cb_getRawIDToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawIDToken);
			return cb_getRawIDToken;
		}

		static IntPtr n_GetRawIDToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawIDToken);
		}
#pragma warning restore 0169

		public virtual unsafe string RawIDToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/method[@name='getRawIDToken' and count(parameter)=0]"
			[Register ("getRawIDToken", "()Ljava/lang/String;", "GetGetRawIDTokenHandler")]
			get {
				const string __id = "getRawIDToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenClaims;
#pragma warning disable 0169
		static Delegate GetGetTokenClaimsHandler ()
		{
			if (cb_getTokenClaims == null)
				cb_getTokenClaims = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenClaims);
			return cb_getTokenClaims;
		}

		static IntPtr n_GetTokenClaims (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (__this.TokenClaims);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, object> TokenClaims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/method[@name='getTokenClaims' and count(parameter)=0]"
			[Register ("getTokenClaims", "()Ljava/util/Map;", "GetGetTokenClaimsHandler")]
			get {
				const string __id = "getTokenClaims.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canEqual_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCanEqual_Ljava_lang_Object_Handler ()
		{
			if (cb_canEqual_Ljava_lang_Object_ == null)
				cb_canEqual_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanEqual_Ljava_lang_Object_);
			return cb_canEqual_Ljava_lang_Object_;
		}

		static bool n_CanEqual_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IDToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanEqual (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/method[@name='canEqual' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("canEqual", "(Ljava/lang/Object;)Z", "GetCanEqual_Ljava_lang_Object_Handler")]
		protected virtual unsafe bool CanEqual (global::Java.Lang.Object other)
		{
			const string __id = "canEqual.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='IDToken']/method[@name='parseJWT' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseJWT", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, object> ParseJWT (string rawIdToken)
		{
			const string __id = "parseJWT.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_rawIdToken = JNIEnv.NewString (rawIdToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawIdToken);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawIdToken);
			}
		}

	}
}
