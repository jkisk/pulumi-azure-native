// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Migrate.V20200501.Inputs
{

    /// <summary>
    /// Properties of Connection state request.
    /// </summary>
    public sealed class ConnectionStateRequestBodyPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Private endpoint connection state.
        /// </summary>
        [Input("privateLinkServiceConnectionState")]
        public Input<Inputs.PrivateLinkServiceConnectionStateArgs>? PrivateLinkServiceConnectionState { get; set; }

        public ConnectionStateRequestBodyPropertiesArgs()
        {
        }
    }
}
