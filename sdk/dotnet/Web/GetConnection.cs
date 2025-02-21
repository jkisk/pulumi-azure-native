// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web
{
    public static class GetConnection
    {
        /// <summary>
        /// API connection
        /// API Version: 2016-06-01.
        /// </summary>
        public static Task<GetConnectionResult> InvokeAsync(GetConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConnectionResult>("azure-native:web:getConnection", args ?? new GetConnectionArgs(), options.WithDefaults());

        /// <summary>
        /// API connection
        /// API Version: 2016-06-01.
        /// </summary>
        public static Output<GetConnectionResult> Invoke(GetConnectionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConnectionResult>("azure-native:web:getConnection", args ?? new GetConnectionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Connection name
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

        /// <summary>
        /// The resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Subscription Id
        /// </summary>
        [Input("subscriptionId")]
        public string? SubscriptionId { get; set; }

        public GetConnectionArgs()
        {
        }
    }

    public sealed class GetConnectionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Connection name
        /// </summary>
        [Input("connectionName", required: true)]
        public Input<string> ConnectionName { get; set; } = null!;

        /// <summary>
        /// The resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Subscription Id
        /// </summary>
        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        public GetConnectionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConnectionResult
    {
        /// <summary>
        /// Resource ETag
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        public readonly Outputs.ApiConnectionDefinitionResponseProperties Properties;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetConnectionResult(
            string? etag,

            string id,

            string? location,

            string name,

            Outputs.ApiConnectionDefinitionResponseProperties properties,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Etag = etag;
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
