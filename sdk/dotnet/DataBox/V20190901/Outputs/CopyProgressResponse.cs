// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataBox.V20190901.Outputs
{

    /// <summary>
    /// Copy progress.
    /// </summary>
    [OutputType]
    public sealed class CopyProgressResponse
    {
        /// <summary>
        /// Id of the account where the data needs to be uploaded.
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// Amount of data uploaded by the job as of now.
        /// </summary>
        public readonly double BytesSentToCloud;
        /// <summary>
        /// Data Destination Type.
        /// </summary>
        public readonly string DataDestinationType;
        /// <summary>
        /// Number of files which could not be copied
        /// </summary>
        public readonly double FilesErroredOut;
        /// <summary>
        /// Number of files processed by the job as of now.
        /// </summary>
        public readonly double FilesProcessed;
        /// <summary>
        /// Total amount of data not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        public readonly double InvalidFileBytesUploaded;
        /// <summary>
        /// Number of files not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        public readonly double InvalidFilesProcessed;
        /// <summary>
        /// Number of folders not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        public readonly double RenamedContainerCount;
        /// <summary>
        /// Name of the storage account where the data needs to be uploaded.
        /// </summary>
        public readonly string StorageAccountName;
        /// <summary>
        /// Total amount of data to be processed by the job.
        /// </summary>
        public readonly double TotalBytesToProcess;
        /// <summary>
        /// Total number of files to be processed by the job.
        /// </summary>
        public readonly double TotalFilesToProcess;

        [OutputConstructor]
        private CopyProgressResponse(
            string accountId,

            double bytesSentToCloud,

            string dataDestinationType,

            double filesErroredOut,

            double filesProcessed,

            double invalidFileBytesUploaded,

            double invalidFilesProcessed,

            double renamedContainerCount,

            string storageAccountName,

            double totalBytesToProcess,

            double totalFilesToProcess)
        {
            AccountId = accountId;
            BytesSentToCloud = bytesSentToCloud;
            DataDestinationType = dataDestinationType;
            FilesErroredOut = filesErroredOut;
            FilesProcessed = filesProcessed;
            InvalidFileBytesUploaded = invalidFileBytesUploaded;
            InvalidFilesProcessed = invalidFilesProcessed;
            RenamedContainerCount = renamedContainerCount;
            StorageAccountName = storageAccountName;
            TotalBytesToProcess = totalBytesToProcess;
            TotalFilesToProcess = totalFilesToProcess;
        }
    }
}
