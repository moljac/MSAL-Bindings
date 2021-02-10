using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IResult']"
	[Register ("com/microsoft/identity/common/internal/providers/oauth2/IResult", "", "Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResultInvoker")]
	public partial interface IResult : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse ErrorResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IResult']/method[@name='getErrorResponse' and count(parameter)=0]"
			[Register ("getErrorResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/IErrorResponse;", "GetGetErrorResponseHandler:Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		bool Success {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IResult']/method[@name='getSuccess' and count(parameter)=0]"
			[Register ("getSuccess", "()Z", "GetGetSuccessHandler:Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse SuccessResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/interface[@name='IResult']/method[@name='getSuccessResponse' and count(parameter)=0]"
			[Register ("getSuccessResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/ISuccessResponse;", "GetGetSuccessResponseHandler:Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResultInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/IResult", DoNotGenerateAcw=true)]
	internal partial class IResultInvoker : global::Java.Lang.Object, IResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/IResult", typeof (IResultInvoker));

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

		public static IResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.providers.oauth2.IResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getErrorResponse;
#pragma warning disable 0169
		static Delegate GetGetErrorResponseHandler ()
		{
			if (cb_getErrorResponse == null)
				cb_getErrorResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorResponse);
			return cb_getErrorResponse;
		}

		static IntPtr n_GetErrorResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorResponse);
		}
#pragma warning restore 0169

		IntPtr id_getErrorResponse;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse ErrorResponse {
			get {
				if (id_getErrorResponse == IntPtr.Zero)
					id_getErrorResponse = JNIEnv.GetMethodID (class_ref, "getErrorResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/IErrorResponse;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IErrorResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSuccess;
#pragma warning disable 0169
		static Delegate GetGetSuccessHandler ()
		{
			if (cb_getSuccess == null)
				cb_getSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetSuccess);
			return cb_getSuccess;
		}

		static bool n_GetSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Success;
		}
#pragma warning restore 0169

		IntPtr id_getSuccess;
		public unsafe bool Success {
			get {
				if (id_getSuccess == IntPtr.Zero)
					id_getSuccess = JNIEnv.GetMethodID (class_ref, "getSuccess", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSuccess);
			}
		}

		static Delegate cb_getSuccessResponse;
#pragma warning disable 0169
		static Delegate GetGetSuccessResponseHandler ()
		{
			if (cb_getSuccessResponse == null)
				cb_getSuccessResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSuccessResponse);
			return cb_getSuccessResponse;
		}

		static IntPtr n_GetSuccessResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuccessResponse);
		}
#pragma warning restore 0169

		IntPtr id_getSuccessResponse;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse SuccessResponse {
			get {
				if (id_getSuccessResponse == IntPtr.Zero)
					id_getSuccessResponse = JNIEnv.GetMethodID (class_ref, "getSuccessResponse", "()Lcom/microsoft/identity/common/internal/providers/oauth2/ISuccessResponse;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ISuccessResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuccessResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
