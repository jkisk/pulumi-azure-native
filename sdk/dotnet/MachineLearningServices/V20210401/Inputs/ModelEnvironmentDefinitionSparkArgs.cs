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
    /// The configuration for a Spark environment.
    /// </summary>
    public sealed class ModelEnvironmentDefinitionSparkArgs : Pulumi.ResourceArgs
    {
        [Input("packages")]
        private InputList<Inputs.SparkMavenPackageArgs>? _packages;

        /// <summary>
        /// The Spark packages to use.
        /// </summary>
        public InputList<Inputs.SparkMavenPackageArgs> Packages
        {
            get => _packages ?? (_packages = new InputList<Inputs.SparkMavenPackageArgs>());
            set => _packages = value;
        }

        /// <summary>
        /// Whether to precache the packages.
        /// </summary>
        [Input("precachePackages")]
        public Input<bool>? PrecachePackages { get; set; }

        [Input("repositories")]
        private InputList<string>? _repositories;

        /// <summary>
        /// The list of spark repositories.
        /// </summary>
        public InputList<string> Repositories
        {
            get => _repositories ?? (_repositories = new InputList<string>());
            set => _repositories = value;
        }

        public ModelEnvironmentDefinitionSparkArgs()
        {
        }
    }
}
