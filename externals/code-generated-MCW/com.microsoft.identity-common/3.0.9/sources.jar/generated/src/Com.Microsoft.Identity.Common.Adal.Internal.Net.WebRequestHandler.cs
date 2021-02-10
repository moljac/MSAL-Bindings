using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/net/WebRequestHandler", DoNotGenerateAcw=true)]
	public partial class WebRequestHandler : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandler {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/field[@name='HEADER_ACCEPT']"
		[Register ("HEADER_ACCEPT")]
		public const string HeaderAccept = (string) "Accept";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/field[@name='HEADER_ACCEPT_JSON']"
		[Register ("HEADER_ACCEPT_JSON")]
		public const string HeaderAcceptJson = (string) "application/json";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/net/WebRequestHandler", typeof (WebRequestHandler));

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

		protected WebRequestHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/constructor[@name='WebRequestHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebRequestHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_sendGet_Ljava_net_URL_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendGet_Ljava_net_URL_Ljava_util_Map_Handler ()
		{
			if (cb_sendGet_Ljava_net_URL_Ljava_util_Map_ == null)
				cb_sendGet_Ljava_net_URL_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SendGet_Ljava_net_URL_Ljava_util_Map_);
			return cb_sendGet_Ljava_net_URL_Ljava_util_Map_;
		}

		static IntPtr n_SendGet_Ljava_net_URL_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.WebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendGet (url, headers));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/method[@name='sendGet' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendGet", "(Ljava/net/URL;Ljava/util/Map;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;", "GetSendGet_Ljava_net_URL_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse SendGet (global::Java.Net.URL url, global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			const string __id = "sendGet.(Ljava/net/URL;Ljava/util/Map;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue (native_headers);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				global::System.GC.KeepAlive (url);
				global::System.GC.KeepAlive (headers);
			}
		}

		static Delegate cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_Handler ()
		{
			if (cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ == null)
				cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_SendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_);
			return cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_;
		}

		static IntPtr n_SendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native_content, IntPtr native_contentType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.WebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			var content = (byte[]) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var contentType = JNIEnv.GetString (native_contentType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendPost (url, headers, content, contentType));
			if (content != null)
				JNIEnv.CopyArray (content, native_content);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/method[@name='sendPost' and count(parameter)=4 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendPost", "(Ljava/net/URL;Ljava/util/Map;[BLjava/lang/String;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;", "GetSendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse SendPost (global::Java.Net.URL url, global::System.Collections.Generic.IDictionary<string, string> headers, byte[] content, string contentType)
		{
			const string __id = "sendPost.(Ljava/net/URL;Ljava/util/Map;[BLjava/lang/String;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			IntPtr native_content = JNIEnv.NewArray (content);
			IntPtr native_contentType = JNIEnv.NewString (contentType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue (native_headers);
				__args [2] = new JniArgumentValue (native_content);
				__args [3] = new JniArgumentValue (native_contentType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
				JNIEnv.DeleteLocalRef (native_contentType);
				global::System.GC.KeepAlive (url);
				global::System.GC.KeepAlive (headers);
				global::System.GC.KeepAlive (content);
			}
		}

		static Delegate cb_setClientVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setClientVersion_Ljava_lang_String_ == null)
				cb_setClientVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientVersion_Ljava_lang_String_);
			return cb_setClientVersion_Ljava_lang_String_;
		}

		static void n_SetClientVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.WebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clientVersion = JNIEnv.GetString (native_clientVersion, JniHandleOwnership.DoNotTransfer);
			__this.SetClientVersion (clientVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/method[@name='setClientVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientVersion", "(Ljava/lang/String;)V", "GetSetClientVersion_Ljava_lang_String_Handler")]
		public virtual unsafe void SetClientVersion (string clientVersion)
		{
			const string __id = "setClientVersion.(Ljava/lang/String;)V";
			IntPtr native_clientVersion = JNIEnv.NewString (clientVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_clientVersion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientVersion);
			}
		}

		static Delegate cb_setRequestCorrelationId_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetSetRequestCorrelationId_Ljava_util_UUID_Handler ()
		{
			if (cb_setRequestCorrelationId_Ljava_util_UUID_ == null)
				cb_setRequestCorrelationId_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestCorrelationId_Ljava_util_UUID_);
			return cb_setRequestCorrelationId_Ljava_util_UUID_;
		}

		static void n_SetRequestCorrelationId_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestCorrelationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.WebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var requestCorrelationId = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_requestCorrelationId, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestCorrelationId (requestCorrelationId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='WebRequestHandler']/method[@name='setRequestCorrelationId' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("setRequestCorrelationId", "(Ljava/util/UUID;)V", "GetSetRequestCorrelationId_Ljava_util_UUID_Handler")]
		public virtual unsafe void SetRequestCorrelationId (global::Java.Util.UUID requestCorrelationId)
		{
			const string __id = "setRequestCorrelationId.(Ljava/util/UUID;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestCorrelationId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCorrelationId).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (requestCorrelationId);
			}
		}

	}
}
