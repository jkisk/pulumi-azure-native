// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210401.Inputs
{

    /// <summary>
    /// The unique identifying details of the AZURE ML environment.
    /// </summary>
    public sealed class EnvironmentImageRequestEnvironmentReferenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the environment.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Version of the environment.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public EnvironmentImageRequestEnvironmentReferenceArgs()
        {
        }
    }
}
