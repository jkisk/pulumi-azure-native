// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20180801Preview.Outputs
{

    /// <summary>
    /// Profile for the container service agent pool.
    /// </summary>
    [OutputType]
    public sealed class ManagedClusterAgentPoolProfileResponse
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. 
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// Whether to enable auto-scaler
        /// </summary>
        public readonly bool? EnableAutoScaling;
        /// <summary>
        /// Maximum number of nodes for auto-scaling
        /// </summary>
        public readonly int? MaxCount;
        /// <summary>
        /// Maximum number of pods that can run on a node.
        /// </summary>
        public readonly int? MaxPods;
        /// <summary>
        /// Minimum number of nodes for auto-scaling
        /// </summary>
        public readonly int? MinCount;
        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// OS Disk Size in GB to be used to specify the disk size for every machine in this master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified.
        /// </summary>
        public readonly int? OsDiskSizeGB;
        /// <summary>
        /// OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// AgentPoolType represents types of an agent pool
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Size of agent VMs.
        /// </summary>
        public readonly string VmSize;
        /// <summary>
        /// VNet SubnetID specifies the VNet's subnet identifier.
        /// </summary>
        public readonly string? VnetSubnetID;

        [OutputConstructor]
        private ManagedClusterAgentPoolProfileResponse(
            int count,

            bool? enableAutoScaling,

            int? maxCount,

            int? maxPods,

            int? minCount,

            string name,

            int? osDiskSizeGB,

            string? osType,

            string? type,

            string vmSize,

            string? vnetSubnetID)
        {
            Count = count;
            EnableAutoScaling = enableAutoScaling;
            MaxCount = maxCount;
            MaxPods = maxPods;
            MinCount = minCount;
            Name = name;
            OsDiskSizeGB = osDiskSizeGB;
            OsType = osType;
            Type = type;
            VmSize = vmSize;
            VnetSubnetID = vnetSubnetID;
        }
    }
}
