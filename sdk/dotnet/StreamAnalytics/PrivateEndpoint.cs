// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StreamAnalytics
{
    /// <summary>
    /// Complete information about the private endpoint.
    /// API Version: 2020-03-01-preview.
    /// </summary>
    [AzureNativeResourceType("azure-native:streamanalytics:PrivateEndpoint")]
    public partial class PrivateEndpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// Unique opaque string (generally a GUID) that represents the metadata state of the resource (private endpoint) and changes whenever the resource is updated. Required on PUT (CreateOrUpdate) requests.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The properties associated with a private endpoint.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.PrivateEndpointPropertiesResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a PrivateEndpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrivateEndpoint(string name, PrivateEndpointArgs args, CustomResourceOptions? options = null)
            : base("azure-native:streamanalytics:PrivateEndpoint", name, args ?? new PrivateEndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PrivateEndpoint(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:streamanalytics:PrivateEndpoint", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:streamanalytics/v20200301:PrivateEndpoint"},
                    new Pulumi.Alias { Type = "azure-native:streamanalytics/v20200301preview:PrivateEndpoint"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PrivateEndpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrivateEndpoint Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PrivateEndpoint(name, id, options);
        }
    }

    public sealed class PrivateEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the private endpoint.
        /// </summary>
        [Input("privateEndpointName")]
        public Input<string>? PrivateEndpointName { get; set; }

        /// <summary>
        /// The properties associated with a private endpoint.
        /// </summary>
        [Input("properties")]
        public Input<Inputs.PrivateEndpointPropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public PrivateEndpointArgs()
        {
        }
    }
}
