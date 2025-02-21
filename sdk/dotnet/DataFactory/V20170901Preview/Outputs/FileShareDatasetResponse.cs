// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20170901Preview.Outputs
{

    /// <summary>
    /// An on-premises file system dataset.
    /// </summary>
    [OutputType]
    public sealed class FileShareDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The data compression method used for the file system.
        /// </summary>
        public readonly object? Compression;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileFilter;
        /// <summary>
        /// The name of the on-premises file system. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileName;
        /// <summary>
        /// The path of the on-premises file system. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FolderPath;
        /// <summary>
        /// The format of the files.
        /// </summary>
        public readonly object? Format;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        public readonly object? Structure;
        /// <summary>
        /// Type of dataset.
        /// Expected value is 'FileShare'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private FileShareDatasetResponse(
            ImmutableArray<object> annotations,

            object? compression,

            string? description,

            object? fileFilter,

            object? fileName,

            object? folderPath,

            object? format,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object? structure,

            string type)
        {
            Annotations = annotations;
            Compression = compression;
            Description = description;
            FileFilter = fileFilter;
            FileName = fileName;
            FolderPath = folderPath;
            Format = format;
            LinkedServiceName = linkedServiceName;
            Parameters = parameters;
            Structure = structure;
            Type = type;
        }
    }
}
