// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20200331.Outputs
{

    /// <summary>
    /// The main origin of CDN content which is added when creating a CDN endpoint.
    /// </summary>
    [OutputType]
    public sealed class DeepCreatedOriginResponse
    {
        /// <summary>
        /// Origin is enabled for load balancing or not. By default, origin is always enabled.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// The address of the origin. It can be a domain name, IPv4 address, or IPv6 address. This should be unique across all origins in an endpoint.
        /// </summary>
        public readonly string HostName;
        /// <summary>
        /// The value of the HTTP port. Must be between 1 and 65535.
        /// </summary>
        public readonly int? HttpPort;
        /// <summary>
        /// The value of the HTTPS port. Must be between 1 and 65535.
        /// </summary>
        public readonly int? HttpsPort;
        /// <summary>
        /// Origin name which must be unique within the endpoint. 
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
        /// </summary>
        public readonly string? OriginHostHeader;
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        public readonly int? Weight;

        [OutputConstructor]
        private DeepCreatedOriginResponse(
            bool? enabled,

            string hostName,

            int? httpPort,

            int? httpsPort,

            string name,

            string? originHostHeader,

            int? priority,

            int? weight)
        {
            Enabled = enabled;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            Name = name;
            OriginHostHeader = originHostHeader;
            Priority = priority;
            Weight = weight;
        }
    }
}
