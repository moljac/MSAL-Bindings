using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/HelloCache", DoNotGenerateAcw=true)]
	public partial class HelloCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/HelloCache", typeof (HelloCache));

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

		protected HelloCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']/constructor[@name='HelloCache' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe HelloCache (global::Android.Content.Context context, string protocolName, string targetAppPackageName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_protocolName = JNIEnv.NewString (protocolName);
			IntPtr native_targetAppPackageName = JNIEnv.NewString (targetAppPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_protocolName);
				__args [2] = new JniArgumentValue (native_targetAppPackageName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_protocolName);
				JNIEnv.DeleteLocalRef (native_targetAppPackageName);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getVersionCode;
#pragma warning disable 0169
		static Delegate GetGetVersionCodeHandler ()
		{
			if (cb_getVersionCode == null)
				cb_getVersionCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersionCode);
			return cb_getVersionCode;
		}

		static IntPtr n_GetVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.HelloCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionCode);
		}
#pragma warning restore 0169

		public virtual unsafe string VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()Ljava/lang/String;", "GetGetVersionCodeHandler")]
			get {
				const string __id = "getVersionCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearCache;
#pragma warning disable 0169
		static Delegate GetClearCacheHandler ()
		{
			if (cb_clearCache == null)
				cb_clearCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearCache);
			return cb_clearCache;
		}

		static void n_ClearCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.HelloCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCache ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']/method[@name='clearCache' and count(parameter)=0]"
		[Register ("clearCache", "()V", "GetClearCacheHandler")]
		public virtual unsafe void ClearCache ()
		{
			const string __id = "clearCache.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_saveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_saveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_saveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SaveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_saveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SaveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientMinimumProtocolVersion, IntPtr native_clientMaximumProtocolVersion, IntPtr native_negotiatedProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.HelloCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientMinimumProtocolVersion = JNIEnv.GetString (native_clientMinimumProtocolVersion, JniHandleOwnership.DoNotTransfer);
			var clientMaximumProtocolVersion = JNIEnv.GetString (native_clientMaximumProtocolVersion, JniHandleOwnership.DoNotTransfer);
			var negotiatedProtocolVersion = JNIEnv.GetString (native_negotiatedProtocolVersion, JniHandleOwnership.DoNotTransfer);
			__this.SaveNegotiatedProtocolVersion (clientMinimumProtocolVersion, clientMaximumProtocolVersion, negotiatedProtocolVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']/method[@name='saveNegotiatedProtocolVersion' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("saveNegotiatedProtocolVersion", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSaveNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveNegotiatedProtocolVersion (string clientMinimumProtocolVersion, string clientMaximumProtocolVersion, string negotiatedProtocolVersion)
		{
			const string __id = "saveNegotiatedProtocolVersion.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientMinimumProtocolVersion = JNIEnv.NewString (clientMinimumProtocolVersion);
			IntPtr native_clientMaximumProtocolVersion = JNIEnv.NewString (clientMaximumProtocolVersion);
			IntPtr native_negotiatedProtocolVersion = JNIEnv.NewString (negotiatedProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_clientMinimumProtocolVersion);
				__args [1] = new JniArgumentValue (native_clientMaximumProtocolVersion);
				__args [2] = new JniArgumentValue (native_negotiatedProtocolVersion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientMinimumProtocolVersion);
				JNIEnv.DeleteLocalRef (native_clientMaximumProtocolVersion);
				JNIEnv.DeleteLocalRef (native_negotiatedProtocolVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']/method[@name='setIsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsEnabled", "(Z)V", "")]
		public static unsafe void SetIsEnabled (bool value)
		{
			const string __id = "setIsEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_tryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_tryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_tryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_TryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_);
			return cb_tryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_TryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientMinimumProtocolVersion, IntPtr native_clientMaximumProtocolVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.HelloCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientMinimumProtocolVersion = JNIEnv.GetString (native_clientMinimumProtocolVersion, JniHandleOwnership.DoNotTransfer);
			var clientMaximumProtocolVersion = JNIEnv.GetString (native_clientMaximumProtocolVersion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.TryGetNegotiatedProtocolVersion (clientMinimumProtocolVersion, clientMaximumProtocolVersion));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='HelloCache']/method[@name='tryGetNegotiatedProtocolVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("tryGetNegotiatedProtocolVersion", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetTryGetNegotiatedProtocolVersion_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string TryGetNegotiatedProtocolVersion (string clientMinimumProtocolVersion, string clientMaximumProtocolVersion)
		{
			const string __id = "tryGetNegotiatedProtocolVersion.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_clientMinimumProtocolVersion = JNIEnv.NewString (clientMinimumProtocolVersion);
			IntPtr native_clientMaximumProtocolVersion = JNIEnv.NewString (clientMaximumProtocolVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientMinimumProtocolVersion);
				__args [1] = new JniArgumentValue (native_clientMaximumProtocolVersion);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientMinimumProtocolVersion);
				JNIEnv.DeleteLocalRef (native_clientMaximumProtocolVersion);
			}
		}

	}
}
