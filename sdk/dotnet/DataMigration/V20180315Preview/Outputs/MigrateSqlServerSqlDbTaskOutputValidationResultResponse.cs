// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataMigration.V20180315Preview.Outputs
{

    /// <summary>
    /// Validation result for Sql Server to Azure Sql DB migration.
    /// </summary>
    [OutputType]
    public sealed class MigrateSqlServerSqlDbTaskOutputValidationResultResponse
    {
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Result type
        /// Expected value is 'MigrationValidationOutput'.
        /// </summary>
        public readonly string ResultType;

        [OutputConstructor]
        private MigrateSqlServerSqlDbTaskOutputValidationResultResponse(
            string id,

            string resultType)
        {
            Id = id;
            ResultType = resultType;
        }
    }
}
