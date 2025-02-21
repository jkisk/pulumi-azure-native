// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./account";
export * from "./creator";
export * from "./getAccount";
export * from "./getCreator";
export * from "./getPrivateAtlase";
export * from "./listAccountKeys";
export * from "./listAccountSas";
export * from "./privateAtlase";

// Export enums:
export * from "../types/enums/maps";

// Export sub-modules:
import * as v20170101preview from "./v20170101preview";
import * as v20180501 from "./v20180501";
import * as v20200201preview from "./v20200201preview";
import * as v20210201 from "./v20210201";
import * as v20210701preview from "./v20210701preview";
import * as v20211201preview from "./v20211201preview";

export {
    v20170101preview,
    v20180501,
    v20200201preview,
    v20210201,
    v20210701preview,
    v20211201preview,
};

// Import resources to register:
import { Account } from "./account";
import { Creator } from "./creator";
import { PrivateAtlase } from "./privateAtlase";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:maps:Account":
                return new Account(name, <any>undefined, { urn })
            case "azure-native:maps:Creator":
                return new Creator(name, <any>undefined, { urn })
            case "azure-native:maps:PrivateAtlase":
                return new PrivateAtlase(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "maps", _module)
