// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataMigration.V20180331Preview.Outputs
{

    /// <summary>
    /// Input for the task that validates connection to SQL Server and also validates source server requirements
    /// </summary>
    [OutputType]
    public sealed class ConnectToSourceSqlServerTaskInputResponse
    {
        /// <summary>
        /// Permission group for validations
        /// </summary>
        public readonly string? CheckPermissionsGroup;
        /// <summary>
        /// Flag for whether to collect agent jobs from source server.
        /// </summary>
        public readonly bool? CollectAgentJobs;
        /// <summary>
        /// Flag for whether to collect logins from source server.
        /// </summary>
        public readonly bool? CollectLogins;
        /// <summary>
        /// Connection information for Source SQL Server
        /// </summary>
        public readonly Outputs.SqlConnectionInfoResponse SourceConnectionInfo;

        [OutputConstructor]
        private ConnectToSourceSqlServerTaskInputResponse(
            string? checkPermissionsGroup,

            bool? collectAgentJobs,

            bool? collectLogins,

            Outputs.SqlConnectionInfoResponse sourceConnectionInfo)
        {
            CheckPermissionsGroup = checkPermissionsGroup;
            CollectAgentJobs = collectAgentJobs;
            CollectLogins = collectLogins;
            SourceConnectionInfo = sourceConnectionInfo;
        }
    }
}
