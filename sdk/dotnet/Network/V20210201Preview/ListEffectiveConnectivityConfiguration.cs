// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210201Preview
{
    public static class ListEffectiveConnectivityConfiguration
    {
        /// <summary>
        /// Result of the request to list networkManagerEffectiveConnectivityConfiguration. It contains a list of groups and a skiptoken to get the next set of results.
        /// </summary>
        public static Task<ListEffectiveConnectivityConfigurationResult> InvokeAsync(ListEffectiveConnectivityConfigurationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListEffectiveConnectivityConfigurationResult>("azure-native:network/v20210201preview:listEffectiveConnectivityConfiguration", args ?? new ListEffectiveConnectivityConfigurationArgs(), options.WithDefaults());

        /// <summary>
        /// Result of the request to list networkManagerEffectiveConnectivityConfiguration. It contains a list of groups and a skiptoken to get the next set of results.
        /// </summary>
        public static Output<ListEffectiveConnectivityConfigurationResult> Invoke(ListEffectiveConnectivityConfigurationInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListEffectiveConnectivityConfigurationResult>("azure-native:network/v20210201preview:listEffectiveConnectivityConfiguration", args ?? new ListEffectiveConnectivityConfigurationInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListEffectiveConnectivityConfigurationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        [Input("skipToken")]
        public string? SkipToken { get; set; }

        /// <summary>
        /// The name of the virtual network.
        /// </summary>
        [Input("virtualNetworkName", required: true)]
        public string VirtualNetworkName { get; set; } = null!;

        public ListEffectiveConnectivityConfigurationArgs()
        {
        }
    }

    public sealed class ListEffectiveConnectivityConfigurationInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        [Input("skipToken")]
        public Input<string>? SkipToken { get; set; }

        /// <summary>
        /// The name of the virtual network.
        /// </summary>
        [Input("virtualNetworkName", required: true)]
        public Input<string> VirtualNetworkName { get; set; } = null!;

        public ListEffectiveConnectivityConfigurationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListEffectiveConnectivityConfigurationResult
    {
        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        public readonly string? SkipToken;
        /// <summary>
        /// Gets a page of NetworkManagerEffectiveConnectivityConfiguration
        /// </summary>
        public readonly ImmutableArray<Outputs.EffectiveConnectivityConfigurationResponse> Value;

        [OutputConstructor]
        private ListEffectiveConnectivityConfigurationResult(
            string? skipToken,

            ImmutableArray<Outputs.EffectiveConnectivityConfigurationResponse> value)
        {
            SkipToken = skipToken;
            Value = value;
        }
    }
}
