// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventGrid.Outputs
{

    /// <summary>
    /// Filter for the Event Channel.
    /// </summary>
    [OutputType]
    public sealed class EventChannelFilterResponse
    {
        /// <summary>
        /// An array of advanced filters that are used for filtering event channels.
        /// </summary>
        public readonly ImmutableArray<object> AdvancedFilters;
        /// <summary>
        /// Allows advanced filters to be evaluated against an array of values instead of expecting a singular value. The default value is either false or null.
        /// </summary>
        public readonly bool? EnableAdvancedFilteringOnArrays;

        [OutputConstructor]
        private EventChannelFilterResponse(
            ImmutableArray<object> advancedFilters,

            bool? enableAdvancedFilteringOnArrays)
        {
            AdvancedFilters = advancedFilters;
            EnableAdvancedFilteringOnArrays = enableAdvancedFilteringOnArrays;
        }
    }
}
