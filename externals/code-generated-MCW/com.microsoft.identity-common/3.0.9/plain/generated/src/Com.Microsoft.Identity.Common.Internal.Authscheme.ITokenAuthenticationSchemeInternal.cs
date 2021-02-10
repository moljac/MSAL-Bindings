using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='ITokenAuthenticationSchemeInternal']"
	[Register ("com/microsoft/identity/common/internal/authscheme/ITokenAuthenticationSchemeInternal", "", "Com.Microsoft.Identity.Common.Internal.Authscheme.ITokenAuthenticationSchemeInternalInvoker")]
	public partial interface ITokenAuthenticationSchemeInternal : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='ITokenAuthenticationSchemeInternal']/method[@name='getAccessTokenForScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccessTokenForScheme", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAccessTokenForScheme_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Internal.Authscheme.ITokenAuthenticationSchemeInternalInvoker, Microsoft.Identity.Common")]
		string GetAccessTokenForScheme (string p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/ITokenAuthenticationSchemeInternal", DoNotGenerateAcw=true)]
	internal partial class ITokenAuthenticationSchemeInternalInvoker : global::Java.Lang.Object, ITokenAuthenticationSchemeInternal {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/ITokenAuthenticationSchemeInternal", typeof (ITokenAuthenticationSchemeInternalInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITokenAuthenticationSchemeInternal GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenAuthenticationSchemeInternal> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.authscheme.ITokenAuthenticationSchemeInternal"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenAuthenticationSchemeInternalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.ITokenAuthenticationSchemeInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAccessTokenForScheme (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccessTokenForScheme_Ljava_lang_String_;
		public unsafe string GetAccessTokenForScheme (string p0)
		{
			if (id_getAccessTokenForScheme_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccessTokenForScheme_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccessTokenForScheme", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessTokenForScheme_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
