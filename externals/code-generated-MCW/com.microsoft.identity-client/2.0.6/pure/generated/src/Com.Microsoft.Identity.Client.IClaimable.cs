using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IClaimable']"
	[Register ("com/microsoft/identity/client/IClaimable", "", "Com.Microsoft.Identity.Client.IClaimableInvoker")]
	public partial interface IClaimable : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IDictionary<string, object> Claims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IClaimable']/method[@name='getClaims' and count(parameter)=0]"
			[Register ("getClaims", "()Ljava/util/Map;", "GetGetClaimsHandler:Com.Microsoft.Identity.Client.IClaimableInvoker, Microsoft.Identity.Client")]
			get; 
		}

		string IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IClaimable']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Ljava/lang/String;", "GetGetIdTokenHandler:Com.Microsoft.Identity.Client.IClaimableInvoker, Microsoft.Identity.Client")]
			get; 
		}

		string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IClaimable']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler:Com.Microsoft.Identity.Client.IClaimableInvoker, Microsoft.Identity.Client")]
			get; 
		}

		string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='IClaimable']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler:Com.Microsoft.Identity.Client.IClaimableInvoker, Microsoft.Identity.Client")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/IClaimable", DoNotGenerateAcw=true)]
	internal partial class IClaimableInvoker : global::Java.Lang.Object, IClaimable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/IClaimable", typeof (IClaimableInvoker));

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

		public static IClaimable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClaimable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.IClaimable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClaimableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getClaims;
#pragma warning disable 0169
		static Delegate GetGetClaimsHandler ()
		{
			if (cb_getClaims == null)
				cb_getClaims = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClaims);
			return cb_getClaims;
		}

		static IntPtr n_GetClaims (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IClaimable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (__this.Claims);
		}
#pragma warning restore 0169

		IntPtr id_getClaims;
		public unsafe global::System.Collections.Generic.IDictionary<string, object> Claims {
			get {
				if (id_getClaims == IntPtr.Zero)
					id_getClaims = JNIEnv.GetMethodID (class_ref, "getClaims", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClaims), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIdToken;
#pragma warning disable 0169
		static Delegate GetGetIdTokenHandler ()
		{
			if (cb_getIdToken == null)
				cb_getIdToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdToken);
			return cb_getIdToken;
		}

		static IntPtr n_GetIdToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IClaimable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdToken);
		}
#pragma warning restore 0169

		IntPtr id_getIdToken;
		public unsafe string IdToken {
			get {
				if (id_getIdToken == IntPtr.Zero)
					id_getIdToken = JNIEnv.GetMethodID (class_ref, "getIdToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTenantId;
#pragma warning disable 0169
		static Delegate GetGetTenantIdHandler ()
		{
			if (cb_getTenantId == null)
				cb_getTenantId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantId);
			return cb_getTenantId;
		}

		static IntPtr n_GetTenantId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IClaimable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		IntPtr id_getTenantId;
		public unsafe string TenantId {
			get {
				if (id_getTenantId == IntPtr.Zero)
					id_getTenantId = JNIEnv.GetMethodID (class_ref, "getTenantId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTenantId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.IClaimable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		IntPtr id_getUsername;
		public unsafe string Username {
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
