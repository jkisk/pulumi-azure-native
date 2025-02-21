// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.OperationalInsights.V20150320
{
    [Obsolete(@"Version 2015-03-20 will be removed in v2 of the provider.")]
    public static class GetSavedSearch
    {
        /// <summary>
        /// Value object for saved search results.
        /// </summary>
        public static Task<GetSavedSearchResult> InvokeAsync(GetSavedSearchArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSavedSearchResult>("azure-native:operationalinsights/v20150320:getSavedSearch", args ?? new GetSavedSearchArgs(), options.WithDefaults());

        /// <summary>
        /// Value object for saved search results.
        /// </summary>
        public static Output<GetSavedSearchResult> Invoke(GetSavedSearchInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSavedSearchResult>("azure-native:operationalinsights/v20150320:getSavedSearch", args ?? new GetSavedSearchInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSavedSearchArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Resource Group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The id of the saved search.
        /// </summary>
        [Input("savedSearchId", required: true)]
        public string SavedSearchId { get; set; } = null!;

        /// <summary>
        /// The Log Analytics Workspace name.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetSavedSearchArgs()
        {
        }
    }

    public sealed class GetSavedSearchInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Resource Group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The id of the saved search.
        /// </summary>
        [Input("savedSearchId", required: true)]
        public Input<string> SavedSearchId { get; set; } = null!;

        /// <summary>
        /// The Log Analytics Workspace name.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetSavedSearchInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSavedSearchResult
    {
        /// <summary>
        /// The category of the saved search. This helps the user to find a saved search faster. 
        /// </summary>
        public readonly string Category;
        /// <summary>
        /// Saved search display name.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The ETag of the saved search.
        /// </summary>
        public readonly string? ETag;
        /// <summary>
        /// The id of the saved search.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the saved search.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The query expression for the saved search. Please see https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-search-reference for reference.
        /// </summary>
        public readonly string Query;
        /// <summary>
        /// The tags attached to the saved search.
        /// </summary>
        public readonly ImmutableArray<Outputs.TagResponse> Tags;
        /// <summary>
        /// The type of the saved search.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The version number of the query language. The current version is 2 and is the default.
        /// </summary>
        public readonly double? Version;

        [OutputConstructor]
        private GetSavedSearchResult(
            string category,

            string displayName,

            string? eTag,

            string id,

            string name,

            string query,

            ImmutableArray<Outputs.TagResponse> tags,

            string type,

            double? version)
        {
            Category = category;
            DisplayName = displayName;
            ETag = eTag;
            Id = id;
            Name = name;
            Query = query;
            Tags = tags;
            Type = type;
            Version = version;
        }
    }
}
