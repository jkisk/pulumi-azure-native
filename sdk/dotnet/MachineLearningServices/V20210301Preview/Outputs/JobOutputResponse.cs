// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210301Preview.Outputs
{

    /// <summary>
    /// Job output definition container information on where to find job output/logs.
    /// </summary>
    [OutputType]
    public sealed class JobOutputResponse
    {
        /// <summary>
        /// ARM ID of the datastore where the job logs and artifacts are stored, or null for the default container ("azureml") in the workspace's storage account.
        /// </summary>
        public readonly string DatastoreId;
        /// <summary>
        /// Path within the datastore to the job logs and artifacts.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private JobOutputResponse(
            string datastoreId,

            string path)
        {
            DatastoreId = datastoreId;
            Path = path;
        }
    }
}
