// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Information about managed application.
//
// Deprecated: Version 2018-06-01 will be removed in v2 of the provider.
func LookupApplication(ctx *pulumi.Context, args *LookupApplicationArgs, opts ...pulumi.InvokeOption) (*LookupApplicationResult, error) {
	var rv LookupApplicationResult
	err := ctx.Invoke("azure-native:solutions/v20180601:getApplication", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupApplicationArgs struct {
	// The name of the managed application.
	ApplicationName string `pulumi:"applicationName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Information about managed application.
type LookupApplicationResult struct {
	// The fully qualified path of managed application definition Id.
	ApplicationDefinitionId *string `pulumi:"applicationDefinitionId"`
	// Resource ID
	Id string `pulumi:"id"`
	// The identity of the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog.
	Kind string `pulumi:"kind"`
	// Resource location
	Location *string `pulumi:"location"`
	// ID of the resource that manages this resource.
	ManagedBy *string `pulumi:"managedBy"`
	// The managed resource group Id.
	ManagedResourceGroupId string `pulumi:"managedResourceGroupId"`
	// Resource name
	Name string `pulumi:"name"`
	// Name and value pairs that define the managed application outputs.
	Outputs interface{} `pulumi:"outputs"`
	// Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string.
	Parameters interface{} `pulumi:"parameters"`
	// The plan information.
	Plan *PlanResponse `pulumi:"plan"`
	// The managed application provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// The SKU of the resource.
	Sku *SkuResponse `pulumi:"sku"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type string `pulumi:"type"`
}

func LookupApplicationOutput(ctx *pulumi.Context, args LookupApplicationOutputArgs, opts ...pulumi.InvokeOption) LookupApplicationResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupApplicationResult, error) {
			args := v.(LookupApplicationArgs)
			r, err := LookupApplication(ctx, &args, opts...)
			var s LookupApplicationResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupApplicationResultOutput)
}

type LookupApplicationOutputArgs struct {
	// The name of the managed application.
	ApplicationName pulumi.StringInput `pulumi:"applicationName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
}

func (LookupApplicationOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupApplicationArgs)(nil)).Elem()
}

// Information about managed application.
type LookupApplicationResultOutput struct{ *pulumi.OutputState }

func (LookupApplicationResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupApplicationResult)(nil)).Elem()
}

func (o LookupApplicationResultOutput) ToLookupApplicationResultOutput() LookupApplicationResultOutput {
	return o
}

func (o LookupApplicationResultOutput) ToLookupApplicationResultOutputWithContext(ctx context.Context) LookupApplicationResultOutput {
	return o
}

// The fully qualified path of managed application definition Id.
func (o LookupApplicationResultOutput) ApplicationDefinitionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupApplicationResult) *string { return v.ApplicationDefinitionId }).(pulumi.StringPtrOutput)
}

// Resource ID
func (o LookupApplicationResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApplicationResult) string { return v.Id }).(pulumi.StringOutput)
}

// The identity of the resource.
func (o LookupApplicationResultOutput) Identity() IdentityResponsePtrOutput {
	return o.ApplyT(func(v LookupApplicationResult) *IdentityResponse { return v.Identity }).(IdentityResponsePtrOutput)
}

// The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog.
func (o LookupApplicationResultOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApplicationResult) string { return v.Kind }).(pulumi.StringOutput)
}

// Resource location
func (o LookupApplicationResultOutput) Location() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupApplicationResult) *string { return v.Location }).(pulumi.StringPtrOutput)
}

// ID of the resource that manages this resource.
func (o LookupApplicationResultOutput) ManagedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupApplicationResult) *string { return v.ManagedBy }).(pulumi.StringPtrOutput)
}

// The managed resource group Id.
func (o LookupApplicationResultOutput) ManagedResourceGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApplicationResult) string { return v.ManagedResourceGroupId }).(pulumi.StringOutput)
}

// Resource name
func (o LookupApplicationResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApplicationResult) string { return v.Name }).(pulumi.StringOutput)
}

// Name and value pairs that define the managed application outputs.
func (o LookupApplicationResultOutput) Outputs() pulumi.AnyOutput {
	return o.ApplyT(func(v LookupApplicationResult) interface{} { return v.Outputs }).(pulumi.AnyOutput)
}

// Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string.
func (o LookupApplicationResultOutput) Parameters() pulumi.AnyOutput {
	return o.ApplyT(func(v LookupApplicationResult) interface{} { return v.Parameters }).(pulumi.AnyOutput)
}

// The plan information.
func (o LookupApplicationResultOutput) Plan() PlanResponsePtrOutput {
	return o.ApplyT(func(v LookupApplicationResult) *PlanResponse { return v.Plan }).(PlanResponsePtrOutput)
}

// The managed application provisioning state.
func (o LookupApplicationResultOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApplicationResult) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// The SKU of the resource.
func (o LookupApplicationResultOutput) Sku() SkuResponsePtrOutput {
	return o.ApplyT(func(v LookupApplicationResult) *SkuResponse { return v.Sku }).(SkuResponsePtrOutput)
}

// Resource tags
func (o LookupApplicationResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupApplicationResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// Resource type
func (o LookupApplicationResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApplicationResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupApplicationResultOutput{})
}
