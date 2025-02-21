// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20191001preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Put subscription properties.
type PutAliasRequestProperties struct {
	// Determines whether subscription is fieldLed, partnerLed or LegacyEA
	BillingScope string `pulumi:"billingScope"`
	// The friendly name of the subscription.
	DisplayName string `pulumi:"displayName"`
	// This parameter can be used to create alias for existing subscription Id
	SubscriptionId *string `pulumi:"subscriptionId"`
	// The workload type of the subscription. It can be either Production or DevTest.
	Workload string `pulumi:"workload"`
}

// PutAliasRequestPropertiesInput is an input type that accepts PutAliasRequestPropertiesArgs and PutAliasRequestPropertiesOutput values.
// You can construct a concrete instance of `PutAliasRequestPropertiesInput` via:
//
//          PutAliasRequestPropertiesArgs{...}
type PutAliasRequestPropertiesInput interface {
	pulumi.Input

	ToPutAliasRequestPropertiesOutput() PutAliasRequestPropertiesOutput
	ToPutAliasRequestPropertiesOutputWithContext(context.Context) PutAliasRequestPropertiesOutput
}

// Put subscription properties.
type PutAliasRequestPropertiesArgs struct {
	// Determines whether subscription is fieldLed, partnerLed or LegacyEA
	BillingScope pulumi.StringInput `pulumi:"billingScope"`
	// The friendly name of the subscription.
	DisplayName pulumi.StringInput `pulumi:"displayName"`
	// This parameter can be used to create alias for existing subscription Id
	SubscriptionId pulumi.StringPtrInput `pulumi:"subscriptionId"`
	// The workload type of the subscription. It can be either Production or DevTest.
	Workload pulumi.StringInput `pulumi:"workload"`
}

func (PutAliasRequestPropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PutAliasRequestProperties)(nil)).Elem()
}

func (i PutAliasRequestPropertiesArgs) ToPutAliasRequestPropertiesOutput() PutAliasRequestPropertiesOutput {
	return i.ToPutAliasRequestPropertiesOutputWithContext(context.Background())
}

func (i PutAliasRequestPropertiesArgs) ToPutAliasRequestPropertiesOutputWithContext(ctx context.Context) PutAliasRequestPropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PutAliasRequestPropertiesOutput)
}

func (i PutAliasRequestPropertiesArgs) ToPutAliasRequestPropertiesPtrOutput() PutAliasRequestPropertiesPtrOutput {
	return i.ToPutAliasRequestPropertiesPtrOutputWithContext(context.Background())
}

func (i PutAliasRequestPropertiesArgs) ToPutAliasRequestPropertiesPtrOutputWithContext(ctx context.Context) PutAliasRequestPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PutAliasRequestPropertiesOutput).ToPutAliasRequestPropertiesPtrOutputWithContext(ctx)
}

// PutAliasRequestPropertiesPtrInput is an input type that accepts PutAliasRequestPropertiesArgs, PutAliasRequestPropertiesPtr and PutAliasRequestPropertiesPtrOutput values.
// You can construct a concrete instance of `PutAliasRequestPropertiesPtrInput` via:
//
//          PutAliasRequestPropertiesArgs{...}
//
//  or:
//
//          nil
type PutAliasRequestPropertiesPtrInput interface {
	pulumi.Input

	ToPutAliasRequestPropertiesPtrOutput() PutAliasRequestPropertiesPtrOutput
	ToPutAliasRequestPropertiesPtrOutputWithContext(context.Context) PutAliasRequestPropertiesPtrOutput
}

type putAliasRequestPropertiesPtrType PutAliasRequestPropertiesArgs

func PutAliasRequestPropertiesPtr(v *PutAliasRequestPropertiesArgs) PutAliasRequestPropertiesPtrInput {
	return (*putAliasRequestPropertiesPtrType)(v)
}

func (*putAliasRequestPropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**PutAliasRequestProperties)(nil)).Elem()
}

func (i *putAliasRequestPropertiesPtrType) ToPutAliasRequestPropertiesPtrOutput() PutAliasRequestPropertiesPtrOutput {
	return i.ToPutAliasRequestPropertiesPtrOutputWithContext(context.Background())
}

func (i *putAliasRequestPropertiesPtrType) ToPutAliasRequestPropertiesPtrOutputWithContext(ctx context.Context) PutAliasRequestPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PutAliasRequestPropertiesPtrOutput)
}

// Put subscription properties.
type PutAliasRequestPropertiesOutput struct{ *pulumi.OutputState }

func (PutAliasRequestPropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PutAliasRequestProperties)(nil)).Elem()
}

func (o PutAliasRequestPropertiesOutput) ToPutAliasRequestPropertiesOutput() PutAliasRequestPropertiesOutput {
	return o
}

func (o PutAliasRequestPropertiesOutput) ToPutAliasRequestPropertiesOutputWithContext(ctx context.Context) PutAliasRequestPropertiesOutput {
	return o
}

func (o PutAliasRequestPropertiesOutput) ToPutAliasRequestPropertiesPtrOutput() PutAliasRequestPropertiesPtrOutput {
	return o.ToPutAliasRequestPropertiesPtrOutputWithContext(context.Background())
}

func (o PutAliasRequestPropertiesOutput) ToPutAliasRequestPropertiesPtrOutputWithContext(ctx context.Context) PutAliasRequestPropertiesPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v PutAliasRequestProperties) *PutAliasRequestProperties {
		return &v
	}).(PutAliasRequestPropertiesPtrOutput)
}

// Determines whether subscription is fieldLed, partnerLed or LegacyEA
func (o PutAliasRequestPropertiesOutput) BillingScope() pulumi.StringOutput {
	return o.ApplyT(func(v PutAliasRequestProperties) string { return v.BillingScope }).(pulumi.StringOutput)
}

// The friendly name of the subscription.
func (o PutAliasRequestPropertiesOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v PutAliasRequestProperties) string { return v.DisplayName }).(pulumi.StringOutput)
}

// This parameter can be used to create alias for existing subscription Id
func (o PutAliasRequestPropertiesOutput) SubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PutAliasRequestProperties) *string { return v.SubscriptionId }).(pulumi.StringPtrOutput)
}

// The workload type of the subscription. It can be either Production or DevTest.
func (o PutAliasRequestPropertiesOutput) Workload() pulumi.StringOutput {
	return o.ApplyT(func(v PutAliasRequestProperties) string { return v.Workload }).(pulumi.StringOutput)
}

type PutAliasRequestPropertiesPtrOutput struct{ *pulumi.OutputState }

func (PutAliasRequestPropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PutAliasRequestProperties)(nil)).Elem()
}

func (o PutAliasRequestPropertiesPtrOutput) ToPutAliasRequestPropertiesPtrOutput() PutAliasRequestPropertiesPtrOutput {
	return o
}

func (o PutAliasRequestPropertiesPtrOutput) ToPutAliasRequestPropertiesPtrOutputWithContext(ctx context.Context) PutAliasRequestPropertiesPtrOutput {
	return o
}

func (o PutAliasRequestPropertiesPtrOutput) Elem() PutAliasRequestPropertiesOutput {
	return o.ApplyT(func(v *PutAliasRequestProperties) PutAliasRequestProperties {
		if v != nil {
			return *v
		}
		var ret PutAliasRequestProperties
		return ret
	}).(PutAliasRequestPropertiesOutput)
}

// Determines whether subscription is fieldLed, partnerLed or LegacyEA
func (o PutAliasRequestPropertiesPtrOutput) BillingScope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PutAliasRequestProperties) *string {
		if v == nil {
			return nil
		}
		return &v.BillingScope
	}).(pulumi.StringPtrOutput)
}

// The friendly name of the subscription.
func (o PutAliasRequestPropertiesPtrOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PutAliasRequestProperties) *string {
		if v == nil {
			return nil
		}
		return &v.DisplayName
	}).(pulumi.StringPtrOutput)
}

// This parameter can be used to create alias for existing subscription Id
func (o PutAliasRequestPropertiesPtrOutput) SubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PutAliasRequestProperties) *string {
		if v == nil {
			return nil
		}
		return v.SubscriptionId
	}).(pulumi.StringPtrOutput)
}

// The workload type of the subscription. It can be either Production or DevTest.
func (o PutAliasRequestPropertiesPtrOutput) Workload() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PutAliasRequestProperties) *string {
		if v == nil {
			return nil
		}
		return &v.Workload
	}).(pulumi.StringPtrOutput)
}

// Put subscription creation result properties.
type PutAliasResponsePropertiesResponse struct {
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Newly created subscription Id.
	SubscriptionId string `pulumi:"subscriptionId"`
}

// Put subscription creation result properties.
type PutAliasResponsePropertiesResponseOutput struct{ *pulumi.OutputState }

func (PutAliasResponsePropertiesResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PutAliasResponsePropertiesResponse)(nil)).Elem()
}

func (o PutAliasResponsePropertiesResponseOutput) ToPutAliasResponsePropertiesResponseOutput() PutAliasResponsePropertiesResponseOutput {
	return o
}

func (o PutAliasResponsePropertiesResponseOutput) ToPutAliasResponsePropertiesResponseOutputWithContext(ctx context.Context) PutAliasResponsePropertiesResponseOutput {
	return o
}

// The provisioning state of the resource.
func (o PutAliasResponsePropertiesResponseOutput) ProvisioningState() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PutAliasResponsePropertiesResponse) *string { return v.ProvisioningState }).(pulumi.StringPtrOutput)
}

// Newly created subscription Id.
func (o PutAliasResponsePropertiesResponseOutput) SubscriptionId() pulumi.StringOutput {
	return o.ApplyT(func(v PutAliasResponsePropertiesResponse) string { return v.SubscriptionId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(PutAliasRequestPropertiesOutput{})
	pulumi.RegisterOutputType(PutAliasRequestPropertiesPtrOutput{})
	pulumi.RegisterOutputType(PutAliasResponsePropertiesResponseOutput{})
}
