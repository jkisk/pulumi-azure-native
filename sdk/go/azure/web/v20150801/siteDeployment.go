// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Represents user credentials used for publishing activity
//
// Deprecated: Version 2015-08-01 will be removed in v2 of the provider.
type SiteDeployment struct {
	pulumi.CustomResourceState

	// Active
	Active pulumi.BoolPtrOutput `pulumi:"active"`
	// Author
	Author pulumi.StringPtrOutput `pulumi:"author"`
	// AuthorEmail
	AuthorEmail pulumi.StringPtrOutput `pulumi:"authorEmail"`
	// Deployer
	Deployer pulumi.StringPtrOutput `pulumi:"deployer"`
	// Detail
	Details pulumi.StringPtrOutput `pulumi:"details"`
	// EndTime
	EndTime pulumi.StringPtrOutput `pulumi:"endTime"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Message
	Message pulumi.StringPtrOutput `pulumi:"message"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// StartTime
	StartTime pulumi.StringPtrOutput `pulumi:"startTime"`
	// Status
	Status pulumi.IntPtrOutput `pulumi:"status"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewSiteDeployment registers a new resource with the given unique name, arguments, and options.
func NewSiteDeployment(ctx *pulumi.Context,
	name string, args *SiteDeploymentArgs, opts ...pulumi.ResourceOption) (*SiteDeployment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:web:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20160801:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20180201:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20181101:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20190801:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20200601:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20200901:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20201001:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20201201:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210101:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210115:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210201:SiteDeployment"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210301:SiteDeployment"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteDeployment
	err := ctx.RegisterResource("azure-native:web/v20150801:SiteDeployment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteDeployment gets an existing SiteDeployment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteDeployment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteDeploymentState, opts ...pulumi.ResourceOption) (*SiteDeployment, error) {
	var resource SiteDeployment
	err := ctx.ReadResource("azure-native:web/v20150801:SiteDeployment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteDeployment resources.
type siteDeploymentState struct {
}

type SiteDeploymentState struct {
}

func (SiteDeploymentState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteDeploymentState)(nil)).Elem()
}

type siteDeploymentArgs struct {
	// Active
	Active *bool `pulumi:"active"`
	// Author
	Author *string `pulumi:"author"`
	// AuthorEmail
	AuthorEmail *string `pulumi:"authorEmail"`
	// Deployer
	Deployer *string `pulumi:"deployer"`
	// Detail
	Details *string `pulumi:"details"`
	// EndTime
	EndTime *string `pulumi:"endTime"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Message
	Message *string `pulumi:"message"`
	// Resource Name
	Name string `pulumi:"name"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// StartTime
	StartTime *string `pulumi:"startTime"`
	// Status
	Status *int `pulumi:"status"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteDeployment resource.
type SiteDeploymentArgs struct {
	// Active
	Active pulumi.BoolPtrInput
	// Author
	Author pulumi.StringPtrInput
	// AuthorEmail
	AuthorEmail pulumi.StringPtrInput
	// Deployer
	Deployer pulumi.StringPtrInput
	// Detail
	Details pulumi.StringPtrInput
	// EndTime
	EndTime pulumi.StringPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Message
	Message pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// StartTime
	StartTime pulumi.StringPtrInput
	// Status
	Status pulumi.IntPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteDeploymentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteDeploymentArgs)(nil)).Elem()
}

type SiteDeploymentInput interface {
	pulumi.Input

	ToSiteDeploymentOutput() SiteDeploymentOutput
	ToSiteDeploymentOutputWithContext(ctx context.Context) SiteDeploymentOutput
}

func (*SiteDeployment) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteDeployment)(nil)).Elem()
}

func (i *SiteDeployment) ToSiteDeploymentOutput() SiteDeploymentOutput {
	return i.ToSiteDeploymentOutputWithContext(context.Background())
}

func (i *SiteDeployment) ToSiteDeploymentOutputWithContext(ctx context.Context) SiteDeploymentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteDeploymentOutput)
}

type SiteDeploymentOutput struct{ *pulumi.OutputState }

func (SiteDeploymentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteDeployment)(nil)).Elem()
}

func (o SiteDeploymentOutput) ToSiteDeploymentOutput() SiteDeploymentOutput {
	return o
}

func (o SiteDeploymentOutput) ToSiteDeploymentOutputWithContext(ctx context.Context) SiteDeploymentOutput {
	return o
}

// Active
func (o SiteDeploymentOutput) Active() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.BoolPtrOutput { return v.Active }).(pulumi.BoolPtrOutput)
}

// Author
func (o SiteDeploymentOutput) Author() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Author }).(pulumi.StringPtrOutput)
}

// AuthorEmail
func (o SiteDeploymentOutput) AuthorEmail() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.AuthorEmail }).(pulumi.StringPtrOutput)
}

// Deployer
func (o SiteDeploymentOutput) Deployer() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Deployer }).(pulumi.StringPtrOutput)
}

// Detail
func (o SiteDeploymentOutput) Details() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Details }).(pulumi.StringPtrOutput)
}

// EndTime
func (o SiteDeploymentOutput) EndTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.EndTime }).(pulumi.StringPtrOutput)
}

// Kind of resource
func (o SiteDeploymentOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Kind }).(pulumi.StringPtrOutput)
}

// Resource Location
func (o SiteDeploymentOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Message
func (o SiteDeploymentOutput) Message() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Message }).(pulumi.StringPtrOutput)
}

// Resource Name
func (o SiteDeploymentOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Name }).(pulumi.StringPtrOutput)
}

// StartTime
func (o SiteDeploymentOutput) StartTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.StartTime }).(pulumi.StringPtrOutput)
}

// Status
func (o SiteDeploymentOutput) Status() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.IntPtrOutput { return v.Status }).(pulumi.IntPtrOutput)
}

// Resource tags
func (o SiteDeploymentOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Resource type
func (o SiteDeploymentOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteDeployment) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(SiteDeploymentOutput{})
}
