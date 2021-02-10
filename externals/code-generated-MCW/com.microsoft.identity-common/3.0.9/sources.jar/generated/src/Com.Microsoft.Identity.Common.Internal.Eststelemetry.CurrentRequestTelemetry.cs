using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='CurrentRequestTelemetry']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/CurrentRequestTelemetry", DoNotGenerateAcw=true)]
	public partial class CurrentRequestTelemetry : global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.RequestTelemetry, global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.ICurrentTelemetry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/CurrentRequestTelemetry", typeof (CurrentRequestTelemetry));

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

		protected CurrentRequestTelemetry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.CurrentRequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderStringForFields);
		}
#pragma warning restore 0169

		public override unsafe string HeaderStringForFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='CurrentRequestTelemetry']/method[@name='getHeaderStringForFields' and count(parameter)=0]"
			[Register ("getHeaderStringForFields", "()Ljava/lang/String;", "GetGetHeaderStringForFieldsHandler")]
			get {
				const string __id = "getHeaderStringForFields.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.CurrentRequestTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='CurrentRequestTelemetry']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string key, string value)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
