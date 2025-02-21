// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20220402Preview.Inputs
{

    /// <summary>
    /// AzureFile CSI Driver settings for the storage profile.
    /// </summary>
    public sealed class ManagedClusterStorageProfileFileCSIDriverArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to enable AzureFile CSI Driver. The default value is true.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public ManagedClusterStorageProfileFileCSIDriverArgs()
        {
        }
    }
}
