// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210301Preview.Inputs
{

    public sealed class K8sOnlineDeploymentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, enables Application Insights logging.
        /// </summary>
        [Input("appInsightsEnabled")]
        public Input<bool>? AppInsightsEnabled { get; set; }

        /// <summary>
        /// Code configuration for the endpoint deployment.
        /// </summary>
        [Input("codeConfiguration")]
        public Input<Inputs.CodeConfigurationArgs>? CodeConfiguration { get; set; }

        /// <summary>
        /// Resource requirements for each container instance within an online deployment.
        /// </summary>
        [Input("containerResourceRequirements")]
        public Input<Inputs.ContainerResourceRequirementsArgs>? ContainerResourceRequirements { get; set; }

        /// <summary>
        /// Description of the endpoint deployment.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Enum to determine endpoint compute type.
        /// Expected value is 'K8S'.
        /// </summary>
        [Input("endpointComputeType", required: true)]
        public Input<string> EndpointComputeType { get; set; } = null!;

        /// <summary>
        /// ARM resource ID of the environment specification for the endpoint deployment.
        /// </summary>
        [Input("environmentId")]
        public Input<string>? EnvironmentId { get; set; }

        [Input("environmentVariables")]
        private InputMap<string>? _environmentVariables;

        /// <summary>
        /// Environment variables configuration for the deployment.
        /// </summary>
        public InputMap<string> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputMap<string>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// Deployment container liveness/readiness probe configuration.
        /// </summary>
        [Input("livenessProbe")]
        public Input<Inputs.ProbeSettingsArgs>? LivenessProbe { get; set; }

        /// <summary>
        /// Reference to the model asset for the endpoint deployment.
        /// </summary>
        [Input("model")]
        public object? Model { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// Property dictionary. Properties can be added, but not removed or altered.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// Online deployment scoring requests configuration.
        /// </summary>
        [Input("requestSettings")]
        public Input<Inputs.OnlineRequestSettingsArgs>? RequestSettings { get; set; }

        /// <summary>
        /// Online deployment scaling configuration.
        /// </summary>
        [Input("scaleSettings")]
        public InputUnion<Inputs.AutoScaleSettingsArgs, Inputs.ManualScaleSettingsArgs>? ScaleSettings { get; set; }

        public K8sOnlineDeploymentArgs()
        {
        }
    }
}
