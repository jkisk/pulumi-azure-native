// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The SourceControl Configuration object.
 */
/** @deprecated Version 2019-11-01-preview will be removed in v2 of the provider. */
export function getSourceControlConfiguration(args: GetSourceControlConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetSourceControlConfigurationResult> {
    pulumi.log.warn("getSourceControlConfiguration is deprecated: Version 2019-11-01-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:kubernetesconfiguration/v20191101preview:getSourceControlConfiguration", {
        "clusterName": args.clusterName,
        "clusterResourceName": args.clusterResourceName,
        "clusterRp": args.clusterRp,
        "resourceGroupName": args.resourceGroupName,
        "sourceControlConfigurationName": args.sourceControlConfigurationName,
    }, opts);
}

export interface GetSourceControlConfigurationArgs {
    /**
     * The name of the kubernetes cluster.
     */
    clusterName: string;
    /**
     * The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
     */
    clusterResourceName: string;
    /**
     * The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
     */
    clusterRp: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * Name of the Source Control Configuration.
     */
    sourceControlConfigurationName: string;
}

/**
 * The SourceControl Configuration object.
 */
export interface GetSourceControlConfigurationResult {
    /**
     * Compliance Status of the Configuration
     */
    readonly complianceStatus: outputs.kubernetesconfiguration.v20191101preview.ComplianceStatusResponse;
    /**
     * Option to enable Helm Operator for this git configuration.
     */
    readonly enableHelmOperator?: string;
    /**
     * Properties for Helm operator.
     */
    readonly helmOperatorProperties?: outputs.kubernetesconfiguration.v20191101preview.HelmOperatorPropertiesResponse;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Instance name of the operator - identifying the specific configuration.
     */
    readonly operatorInstanceName?: string;
    /**
     * The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
     */
    readonly operatorNamespace?: string;
    /**
     * Any Parameters for the Operator instance in string format.
     */
    readonly operatorParams?: string;
    /**
     * Scope at which the operator will be installed.
     */
    readonly operatorScope?: string;
    /**
     * Type of the operator
     */
    readonly operatorType?: string;
    /**
     * The provisioning state of the resource provider.
     */
    readonly provisioningState: string;
    /**
     * Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user).
     */
    readonly repositoryPublicKey: string;
    /**
     * Url of the SourceControl Repository.
     */
    readonly repositoryUrl?: string;
    /**
     * Resource type
     */
    readonly type: string;
}

export function getSourceControlConfigurationOutput(args: GetSourceControlConfigurationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSourceControlConfigurationResult> {
    return pulumi.output(args).apply(a => getSourceControlConfiguration(a, opts))
}

export interface GetSourceControlConfigurationOutputArgs {
    /**
     * The name of the kubernetes cluster.
     */
    clusterName: pulumi.Input<string>;
    /**
     * The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
     */
    clusterResourceName: pulumi.Input<string>;
    /**
     * The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
     */
    clusterRp: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the Source Control Configuration.
     */
    sourceControlConfigurationName: pulumi.Input<string>;
}
