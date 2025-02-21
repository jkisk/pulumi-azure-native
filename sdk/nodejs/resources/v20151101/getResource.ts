// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Resource information.
 */
/** @deprecated Version 2015-11-01 will be removed in v2 of the provider. */
export function getResource(args: GetResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetResourceResult> {
    pulumi.log.warn("getResource is deprecated: Version 2015-11-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:resources/v20151101:getResource", {
        "parentResourcePath": args.parentResourcePath,
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
        "resourceProviderNamespace": args.resourceProviderNamespace,
        "resourceType": args.resourceType,
    }, opts);
}

export interface GetResourceArgs {
    /**
     * Resource identity.
     */
    parentResourcePath: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * Resource identity.
     */
    resourceName: string;
    /**
     * Resource identity.
     */
    resourceProviderNamespace: string;
    /**
     * Resource identity.
     */
    resourceType: string;
}

/**
 * Resource information.
 */
export interface GetResourceResult {
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Gets or sets the plan of the resource.
     */
    readonly plan?: outputs.resources.v20151101.PlanResponse;
    /**
     * Gets or sets the resource properties.
     */
    readonly properties: any;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

export function getResourceOutput(args: GetResourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetResourceResult> {
    return pulumi.output(args).apply(a => getResource(a, opts))
}

export interface GetResourceOutputArgs {
    /**
     * Resource identity.
     */
    parentResourcePath: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource identity.
     */
    resourceName: pulumi.Input<string>;
    /**
     * Resource identity.
     */
    resourceProviderNamespace: pulumi.Input<string>;
    /**
     * Resource identity.
     */
    resourceType: pulumi.Input<string>;
}
