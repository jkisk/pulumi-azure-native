// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridData.V20160601.Inputs
{

    /// <summary>
    /// The sku type.
    /// </summary>
    public sealed class SkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The sku name. Required for data manager creation, optional for update.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The sku tier. This is based on the SKU name.
        /// </summary>
        [Input("tier")]
        public Input<string>? Tier { get; set; }

        public SkuArgs()
        {
        }
    }
}
