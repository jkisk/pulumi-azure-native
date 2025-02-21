// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Pipeline used to configure Continuous Integration (CI) & Continuous Delivery (CD) for Azure resources.
 * API Version: 2020-07-13-preview.
 */
export class Pipeline extends pulumi.CustomResource {
    /**
     * Get an existing Pipeline resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Pipeline {
        return new Pipeline(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:devops:Pipeline';

    /**
     * Returns true if the given object is an instance of Pipeline.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Pipeline {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Pipeline.__pulumiType;
    }

    /**
     * Configuration used to bootstrap the Pipeline.
     */
    public readonly bootstrapConfiguration!: pulumi.Output<outputs.devops.BootstrapConfigurationResponse>;
    /**
     * Resource Location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource Name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Unique identifier of the Pipeline
     */
    public /*out*/ readonly pipelineId!: pulumi.Output<number>;
    /**
     * Specifies which CI/CD provider to use. Valid options are 'azurePipeline', 'githubWorkflow'.
     */
    public readonly pipelineType!: pulumi.Output<string>;
    /**
     * The system metadata pertaining to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.devops.SystemDataResponse>;
    /**
     * Resource Tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource Type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Pipeline resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PipelineArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.bootstrapConfiguration === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bootstrapConfiguration'");
            }
            if ((!args || args.pipelineType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pipelineType'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["bootstrapConfiguration"] = args ? args.bootstrapConfiguration : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["pipelineName"] = args ? args.pipelineName : undefined;
            resourceInputs["pipelineType"] = args ? args.pipelineType : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["pipelineId"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["bootstrapConfiguration"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["pipelineId"] = undefined /*out*/;
            resourceInputs["pipelineType"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:devops/v20190701preview:Pipeline" }, { type: "azure-native:devops/v20200713preview:Pipeline" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Pipeline.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Pipeline resource.
 */
export interface PipelineArgs {
    /**
     * Configuration used to bootstrap the Pipeline.
     */
    bootstrapConfiguration: pulumi.Input<inputs.devops.BootstrapConfigurationArgs>;
    /**
     * Resource Location
     */
    location?: pulumi.Input<string>;
    /**
     * The name of the Pipeline resource in ARM.
     */
    pipelineName?: pulumi.Input<string>;
    /**
     * Specifies which CI/CD provider to use. Valid options are 'azurePipeline', 'githubWorkflow'.
     */
    pipelineType: pulumi.Input<string | enums.devops.PipelineTypeEnum>;
    /**
     * Name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource Tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
