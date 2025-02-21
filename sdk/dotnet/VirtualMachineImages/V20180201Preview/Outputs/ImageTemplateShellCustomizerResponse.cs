// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.VirtualMachineImages.V20180201Preview.Outputs
{

    /// <summary>
    /// Runs a shell script during the customization phase
    /// </summary>
    [OutputType]
    public sealed class ImageTemplateShellCustomizerResponse
    {
        /// <summary>
        /// Friendly Name to provide context on what this customization step does
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The shell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        /// </summary>
        public readonly string? Script;
        /// <summary>
        /// The type of customization tool you want to use on the Image. For example, "shell" can be shellCustomizer
        /// Expected value is 'shell'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ImageTemplateShellCustomizerResponse(
            string? name,

            string? script,

            string type)
        {
            Name = name;
            Script = script;
            Type = type;
        }
    }
}
