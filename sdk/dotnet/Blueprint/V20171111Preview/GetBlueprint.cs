// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Blueprint.V20171111Preview
{
    [Obsolete(@"Version 2017-11-11-preview will be removed in v2 of the provider.")]
    public static class GetBlueprint
    {
        /// <summary>
        /// Represents a Blueprint definition.
        /// </summary>
        public static Task<GetBlueprintResult> InvokeAsync(GetBlueprintArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBlueprintResult>("azure-native:blueprint/v20171111preview:getBlueprint", args ?? new GetBlueprintArgs(), options.WithDefaults());

        /// <summary>
        /// Represents a Blueprint definition.
        /// </summary>
        public static Output<GetBlueprintResult> Invoke(GetBlueprintInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBlueprintResult>("azure-native:blueprint/v20171111preview:getBlueprint", args ?? new GetBlueprintInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBlueprintArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// name of the blueprint.
        /// </summary>
        [Input("blueprintName", required: true)]
        public string BlueprintName { get; set; } = null!;

        /// <summary>
        /// ManagementGroup where blueprint stores.
        /// </summary>
        [Input("managementGroupName", required: true)]
        public string ManagementGroupName { get; set; } = null!;

        public GetBlueprintArgs()
        {
        }
    }

    public sealed class GetBlueprintInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// name of the blueprint.
        /// </summary>
        [Input("blueprintName", required: true)]
        public Input<string> BlueprintName { get; set; } = null!;

        /// <summary>
        /// ManagementGroup where blueprint stores.
        /// </summary>
        [Input("managementGroupName", required: true)]
        public Input<string> ManagementGroupName { get; set; } = null!;

        public GetBlueprintInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBlueprintResult
    {
        /// <summary>
        /// Multi-line explain this resource.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// One-liner string explain this resource.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// String Id used to locate any resource on Azure.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Layout view of the blueprint, for UI reference.
        /// </summary>
        public readonly object? Layout;
        /// <summary>
        /// Name of this resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Parameters required by this Blueprint definition.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterDefinitionResponse>? Parameters;
        /// <summary>
        /// Resource group placeholders defined by this Blueprint definition.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ResourceGroupDefinitionResponse>? ResourceGroups;
        /// <summary>
        /// Status of the Blueprint. This field is readonly.
        /// </summary>
        public readonly Outputs.BlueprintStatusResponse Status;
        /// <summary>
        /// The scope where this Blueprint can be applied.
        /// </summary>
        public readonly string TargetScope;
        /// <summary>
        /// Type of this resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Published versions of this blueprint.
        /// </summary>
        public readonly object? Versions;

        [OutputConstructor]
        private GetBlueprintResult(
            string? description,

            string? displayName,

            string id,

            object? layout,

            string name,

            ImmutableDictionary<string, Outputs.ParameterDefinitionResponse>? parameters,

            ImmutableDictionary<string, Outputs.ResourceGroupDefinitionResponse>? resourceGroups,

            Outputs.BlueprintStatusResponse status,

            string targetScope,

            string type,

            object? versions)
        {
            Description = description;
            DisplayName = displayName;
            Id = id;
            Layout = layout;
            Name = name;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            Status = status;
            TargetScope = targetScope;
            Type = type;
            Versions = versions;
        }
    }
}
