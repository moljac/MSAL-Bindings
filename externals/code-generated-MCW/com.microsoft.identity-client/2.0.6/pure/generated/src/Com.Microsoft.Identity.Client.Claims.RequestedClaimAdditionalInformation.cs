using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Claims {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/claims/RequestedClaimAdditionalInformation", DoNotGenerateAcw=true)]
	public partial class RequestedClaimAdditionalInformation : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation.SerializedNames']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/claims/RequestedClaimAdditionalInformation$SerializedNames", DoNotGenerateAcw=true)]
		public sealed partial class SerializedNames : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/claims/RequestedClaimAdditionalInformation$SerializedNames", typeof (SerializedNames));

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

			internal SerializedNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation.SerializedNames']/constructor[@name='RequestedClaimAdditionalInformation.SerializedNames' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SerializedNames () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/claims/RequestedClaimAdditionalInformation", typeof (RequestedClaimAdditionalInformation));

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

		protected RequestedClaimAdditionalInformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/constructor[@name='RequestedClaimAdditionalInformation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestedClaimAdditionalInformation () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getEssential;
#pragma warning disable 0169
		static Delegate GetGetEssentialHandler ()
		{
			if (cb_getEssential == null)
				cb_getEssential = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEssential);
			return cb_getEssential;
		}

		static IntPtr n_GetEssential (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Essential);
		}
#pragma warning restore 0169

		static Delegate cb_setEssential_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetEssential_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setEssential_Ljava_lang_Boolean_ == null)
				cb_setEssential_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEssential_Ljava_lang_Boolean_);
			return cb_setEssential_Ljava_lang_Boolean_;
		}

		static void n_SetEssential_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_essential)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var essential = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_essential, JniHandleOwnership.DoNotTransfer);
			__this.Essential = essential;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean Essential {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/method[@name='getEssential' and count(parameter)=0]"
			[Register ("getEssential", "()Ljava/lang/Boolean;", "GetGetEssentialHandler")]
			get {
				const string __id = "getEssential.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/method[@name='setEssential' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setEssential", "(Ljava/lang/Boolean;)V", "GetSetEssential_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setEssential.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Object_Handler ()
		{
			if (cb_setValue_Ljava_lang_Object_ == null)
				cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_Ljava_lang_Object_);
			return cb_setValue_Ljava_lang_Object_;
		}

		static void n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Value = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setValue.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (__this.Values);
		}
#pragma warning restore 0169

		static Delegate cb_setValues_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetValues_Ljava_util_List_Handler ()
		{
			if (cb_setValues_Ljava_util_List_ == null)
				cb_setValues_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValues_Ljava_util_List_);
			return cb_setValues_Ljava_util_List_;
		}

		static void n_SetValues_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Claims.RequestedClaimAdditionalInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.Values = values;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object> Values {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/method[@name='getValues' and count(parameter)=0]"
			[Register ("getValues", "()Ljava/util/List;", "GetGetValuesHandler")]
			get {
				const string __id = "getValues.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.claims']/class[@name='RequestedClaimAdditionalInformation']/method[@name='setValues' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Object&gt;']]"
			[Register ("setValues", "(Ljava/util/List;)V", "GetSetValues_Ljava_util_List_Handler")]
			set {
				const string __id = "setValues.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
