// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Trigger resource type.
 */
/** @deprecated Version 2017-09-01-preview will be removed in v2 of the provider. */
export function getTrigger(args: GetTriggerArgs, opts?: pulumi.InvokeOptions): Promise<GetTriggerResult> {
    pulumi.log.warn("getTrigger is deprecated: Version 2017-09-01-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datafactory/v20170901preview:getTrigger", {
        "factoryName": args.factoryName,
        "resourceGroupName": args.resourceGroupName,
        "triggerName": args.triggerName,
    }, opts);
}

export interface GetTriggerArgs {
    /**
     * The factory name.
     */
    factoryName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
    /**
     * The trigger name.
     */
    triggerName: string;
}

/**
 * Trigger resource type.
 */
export interface GetTriggerResult {
    /**
     * Etag identifies change in the resource.
     */
    readonly etag: string;
    /**
     * The resource identifier.
     */
    readonly id: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * Properties of the trigger.
     */
    readonly properties: outputs.datafactory.v20170901preview.BlobEventsTriggerResponse | outputs.datafactory.v20170901preview.BlobTriggerResponse | outputs.datafactory.v20170901preview.MultiplePipelineTriggerResponse | outputs.datafactory.v20170901preview.ScheduleTriggerResponse | outputs.datafactory.v20170901preview.TumblingWindowTriggerResponse;
    /**
     * The resource type.
     */
    readonly type: string;
}

export function getTriggerOutput(args: GetTriggerOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTriggerResult> {
    return pulumi.output(args).apply(a => getTrigger(a, opts))
}

export interface GetTriggerOutputArgs {
    /**
     * The factory name.
     */
    factoryName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The trigger name.
     */
    triggerName: pulumi.Input<string>;
}
