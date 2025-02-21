// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CognitiveServices.V20211001.Inputs
{

    /// <summary>
    /// Properties of Cognitive Services account deployment model.
    /// </summary>
    public sealed class DeploymentScaleSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Deployment capacity.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// Deployment scale type.
        /// </summary>
        [Input("scaleType")]
        public InputUnion<string, Pulumi.AzureNative.CognitiveServices.V20211001.DeploymentScaleType>? ScaleType { get; set; }

        public DeploymentScaleSettingsArgs()
        {
        }
    }
}
