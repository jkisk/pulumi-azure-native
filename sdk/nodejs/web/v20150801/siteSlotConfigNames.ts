// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Slot Config names azure resource
 *
 * @deprecated Version 2015-08-01 will be removed in v2 of the provider.
 */
export class SiteSlotConfigNames extends pulumi.CustomResource {
    /**
     * Get an existing SiteSlotConfigNames resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SiteSlotConfigNames {
        pulumi.log.warn("SiteSlotConfigNames is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        return new SiteSlotConfigNames(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:web/v20150801:SiteSlotConfigNames';

    /**
     * Returns true if the given object is an instance of SiteSlotConfigNames.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteSlotConfigNames {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteSlotConfigNames.__pulumiType;
    }

    /**
     * List of application settings names
     */
    public readonly appSettingNames!: pulumi.Output<string[] | undefined>;
    /**
     * List of connection string names
     */
    public readonly connectionStringNames!: pulumi.Output<string[] | undefined>;
    /**
     * Kind of resource
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a SiteSlotConfigNames resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-08-01 will be removed in v2 of the provider. */
    constructor(name: string, args: SiteSlotConfigNamesArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("SiteSlotConfigNames is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["appSettingNames"] = args ? args.appSettingNames : undefined;
            resourceInputs["connectionStringNames"] = args ? args.connectionStringNames : undefined;
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
        } else {
            resourceInputs["appSettingNames"] = undefined /*out*/;
            resourceInputs["connectionStringNames"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:web:SiteSlotConfigNames" }, { type: "azure-native:web/v20160801:SiteSlotConfigNames" }, { type: "azure-native:web/v20180201:SiteSlotConfigNames" }, { type: "azure-native:web/v20181101:SiteSlotConfigNames" }, { type: "azure-native:web/v20190801:SiteSlotConfigNames" }, { type: "azure-native:web/v20200601:SiteSlotConfigNames" }, { type: "azure-native:web/v20200901:SiteSlotConfigNames" }, { type: "azure-native:web/v20201001:SiteSlotConfigNames" }, { type: "azure-native:web/v20201201:SiteSlotConfigNames" }, { type: "azure-native:web/v20210101:SiteSlotConfigNames" }, { type: "azure-native:web/v20210115:SiteSlotConfigNames" }, { type: "azure-native:web/v20210201:SiteSlotConfigNames" }, { type: "azure-native:web/v20210301:SiteSlotConfigNames" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(SiteSlotConfigNames.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a SiteSlotConfigNames resource.
 */
export interface SiteSlotConfigNamesArgs {
    /**
     * List of application settings names
     */
    appSettingNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * List of connection string names
     */
    connectionStringNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Resource Id
     */
    id?: pulumi.Input<string>;
    /**
     * Kind of resource
     */
    kind?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    location?: pulumi.Input<string>;
    /**
     * Resource Name
     */
    name: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    type?: pulumi.Input<string>;
}
