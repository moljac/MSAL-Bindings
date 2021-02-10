using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Commands {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='DeviceCodeFlowCommandCallback']"
	[Register ("com/microsoft/identity/common/internal/commands/DeviceCodeFlowCommandCallback", "", "Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
	public partial interface IDeviceCodeFlowCommandCallback : global::Com.Microsoft.Identity.Common.Internal.Commands.ICommandCallback {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.commands']/interface[@name='DeviceCodeFlowCommandCallback']/method[@name='onUserCodeReceived' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date']]"
		[Register ("onUserCodeReceived", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", "GetOnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler:Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallbackInvoker, Microsoft.Identity.Common")]
		void OnUserCodeReceived (string p0, string p1, string p2, global::Java.Util.Date p3);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/commands/DeviceCodeFlowCommandCallback", DoNotGenerateAcw=true)]
	internal partial class IDeviceCodeFlowCommandCallbackInvoker : global::Java.Lang.Object, IDeviceCodeFlowCommandCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/commands/DeviceCodeFlowCommandCallback", typeof (IDeviceCodeFlowCommandCallbackInvoker));

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

		public static IDeviceCodeFlowCommandCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceCodeFlowCommandCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.commands.DeviceCodeFlowCommandCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceCodeFlowCommandCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetOnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler ()
		{
			if (cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ == null)
				cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_);
			return cb_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		}

		static void n_OnUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnUserCodeReceived (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		public unsafe void OnUserCodeReceived (string p0, string p1, string p2, global::Java.Util.Date p3)
		{
			if (id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "onUserCodeReceived", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserCodeReceived_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate cb_onError_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Object_Handler ()
		{
			if (cb_onError_Ljava_lang_Object_ == null)
				cb_onError_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Object_);
			return cb_onError_Ljava_lang_Object_;
		}

		static void n_OnError_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Object_;
		public unsafe void OnError (global::Java.Lang.Object p0)
		{
			if (id_onError_Ljava_lang_Object_ == IntPtr.Zero)
				id_onError_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onTaskCompleted_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnTaskCompleted_Ljava_lang_Object_Handler ()
		{
			if (cb_onTaskCompleted_Ljava_lang_Object_ == null)
				cb_onTaskCompleted_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTaskCompleted_Ljava_lang_Object_);
			return cb_onTaskCompleted_Ljava_lang_Object_;
		}

		static void n_OnTaskCompleted_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Commands.IDeviceCodeFlowCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTaskCompleted_Ljava_lang_Object_;
		public unsafe void OnTaskCompleted (global::Java.Lang.Object p0)
		{
			if (id_onTaskCompleted_Ljava_lang_Object_ == IntPtr.Zero)
				id_onTaskCompleted_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onTaskCompleted", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskCompleted_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
