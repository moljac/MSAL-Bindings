using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Broker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='PackageHelper']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/broker/PackageHelper", DoNotGenerateAcw=true)]
	public partial class PackageHelper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/broker/PackageHelper", typeof (PackageHelper));

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

		protected PackageHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='PackageHelper']/constructor[@name='PackageHelper' and count(parameter)=1 and parameter[1][@type='android.content.pm.PackageManager']]"
		[Register (".ctor", "(Landroid/content/pm/PackageManager;)V", "")]
		public unsafe PackageHelper (global::Android.Content.PM.PackageManager packageManager) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/pm/PackageManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packageManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packageManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packageManager);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='PackageHelper']/method[@name='getBrokerRedirectUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBrokerRedirectUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetBrokerRedirectUrl (string packageName, string signatureDigest)
		{
			const string __id = "getBrokerRedirectUrl.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			IntPtr native_signatureDigest = JNIEnv.NewString (signatureDigest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_signatureDigest);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				JNIEnv.DeleteLocalRef (native_signatureDigest);
			}
		}

		static Delegate cb_getCurrentSignatureForPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCurrentSignatureForPackage_Ljava_lang_String_Handler ()
		{
			if (cb_getCurrentSignatureForPackage_Ljava_lang_String_ == null)
				cb_getCurrentSignatureForPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCurrentSignatureForPackage_Ljava_lang_String_);
			return cb_getCurrentSignatureForPackage_Ljava_lang_String_;
		}

		static IntPtr n_GetCurrentSignatureForPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.PackageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetCurrentSignatureForPackage (packageName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='PackageHelper']/method[@name='getCurrentSignatureForPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCurrentSignatureForPackage", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetCurrentSignatureForPackage_Ljava_lang_String_Handler")]
		public virtual unsafe string GetCurrentSignatureForPackage (string packageName)
		{
			const string __id = "getCurrentSignatureForPackage.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_getUIDForPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUIDForPackage_Ljava_lang_String_Handler ()
		{
			if (cb_getUIDForPackage_Ljava_lang_String_ == null)
				cb_getUIDForPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetUIDForPackage_Ljava_lang_String_);
			return cb_getUIDForPackage_Ljava_lang_String_;
		}

		static int n_GetUIDForPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.PackageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUIDForPackage (packageName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='PackageHelper']/method[@name='getUIDForPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUIDForPackage", "(Ljava/lang/String;)I", "GetGetUIDForPackage_Ljava_lang_String_Handler")]
		public virtual unsafe int GetUIDForPackage (string packageName)
		{
			const string __id = "getUIDForPackage.(Ljava/lang/String;)I";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageName);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_isPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_isPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_isPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IsPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_);
			return cb_isPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_IsPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_packageName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Broker.PackageHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPackageInstalledAndEnabled (context, packageName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.broker']/class[@name='PackageHelper']/method[@name='isPackageInstalledAndEnabled' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isPackageInstalledAndEnabled", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetIsPackageInstalledAndEnabled_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsPackageInstalledAndEnabled (global::Android.Content.Context context, string packageName)
		{
			const string __id = "isPackageInstalledAndEnabled.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_packageName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
