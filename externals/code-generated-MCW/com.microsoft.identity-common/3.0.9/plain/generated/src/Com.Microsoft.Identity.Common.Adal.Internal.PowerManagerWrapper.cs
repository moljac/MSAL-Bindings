using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='PowerManagerWrapper']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/PowerManagerWrapper", DoNotGenerateAcw=true)]
	public partial class PowerManagerWrapper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/PowerManagerWrapper", typeof (PowerManagerWrapper));

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

		protected PowerManagerWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='PowerManagerWrapper']/constructor[@name='PowerManagerWrapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PowerManagerWrapper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.PowerManagerWrapper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='PowerManagerWrapper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/adal/internal/PowerManagerWrapper;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/adal/internal/PowerManagerWrapper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.PowerManagerWrapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='PowerManagerWrapper']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.adal.internal.PowerManagerWrapper']]"
			[Register ("setInstance", "(Lcom/microsoft/identity/common/adal/internal/PowerManagerWrapper;)V", "")]
			set {
				const string __id = "setInstance.(Lcom/microsoft/identity/common/adal/internal/PowerManagerWrapper;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isDeviceIdleMode_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsDeviceIdleMode_Landroid_content_Context_Handler ()
		{
			if (cb_isDeviceIdleMode_Landroid_content_Context_ == null)
				cb_isDeviceIdleMode_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsDeviceIdleMode_Landroid_content_Context_);
			return cb_isDeviceIdleMode_Landroid_content_Context_;
		}

		static bool n_IsDeviceIdleMode_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectionContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.PowerManagerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectionContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_connectionContext, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceIdleMode (connectionContext);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='PowerManagerWrapper']/method[@name='isDeviceIdleMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isDeviceIdleMode", "(Landroid/content/Context;)Z", "GetIsDeviceIdleMode_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsDeviceIdleMode (global::Android.Content.Context connectionContext)
		{
			const string __id = "isDeviceIdleMode.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connectionContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionContext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (connectionContext);
			}
		}

		static Delegate cb_isIgnoringBatteryOptimizations_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsIgnoringBatteryOptimizations_Landroid_content_Context_Handler ()
		{
			if (cb_isIgnoringBatteryOptimizations_Landroid_content_Context_ == null)
				cb_isIgnoringBatteryOptimizations_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsIgnoringBatteryOptimizations_Landroid_content_Context_);
			return cb_isIgnoringBatteryOptimizations_Landroid_content_Context_;
		}

		static bool n_IsIgnoringBatteryOptimizations_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectionContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.PowerManagerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectionContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_connectionContext, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsIgnoringBatteryOptimizations (connectionContext);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='PowerManagerWrapper']/method[@name='isIgnoringBatteryOptimizations' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isIgnoringBatteryOptimizations", "(Landroid/content/Context;)Z", "GetIsIgnoringBatteryOptimizations_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsIgnoringBatteryOptimizations (global::Android.Content.Context connectionContext)
		{
			const string __id = "isIgnoringBatteryOptimizations.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connectionContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionContext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (connectionContext);
			}
		}

	}
}
