using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/GenerateShrResult", DoNotGenerateAcw=true)]
	public partial class GenerateShrResult : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult.Errors']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/result/GenerateShrResult$Errors", DoNotGenerateAcw=true)]
		public partial class Errors : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult.Errors']/field[@name='CLIENT_EXCEPTION']"
			[Register ("CLIENT_EXCEPTION")]
			public const string ClientException = (string) "client_exception";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult.Errors']/field[@name='NO_ACCOUNT_FOUND']"
			[Register ("NO_ACCOUNT_FOUND")]
			public const string NoAccountFound = (string) "no_account_found";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/GenerateShrResult$Errors", typeof (Errors));

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

			protected Errors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult.Errors']/constructor[@name='GenerateShrResult.Errors' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Errors () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/result/GenerateShrResult", typeof (GenerateShrResult));

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

		protected GenerateShrResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/constructor[@name='GenerateShrResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GenerateShrResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorCode);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorCode_Ljava_lang_String_ == null)
				cb_setErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetErrorCode_Ljava_lang_String_);
			return cb_setErrorCode_Ljava_lang_String_;
		}

		static void n_SetErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCode = errorCode;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Ljava/lang/String;", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorCode", "(Ljava/lang/String;)V", "GetSetErrorCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getErrorMessage;
#pragma warning disable 0169
		static Delegate GetGetErrorMessageHandler ()
		{
			if (cb_getErrorMessage == null)
				cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorMessage);
			return cb_getErrorMessage;
		}

		static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorMessage_Ljava_lang_String_ == null)
				cb_setErrorMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetErrorMessage_Ljava_lang_String_);
			return cb_setErrorMessage_Ljava_lang_String_;
		}

		static void n_SetErrorMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var errorMessage = JNIEnv.GetString (native_errorMessage, JniHandleOwnership.DoNotTransfer);
			__this.ErrorMessage = errorMessage;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				const string __id = "getErrorMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/method[@name='setErrorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorMessage", "(Ljava/lang/String;)V", "GetSetErrorMessage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorMessage.(Ljava/lang/String;)V";
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

		static Delegate cb_getShr;
#pragma warning disable 0169
		static Delegate GetGetShrHandler ()
		{
			if (cb_getShr == null)
				cb_getShr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetShr);
			return cb_getShr;
		}

		static IntPtr n_GetShr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Shr);
		}
#pragma warning restore 0169

		static Delegate cb_setShr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShr_Ljava_lang_String_Handler ()
		{
			if (cb_setShr_Ljava_lang_String_ == null)
				cb_setShr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetShr_Ljava_lang_String_);
			return cb_setShr_Ljava_lang_String_;
		}

		static void n_SetShr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Result.GenerateShrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var shr = JNIEnv.GetString (native_shr, JniHandleOwnership.DoNotTransfer);
			__this.Shr = shr;
		}
#pragma warning restore 0169

		public virtual unsafe string Shr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/method[@name='getShr' and count(parameter)=0]"
			[Register ("getShr", "()Ljava/lang/String;", "GetGetShrHandler")]
			get {
				const string __id = "getShr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.result']/class[@name='GenerateShrResult']/method[@name='setShr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShr", "(Ljava/lang/String;)V", "GetSetShr_Ljava_lang_String_Handler")]
			set {
				const string __id = "setShr.(Ljava/lang/String;)V";
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
