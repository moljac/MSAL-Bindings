using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='HeaderSerializationUtil']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/HeaderSerializationUtil", DoNotGenerateAcw=true)]
	public partial class HeaderSerializationUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/HeaderSerializationUtil", typeof (HeaderSerializationUtil));

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

		protected HeaderSerializationUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='HeaderSerializationUtil']/constructor[@name='HeaderSerializationUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HeaderSerializationUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='HeaderSerializationUtil']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> FromJson (string jsonIn)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_jsonIn = JNIEnv.NewString (jsonIn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonIn);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonIn);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='HeaderSerializationUtil']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("toJson", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string ToJson (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> headersIn)
		{
			const string __id = "toJson.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_headersIn = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (headersIn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headersIn);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headersIn);
				global::System.GC.KeepAlive (headersIn);
			}
		}

	}
}
