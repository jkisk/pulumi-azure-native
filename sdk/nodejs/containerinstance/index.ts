// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./containerGroup";
export * from "./getContainerGroup";

// Export enums:
export * from "../types/enums/containerinstance";

// Export sub-modules:
import * as v20170801preview from "./v20170801preview";
import * as v20171001preview from "./v20171001preview";
import * as v20171201preview from "./v20171201preview";
import * as v20180201preview from "./v20180201preview";
import * as v20180401 from "./v20180401";
import * as v20180601 from "./v20180601";
import * as v20180901 from "./v20180901";
import * as v20181001 from "./v20181001";
import * as v20191201 from "./v20191201";
import * as v20201101 from "./v20201101";
import * as v20210301 from "./v20210301";
import * as v20210701 from "./v20210701";
import * as v20210901 from "./v20210901";
import * as v20211001 from "./v20211001";

export {
    v20170801preview,
    v20171001preview,
    v20171201preview,
    v20180201preview,
    v20180401,
    v20180601,
    v20180901,
    v20181001,
    v20191201,
    v20201101,
    v20210301,
    v20210701,
    v20210901,
    v20211001,
};

// Import resources to register:
import { ContainerGroup } from "./containerGroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:containerinstance:ContainerGroup":
                return new ContainerGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "containerinstance", _module)
