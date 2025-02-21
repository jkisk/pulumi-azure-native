// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20220501Preview.Inputs
{

    /// <summary>
    /// Additional App settings in vnet injection instance
    /// </summary>
    public sealed class AppVNetAddonsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether the App in vnet injection instance exposes endpoint which could be accessed from internet.
        /// </summary>
        [Input("publicEndpoint")]
        public Input<bool>? PublicEndpoint { get; set; }

        public AppVNetAddonsArgs()
        {
            PublicEndpoint = false;
        }
    }
}
