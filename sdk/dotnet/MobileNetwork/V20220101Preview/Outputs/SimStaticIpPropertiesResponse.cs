// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.V20220101Preview.Outputs
{

    /// <summary>
    /// Static IP configuration for a sim, scoped to a particular attached data network and slice.
    /// </summary>
    [OutputType]
    public sealed class SimStaticIpPropertiesResponse
    {
        /// <summary>
        /// The attached data network on which the static IP address will be used. The combination of attachedDataNetwork and slice defines the network scope of the IP address.
        /// </summary>
        public readonly Outputs.AttachedDataNetworkResourceIdResponse? AttachedDataNetwork;
        /// <summary>
        /// The network slice on which the static IP address will be used. The combination of attachedDataNetwork and slice defines the network scope of the IP address.
        /// </summary>
        public readonly Outputs.SliceResourceIdResponse? Slice;
        /// <summary>
        /// The static IP configuration for the sim to use at the defined network scope.
        /// </summary>
        public readonly Outputs.SimStaticIpPropertiesResponseStaticIp? StaticIp;

        [OutputConstructor]
        private SimStaticIpPropertiesResponse(
            Outputs.AttachedDataNetworkResourceIdResponse? attachedDataNetwork,

            Outputs.SliceResourceIdResponse? slice,

            Outputs.SimStaticIpPropertiesResponseStaticIp? staticIp)
        {
            AttachedDataNetwork = attachedDataNetwork;
            Slice = slice;
            StaticIp = staticIp;
        }
    }
}
