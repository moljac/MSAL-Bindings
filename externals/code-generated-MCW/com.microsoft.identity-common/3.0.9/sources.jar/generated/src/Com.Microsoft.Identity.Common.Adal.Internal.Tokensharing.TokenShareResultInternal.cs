using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareResultInternal']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/tokensharing/TokenShareResultInternal", DoNotGenerateAcw=true)]
	public partial class TokenShareResultInternal : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/tokensharing/TokenShareResultInternal", typeof (TokenShareResultInternal));

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

		protected TokenShareResultInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareResultInternal']/constructor[@name='TokenShareResultInternal' and count(parameter)=3 and parameter[1][@type='com.microsoft.identity.common.internal.cache.ICacheRecord'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected unsafe TokenShareResultInternal (global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord cacheRecord, string refreshToken, string format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/microsoft/identity/common/internal/cache/ICacheRecord;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cacheRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheRecord).Handle);
				__args [1] = new JniArgumentValue (native_refreshToken);
				__args [2] = new JniArgumentValue (native_format);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refreshToken);
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (cacheRecord);
			}
		}

		static Delegate cb_getCacheRecord;
#pragma warning disable 0169
		static Delegate GetGetCacheRecordHandler ()
		{
			if (cb_getCacheRecord == null)
				cb_getCacheRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCacheRecord);
			return cb_getCacheRecord;
		}

		static IntPtr n_GetCacheRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareResultInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheRecord);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord CacheRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareResultInternal']/method[@name='getCacheRecord' and count(parameter)=0]"
			[Register ("getCacheRecord", "()Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetGetCacheRecordHandler")]
			get {
				const string __id = "getCacheRecord.()Lcom/microsoft/identity/common/internal/cache/ICacheRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareResultInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		public virtual unsafe string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareResultInternal']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
			get {
				const string __id = "getFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenHandler ()
		{
			if (cb_getRefreshToken == null)
				cb_getRefreshToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefreshToken);
			return cb_getRefreshToken;
		}

		static IntPtr n_GetRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareResultInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='TokenShareResultInternal']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				const string __id = "getRefreshToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
