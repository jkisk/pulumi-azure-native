// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventGrid.V20180915Preview.Outputs
{

    /// <summary>
    /// StringBeginsWith Filter
    /// </summary>
    [OutputType]
    public sealed class StringBeginsWithAdvancedFilterResponse
    {
        /// <summary>
        /// The filter key. Represents an event property with up to two levels of nesting.
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// Represents the filter operator
        /// Expected value is 'StringBeginsWith'.
        /// </summary>
        public readonly string OperatorType;
        /// <summary>
        /// The set of filter values
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private StringBeginsWithAdvancedFilterResponse(
            string? key,

            string operatorType,

            ImmutableArray<string> values)
        {
            Key = key;
            OperatorType = operatorType;
            Values = values;
        }
    }
}
