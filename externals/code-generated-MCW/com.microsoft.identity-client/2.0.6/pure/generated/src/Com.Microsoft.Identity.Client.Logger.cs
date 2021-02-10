using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/Logger", DoNotGenerateAcw=true)]
	public sealed partial class Logger : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']"
		[global::Android.Runtime.Register ("com/microsoft/identity/client/Logger$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Microsoft.Identity.Client.Logger.LogLevel Error {
				get {
					const string __id = "ERROR.Lcom/microsoft/identity/client/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Microsoft.Identity.Client.Logger.LogLevel Info {
				get {
					const string __id = "INFO.Lcom/microsoft/identity/client/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.Microsoft.Identity.Client.Logger.LogLevel Verbose {
				get {
					const string __id = "VERBOSE.Lcom/microsoft/identity/client/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']/field[@name='WARNING']"
			[Register ("WARNING")]
			public static global::Com.Microsoft.Identity.Client.Logger.LogLevel Warning {
				get {
					const string __id = "WARNING.Lcom/microsoft/identity/client/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/Logger$LogLevel", typeof (LogLevel));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/client/Logger$LogLevel;", "")]
			public static unsafe global::Com.Microsoft.Identity.Client.Logger.LogLevel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/client/Logger$LogLevel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microsoft/identity/client/Logger$LogLevel;", "")]
			public static unsafe global::Com.Microsoft.Identity.Client.Logger.LogLevel[] Values ()
			{
				const string __id = "values.()[Lcom/microsoft/identity/client/Logger$LogLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Microsoft.Identity.Client.Logger.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Client.Logger.LogLevel));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/Logger", typeof (Logger));

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
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

		public static unsafe global::Com.Microsoft.Identity.Client.Logger Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/client/Logger;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/client/Logger;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Client.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']/method[@name='setEnableLogcatLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableLogcatLog", "(Z)V", "")]
		public unsafe void SetEnableLogcatLog (bool enableLogcatLog)
		{
			const string __id = "setEnableLogcatLog.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableLogcatLog);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']/method[@name='setEnablePII' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnablePII", "(Z)V", "")]
		public unsafe void SetEnablePII (bool enablePII)
		{
			const string __id = "setEnablePII.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enablePII);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']/method[@name='setExternalLogger' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.ILoggerCallback']]"
		[Register ("setExternalLogger", "(Lcom/microsoft/identity/client/ILoggerCallback;)V", "")]
		public unsafe void SetExternalLogger (global::Com.Microsoft.Identity.Client.ILoggerCallback externalLogger)
		{
			const string __id = "setExternalLogger.(Lcom/microsoft/identity/client/ILoggerCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((externalLogger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) externalLogger).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (externalLogger);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client']/class[@name='Logger']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.client.Logger.LogLevel']]"
		[Register ("setLogLevel", "(Lcom/microsoft/identity/client/Logger$LogLevel;)V", "")]
		public unsafe void SetLogLevel (global::Com.Microsoft.Identity.Client.Logger.LogLevel logLevel)
		{
			const string __id = "setLogLevel.(Lcom/microsoft/identity/client/Logger$LogLevel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (logLevel);
			}
		}

	}
}
