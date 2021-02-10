using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Eststelemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/eststelemetry/EstsTelemetry", DoNotGenerateAcw=true)]
	public partial class EstsTelemetry : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/eststelemetry/EstsTelemetry", typeof (EstsTelemetry));

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

		protected EstsTelemetry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/internal/eststelemetry/EstsTelemetry;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/internal/eststelemetry/EstsTelemetry;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTelemetryHeaders;
#pragma warning disable 0169
		static Delegate GetGetTelemetryHeadersHandler ()
		{
			if (cb_getTelemetryHeaders == null)
				cb_getTelemetryHeaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTelemetryHeaders);
			return cb_getTelemetryHeaders;
		}

		static IntPtr n_GetTelemetryHeaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.TelemetryHeaders);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> TelemetryHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='getTelemetryHeaders' and count(parameter)=0]"
			[Register ("getTelemetryHeaders", "()Ljava/util/Map;", "GetGetTelemetryHeadersHandler")]
			get {
				const string __id = "getTelemetryHeaders.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_emit_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEmit_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_emit_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_emit_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Emit_Ljava_lang_String_Ljava_lang_String_);
			return cb_emit_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Emit_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Emit (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='emit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("emit", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEmit_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Emit (string key, string value)
		{
			const string __id = "emit.(Ljava/lang/String;Ljava/lang/String;)V";
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

		static Delegate cb_emit_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetEmit_Ljava_util_Map_Handler ()
		{
			if (cb_emit_Ljava_util_Map_ == null)
				cb_emit_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Emit_Ljava_util_Map_);
			return cb_emit_Ljava_util_Map_;
		}

		static void n_Emit_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_telemetry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var telemetry = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_telemetry, JniHandleOwnership.DoNotTransfer);
			__this.Emit (telemetry);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='emit' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("emit", "(Ljava/util/Map;)V", "GetEmit_Ljava_util_Map_Handler")]
		public virtual unsafe void Emit (global::System.Collections.Generic.IDictionary<string, string> telemetry)
		{
			const string __id = "emit.(Ljava/util/Map;)V";
			IntPtr native_telemetry = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (telemetry);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_telemetry);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_telemetry);
				global::System.GC.KeepAlive (telemetry);
			}
		}

		static Delegate cb_emitApiId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEmitApiId_Ljava_lang_String_Handler ()
		{
			if (cb_emitApiId_Ljava_lang_String_ == null)
				cb_emitApiId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EmitApiId_Ljava_lang_String_);
			return cb_emitApiId_Ljava_lang_String_;
		}

		static void n_EmitApiId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var apiId = JNIEnv.GetString (native_apiId, JniHandleOwnership.DoNotTransfer);
			__this.EmitApiId (apiId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='emitApiId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("emitApiId", "(Ljava/lang/String;)V", "GetEmitApiId_Ljava_lang_String_Handler")]
		public virtual unsafe void EmitApiId (string apiId)
		{
			const string __id = "emitApiId.(Ljava/lang/String;)V";
			IntPtr native_apiId = JNIEnv.NewString (apiId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_apiId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_apiId);
			}
		}

		static Delegate cb_emitForceRefresh_Z;
#pragma warning disable 0169
		static Delegate GetEmitForceRefresh_ZHandler ()
		{
			if (cb_emitForceRefresh_Z == null)
				cb_emitForceRefresh_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_EmitForceRefresh_Z);
			return cb_emitForceRefresh_Z;
		}

		static void n_EmitForceRefresh_Z (IntPtr jnienv, IntPtr native__this, bool forceRefresh)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmitForceRefresh (forceRefresh);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='emitForceRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("emitForceRefresh", "(Z)V", "GetEmitForceRefresh_ZHandler")]
		public virtual unsafe void EmitForceRefresh (bool forceRefresh)
		{
			const string __id = "emitForceRefresh.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (forceRefresh);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_flush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_;
#pragma warning disable 0169
		static Delegate GetFlush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_Handler ()
		{
			if (cb_flush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_ == null)
				cb_flush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Flush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_);
			return cb_flush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_;
		}

		static void n_Flush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_command, IntPtr native_commandResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var command = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (native_command, JniHandleOwnership.DoNotTransfer);
			var commandResult = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult> (native_commandResult, JniHandleOwnership.DoNotTransfer);
			__this.Flush (command, commandResult);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='flush' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.commands.BaseCommand'] and parameter[2][@type='com.microsoft.identity.common.internal.controllers.CommandResult']]"
		[Register ("flush", "(Lcom/microsoft/identity/common/internal/commands/BaseCommand;Lcom/microsoft/identity/common/internal/controllers/CommandResult;)V", "GetFlush_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Lcom_microsoft_identity_common_internal_controllers_CommandResult_Handler")]
		public virtual unsafe void Flush (global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand command, global::Com.Microsoft.Identity.Common.Internal.Controllers.CommandResult commandResult)
		{
			const string __id = "flush.(Lcom/microsoft/identity/common/internal/commands/BaseCommand;Lcom/microsoft/identity/common/internal/controllers/CommandResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				__args [1] = new JniArgumentValue ((commandResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commandResult).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (command);
				global::System.GC.KeepAlive (commandResult);
			}
		}

		static Delegate cb_initTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_;
#pragma warning disable 0169
		static Delegate GetInitTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Handler ()
		{
			if (cb_initTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_ == null)
				cb_initTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_);
			return cb_initTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_;
		}

		static void n_InitTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Eststelemetry.EstsTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var command = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand> (native_command, JniHandleOwnership.DoNotTransfer);
			__this.InitTelemetryForCommand (command);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.eststelemetry']/class[@name='EstsTelemetry']/method[@name='initTelemetryForCommand' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.BaseCommand']]"
		[Register ("initTelemetryForCommand", "(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)V", "GetInitTelemetryForCommand_Lcom_microsoft_identity_common_internal_commands_BaseCommand_Handler")]
		public virtual unsafe void InitTelemetryForCommand (global::Com.Microsoft.Identity.Common.Internal.Commands.BaseCommand command)
		{
			const string __id = "initTelemetryForCommand.(Lcom/microsoft/identity/common/internal/commands/BaseCommand;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (command);
			}
		}

	}
}
