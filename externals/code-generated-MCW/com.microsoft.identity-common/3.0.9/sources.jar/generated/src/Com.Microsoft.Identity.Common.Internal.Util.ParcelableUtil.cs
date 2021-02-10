using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ParcelableUtil']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/ParcelableUtil", DoNotGenerateAcw=true)]
	public sealed partial class ParcelableUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/ParcelableUtil", typeof (ParcelableUtil));

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

		internal ParcelableUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ParcelableUtil']/method[@name='marshall' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("marshall", "(Landroid/os/Parcelable;)[B", "")]
		public static unsafe byte[] Marshall (global::Android.OS.IParcelable parcelable)
		{
			const string __id = "marshall.(Landroid/os/Parcelable;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parcelable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcelable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (parcelable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ParcelableUtil']/method[@name='unmarshall' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("unmarshall", "([B)Landroid/os/Parcel;", "")]
		public static unsafe global::Android.OS.Parcel Unmarshall (byte[] bytes)
		{
			const string __id = "unmarshall.([B)Landroid/os/Parcel;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='ParcelableUtil']/method[@name='unmarshall' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.os.Parcelable.Creator&lt;T&gt;']]"
		[Register ("unmarshall", "([BLandroid/os/Parcelable$Creator;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Unmarshall (byte[] bytes, global::Android.OS.IParcelableCreator creator)
		{
			const string __id = "unmarshall.([BLandroid/os/Parcelable$Creator;)Ljava/lang/Object;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue ((creator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) creator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
				global::System.GC.KeepAlive (creator);
			}
		}

	}
}
