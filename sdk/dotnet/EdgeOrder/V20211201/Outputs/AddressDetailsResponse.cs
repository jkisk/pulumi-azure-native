// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EdgeOrder.V20211201.Outputs
{

    /// <summary>
    /// Address details for an order item.
    /// </summary>
    [OutputType]
    public sealed class AddressDetailsResponse
    {
        /// <summary>
        /// Customer address and contact details. It should be address resource
        /// </summary>
        public readonly Outputs.AddressPropertiesResponse ForwardAddress;
        /// <summary>
        /// Return shipping address
        /// </summary>
        public readonly Outputs.AddressPropertiesResponse ReturnAddress;

        [OutputConstructor]
        private AddressDetailsResponse(
            Outputs.AddressPropertiesResponse forwardAddress,

            Outputs.AddressPropertiesResponse returnAddress)
        {
            ForwardAddress = forwardAddress;
            ReturnAddress = returnAddress;
        }
    }
}
