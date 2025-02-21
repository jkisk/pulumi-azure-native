// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20151001
{
    public static class ListMediaServiceKeys
    {
        /// <summary>
        /// The response body for a ListKeys API.
        /// </summary>
        public static Task<ListMediaServiceKeysResult> InvokeAsync(ListMediaServiceKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListMediaServiceKeysResult>("azure-native:media/v20151001:listMediaServiceKeys", args ?? new ListMediaServiceKeysArgs(), options.WithDefaults());

        /// <summary>
        /// The response body for a ListKeys API.
        /// </summary>
        public static Output<ListMediaServiceKeysResult> Invoke(ListMediaServiceKeysInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListMediaServiceKeysResult>("azure-native:media/v20151001:listMediaServiceKeys", args ?? new ListMediaServiceKeysInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListMediaServiceKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Media Service.
        /// </summary>
        [Input("mediaServiceName", required: true)]
        public string MediaServiceName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListMediaServiceKeysArgs()
        {
        }
    }

    public sealed class ListMediaServiceKeysInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Media Service.
        /// </summary>
        [Input("mediaServiceName", required: true)]
        public Input<string> MediaServiceName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListMediaServiceKeysInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListMediaServiceKeysResult
    {
        /// <summary>
        /// The primary authorization endpoint.
        /// </summary>
        public readonly string? PrimaryAuthEndpoint;
        /// <summary>
        /// The primary key for the Media Service resource.
        /// </summary>
        public readonly string? PrimaryKey;
        /// <summary>
        /// The authorization scope.
        /// </summary>
        public readonly string? Scope;
        /// <summary>
        /// The secondary authorization endpoint.
        /// </summary>
        public readonly string? SecondaryAuthEndpoint;
        /// <summary>
        /// The secondary key for the Media Service resource.
        /// </summary>
        public readonly string? SecondaryKey;

        [OutputConstructor]
        private ListMediaServiceKeysResult(
            string? primaryAuthEndpoint,

            string? primaryKey,

            string? scope,

            string? secondaryAuthEndpoint,

            string? secondaryKey)
        {
            PrimaryAuthEndpoint = primaryAuthEndpoint;
            PrimaryKey = primaryKey;
            Scope = scope;
            SecondaryAuthEndpoint = secondaryAuthEndpoint;
            SecondaryKey = secondaryKey;
        }
    }
}
