// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210401

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-azure-native/sdk/go/azure"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "azure-native:compute/v20210401:AvailabilitySet":
		r = &AvailabilitySet{}
	case "azure-native:compute/v20210401:CapacityReservation":
		r = &CapacityReservation{}
	case "azure-native:compute/v20210401:CapacityReservationGroup":
		r = &CapacityReservationGroup{}
	case "azure-native:compute/v20210401:DedicatedHost":
		r = &DedicatedHost{}
	case "azure-native:compute/v20210401:DedicatedHostGroup":
		r = &DedicatedHostGroup{}
	case "azure-native:compute/v20210401:Disk":
		r = &Disk{}
	case "azure-native:compute/v20210401:DiskAccess":
		r = &DiskAccess{}
	case "azure-native:compute/v20210401:DiskAccessAPrivateEndpointConnection":
		r = &DiskAccessAPrivateEndpointConnection{}
	case "azure-native:compute/v20210401:DiskEncryptionSet":
		r = &DiskEncryptionSet{}
	case "azure-native:compute/v20210401:Image":
		r = &Image{}
	case "azure-native:compute/v20210401:ProximityPlacementGroup":
		r = &ProximityPlacementGroup{}
	case "azure-native:compute/v20210401:RestorePoint":
		r = &RestorePoint{}
	case "azure-native:compute/v20210401:RestorePointCollection":
		r = &RestorePointCollection{}
	case "azure-native:compute/v20210401:Snapshot":
		r = &Snapshot{}
	case "azure-native:compute/v20210401:SshPublicKey":
		r = &SshPublicKey{}
	case "azure-native:compute/v20210401:VirtualMachine":
		r = &VirtualMachine{}
	case "azure-native:compute/v20210401:VirtualMachineExtension":
		r = &VirtualMachineExtension{}
	case "azure-native:compute/v20210401:VirtualMachineRunCommandByVirtualMachine":
		r = &VirtualMachineRunCommandByVirtualMachine{}
	case "azure-native:compute/v20210401:VirtualMachineScaleSet":
		r = &VirtualMachineScaleSet{}
	case "azure-native:compute/v20210401:VirtualMachineScaleSetExtension":
		r = &VirtualMachineScaleSetExtension{}
	case "azure-native:compute/v20210401:VirtualMachineScaleSetVM":
		r = &VirtualMachineScaleSetVM{}
	case "azure-native:compute/v20210401:VirtualMachineScaleSetVMExtension":
		r = &VirtualMachineScaleSetVMExtension{}
	case "azure-native:compute/v20210401:VirtualMachineScaleSetVMRunCommand":
		r = &VirtualMachineScaleSetVMRunCommand{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := azure.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"azure-native",
		"compute/v20210401",
		&module{version},
	)
}
