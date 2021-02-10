using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/exception/BaseException", DoNotGenerateAcw=true)]
	public partial class BaseException : global::Java.Lang.Exception {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/field[@name='sName']"
		[Register ("sName")]
		public static string SName {
			get {
				const string __id = "sName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/exception/BaseException", typeof (BaseException));

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

		protected BaseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/constructor[@name='BaseException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe BaseException () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/constructor[@name='BaseException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BaseException (string errorCode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errorCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/constructor[@name='BaseException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseException (string errorCode, string errorMessage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/constructor[@name='BaseException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe BaseException (string errorCode, string errorMessage, global::Java.Lang.Throwable throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_errorCode);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (throwable);
			}
		}

		static Delegate cb_getCliTelemErrorCode;
#pragma warning disable 0169
		static Delegate GetGetCliTelemErrorCodeHandler ()
		{
			if (cb_getCliTelemErrorCode == null)
				cb_getCliTelemErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCliTelemErrorCode);
			return cb_getCliTelemErrorCode;
		}

		static IntPtr n_GetCliTelemErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CliTelemErrorCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCliTelemErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCliTelemErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCliTelemErrorCode_Ljava_lang_String_ == null)
				cb_setCliTelemErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCliTelemErrorCode_Ljava_lang_String_);
			return cb_setCliTelemErrorCode_Ljava_lang_String_;
		}

		static void n_SetCliTelemErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cliTelemErrorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cliTelemErrorCode = JNIEnv.GetString (native_cliTelemErrorCode, JniHandleOwnership.DoNotTransfer);
			__this.CliTelemErrorCode = cliTelemErrorCode;
		}
#pragma warning restore 0169

		public virtual unsafe string CliTelemErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getCliTelemErrorCode' and count(parameter)=0]"
			[Register ("getCliTelemErrorCode", "()Ljava/lang/String;", "GetGetCliTelemErrorCodeHandler")]
			get {
				const string __id = "getCliTelemErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='setCliTelemErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCliTelemErrorCode", "(Ljava/lang/String;)V", "GetSetCliTelemErrorCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCliTelemErrorCode.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCliTelemSubErrorCode;
#pragma warning disable 0169
		static Delegate GetGetCliTelemSubErrorCodeHandler ()
		{
			if (cb_getCliTelemSubErrorCode == null)
				cb_getCliTelemSubErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCliTelemSubErrorCode);
			return cb_getCliTelemSubErrorCode;
		}

		static IntPtr n_GetCliTelemSubErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CliTelemSubErrorCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCliTelemSubErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCliTelemSubErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCliTelemSubErrorCode_Ljava_lang_String_ == null)
				cb_setCliTelemSubErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCliTelemSubErrorCode_Ljava_lang_String_);
			return cb_setCliTelemSubErrorCode_Ljava_lang_String_;
		}

		static void n_SetCliTelemSubErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cliTelemSubErrorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cliTelemSubErrorCode = JNIEnv.GetString (native_cliTelemSubErrorCode, JniHandleOwnership.DoNotTransfer);
			__this.CliTelemSubErrorCode = cliTelemSubErrorCode;
		}
#pragma warning restore 0169

		public virtual unsafe string CliTelemSubErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getCliTelemSubErrorCode' and count(parameter)=0]"
			[Register ("getCliTelemSubErrorCode", "()Ljava/lang/String;", "GetGetCliTelemSubErrorCodeHandler")]
			get {
				const string __id = "getCliTelemSubErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='setCliTelemSubErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCliTelemSubErrorCode", "(Ljava/lang/String;)V", "GetSetCliTelemSubErrorCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCliTelemSubErrorCode.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCorrelationId;
#pragma warning disable 0169
		static Delegate GetGetCorrelationIdHandler ()
		{
			if (cb_getCorrelationId == null)
				cb_getCorrelationId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCorrelationId);
			return cb_getCorrelationId;
		}

		static IntPtr n_GetCorrelationId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CorrelationId);
		}
#pragma warning restore 0169

		static Delegate cb_setCorrelationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCorrelationId_Ljava_lang_String_Handler ()
		{
			if (cb_setCorrelationId_Ljava_lang_String_ == null)
				cb_setCorrelationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCorrelationId_Ljava_lang_String_);
			return cb_setCorrelationId_Ljava_lang_String_;
		}

		static void n_SetCorrelationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
			__this.CorrelationId = correlationId;
		}
#pragma warning restore 0169

		public virtual unsafe string CorrelationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getCorrelationId' and count(parameter)=0]"
			[Register ("getCorrelationId", "()Ljava/lang/String;", "GetGetCorrelationIdHandler")]
			get {
				const string __id = "getCorrelationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='setCorrelationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCorrelationId", "(Ljava/lang/String;)V", "GetSetCorrelationId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCorrelationId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static IntPtr n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Ljava/lang/String;", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExceptionName;
#pragma warning disable 0169
		static Delegate GetGetExceptionNameHandler ()
		{
			if (cb_getExceptionName == null)
				cb_getExceptionName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExceptionName);
			return cb_getExceptionName;
		}

		static IntPtr n_GetExceptionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExceptionName);
		}
#pragma warning restore 0169

		public virtual unsafe string ExceptionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getExceptionName' and count(parameter)=0]"
			[Register ("getExceptionName", "()Ljava/lang/String;", "GetGetExceptionNameHandler")]
			get {
				const string __id = "getExceptionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshTokenAge;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenAgeHandler ()
		{
			if (cb_getRefreshTokenAge == null)
				cb_getRefreshTokenAge = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshTokenAge);
			return cb_getRefreshTokenAge;
		}

		static IntPtr n_GetRefreshTokenAge (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshTokenAge);
		}
#pragma warning restore 0169

		static Delegate cb_setRefreshTokenAge_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefreshTokenAge_Ljava_lang_String_Handler ()
		{
			if (cb_setRefreshTokenAge_Ljava_lang_String_ == null)
				cb_setRefreshTokenAge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefreshTokenAge_Ljava_lang_String_);
			return cb_setRefreshTokenAge_Ljava_lang_String_;
		}

		static void n_SetRefreshTokenAge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshTokenAge)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshTokenAge = JNIEnv.GetString (native_refreshTokenAge, JniHandleOwnership.DoNotTransfer);
			__this.RefreshTokenAge = refreshTokenAge;
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshTokenAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getRefreshTokenAge' and count(parameter)=0]"
			[Register ("getRefreshTokenAge", "()Ljava/lang/String;", "GetGetRefreshTokenAgeHandler")]
			get {
				const string __id = "getRefreshTokenAge.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='setRefreshTokenAge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefreshTokenAge", "(Ljava/lang/String;)V", "GetSetRefreshTokenAge_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRefreshTokenAge.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSpeRing;
#pragma warning disable 0169
		static Delegate GetGetSpeRingHandler ()
		{
			if (cb_getSpeRing == null)
				cb_getSpeRing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSpeRing);
			return cb_getSpeRing;
		}

		static IntPtr n_GetSpeRing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpeRing);
		}
#pragma warning restore 0169

		static Delegate cb_setSpeRing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSpeRing_Ljava_lang_String_Handler ()
		{
			if (cb_setSpeRing_Ljava_lang_String_ == null)
				cb_setSpeRing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSpeRing_Ljava_lang_String_);
			return cb_setSpeRing_Ljava_lang_String_;
		}

		static void n_SetSpeRing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_speRing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var speRing = JNIEnv.GetString (native_speRing, JniHandleOwnership.DoNotTransfer);
			__this.SpeRing = speRing;
		}
#pragma warning restore 0169

		public virtual unsafe string SpeRing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='getSpeRing' and count(parameter)=0]"
			[Register ("getSpeRing", "()Ljava/lang/String;", "GetGetSpeRingHandler")]
			get {
				const string __id = "getSpeRing.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.exception']/class[@name='BaseException']/method[@name='setSpeRing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSpeRing", "(Ljava/lang/String;)V", "GetSetSpeRing_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSpeRing.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
