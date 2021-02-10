using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IShareSingleSignOnState']"
	[Register ("com/microsoft/identity/common/internal/cache/IShareSingleSignOnState", "", "Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnStateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.BaseAccount", "U extends com.microsoft.identity.common.internal.providers.oauth2.RefreshToken"})]
	public partial interface IShareSingleSignOnState : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IShareSingleSignOnState']/method[@name='getSingleSignOnState' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getSingleSignOnState", "(Lcom/microsoft/identity/common/BaseAccount;)Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;", "GetGetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnStateInvoker, Microsoft.Identity.Common")]
		global::Java.Lang.Object GetSingleSignOnState (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/interface[@name='IShareSingleSignOnState']/method[@name='setSingleSignOnState' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='U']]"
		[Register ("setSingleSignOnState", "(Lcom/microsoft/identity/common/BaseAccount;Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;)V", "GetSetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_Handler:Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnStateInvoker, Microsoft.Identity.Common")]
		void SetSingleSignOnState (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/IShareSingleSignOnState", DoNotGenerateAcw=true)]
	internal partial class IShareSingleSignOnStateInvoker : global::Java.Lang.Object, IShareSingleSignOnState {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/IShareSingleSignOnState", typeof (IShareSingleSignOnStateInvoker));

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

		public static IShareSingleSignOnState GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShareSingleSignOnState> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.cache.IShareSingleSignOnState"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShareSingleSignOnStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_;
#pragma warning disable 0169
		static Delegate GetGetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Handler ()
		{
			if (cb_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_ == null)
				cb_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_);
			return cb_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_;
		}

		static IntPtr n_GetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSingleSignOnState (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_;
		public unsafe global::Java.Lang.Object GetSingleSignOnState (global::Java.Lang.Object p0)
		{
			if (id_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_ == IntPtr.Zero)
				id_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_ = JNIEnv.GetMethodID (class_ref, "getSingleSignOnState", "(Lcom/microsoft/identity/common/BaseAccount;)Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
#pragma warning disable 0169
		static Delegate GetSetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_Handler ()
		{
			if (cb_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ == null)
				cb_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_);
			return cb_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
		}

		static void n_SetSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSingleSignOnState (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_;
		public unsafe void SetSingleSignOnState (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ == IntPtr.Zero)
				id_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_ = JNIEnv.GetMethodID (class_ref, "setSingleSignOnState", "(Lcom/microsoft/identity/common/BaseAccount;Lcom/microsoft/identity/common/internal/providers/oauth2/RefreshToken;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSingleSignOnState_Lcom_microsoft_identity_common_BaseAccount_Lcom_microsoft_identity_common_internal_providers_oauth2_RefreshToken_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
