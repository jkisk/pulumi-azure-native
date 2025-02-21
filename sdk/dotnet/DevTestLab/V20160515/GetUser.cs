// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DevTestLab.V20160515
{
    [Obsolete(@"Version 2016-05-15 will be removed in v2 of the provider.")]
    public static class GetUser
    {
        /// <summary>
        /// Profile of a lab user.
        /// </summary>
        public static Task<GetUserResult> InvokeAsync(GetUserArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("azure-native:devtestlab/v20160515:getUser", args ?? new GetUserArgs(), options.WithDefaults());

        /// <summary>
        /// Profile of a lab user.
        /// </summary>
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetUserResult>("azure-native:devtestlab/v20160515:getUser", args ?? new GetUserInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specify the $expand query. Example: 'properties($select=identity)'
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the lab.
        /// </summary>
        [Input("labName", required: true)]
        public string LabName { get; set; } = null!;

        /// <summary>
        /// The name of the user profile.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetUserArgs()
        {
        }
    }

    public sealed class GetUserInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specify the $expand query. Example: 'properties($select=identity)'
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// The name of the lab.
        /// </summary>
        [Input("labName", required: true)]
        public Input<string> LabName { get; set; } = null!;

        /// <summary>
        /// The name of the user profile.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetUserInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetUserResult
    {
        /// <summary>
        /// The creation date of the user profile.
        /// </summary>
        public readonly string CreatedDate;
        /// <summary>
        /// The identifier of the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the user.
        /// </summary>
        public readonly Outputs.UserIdentityResponse? Identity;
        /// <summary>
        /// The location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// The secret store of the user.
        /// </summary>
        public readonly Outputs.UserSecretStoreResponse? SecretStore;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The unique immutable identifier of a resource (Guid).
        /// </summary>
        public readonly string? UniqueIdentifier;

        [OutputConstructor]
        private GetUserResult(
            string createdDate,

            string id,

            Outputs.UserIdentityResponse? identity,

            string? location,

            string name,

            string? provisioningState,

            Outputs.UserSecretStoreResponse? secretStore,

            ImmutableDictionary<string, string>? tags,

            string type,

            string? uniqueIdentifier)
        {
            CreatedDate = createdDate;
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SecretStore = secretStore;
            Tags = tags;
            Type = type;
            UniqueIdentifier = uniqueIdentifier;
        }
    }
}
