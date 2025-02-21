// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20210401.Inputs
{

    /// <summary>
    /// Definition of which streams are sent to which destinations.
    /// </summary>
    public sealed class DataFlowArgs : Pulumi.ResourceArgs
    {
        [Input("destinations")]
        private InputList<string>? _destinations;

        /// <summary>
        /// List of destinations for this data flow.
        /// </summary>
        public InputList<string> Destinations
        {
            get => _destinations ?? (_destinations = new InputList<string>());
            set => _destinations = value;
        }

        [Input("streams")]
        private InputList<Union<string, Pulumi.AzureNative.Insights.V20210401.KnownDataFlowStreams>>? _streams;

        /// <summary>
        /// List of streams for this data flow.
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.Insights.V20210401.KnownDataFlowStreams>> Streams
        {
            get => _streams ?? (_streams = new InputList<Union<string, Pulumi.AzureNative.Insights.V20210401.KnownDataFlowStreams>>());
            set => _streams = value;
        }

        public DataFlowArgs()
        {
        }
    }
}
