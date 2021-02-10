using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='ITokenShareResultInternal.TokenShareExportFormatInternal']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal$TokenShareExportFormatInternal", DoNotGenerateAcw=true)]
	public partial class TokenShareResultInternalTokenShareExportFormatInternal : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='ITokenShareResultInternal.TokenShareExportFormatInternal']/field[@name='RAW']"
		[Register ("RAW")]
		public const string Raw = (string) "RAW";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/class[@name='ITokenShareResultInternal.TokenShareExportFormatInternal']/field[@name='SSO_STATE_SERIALIZER_BLOB']"
		[Register ("SSO_STATE_SERIALIZER_BLOB")]
		public const string SsoStateSerializerBlob = (string) "SSO_STATE_SERIALIZER_BLOB";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal$TokenShareExportFormatInternal", typeof (TokenShareResultInternalTokenShareExportFormatInternal));

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

		protected TokenShareResultInternalTokenShareExportFormatInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareResultInternal']"
	[Register ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal", "", "Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternalInvoker")]
	public partial interface ITokenShareResultInternal : IJavaObject, IJavaPeerable {
		global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord CacheRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareResultInternal']/method[@name='getCacheRecord' and count(parameter)=0]"
			[Register ("getCacheRecord", "()Lcom/microsoft/identity/common/internal/cache/ICacheRecord;", "GetGetCacheRecordHandler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternalInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareResultInternal']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternalInvoker, Microsoft.Identity.Common")]
			get; 
		}

		string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.tokensharing']/interface[@name='ITokenShareResultInternal']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternalInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal", DoNotGenerateAcw=true)]
	internal partial class ITokenShareResultInternalInvoker : global::Java.Lang.Object, ITokenShareResultInternal {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal", typeof (ITokenShareResultInternalInvoker));

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

		public static ITokenShareResultInternal GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenShareResultInternal> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.tokensharing.ITokenShareResultInternal"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenShareResultInternalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheRecord);
		}
#pragma warning restore 0169

		IntPtr id_getCacheRecord;
		public unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord CacheRecord {
			get {
				if (id_getCacheRecord == IntPtr.Zero)
					id_getCacheRecord = JNIEnv.GetMethodID (class_ref, "getCacheRecord", "()Lcom/microsoft/identity/common/internal/cache/ICacheRecord;");
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheRecord), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		IntPtr id_getFormat;
		public unsafe string Format {
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.ITokenShareResultInternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshToken;
		public unsafe string RefreshToken {
			get {
				if (id_getRefreshToken == IntPtr.Zero)
					id_getRefreshToken = JNIEnv.GetMethodID (class_ref, "getRefreshToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshToken), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
