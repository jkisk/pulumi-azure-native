// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./accessPolicy";
export * from "./environment";
export * from "./eventHubEventSource";
export * from "./eventSource";
export * from "./gen1Environment";
export * from "./gen2Environment";
export * from "./getAccessPolicy";
export * from "./getEnvironment";
export * from "./getEventHubEventSource";
export * from "./getEventSource";
export * from "./getGen1Environment";
export * from "./getGen2Environment";
export * from "./getIoTHubEventSource";
export * from "./getPrivateEndpointConnection";
export * from "./getReferenceDataSet";
export * from "./ioTHubEventSource";
export * from "./privateEndpointConnection";
export * from "./referenceDataSet";

// Export enums:
export * from "../../types/enums/timeseriesinsights/v20210331preview";

// Import resources to register:
import { AccessPolicy } from "./accessPolicy";
import { Environment } from "./environment";
import { EventHubEventSource } from "./eventHubEventSource";
import { EventSource } from "./eventSource";
import { Gen1Environment } from "./gen1Environment";
import { Gen2Environment } from "./gen2Environment";
import { IoTHubEventSource } from "./ioTHubEventSource";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { ReferenceDataSet } from "./referenceDataSet";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:timeseriesinsights/v20210331preview:AccessPolicy":
                return new AccessPolicy(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:Environment":
                return new Environment(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:EventHubEventSource":
                return new EventHubEventSource(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:EventSource":
                return new EventSource(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:Gen1Environment":
                return new Gen1Environment(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:Gen2Environment":
                return new Gen2Environment(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:IoTHubEventSource":
                return new IoTHubEventSource(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:timeseriesinsights/v20210331preview:ReferenceDataSet":
                return new ReferenceDataSet(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "timeseriesinsights/v20210331preview", _module)
