// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20210301.Outputs
{

    [OutputType]
    public sealed class LoadBalancerFrontendIPConfigurationResponse
    {
        /// <summary>
        /// The name of the resource that is unique within the set of frontend IP configurations used by the load balancer. This name can be used to access the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Properties of load balancer frontend ip configuration.
        /// </summary>
        public readonly Outputs.LoadBalancerFrontendIPConfigurationPropertiesResponse Properties;

        [OutputConstructor]
        private LoadBalancerFrontendIPConfigurationResponse(
            string name,

            Outputs.LoadBalancerFrontendIPConfigurationPropertiesResponse properties)
        {
            Name = name;
            Properties = properties;
        }
    }
}
