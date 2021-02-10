using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='DualScreenActivity']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/DualScreenActivity", DoNotGenerateAcw=true)]
	public partial class DualScreenActivity : global::AndroidX.Fragment.App.FragmentActivity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/DualScreenActivity", typeof (DualScreenActivity));

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

		protected DualScreenActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='DualScreenActivity']/constructor[@name='DualScreenActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DualScreenActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getRotation_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetGetRotation_Landroid_app_Activity_Handler ()
		{
			if (cb_getRotation_Landroid_app_Activity_ == null)
				cb_getRotation_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetRotation_Landroid_app_Activity_);
			return cb_getRotation_Landroid_app_Activity_;
		}

		static int n_GetRotation_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.DualScreenActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetRotation (activity);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='DualScreenActivity']/method[@name='getRotation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getRotation", "(Landroid/app/Activity;)I", "GetGetRotation_Landroid_app_Activity_Handler")]
		public virtual unsafe int GetRotation (global::Android.App.Activity activity)
		{
			const string __id = "getRotation.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_isAppSpanned_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetIsAppSpanned_Landroid_app_Activity_Handler ()
		{
			if (cb_isAppSpanned_Landroid_app_Activity_ == null)
				cb_isAppSpanned_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsAppSpanned_Landroid_app_Activity_);
			return cb_isAppSpanned_Landroid_app_Activity_;
		}

		static bool n_IsAppSpanned_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.DualScreenActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAppSpanned (activity);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='DualScreenActivity']/method[@name='isAppSpanned' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("isAppSpanned", "(Landroid/app/Activity;)Z", "GetIsAppSpanned_Landroid_app_Activity_Handler")]
		public virtual unsafe bool IsAppSpanned (global::Android.App.Activity activity)
		{
			const string __id = "isAppSpanned.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_setFragment_Landroidx_fragment_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetSetFragment_Landroidx_fragment_app_Fragment_Handler ()
		{
			if (cb_setFragment_Landroidx_fragment_app_Fragment_ == null)
				cb_setFragment_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFragment_Landroidx_fragment_app_Fragment_);
			return cb_setFragment_Landroidx_fragment_app_Fragment_;
		}

		static void n_SetFragment_Landroidx_fragment_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.DualScreenActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fragment = global::Java.Lang.Object.GetObject<global::AndroidX.Fragment.App.Fragment> (native_fragment, JniHandleOwnership.DoNotTransfer);
			__this.SetFragment (fragment);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui']/class[@name='DualScreenActivity']/method[@name='setFragment' and count(parameter)=1 and parameter[1][@type='androidx.fragment.app.Fragment']]"
		[Register ("setFragment", "(Landroidx/fragment/app/Fragment;)V", "GetSetFragment_Landroidx_fragment_app_Fragment_Handler")]
		public virtual unsafe void SetFragment (global::AndroidX.Fragment.App.Fragment fragment)
		{
			const string __id = "setFragment.(Landroidx/fragment/app/Fragment;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fragment);
			}
		}

	}
}
