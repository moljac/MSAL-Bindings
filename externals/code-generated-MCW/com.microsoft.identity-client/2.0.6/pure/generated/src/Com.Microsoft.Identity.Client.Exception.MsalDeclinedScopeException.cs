using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalDeclinedScopeException']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/exception/MsalDeclinedScopeException", DoNotGenerateAcw=true)]
	public partial class MsalDeclinedScopeException : global::Com.Microsoft.Identity.Client.Exception.MsalException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/exception/MsalDeclinedScopeException", typeof (MsalDeclinedScopeException));

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

		protected MsalDeclinedScopeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalDeclinedScopeException']/constructor[@name='MsalDeclinedScopeException' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='com.microsoft.identity.client.AcquireTokenSilentParameters']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V", "")]
		public unsafe MsalDeclinedScopeException (global::System.Collections.Generic.IList<string> grantedScopes, global::System.Collections.Generic.IList<string> declinedScopes, global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters silentParametersForGrantedScopes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;Lcom/microsoft/identity/client/AcquireTokenSilentParameters;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_grantedScopes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (grantedScopes);
			IntPtr native_declinedScopes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (declinedScopes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_grantedScopes);
				__args [1] = new JniArgumentValue (native_declinedScopes);
				__args [2] = new JniArgumentValue ((silentParametersForGrantedScopes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) silentParametersForGrantedScopes).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_grantedScopes);
				JNIEnv.DeleteLocalRef (native_declinedScopes);
				global::System.GC.KeepAlive (grantedScopes);
				global::System.GC.KeepAlive (declinedScopes);
				global::System.GC.KeepAlive (silentParametersForGrantedScopes);
			}
		}

		static Delegate cb_getDeclinedScopes;
#pragma warning disable 0169
		static Delegate GetGetDeclinedScopesHandler ()
		{
			if (cb_getDeclinedScopes == null)
				cb_getDeclinedScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclinedScopes);
			return cb_getDeclinedScopes;
		}

		static IntPtr n_GetDeclinedScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalDeclinedScopeException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.DeclinedScopes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> DeclinedScopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalDeclinedScopeException']/method[@name='getDeclinedScopes' and count(parameter)=0]"
			[Register ("getDeclinedScopes", "()Ljava/util/List;", "GetGetDeclinedScopesHandler")]
			get {
				const string __id = "getDeclinedScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGrantedScopes;
#pragma warning disable 0169
		static Delegate GetGetGrantedScopesHandler ()
		{
			if (cb_getGrantedScopes == null)
				cb_getGrantedScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGrantedScopes);
			return cb_getGrantedScopes;
		}

		static IntPtr n_GetGrantedScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalDeclinedScopeException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GrantedScopes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> GrantedScopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalDeclinedScopeException']/method[@name='getGrantedScopes' and count(parameter)=0]"
			[Register ("getGrantedScopes", "()Ljava/util/List;", "GetGetGrantedScopesHandler")]
			get {
				const string __id = "getGrantedScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSilentParametersForGrantedScopes;
#pragma warning disable 0169
		static Delegate GetGetSilentParametersForGrantedScopesHandler ()
		{
			if (cb_getSilentParametersForGrantedScopes == null)
				cb_getSilentParametersForGrantedScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSilentParametersForGrantedScopes);
			return cb_getSilentParametersForGrantedScopes;
		}

		static IntPtr n_GetSilentParametersForGrantedScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Exception.MsalDeclinedScopeException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SilentParametersForGrantedScopes);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters SilentParametersForGrantedScopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.exception']/class[@name='MsalDeclinedScopeException']/method[@name='getSilentParametersForGrantedScopes' and count(parameter)=0]"
			[Register ("getSilentParametersForGrantedScopes", "()Lcom/microsoft/identity/client/AcquireTokenSilentParameters;", "GetGetSilentParametersForGrantedScopesHandler")]
			get {
				const string __id = "getSilentParametersForGrantedScopes.()Lcom/microsoft/identity/client/AcquireTokenSilentParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.AcquireTokenSilentParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
