// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// String dictionary resource
//
// Deprecated: Version 2015-08-01 will be removed in v2 of the provider.
type SiteConnectionStringsSlot struct {
	pulumi.CustomResourceState

	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Connection strings
	Properties ConnStringValueTypePairResponseMapOutput `pulumi:"properties"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewSiteConnectionStringsSlot registers a new resource with the given unique name, arguments, and options.
func NewSiteConnectionStringsSlot(ctx *pulumi.Context,
	name string, args *SiteConnectionStringsSlotArgs, opts ...pulumi.ResourceOption) (*SiteConnectionStringsSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Slot == nil {
		return nil, errors.New("invalid value for required argument 'Slot'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:web:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20160801:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20180201:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20181101:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20190801:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20200601:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20200901:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20201001:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20201201:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210101:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210115:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210201:SiteConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210301:SiteConnectionStringsSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteConnectionStringsSlot
	err := ctx.RegisterResource("azure-native:web/v20150801:SiteConnectionStringsSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteConnectionStringsSlot gets an existing SiteConnectionStringsSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteConnectionStringsSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteConnectionStringsSlotState, opts ...pulumi.ResourceOption) (*SiteConnectionStringsSlot, error) {
	var resource SiteConnectionStringsSlot
	err := ctx.ReadResource("azure-native:web/v20150801:SiteConnectionStringsSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteConnectionStringsSlot resources.
type siteConnectionStringsSlotState struct {
}

type SiteConnectionStringsSlotState struct {
}

func (SiteConnectionStringsSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteConnectionStringsSlotState)(nil)).Elem()
}

type siteConnectionStringsSlotArgs struct {
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name string `pulumi:"name"`
	// Connection strings
	Properties map[string]ConnStringValueTypePair `pulumi:"properties"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of web app slot. If not specified then will default to production slot.
	Slot string `pulumi:"slot"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteConnectionStringsSlot resource.
type SiteConnectionStringsSlotArgs struct {
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringInput
	// Connection strings
	Properties ConnStringValueTypePairMapInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// Name of web app slot. If not specified then will default to production slot.
	Slot pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteConnectionStringsSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteConnectionStringsSlotArgs)(nil)).Elem()
}

type SiteConnectionStringsSlotInput interface {
	pulumi.Input

	ToSiteConnectionStringsSlotOutput() SiteConnectionStringsSlotOutput
	ToSiteConnectionStringsSlotOutputWithContext(ctx context.Context) SiteConnectionStringsSlotOutput
}

func (*SiteConnectionStringsSlot) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteConnectionStringsSlot)(nil)).Elem()
}

func (i *SiteConnectionStringsSlot) ToSiteConnectionStringsSlotOutput() SiteConnectionStringsSlotOutput {
	return i.ToSiteConnectionStringsSlotOutputWithContext(context.Background())
}

func (i *SiteConnectionStringsSlot) ToSiteConnectionStringsSlotOutputWithContext(ctx context.Context) SiteConnectionStringsSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteConnectionStringsSlotOutput)
}

type SiteConnectionStringsSlotOutput struct{ *pulumi.OutputState }

func (SiteConnectionStringsSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteConnectionStringsSlot)(nil)).Elem()
}

func (o SiteConnectionStringsSlotOutput) ToSiteConnectionStringsSlotOutput() SiteConnectionStringsSlotOutput {
	return o
}

func (o SiteConnectionStringsSlotOutput) ToSiteConnectionStringsSlotOutputWithContext(ctx context.Context) SiteConnectionStringsSlotOutput {
	return o
}

// Kind of resource
func (o SiteConnectionStringsSlotOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteConnectionStringsSlot) pulumi.StringPtrOutput { return v.Kind }).(pulumi.StringPtrOutput)
}

// Resource Location
func (o SiteConnectionStringsSlotOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteConnectionStringsSlot) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Resource Name
func (o SiteConnectionStringsSlotOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteConnectionStringsSlot) pulumi.StringPtrOutput { return v.Name }).(pulumi.StringPtrOutput)
}

// Connection strings
func (o SiteConnectionStringsSlotOutput) Properties() ConnStringValueTypePairResponseMapOutput {
	return o.ApplyT(func(v *SiteConnectionStringsSlot) ConnStringValueTypePairResponseMapOutput { return v.Properties }).(ConnStringValueTypePairResponseMapOutput)
}

// Resource tags
func (o SiteConnectionStringsSlotOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *SiteConnectionStringsSlot) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Resource type
func (o SiteConnectionStringsSlotOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteConnectionStringsSlot) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(SiteConnectionStringsSlotOutput{})
}
