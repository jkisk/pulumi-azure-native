// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getGrafana";
export * from "./getPrivateEndpointConnection";
export * from "./grafana";
export * from "./privateEndpointConnection";

// Export enums:
export * from "../types/enums/dashboard";

// Export sub-modules:
import * as v20210901preview from "./v20210901preview";
import * as v20220501preview from "./v20220501preview";

export {
    v20210901preview,
    v20220501preview,
};

// Import resources to register:
import { Grafana } from "./grafana";
import { PrivateEndpointConnection } from "./privateEndpointConnection";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:dashboard:Grafana":
                return new Grafana(name, <any>undefined, { urn })
            case "azure-native:dashboard:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "dashboard", _module)
