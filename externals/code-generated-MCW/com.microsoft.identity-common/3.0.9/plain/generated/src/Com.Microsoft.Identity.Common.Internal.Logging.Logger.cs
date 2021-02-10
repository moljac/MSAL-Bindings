using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/logging/Logger", DoNotGenerateAcw=true)]
	public sealed partial class Logger : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/logging/Logger$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel Error {
				get {
					const string __id = "ERROR.Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel Info {
				get {
					const string __id = "INFO.Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel Verbose {
				get {
					const string __id = "VERBOSE.Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']/field[@name='WARN']"
			[Register ("WARN")]
			public static global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel Warn {
				get {
					const string __id = "WARN.Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/logging/Logger$LogLevel", typeof (LogLevel));

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

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;", "")]
			public static unsafe global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/logging/Logger", typeof (Logger));

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

		internal Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logger () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe bool AllowLogcat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='getAllowLogcat' and count(parameter)=0]"
			[Register ("getAllowLogcat", "()Z", "")]
			get {
				const string __id = "getAllowLogcat.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='setAllowLogcat' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowLogcat", "(Z)V", "")]
			set {
				const string __id = "setAllowLogcat.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool AllowPii {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='getAllowPii' and count(parameter)=0]"
			[Register ("getAllowPii", "()Z", "")]
			get {
				const string __id = "getAllowPii.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='setAllowPii' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowPii", "(Z)V", "")]
			set {
				const string __id = "setAllowPii.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Logging.Logger Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/internal/logging/Logger;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/internal/logging/Logger;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Logging.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='error' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Error (string tag, string correlationID, string errorMessage, global::Java.Lang.Throwable exception)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_errorMessage);
				__args [3] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (exception);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Error (string tag, string errorMessage, global::Java.Lang.Throwable exception)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (exception);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='errorPII' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
		[Register ("errorPII", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void ErrorPII (string tag, string correlationID, string errorMessage, global::Java.Lang.Throwable exception)
		{
			const string __id = "errorPII.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_errorMessage);
				__args [3] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (exception);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='errorPII' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("errorPII", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void ErrorPII (string tag, string errorMessage, global::Java.Lang.Throwable exception)
		{
			const string __id = "errorPII.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (exception);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Info (string tag, string message)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Info (string tag, string correlationID, string message)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='infoPII' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("infoPII", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void InfoPII (string tag, string message)
		{
			const string __id = "infoPII.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='infoPII' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("infoPII", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void InfoPII (string tag, string correlationID, string message)
		{
			const string __id = "infoPII.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='setExternalLogger' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.logging.ILoggerCallback']]"
		[Register ("setExternalLogger", "(Lcom/microsoft/identity/common/internal/logging/ILoggerCallback;)V", "")]
		public unsafe void SetExternalLogger (global::Com.Microsoft.Identity.Common.Internal.Logging.ILoggerCallback externalLogger)
		{
			const string __id = "setExternalLogger.(Lcom/microsoft/identity/common/internal/logging/ILoggerCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((externalLogger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) externalLogger).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (externalLogger);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.logging.Logger.LogLevel']]"
		[Register ("setLogLevel", "(Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;)V", "")]
		public unsafe void SetLogLevel (global::Com.Microsoft.Identity.Common.Internal.Logging.Logger.LogLevel logLevel)
		{
			const string __id = "setLogLevel.(Lcom/microsoft/identity/common/internal/logging/Logger$LogLevel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (logLevel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='verbose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("verbose", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Verbose (string tag, string message)
		{
			const string __id = "verbose.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='verbose' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("verbose", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Verbose (string tag, string correlationID, string message)
		{
			const string __id = "verbose.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='verbosePII' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("verbosePII", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void VerbosePII (string tag, string message)
		{
			const string __id = "verbosePII.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='verbosePII' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("verbosePII", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void VerbosePII (string tag, string correlationID, string message)
		{
			const string __id = "verbosePII.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Warn (string tag, string message)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Warn (string tag, string correlationID, string message)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='warnPII' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("warnPII", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void WarnPII (string tag, string message)
		{
			const string __id = "warnPII.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.logging']/class[@name='Logger']/method[@name='warnPII' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("warnPII", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void WarnPII (string tag, string correlationID, string message)
		{
			const string __id = "warnPII.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_correlationID = JNIEnv.NewString (correlationID);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_correlationID);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_correlationID);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
