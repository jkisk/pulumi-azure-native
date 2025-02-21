// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20170901Preview.Outputs
{

    /// <summary>
    /// Base class for all triggers that support one to many model for trigger to pipeline.
    /// </summary>
    [OutputType]
    public sealed class MultiplePipelineTriggerResponse
    {
        /// <summary>
        /// Trigger description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Pipelines that need to be started.
        /// </summary>
        public readonly ImmutableArray<Outputs.TriggerPipelineReferenceResponse> Pipelines;
        /// <summary>
        /// Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger.
        /// </summary>
        public readonly string RuntimeState;
        /// <summary>
        /// Trigger type.
        /// Expected value is 'MultiplePipelineTrigger'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private MultiplePipelineTriggerResponse(
            string? description,

            ImmutableArray<Outputs.TriggerPipelineReferenceResponse> pipelines,

            string runtimeState,

            string type)
        {
            Description = description;
            Pipelines = pipelines;
            RuntimeState = runtimeState;
            Type = type;
        }
    }
}
