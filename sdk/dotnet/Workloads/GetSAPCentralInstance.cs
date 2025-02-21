// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads
{
    public static class GetSAPCentralInstance
    {
        /// <summary>
        /// Define the SAP Central Server Instance.
        /// API Version: 2021-12-01-preview.
        /// </summary>
        public static Task<GetSAPCentralInstanceResult> InvokeAsync(GetSAPCentralInstanceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSAPCentralInstanceResult>("azure-native:workloads:getSAPCentralInstance", args ?? new GetSAPCentralInstanceArgs(), options.WithDefaults());

        /// <summary>
        /// Define the SAP Central Server Instance.
        /// API Version: 2021-12-01-preview.
        /// </summary>
        public static Output<GetSAPCentralInstanceResult> Invoke(GetSAPCentralInstanceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSAPCentralInstanceResult>("azure-native:workloads:getSAPCentralInstance", args ?? new GetSAPCentralInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSAPCentralInstanceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Central Instance name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Input("centralInstanceName", required: true)]
        public string CentralInstanceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Instances for SAP.
        /// </summary>
        [Input("sapVirtualInstanceName", required: true)]
        public string SapVirtualInstanceName { get; set; } = null!;

        public GetSAPCentralInstanceArgs()
        {
        }
    }

    public sealed class GetSAPCentralInstanceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Central Instance name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Input("centralInstanceName", required: true)]
        public Input<string> CentralInstanceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Instances for SAP.
        /// </summary>
        [Input("sapVirtualInstanceName", required: true)]
        public Input<string> SapVirtualInstanceName { get; set; } = null!;

        public GetSAPCentralInstanceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSAPCentralInstanceResult
    {
        /// <summary>
        /// Defines the SAP ERS Server properties.
        /// </summary>
        public readonly Outputs.EnqueueReplicationServerPropertiesResponse? EnqueueReplicationServerProperties;
        /// <summary>
        /// Defines the SAP enqueue server properties.
        /// </summary>
        public readonly Outputs.EnqueueServerPropertiesResponse? EnqueueServerProperties;
        /// <summary>
        /// Defines the Central Instance errors.
        /// </summary>
        public readonly Outputs.SAPVirtualInstanceErrorResponse Errors;
        /// <summary>
        /// Defines the SAP Gateway Server properties.
        /// </summary>
        public readonly Outputs.GatewayServerPropertiesResponse? GatewayServerProperties;
        /// <summary>
        /// Defines the SAP Instance health.
        /// </summary>
        public readonly string Health;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The central server instance id.
        /// </summary>
        public readonly string InstanceNo;
        /// <summary>
        /// The central server kernel patch.
        /// </summary>
        public readonly string KernelPatch;
        /// <summary>
        /// The central server kernel version.
        /// </summary>
        public readonly string KernelVersion;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Defines the SAP message server properties.
        /// </summary>
        public readonly Outputs.MessageServerPropertiesResponse? MessageServerProperties;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the provisioning states.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Defines the SAP Instance status.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The central server subnet.
        /// </summary>
        public readonly string Subnet;
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The list of virtual machines.
        /// </summary>
        public readonly ImmutableArray<Outputs.CentralServerVmDetailsResponse> VmDetails;

        [OutputConstructor]
        private GetSAPCentralInstanceResult(
            Outputs.EnqueueReplicationServerPropertiesResponse? enqueueReplicationServerProperties,

            Outputs.EnqueueServerPropertiesResponse? enqueueServerProperties,

            Outputs.SAPVirtualInstanceErrorResponse errors,

            Outputs.GatewayServerPropertiesResponse? gatewayServerProperties,

            string health,

            string id,

            string instanceNo,

            string kernelPatch,

            string kernelVersion,

            string location,

            Outputs.MessageServerPropertiesResponse? messageServerProperties,

            string name,

            string provisioningState,

            string status,

            string subnet,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<Outputs.CentralServerVmDetailsResponse> vmDetails)
        {
            EnqueueReplicationServerProperties = enqueueReplicationServerProperties;
            EnqueueServerProperties = enqueueServerProperties;
            Errors = errors;
            GatewayServerProperties = gatewayServerProperties;
            Health = health;
            Id = id;
            InstanceNo = instanceNo;
            KernelPatch = kernelPatch;
            KernelVersion = kernelVersion;
            Location = location;
            MessageServerProperties = messageServerProperties;
            Name = name;
            ProvisioningState = provisioningState;
            Status = status;
            Subnet = subnet;
            SystemData = systemData;
            Tags = tags;
            Type = type;
            VmDetails = vmDetails;
        }
    }
}
