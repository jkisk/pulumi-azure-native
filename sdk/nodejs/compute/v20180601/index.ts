// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./availabilitySet";
export * from "./disk";
export * from "./gallery";
export * from "./galleryImage";
export * from "./galleryImageVersion";
export * from "./getAvailabilitySet";
export * from "./getDisk";
export * from "./getGallery";
export * from "./getGalleryImage";
export * from "./getGalleryImageVersion";
export * from "./getImage";
export * from "./getLogAnalyticExportRequestRateByInterval";
export * from "./getLogAnalyticExportThrottledRequests";
export * from "./getProximityPlacementGroup";
export * from "./getSnapshot";
export * from "./getVirtualMachine";
export * from "./getVirtualMachineExtension";
export * from "./getVirtualMachineScaleSet";
export * from "./getVirtualMachineScaleSetExtension";
export * from "./getVirtualMachineScaleSetVM";
export * from "./image";
export * from "./proximityPlacementGroup";
export * from "./snapshot";
export * from "./virtualMachine";
export * from "./virtualMachineExtension";
export * from "./virtualMachineScaleSet";
export * from "./virtualMachineScaleSetExtension";
export * from "./virtualMachineScaleSetVM";

// Export enums:
export * from "../../types/enums/compute/v20180601";

// Import resources to register:
import { AvailabilitySet } from "./availabilitySet";
import { Disk } from "./disk";
import { Gallery } from "./gallery";
import { GalleryImage } from "./galleryImage";
import { GalleryImageVersion } from "./galleryImageVersion";
import { Image } from "./image";
import { ProximityPlacementGroup } from "./proximityPlacementGroup";
import { Snapshot } from "./snapshot";
import { VirtualMachine } from "./virtualMachine";
import { VirtualMachineExtension } from "./virtualMachineExtension";
import { VirtualMachineScaleSet } from "./virtualMachineScaleSet";
import { VirtualMachineScaleSetExtension } from "./virtualMachineScaleSetExtension";
import { VirtualMachineScaleSetVM } from "./virtualMachineScaleSetVM";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:compute/v20180601:AvailabilitySet":
                return new AvailabilitySet(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:Disk":
                return new Disk(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:Gallery":
                return new Gallery(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:GalleryImage":
                return new GalleryImage(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:GalleryImageVersion":
                return new GalleryImageVersion(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:Image":
                return new Image(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:ProximityPlacementGroup":
                return new ProximityPlacementGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:VirtualMachine":
                return new VirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:VirtualMachineExtension":
                return new VirtualMachineExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:VirtualMachineScaleSet":
                return new VirtualMachineScaleSet(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:VirtualMachineScaleSetExtension":
                return new VirtualMachineScaleSetExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20180601:VirtualMachineScaleSetVM":
                return new VirtualMachineScaleSetVM(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "compute/v20180601", _module)
