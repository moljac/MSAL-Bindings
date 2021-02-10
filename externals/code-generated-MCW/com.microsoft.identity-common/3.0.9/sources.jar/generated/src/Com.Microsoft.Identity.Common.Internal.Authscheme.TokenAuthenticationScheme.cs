using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='TokenAuthenticationScheme']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/TokenAuthenticationScheme", DoNotGenerateAcw=true)]
	public abstract partial class TokenAuthenticationScheme : global::Com.Microsoft.Identity.Common.Internal.Authscheme.AbstractAuthenticationScheme, global::Com.Microsoft.Identity.Common.Internal.Authscheme.ITokenAuthenticationSchemeInternal {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='TokenAuthenticationScheme']/field[@name='SCHEME_DELIMITER']"
		[Register ("SCHEME_DELIMITER")]
		public const string SchemeDelimiter = (string) " ";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/TokenAuthenticationScheme", typeof (TokenAuthenticationScheme));

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

		protected TokenAuthenticationScheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAccessTokenForScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenForScheme_Ljava_lang_String_Handler ()
		{
			if (cb_getAccessTokenForScheme_Ljava_lang_String_ == null)
				cb_getAccessTokenForScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccessTokenForScheme_Ljava_lang_String_);
			return cb_getAccessTokenForScheme_Ljava_lang_String_;
		}

		static IntPtr n_GetAccessTokenForScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.TokenAuthenticationScheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAccessTokenForScheme (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='ITokenAuthenticationSchemeInternal']/method[@name='getAccessTokenForScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccessTokenForScheme", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAccessTokenForScheme_Ljava_lang_String_Handler")]
		public abstract string GetAccessTokenForScheme (string p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/TokenAuthenticationScheme", DoNotGenerateAcw=true)]
	internal partial class TokenAuthenticationSchemeInvoker : TokenAuthenticationScheme {
		public TokenAuthenticationSchemeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/TokenAuthenticationScheme", typeof (TokenAuthenticationSchemeInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='ITokenAuthenticationSchemeInternal']/method[@name='getAccessTokenForScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccessTokenForScheme", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAccessTokenForScheme_Ljava_lang_String_Handler")]
		public override unsafe string GetAccessTokenForScheme (string p0)
		{
			const string __id = "getAccessTokenForScheme.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
