using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/BrokerValidator", DoNotGenerateAcw=true)]
	public partial class BrokerValidator : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/BrokerValidator", typeof (BrokerValidator));

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

		protected BrokerValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']/constructor[@name='BrokerValidator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BrokerValidator (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getCurrentActiveBrokerPackageName;
#pragma warning disable 0169
		static Delegate GetGetCurrentActiveBrokerPackageNameHandler ()
		{
			if (cb_getCurrentActiveBrokerPackageName == null)
				cb_getCurrentActiveBrokerPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentActiveBrokerPackageName);
			return cb_getCurrentActiveBrokerPackageName;
		}

		static IntPtr n_GetCurrentActiveBrokerPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentActiveBrokerPackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string CurrentActiveBrokerPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']/method[@name='getCurrentActiveBrokerPackageName' and count(parameter)=0]"
			[Register ("getCurrentActiveBrokerPackageName", "()Ljava/lang/String;", "GetGetCurrentActiveBrokerPackageNameHandler")]
			get {
				const string __id = "getCurrentActiveBrokerPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']/method[@name='getBrokerRedirectUri' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBrokerRedirectUri", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetBrokerRedirectUri (global::Android.Content.Context context, string packageName)
		{
			const string __id = "getBrokerRedirectUri.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_packageName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']/method[@name='isValidBrokerRedirect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String']]"
		[Register ("isValidBrokerRedirect", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsValidBrokerRedirect (string redirectUri, global::Android.Content.Context context, string packageName)
		{
			const string __id = "isValidBrokerRedirect.(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_redirectUri);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [2] = new JniArgumentValue (native_packageName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_redirectUri);
				JNIEnv.DeleteLocalRef (native_packageName);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_verifySignature_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetVerifySignature_Ljava_lang_String_Handler ()
		{
			if (cb_verifySignature_Ljava_lang_String_ == null)
				cb_verifySignature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_VerifySignature_Ljava_lang_String_);
			return cb_verifySignature_Ljava_lang_String_;
		}

		static bool n_VerifySignature_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brokerPackageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var brokerPackageName = JNIEnv.GetString (native_brokerPackageName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VerifySignature (brokerPackageName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']/method[@name='verifySignature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("verifySignature", "(Ljava/lang/String;)Z", "GetVerifySignature_Ljava_lang_String_Handler")]
		public virtual unsafe bool VerifySignature (string brokerPackageName)
		{
			const string __id = "verifySignature.(Ljava/lang/String;)Z";
			IntPtr native_brokerPackageName = JNIEnv.NewString (brokerPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_brokerPackageName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_brokerPackageName);
			}
		}

		static Delegate cb_verifySignatureAndThrow_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetVerifySignatureAndThrow_Ljava_lang_String_Handler ()
		{
			if (cb_verifySignatureAndThrow_Ljava_lang_String_ == null)
				cb_verifySignatureAndThrow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_VerifySignatureAndThrow_Ljava_lang_String_);
			return cb_verifySignatureAndThrow_Ljava_lang_String_;
		}

		static IntPtr n_VerifySignatureAndThrow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brokerPackageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.BrokerValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var brokerPackageName = JNIEnv.GetString (native_brokerPackageName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.VerifySignatureAndThrow (brokerPackageName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='BrokerValidator']/method[@name='verifySignatureAndThrow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("verifySignatureAndThrow", "(Ljava/lang/String;)Ljava/lang/String;", "GetVerifySignatureAndThrow_Ljava_lang_String_Handler")]
		public virtual unsafe string VerifySignatureAndThrow (string brokerPackageName)
		{
			const string __id = "verifySignatureAndThrow.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_brokerPackageName = JNIEnv.NewString (brokerPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_brokerPackageName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_brokerPackageName);
			}
		}

	}
}
