using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Adal.Internal.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpUrlConnectionFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/adal/internal/net/HttpUrlConnectionFactory", DoNotGenerateAcw=true)]
	public sealed partial class HttpUrlConnectionFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/adal/internal/net/HttpUrlConnectionFactory", typeof (HttpUrlConnectionFactory));

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

		internal HttpUrlConnectionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Java.Net.URL MockedConnectionOpenUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpUrlConnectionFactory']/method[@name='getMockedConnectionOpenUrl' and count(parameter)=0]"
			[Register ("getMockedConnectionOpenUrl", "()Ljava/net/URL;", "")]
			get {
				const string __id = "getMockedConnectionOpenUrl.()Ljava/net/URL;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpUrlConnectionFactory']/method[@name='createHttpUrlConnection' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("createHttpUrlConnection", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;", "")]
		public static unsafe global::Java.Net.HttpURLConnection CreateHttpUrlConnection (global::Java.Net.URL url)
		{
			const string __id = "createHttpUrlConnection.(Ljava/net/URL;)Ljava/net/HttpURLConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.adal.internal.net']/class[@name='HttpUrlConnectionFactory']/method[@name='setMockedHttpUrlConnection' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register ("setMockedHttpUrlConnection", "(Ljava/net/HttpURLConnection;)V", "")]
		public static unsafe void SetMockedHttpUrlConnection (global::Java.Net.HttpURLConnection mockedHttpUrlConnection)
		{
			const string __id = "setMockedHttpUrlConnection.(Ljava/net/HttpURLConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mockedHttpUrlConnection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mockedHttpUrlConnection).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (mockedHttpUrlConnection);
			}
		}

	}
}
