// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20150801.Outputs
{

    /// <summary>
    /// AutoHealActions - Describes the actions which can be
    ///             taken by the auto-heal module when a rule is triggered.
    /// </summary>
    [OutputType]
    public sealed class AutoHealActionsResponse
    {
        /// <summary>
        /// ActionType - predefined action to be taken
        /// </summary>
        public readonly string ActionType;
        /// <summary>
        /// CustomAction - custom action to be taken
        /// </summary>
        public readonly Outputs.AutoHealCustomActionResponse? CustomAction;
        /// <summary>
        /// MinProcessExecutionTime - minimum time the process must execute
        ///             before taking the action
        /// </summary>
        public readonly string? MinProcessExecutionTime;

        [OutputConstructor]
        private AutoHealActionsResponse(
            string actionType,

            Outputs.AutoHealCustomActionResponse? customAction,

            string? minProcessExecutionTime)
        {
            ActionType = actionType;
            CustomAction = customAction;
            MinProcessExecutionTime = minProcessExecutionTime;
        }
    }
}
