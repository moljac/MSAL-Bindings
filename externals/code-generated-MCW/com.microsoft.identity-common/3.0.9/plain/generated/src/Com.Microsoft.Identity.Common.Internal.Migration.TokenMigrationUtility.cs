using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenMigrationUtility']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/migration/TokenMigrationUtility", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.BaseAccount", "U extends com.microsoft.identity.common.internal.providers.oauth2.RefreshToken"})]
	public partial class TokenMigrationUtility : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/migration/TokenMigrationUtility", typeof (TokenMigrationUtility));

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

		protected TokenMigrationUtility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenMigrationUtility']/constructor[@name='TokenMigrationUtility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenMigrationUtility () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb__import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_;
#pragma warning disable 0169
		static Delegate Get_import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_Handler ()
		{
			if (cb__import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_ == null)
				cb__import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n__import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_);
			return cb__import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_;
		}

		static void n__import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, IntPtr native_credentials, IntPtr native_destination, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.TokenMigrationUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adapter = (global::Com.Microsoft.Identity.Common.Internal.Migration.IMigrationAdapter)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.IMigrationAdapter> (native_adapter, JniHandleOwnership.DoNotTransfer);
			var credentials = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_credentials, JniHandleOwnership.DoNotTransfer);
			var destination = (global::Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnState)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnState> (native_destination, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Microsoft.Identity.Common.Internal.Migration.ITokenMigrationCallback)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.ITokenMigrationCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this._import (adapter, credentials, destination, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='TokenMigrationUtility']/method[@name='_import' and count(parameter)=4 and parameter[1][@type='com.microsoft.identity.common.internal.migration.IMigrationAdapter&lt;T, U&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='com.microsoft.identity.common.internal.cache.IShareSingleSignOnState&lt;T, U&gt;'] and parameter[4][@type='com.microsoft.identity.common.internal.migration.TokenMigrationCallback']]"
		[Register ("_import", "(Lcom/microsoft/identity/common/internal/migration/IMigrationAdapter;Ljava/util/Map;Lcom/microsoft/identity/common/internal/cache/IShareSingleSignOnState;Lcom/microsoft/identity/common/internal/migration/TokenMigrationCallback;)V", "Get_import_Lcom_microsoft_identity_common_internal_migration_IMigrationAdapter_Ljava_util_Map_Lcom_microsoft_identity_common_internal_cache_IShareSingleSignOnState_Lcom_microsoft_identity_common_internal_migration_TokenMigrationCallback_Handler")]
		public virtual unsafe void _import (global::Com.Microsoft.Identity.Common.Internal.Migration.IMigrationAdapter adapter, global::System.Collections.Generic.IDictionary<string, string> credentials, global::Com.Microsoft.Identity.Common.Internal.Cache.IShareSingleSignOnState destination, global::Com.Microsoft.Identity.Common.Internal.Migration.ITokenMigrationCallback @callback)
		{
			const string __id = "_import.(Lcom/microsoft/identity/common/internal/migration/IMigrationAdapter;Ljava/util/Map;Lcom/microsoft/identity/common/internal/cache/IShareSingleSignOnState;Lcom/microsoft/identity/common/internal/migration/TokenMigrationCallback;)V";
			IntPtr native_credentials = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (credentials);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				__args [1] = new JniArgumentValue (native_credentials);
				__args [2] = new JniArgumentValue ((destination == null) ? IntPtr.Zero : ((global::Java.Lang.Object) destination).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_credentials);
				global::System.GC.KeepAlive (adapter);
				global::System.GC.KeepAlive (credentials);
				global::System.GC.KeepAlive (destination);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
