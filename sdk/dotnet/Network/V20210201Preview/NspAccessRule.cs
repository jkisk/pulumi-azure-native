// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210201Preview
{
    /// <summary>
    /// The NSP access rule resource
    /// </summary>
    [AzureNativeResourceType("azure-native:network/v20210201preview:NspAccessRule")]
    public partial class NspAccessRule : Pulumi.CustomResource
    {
        /// <summary>
        /// Inbound address prefixes (IPv4/IPv6)
        /// </summary>
        [Output("addressPrefixes")]
        public Output<ImmutableArray<string>> AddressPrefixes { get; private set; } = null!;

        /// <summary>
        /// Direction that specifies whether the access rules is inbound/outbound.
        /// </summary>
        [Output("direction")]
        public Output<string?> Direction { get; private set; } = null!;

        /// <summary>
        /// Outbound rules fully qualified domain name format.
        /// </summary>
        [Output("fullyQualifiedDomainNames")]
        public Output<ImmutableArray<string>> FullyQualifiedDomainNames { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Inbound rule specified by the perimeter id.
        /// </summary>
        [Output("networkSecurityPerimeters")]
        public Output<ImmutableArray<Outputs.PerimeterBasedAccessRuleResponse>> NetworkSecurityPerimeters { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the scope assignment resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Subscription id in the ARM id format.
        /// </summary>
        [Output("subscriptions")]
        public Output<ImmutableArray<string>> Subscriptions { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a NspAccessRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NspAccessRule(string name, NspAccessRuleArgs args, CustomResourceOptions? options = null)
            : base("azure-native:network/v20210201preview:NspAccessRule", name, args ?? new NspAccessRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NspAccessRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:network/v20210201preview:NspAccessRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:network:NspAccessRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NspAccessRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NspAccessRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NspAccessRule(name, id, options);
        }
    }

    public sealed class NspAccessRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the NSP access rule.
        /// </summary>
        [Input("accessRuleName")]
        public Input<string>? AccessRuleName { get; set; }

        [Input("addressPrefixes")]
        private InputList<string>? _addressPrefixes;

        /// <summary>
        /// Inbound address prefixes (IPv4/IPv6)
        /// </summary>
        public InputList<string> AddressPrefixes
        {
            get => _addressPrefixes ?? (_addressPrefixes = new InputList<string>());
            set => _addressPrefixes = value;
        }

        /// <summary>
        /// Direction that specifies whether the access rules is inbound/outbound.
        /// </summary>
        [Input("direction")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20210201Preview.AccessRuleDirection>? Direction { get; set; }

        [Input("fullyQualifiedDomainNames")]
        private InputList<string>? _fullyQualifiedDomainNames;

        /// <summary>
        /// Outbound rules fully qualified domain name format.
        /// </summary>
        public InputList<string> FullyQualifiedDomainNames
        {
            get => _fullyQualifiedDomainNames ?? (_fullyQualifiedDomainNames = new InputList<string>());
            set => _fullyQualifiedDomainNames = value;
        }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the access rule that is unique within a profile. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the network security perimeter.
        /// </summary>
        [Input("networkSecurityPerimeterName", required: true)]
        public Input<string> NetworkSecurityPerimeterName { get; set; } = null!;

        [Input("networkSecurityPerimeters")]
        private InputList<Inputs.PerimeterBasedAccessRuleArgs>? _networkSecurityPerimeters;

        /// <summary>
        /// Inbound rule specified by the perimeter id.
        /// </summary>
        public InputList<Inputs.PerimeterBasedAccessRuleArgs> NetworkSecurityPerimeters
        {
            get => _networkSecurityPerimeters ?? (_networkSecurityPerimeters = new InputList<Inputs.PerimeterBasedAccessRuleArgs>());
            set => _networkSecurityPerimeters = value;
        }

        /// <summary>
        /// The name of the NSP profile.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("subscriptions")]
        private InputList<string>? _subscriptions;

        /// <summary>
        /// Subscription id in the ARM id format.
        /// </summary>
        public InputList<string> Subscriptions
        {
            get => _subscriptions ?? (_subscriptions = new InputList<string>());
            set => _subscriptions = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public NspAccessRuleArgs()
        {
        }
    }
}
