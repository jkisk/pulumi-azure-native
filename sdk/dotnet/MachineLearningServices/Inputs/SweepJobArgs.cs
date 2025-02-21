// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.Inputs
{

    /// <summary>
    /// Sweep job definition.
    /// </summary>
    public sealed class SweepJobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// [Required] Type of the hyperparameter sampling algorithms
        /// </summary>
        [Input("algorithm", required: true)]
        public InputUnion<string, Pulumi.AzureNative.MachineLearningServices.SamplingAlgorithm> Algorithm { get; set; } = null!;

        /// <summary>
        /// [Required] Compute binding for the job.
        /// </summary>
        [Input("compute", required: true)]
        public Input<Inputs.ComputeConfigurationArgs> Compute { get; set; } = null!;

        /// <summary>
        /// The asset description text.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Early termination policies enable canceling poor-performing runs before they complete.
        /// </summary>
        [Input("earlyTermination")]
        public object? EarlyTermination { get; set; }

        /// <summary>
        /// The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment.
        /// </summary>
        [Input("experimentName")]
        public Input<string>? ExperimentName { get; set; }

        /// <summary>
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity or null.
        /// Defaults to AmlToken if null.
        /// </summary>
        [Input("identity")]
        public InputUnion<Inputs.AmlTokenArgs, Inputs.ManagedIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Enum to determine the type of job.
        /// Expected value is 'Sweep'.
        /// </summary>
        [Input("jobType", required: true)]
        public Input<string> JobType { get; set; } = null!;

        /// <summary>
        /// An upper bound on the number of trials performed in parallel.
        /// </summary>
        [Input("maxConcurrentTrials")]
        public Input<int>? MaxConcurrentTrials { get; set; }

        /// <summary>
        /// An upper bound on the number of trials to perform.
        /// </summary>
        [Input("maxTotalTrials")]
        public Input<int>? MaxTotalTrials { get; set; }

        /// <summary>
        /// [Required] Optimization objective.
        /// </summary>
        [Input("objective", required: true)]
        public Input<Inputs.ObjectiveArgs> Objective { get; set; } = null!;

        /// <summary>
        /// Job priority for scheduling policy. Only applies to AMLCompute.
        /// Private preview feature and only available to users on the allow list.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// The asset property dictionary.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        [Input("searchSpace", required: true)]
        private InputMap<object>? _searchSpace;

        /// <summary>
        /// [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter
        /// </summary>
        public InputMap<object> SearchSpace
        {
            get => _searchSpace ?? (_searchSpace = new InputMap<object>());
            set => _searchSpace = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tag dictionary. Tags can be added, removed, and updated.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The total timeout in ISO 8601 format. Only supports duration with precision as low as Minutes.
        /// </summary>
        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        /// <summary>
        /// Trial component definition.
        /// </summary>
        [Input("trial")]
        public Input<Inputs.TrialComponentArgs>? Trial { get; set; }

        public SweepJobArgs()
        {
        }
    }
}
