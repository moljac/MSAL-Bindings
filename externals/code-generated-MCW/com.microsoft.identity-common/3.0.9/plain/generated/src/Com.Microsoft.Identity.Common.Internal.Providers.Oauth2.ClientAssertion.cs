using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Providers.Oauth2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='ClientAssertion']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/ClientAssertion", DoNotGenerateAcw=true)]
	public abstract partial class ClientAssertion : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/ClientAssertion", typeof (ClientAssertion));

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

		protected ClientAssertion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='ClientAssertion']/constructor[@name='ClientAssertion' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClientAssertion () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getClientAssertionType;
#pragma warning disable 0169
		static Delegate GetGetClientAssertionTypeHandler ()
		{
			if (cb_getClientAssertionType == null)
				cb_getClientAssertionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientAssertionType);
			return cb_getClientAssertionType;
		}

		static IntPtr n_GetClientAssertionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ClientAssertion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAssertionType);
		}
#pragma warning restore 0169

		static Delegate cb_setClientAssertionType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAssertionType_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAssertionType_Ljava_lang_String_ == null)
				cb_setClientAssertionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientAssertionType_Ljava_lang_String_);
			return cb_setClientAssertionType_Ljava_lang_String_;
		}

		static void n_SetClientAssertionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientAssertionType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ClientAssertion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientAssertionType = JNIEnv.GetString (native_clientAssertionType, JniHandleOwnership.DoNotTransfer);
			__this.ClientAssertionType = clientAssertionType;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientAssertionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='ClientAssertion']/method[@name='getClientAssertionType' and count(parameter)=0]"
			[Register ("getClientAssertionType", "()Ljava/lang/String;", "GetGetClientAssertionTypeHandler")]
			get {
				const string __id = "getClientAssertionType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='ClientAssertion']/method[@name='setClientAssertionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientAssertionType", "(Ljava/lang/String;)V", "GetSetClientAssertionType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientAssertionType.(Ljava/lang/String;)V";
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

		static Delegate cb_getClientAssertion;
#pragma warning disable 0169
		static Delegate GetGetClientAssertionHandler ()
		{
			if (cb_getClientAssertion == null)
				cb_getClientAssertion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientAssertion);
			return cb_getClientAssertion;
		}

		static IntPtr n_GetClientAssertion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ClientAssertion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetClientAssertion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='ClientAssertion']/method[@name='getClientAssertion' and count(parameter)=0]"
		[Register ("getClientAssertion", "()Ljava/lang/String;", "GetGetClientAssertionHandler")]
		public virtual unsafe string GetClientAssertion ()
		{
			const string __id = "getClientAssertion.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setClientAssertion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAssertion_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAssertion_Ljava_lang_String_ == null)
				cb_setClientAssertion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientAssertion_Ljava_lang_String_);
			return cb_setClientAssertion_Ljava_lang_String_;
		}

		static void n_SetClientAssertion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientAssertion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.ClientAssertion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientAssertion = JNIEnv.GetString (native_clientAssertion, JniHandleOwnership.DoNotTransfer);
			__this.SetClientAssertion (clientAssertion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.providers.oauth2']/class[@name='ClientAssertion']/method[@name='setClientAssertion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientAssertion", "(Ljava/lang/String;)V", "GetSetClientAssertion_Ljava_lang_String_Handler")]
		public virtual unsafe void SetClientAssertion (string clientAssertion)
		{
			const string __id = "setClientAssertion.(Ljava/lang/String;)V";
			IntPtr native_clientAssertion = JNIEnv.NewString (clientAssertion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_clientAssertion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientAssertion);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/providers/oauth2/ClientAssertion", DoNotGenerateAcw=true)]
	internal partial class ClientAssertionInvoker : ClientAssertion {
		public ClientAssertionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/providers/oauth2/ClientAssertion", typeof (ClientAssertionInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
