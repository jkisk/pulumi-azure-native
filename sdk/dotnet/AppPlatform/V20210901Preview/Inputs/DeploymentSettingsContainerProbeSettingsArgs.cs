// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20210901Preview.Inputs
{

    /// <summary>
    /// Container liveness and readiness probe settings
    /// </summary>
    public sealed class DeploymentSettingsContainerProbeSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether disable the liveness and readiness probe
        /// </summary>
        [Input("disableProbe")]
        public Input<bool>? DisableProbe { get; set; }

        public DeploymentSettingsContainerProbeSettingsArgs()
        {
        }
    }
}
