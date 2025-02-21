// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Certificate signing request object
 *
 * @deprecated Version 2015-08-01 will be removed in v2 of the provider.
 */
export class CertificateCsr extends pulumi.CustomResource {
    /**
     * Get an existing CertificateCsr resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CertificateCsr {
        pulumi.log.warn("CertificateCsr is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        return new CertificateCsr(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:web/v20150801:CertificateCsr';

    /**
     * Returns true if the given object is an instance of CertificateCsr.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CertificateCsr {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CertificateCsr.__pulumiType;
    }

    /**
     * Actual CSR string created
     */
    public readonly csrString!: pulumi.Output<string | undefined>;
    /**
     * Distinguished name of certificate to be created
     */
    public readonly distinguishedName!: pulumi.Output<string | undefined>;
    /**
     * Hosting environment
     */
    public readonly hostingEnvironment!: pulumi.Output<string | undefined>;
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
     * PFX password
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * PFX certificate of created certificate
     */
    public readonly pfxBlob!: pulumi.Output<string | undefined>;
    /**
     * Hash of the certificates public key
     */
    public readonly publicKeyHash!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a CertificateCsr resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-08-01 will be removed in v2 of the provider. */
    constructor(name: string, args: CertificateCsrArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("CertificateCsr is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["csrString"] = args ? args.csrString : undefined;
            resourceInputs["distinguishedName"] = args ? args.distinguishedName : undefined;
            resourceInputs["hostingEnvironment"] = args ? args.hostingEnvironment : undefined;
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["password"] = args ? args.password : undefined;
            resourceInputs["pfxBlob"] = args ? args.pfxBlob : undefined;
            resourceInputs["publicKeyHash"] = args ? args.publicKeyHash : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
        } else {
            resourceInputs["csrString"] = undefined /*out*/;
            resourceInputs["distinguishedName"] = undefined /*out*/;
            resourceInputs["hostingEnvironment"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["password"] = undefined /*out*/;
            resourceInputs["pfxBlob"] = undefined /*out*/;
            resourceInputs["publicKeyHash"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CertificateCsr.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a CertificateCsr resource.
 */
export interface CertificateCsrArgs {
    /**
     * Actual CSR string created
     */
    csrString?: pulumi.Input<string>;
    /**
     * Distinguished name of certificate to be created
     */
    distinguishedName?: pulumi.Input<string>;
    /**
     * Hosting environment
     */
    hostingEnvironment?: pulumi.Input<string>;
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
    name?: pulumi.Input<string>;
    /**
     * PFX password
     */
    password?: pulumi.Input<string>;
    /**
     * PFX certificate of created certificate
     */
    pfxBlob?: pulumi.Input<string>;
    /**
     * Hash of the certificates public key
     */
    publicKeyHash?: pulumi.Input<string>;
    /**
     * Name of the resource group
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
