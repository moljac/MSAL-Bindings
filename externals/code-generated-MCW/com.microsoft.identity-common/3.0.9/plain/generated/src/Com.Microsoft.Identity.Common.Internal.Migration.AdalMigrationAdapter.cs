using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='AdalMigrationAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/migration/AdalMigrationAdapter", DoNotGenerateAcw=true)]
	public partial class AdalMigrationAdapter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/migration/AdalMigrationAdapter", typeof (AdalMigrationAdapter));

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

		protected AdalMigrationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='AdalMigrationAdapter']/constructor[@name='AdalMigrationAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/Map;Z)V", "")]
		public unsafe AdalMigrationAdapter (global::Android.Content.Context context, global::System.Collections.Generic.IDictionary<string, string> redirects, bool force) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/util/Map;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_redirects = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (redirects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_redirects);
				__args [2] = new JniArgumentValue (force);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_redirects);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (redirects);
			}
		}

		static Delegate cb_getMigrationStatus;
#pragma warning disable 0169
		static Delegate GetGetMigrationStatusHandler ()
		{
			if (cb_getMigrationStatus == null)
				cb_getMigrationStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetMigrationStatus);
			return cb_getMigrationStatus;
		}

		static bool n_GetMigrationStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.AdalMigrationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MigrationStatus;
		}
#pragma warning restore 0169

		static Delegate cb_setMigrationStatus_Z;
#pragma warning disable 0169
		static Delegate GetSetMigrationStatus_ZHandler ()
		{
			if (cb_setMigrationStatus_Z == null)
				cb_setMigrationStatus_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMigrationStatus_Z);
			return cb_setMigrationStatus_Z;
		}

		static void n_SetMigrationStatus_Z (IntPtr jnienv, IntPtr native__this, bool hasMigrated)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.AdalMigrationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MigrationStatus = hasMigrated;
		}
#pragma warning restore 0169

		public virtual unsafe bool MigrationStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='AdalMigrationAdapter']/method[@name='getMigrationStatus' and count(parameter)=0]"
			[Register ("getMigrationStatus", "()Z", "GetGetMigrationStatusHandler")]
			get {
				const string __id = "getMigrationStatus.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='AdalMigrationAdapter']/method[@name='setMigrationStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMigrationStatus", "(Z)V", "GetSetMigrationStatus_ZHandler")]
			set {
				const string __id = "setMigrationStatus.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_adapt_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdapt_Ljava_util_Map_Handler ()
		{
			if (cb_adapt_Ljava_util_Map_ == null)
				cb_adapt_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Adapt_Ljava_util_Map_);
			return cb_adapt_Ljava_util_Map_;
		}

		static IntPtr n_Adapt_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheItems)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.AdalMigrationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cacheItems = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_cacheItems, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.Adapt (cacheItems));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='AdalMigrationAdapter']/method[@name='adapt' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("adapt", "(Ljava/util/Map;)Ljava/util/List;", "GetAdapt_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> Adapt (global::System.Collections.Generic.IDictionary<string, string> cacheItems)
		{
			const string __id = "adapt.(Ljava/util/Map;)Ljava/util/List;";
			IntPtr native_cacheItems = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (cacheItems);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cacheItems);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cacheItems);
				global::System.GC.KeepAlive (cacheItems);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/class[@name='AdalMigrationAdapter']/method[@name='loadCloudDiscoveryMetadata' and count(parameter)=0]"
		[Register ("loadCloudDiscoveryMetadata", "()Z", "")]
		public static unsafe bool LoadCloudDiscoveryMetadata ()
		{
			const string __id = "loadCloudDiscoveryMetadata.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
