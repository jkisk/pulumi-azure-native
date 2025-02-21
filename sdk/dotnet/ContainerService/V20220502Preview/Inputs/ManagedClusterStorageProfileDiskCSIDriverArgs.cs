// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20220502Preview.Inputs
{

    /// <summary>
    /// AzureDisk CSI Driver settings for the storage profile.
    /// </summary>
    public sealed class ManagedClusterStorageProfileDiskCSIDriverArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to enable AzureDisk CSI Driver. The default value is true.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The version of AzureDisk CSI Driver. The default value is v1.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ManagedClusterStorageProfileDiskCSIDriverArgs()
        {
        }
    }
}
