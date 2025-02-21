// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorageCache.V20200301.Outputs
{

    /// <summary>
    /// A namespace junction.
    /// </summary>
    [OutputType]
    public sealed class NamespaceJunctionResponse
    {
        /// <summary>
        /// Namespace path on a Cache for a Storage Target.
        /// </summary>
        public readonly string? NamespacePath;
        /// <summary>
        /// NFS export where targetPath exists.
        /// </summary>
        public readonly string? NfsExport;
        /// <summary>
        /// Path in Storage Target to which namespacePath points.
        /// </summary>
        public readonly string? TargetPath;

        [OutputConstructor]
        private NamespaceJunctionResponse(
            string? namespacePath,

            string? nfsExport,

            string? targetPath)
        {
            NamespacePath = namespacePath;
            NfsExport = nfsExport;
            TargetPath = targetPath;
        }
    }
}
