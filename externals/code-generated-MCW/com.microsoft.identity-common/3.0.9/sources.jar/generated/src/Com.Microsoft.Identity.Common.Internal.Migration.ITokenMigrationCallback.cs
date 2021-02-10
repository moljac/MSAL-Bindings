using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Migration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/interface[@name='TokenMigrationCallback']"
	[Register ("com/microsoft/identity/common/internal/migration/TokenMigrationCallback", "", "Com.Microsoft.Identity.Common.Internal.Migration.ITokenMigrationCallbackInvoker")]
	public partial interface ITokenMigrationCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.migration']/interface[@name='TokenMigrationCallback']/method[@name='onMigrationFinished' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMigrationFinished", "(I)V", "GetOnMigrationFinished_IHandler:Com.Microsoft.Identity.Common.Internal.Migration.ITokenMigrationCallbackInvoker, Microsoft.Identity.Common")]
		void OnMigrationFinished (int p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/migration/TokenMigrationCallback", DoNotGenerateAcw=true)]
	internal partial class ITokenMigrationCallbackInvoker : global::Java.Lang.Object, ITokenMigrationCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/migration/TokenMigrationCallback", typeof (ITokenMigrationCallbackInvoker));

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

		public static ITokenMigrationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenMigrationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.migration.TokenMigrationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenMigrationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMigrationFinished_I;
#pragma warning disable 0169
		static Delegate GetOnMigrationFinished_IHandler ()
		{
			if (cb_onMigrationFinished_I == null)
				cb_onMigrationFinished_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMigrationFinished_I);
			return cb_onMigrationFinished_I;
		}

		static void n_OnMigrationFinished_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Migration.ITokenMigrationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMigrationFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMigrationFinished_I;
		public unsafe void OnMigrationFinished (int p0)
		{
			if (id_onMigrationFinished_I == IntPtr.Zero)
				id_onMigrationFinished_I = JNIEnv.GetMethodID (class_ref, "onMigrationFinished", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMigrationFinished_I, __args);
		}

	}
}
