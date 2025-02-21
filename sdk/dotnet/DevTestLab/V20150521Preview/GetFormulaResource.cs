// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DevTestLab.V20150521Preview
{
    [Obsolete(@"Version 2015-05-21-preview will be removed in v2 of the provider.")]
    public static class GetFormulaResource
    {
        /// <summary>
        /// A formula.
        /// </summary>
        public static Task<GetFormulaResourceResult> InvokeAsync(GetFormulaResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFormulaResourceResult>("azure-native:devtestlab/v20150521preview:getFormulaResource", args ?? new GetFormulaResourceArgs(), options.WithDefaults());

        /// <summary>
        /// A formula.
        /// </summary>
        public static Output<GetFormulaResourceResult> Invoke(GetFormulaResourceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetFormulaResourceResult>("azure-native:devtestlab/v20150521preview:getFormulaResource", args ?? new GetFormulaResourceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFormulaResourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the lab.
        /// </summary>
        [Input("labName", required: true)]
        public string LabName { get; set; } = null!;

        /// <summary>
        /// The name of the formula.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetFormulaResourceArgs()
        {
        }
    }

    public sealed class GetFormulaResourceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the lab.
        /// </summary>
        [Input("labName", required: true)]
        public Input<string> LabName { get; set; } = null!;

        /// <summary>
        /// The name of the formula.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetFormulaResourceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFormulaResourceResult
    {
        /// <summary>
        /// The author of the formula.
        /// </summary>
        public readonly string? Author;
        /// <summary>
        /// The creation date of the formula.
        /// </summary>
        public readonly string? CreationDate;
        /// <summary>
        /// The description of the formula.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The content of the formula.
        /// </summary>
        public readonly Outputs.LabVirtualMachineResponse? FormulaContent;
        /// <summary>
        /// The identifier of the resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The OS type of the formula.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Information about a VM from which a formula is to be created.
        /// </summary>
        public readonly Outputs.FormulaPropertiesFromVmResponse? Vm;

        [OutputConstructor]
        private GetFormulaResourceResult(
            string? author,

            string? creationDate,

            string? description,

            Outputs.LabVirtualMachineResponse? formulaContent,

            string? id,

            string? location,

            string? name,

            string? osType,

            string? provisioningState,

            ImmutableDictionary<string, string>? tags,

            string? type,

            Outputs.FormulaPropertiesFromVmResponse? vm)
        {
            Author = author;
            CreationDate = creationDate;
            Description = description;
            FormulaContent = formulaContent;
            Id = id;
            Location = location;
            Name = name;
            OsType = osType;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            Vm = vm;
        }
    }
}
