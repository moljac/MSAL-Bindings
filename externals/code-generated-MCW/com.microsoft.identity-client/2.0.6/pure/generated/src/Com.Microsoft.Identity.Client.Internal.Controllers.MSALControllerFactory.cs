using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Client.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MSALControllerFactory']"
	[global::Android.Runtime.Register ("com/microsoft/identity/client/internal/controllers/MSALControllerFactory", DoNotGenerateAcw=true)]
	public partial class MSALControllerFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/client/internal/controllers/MSALControllerFactory", typeof (MSALControllerFactory));

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

		protected MSALControllerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MSALControllerFactory']/constructor[@name='MSALControllerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MSALControllerFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MSALControllerFactory']/method[@name='brokerEligible' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.microsoft.identity.common.internal.authorities.Authority'] and parameter[3][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration']]"
		[Register ("brokerEligible", "(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)Z", "")]
		public static unsafe bool BrokerEligible (global::Android.Content.Context applicationContext, global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority authority, global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration applicationConfiguration)
		{
			const string __id = "brokerEligible.(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				__args [1] = new JniArgumentValue ((authority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authority).Handle);
				__args [2] = new JniArgumentValue ((applicationConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationConfiguration).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (applicationContext);
				global::System.GC.KeepAlive (authority);
				global::System.GC.KeepAlive (applicationConfiguration);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MSALControllerFactory']/method[@name='brokerInstalled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("brokerInstalled", "(Landroid/content/Context;)Z", "")]
		protected static unsafe bool BrokerInstalled (global::Android.Content.Context applicationContext)
		{
			const string __id = "brokerInstalled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (applicationContext);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MSALControllerFactory']/method[@name='getAllControllers' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.microsoft.identity.common.internal.authorities.Authority'] and parameter[3][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration']]"
		[Register ("getAllControllers", "(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> GetAllControllers (global::Android.Content.Context applicationContext, global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority authority, global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration applicationConfiguration)
		{
			const string __id = "getAllControllers.(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				__args [1] = new JniArgumentValue ((authority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authority).Handle);
				__args [2] = new JniArgumentValue ((applicationConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationConfiguration).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (applicationContext);
				global::System.GC.KeepAlive (authority);
				global::System.GC.KeepAlive (applicationConfiguration);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.client.internal.controllers']/class[@name='MSALControllerFactory']/method[@name='getDefaultController' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.microsoft.identity.common.internal.authorities.Authority'] and parameter[3][@type='com.microsoft.identity.client.PublicClientApplicationConfiguration']]"
		[Register ("getDefaultController", "(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)Lcom/microsoft/identity/common/internal/controllers/BaseController;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController GetDefaultController (global::Android.Content.Context applicationContext, global::Com.Microsoft.Identity.Common.Internal.Authorities.Authority authority, global::Com.Microsoft.Identity.Client.PublicClientApplicationConfiguration applicationConfiguration)
		{
			const string __id = "getDefaultController.(Landroid/content/Context;Lcom/microsoft/identity/common/internal/authorities/Authority;Lcom/microsoft/identity/client/PublicClientApplicationConfiguration;)Lcom/microsoft/identity/common/internal/controllers/BaseController;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				__args [1] = new JniArgumentValue ((authority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authority).Handle);
				__args [2] = new JniArgumentValue ((applicationConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationConfiguration).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Controllers.BaseController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (applicationContext);
				global::System.GC.KeepAlive (authority);
				global::System.GC.KeepAlive (applicationConfiguration);
			}
		}

	}
}
