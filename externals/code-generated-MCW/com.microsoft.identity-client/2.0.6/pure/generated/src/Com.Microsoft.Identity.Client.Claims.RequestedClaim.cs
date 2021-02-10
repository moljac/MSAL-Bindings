using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Claims {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaim']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/claims/RequestedClaim", DoNotGenerateAcw=true)]
	public partial class RequestedClaim : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/claims/RequestedClaim", typeof (RequestedClaim));

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

		protected RequestedClaim (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaim']/constructor[@name='RequestedClaim' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestedClaim () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAdditionalInformation;
#pragma warning disable 0169
		static Delegate GetGetAdditionalInformationHandler ()
		{
			if (cb_getAdditionalInformation == null)
				cb_getAdditionalInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalInformation);
			return cb_getAdditionalInformation;
		}

		static IntPtr n_GetAdditionalInformation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdditionalInformation);
		}
#pragma warning restore 0169

		static Delegate cb_setAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler ()
		{
			if (cb_setAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ == null)
				cb_setAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_);
			return cb_setAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_;
		}

		static void n_SetAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_information)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var information = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (native_information, JniHandleOwnership.DoNotTransfer);
			__this.AdditionalInformation = information;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation AdditionalInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaim']/method[@name='getAdditionalInformation' and count(parameter)=0]"
			[Register ("getAdditionalInformation", "()Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;", "GetGetAdditionalInformationHandler")]
			get {
				const string __id = "getAdditionalInformation.()Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaim']/method[@name='setAdditionalInformation' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.claims.RequestedClaimAdditionalInformation']]"
			[Register ("setAdditionalInformation", "(Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V", "GetSetAdditionalInformation_Lcom_microsoft_identity_client_claims_RequestedClaimAdditionalInformation_Handler")]
			set {
				const string __id = "setAdditionalInformation.(Lcom/microsoft/identity/client/claims/RequestedClaimAdditionalInformation;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaim> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaim']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaim']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
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
