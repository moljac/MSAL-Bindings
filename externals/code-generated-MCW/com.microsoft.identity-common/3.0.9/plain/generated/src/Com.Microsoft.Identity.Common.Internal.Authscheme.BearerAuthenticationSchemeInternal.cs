using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='BearerAuthenticationSchemeInternal']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/BearerAuthenticationSchemeInternal", DoNotGenerateAcw=true)]
	public partial class BearerAuthenticationSchemeInternal : global::Com.Microsoft.Identity.Common.Internal.Authscheme.TokenAuthenticationScheme, global::Com.Microsoft.Identity.Common.Internal.Authscheme.ITokenAuthenticationSchemeInternal {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='BearerAuthenticationSchemeInternal']/field[@name='SCHEME_BEARER']"
		[Register ("SCHEME_BEARER")]
		public const string SchemeBearer = (string) "Bearer";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/BearerAuthenticationSchemeInternal", typeof (BearerAuthenticationSchemeInternal));

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

		protected BearerAuthenticationSchemeInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='BearerAuthenticationSchemeInternal']/constructor[@name='BearerAuthenticationSchemeInternal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BearerAuthenticationSchemeInternal () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAccessTokenForScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenForScheme_Ljava_lang_String_Handler ()
		{
			if (cb_getAccessTokenForScheme_Ljava_lang_String_ == null)
				cb_getAccessTokenForScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccessTokenForScheme_Ljava_lang_String_);
			return cb_getAccessTokenForScheme_Ljava_lang_String_;
		}

		static IntPtr n_GetAccessTokenForScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.BearerAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAccessTokenForScheme (accessToken));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/class[@name='BearerAuthenticationSchemeInternal']/method[@name='getAccessTokenForScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccessTokenForScheme", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAccessTokenForScheme_Ljava_lang_String_Handler")]
		public override unsafe string GetAccessTokenForScheme (string accessToken)
		{
			const string __id = "getAccessTokenForScheme.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_accessToken);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
			}
		}

	}
}
