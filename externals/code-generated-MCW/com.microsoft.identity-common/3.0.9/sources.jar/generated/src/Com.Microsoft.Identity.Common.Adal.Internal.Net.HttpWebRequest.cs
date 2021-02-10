using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpWebRequest']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/net/HttpWebRequest", DoNotGenerateAcw=true)]
	public partial class HttpWebRequest : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/net/HttpWebRequest", typeof (HttpWebRequest));

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

		protected HttpWebRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpWebRequest']/constructor[@name='HttpWebRequest' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe HttpWebRequest (global::Java.Net.URL requestURL, string requestMethod, global::System.Collections.Generic.IDictionary<string, string> headers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_requestMethod = JNIEnv.NewString (requestMethod);
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((requestURL == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestURL).Handle);
				__args [1] = new JniArgumentValue (native_requestMethod);
				__args [2] = new JniArgumentValue (native_headers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestMethod);
				JNIEnv.DeleteLocalRef (native_headers);
				global::System.GC.KeepAlive (requestURL);
				global::System.GC.KeepAlive (headers);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpWebRequest']/constructor[@name='HttpWebRequest' and count(parameter)=5 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/util/Map;[BLjava/lang/String;)V", "")]
		public unsafe HttpWebRequest (global::Java.Net.URL requestURL, string requestMethod, global::System.Collections.Generic.IDictionary<string, string> headers, byte[] requestContent, string requestContentType) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Ljava/lang/String;Ljava/util/Map;[BLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_requestMethod = JNIEnv.NewString (requestMethod);
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			IntPtr native_requestContent = JNIEnv.NewArray (requestContent);
			IntPtr native_requestContentType = JNIEnv.NewString (requestContentType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((requestURL == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestURL).Handle);
				__args [1] = new JniArgumentValue (native_requestMethod);
				__args [2] = new JniArgumentValue (native_headers);
				__args [3] = new JniArgumentValue (native_requestContent);
				__args [4] = new JniArgumentValue (native_requestContentType);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestMethod);
				JNIEnv.DeleteLocalRef (native_headers);
				if (requestContent != null) {
					JNIEnv.CopyArray (native_requestContent, requestContent);
					JNIEnv.DeleteLocalRef (native_requestContent);
				}
				JNIEnv.DeleteLocalRef (native_requestContentType);
				global::System.GC.KeepAlive (requestURL);
				global::System.GC.KeepAlive (headers);
				global::System.GC.KeepAlive (requestContent);
			}
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Send);
			return cb_send;
		}

		static IntPtr n_Send (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Send ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpWebRequest']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;", "GetSendHandler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse Send ()
		{
			const string __id = "send.()Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpWebRequest']/method[@name='throwIfNetworkNotAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("throwIfNetworkNotAvailable", "(Landroid/content/Context;)V", "")]
		public static unsafe void ThrowIfNetworkNotAvailable (global::Android.Content.Context context)
		{
			const string __id = "throwIfNetworkNotAvailable.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpWebRequest']/method[@name='throwIfNetworkNotAvailable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("throwIfNetworkNotAvailable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void ThrowIfNetworkNotAvailable (global::Android.Content.Context context, bool performPowerOptimizationCheck)
		{
			const string __id = "throwIfNetworkNotAvailable.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (performPowerOptimizationCheck);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
