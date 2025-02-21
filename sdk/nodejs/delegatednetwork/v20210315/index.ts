// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./controllerDetails";
export * from "./delegatedSubnetServiceDetails";
export * from "./getControllerDetails";
export * from "./getDelegatedSubnetServiceDetails";
export * from "./getOrchestratorInstanceServiceDetails";
export * from "./orchestratorInstanceServiceDetails";

// Export enums:
export * from "../../types/enums/delegatednetwork/v20210315";

// Import resources to register:
import { ControllerDetails } from "./controllerDetails";
import { DelegatedSubnetServiceDetails } from "./delegatedSubnetServiceDetails";
import { OrchestratorInstanceServiceDetails } from "./orchestratorInstanceServiceDetails";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:delegatednetwork/v20210315:ControllerDetails":
                return new ControllerDetails(name, <any>undefined, { urn })
            case "azure-native:delegatednetwork/v20210315:DelegatedSubnetServiceDetails":
                return new DelegatedSubnetServiceDetails(name, <any>undefined, { urn })
            case "azure-native:delegatednetwork/v20210315:OrchestratorInstanceServiceDetails":
                return new OrchestratorInstanceServiceDetails(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "delegatednetwork/v20210315", _module)
