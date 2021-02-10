using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Net {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IConnectionService']"
	[Register ("com/microsoft/identity/common/adal/internal/net/IConnectionService", "", "Com.Microsoft.Identity.Common.Adal.Internal.Net.IConnectionServiceInvoker")]
	public partial interface IConnectionService : IJavaObject, IJavaPeerable {
		bool IsConnectionAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IConnectionService']/method[@name='isConnectionAvailable' and count(parameter)=0]"
			[Register ("isConnectionAvailable", "()Z", "GetIsConnectionAvailableHandler:Com.Microsoft.Identity.Common.Adal.Internal.Net.IConnectionServiceInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/net/IConnectionService", DoNotGenerateAcw=true)]
	internal partial class IConnectionServiceInvoker : global::Java.Lang.Object, IConnectionService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/net/IConnectionService", typeof (IConnectionServiceInvoker));

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

		public static IConnectionService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.net.IConnectionService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isConnectionAvailable;
#pragma warning disable 0169
		static Delegate GetIsConnectionAvailableHandler ()
		{
			if (cb_isConnectionAvailable == null)
				cb_isConnectionAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnectionAvailable);
			return cb_isConnectionAvailable;
		}

		static bool n_IsConnectionAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnectionAvailable;
		}
#pragma warning restore 0169

		IntPtr id_isConnectionAvailable;
		public unsafe bool IsConnectionAvailable {
			get {
				if (id_isConnectionAvailable == IntPtr.Zero)
					id_isConnectionAvailable = JNIEnv.GetMethodID (class_ref, "isConnectionAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnectionAvailable);
			}
		}

	}
}
