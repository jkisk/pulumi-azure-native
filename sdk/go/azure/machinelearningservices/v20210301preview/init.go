// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210301preview

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
	case "azure-native:machinelearningservices/v20210301preview:BatchDeployment":
		r = &BatchDeployment{}
	case "azure-native:machinelearningservices/v20210301preview:BatchEndpoint":
		r = &BatchEndpoint{}
	case "azure-native:machinelearningservices/v20210301preview:CodeContainer":
		r = &CodeContainer{}
	case "azure-native:machinelearningservices/v20210301preview:CodeVersion":
		r = &CodeVersion{}
	case "azure-native:machinelearningservices/v20210301preview:Compute":
		r = &Compute{}
	case "azure-native:machinelearningservices/v20210301preview:DataContainer":
		r = &DataContainer{}
	case "azure-native:machinelearningservices/v20210301preview:DataVersion":
		r = &DataVersion{}
	case "azure-native:machinelearningservices/v20210301preview:Datastore":
		r = &Datastore{}
	case "azure-native:machinelearningservices/v20210301preview:EnvironmentContainer":
		r = &EnvironmentContainer{}
	case "azure-native:machinelearningservices/v20210301preview:EnvironmentSpecificationVersion":
		r = &EnvironmentSpecificationVersion{}
	case "azure-native:machinelearningservices/v20210301preview:Job":
		r = &Job{}
	case "azure-native:machinelearningservices/v20210301preview:LabelingJob":
		r = &LabelingJob{}
	case "azure-native:machinelearningservices/v20210301preview:ModelContainer":
		r = &ModelContainer{}
	case "azure-native:machinelearningservices/v20210301preview:ModelVersion":
		r = &ModelVersion{}
	case "azure-native:machinelearningservices/v20210301preview:OnlineDeployment":
		r = &OnlineDeployment{}
	case "azure-native:machinelearningservices/v20210301preview:OnlineEndpoint":
		r = &OnlineEndpoint{}
	case "azure-native:machinelearningservices/v20210301preview:PrivateEndpointConnection":
		r = &PrivateEndpointConnection{}
	case "azure-native:machinelearningservices/v20210301preview:Workspace":
		r = &Workspace{}
	case "azure-native:machinelearningservices/v20210301preview:WorkspaceConnection":
		r = &WorkspaceConnection{}
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
		"machinelearningservices/v20210301preview",
		&module{version},
	)
}
