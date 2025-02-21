// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20170907privatepreview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Class representing a Kusto database.
//
// Deprecated: Version 2017-09-07-privatepreview will be removed in v2 of the provider.
type Database struct {
	pulumi.CustomResourceState

	// An ETag of the resource created.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The number of days of data that should be kept in cache for fast queries.
	HotCachePeriodInDays pulumi.IntPtrOutput `pulumi:"hotCachePeriodInDays"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioned state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The number of days data should be kept before it stops being accessible to queries.
	SoftDeletePeriodInDays pulumi.IntOutput `pulumi:"softDeletePeriodInDays"`
	// The statistics of the database.
	Statistics DatabaseStatisticsResponseOutput `pulumi:"statistics"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDatabase registers a new resource with the given unique name, arguments, and options.
func NewDatabase(ctx *pulumi.Context,
	name string, args *DatabaseArgs, opts ...pulumi.ResourceOption) (*Database, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterName == nil {
		return nil, errors.New("invalid value for required argument 'ClusterName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.SoftDeletePeriodInDays == nil {
		return nil, errors.New("invalid value for required argument 'SoftDeletePeriodInDays'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:kusto:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20180907preview:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20190121:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20190515:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20190907:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20191109:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20200215:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20200614:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20200918:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20210101:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20210827:Database"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20220201:Database"),
		},
	})
	opts = append(opts, aliases)
	var resource Database
	err := ctx.RegisterResource("azure-native:kusto/v20170907privatepreview:Database", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabase gets an existing Database resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseState, opts ...pulumi.ResourceOption) (*Database, error) {
	var resource Database
	err := ctx.ReadResource("azure-native:kusto/v20170907privatepreview:Database", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Database resources.
type databaseState struct {
}

type DatabaseState struct {
}

func (DatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseState)(nil)).Elem()
}

type databaseArgs struct {
	// The name of the Kusto cluster.
	ClusterName string `pulumi:"clusterName"`
	// The name of the database in the Kusto cluster.
	DatabaseName *string `pulumi:"databaseName"`
	// The number of days of data that should be kept in cache for fast queries.
	HotCachePeriodInDays *int `pulumi:"hotCachePeriodInDays"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The number of days data should be kept before it stops being accessible to queries.
	SoftDeletePeriodInDays int `pulumi:"softDeletePeriodInDays"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Database resource.
type DatabaseArgs struct {
	// The name of the Kusto cluster.
	ClusterName pulumi.StringInput
	// The name of the database in the Kusto cluster.
	DatabaseName pulumi.StringPtrInput
	// The number of days of data that should be kept in cache for fast queries.
	HotCachePeriodInDays pulumi.IntPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName pulumi.StringInput
	// The number of days data should be kept before it stops being accessible to queries.
	SoftDeletePeriodInDays pulumi.IntInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (DatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseArgs)(nil)).Elem()
}

type DatabaseInput interface {
	pulumi.Input

	ToDatabaseOutput() DatabaseOutput
	ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput
}

func (*Database) ElementType() reflect.Type {
	return reflect.TypeOf((**Database)(nil)).Elem()
}

func (i *Database) ToDatabaseOutput() DatabaseOutput {
	return i.ToDatabaseOutputWithContext(context.Background())
}

func (i *Database) ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseOutput)
}

type DatabaseOutput struct{ *pulumi.OutputState }

func (DatabaseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Database)(nil)).Elem()
}

func (o DatabaseOutput) ToDatabaseOutput() DatabaseOutput {
	return o
}

func (o DatabaseOutput) ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput {
	return o
}

// An ETag of the resource created.
func (o DatabaseOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Etag }).(pulumi.StringOutput)
}

// The number of days of data that should be kept in cache for fast queries.
func (o DatabaseOutput) HotCachePeriodInDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Database) pulumi.IntPtrOutput { return v.HotCachePeriodInDays }).(pulumi.IntPtrOutput)
}

// The geo-location where the resource lives
func (o DatabaseOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The name of the resource
func (o DatabaseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The provisioned state of the resource.
func (o DatabaseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.ProvisioningState }).(pulumi.StringOutput)
}

// The number of days data should be kept before it stops being accessible to queries.
func (o DatabaseOutput) SoftDeletePeriodInDays() pulumi.IntOutput {
	return o.ApplyT(func(v *Database) pulumi.IntOutput { return v.SoftDeletePeriodInDays }).(pulumi.IntOutput)
}

// The statistics of the database.
func (o DatabaseOutput) Statistics() DatabaseStatisticsResponseOutput {
	return o.ApplyT(func(v *Database) DatabaseStatisticsResponseOutput { return v.Statistics }).(DatabaseStatisticsResponseOutput)
}

// Resource tags.
func (o DatabaseOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Database) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o DatabaseOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(DatabaseOutput{})
}
