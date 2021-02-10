using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/interface[@name='ILocalAuthenticationCallback']"
	[Register ("com/microsoft/identity/common/internal/request/ILocalAuthenticationCallback", "", "Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallbackInvoker")]
	public partial interface ILocalAuthenticationCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/interface[@name='ILocalAuthenticationCallback']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallbackInvoker, Microsoft.Identity.Common")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/interface[@name='ILocalAuthenticationCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.exception.BaseException']]"
		[Register ("onError", "(Lcom/microsoft/identity/common/exception/BaseException;)V", "GetOnError_Lcom_microsoft_identity_common_exception_BaseException_Handler:Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallbackInvoker, Microsoft.Identity.Common")]
		void OnError (global::Com.Microsoft.Identity.Common.Exception.BaseException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.request']/interface[@name='ILocalAuthenticationCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.result.ILocalAuthenticationResult']]"
		[Register ("onSuccess", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)V", "GetOnSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Handler:Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallbackInvoker, Microsoft.Identity.Common")]
		void OnSuccess (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/request/ILocalAuthenticationCallback", DoNotGenerateAcw=true)]
	internal partial class ILocalAuthenticationCallbackInvoker : global::Java.Lang.Object, ILocalAuthenticationCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/request/ILocalAuthenticationCallback", typeof (ILocalAuthenticationCallbackInvoker));

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

		public static ILocalAuthenticationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocalAuthenticationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.request.ILocalAuthenticationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocalAuthenticationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate cb_onError_Lcom_microsoft_identity_common_exception_BaseException_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_microsoft_identity_common_exception_BaseException_Handler ()
		{
			if (cb_onError_Lcom_microsoft_identity_common_exception_BaseException_ == null)
				cb_onError_Lcom_microsoft_identity_common_exception_BaseException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_microsoft_identity_common_exception_BaseException_);
			return cb_onError_Lcom_microsoft_identity_common_exception_BaseException_;
		}

		static void n_OnError_Lcom_microsoft_identity_common_exception_BaseException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_microsoft_identity_common_exception_BaseException_;
		public unsafe void OnError (global::Com.Microsoft.Identity.Common.Exception.BaseException p0)
		{
			if (id_onError_Lcom_microsoft_identity_common_exception_BaseException_ == IntPtr.Zero)
				id_onError_Lcom_microsoft_identity_common_exception_BaseException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/microsoft/identity/common/exception/BaseException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_microsoft_identity_common_exception_BaseException_, __args);
		}

		static Delegate cb_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_Handler ()
		{
			if (cb_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ == null)
				cb_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_);
			return cb_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_;
		}

		static void n_OnSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Request.ILocalAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_;
		public unsafe void OnSuccess (global::Com.Microsoft.Identity.Common.Internal.Result.ILocalAuthenticationResult p0)
		{
			if (id_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ == IntPtr.Zero)
				id_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/microsoft/identity/common/internal/result/ILocalAuthenticationResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_microsoft_identity_common_internal_result_ILocalAuthenticationResult_, __args);
		}

	}
}
