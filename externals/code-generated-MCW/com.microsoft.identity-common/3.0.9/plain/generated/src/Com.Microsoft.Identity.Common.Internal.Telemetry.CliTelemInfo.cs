using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/CliTelemInfo", DoNotGenerateAcw=true)]
	public partial class CliTelemInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/CliTelemInfo", typeof (CliTelemInfo));

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

		protected CliTelemInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/constructor[@name='CliTelemInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CliTelemInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/constructor[@name='CliTelemInfo' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.CliTelemInfo']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;)V", "")]
		public unsafe CliTelemInfo (global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo copy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((copy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) copy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (copy);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshTokenAge = JNIEnv.GetString (native_refreshTokenAge, JniHandleOwnership.DoNotTransfer);
			__this.RefreshTokenAge = refreshTokenAge;
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshTokenAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='getRefreshTokenAge' and count(parameter)=0]"
			[Register ("getRefreshTokenAge", "()Ljava/lang/String;", "GetGetRefreshTokenAgeHandler")]
			get {
				const string __id = "getRefreshTokenAge.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='setRefreshTokenAge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getServerErrorCode;
#pragma warning disable 0169
		static Delegate GetGetServerErrorCodeHandler ()
		{
			if (cb_getServerErrorCode == null)
				cb_getServerErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServerErrorCode);
			return cb_getServerErrorCode;
		}

		static IntPtr n_GetServerErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string ServerErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='getServerErrorCode' and count(parameter)=0]"
			[Register ("getServerErrorCode", "()Ljava/lang/String;", "GetGetServerErrorCodeHandler")]
			get {
				const string __id = "getServerErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerSubErrorCode;
#pragma warning disable 0169
		static Delegate GetGetServerSubErrorCodeHandler ()
		{
			if (cb_getServerSubErrorCode == null)
				cb_getServerSubErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServerSubErrorCode);
			return cb_getServerSubErrorCode;
		}

		static IntPtr n_GetServerSubErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerSubErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string ServerSubErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='getServerSubErrorCode' and count(parameter)=0]"
			[Register ("getServerSubErrorCode", "()Ljava/lang/String;", "GetGetServerSubErrorCodeHandler")]
			get {
				const string __id = "getServerSubErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var speRing = JNIEnv.GetString (native_speRing, JniHandleOwnership.DoNotTransfer);
			__this.SpeRing = speRing;
		}
#pragma warning restore 0169

		public virtual unsafe string SpeRing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='getSpeRing' and count(parameter)=0]"
			[Register ("getSpeRing", "()Ljava/lang/String;", "GetGetSpeRingHandler")]
			get {
				const string __id = "getSpeRing.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='setSpeRing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='fromXMsCliTelemHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromXMsCliTelemHeader", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo FromXMsCliTelemHeader (string headerValue)
		{
			const string __id = "fromXMsCliTelemHeader.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;";
			IntPtr native_headerValue = JNIEnv.NewString (headerValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerValue);
			}
		}

		static Delegate cb_setServerErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_setServerErrorCode_Ljava_lang_String_ == null)
				cb_setServerErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetServerErrorCode_Ljava_lang_String_);
			return cb_setServerErrorCode_Ljava_lang_String_;
		}

		static void n_SetServerErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverErrorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverErrorCode = JNIEnv.GetString (native_serverErrorCode, JniHandleOwnership.DoNotTransfer);
			__this.SetServerErrorCode (serverErrorCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='setServerErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServerErrorCode", "(Ljava/lang/String;)V", "GetSetServerErrorCode_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetServerErrorCode (string serverErrorCode)
		{
			const string __id = "setServerErrorCode.(Ljava/lang/String;)V";
			IntPtr native_serverErrorCode = JNIEnv.NewString (serverErrorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serverErrorCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverErrorCode);
			}
		}

		static Delegate cb_setServerSubErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerSubErrorCode_Ljava_lang_String_Handler ()
		{
			if (cb_setServerSubErrorCode_Ljava_lang_String_ == null)
				cb_setServerSubErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetServerSubErrorCode_Ljava_lang_String_);
			return cb_setServerSubErrorCode_Ljava_lang_String_;
		}

		static void n_SetServerSubErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverSubErrorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverSubErrorCode = JNIEnv.GetString (native_serverSubErrorCode, JniHandleOwnership.DoNotTransfer);
			__this.SetServerSubErrorCode (serverSubErrorCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='setServerSubErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServerSubErrorCode", "(Ljava/lang/String;)V", "GetSetServerSubErrorCode_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetServerSubErrorCode (string serverSubErrorCode)
		{
			const string __id = "setServerSubErrorCode.(Ljava/lang/String;)V";
			IntPtr native_serverSubErrorCode = JNIEnv.NewString (serverSubErrorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serverSubErrorCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverSubErrorCode);
			}
		}

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var version = JNIEnv.GetString (native_version, JniHandleOwnership.DoNotTransfer);
			__this.SetVersion (version);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='CliTelemInfo']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetVersion (string version)
		{
			const string __id = "setVersion.(Ljava/lang/String;)V";
			IntPtr native_version = JNIEnv.NewString (version);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_version);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_version);
			}
		}

	}
}
