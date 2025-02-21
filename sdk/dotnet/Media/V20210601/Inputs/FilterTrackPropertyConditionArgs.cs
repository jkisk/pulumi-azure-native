// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20210601.Inputs
{

    /// <summary>
    /// The class to specify one track property condition.
    /// </summary>
    public sealed class FilterTrackPropertyConditionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The track property condition operation.
        /// </summary>
        [Input("operation", required: true)]
        public InputUnion<string, Pulumi.AzureNative.Media.V20210601.FilterTrackPropertyCompareOperation> Operation { get; set; } = null!;

        /// <summary>
        /// The track property type.
        /// </summary>
        [Input("property", required: true)]
        public InputUnion<string, Pulumi.AzureNative.Media.V20210601.FilterTrackPropertyType> Property { get; set; } = null!;

        /// <summary>
        /// The track property value.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public FilterTrackPropertyConditionArgs()
        {
        }
    }
}
