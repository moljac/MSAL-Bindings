using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Authscheme {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='INonced']"
	[Register ("com/microsoft/identity/common/internal/authscheme/INonced", "", "Com.Microsoft.Identity.Common.Internal.Authscheme.INoncedInvoker")]
	public partial interface INonced : global::Java.IO.ISerializable {
		string Nonce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.authscheme']/interface[@name='INonced']/method[@name='getNonce' and count(parameter)=0]"
			[Register ("getNonce", "()Ljava/lang/String;", "GetGetNonceHandler:Com.Microsoft.Identity.Common.Internal.Authscheme.INoncedInvoker, Microsoft.Identity.Common")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/authscheme/INonced", DoNotGenerateAcw=true)]
	internal partial class INoncedInvoker : global::Java.Lang.Object, INonced {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/authscheme/INonced", typeof (INoncedInvoker));

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

		public static INonced GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INonced> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.internal.authscheme.INonced"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INoncedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getNonce;
#pragma warning disable 0169
		static Delegate GetGetNonceHandler ()
		{
			if (cb_getNonce == null)
				cb_getNonce = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNonce);
			return cb_getNonce;
		}

		static IntPtr n_GetNonce (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Authscheme.INonced> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nonce);
		}
#pragma warning restore 0169

		IntPtr id_getNonce;
		public unsafe string Nonce {
			get {
				if (id_getNonce == IntPtr.Zero)
					id_getNonce = JNIEnv.GetMethodID (class_ref, "getNonce", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNonce), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
