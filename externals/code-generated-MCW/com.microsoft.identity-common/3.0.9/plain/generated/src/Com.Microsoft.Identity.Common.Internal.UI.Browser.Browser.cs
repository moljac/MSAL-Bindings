using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.UI.Browser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/ui/browser/Browser", DoNotGenerateAcw=true)]
	public partial class Browser : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/ui/browser/Browser", typeof (Browser));

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

		protected Browser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/constructor[@name='Browser' and count(parameter)=1 and parameter[1][@type='android.content.pm.PackageInfo']]"
		[Register (".ctor", "(Landroid/content/pm/PackageInfo;)V", "")]
		public unsafe Browser (global::Android.Content.PM.PackageInfo packageInfo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/pm/PackageInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packageInfo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packageInfo);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/constructor[@name='Browser' and count(parameter)=2 and parameter[1][@type='android.content.pm.PackageInfo'] and parameter[2][@type='java.lang.Boolean']]"
		[Register (".ctor", "(Landroid/content/pm/PackageInfo;Ljava/lang/Boolean;)V", "")]
		public unsafe Browser (global::Android.Content.PM.PackageInfo packageInfo, global::Java.Lang.Boolean isCustomTabsServiceSupported) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/pm/PackageInfo;Ljava/lang/Boolean;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((packageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packageInfo).Handle);
				__args [1] = new JniArgumentValue ((isCustomTabsServiceSupported == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isCustomTabsServiceSupported).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packageInfo);
				global::System.GC.KeepAlive (isCustomTabsServiceSupported);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/constructor[@name='Browser' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Set;Ljava/lang/String;Z)V", "")]
		public unsafe Browser (string packageName, global::System.Collections.Generic.ICollection<string> signatureHashes, string version, bool isCustomTabsServiceSupported) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/Set;Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_packageName = JNIEnv.NewString (packageName);
			IntPtr native_signatureHashes = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (signatureHashes);
			IntPtr native_version = JNIEnv.NewString (version);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_signatureHashes);
				__args [2] = new JniArgumentValue (native_version);
				__args [3] = new JniArgumentValue (isCustomTabsServiceSupported);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				JNIEnv.DeleteLocalRef (native_signatureHashes);
				JNIEnv.DeleteLocalRef (native_version);
				global::System.GC.KeepAlive (signatureHashes);
			}
		}

		static Delegate cb_isCustomTabsServiceSupported;
#pragma warning disable 0169
		static Delegate GetIsCustomTabsServiceSupportedHandler ()
		{
			if (cb_isCustomTabsServiceSupported == null)
				cb_isCustomTabsServiceSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCustomTabsServiceSupported);
			return cb_isCustomTabsServiceSupported;
		}

		static bool n_IsCustomTabsServiceSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCustomTabsServiceSupported;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCustomTabsServiceSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/method[@name='isCustomTabsServiceSupported' and count(parameter)=0]"
			[Register ("isCustomTabsServiceSupported", "()Z", "GetIsCustomTabsServiceSupportedHandler")]
			get {
				const string __id = "isCustomTabsServiceSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSignatureHashes;
#pragma warning disable 0169
		static Delegate GetGetSignatureHashesHandler ()
		{
			if (cb_getSignatureHashes == null)
				cb_getSignatureHashes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignatureHashes);
			return cb_getSignatureHashes;
		}

		static IntPtr n_GetSignatureHashes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.SignatureHashes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> SignatureHashes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/method[@name='getSignatureHashes' and count(parameter)=0]"
			[Register ("getSignatureHashes", "()Ljava/util/Set;", "GetGetSignatureHashesHandler")]
			get {
				const string __id = "getSignatureHashes.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.UI.Browser.Browser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.ui.browser']/class[@name='Browser']/method[@name='generateSignatureHashes' and count(parameter)=1 and parameter[1][@type='android.content.pm.Signature[]']]"
		[Register ("generateSignatureHashes", "([Landroid/content/pm/Signature;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> GenerateSignatureHashes (global::Android.Content.PM.Signature[] signatures)
		{
			const string __id = "generateSignatureHashes.([Landroid/content/pm/Signature;)Ljava/util/Set;";
			IntPtr native_signatures = JNIEnv.NewArray (signatures);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_signatures);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (signatures != null) {
					JNIEnv.CopyArray (native_signatures, signatures);
					JNIEnv.DeleteLocalRef (native_signatures);
				}
				global::System.GC.KeepAlive (signatures);
			}
		}

	}
}
