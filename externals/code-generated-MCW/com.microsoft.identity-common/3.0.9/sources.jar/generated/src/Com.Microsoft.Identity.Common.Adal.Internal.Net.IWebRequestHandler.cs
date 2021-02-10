using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Net {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IWebRequestHandler']"
	[Register ("com/microsoft/identity/common/adal/internal/net/IWebRequestHandler", "", "Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandlerInvoker")]
	public partial interface IWebRequestHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IWebRequestHandler']/method[@name='sendGet' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendGet", "(Ljava/net/URL;Ljava/util/Map;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;", "GetSendGet_Ljava_net_URL_Ljava_util_Map_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandlerInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse SendGet (global::Java.Net.URL p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IWebRequestHandler']/method[@name='sendPost' and count(parameter)=4 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendPost", "(Ljava/net/URL;Ljava/util/Map;[BLjava/lang/String;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;", "GetSendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandlerInvoker, Microsoft.Identity.Common")]
		global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse SendPost (global::Java.Net.URL p0, global::System.Collections.Generic.IDictionary<string, string> p1, byte[] p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IWebRequestHandler']/method[@name='setClientVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientVersion", "(Ljava/lang/String;)V", "GetSetClientVersion_Ljava_lang_String_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandlerInvoker, Microsoft.Identity.Common")]
		void SetClientVersion (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/interface[@name='IWebRequestHandler']/method[@name='setRequestCorrelationId' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("setRequestCorrelationId", "(Ljava/util/UUID;)V", "GetSetRequestCorrelationId_Ljava_util_UUID_Handler:Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandlerInvoker, Microsoft.Identity.Common")]
		void SetRequestCorrelationId (global::Java.Util.UUID p0);

	}

	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/net/IWebRequestHandler", DoNotGenerateAcw=true)]
	internal partial class IWebRequestHandlerInvoker : global::Java.Lang.Object, IWebRequestHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/net/IWebRequestHandler", typeof (IWebRequestHandlerInvoker));

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

		public static IWebRequestHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebRequestHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.microsoft.identity.common.adal.internal.net.IWebRequestHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebRequestHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendGet_Ljava_net_URL_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendGet_Ljava_net_URL_Ljava_util_Map_Handler ()
		{
			if (cb_sendGet_Ljava_net_URL_Ljava_util_Map_ == null)
				cb_sendGet_Ljava_net_URL_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SendGet_Ljava_net_URL_Ljava_util_Map_);
			return cb_sendGet_Ljava_net_URL_Ljava_util_Map_;
		}

		static IntPtr n_SendGet_Ljava_net_URL_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendGet (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendGet_Ljava_net_URL_Ljava_util_Map_;
		public unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse SendGet (global::Java.Net.URL p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_sendGet_Ljava_net_URL_Ljava_util_Map_ == IntPtr.Zero)
				id_sendGet_Ljava_net_URL_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendGet", "(Ljava/net/URL;Ljava/util/Map;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendGet_Ljava_net_URL_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_Handler ()
		{
			if (cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ == null)
				cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_SendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_);
			return cb_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_;
		}

		static IntPtr n_SendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendPost (p0, p1, p2, p3));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_;
		public unsafe global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse SendPost (global::Java.Net.URL p0, global::System.Collections.Generic.IDictionary<string, string> p1, byte[] p2, string p3)
		{
			if (id_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendPost", "(Ljava/net/URL;Ljava/util/Map;[BLjava/lang/String;)Lcom/microsoft/identity/common/adal/internal/net/HttpWebResponse;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.HttpWebResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendPost_Ljava_net_URL_Ljava_util_Map_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_setClientVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setClientVersion_Ljava_lang_String_ == null)
				cb_setClientVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientVersion_Ljava_lang_String_);
			return cb_setClientVersion_Ljava_lang_String_;
		}

		static void n_SetClientVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClientVersion (p0);
		}
#pragma warning restore 0169

		IntPtr id_setClientVersion_Ljava_lang_String_;
		public unsafe void SetClientVersion (string p0)
		{
			if (id_setClientVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setClientVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientVersion_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setRequestCorrelationId_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetSetRequestCorrelationId_Ljava_util_UUID_Handler ()
		{
			if (cb_setRequestCorrelationId_Ljava_util_UUID_ == null)
				cb_setRequestCorrelationId_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestCorrelationId_Ljava_util_UUID_);
			return cb_setRequestCorrelationId_Ljava_util_UUID_;
		}

		static void n_SetRequestCorrelationId_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Adal.Internal.Net.IWebRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestCorrelationId (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRequestCorrelationId_Ljava_util_UUID_;
		public unsafe void SetRequestCorrelationId (global::Java.Util.UUID p0)
		{
			if (id_setRequestCorrelationId_Ljava_util_UUID_ == IntPtr.Zero)
				id_setRequestCorrelationId_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "setRequestCorrelationId", "(Ljava/util/UUID;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestCorrelationId_Ljava_util_UUID_, __args);
		}

	}
}
