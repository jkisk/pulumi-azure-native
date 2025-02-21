// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210401.Inputs
{

    public sealed class SparkMavenPackageArgs : Pulumi.ResourceArgs
    {
        [Input("artifact")]
        public Input<string>? Artifact { get; set; }

        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public SparkMavenPackageArgs()
        {
        }
    }
}
