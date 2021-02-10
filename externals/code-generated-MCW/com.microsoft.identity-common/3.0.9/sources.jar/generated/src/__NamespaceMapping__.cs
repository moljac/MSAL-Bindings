using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.aad.adal", Managed="Com.Microsoft.Aad.Adal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.client", Managed="Com.Microsoft.Identity.Client")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common", Managed="Com.Microsoft.Identity.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.adal.internal", Managed="Com.Microsoft.Identity.Common.Adal.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.adal.internal.cache", Managed="Com.Microsoft.Identity.Common.Adal.Internal.Cache")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.adal.internal.net", Managed="Com.Microsoft.Identity.Common.Adal.Internal.Net")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.adal.internal.tokensharing", Managed="Com.Microsoft.Identity.Common.Adal.Internal.Tokensharing")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.adal.internal.util", Managed="Com.Microsoft.Identity.Common.Adal.Internal.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.exception", Managed="Com.Microsoft.Identity.Common.Exception")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.authorities", Managed="Com.Microsoft.Identity.Common.Internal.Authorities")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.authscheme", Managed="Com.Microsoft.Identity.Common.Internal.Authscheme")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.broker", Managed="Com.Microsoft.Identity.Common.Internal.Broker")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.broker.ipc", Managed="Com.Microsoft.Identity.Common.Internal.Broker.Ipc")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.cache", Managed="Com.Microsoft.Identity.Common.Internal.Cache")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.cache.registry", Managed="Com.Microsoft.Identity.Common.Internal.Cache.Registry")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.commands", Managed="Com.Microsoft.Identity.Common.Internal.Commands")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.commands.parameters", Managed="Com.Microsoft.Identity.Common.Internal.Commands.Parameters")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.controllers", Managed="Com.Microsoft.Identity.Common.Internal.Controllers")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.dto", Managed="Com.Microsoft.Identity.Common.Internal.Dto")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.eststelemetry", Managed="Com.Microsoft.Identity.Common.Internal.Eststelemetry")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.logging", Managed="Com.Microsoft.Identity.Common.Internal.Logging")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.migration", Managed="Com.Microsoft.Identity.Common.Internal.Migration")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.net.cache", Managed="Com.Microsoft.Identity.Common.Internal.Net.Cache")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.providers.keys", Managed="Com.Microsoft.Identity.Common.Internal.Providers.Keys")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.providers.oauth2", Managed="Com.Microsoft.Identity.Common.Internal.Providers.Oauth2")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.request", Managed="Com.Microsoft.Identity.Common.Internal.Request")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.result", Managed="Com.Microsoft.Identity.Common.Internal.Result")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.telemetry", Managed="Com.Microsoft.Identity.Common.Internal.Telemetry")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.telemetry.adapter", Managed="Com.Microsoft.Identity.Common.Internal.Telemetry.Adapter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.telemetry.events", Managed="Com.Microsoft.Identity.Common.Internal.Telemetry.Events")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.telemetry.observers", Managed="Com.Microsoft.Identity.Common.Internal.Telemetry.Observers")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.telemetry.rules", Managed="Com.Microsoft.Identity.Common.Internal.Telemetry.Rules")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.ui", Managed="Com.Microsoft.Identity.Common.Internal.UI")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.ui.browser", Managed="Com.Microsoft.Identity.Common.Internal.UI.Browser")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.ui.webview", Managed="Com.Microsoft.Identity.Common.Internal.UI.Webview")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.ui.webview.challengehandlers", Managed="Com.Microsoft.Identity.Common.Internal.UI.Webview.Challengehandlers")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.microsoft.identity.common.internal.util", Managed="Com.Microsoft.Identity.Common.Internal.Util")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPII_L (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPIIL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate bool _JniMarshal_PPIL_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPILL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPILLI_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPJL_L (IntPtr jnienv, IntPtr klass, long p0, IntPtr p1);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate long _JniMarshal_PPL_J (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate IntPtr _JniMarshal_PPLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6);
delegate IntPtr _JniMarshal_PPLLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, IntPtr p7);
delegate void _JniMarshal_PPLLLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, bool p3);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate bool _JniMarshal_PPZ_Z (IntPtr jnienv, IntPtr klass, bool p0);
