using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetry']"
	[Register ("com/microsoft/identity/common/internal/eststelemetry/IRequestTelemetry", "", "Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryInvoker")]
	public partial interface IRequestTelemetry : IJavaObject, IJavaPeerable {
		string CompleteHeaderString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetry']/method[@name='getCompleteHeaderString' and count(parameter)=0]"
			[Register ("getCompleteHeaderString", "()Ljava/lang/String;", "GetGetCompleteHeaderStringHandler:Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string HeaderStringForFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetry']/method[@name='getHeaderStringForFields' and count(parameter)=0]"
			[Register ("getHeaderStringForFields", "()Ljava/lang/String;", "GetGetHeaderStringForFieldsHandler:Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/interface[@name='IRequestTelemetry']/method[@name='copySharedValues' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.eststelemetry.RequestTelemetry']]"
		[Register ("copySharedValues", "(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;", "GetCopySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_Handler:Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetryInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry CopySharedValues (global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/IRequestTelemetry", DoNotGenerateAcw=true)]
	internal partial class IRequestTelemetryInvoker : global::Java.Lang.Object, IRequestTelemetry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/IRequestTelemetry", typeof (IRequestTelemetryInvoker));

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

		public static IRequestTelemetry GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestTelemetry> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.eststelemetry.IRequestTelemetry"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestTelemetryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCompleteHeaderString;
#pragma warning disable 0169
		static Delegate GetGetCompleteHeaderStringHandler ()
		{
			if (cb_getCompleteHeaderString == null)
				cb_getCompleteHeaderString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCompleteHeaderString);
			return cb_getCompleteHeaderString;
		}

		static IntPtr n_GetCompleteHeaderString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CompleteHeaderString);
		}
#pragma warning restore 0169

		IntPtr id_getCompleteHeaderString;
		public unsafe string CompleteHeaderString {
			get {
				if (id_getCompleteHeaderString == IntPtr.Zero)
					id_getCompleteHeaderString = JNIEnv.GetMethodID (class_ref, "getCompleteHeaderString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCompleteHeaderString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeaderStringForFields;
#pragma warning disable 0169
		static Delegate GetGetHeaderStringForFieldsHandler ()
		{
			if (cb_getHeaderStringForFields == null)
				cb_getHeaderStringForFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeaderStringForFields);
			return cb_getHeaderStringForFields;
		}

		static IntPtr n_GetHeaderStringForFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderStringForFields);
		}
#pragma warning restore 0169

		IntPtr id_getHeaderStringForFields;
		public unsafe string HeaderStringForFields {
			get {
				if (id_getHeaderStringForFields == IntPtr.Zero)
					id_getHeaderStringForFields = JNIEnv.GetMethodID (class_ref, "getHeaderStringForFields", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderStringForFields), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_;
#pragma warning disable 0169
		static Delegate GetCopySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_Handler ()
		{
			if (cb_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ == null)
				cb_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CopySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_);
			return cb_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_;
		}

		static IntPtr n_CopySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopySharedValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry CopySharedValues (global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry p0)
		{
			if (id_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ == IntPtr.Zero)
				id_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ = JNIEnv.GetMethodID (class_ref, "copySharedValues", "(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
