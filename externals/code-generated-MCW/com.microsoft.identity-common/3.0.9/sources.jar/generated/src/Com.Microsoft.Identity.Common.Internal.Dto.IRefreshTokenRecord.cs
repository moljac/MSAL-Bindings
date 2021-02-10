using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']"
	[Register ("com/microsoft/identity/common/internal/dto/IRefreshTokenRecord", "", "Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker")]
	public partial interface IRefreshTokenRecord : IJavaObject, IJavaPeerable {
		string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler:Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler:Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string FamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']/method[@name='getFamilyId' and count(parameter)=0]"
			[Register ("getFamilyId", "()Ljava/lang/String;", "GetGetFamilyIdHandler:Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string HomeAccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']/method[@name='getHomeAccountId' and count(parameter)=0]"
			[Register ("getHomeAccountId", "()Ljava/lang/String;", "GetGetHomeAccountIdHandler:Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Secret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']/method[@name='getSecret' and count(parameter)=0]"
			[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler:Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/interface[@name='IRefreshTokenRecord']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/String;", "GetGetTargetHandler:Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecordInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/IRefreshTokenRecord", DoNotGenerateAcw=true)]
	internal partial class IRefreshTokenRecordInvoker : global::Java.Lang.Object, IRefreshTokenRecord {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/IRefreshTokenRecord", typeof (IRefreshTokenRecordInvoker));

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

		public static IRefreshTokenRecord GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefreshTokenRecord> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.dto.IRefreshTokenRecord"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefreshTokenRecordInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		IntPtr id_getClientId;
		public unsafe string ClientId {
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnvironment);
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		IntPtr id_getEnvironment;
		public unsafe string Environment {
			get {
				if (id_getEnvironment == IntPtr.Zero)
					id_getEnvironment = JNIEnv.GetMethodID (class_ref, "getEnvironment", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnvironment), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyId);
		}
#pragma warning restore 0169

		IntPtr id_getFamilyId;
		public unsafe string FamilyId {
			get {
				if (id_getFamilyId == IntPtr.Zero)
					id_getFamilyId = JNIEnv.GetMethodID (class_ref, "getFamilyId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFamilyId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHomeAccountId;
#pragma warning disable 0169
		static Delegate GetGetHomeAccountIdHandler ()
		{
			if (cb_getHomeAccountId == null)
				cb_getHomeAccountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHomeAccountId);
			return cb_getHomeAccountId;
		}

		static IntPtr n_GetHomeAccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomeAccountId);
		}
#pragma warning restore 0169

		IntPtr id_getHomeAccountId;
		public unsafe string HomeAccountId {
			get {
				if (id_getHomeAccountId == IntPtr.Zero)
					id_getHomeAccountId = JNIEnv.GetMethodID (class_ref, "getHomeAccountId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHomeAccountId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSecret;
#pragma warning disable 0169
		static Delegate GetGetSecretHandler ()
		{
			if (cb_getSecret == null)
				cb_getSecret = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecret);
			return cb_getSecret;
		}

		static IntPtr n_GetSecret (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Secret);
		}
#pragma warning restore 0169

		IntPtr id_getSecret;
		public unsafe string Secret {
			get {
				if (id_getSecret == IntPtr.Zero)
					id_getSecret = JNIEnv.GetMethodID (class_ref, "getSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecret), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IRefreshTokenRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Target);
		}
#pragma warning restore 0169

		IntPtr id_getTarget;
		public unsafe string Target {
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
