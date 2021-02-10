using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/Telemetry", DoNotGenerateAcw=true)]
	public partial class Telemetry : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry.Builder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/telemetry/Telemetry$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/Telemetry$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry.Builder']/constructor[@name='Telemetry.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/telemetry/Telemetry;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/telemetry/Telemetry;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_defaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_;
#pragma warning disable 0169
			static Delegate GetDefaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_Handler ()
			{
				if (cb_defaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_ == null)
					cb_defaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DefaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_);
				return cb_defaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_;
			}

			static IntPtr n_DefaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var configuration = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration> (native_configuration, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefaultConfiguration (configuration));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry.Builder']/method[@name='defaultConfiguration' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.TelemetryConfiguration']]"
			[Register ("defaultConfiguration", "(Lcom/microsoft/identity/common/internal/telemetry/TelemetryConfiguration;)Lcom/microsoft/identity/common/internal/telemetry/Telemetry$Builder;", "GetDefaultConfiguration_Lcom_microsoft_identity_common_internal_telemetry_TelemetryConfiguration_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder DefaultConfiguration (global::Com.Microsoft.Identity.Common.Internal.Telemetry.TelemetryConfiguration configuration)
			{
				const string __id = "defaultConfiguration.(Lcom/microsoft/identity/common/internal/telemetry/TelemetryConfiguration;)Lcom/microsoft/identity/common/internal/telemetry/Telemetry$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (configuration);
				}
			}

			static Delegate cb_withContext_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetWithContext_Landroid_content_Context_Handler ()
			{
				if (cb_withContext_Landroid_content_Context_ == null)
					cb_withContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithContext_Landroid_content_Context_);
				return cb_withContext_Landroid_content_Context_;
			}

			static IntPtr n_WithContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithContext (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry.Builder']/method[@name='withContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("withContext", "(Landroid/content/Context;)Lcom/microsoft/identity/common/internal/telemetry/Telemetry$Builder;", "GetWithContext_Landroid_content_Context_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder WithContext (global::Android.Content.Context context)
			{
				const string __id = "withContext.(Landroid/content/Context;)Lcom/microsoft/identity/common/internal/telemetry/Telemetry$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/telemetry/Telemetry", typeof (Telemetry));

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

		protected Telemetry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/microsoft/identity/common/internal/telemetry/Telemetry;", "")]
			get {
				const string __id = "getInstance.()Lcom/microsoft/identity/common/internal/telemetry/Telemetry;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObservers;
#pragma warning disable 0169
		static Delegate GetGetObserversHandler ()
		{
			if (cb_getObservers == null)
				cb_getObservers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObservers);
			return cb_getObservers;
		}

		static IntPtr n_GetObservers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver>.ToLocalJniHandle (__this.Observers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver> Observers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='getObservers' and count(parameter)=0]"
			[Register ("getObservers", "()Ljava/util/List;", "GetGetObserversHandler")]
			get {
				const string __id = "getObservers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_;
#pragma warning disable 0169
		static Delegate GetAddObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_Handler ()
		{
			if (cb_addObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_ == null)
				cb_addObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_);
			return cb_addObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_;
		}

		static void n_AddObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var observer = (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.AddObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='addObserver' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.observers.ITelemetryObserver']]"
		[Register ("addObserver", "(Lcom/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver;)V", "GetAddObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_Handler")]
		public virtual unsafe void AddObserver (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver observer)
		{
			const string __id = "addObserver.(Lcom/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='emit' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.events.BaseEvent']]"
		[Register ("emit", "(Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;)V", "")]
		public static unsafe void Emit (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Events.BaseEvent e)
		{
			const string __id = "emit.(Lcom/microsoft/identity/common/internal/telemetry/events/BaseEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flush_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFlush_Ljava_lang_String_Handler ()
		{
			if (cb_flush_Ljava_lang_String_ == null)
				cb_flush_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Flush_Ljava_lang_String_);
			return cb_flush_Ljava_lang_String_;
		}

		static void n_Flush_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_correlationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var correlationId = JNIEnv.GetString (native_correlationId, JniHandleOwnership.DoNotTransfer);
			__this.Flush (correlationId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='flush' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("flush", "(Ljava/lang/String;)V", "GetFlush_Ljava_lang_String_Handler")]
		public virtual unsafe void Flush (string correlationId)
		{
			const string __id = "flush.(Ljava/lang/String;)V";
			IntPtr native_correlationId = JNIEnv.NewString (correlationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_correlationId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_correlationId);
			}
		}

		static Delegate cb_removeObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_;
#pragma warning disable 0169
		static Delegate GetRemoveObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_Handler ()
		{
			if (cb_removeObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_ == null)
				cb_removeObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_);
			return cb_removeObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_;
		}

		static void n_RemoveObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var observer = (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver)global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.RemoveObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='removeObserver' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.observers.ITelemetryObserver']]"
		[Register ("removeObserver", "(Lcom/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver;)V", "GetRemoveObserver_Lcom_microsoft_identity_common_internal_telemetry_observers_ITelemetryObserver_Handler")]
		public virtual unsafe void RemoveObserver (global::Com.Microsoft.Identity.Common.Internal.Telemetry.Observers.ITelemetryObserver observer)
		{
			const string __id = "removeObserver.(Lcom/microsoft/identity/common/internal/telemetry/observers/ITelemetryObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		static Delegate cb_removeObserver_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRemoveObserver_Ljava_lang_Class_Handler ()
		{
			if (cb_removeObserver_Ljava_lang_Class_ == null)
				cb_removeObserver_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveObserver_Ljava_lang_Class_);
			return cb_removeObserver_Ljava_lang_Class_;
		}

		static void n_RemoveObserver_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cls)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Telemetry.Telemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cls = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_cls, JniHandleOwnership.DoNotTransfer);
			__this.RemoveObserver (cls);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.telemetry']/class[@name='Telemetry']/method[@name='removeObserver' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("removeObserver", "(Ljava/lang/Class;)V", "GetRemoveObserver_Ljava_lang_Class_Handler")]
		public virtual unsafe void RemoveObserver (global::Java.Lang.Class cls)
		{
			const string __id = "removeObserver.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cls);
			}
		}

	}
}
