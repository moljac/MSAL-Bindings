using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ILoggerCallback']"
	[Register ("com/microsoft/identity/client/ILoggerCallback", "", "Com.Microsoft.Identity.Client.ILoggerCallbackInvoker")]
	public partial interface ILoggerCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/interface[@name='ILoggerCallback']/method[@name='log' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microsoft.identity.client.Logger.LogLevel'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("log", "(Ljava/lang/String;Lcom/microsoft/identity/client/Logger$LogLevel;Ljava/lang/String;Z)V", "GetLog_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_ZHandler:Com.Microsoft.Identity.Client.ILoggerCallbackInvoker, Microsoft.Identity.Client")]
		void Log (string tag, global::Com.Microsoft.Identity.Client.Logger.LogLevel logLevel, string message, bool containsPII);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/client/ILoggerCallback", DoNotGenerateAcw=true)]
	internal partial class ILoggerCallbackInvoker : global::Java.Lang.Object, ILoggerCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/ILoggerCallback", typeof (ILoggerCallbackInvoker));

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

		public static ILoggerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.client.ILoggerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_ZHandler ()
		{
			if (cb_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z == null)
				cb_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_Log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z);
			return cb_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z;
		}

		static void n_Log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_logLevel, IntPtr native_message, bool containsPII)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.ILoggerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			var logLevel = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (native_logLevel, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Log (tag, logLevel, message, containsPII);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z;
		public unsafe void Log (string tag, global::Com.Microsoft.Identity.Client.Logger.LogLevel logLevel, string message, bool containsPII)
		{
			if (id_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z == IntPtr.Zero)
				id_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/String;Lcom/microsoft/identity/client/Logger$LogLevel;Ljava/lang/String;Z)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_tag);
			__args [1] = new JValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
			__args [2] = new JValue (native_message);
			__args [3] = new JValue (containsPII);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_String_Lcom_microsoft_identity_client_Logger_LogLevel_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_tag);
			JNIEnv.DeleteLocalRef (native_message);
		}

	}
}
