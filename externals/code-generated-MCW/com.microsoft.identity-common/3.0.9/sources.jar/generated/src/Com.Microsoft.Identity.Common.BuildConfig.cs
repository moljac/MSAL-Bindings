using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/BuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class BuildConfig : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='AZURE_AUTHENTICATOR_APP_SIGNATURE']"
		[Register ("AZURE_AUTHENTICATOR_APP_SIGNATURE")]
		public const string AzureAuthenticatorAppSignature = (string) "ho040S3ffZkmxqtQrSwpTVOn9r0=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='AZURE_AUTHENTICATOR_PROD_APP_SIGNATURE']"
		[Register ("AZURE_AUTHENTICATOR_PROD_APP_SIGNATURE")]
		public const string AzureAuthenticatorProdAppSignature = (string) "ho040S3ffZkmxqtQrSwpTVOn9r0=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='BUILD_TYPE']"
		[Register ("BUILD_TYPE")]
		public const string BuildType = (string) "release";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='COMPANY_PORTAL_APP_PACKAGE_NAME']"
		[Register ("COMPANY_PORTAL_APP_PACKAGE_NAME")]
		public const string CompanyPortalAppPackageName = (string) "com.microsoft.windowsintune.companyportal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='COMPANY_PORTAL_APP_SIGNATURE']"
		[Register ("COMPANY_PORTAL_APP_SIGNATURE")]
		public const string CompanyPortalAppSignature = (string) "1L4Z9FJCgn5c0VLhyAxC5O9LdlE=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='COMPANY_PORTAL_PROD_APP_PACKAGE_NAME']"
		[Register ("COMPANY_PORTAL_PROD_APP_PACKAGE_NAME")]
		public const string CompanyPortalProdAppPackageName = (string) "com.microsoft.windowsintune.companyportal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='COMPANY_PORTAL_PROD_APP_SIGNATURE']"
		[Register ("COMPANY_PORTAL_PROD_APP_SIGNATURE")]
		public const string CompanyPortalProdAppSignature = (string) "1L4Z9FJCgn5c0VLhyAxC5O9LdlE=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='DC']"
		[Register ("DC")]
		public const string Dc = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const bool Debug = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='LIBRARY_PACKAGE_NAME']"
		[Register ("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = (string) "com.microsoft.identity.common";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/field[@name='SLICE']"
		[Register ("SLICE")]
		public const string Slice = (string) "";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/BuildConfig", typeof (BuildConfig));

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

		internal BuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microsoft.identity.common']/class[@name='BuildConfig']/constructor[@name='BuildConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
