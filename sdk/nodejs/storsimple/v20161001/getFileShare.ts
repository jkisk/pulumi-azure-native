// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * The File Share.
 */
/** @deprecated Version 2016-10-01 will be removed in v2 of the provider. */
export function getFileShare(args: GetFileShareArgs, opts?: pulumi.InvokeOptions): Promise<GetFileShareResult> {
    pulumi.log.warn("getFileShare is deprecated: Version 2016-10-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:storsimple/v20161001:getFileShare", {
        "deviceName": args.deviceName,
        "fileServerName": args.fileServerName,
        "managerName": args.managerName,
        "resourceGroupName": args.resourceGroupName,
        "shareName": args.shareName,
    }, opts);
}

export interface GetFileShareArgs {
    /**
     * The device name.
     */
    deviceName: string;
    /**
     * The file server name.
     */
    fileServerName: string;
    /**
     * The manager name
     */
    managerName: string;
    /**
     * The resource group name
     */
    resourceGroupName: string;
    /**
     * The file share name.
     */
    shareName: string;
}

/**
 * The File Share.
 */
export interface GetFileShareResult {
    /**
     * The user/group who will have full permission in this share. Active directory email address. Example: xyz@contoso.com or Contoso\xyz.
     */
    readonly adminUser: string;
    /**
     * The data policy
     */
    readonly dataPolicy: string;
    /**
     * Description for file share
     */
    readonly description?: string;
    /**
     * The identifier.
     */
    readonly id: string;
    /**
     * The local used capacity in Bytes.
     */
    readonly localUsedCapacityInBytes: number;
    /**
     * The monitoring status
     */
    readonly monitoringStatus: string;
    /**
     * The name.
     */
    readonly name: string;
    /**
     * The total provisioned capacity in Bytes
     */
    readonly provisionedCapacityInBytes: number;
    /**
     * The Share Status
     */
    readonly shareStatus: string;
    /**
     * The type.
     */
    readonly type: string;
    /**
     * The used capacity in Bytes.
     */
    readonly usedCapacityInBytes: number;
}

export function getFileShareOutput(args: GetFileShareOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFileShareResult> {
    return pulumi.output(args).apply(a => getFileShare(a, opts))
}

export interface GetFileShareOutputArgs {
    /**
     * The device name.
     */
    deviceName: pulumi.Input<string>;
    /**
     * The file server name.
     */
    fileServerName: pulumi.Input<string>;
    /**
     * The manager name
     */
    managerName: pulumi.Input<string>;
    /**
     * The resource group name
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The file share name.
     */
    shareName: pulumi.Input<string>;
}
