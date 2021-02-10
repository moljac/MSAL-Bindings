using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IErrorResponse']"
	[Register ("com/microsoft/identity/common/internal/providers/oauth2/IErrorResponse", "", "Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponseInvoker")]
	public partial interface IErrorResponse : IJavaObject, IJavaPeerable {
		string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IErrorResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler:Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponseInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string ErrorDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IErrorResponse']/method[@name='getErrorDescription' and count(parameter)=0]"
			[Register ("getErrorDescription", "()Ljava/lang/String;", "GetGetErrorDescriptionHandler:Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponseInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/IErrorResponse", DoNotGenerateAcw=true)]
	internal partial class IErrorResponseInvoker : global::Java.Lang.Object, IErrorResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/IErrorResponse", typeof (IErrorResponseInvoker));

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

		public static IErrorResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IErrorResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.providers.oauth2.IErrorResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IErrorResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		IntPtr id_getError;
		public unsafe string Error {
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getErrorDescription;
#pragma warning disable 0169
		static Delegate GetGetErrorDescriptionHandler ()
		{
			if (cb_getErrorDescription == null)
				cb_getErrorDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorDescription);
			return cb_getErrorDescription;
		}

		static IntPtr n_GetErrorDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorDescription);
		}
#pragma warning restore 0169

		IntPtr id_getErrorDescription;
		public unsafe string ErrorDescription {
			get {
				if (id_getErrorDescription == IntPtr.Zero)
					id_getErrorDescription = JNIEnv.GetMethodID (class_ref, "getErrorDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
