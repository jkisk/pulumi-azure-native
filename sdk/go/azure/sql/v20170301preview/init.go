// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20170301preview

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
	case "azure-native:sql/v20170301preview:BackupLongTermRetentionPolicy":
		r = &BackupLongTermRetentionPolicy{}
	case "azure-native:sql/v20170301preview:Database":
		r = &Database{}
	case "azure-native:sql/v20170301preview:DatabaseBlobAuditingPolicy":
		r = &DatabaseBlobAuditingPolicy{}
	case "azure-native:sql/v20170301preview:DatabaseVulnerabilityAssessment":
		r = &DatabaseVulnerabilityAssessment{}
	case "azure-native:sql/v20170301preview:DatabaseVulnerabilityAssessmentRuleBaseline":
		r = &DatabaseVulnerabilityAssessmentRuleBaseline{}
	case "azure-native:sql/v20170301preview:ExtendedDatabaseBlobAuditingPolicy":
		r = &ExtendedDatabaseBlobAuditingPolicy{}
	case "azure-native:sql/v20170301preview:ExtendedServerBlobAuditingPolicy":
		r = &ExtendedServerBlobAuditingPolicy{}
	case "azure-native:sql/v20170301preview:Job":
		r = &Job{}
	case "azure-native:sql/v20170301preview:JobAgent":
		r = &JobAgent{}
	case "azure-native:sql/v20170301preview:JobCredential":
		r = &JobCredential{}
	case "azure-native:sql/v20170301preview:JobStep":
		r = &JobStep{}
	case "azure-native:sql/v20170301preview:JobTargetGroup":
		r = &JobTargetGroup{}
	case "azure-native:sql/v20170301preview:ManagedDatabase":
		r = &ManagedDatabase{}
	case "azure-native:sql/v20170301preview:ManagedInstanceAdministrator":
		r = &ManagedInstanceAdministrator{}
	case "azure-native:sql/v20170301preview:SensitivityLabel":
		r = &SensitivityLabel{}
	case "azure-native:sql/v20170301preview:ServerBlobAuditingPolicy":
		r = &ServerBlobAuditingPolicy{}
	case "azure-native:sql/v20170301preview:ServerDnsAlias":
		r = &ServerDnsAlias{}
	case "azure-native:sql/v20170301preview:ServerSecurityAlertPolicy":
		r = &ServerSecurityAlertPolicy{}
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
		"sql/v20170301preview",
		&module{version},
	)
}
