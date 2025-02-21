// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Solutions.V20160901Preview
{
    [Obsolete(@"Version 2016-09-01-preview will be removed in v2 of the provider.")]
    public static class GetAppliance
    {
        /// <summary>
        /// Information about appliance.
        /// </summary>
        public static Task<GetApplianceResult> InvokeAsync(GetApplianceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApplianceResult>("azure-native:solutions/v20160901preview:getAppliance", args ?? new GetApplianceArgs(), options.WithDefaults());

        /// <summary>
        /// Information about appliance.
        /// </summary>
        public static Output<GetApplianceResult> Invoke(GetApplianceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetApplianceResult>("azure-native:solutions/v20160901preview:getAppliance", args ?? new GetApplianceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplianceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the appliance.
        /// </summary>
        [Input("applianceName", required: true)]
        public string ApplianceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetApplianceArgs()
        {
        }
    }

    public sealed class GetApplianceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the appliance.
        /// </summary>
        [Input("applianceName", required: true)]
        public Input<string> ApplianceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetApplianceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApplianceResult
    {
        /// <summary>
        /// The fully qualified path of appliance definition Id.
        /// </summary>
        public readonly string? ApplianceDefinitionId;
        /// <summary>
        /// Resource ID
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// The kind of the appliance. Allowed values are MarketPlace and ServiceCatalog.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// ID of the resource that manages this resource.
        /// </summary>
        public readonly string? ManagedBy;
        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        public readonly string ManagedResourceGroupId;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Name and value pairs that define the appliance outputs.
        /// </summary>
        public readonly object Outputs;
        /// <summary>
        /// Name and value pairs that define the appliance parameters. It can be a JObject or a well formed JSON string.
        /// </summary>
        public readonly object? Parameters;
        /// <summary>
        /// The plan information.
        /// </summary>
        public readonly Outputs.PlanResponse? Plan;
        /// <summary>
        /// The appliance provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The blob URI where the UI definition file is located.
        /// </summary>
        public readonly string? UiDefinitionUri;

        [OutputConstructor]
        private GetApplianceResult(
            string? applianceDefinitionId,

            string id,

            Outputs.IdentityResponse? identity,

            string? kind,

            string? location,

            string? managedBy,

            string managedResourceGroupId,

            string name,

            object outputs,

            object? parameters,

            Outputs.PlanResponse? plan,

            string provisioningState,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type,

            string? uiDefinitionUri)
        {
            ApplianceDefinitionId = applianceDefinitionId;
            Id = id;
            Identity = identity;
            Kind = kind;
            Location = location;
            ManagedBy = managedBy;
            ManagedResourceGroupId = managedResourceGroupId;
            Name = name;
            Outputs = outputs;
            Parameters = parameters;
            Plan = plan;
            ProvisioningState = provisioningState;
            Sku = sku;
            Tags = tags;
            Type = type;
            UiDefinitionUri = uiDefinitionUri;
        }
    }
}
