using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='UsageStatsManagerWrapper']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/UsageStatsManagerWrapper", DoNotGenerateAcw=true)]
	public partial class UsageStatsManagerWrapper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/UsageStatsManagerWrapper", typeof (UsageStatsManagerWrapper));

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

		protected UsageStatsManagerWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='UsageStatsManagerWrapper']/constructor[@name='UsageStatsManagerWrapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsageStatsManagerWrapper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.UsageStatsManagerWrapper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='UsageStatsManagerWrapper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/adal/internal/UsageStatsManagerWrapper;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/adal/internal/UsageStatsManagerWrapper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.UsageStatsManagerWrapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='UsageStatsManagerWrapper']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.adal.internal.UsageStatsManagerWrapper']]"
			[Register ("setInstance", "(Lcom/microsoft/identity/common/adal/internal/UsageStatsManagerWrapper;)V", "")]
			set {
				const string __id = "setInstance.(Lcom/microsoft/identity/common/adal/internal/UsageStatsManagerWrapper;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isAppInactive_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsAppInactive_Landroid_content_Context_Handler ()
		{
			if (cb_isAppInactive_Landroid_content_Context_ == null)
				cb_isAppInactive_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsAppInactive_Landroid_content_Context_);
			return cb_isAppInactive_Landroid_content_Context_;
		}

		static bool n_IsAppInactive_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectionContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.UsageStatsManagerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectionContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_connectionContext, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAppInactive (connectionContext);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal']/class[@name='UsageStatsManagerWrapper']/method[@name='isAppInactive' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAppInactive", "(Landroid/content/Context;)Z", "GetIsAppInactive_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsAppInactive (global::Android.Content.Context connectionContext)
		{
			const string __id = "isAppInactive.(Landroid/content/Context;)Z";
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
