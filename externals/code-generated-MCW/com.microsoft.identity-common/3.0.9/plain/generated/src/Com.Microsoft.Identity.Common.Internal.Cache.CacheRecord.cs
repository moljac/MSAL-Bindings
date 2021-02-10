using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Microsoft.Identity.Common.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']"
	[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/CacheRecord", DoNotGenerateAcw=true)]
	public sealed partial class CacheRecord : global::Java.Lang.Object, global::Com.Microsoft.Identity.Common.Internal.Cache.ICacheRecord {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']"
		[global::Android.Runtime.Register ("com/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder", DoNotGenerateAcw=true)]
		public partial class CacheRecordBuilder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder", typeof (CacheRecordBuilder));

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

			protected CacheRecordBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/microsoft/identity/common/internal/cache/CacheRecord;", "GetBuildHandler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord Build ()
			{
				const string __id = "build.()Lcom/microsoft/identity/common/internal/cache/CacheRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_mAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_;
#pragma warning disable 0169
			static Delegate GetMAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_Handler ()
			{
				if (cb_mAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_ == null)
					cb_mAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_);
				return cb_mAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_;
			}

			static IntPtr n_MAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mAccessToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mAccessToken = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (native_mAccessToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MAccessToken (mAccessToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']/method[@name='mAccessToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccessTokenRecord']]"
			[Register ("mAccessToken", "(Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;", "GetMAccessToken_Lcom_microsoft_identity_common_internal_dto_AccessTokenRecord_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder MAccessToken (global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord mAccessToken)
			{
				const string __id = "mAccessToken.(Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mAccessToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mAccessToken).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (mAccessToken);
				}
			}

			static Delegate cb_mAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
#pragma warning disable 0169
			static Delegate GetMAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler ()
			{
				if (cb_mAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ == null)
					cb_mAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_);
				return cb_mAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_;
			}

			static IntPtr n_MAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var account = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (native_account, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MAccount (account));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']/method[@name='mAccount' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.AccountRecord']]"
			[Register ("mAccount", "(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;", "GetMAccount_Lcom_microsoft_identity_common_internal_dto_AccountRecord_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder MAccount (global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord account)
			{
				const string __id = "mAccount.(Lcom/microsoft/identity/common/internal/dto/AccountRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((account == null) ? IntPtr.Zero : ((global::Java.Lang.Object) account).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (account);
				}
			}

			static Delegate cb_mIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_;
#pragma warning disable 0169
			static Delegate GetMIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler ()
			{
				if (cb_mIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ == null)
					cb_mIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_);
				return cb_mIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_;
			}

			static IntPtr n_MIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mIdToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mIdToken = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (native_mIdToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MIdToken (mIdToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']/method[@name='mIdToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.IdTokenRecord']]"
			[Register ("mIdToken", "(Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;", "GetMIdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder MIdToken (global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord mIdToken)
			{
				const string __id = "mIdToken.(Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mIdToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mIdToken).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (mIdToken);
				}
			}

			static Delegate cb_mRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_;
#pragma warning disable 0169
			static Delegate GetMRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Handler ()
			{
				if (cb_mRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_ == null)
					cb_mRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_);
				return cb_mRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_;
			}

			static IntPtr n_MRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mRefreshToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mRefreshToken = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (native_mRefreshToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MRefreshToken (mRefreshToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']/method[@name='mRefreshToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.RefreshTokenRecord']]"
			[Register ("mRefreshToken", "(Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;", "GetMRefreshToken_Lcom_microsoft_identity_common_internal_dto_RefreshTokenRecord_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder MRefreshToken (global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord mRefreshToken)
			{
				const string __id = "mRefreshToken.(Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mRefreshToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mRefreshToken).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (mRefreshToken);
				}
			}

			static Delegate cb_mV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_;
#pragma warning disable 0169
			static Delegate GetMV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler ()
			{
				if (cb_mV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ == null)
					cb_mV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_);
				return cb_mV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_;
			}

			static IntPtr n_MV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mV1IdToken)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mV1IdToken = global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (native_mV1IdToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MV1IdToken (mV1IdToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord.CacheRecordBuilder']/method[@name='mV1IdToken' and count(parameter)=1 and parameter[1][@type='com.microsoft.identity.common.internal.dto.IdTokenRecord']]"
			[Register ("mV1IdToken", "(Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;", "GetMV1IdToken_Lcom_microsoft_identity_common_internal_dto_IdTokenRecord_Handler")]
			public virtual unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder MV1IdToken (global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord mV1IdToken)
			{
				const string __id = "mV1IdToken.(Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;)Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mV1IdToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mV1IdToken).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (mV1IdToken);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/microsoft/identity/common/internal/cache/CacheRecord", typeof (CacheRecord));

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

		internal CacheRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;", "")]
			get {
				const string __id = "getAccessToken.()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "")]
			get {
				const string __id = "getAccount.()Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "")]
			get {
				const string __id = "getIdToken.()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord MAccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getMAccessToken' and count(parameter)=0]"
			[Register ("getMAccessToken", "()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;", "")]
			get {
				const string __id = "getMAccessToken.()Lcom/microsoft/identity/common/internal/dto/AccessTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccessTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord MAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getMAccount' and count(parameter)=0]"
			[Register ("getMAccount", "()Lcom/microsoft/identity/common/internal/dto/AccountRecord;", "")]
			get {
				const string __id = "getMAccount.()Lcom/microsoft/identity/common/internal/dto/AccountRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.AccountRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord MIdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getMIdToken' and count(parameter)=0]"
			[Register ("getMIdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "")]
			get {
				const string __id = "getMIdToken.()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord MRefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getMRefreshToken' and count(parameter)=0]"
			[Register ("getMRefreshToken", "()Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;", "")]
			get {
				const string __id = "getMRefreshToken.()Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord MV1IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getMV1IdToken' and count(parameter)=0]"
			[Register ("getMV1IdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "")]
			get {
				const string __id = "getMV1IdToken.()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;", "")]
			get {
				const string __id = "getRefreshToken.()Lcom/microsoft/identity/common/internal/dto/RefreshTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.RefreshTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord V1IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='getV1IdToken' and count(parameter)=0]"
			[Register ("getV1IdToken", "()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;", "")]
			get {
				const string __id = "getV1IdToken.()Lcom/microsoft/identity/common/internal/dto/IdTokenRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Dto.IdTokenRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microsoft.identity.common.internal.cache']/class[@name='CacheRecord']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;", "")]
		public static unsafe global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder Builder ()
		{
			const string __id = "builder.()Lcom/microsoft/identity/common/internal/cache/CacheRecord$CacheRecordBuilder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Microsoft.Identity.Common.Internal.Cache.CacheRecord.CacheRecordBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
