// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getPrivateEndpointConnection";
export * from "./getprivateLinkForAzureAd";
export * from "./privateEndpointConnection";
export * from "./privateLinkForAzureAd";

// Export enums:
export * from "../../types/enums/aadiam/v20200301";

// Import resources to register:
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { PrivateLinkForAzureAd } from "./privateLinkForAzureAd";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:aadiam/v20200301:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:aadiam/v20200301:privateLinkForAzureAd":
                return new PrivateLinkForAzureAd(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "aadiam/v20200301", _module)
