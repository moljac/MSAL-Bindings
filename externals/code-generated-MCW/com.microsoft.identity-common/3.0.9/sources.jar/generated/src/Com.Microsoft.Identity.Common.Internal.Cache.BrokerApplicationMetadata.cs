using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='BrokerApplicationMetadata']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/BrokerApplicationMetadata", DoNotGenerateAcw=true)]
	public partial class BrokerApplicationMetadata : global::Com.Microsoft.Identity.Common.Internal.Cache.AbstractApplicationMetadata {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/BrokerApplicationMetadata", typeof (BrokerApplicationMetadata));

		internal static new IntPtr class_ref {
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

		protected BrokerApplicationMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='BrokerApplicationMetadata']/constructor[@name='BrokerApplicationMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrokerApplicationMetadata () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getFoci;
#pragma warning disable 0169
		static Delegate GetGetFociHandler ()
		{
			if (cb_getFoci == null)
				cb_getFoci = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFoci);
			return cb_getFoci;
		}

		static IntPtr n_GetFoci (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Foci);
		}
#pragma warning restore 0169

		static Delegate cb_setFoci_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFoci_Ljava_lang_String_Handler ()
		{
			if (cb_setFoci_Ljava_lang_String_ == null)
				cb_setFoci_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFoci_Ljava_lang_String_);
			return cb_setFoci_Ljava_lang_String_;
		}

		static void n_SetFoci_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mFoci)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.BrokerApplicationMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mFoci = JNIEnv.GetString (native_mFoci, JniHandleOwnership.DoNotTransfer);
			__this.Foci = mFoci;
		}
#pragma warning restore 0169

		public virtual unsafe string Foci {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='BrokerApplicationMetadata']/method[@name='getFoci' and count(parameter)=0]"
			[Register ("getFoci", "()Ljava/lang/String;", "GetGetFociHandler")]
			get {
				const string __id = "getFoci.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='BrokerApplicationMetadata']/method[@name='setFoci' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFoci", "(Ljava/lang/String;)V", "GetSetFoci_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFoci.(Ljava/lang/String;)V";
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

	}
}
