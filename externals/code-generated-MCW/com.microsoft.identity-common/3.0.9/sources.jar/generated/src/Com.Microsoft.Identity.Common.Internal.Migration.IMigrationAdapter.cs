using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Migration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/interface[@name='IMigrationAdapter']"
	[Register ("com/microsoft/identity/common/internal/migration/IMigrationAdapter", "", "Com.Microsoft.Identity.Common.Internal.Migration.IMigrationAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.microsoft.identity.common.BaseAccount", "U extends com.microsoft.identity.common.internal.providers.oauth2.RefreshToken"})]
	public partial interface IMigrationAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/interface[@name='IMigrationAdapter']/method[@name='adapt' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("adapt", "(Ljava/util/Map;)Ljava/util/List;", "GetAdapt_Ljava_util_Map_Handler:Com.Microsoft.Identity.Common.Internal.Migration.IMigrationAdapterInvoker, Microsoft.Identity.Common")]
		global::System.Collections.Generic.IList<global::Android.Util.Pair> Adapt (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/migration/IMigrationAdapter", DoNotGenerateAcw=true)]
	internal partial class IMigrationAdapterInvoker : global::Java.Lang.Object, IMigrationAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/migration/IMigrationAdapter", typeof (IMigrationAdapterInvoker));

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

		public static IMigrationAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMigrationAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.migration.IMigrationAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMigrationAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_adapt_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdapt_Ljava_util_Map_Handler ()
		{
			if (cb_adapt_Ljava_util_Map_ == null)
				cb_adapt_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Adapt_Ljava_util_Map_);
			return cb_adapt_Ljava_util_Map_;
		}

		static IntPtr n_Adapt_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.IMigrationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.Adapt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_adapt_Ljava_util_Map_;
		public unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> Adapt (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_adapt_Ljava_util_Map_ == IntPtr.Zero)
				id_adapt_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "adapt", "(Ljava/util/Map;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adapt_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
