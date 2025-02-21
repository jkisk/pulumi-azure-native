// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// HDInsight Hive activity type.
    /// </summary>
    public sealed class HDInsightHiveActivityArgs : Pulumi.ResourceArgs
    {
        [Input("arguments")]
        private InputList<object>? _arguments;

        /// <summary>
        /// User specified arguments to HDInsightActivity.
        /// </summary>
        public InputList<object> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<object>());
            set => _arguments = value;
        }

        [Input("defines")]
        private InputMap<object>? _defines;

        /// <summary>
        /// Allows user to specify defines for Hive job request.
        /// </summary>
        public InputMap<object> Defines
        {
            get => _defines ?? (_defines = new InputMap<object>());
            set => _defines = value;
        }

        [Input("dependsOn")]
        private InputList<Inputs.ActivityDependencyArgs>? _dependsOn;

        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public InputList<Inputs.ActivityDependencyArgs> DependsOn
        {
            get => _dependsOn ?? (_dependsOn = new InputList<Inputs.ActivityDependencyArgs>());
            set => _dependsOn = value;
        }

        /// <summary>
        /// Activity description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Debug info option.
        /// </summary>
        [Input("getDebugInfo")]
        public InputUnion<string, Pulumi.AzureNative.DataFactory.V20180601.HDInsightActivityDebugInfoOption>? GetDebugInfo { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        /// <summary>
        /// Query timeout value (in minutes).  Effective when the HDInsight cluster is with ESP (Enterprise Security Package)
        /// </summary>
        [Input("queryTimeout")]
        public Input<int>? QueryTimeout { get; set; }

        /// <summary>
        /// Script linked service reference.
        /// </summary>
        [Input("scriptLinkedService")]
        public Input<Inputs.LinkedServiceReferenceArgs>? ScriptLinkedService { get; set; }

        /// <summary>
        /// Script path. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("scriptPath")]
        public Input<object>? ScriptPath { get; set; }

        [Input("storageLinkedServices")]
        private InputList<Inputs.LinkedServiceReferenceArgs>? _storageLinkedServices;

        /// <summary>
        /// Storage linked service references.
        /// </summary>
        public InputList<Inputs.LinkedServiceReferenceArgs> StorageLinkedServices
        {
            get => _storageLinkedServices ?? (_storageLinkedServices = new InputList<Inputs.LinkedServiceReferenceArgs>());
            set => _storageLinkedServices = value;
        }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'HDInsightHive'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("userProperties")]
        private InputList<Inputs.UserPropertyArgs>? _userProperties;

        /// <summary>
        /// Activity user properties.
        /// </summary>
        public InputList<Inputs.UserPropertyArgs> UserProperties
        {
            get => _userProperties ?? (_userProperties = new InputList<Inputs.UserPropertyArgs>());
            set => _userProperties = value;
        }

        [Input("variables")]
        private InputList<object>? _variables;

        /// <summary>
        /// User specified arguments under hivevar namespace.
        /// </summary>
        public InputList<object> Variables
        {
            get => _variables ?? (_variables = new InputList<object>());
            set => _variables = value;
        }

        public HDInsightHiveActivityArgs()
        {
        }
    }
}
