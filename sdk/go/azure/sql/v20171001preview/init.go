// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20171001preview

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
	case "azure-native:sql/v20171001preview:BackupShortTermRetentionPolicy":
		r = &BackupShortTermRetentionPolicy{}
	case "azure-native:sql/v20171001preview:Database":
		r = &Database{}
	case "azure-native:sql/v20171001preview:ElasticPool":
		r = &ElasticPool{}
	case "azure-native:sql/v20171001preview:InstanceFailoverGroup":
		r = &InstanceFailoverGroup{}
	case "azure-native:sql/v20171001preview:ManagedDatabaseVulnerabilityAssessment":
		r = &ManagedDatabaseVulnerabilityAssessment{}
	case "azure-native:sql/v20171001preview:ManagedDatabaseVulnerabilityAssessmentRuleBaseline":
		r = &ManagedDatabaseVulnerabilityAssessmentRuleBaseline{}
	case "azure-native:sql/v20171001preview:ManagedInstanceKey":
		r = &ManagedInstanceKey{}
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
		"sql/v20171001preview",
		&module{version},
	)
}
