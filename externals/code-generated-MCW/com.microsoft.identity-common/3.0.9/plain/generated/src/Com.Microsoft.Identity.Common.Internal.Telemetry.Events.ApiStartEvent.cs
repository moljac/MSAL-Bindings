using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/events/ApiStartEvent", DoNotGenerateAcw=true)]
	public partial class ApiStartEvent : global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/events/ApiStartEvent", typeof (ApiStartEvent));

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

		protected ApiStartEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/constructor[@name='ApiStartEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApiStartEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_authority_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAuthority_Ljava_lang_String_Handler ()
		{
			if (cb_authority_Ljava_lang_String_ == null)
				cb_authority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Authority_Ljava_lang_String_);
			return cb_authority_Ljava_lang_String_;
		}

		static IntPtr n_Authority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authority (authority));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='authority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("authority", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetAuthority_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent Authority (string authority)
		{
			const string __id = "authority.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authority);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
			}
		}

		static Delegate cb_putApiId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutApiId_Ljava_lang_String_Handler ()
		{
			if (cb_putApiId_Ljava_lang_String_ == null)
				cb_putApiId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutApiId_Ljava_lang_String_);
			return cb_putApiId_Ljava_lang_String_;
		}

		static IntPtr n_PutApiId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var apiId = JNIEnv.GetString (native_apiId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutApiId (apiId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='putApiId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putApiId", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetPutApiId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent PutApiId (string apiId)
		{
			const string __id = "putApiId.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			IntPtr native_apiId = JNIEnv.NewString (apiId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_apiId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_apiId);
			}
		}

		static Delegate cb_putAuthorityType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutAuthorityType_Ljava_lang_String_Handler ()
		{
			if (cb_putAuthorityType_Ljava_lang_String_ == null)
				cb_putAuthorityType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutAuthorityType_Ljava_lang_String_);
			return cb_putAuthorityType_Ljava_lang_String_;
		}

		static IntPtr n_PutAuthorityType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authorityType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authorityType = JNIEnv.GetString (native_authorityType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutAuthorityType (authorityType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='putAuthorityType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putAuthorityType", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetPutAuthorityType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent PutAuthorityType (string authorityType)
		{
			const string __id = "putAuthorityType.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			IntPtr native_authorityType = JNIEnv.NewString (authorityType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authorityType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authorityType);
			}
		}

		static Delegate cb_putExtendedExpiresOnSetting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutExtendedExpiresOnSetting_Ljava_lang_String_Handler ()
		{
			if (cb_putExtendedExpiresOnSetting_Ljava_lang_String_ == null)
				cb_putExtendedExpiresOnSetting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutExtendedExpiresOnSetting_Ljava_lang_String_);
			return cb_putExtendedExpiresOnSetting_Ljava_lang_String_;
		}

		static IntPtr n_PutExtendedExpiresOnSetting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extendedExpiresOnSetting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var extendedExpiresOnSetting = JNIEnv.GetString (native_extendedExpiresOnSetting, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutExtendedExpiresOnSetting (extendedExpiresOnSetting));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='putExtendedExpiresOnSetting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putExtendedExpiresOnSetting", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetPutExtendedExpiresOnSetting_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent PutExtendedExpiresOnSetting (string extendedExpiresOnSetting)
		{
			const string __id = "putExtendedExpiresOnSetting.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			IntPtr native_extendedExpiresOnSetting = JNIEnv.NewString (extendedExpiresOnSetting);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_extendedExpiresOnSetting);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_extendedExpiresOnSetting);
			}
		}

		static Delegate cb_putLoginHint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutLoginHint_Ljava_lang_String_Handler ()
		{
			if (cb_putLoginHint_Ljava_lang_String_ == null)
				cb_putLoginHint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutLoginHint_Ljava_lang_String_);
			return cb_putLoginHint_Ljava_lang_String_;
		}

		static IntPtr n_PutLoginHint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loginHint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var loginHint = JNIEnv.GetString (native_loginHint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutLoginHint (loginHint));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='putLoginHint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putLoginHint", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetPutLoginHint_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent PutLoginHint (string loginHint)
		{
			const string __id = "putLoginHint.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			IntPtr native_loginHint = JNIEnv.NewString (loginHint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_loginHint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_loginHint);
			}
		}

		static Delegate cb_putProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
#pragma warning disable 0169
		static Delegate GetPutProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler ()
		{
			if (cb_putProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ == null)
				cb_putProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_);
			return cb_putProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_;
		}

		static IntPtr n_PutProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutProperties (parameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='putProperties' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.commands.parameters.CommandParameters']]"
		[Register ("putProperties", "(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetPutProperties_Lcom_microsoft_identity_common_internal_commands_parameters_CommandParameters_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent PutProperties (global::Com.Microsoft.Identity.Common.Internal.Commands.Parameters.CommandParameters parameters)
		{
			const string __id = "putProperties.(Lcom/microsoft/identity/common/internal/commands/parameters/CommandParameters;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_putValidationStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutValidationStatus_Ljava_lang_String_Handler ()
		{
			if (cb_putValidationStatus_Ljava_lang_String_ == null)
				cb_putValidationStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutValidationStatus_Ljava_lang_String_);
			return cb_putValidationStatus_Ljava_lang_String_;
		}

		static IntPtr n_PutValidationStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_validationStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var validationStatus = JNIEnv.GetString (native_validationStatus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutValidationStatus (validationStatus));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry.events']/class[@name='ApiStartEvent']/method[@name='putValidationStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putValidationStatus", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;", "GetPutValidationStatus_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent PutValidationStatus (string validationStatus)
		{
			const string __id = "putValidationStatus.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/telemetry/events/ApiStartEvent;";
			IntPtr native_validationStatus = JNIEnv.NewString (validationStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_validationStatus);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.ApiStartEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_validationStatus);
			}
		}

	}
}
