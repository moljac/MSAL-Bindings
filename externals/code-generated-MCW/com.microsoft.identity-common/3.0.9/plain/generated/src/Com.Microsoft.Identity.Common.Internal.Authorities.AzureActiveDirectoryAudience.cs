using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authorities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience", DoNotGenerateAcw=true)]
	public abstract partial class AzureActiveDirectoryAudience : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/field[@name='ALL']"
		[Register ("ALL")]
		public const string All = (string) "common";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/field[@name='CONSUMERS']"
		[Register ("CONSUMERS")]
		public const string Consumers = (string) "consumers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/field[@name='MSA_MEGA_TENANT_ID']"
		[Register ("MSA_MEGA_TENANT_ID")]
		public const string MsaMegaTenantId = (string) "9188040d-6c67-4c5b-b112-36a304b66dad";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/field[@name='ORGANIZATIONS']"
		[Register ("ORGANIZATIONS")]
		public const string Organizations = (string) "organizations";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience", typeof (AzureActiveDirectoryAudience));

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

		protected AzureActiveDirectoryAudience (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/constructor[@name='AzureActiveDirectoryAudience' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AzureActiveDirectoryAudience () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCloudUrl;
#pragma warning disable 0169
		static Delegate GetGetCloudUrlHandler ()
		{
			if (cb_getCloudUrl == null)
				cb_getCloudUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCloudUrl);
			return cb_getCloudUrl;
		}

		static IntPtr n_GetCloudUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CloudUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setCloudUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCloudUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setCloudUrl_Ljava_lang_String_ == null)
				cb_setCloudUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCloudUrl_Ljava_lang_String_);
			return cb_setCloudUrl_Ljava_lang_String_;
		}

		static void n_SetCloudUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cloudUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cloudUrl = JNIEnv.GetString (native_cloudUrl, JniHandleOwnership.DoNotTransfer);
			__this.CloudUrl = cloudUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string CloudUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='getCloudUrl' and count(parameter)=0]"
			[Register ("getCloudUrl", "()Ljava/lang/String;", "GetGetCloudUrlHandler")]
			get {
				const string __id = "getCloudUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='setCloudUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCloudUrl", "(Ljava/lang/String;)V", "GetSetCloudUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCloudUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTenantId;
#pragma warning disable 0169
		static Delegate GetGetTenantIdHandler ()
		{
			if (cb_getTenantId == null)
				cb_getTenantId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTenantId);
			return cb_getTenantId;
		}

		static IntPtr n_GetTenantId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenantId);
		}
#pragma warning restore 0169

		static Delegate cb_setTenantId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTenantId_Ljava_lang_String_Handler ()
		{
			if (cb_setTenantId_Ljava_lang_String_ == null)
				cb_setTenantId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTenantId_Ljava_lang_String_);
			return cb_setTenantId_Ljava_lang_String_;
		}

		static void n_SetTenantId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tenantId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tenantId = JNIEnv.GetString (native_tenantId, JniHandleOwnership.DoNotTransfer);
			__this.TenantId = tenantId;
		}
#pragma warning restore 0169

		public virtual unsafe string TenantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='getTenantId' and count(parameter)=0]"
			[Register ("getTenantId", "()Ljava/lang/String;", "GetGetTenantIdHandler")]
			get {
				const string __id = "getTenantId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='setTenantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTenantId", "(Ljava/lang/String;)V", "GetSetTenantId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTenantId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='getAzureActiveDirectoryAudience' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAzureActiveDirectoryAudience", "(Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience GetAzureActiveDirectoryAudience (string cloudUrl, string tenantId)
		{
			const string __id = "getAzureActiveDirectoryAudience.(Ljava/lang/String;Ljava/lang/String;)Lcom/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience;";
			IntPtr native_cloudUrl = JNIEnv.NewString (cloudUrl);
			IntPtr native_tenantId = JNIEnv.NewString (tenantId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cloudUrl);
				__args [1] = new JniArgumentValue (native_tenantId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cloudUrl);
				JNIEnv.DeleteLocalRef (native_tenantId);
			}
		}

		static Delegate cb_getTenantUuidForAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTenantUuidForAlias_Ljava_lang_String_Handler ()
		{
			if (cb_getTenantUuidForAlias_Ljava_lang_String_ == null)
				cb_getTenantUuidForAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetTenantUuidForAlias_Ljava_lang_String_);
			return cb_getTenantUuidForAlias_Ljava_lang_String_;
		}

		static IntPtr n_GetTenantUuidForAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authorities.AzureActiveDirectoryAudience> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authority = JNIEnv.GetString (native_authority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTenantUuidForAlias (authority));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='getTenantUuidForAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTenantUuidForAlias", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTenantUuidForAlias_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTenantUuidForAlias (string authority)
		{
			const string __id = "getTenantUuidForAlias.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_authority = JNIEnv.NewString (authority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authority);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_authority);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authorities']/class[@name='AzureActiveDirectoryAudience']/method[@name='isHomeTenantAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isHomeTenantAlias", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsHomeTenantAlias (string tenantId)
		{
			const string __id = "isHomeTenantAlias.(Ljava/lang/String;)Z";
			IntPtr native_tenantId = JNIEnv.NewString (tenantId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tenantId);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_tenantId);
			}
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience", DoNotGenerateAcw=true)]
	internal partial class AzureActiveDirectoryAudienceInvoker : AzureActiveDirectoryAudience {
		public AzureActiveDirectoryAudienceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authorities/AzureActiveDirectoryAudience", typeof (AzureActiveDirectoryAudienceInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
