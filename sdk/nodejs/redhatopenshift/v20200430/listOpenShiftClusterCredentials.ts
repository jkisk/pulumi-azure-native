// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * OpenShiftClusterCredentials represents an OpenShift cluster's credentials
 */
export function listOpenShiftClusterCredentials(args: ListOpenShiftClusterCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<ListOpenShiftClusterCredentialsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:redhatopenshift/v20200430:listOpenShiftClusterCredentials", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface ListOpenShiftClusterCredentialsArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the OpenShift cluster resource.
     */
    resourceName: string;
}

/**
 * OpenShiftClusterCredentials represents an OpenShift cluster's credentials
 */
export interface ListOpenShiftClusterCredentialsResult {
    /**
     * The password for the kubeadmin user
     */
    readonly kubeadminPassword?: string;
    /**
     * The username for the kubeadmin user
     */
    readonly kubeadminUsername?: string;
}

export function listOpenShiftClusterCredentialsOutput(args: ListOpenShiftClusterCredentialsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListOpenShiftClusterCredentialsResult> {
    return pulumi.output(args).apply(a => listOpenShiftClusterCredentials(a, opts))
}

export interface ListOpenShiftClusterCredentialsOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the OpenShift cluster resource.
     */
    resourceName: pulumi.Input<string>;
}
