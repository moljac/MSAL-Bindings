using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/microsoft/aad/adal",
						"com/microsoft/identity/client",
						"com/microsoft/identity/common/adal/internal/tokensharing",
						"com/microsoft/identity/common/internal/broker/ipc",
					},
					new Converter<string, Type>[]{
						lookup_com_microsoft_aad_adal_package,
						lookup_com_microsoft_identity_client_package,
						lookup_com_microsoft_identity_common_adal_internal_tokensharing_package,
						lookup_com_microsoft_identity_common_internal_broker_ipc_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_microsoft_aad_adal_mappings;
		static Type lookup_com_microsoft_aad_adal_package (string klass)
		{
			if (package_com_microsoft_aad_adal_mappings == null) {
				package_com_microsoft_aad_adal_mappings = new string[]{
					"com/microsoft/aad/adal/IBrokerAccountService$Default:Com.Microsoft.Aad.Adal.BrokerAccountServiceDefault",
					"com/microsoft/aad/adal/IBrokerAccountService$Stub:Com.Microsoft.Aad.Adal.BrokerAccountServiceStub",
				};
			}

			return Lookup (package_com_microsoft_aad_adal_mappings, klass);
		}

		static string[] package_com_microsoft_identity_client_mappings;
		static Type lookup_com_microsoft_identity_client_package (string klass)
		{
			if (package_com_microsoft_identity_client_mappings == null) {
				package_com_microsoft_identity_client_mappings = new string[]{
					"com/microsoft/identity/client/IMicrosoftAuthService$Default:Com.Microsoft.Identity.Client.MicrosoftAuthServiceDefault",
					"com/microsoft/identity/client/IMicrosoftAuthService$Stub:Com.Microsoft.Identity.Client.MicrosoftAuthServiceStub",
				};
			}

			return Lookup (package_com_microsoft_identity_client_mappings, klass);
		}

		static string[] package_com_microsoft_identity_common_adal_internal_tokensharing_mappings;
		static Type lookup_com_microsoft_identity_common_adal_internal_tokensharing_package (string klass)
		{
			if (package_com_microsoft_identity_common_adal_internal_tokensharing_mappings == null) {
				package_com_microsoft_identity_common_adal_internal_tokensharing_mappings = new string[]{
					"com/microsoft/identity/common/adal/internal/tokensharing/ITokenShareResultInternal$TokenShareExportFormatInternal:Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing.TokenShareResultInternalTokenShareExportFormatInternal",
				};
			}

			return Lookup (package_com_microsoft_identity_common_adal_internal_tokensharing_mappings, klass);
		}

		static string[] package_com_microsoft_identity_common_internal_broker_ipc_mappings;
		static Type lookup_com_microsoft_identity_common_internal_broker_ipc_package (string klass)
		{
			if (package_com_microsoft_identity_common_internal_broker_ipc_mappings == null) {
				package_com_microsoft_identity_common_internal_broker_ipc_mappings = new string[]{
					"com/microsoft/identity/common/internal/broker/ipc/IIpcStrategy$Type:Com.Microsoft.Identity.Common.Internal.Broker.Ipc.IpcStrategyType",
				};
			}

			return Lookup (package_com_microsoft_identity_common_internal_broker_ipc_mappings, klass);
		}
	}
}
