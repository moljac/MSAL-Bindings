using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Dto {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/dto/CredentialType", DoNotGenerateAcw=true)]
	public sealed partial class CredentialType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='AccessToken']"
		[Register ("AccessToken")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType AccessToken {
			get {
				const string __id = "AccessToken.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='AccessToken_With_AuthScheme']"
		[Register ("AccessToken_With_AuthScheme")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType AccessTokenWithAuthScheme {
			get {
				const string __id = "AccessToken_With_AuthScheme.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='Certificate']"
		[Register ("Certificate")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType Certificate {
			get {
				const string __id = "Certificate.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='Cookie']"
		[Register ("Cookie")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType Cookie {
			get {
				const string __id = "Cookie.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='ID_TOKEN_TYPES']"
		[Register ("ID_TOKEN_TYPES")]
		public static IList<Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> IdTokenTypes {
			get {
				const string __id = "ID_TOKEN_TYPES.[Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='IdToken']"
		[Register ("IdToken")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType IdToken {
			get {
				const string __id = "IdToken.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='Password']"
		[Register ("Password")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType Password {
			get {
				const string __id = "Password.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='RefreshToken']"
		[Register ("RefreshToken")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType RefreshToken {
			get {
				const string __id = "RefreshToken.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/field[@name='V1IdToken']"
		[Register ("V1IdToken")]
		public static global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType V1IdToken {
			get {
				const string __id = "V1IdToken.Lcom/microsoft/identity/common/internal/dto/CredentialType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/dto/CredentialType", typeof (CredentialType));

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

		internal CredentialType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/CredentialType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType FromString (string name)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/CredentialType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/CredentialType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/microsoft/identity/common/internal/dto/CredentialType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/method[@name='valueSet' and count(parameter)=0]"
		[Register ("valueSet", "()Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> ValueSet ()
		{
			const string __id = "valueSet.()Ljava/util/Set;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.dto']/class[@name='CredentialType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microsoft/identity/common/internal/dto/CredentialType;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType[] Values ()
		{
			const string __id = "values.()[Lcom/microsoft/identity/common/internal/dto/CredentialType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microsoft.Identity.Common.Internal.Dto.CredentialType));
			} finally {
			}
		}

	}
}
