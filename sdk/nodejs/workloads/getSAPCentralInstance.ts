// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Define the SAP Central Server Instance.
 * API Version: 2021-12-01-preview.
 */
export function getSAPCentralInstance(args: GetSAPCentralInstanceArgs, opts?: pulumi.InvokeOptions): Promise<GetSAPCentralInstanceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:workloads:getSAPCentralInstance", {
        "centralInstanceName": args.centralInstanceName,
        "resourceGroupName": args.resourceGroupName,
        "sapVirtualInstanceName": args.sapVirtualInstanceName,
    }, opts);
}

export interface GetSAPCentralInstanceArgs {
    /**
     * Central Instance name string modeled as parameter for auto generation to work correctly.
     */
    centralInstanceName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the Virtual Instances for SAP.
     */
    sapVirtualInstanceName: string;
}

/**
 * Define the SAP Central Server Instance.
 */
export interface GetSAPCentralInstanceResult {
    /**
     * Defines the SAP ERS Server properties.
     */
    readonly enqueueReplicationServerProperties?: outputs.workloads.EnqueueReplicationServerPropertiesResponse;
    /**
     * Defines the SAP enqueue server properties.
     */
    readonly enqueueServerProperties?: outputs.workloads.EnqueueServerPropertiesResponse;
    /**
     * Defines the Central Instance errors.
     */
    readonly errors: outputs.workloads.SAPVirtualInstanceErrorResponse;
    /**
     * Defines the SAP Gateway Server properties.
     */
    readonly gatewayServerProperties?: outputs.workloads.GatewayServerPropertiesResponse;
    /**
     * Defines the SAP Instance health.
     */
    readonly health: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The central server instance id.
     */
    readonly instanceNo: string;
    /**
     * The central server kernel patch.
     */
    readonly kernelPatch: string;
    /**
     * The central server kernel version.
     */
    readonly kernelVersion: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * Defines the SAP message server properties.
     */
    readonly messageServerProperties?: outputs.workloads.MessageServerPropertiesResponse;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Defines the provisioning states.
     */
    readonly provisioningState: string;
    /**
     * Defines the SAP Instance status.
     */
    readonly status: string;
    /**
     * The central server subnet.
     */
    readonly subnet: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.workloads.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
    /**
     * The list of virtual machines.
     */
    readonly vmDetails: outputs.workloads.CentralServerVmDetailsResponse[];
}

export function getSAPCentralInstanceOutput(args: GetSAPCentralInstanceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSAPCentralInstanceResult> {
    return pulumi.output(args).apply(a => getSAPCentralInstance(a, opts))
}

export interface GetSAPCentralInstanceOutputArgs {
    /**
     * Central Instance name string modeled as parameter for auto generation to work correctly.
     */
    centralInstanceName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Virtual Instances for SAP.
     */
    sapVirtualInstanceName: pulumi.Input<string>;
}
