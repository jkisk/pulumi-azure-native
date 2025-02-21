// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210301Preview.Inputs
{

    /// <summary>
    /// Labeling job definition
    /// </summary>
    public sealed class LabelingJobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of dataset used in the job.
        /// </summary>
        [Input("datasetConfiguration")]
        public Input<Inputs.LabelingDatasetConfigurationArgs>? DatasetConfiguration { get; set; }

        /// <summary>
        /// The asset description text.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Labeling instructions of the job.
        /// </summary>
        [Input("jobInstructions")]
        public Input<Inputs.LabelingJobInstructionsArgs>? JobInstructions { get; set; }

        /// <summary>
        /// [Required] Specifies the type of job. This field should always be set to "Labeling".
        /// </summary>
        [Input("jobType", required: true)]
        public InputUnion<string, Pulumi.AzureNative.MachineLearningServices.V20210301Preview.JobType> JobType { get; set; } = null!;

        [Input("labelCategories")]
        private InputMap<Inputs.LabelCategoryArgs>? _labelCategories;

        /// <summary>
        /// Label categories of the job.
        /// </summary>
        public InputMap<Inputs.LabelCategoryArgs> LabelCategories
        {
            get => _labelCategories ?? (_labelCategories = new InputMap<Inputs.LabelCategoryArgs>());
            set => _labelCategories = value;
        }

        /// <summary>
        /// Media type specific properties in the job.
        /// </summary>
        [Input("labelingJobMediaProperties")]
        public InputUnion<Inputs.LabelingJobImagePropertiesArgs, Inputs.LabelingJobTextPropertiesArgs>? LabelingJobMediaProperties { get; set; }

        /// <summary>
        /// Configuration of MLAssist feature in the job.
        /// </summary>
        [Input("mlAssistConfiguration")]
        public Input<Inputs.MLAssistConfigurationArgs>? MlAssistConfiguration { get; set; }

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

        public LabelingJobArgs()
        {
        }
    }
}
