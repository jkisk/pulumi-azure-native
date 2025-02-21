// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DevTestLab.Inputs
{

    /// <summary>
    /// An event to be notified for.
    /// </summary>
    public sealed class EventArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The event type for which this notification is enabled (i.e. AutoShutdown, Cost)
        /// </summary>
        [Input("eventName")]
        public InputUnion<string, Pulumi.AzureNative.DevTestLab.NotificationChannelEventType>? EventName { get; set; }

        public EventArgs()
        {
        }
    }
}
