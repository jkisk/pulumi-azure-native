// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20210301.Outputs
{

    [OutputType]
    public sealed class ManagedClusterPodIdentityProfileResponse
    {
        /// <summary>
        /// Customer consent for enabling AAD pod identity addon in cluster using Kubenet network plugin.
        /// </summary>
        public readonly bool? AllowNetworkPluginKubenet;
        /// <summary>
        /// Whether the pod identity addon is enabled.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// User assigned pod identity settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ManagedClusterPodIdentityResponse> UserAssignedIdentities;
        /// <summary>
        /// User assigned pod identity exception settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ManagedClusterPodIdentityExceptionResponse> UserAssignedIdentityExceptions;

        [OutputConstructor]
        private ManagedClusterPodIdentityProfileResponse(
            bool? allowNetworkPluginKubenet,

            bool? enabled,

            ImmutableArray<Outputs.ManagedClusterPodIdentityResponse> userAssignedIdentities,

            ImmutableArray<Outputs.ManagedClusterPodIdentityExceptionResponse> userAssignedIdentityExceptions)
        {
            AllowNetworkPluginKubenet = allowNetworkPluginKubenet;
            Enabled = enabled;
            UserAssignedIdentities = userAssignedIdentities;
            UserAssignedIdentityExceptions = userAssignedIdentityExceptions;
        }
    }
}
