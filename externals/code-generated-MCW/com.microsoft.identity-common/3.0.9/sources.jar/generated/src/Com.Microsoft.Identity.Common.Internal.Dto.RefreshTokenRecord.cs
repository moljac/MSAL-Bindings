using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/RefreshTokenRecord", DoNotGenerateAcw=true)]
	public partial class RefreshTokenRecord : global::Com.Microsoft.Identity.Common.Internal.Dto.Credential {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/RefreshTokenRecord$SerializedNames", DoNotGenerateAcw=true)]
		public new partial class SerializedNames : global::Com.Microsoft.Identity.Common.Internal.Dto.Credential.SerializedNames {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord.SerializedNames']/field[@name='FAMILY_ID']"
			[Register ("FAMILY_ID")]
			public const string FamilyId = (string) "family_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord.SerializedNames']/field[@name='TARGET']"
			[Register ("TARGET")]
			public const string Target = (string) "target";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/RefreshTokenRecord$SerializedNames", typeof (SerializedNames));

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

			protected SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord.SerializedNames']/constructor[@name='RefreshTokenRecord.SerializedNames' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SerializedNames () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/RefreshTokenRecord", typeof (RefreshTokenRecord));

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

		protected RefreshTokenRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']/constructor[@name='RefreshTokenRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefreshTokenRecord () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getFamilyId;
#pragma warning disable 0169
		static Delegate GetGetFamilyIdHandler ()
		{
			if (cb_getFamilyId == null)
				cb_getFamilyId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFamilyId);
			return cb_getFamilyId;
		}

		static IntPtr n_GetFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyId);
		}
#pragma warning restore 0169

		static Delegate cb_setFamilyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFamilyId_Ljava_lang_String_Handler ()
		{
			if (cb_setFamilyId_Ljava_lang_String_ == null)
				cb_setFamilyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFamilyId_Ljava_lang_String_);
			return cb_setFamilyId_Ljava_lang_String_;
		}

		static void n_SetFamilyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_familyId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var familyId = JNIEnv.GetString (native_familyId, JniHandleOwnership.DoNotTransfer);
			__this.FamilyId = familyId;
		}
#pragma warning restore 0169

		public virtual unsafe string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler")]
			get {
				const string __id = "getFamilyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']/method[@name='setFamilyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFamilyId", "(Ljava/lang/String;)V", "GetSetFamilyId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFamilyId.(Ljava/lang/String;)V";
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

		static Delegate cb_isExpired;
#pragma warning disable 0169
		static Delegate GetIsExpiredHandler ()
		{
			if (cb_isExpired == null)
				cb_isExpired = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExpired);
			return cb_isExpired;
		}

		static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		public override unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				const string __id = "isExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Target);
		}
#pragma warning restore 0169

		static Delegate cb_setTarget_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Ljava_lang_String_Handler ()
		{
			if (cb_setTarget_Ljava_lang_String_ == null)
				cb_setTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTarget_Ljava_lang_String_);
			return cb_setTarget_Ljava_lang_String_;
		}

		static void n_SetTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			__this.Target = target;
		}
#pragma warning restore 0169

		public virtual unsafe string Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/String;", "GetGetTargetHandler")]
			get {
				const string __id = "getTarget.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='RefreshTokenRecord']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTarget", "(Ljava/lang/String;)V", "GetSetTarget_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTarget.(Ljava/lang/String;)V";
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
