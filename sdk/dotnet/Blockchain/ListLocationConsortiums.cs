// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Blockchain
{
    public static class ListLocationConsortiums
    {
        /// <summary>
        /// Collection of the consortium payload.
        /// API Version: 2018-06-01-preview.
        /// </summary>
        public static Task<ListLocationConsortiumsResult> InvokeAsync(ListLocationConsortiumsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListLocationConsortiumsResult>("azure-native:blockchain:listLocationConsortiums", args ?? new ListLocationConsortiumsArgs(), options.WithDefaults());

        /// <summary>
        /// Collection of the consortium payload.
        /// API Version: 2018-06-01-preview.
        /// </summary>
        public static Output<ListLocationConsortiumsResult> Invoke(ListLocationConsortiumsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListLocationConsortiumsResult>("azure-native:blockchain:listLocationConsortiums", args ?? new ListLocationConsortiumsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListLocationConsortiumsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Location Name.
        /// </summary>
        [Input("locationName", required: true)]
        public string LocationName { get; set; } = null!;

        public ListLocationConsortiumsArgs()
        {
        }
    }

    public sealed class ListLocationConsortiumsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Location Name.
        /// </summary>
        [Input("locationName", required: true)]
        public Input<string> LocationName { get; set; } = null!;

        public ListLocationConsortiumsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListLocationConsortiumsResult
    {
        /// <summary>
        /// Gets or sets the collection of consortiums.
        /// </summary>
        public readonly ImmutableArray<Outputs.ConsortiumResponse> Value;

        [OutputConstructor]
        private ListLocationConsortiumsResult(ImmutableArray<Outputs.ConsortiumResponse> value)
        {
            Value = value;
        }
    }
}
