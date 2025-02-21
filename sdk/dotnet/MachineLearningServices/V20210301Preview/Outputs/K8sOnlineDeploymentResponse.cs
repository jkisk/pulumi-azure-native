// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210301Preview.Outputs
{

    [OutputType]
    public sealed class K8sOnlineDeploymentResponse
    {
        /// <summary>
        /// If true, enables Application Insights logging.
        /// </summary>
        public readonly bool? AppInsightsEnabled;
        /// <summary>
        /// Code configuration for the endpoint deployment.
        /// </summary>
        public readonly Outputs.CodeConfigurationResponse? CodeConfiguration;
        /// <summary>
        /// Resource requirements for each container instance within an online deployment.
        /// </summary>
        public readonly Outputs.ContainerResourceRequirementsResponse? ContainerResourceRequirements;
        /// <summary>
        /// Description of the endpoint deployment.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Enum to determine endpoint compute type.
        /// Expected value is 'K8S'.
        /// </summary>
        public readonly string EndpointComputeType;
        /// <summary>
        /// ARM resource ID of the environment specification for the endpoint deployment.
        /// </summary>
        public readonly string? EnvironmentId;
        /// <summary>
        /// Environment variables configuration for the deployment.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? EnvironmentVariables;
        /// <summary>
        /// Deployment container liveness/readiness probe configuration.
        /// </summary>
        public readonly Outputs.ProbeSettingsResponse? LivenessProbe;
        /// <summary>
        /// Reference to the model asset for the endpoint deployment.
        /// </summary>
        public readonly object? Model;
        /// <summary>
        /// Property dictionary. Properties can be added, but not removed or altered.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Properties;
        /// <summary>
        /// Provisioning state for the endpoint deployment.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Online deployment scoring requests configuration.
        /// </summary>
        public readonly Outputs.OnlineRequestSettingsResponse? RequestSettings;
        /// <summary>
        /// Online deployment scaling configuration.
        /// </summary>
        public readonly Union<Outputs.AutoScaleSettingsResponse, Outputs.ManualScaleSettingsResponse>? ScaleSettings;

        [OutputConstructor]
        private K8sOnlineDeploymentResponse(
            bool? appInsightsEnabled,

            Outputs.CodeConfigurationResponse? codeConfiguration,

            Outputs.ContainerResourceRequirementsResponse? containerResourceRequirements,

            string? description,

            string endpointComputeType,

            string? environmentId,

            ImmutableDictionary<string, string>? environmentVariables,

            Outputs.ProbeSettingsResponse? livenessProbe,

            object? model,

            ImmutableDictionary<string, string>? properties,

            string provisioningState,

            Outputs.OnlineRequestSettingsResponse? requestSettings,

            Union<Outputs.AutoScaleSettingsResponse, Outputs.ManualScaleSettingsResponse>? scaleSettings)
        {
            AppInsightsEnabled = appInsightsEnabled;
            CodeConfiguration = codeConfiguration;
            ContainerResourceRequirements = containerResourceRequirements;
            Description = description;
            EndpointComputeType = endpointComputeType;
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            LivenessProbe = livenessProbe;
            Model = model;
            Properties = properties;
            ProvisioningState = provisioningState;
            RequestSettings = requestSettings;
            ScaleSettings = scaleSettings;
        }
    }
}
