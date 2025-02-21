// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210301Preview.Outputs
{

    /// <summary>
    /// Labeling MLAssist configuration definition
    /// </summary>
    [OutputType]
    public sealed class MLAssistConfigurationResponse
    {
        /// <summary>
        /// AML compute binding used in inferencing.
        /// </summary>
        public readonly Outputs.ComputeConfigurationResponse? InferencingComputeBinding;
        /// <summary>
        /// Indicates whether MLAssist feature is enabled.
        /// </summary>
        public readonly bool? MlAssistEnabled;
        /// <summary>
        /// AML compute binding used in training.
        /// </summary>
        public readonly Outputs.ComputeConfigurationResponse? TrainingComputeBinding;

        [OutputConstructor]
        private MLAssistConfigurationResponse(
            Outputs.ComputeConfigurationResponse? inferencingComputeBinding,

            bool? mlAssistEnabled,

            Outputs.ComputeConfigurationResponse? trainingComputeBinding)
        {
            InferencingComputeBinding = inferencingComputeBinding;
            MlAssistEnabled = mlAssistEnabled;
            TrainingComputeBinding = trainingComputeBinding;
        }
    }
}
