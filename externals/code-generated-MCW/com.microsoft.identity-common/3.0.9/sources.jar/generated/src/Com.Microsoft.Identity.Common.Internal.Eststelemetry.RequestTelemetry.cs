using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='RequestTelemetry']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/RequestTelemetry", DoNotGenerateAcw=true)]
	public abstract partial class RequestTelemetry : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.IRequestTelemetry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/RequestTelemetry", typeof (RequestTelemetry));

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

		protected RequestTelemetry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CompleteHeaderString);
		}
#pragma warning restore 0169

		public virtual unsafe string CompleteHeaderString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='RequestTelemetry']/method[@name='getCompleteHeaderString' and count(parameter)=0]"
			[Register ("getCompleteHeaderString", "()Ljava/lang/String;", "GetGetCompleteHeaderStringHandler")]
			get {
				const string __id = "getCompleteHeaderString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static IntPtr n_CopySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestTelemetry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestTelemetry = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (native_requestTelemetry, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopySharedValues (requestTelemetry));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='RequestTelemetry']/method[@name='copySharedValues' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.eststelemetry.RequestTelemetry']]"
		[Register ("copySharedValues", "(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;", "GetCopySharedValues_Lcom_microsoft_identity_common_internal_eststelemetry_RequestTelemetry_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry CopySharedValues (global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry requestTelemetry)
		{
			const string __id = "copySharedValues.(Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;)Lcom/microsoft/identity/common/internal/eststelemetry/RequestTelemetry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestTelemetry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestTelemetry).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (requestTelemetry);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderStringForFields);
		}
#pragma warning restore 0169

		public abstract string HeaderStringForFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='RequestTelemetry']/method[@name='getHeaderStringForFields' and count(parameter)=0]"
			[Register ("getHeaderStringForFields", "()Ljava/lang/String;", "GetGetHeaderStringForFieldsHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/RequestTelemetry", DoNotGenerateAcw=true)]
	internal partial class RequestTelemetryInvoker : RequestTelemetry {
		public RequestTelemetryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/RequestTelemetry", typeof (RequestTelemetryInvoker));

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

		public override unsafe string HeaderStringForFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='RequestTelemetry']/method[@name='getHeaderStringForFields' and count(parameter)=0]"
			[Register ("getHeaderStringForFields", "()Ljava/lang/String;", "GetGetHeaderStringForFieldsHandler")]
			get {
				const string __id = "getHeaderStringForFields.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
