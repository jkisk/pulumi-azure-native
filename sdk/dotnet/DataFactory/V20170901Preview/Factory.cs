// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20170901Preview
{
    /// <summary>
    /// Factory resource type.
    /// </summary>
    [Obsolete(@"Version 2017-09-01-preview will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:datafactory/v20170901preview:Factory")]
    public partial class Factory : Pulumi.CustomResource
    {
        /// <summary>
        /// Time the factory was created in ISO8601 format.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Managed service identity of the factory.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.FactoryIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Factory provisioning state, example Succeeded.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Version of the factory.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// VSTS repo information of the factory.
        /// </summary>
        [Output("vstsConfiguration")]
        public Output<Outputs.FactoryVSTSConfigurationResponse?> VstsConfiguration { get; private set; } = null!;


        /// <summary>
        /// Create a Factory resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Factory(string name, FactoryArgs args, CustomResourceOptions? options = null)
            : base("azure-native:datafactory/v20170901preview:Factory", name, args ?? new FactoryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Factory(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:datafactory/v20170901preview:Factory", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:datafactory:Factory"},
                    new Pulumi.Alias { Type = "azure-native:datafactory/v20180601:Factory"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Factory resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Factory Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Factory(name, id, options);
        }
    }

    public sealed class FactoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName")]
        public Input<string>? FactoryName { get; set; }

        /// <summary>
        /// Managed service identity of the factory.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.FactoryIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// VSTS repo information of the factory.
        /// </summary>
        [Input("vstsConfiguration")]
        public Input<Inputs.FactoryVSTSConfigurationArgs>? VstsConfiguration { get; set; }

        public FactoryArgs()
        {
        }
    }
}
