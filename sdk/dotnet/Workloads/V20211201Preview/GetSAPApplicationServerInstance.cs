// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.V20211201Preview
{
    public static class GetSAPApplicationServerInstance
    {
        /// <summary>
        /// Define the SAP Application Server Instance.
        /// </summary>
        public static Task<GetSAPApplicationServerInstanceResult> InvokeAsync(GetSAPApplicationServerInstanceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSAPApplicationServerInstanceResult>("azure-native:workloads/v20211201preview:getSAPApplicationServerInstance", args ?? new GetSAPApplicationServerInstanceArgs(), options.WithDefaults());

        /// <summary>
        /// Define the SAP Application Server Instance.
        /// </summary>
        public static Output<GetSAPApplicationServerInstanceResult> Invoke(GetSAPApplicationServerInstanceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSAPApplicationServerInstanceResult>("azure-native:workloads/v20211201preview:getSAPApplicationServerInstance", args ?? new GetSAPApplicationServerInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSAPApplicationServerInstanceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of SAP Application Server instance.
        /// </summary>
        [Input("applicationInstanceName", required: true)]
        public string ApplicationInstanceName { get; set; } = null!;

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

        public GetSAPApplicationServerInstanceArgs()
        {
        }
    }

    public sealed class GetSAPApplicationServerInstanceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of SAP Application Server instance.
        /// </summary>
        [Input("applicationInstanceName", required: true)]
        public Input<string> ApplicationInstanceName { get; set; } = null!;

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

        public GetSAPApplicationServerInstanceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSAPApplicationServerInstanceResult
    {
        /// <summary>
        /// Defines the Application Instance errors.
        /// </summary>
        public readonly Outputs.SAPVirtualInstanceErrorResponse Errors;
        /// <summary>
        /// The application server gateway Port.
        /// </summary>
        public readonly double GatewayPort;
        /// <summary>
        /// Defines the SAP Instance health.
        /// </summary>
        public readonly string Health;
        /// <summary>
        /// The application server SAP host name.
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// The application server ICM HTTP Port.
        /// </summary>
        public readonly double IcmHttpPort;
        /// <summary>
        /// The application server ICM HTTPS Port.
        /// </summary>
        public readonly double IcmHttpsPort;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The application server instance id.
        /// </summary>
        public readonly string InstanceNo;
        /// <summary>
        /// The application server SAP IP Address.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// The application server SAP kernel patch.
        /// </summary>
        public readonly string KernelPatch;
        /// <summary>
        /// The application server SAP kernel version.
        /// </summary>
        public readonly string KernelVersion;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
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
        /// The application server subnet.
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
        /// The virtual machine.
        /// </summary>
        public readonly string VirtualMachineId;

        [OutputConstructor]
        private GetSAPApplicationServerInstanceResult(
            Outputs.SAPVirtualInstanceErrorResponse errors,

            double gatewayPort,

            string health,

            string hostname,

            double icmHttpPort,

            double icmHttpsPort,

            string id,

            string instanceNo,

            string ipAddress,

            string kernelPatch,

            string kernelVersion,

            string location,

            string name,

            string provisioningState,

            string status,

            string subnet,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type,

            string virtualMachineId)
        {
            Errors = errors;
            GatewayPort = gatewayPort;
            Health = health;
            Hostname = hostname;
            IcmHttpPort = icmHttpPort;
            IcmHttpsPort = icmHttpsPort;
            Id = id;
            InstanceNo = instanceNo;
            IpAddress = ipAddress;
            KernelPatch = kernelPatch;
            KernelVersion = kernelVersion;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Status = status;
            Subnet = subnet;
            SystemData = systemData;
            Tags = tags;
            Type = type;
            VirtualMachineId = virtualMachineId;
        }
    }
}
