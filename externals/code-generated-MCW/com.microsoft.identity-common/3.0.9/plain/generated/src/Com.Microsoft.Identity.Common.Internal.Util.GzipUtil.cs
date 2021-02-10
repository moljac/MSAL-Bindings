using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='GzipUtil']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/GzipUtil", DoNotGenerateAcw=true)]
	public partial class GzipUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/GzipUtil", typeof (GzipUtil));

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

		protected GzipUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='GzipUtil']/constructor[@name='GzipUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GzipUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='GzipUtil']/method[@name='compressString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("compressString", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] CompressString (string inputString)
		{
			const string __id = "compressString.(Ljava/lang/String;)[B";
			IntPtr native_inputString = JNIEnv.NewString (inputString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_inputString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='GzipUtil']/method[@name='decompressBytesToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decompressBytesToString", "([B)Ljava/lang/String;", "")]
		public static unsafe string DecompressBytesToString (byte[] compressedBytes)
		{
			const string __id = "decompressBytesToString.([B)Ljava/lang/String;";
			IntPtr native_compressedBytes = JNIEnv.NewArray (compressedBytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_compressedBytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (compressedBytes != null) {
					JNIEnv.CopyArray (native_compressedBytes, compressedBytes);
					JNIEnv.DeleteLocalRef (native_compressedBytes);
				}
				global::System.GC.KeepAlive (compressedBytes);
			}
		}

	}
}
