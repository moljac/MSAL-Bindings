using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/util/StringUtil", DoNotGenerateAcw=true)]
	public sealed partial class StringUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/util/StringUtil", typeof (StringUtil));

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

		internal StringUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='compareSemanticVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareSemanticVersion", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareSemanticVersion (string thisVersion, string thatVersion)
		{
			const string __id = "compareSemanticVersion.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_thisVersion = JNIEnv.NewString (thisVersion);
			IntPtr native_thatVersion = JNIEnv.NewString (thatVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_thisVersion);
				__args [1] = new JniArgumentValue (native_thatVersion);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_thisVersion);
				JNIEnv.DeleteLocalRef (native_thatVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='convertSetToString' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertSetToString", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ConvertSetToString (global::System.Collections.Generic.ICollection<string> inputSet, string delimiter)
		{
			const string __id = "convertSetToString.(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_inputSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (inputSet);
			IntPtr native_delimiter = JNIEnv.NewString (delimiter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputSet);
				__args [1] = new JniArgumentValue (native_delimiter);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputSet);
				JNIEnv.DeleteLocalRef (native_delimiter);
				global::System.GC.KeepAlive (inputSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='countMatches' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("countMatches", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CountMatches (string str, string subString)
		{
			const string __id = "countMatches.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_subString = JNIEnv.NewString (subString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_str);
				__args [1] = new JniArgumentValue (native_subString);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_subString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='equalsIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("equalsIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool EqualsIgnoreCase (string one, string two)
		{
			const string __id = "equalsIgnoreCase.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_one = JNIEnv.NewString (one);
			IntPtr native_two = JNIEnv.NewString (two);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_one);
				__args [1] = new JniArgumentValue (native_two);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_one);
				JNIEnv.DeleteLocalRef (native_two);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='equalsIgnoreCaseTrim' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("equalsIgnoreCaseTrim", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool EqualsIgnoreCaseTrim (string one, string two)
		{
			const string __id = "equalsIgnoreCaseTrim.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_one = JNIEnv.NewString (one);
			IntPtr native_two = JNIEnv.NewString (two);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_one);
				__args [1] = new JniArgumentValue (native_two);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_one);
				JNIEnv.DeleteLocalRef (native_two);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='getTenantInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTenantInfo", "(Ljava/lang/String;)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair GetTenantInfo (string homeAccountId)
		{
			const string __id = "getTenantInfo.(Ljava/lang/String;)Landroid/util/Pair;";
			IntPtr native_homeAccountId = JNIEnv.NewString (homeAccountId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_homeAccountId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_homeAccountId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmpty (string message)
		{
			const string __id = "isEmpty.(Ljava/lang/String;)Z";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='isFirstVersionLargerOrEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isFirstVersionLargerOrEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFirstVersionLargerOrEqual (string first, string second)
		{
			const string __id = "isFirstVersionLargerOrEqual.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_first = JNIEnv.NewString (first);
			IntPtr native_second = JNIEnv.NewString (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_first);
				__args [1] = new JniArgumentValue (native_second);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_first);
				JNIEnv.DeleteLocalRef (native_second);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='isFirstVersionSmallerOrEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isFirstVersionSmallerOrEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFirstVersionSmallerOrEqual (string first, string second)
		{
			const string __id = "isFirstVersionSmallerOrEqual.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_first = JNIEnv.NewString (first);
			IntPtr native_second = JNIEnv.NewString (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_first);
				__args [1] = new JniArgumentValue (native_second);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_first);
				JNIEnv.DeleteLocalRef (native_second);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='isUuid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUuid", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsUuid (string inputString)
		{
			const string __id = "isUuid.(Ljava/lang/String;)Z";
			IntPtr native_inputString = JNIEnv.NewString (inputString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputString);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.util']/class[@name='StringUtil']/method[@name='join' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("join", "(CLjava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string Join (char delimiter, global::System.Collections.Generic.IList<string> toJoin)
		{
			const string __id = "join.(CLjava/util/List;)Ljava/lang/String;";
			IntPtr native_toJoin = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (toJoin);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (delimiter);
				__args [1] = new JniArgumentValue (native_toJoin);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_toJoin);
				global::System.GC.KeepAlive (toJoin);
			}
		}

	}
}
