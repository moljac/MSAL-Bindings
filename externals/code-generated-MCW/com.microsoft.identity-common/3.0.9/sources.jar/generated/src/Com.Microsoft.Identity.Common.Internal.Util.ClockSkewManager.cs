using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/ClockSkewManager", DoNotGenerateAcw=true)]
	public partial class ClockSkewManager : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Util.IClockSkewManager {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/ClockSkewManager", typeof (ClockSkewManager));

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

		protected ClockSkewManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/constructor[@name='ClockSkewManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ClockSkewManager (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.ClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdjustedReferenceTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date AdjustedReferenceTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/method[@name='getAdjustedReferenceTime' and count(parameter)=0]"
			[Register ("getAdjustedReferenceTime", "()Ljava/util/Date;", "GetGetAdjustedReferenceTimeHandler")]
			get {
				const string __id = "getAdjustedReferenceTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.ClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentClientTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date CurrentClientTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/method[@name='getCurrentClientTime' and count(parameter)=0]"
			[Register ("getCurrentClientTime", "()Ljava/util/Date;", "GetGetCurrentClientTimeHandler")]
			get {
				const string __id = "getCurrentClientTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.ClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkewMillis;
		}
#pragma warning restore 0169

		public virtual unsafe long SkewMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/method[@name='getSkewMillis' and count(parameter)=0]"
			[Register ("getSkewMillis", "()J", "GetGetSkewMillisHandler")]
			get {
				const string __id = "getSkewMillis.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
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

		static void n_OnTimestampReceived_J (IntPtr jnienv, IntPtr native__this, long referenceTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.ClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTimestampReceived (referenceTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/method[@name='onTimestampReceived' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onTimestampReceived", "(J)V", "GetOnTimestampReceived_JHandler")]
		public virtual unsafe void OnTimestampReceived (long referenceTime)
		{
			const string __id = "onTimestampReceived.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (referenceTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_toClientTime_J;
#pragma warning disable 0169
		static Delegate GetToClientTime_JHandler ()
		{
			if (cb_toClientTime_J == null)
				cb_toClientTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ToClientTime_J);
			return cb_toClientTime_J;
		}

		static IntPtr n_ToClientTime_J (IntPtr jnienv, IntPtr native__this, long referenceTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.ClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToClientTime (referenceTime));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/method[@name='toClientTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toClientTime", "(J)Ljava/util/Date;", "GetToClientTime_JHandler")]
		public virtual unsafe global::Java.Util.Date ToClientTime (long referenceTime)
		{
			const string __id = "toClientTime.(J)Ljava/util/Date;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (referenceTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toReferenceTime_J;
#pragma warning disable 0169
		static Delegate GetToReferenceTime_JHandler ()
		{
			if (cb_toReferenceTime_J == null)
				cb_toReferenceTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ToReferenceTime_J);
			return cb_toReferenceTime_J;
		}

		static IntPtr n_ToReferenceTime_J (IntPtr jnienv, IntPtr native__this, long clientTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Util.ClockSkewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToReferenceTime (clientTime));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ClockSkewManager']/method[@name='toReferenceTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toReferenceTime", "(J)Ljava/util/Date;", "GetToReferenceTime_JHandler")]
		public virtual unsafe global::Java.Util.Date ToReferenceTime (long clientTime)
		{
			const string __id = "toReferenceTime.(J)Ljava/util/Date;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clientTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
