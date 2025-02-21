// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./domainService";
export * from "./getDomainService";
export * from "./getOuContainer";
export * from "./ouContainer";

// Export enums:
export * from "../types/enums/aad";

// Export sub-modules:
import * as v20170101 from "./v20170101";
import * as v20170601 from "./v20170601";
import * as v20200101 from "./v20200101";
import * as v20210301 from "./v20210301";
import * as v20210501 from "./v20210501";

export {
    v20170101,
    v20170601,
    v20200101,
    v20210301,
    v20210501,
};

// Import resources to register:
import { DomainService } from "./domainService";
import { OuContainer } from "./ouContainer";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:aad:DomainService":
                return new DomainService(name, <any>undefined, { urn })
            case "azure-native:aad:OuContainer":
                return new OuContainer(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "aad", _module)
