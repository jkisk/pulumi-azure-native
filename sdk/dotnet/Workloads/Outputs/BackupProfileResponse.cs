// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Outputs
{

    /// <summary>
    /// Backup profile
    /// </summary>
    [OutputType]
    public sealed class BackupProfileResponse
    {
        /// <summary>
        /// Whether to enable Azure backup for the workload
        /// </summary>
        public readonly string BackupEnabled;
        /// <summary>
        /// Backup vault resource Id
        /// </summary>
        public readonly string VaultResourceId;

        [OutputConstructor]
        private BackupProfileResponse(
            string backupEnabled,

            string vaultResourceId)
        {
            BackupEnabled = backupEnabled;
            VaultResourceId = vaultResourceId;
        }
    }
}
