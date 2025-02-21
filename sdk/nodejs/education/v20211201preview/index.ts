// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getLab";
export * from "./getStudent";
export * from "./lab";
export * from "./student";

// Export enums:
export * from "../../types/enums/education/v20211201preview";

// Import resources to register:
import { Lab } from "./lab";
import { Student } from "./student";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:education/v20211201preview:Lab":
                return new Lab(name, <any>undefined, { urn })
            case "azure-native:education/v20211201preview:Student":
                return new Student(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "education/v20211201preview", _module)
