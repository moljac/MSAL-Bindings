using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Controllers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/controllers/ExceptionAdapter", DoNotGenerateAcw=true)]
	public partial class ExceptionAdapter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/controllers/ExceptionAdapter", typeof (ExceptionAdapter));

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

		protected ExceptionAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']/constructor[@name='ExceptionAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']/method[@name='applyCliTelemInfo' and count(parameter)=2 and parameter[1][@type='com.microsoft.identity.common.internal.telemetry.CliTelemInfo'] and parameter[2][@type='com.microsoft.identity.common.exception.BaseException']]"
		[Register ("applyCliTelemInfo", "(Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;Lcom/microsoft/identity/common/exception/BaseException;)V", "")]
		public static unsafe void ApplyCliTelemInfo (global::Com.Microsoft.Identity.Common.Internal.Telemetry.CliTelemInfo cliTelemInfo, global::Com.Microsoft.Identity.Common.Exception.BaseException outErr)
		{
			const string __id = "applyCliTelemInfo.(Lcom/microsoft/identity/common/internal/telemetry/CliTelemInfo;Lcom/microsoft/identity/common/exception/BaseException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cliTelemInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cliTelemInfo).Handle);
				__args [1] = new JniArgumentValue ((outErr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) outErr).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (cliTelemInfo);
				global::System.GC.KeepAlive (outErr);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']/method[@name='baseExceptionFromException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("baseExceptionFromException", "(Ljava/lang/Throwable;)Lcom/microsoft/identity/common/exception/BaseException;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Exception.BaseException BaseExceptionFromException (global::Java.Lang.Throwable exception)
		{
			const string __id = "baseExceptionFromException.(Ljava/lang/Throwable;)Lcom/microsoft/identity/common/exception/BaseException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']/method[@name='exceptionFromAcquireTokenResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.result.AcquireTokenResult']]"
		[Register ("exceptionFromAcquireTokenResult", "(Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;)Lcom/microsoft/identity/common/exception/BaseException;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Exception.BaseException ExceptionFromAcquireTokenResult (global::Com.Microsoft.Identity.Common.Internal.Result.AcquireTokenResult result)
		{
			const string __id = "exceptionFromAcquireTokenResult.(Lcom/microsoft/identity/common/internal/result/AcquireTokenResult;)Lcom/microsoft/identity/common/exception/BaseException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.BaseException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (result);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']/method[@name='exceptionFromTokenResult' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenResult']]"
		[Register ("exceptionFromTokenResult", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;)Lcom/microsoft/identity/common/exception/ServiceException;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Exception.ServiceException ExceptionFromTokenResult (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenResult tokenResult)
		{
			const string __id = "exceptionFromTokenResult.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenResult;)Lcom/microsoft/identity/common/exception/ServiceException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tokenResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenResult).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tokenResult);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.controllers']/class[@name='ExceptionAdapter']/method[@name='getExceptionFromTokenErrorResponse' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.providers.oauth2.TokenErrorResponse']]"
		[Register ("getExceptionFromTokenErrorResponse", "(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;)Lcom/microsoft/identity/common/exception/ServiceException;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Exception.ServiceException GetExceptionFromTokenErrorResponse (global::Com.Microsoft.Identity.Common.Internal.Providers.Oauth2.TokenErrorResponse errorResponse)
		{
			const string __id = "getExceptionFromTokenErrorResponse.(Lcom/microsoft/identity/common/internal/providers/oauth2/TokenErrorResponse;)Lcom/microsoft/identity/common/exception/ServiceException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorResponse).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Exception.ServiceException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (errorResponse);
			}
		}

	}
}
