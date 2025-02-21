// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SqlVirtualMachine.V20220201Preview.Outputs
{

    /// <summary>
    /// Set the access level and network port settings for SQL Server.
    /// </summary>
    [OutputType]
    public sealed class SqlConnectivityUpdateSettingsResponse
    {
        /// <summary>
        /// SQL Server connectivity option.
        /// </summary>
        public readonly string? ConnectivityType;
        /// <summary>
        /// SQL Server port.
        /// </summary>
        public readonly int? Port;

        [OutputConstructor]
        private SqlConnectivityUpdateSettingsResponse(
            string? connectivityType,

            int? port)
        {
            ConnectivityType = connectivityType;
            Port = port;
        }
    }
}
