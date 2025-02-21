// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Dashboard.V20210901Preview.Outputs
{

    /// <summary>
    /// Properties specific to the grafana resource.
    /// </summary>
    [OutputType]
    public sealed class ManagedGrafanaPropertiesResponse
    {
        public readonly string? AutoGeneratedDomainNameLabelScope;
        /// <summary>
        /// The endpoint of the Grafana instance.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// The Grafana software version.
        /// </summary>
        public readonly string GrafanaVersion;
        /// <summary>
        /// Provisioning state of the resource.
        /// </summary>
        public readonly string? ProvisioningState;
        public readonly string? ZoneRedundancy;

        [OutputConstructor]
        private ManagedGrafanaPropertiesResponse(
            string? autoGeneratedDomainNameLabelScope,

            string endpoint,

            string grafanaVersion,

            string? provisioningState,

            string? zoneRedundancy)
        {
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            Endpoint = endpoint;
            GrafanaVersion = grafanaVersion;
            ProvisioningState = provisioningState;
            ZoneRedundancy = zoneRedundancy;
        }
    }
}
