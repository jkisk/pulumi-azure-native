// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SqlVirtualMachine.V20211101Preview.Inputs
{

    public sealed class SQLTempDbSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SQL Server default file count
        /// </summary>
        [Input("dataFileCount")]
        public Input<int>? DataFileCount { get; set; }

        /// <summary>
        /// SQL Server default file size
        /// </summary>
        [Input("dataFileSize")]
        public Input<int>? DataFileSize { get; set; }

        /// <summary>
        /// SQL Server default file autoGrowth size
        /// </summary>
        [Input("dataGrowth")]
        public Input<int>? DataGrowth { get; set; }

        /// <summary>
        /// SQL Server default file path
        /// </summary>
        [Input("defaultFilePath")]
        public Input<string>? DefaultFilePath { get; set; }

        /// <summary>
        /// SQL Server default file size
        /// </summary>
        [Input("logFileSize")]
        public Input<int>? LogFileSize { get; set; }

        /// <summary>
        /// SQL Server default file autoGrowth size
        /// </summary>
        [Input("logGrowth")]
        public Input<int>? LogGrowth { get; set; }

        [Input("luns")]
        private InputList<int>? _luns;

        /// <summary>
        /// Logical Unit Numbers for the disks.
        /// </summary>
        public InputList<int> Luns
        {
            get => _luns ?? (_luns = new InputList<int>());
            set => _luns = value;
        }

        public SQLTempDbSettingsArgs()
        {
        }
    }
}
