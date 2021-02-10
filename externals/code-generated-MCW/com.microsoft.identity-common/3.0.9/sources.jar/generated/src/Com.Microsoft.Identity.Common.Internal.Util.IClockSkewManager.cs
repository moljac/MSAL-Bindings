using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']"
	[Register ("com/microsoft/identity/common/internal/util/IClockSkewManager", "", "Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker")]
	public partial interface IClockSkewManager : IJavaObject, IJavaPeerable {
		global::Java.Util.Date AdjustedReferenceTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']/method[@name='getAdjustedReferenceTime' and count(parameter)=0]"
			[Register ("getAdjustedReferenceTime", "()Ljava/util/Date;", "GetGetAdjustedReferenceTimeHandler:Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker, Microsoft.Identity.Common")]
			get; 
		}

		global::Java.Util.Date CurrentClientTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']/method[@name='getCurrentClientTime' and count(parameter)=0]"
			[Register ("getCurrentClientTime", "()Ljava/util/Date;", "GetGetCurrentClientTimeHandler:Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker, Microsoft.Identity.Common")]
			get; 
		}

		long SkewMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']/method[@name='getSkewMillis' and count(parameter)=0]"
			[Register ("getSkewMillis", "()J", "GetGetSkewMillisHandler:Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker, Microsoft.Identity.Common")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']/method[@name='onTimestampReceived' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onTimestampReceived", "(J)V", "GetOnTimestampReceived_JHandler:Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker, Microsoft.Identity.Common")]
		void OnTimestampReceived (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']/method[@name='toClientTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toClientTime", "(J)Ljava/util/Date;", "GetToClientTime_JHandler:Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker, Microsoft.Identity.Common")]
		global::Java.Util.Date ToClientTime (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/interface[@name='IClockSkewManager']/method[@name='toReferenceTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toReferenceTime", "(J)Ljava/util/Date;", "GetToReferenceTime_JHandler:Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManagerInvoker, Microsoft.Identity.Common")]
		global::Java.Util.Date ToReferenceTime (long p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/IClockSkewManager", DoNotGenerateAcw=true)]
	internal partial class IClockSkewManagerInvoker : global::Java.Lang.Object, IClockSkewManager {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/IClockSkewManager", typeof (IClockSkewManagerInvoker));

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

		public static IClockSkewManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClockSkewManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.util.IClockSkewManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClockSkewManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdjustedReferenceTime;
#pragma warning disable 0169
		static Delegate GetGetAdjustedReferenceTimeHandler ()
		{
			if (cb_getAdjustedReferenceTime == null)
				cb_getAdjustedReferenceTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdjustedReferenceTime);
			return cb_getAdjustedReferenceTime;
		}

		static IntPtr n_GetAdjustedReferenceTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdjustedReferenceTime);
		}
#pragma warning restore 0169

		IntPtr id_getAdjustedReferenceTime;
		public unsafe global::Java.Util.Date AdjustedReferenceTime {
			get {
				if (id_getAdjustedReferenceTime == IntPtr.Zero)
					id_getAdjustedReferenceTime = JNIEnv.GetMethodID (class_ref, "getAdjustedReferenceTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustedReferenceTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentClientTime;
#pragma warning disable 0169
		static Delegate GetGetCurrentClientTimeHandler ()
		{
			if (cb_getCurrentClientTime == null)
				cb_getCurrentClientTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentClientTime);
			return cb_getCurrentClientTime;
		}

		static IntPtr n_GetCurrentClientTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentClientTime);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentClientTime;
		public unsafe global::Java.Util.Date CurrentClientTime {
			get {
				if (id_getCurrentClientTime == IntPtr.Zero)
					id_getCurrentClientTime = JNIEnv.GetMethodID (class_ref, "getCurrentClientTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentClientTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSkewMillis;
#pragma warning disable 0169
		static Delegate GetGetSkewMillisHandler ()
		{
			if (cb_getSkewMillis == null)
				cb_getSkewMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSkewMillis);
			return cb_getSkewMillis;
		}

		static long n_GetSkewMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkewMillis;
		}
#pragma warning restore 0169

		IntPtr id_getSkewMillis;
		public unsafe long SkewMillis {
			get {
				if (id_getSkewMillis == IntPtr.Zero)
					id_getSkewMillis = JNIEnv.GetMethodID (class_ref, "getSkewMillis", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSkewMillis);
			}
		}

		static Delegate cb_onTimestampReceived_J;
#pragma warning disable 0169
		static Delegate GetOnTimestampReceived_JHandler ()
		{
			if (cb_onTimestampReceived_J == null)
				cb_onTimestampReceived_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnTimestampReceived_J);
			return cb_onTimestampReceived_J;
		}

		static void n_OnTimestampReceived_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTimestampReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTimestampReceived_J;
		public unsafe void OnTimestampReceived (long p0)
		{
			if (id_onTimestampReceived_J == IntPtr.Zero)
				id_onTimestampReceived_J = JNIEnv.GetMethodID (class_ref, "onTimestampReceived", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimestampReceived_J, __args);
		}

		static Delegate cb_toClientTime_J;
#pragma warning disable 0169
		static Delegate GetToClientTime_JHandler ()
		{
			if (cb_toClientTime_J == null)
				cb_toClientTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ToClientTime_J);
			return cb_toClientTime_J;
		}

		static IntPtr n_ToClientTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToClientTime (p0));
		}
#pragma warning restore 0169

		IntPtr id_toClientTime_J;
		public unsafe global::Java.Util.Date ToClientTime (long p0)
		{
			if (id_toClientTime_J == IntPtr.Zero)
				id_toClientTime_J = JNIEnv.GetMethodID (class_ref, "toClientTime", "(J)Ljava/util/Date;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toClientTime_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toReferenceTime_J;
#pragma warning disable 0169
		static Delegate GetToReferenceTime_JHandler ()
		{
			if (cb_toReferenceTime_J == null)
				cb_toReferenceTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ToReferenceTime_J);
			return cb_toReferenceTime_J;
		}

		static IntPtr n_ToReferenceTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToReferenceTime (p0));
		}
#pragma warning restore 0169

		IntPtr id_toReferenceTime_J;
		public unsafe global::Java.Util.Date ToReferenceTime (long p0)
		{
			if (id_toReferenceTime_J == IntPtr.Zero)
				id_toReferenceTime_J = JNIEnv.GetMethodID (class_ref, "toReferenceTime", "(J)Ljava/util/Date;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toReferenceTime_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
