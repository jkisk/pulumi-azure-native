// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cache.V20170201
{
    /// <summary>
    /// Response to put/get linked server (with properties) for Redis cache.
    /// </summary>
    [Obsolete(@"Version 2017-02-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:cache/v20170201:RedisLinkedServer")]
    public partial class RedisLinkedServer : Pulumi.CustomResource
    {
        /// <summary>
        /// Fully qualified resourceId of the linked redis cache.
        /// </summary>
        [Output("linkedRedisCacheId")]
        public Output<string> LinkedRedisCacheId { get; private set; } = null!;

        /// <summary>
        /// Location of the linked redis cache.
        /// </summary>
        [Output("linkedRedisCacheLocation")]
        public Output<string> LinkedRedisCacheLocation { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Terminal state of the link between primary and secondary redis cache.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Role of the linked server.
        /// </summary>
        [Output("serverRole")]
        public Output<string> ServerRole { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a RedisLinkedServer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RedisLinkedServer(string name, RedisLinkedServerArgs args, CustomResourceOptions? options = null)
            : base("azure-native:cache/v20170201:RedisLinkedServer", name, args ?? new RedisLinkedServerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RedisLinkedServer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:cache/v20170201:RedisLinkedServer", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:cache:RedisLinkedServer"},
                    new Pulumi.Alias { Type = "azure-native:cache/v20171001:RedisLinkedServer"},
                    new Pulumi.Alias { Type = "azure-native:cache/v20180301:RedisLinkedServer"},
                    new Pulumi.Alias { Type = "azure-native:cache/v20190701:RedisLinkedServer"},
                    new Pulumi.Alias { Type = "azure-native:cache/v20200601:RedisLinkedServer"},
                    new Pulumi.Alias { Type = "azure-native:cache/v20201201:RedisLinkedServer"},
                    new Pulumi.Alias { Type = "azure-native:cache/v20210601:RedisLinkedServer"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RedisLinkedServer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RedisLinkedServer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RedisLinkedServer(name, id, options);
        }
    }

    public sealed class RedisLinkedServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fully qualified resourceId of the linked redis cache.
        /// </summary>
        [Input("linkedRedisCacheId", required: true)]
        public Input<string> LinkedRedisCacheId { get; set; } = null!;

        /// <summary>
        /// Location of the linked redis cache.
        /// </summary>
        [Input("linkedRedisCacheLocation", required: true)]
        public Input<string> LinkedRedisCacheLocation { get; set; } = null!;

        /// <summary>
        /// The name of the linked server that is being added to the Redis cache.
        /// </summary>
        [Input("linkedServerName")]
        public Input<string>? LinkedServerName { get; set; }

        /// <summary>
        /// The name of the Redis cache.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Role of the linked server.
        /// </summary>
        [Input("serverRole", required: true)]
        public Input<Pulumi.AzureNative.Cache.V20170201.ReplicationRole> ServerRole { get; set; } = null!;

        public RedisLinkedServerArgs()
        {
        }
    }
}
