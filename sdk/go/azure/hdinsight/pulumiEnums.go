// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package hdinsight

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type DaysOfWeek string

const (
	DaysOfWeekMonday    = DaysOfWeek("Monday")
	DaysOfWeekTuesday   = DaysOfWeek("Tuesday")
	DaysOfWeekWednesday = DaysOfWeek("Wednesday")
	DaysOfWeekThursday  = DaysOfWeek("Thursday")
	DaysOfWeekFriday    = DaysOfWeek("Friday")
	DaysOfWeekSaturday  = DaysOfWeek("Saturday")
	DaysOfWeekSunday    = DaysOfWeek("Sunday")
)

func (DaysOfWeek) ElementType() reflect.Type {
	return reflect.TypeOf((*DaysOfWeek)(nil)).Elem()
}

func (e DaysOfWeek) ToDaysOfWeekOutput() DaysOfWeekOutput {
	return pulumi.ToOutput(e).(DaysOfWeekOutput)
}

func (e DaysOfWeek) ToDaysOfWeekOutputWithContext(ctx context.Context) DaysOfWeekOutput {
	return pulumi.ToOutputWithContext(ctx, e).(DaysOfWeekOutput)
}

func (e DaysOfWeek) ToDaysOfWeekPtrOutput() DaysOfWeekPtrOutput {
	return e.ToDaysOfWeekPtrOutputWithContext(context.Background())
}

func (e DaysOfWeek) ToDaysOfWeekPtrOutputWithContext(ctx context.Context) DaysOfWeekPtrOutput {
	return DaysOfWeek(e).ToDaysOfWeekOutputWithContext(ctx).ToDaysOfWeekPtrOutputWithContext(ctx)
}

func (e DaysOfWeek) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e DaysOfWeek) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e DaysOfWeek) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e DaysOfWeek) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type DaysOfWeekOutput struct{ *pulumi.OutputState }

func (DaysOfWeekOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DaysOfWeek)(nil)).Elem()
}

func (o DaysOfWeekOutput) ToDaysOfWeekOutput() DaysOfWeekOutput {
	return o
}

func (o DaysOfWeekOutput) ToDaysOfWeekOutputWithContext(ctx context.Context) DaysOfWeekOutput {
	return o
}

func (o DaysOfWeekOutput) ToDaysOfWeekPtrOutput() DaysOfWeekPtrOutput {
	return o.ToDaysOfWeekPtrOutputWithContext(context.Background())
}

func (o DaysOfWeekOutput) ToDaysOfWeekPtrOutputWithContext(ctx context.Context) DaysOfWeekPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v DaysOfWeek) *DaysOfWeek {
		return &v
	}).(DaysOfWeekPtrOutput)
}

func (o DaysOfWeekOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o DaysOfWeekOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e DaysOfWeek) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o DaysOfWeekOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o DaysOfWeekOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e DaysOfWeek) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type DaysOfWeekPtrOutput struct{ *pulumi.OutputState }

func (DaysOfWeekPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DaysOfWeek)(nil)).Elem()
}

func (o DaysOfWeekPtrOutput) ToDaysOfWeekPtrOutput() DaysOfWeekPtrOutput {
	return o
}

func (o DaysOfWeekPtrOutput) ToDaysOfWeekPtrOutputWithContext(ctx context.Context) DaysOfWeekPtrOutput {
	return o
}

func (o DaysOfWeekPtrOutput) Elem() DaysOfWeekOutput {
	return o.ApplyT(func(v *DaysOfWeek) DaysOfWeek {
		if v != nil {
			return *v
		}
		var ret DaysOfWeek
		return ret
	}).(DaysOfWeekOutput)
}

func (o DaysOfWeekPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o DaysOfWeekPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *DaysOfWeek) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// DaysOfWeekInput is an input type that accepts DaysOfWeekArgs and DaysOfWeekOutput values.
// You can construct a concrete instance of `DaysOfWeekInput` via:
//
//          DaysOfWeekArgs{...}
type DaysOfWeekInput interface {
	pulumi.Input

	ToDaysOfWeekOutput() DaysOfWeekOutput
	ToDaysOfWeekOutputWithContext(context.Context) DaysOfWeekOutput
}

var daysOfWeekPtrType = reflect.TypeOf((**DaysOfWeek)(nil)).Elem()

type DaysOfWeekPtrInput interface {
	pulumi.Input

	ToDaysOfWeekPtrOutput() DaysOfWeekPtrOutput
	ToDaysOfWeekPtrOutputWithContext(context.Context) DaysOfWeekPtrOutput
}

type daysOfWeekPtr string

func DaysOfWeekPtr(v string) DaysOfWeekPtrInput {
	return (*daysOfWeekPtr)(&v)
}

func (*daysOfWeekPtr) ElementType() reflect.Type {
	return daysOfWeekPtrType
}

func (in *daysOfWeekPtr) ToDaysOfWeekPtrOutput() DaysOfWeekPtrOutput {
	return pulumi.ToOutput(in).(DaysOfWeekPtrOutput)
}

func (in *daysOfWeekPtr) ToDaysOfWeekPtrOutputWithContext(ctx context.Context) DaysOfWeekPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(DaysOfWeekPtrOutput)
}

// DaysOfWeekArrayInput is an input type that accepts DaysOfWeekArray and DaysOfWeekArrayOutput values.
// You can construct a concrete instance of `DaysOfWeekArrayInput` via:
//
//          DaysOfWeekArray{ DaysOfWeekArgs{...} }
type DaysOfWeekArrayInput interface {
	pulumi.Input

	ToDaysOfWeekArrayOutput() DaysOfWeekArrayOutput
	ToDaysOfWeekArrayOutputWithContext(context.Context) DaysOfWeekArrayOutput
}

type DaysOfWeekArray []DaysOfWeek

func (DaysOfWeekArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]DaysOfWeek)(nil)).Elem()
}

func (i DaysOfWeekArray) ToDaysOfWeekArrayOutput() DaysOfWeekArrayOutput {
	return i.ToDaysOfWeekArrayOutputWithContext(context.Background())
}

func (i DaysOfWeekArray) ToDaysOfWeekArrayOutputWithContext(ctx context.Context) DaysOfWeekArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DaysOfWeekArrayOutput)
}

type DaysOfWeekArrayOutput struct{ *pulumi.OutputState }

func (DaysOfWeekArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]DaysOfWeek)(nil)).Elem()
}

func (o DaysOfWeekArrayOutput) ToDaysOfWeekArrayOutput() DaysOfWeekArrayOutput {
	return o
}

func (o DaysOfWeekArrayOutput) ToDaysOfWeekArrayOutputWithContext(ctx context.Context) DaysOfWeekArrayOutput {
	return o
}

func (o DaysOfWeekArrayOutput) Index(i pulumi.IntInput) DaysOfWeekOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) DaysOfWeek {
		return vs[0].([]DaysOfWeek)[vs[1].(int)]
	}).(DaysOfWeekOutput)
}

// The directory type.
type DirectoryType string

const (
	DirectoryTypeActiveDirectory = DirectoryType("ActiveDirectory")
)

func (DirectoryType) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectoryType)(nil)).Elem()
}

func (e DirectoryType) ToDirectoryTypeOutput() DirectoryTypeOutput {
	return pulumi.ToOutput(e).(DirectoryTypeOutput)
}

func (e DirectoryType) ToDirectoryTypeOutputWithContext(ctx context.Context) DirectoryTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(DirectoryTypeOutput)
}

func (e DirectoryType) ToDirectoryTypePtrOutput() DirectoryTypePtrOutput {
	return e.ToDirectoryTypePtrOutputWithContext(context.Background())
}

func (e DirectoryType) ToDirectoryTypePtrOutputWithContext(ctx context.Context) DirectoryTypePtrOutput {
	return DirectoryType(e).ToDirectoryTypeOutputWithContext(ctx).ToDirectoryTypePtrOutputWithContext(ctx)
}

func (e DirectoryType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e DirectoryType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e DirectoryType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e DirectoryType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type DirectoryTypeOutput struct{ *pulumi.OutputState }

func (DirectoryTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectoryType)(nil)).Elem()
}

func (o DirectoryTypeOutput) ToDirectoryTypeOutput() DirectoryTypeOutput {
	return o
}

func (o DirectoryTypeOutput) ToDirectoryTypeOutputWithContext(ctx context.Context) DirectoryTypeOutput {
	return o
}

func (o DirectoryTypeOutput) ToDirectoryTypePtrOutput() DirectoryTypePtrOutput {
	return o.ToDirectoryTypePtrOutputWithContext(context.Background())
}

func (o DirectoryTypeOutput) ToDirectoryTypePtrOutputWithContext(ctx context.Context) DirectoryTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v DirectoryType) *DirectoryType {
		return &v
	}).(DirectoryTypePtrOutput)
}

func (o DirectoryTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o DirectoryTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e DirectoryType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o DirectoryTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o DirectoryTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e DirectoryType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type DirectoryTypePtrOutput struct{ *pulumi.OutputState }

func (DirectoryTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectoryType)(nil)).Elem()
}

func (o DirectoryTypePtrOutput) ToDirectoryTypePtrOutput() DirectoryTypePtrOutput {
	return o
}

func (o DirectoryTypePtrOutput) ToDirectoryTypePtrOutputWithContext(ctx context.Context) DirectoryTypePtrOutput {
	return o
}

func (o DirectoryTypePtrOutput) Elem() DirectoryTypeOutput {
	return o.ApplyT(func(v *DirectoryType) DirectoryType {
		if v != nil {
			return *v
		}
		var ret DirectoryType
		return ret
	}).(DirectoryTypeOutput)
}

func (o DirectoryTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o DirectoryTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *DirectoryType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// DirectoryTypeInput is an input type that accepts DirectoryTypeArgs and DirectoryTypeOutput values.
// You can construct a concrete instance of `DirectoryTypeInput` via:
//
//          DirectoryTypeArgs{...}
type DirectoryTypeInput interface {
	pulumi.Input

	ToDirectoryTypeOutput() DirectoryTypeOutput
	ToDirectoryTypeOutputWithContext(context.Context) DirectoryTypeOutput
}

var directoryTypePtrType = reflect.TypeOf((**DirectoryType)(nil)).Elem()

type DirectoryTypePtrInput interface {
	pulumi.Input

	ToDirectoryTypePtrOutput() DirectoryTypePtrOutput
	ToDirectoryTypePtrOutputWithContext(context.Context) DirectoryTypePtrOutput
}

type directoryTypePtr string

func DirectoryTypePtr(v string) DirectoryTypePtrInput {
	return (*directoryTypePtr)(&v)
}

func (*directoryTypePtr) ElementType() reflect.Type {
	return directoryTypePtrType
}

func (in *directoryTypePtr) ToDirectoryTypePtrOutput() DirectoryTypePtrOutput {
	return pulumi.ToOutput(in).(DirectoryTypePtrOutput)
}

func (in *directoryTypePtr) ToDirectoryTypePtrOutputWithContext(ctx context.Context) DirectoryTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(DirectoryTypePtrOutput)
}

// Algorithm identifier for encryption, default RSA-OAEP.
type JsonWebKeyEncryptionAlgorithm string

const (
	JsonWebKeyEncryptionAlgorithm_RSA_OAEP     = JsonWebKeyEncryptionAlgorithm("RSA-OAEP")
	JsonWebKeyEncryptionAlgorithm_RSA_OAEP_256 = JsonWebKeyEncryptionAlgorithm("RSA-OAEP-256")
	JsonWebKeyEncryptionAlgorithm_RSA1_5       = JsonWebKeyEncryptionAlgorithm("RSA1_5")
)

// The type of operating system.
type OSType string

const (
	OSTypeWindows = OSType("Windows")
	OSTypeLinux   = OSType("Linux")
)

func (OSType) ElementType() reflect.Type {
	return reflect.TypeOf((*OSType)(nil)).Elem()
}

func (e OSType) ToOSTypeOutput() OSTypeOutput {
	return pulumi.ToOutput(e).(OSTypeOutput)
}

func (e OSType) ToOSTypeOutputWithContext(ctx context.Context) OSTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(OSTypeOutput)
}

func (e OSType) ToOSTypePtrOutput() OSTypePtrOutput {
	return e.ToOSTypePtrOutputWithContext(context.Background())
}

func (e OSType) ToOSTypePtrOutputWithContext(ctx context.Context) OSTypePtrOutput {
	return OSType(e).ToOSTypeOutputWithContext(ctx).ToOSTypePtrOutputWithContext(ctx)
}

func (e OSType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e OSType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e OSType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e OSType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type OSTypeOutput struct{ *pulumi.OutputState }

func (OSTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OSType)(nil)).Elem()
}

func (o OSTypeOutput) ToOSTypeOutput() OSTypeOutput {
	return o
}

func (o OSTypeOutput) ToOSTypeOutputWithContext(ctx context.Context) OSTypeOutput {
	return o
}

func (o OSTypeOutput) ToOSTypePtrOutput() OSTypePtrOutput {
	return o.ToOSTypePtrOutputWithContext(context.Background())
}

func (o OSTypeOutput) ToOSTypePtrOutputWithContext(ctx context.Context) OSTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v OSType) *OSType {
		return &v
	}).(OSTypePtrOutput)
}

func (o OSTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o OSTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e OSType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o OSTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o OSTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e OSType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type OSTypePtrOutput struct{ *pulumi.OutputState }

func (OSTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OSType)(nil)).Elem()
}

func (o OSTypePtrOutput) ToOSTypePtrOutput() OSTypePtrOutput {
	return o
}

func (o OSTypePtrOutput) ToOSTypePtrOutputWithContext(ctx context.Context) OSTypePtrOutput {
	return o
}

func (o OSTypePtrOutput) Elem() OSTypeOutput {
	return o.ApplyT(func(v *OSType) OSType {
		if v != nil {
			return *v
		}
		var ret OSType
		return ret
	}).(OSTypeOutput)
}

func (o OSTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o OSTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *OSType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// OSTypeInput is an input type that accepts OSTypeArgs and OSTypeOutput values.
// You can construct a concrete instance of `OSTypeInput` via:
//
//          OSTypeArgs{...}
type OSTypeInput interface {
	pulumi.Input

	ToOSTypeOutput() OSTypeOutput
	ToOSTypeOutputWithContext(context.Context) OSTypeOutput
}

var ostypePtrType = reflect.TypeOf((**OSType)(nil)).Elem()

type OSTypePtrInput interface {
	pulumi.Input

	ToOSTypePtrOutput() OSTypePtrOutput
	ToOSTypePtrOutputWithContext(context.Context) OSTypePtrOutput
}

type ostypePtr string

func OSTypePtr(v string) OSTypePtrInput {
	return (*ostypePtr)(&v)
}

func (*ostypePtr) ElementType() reflect.Type {
	return ostypePtrType
}

func (in *ostypePtr) ToOSTypePtrOutput() OSTypePtrOutput {
	return pulumi.ToOutput(in).(OSTypePtrOutput)
}

func (in *ostypePtr) ToOSTypePtrOutputWithContext(ctx context.Context) OSTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(OSTypePtrOutput)
}

// Indicates whether or not private link is enabled.
type PrivateLink string

const (
	PrivateLinkDisabled = PrivateLink("Disabled")
	PrivateLinkEnabled  = PrivateLink("Enabled")
)

// The concrete private link service connection.
type PrivateLinkServiceConnectionStatus string

const (
	PrivateLinkServiceConnectionStatusApproved = PrivateLinkServiceConnectionStatus("Approved")
	PrivateLinkServiceConnectionStatusRejected = PrivateLinkServiceConnectionStatus("Rejected")
	PrivateLinkServiceConnectionStatusPending  = PrivateLinkServiceConnectionStatus("Pending")
	PrivateLinkServiceConnectionStatusRemoved  = PrivateLinkServiceConnectionStatus("Removed")
)

// The type of identity used for the cluster. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities.
type ResourceIdentityType string

const (
	ResourceIdentityTypeSystemAssigned               = ResourceIdentityType("SystemAssigned")
	ResourceIdentityTypeUserAssigned                 = ResourceIdentityType("UserAssigned")
	ResourceIdentityType_SystemAssigned_UserAssigned = ResourceIdentityType("SystemAssigned, UserAssigned")
	ResourceIdentityTypeNone                         = ResourceIdentityType("None")
)

func (ResourceIdentityType) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourceIdentityType)(nil)).Elem()
}

func (e ResourceIdentityType) ToResourceIdentityTypeOutput() ResourceIdentityTypeOutput {
	return pulumi.ToOutput(e).(ResourceIdentityTypeOutput)
}

func (e ResourceIdentityType) ToResourceIdentityTypeOutputWithContext(ctx context.Context) ResourceIdentityTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(ResourceIdentityTypeOutput)
}

func (e ResourceIdentityType) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return e.ToResourceIdentityTypePtrOutputWithContext(context.Background())
}

func (e ResourceIdentityType) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return ResourceIdentityType(e).ToResourceIdentityTypeOutputWithContext(ctx).ToResourceIdentityTypePtrOutputWithContext(ctx)
}

func (e ResourceIdentityType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ResourceIdentityType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ResourceIdentityType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ResourceIdentityType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type ResourceIdentityTypeOutput struct{ *pulumi.OutputState }

func (ResourceIdentityTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourceIdentityType)(nil)).Elem()
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypeOutput() ResourceIdentityTypeOutput {
	return o
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypeOutputWithContext(ctx context.Context) ResourceIdentityTypeOutput {
	return o
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return o.ToResourceIdentityTypePtrOutputWithContext(context.Background())
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ResourceIdentityType) *ResourceIdentityType {
		return &v
	}).(ResourceIdentityTypePtrOutput)
}

func (o ResourceIdentityTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o ResourceIdentityTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ResourceIdentityType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o ResourceIdentityTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ResourceIdentityTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ResourceIdentityType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type ResourceIdentityTypePtrOutput struct{ *pulumi.OutputState }

func (ResourceIdentityTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourceIdentityType)(nil)).Elem()
}

func (o ResourceIdentityTypePtrOutput) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return o
}

func (o ResourceIdentityTypePtrOutput) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return o
}

func (o ResourceIdentityTypePtrOutput) Elem() ResourceIdentityTypeOutput {
	return o.ApplyT(func(v *ResourceIdentityType) ResourceIdentityType {
		if v != nil {
			return *v
		}
		var ret ResourceIdentityType
		return ret
	}).(ResourceIdentityTypeOutput)
}

func (o ResourceIdentityTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ResourceIdentityTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *ResourceIdentityType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// ResourceIdentityTypeInput is an input type that accepts ResourceIdentityTypeArgs and ResourceIdentityTypeOutput values.
// You can construct a concrete instance of `ResourceIdentityTypeInput` via:
//
//          ResourceIdentityTypeArgs{...}
type ResourceIdentityTypeInput interface {
	pulumi.Input

	ToResourceIdentityTypeOutput() ResourceIdentityTypeOutput
	ToResourceIdentityTypeOutputWithContext(context.Context) ResourceIdentityTypeOutput
}

var resourceIdentityTypePtrType = reflect.TypeOf((**ResourceIdentityType)(nil)).Elem()

type ResourceIdentityTypePtrInput interface {
	pulumi.Input

	ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput
	ToResourceIdentityTypePtrOutputWithContext(context.Context) ResourceIdentityTypePtrOutput
}

type resourceIdentityTypePtr string

func ResourceIdentityTypePtr(v string) ResourceIdentityTypePtrInput {
	return (*resourceIdentityTypePtr)(&v)
}

func (*resourceIdentityTypePtr) ElementType() reflect.Type {
	return resourceIdentityTypePtrType
}

func (in *resourceIdentityTypePtr) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return pulumi.ToOutput(in).(ResourceIdentityTypePtrOutput)
}

func (in *resourceIdentityTypePtr) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(ResourceIdentityTypePtrOutput)
}

// The direction for the resource provider connection.
type ResourceProviderConnection string

const (
	ResourceProviderConnectionInbound  = ResourceProviderConnection("Inbound")
	ResourceProviderConnectionOutbound = ResourceProviderConnection("Outbound")
)

// The cluster tier.
type Tier string

const (
	TierStandard = Tier("Standard")
	TierPremium  = Tier("Premium")
)

func (Tier) ElementType() reflect.Type {
	return reflect.TypeOf((*Tier)(nil)).Elem()
}

func (e Tier) ToTierOutput() TierOutput {
	return pulumi.ToOutput(e).(TierOutput)
}

func (e Tier) ToTierOutputWithContext(ctx context.Context) TierOutput {
	return pulumi.ToOutputWithContext(ctx, e).(TierOutput)
}

func (e Tier) ToTierPtrOutput() TierPtrOutput {
	return e.ToTierPtrOutputWithContext(context.Background())
}

func (e Tier) ToTierPtrOutputWithContext(ctx context.Context) TierPtrOutput {
	return Tier(e).ToTierOutputWithContext(ctx).ToTierPtrOutputWithContext(ctx)
}

func (e Tier) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e Tier) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e Tier) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e Tier) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type TierOutput struct{ *pulumi.OutputState }

func (TierOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Tier)(nil)).Elem()
}

func (o TierOutput) ToTierOutput() TierOutput {
	return o
}

func (o TierOutput) ToTierOutputWithContext(ctx context.Context) TierOutput {
	return o
}

func (o TierOutput) ToTierPtrOutput() TierPtrOutput {
	return o.ToTierPtrOutputWithContext(context.Background())
}

func (o TierOutput) ToTierPtrOutputWithContext(ctx context.Context) TierPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v Tier) *Tier {
		return &v
	}).(TierPtrOutput)
}

func (o TierOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o TierOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e Tier) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o TierOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o TierOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e Tier) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type TierPtrOutput struct{ *pulumi.OutputState }

func (TierPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Tier)(nil)).Elem()
}

func (o TierPtrOutput) ToTierPtrOutput() TierPtrOutput {
	return o
}

func (o TierPtrOutput) ToTierPtrOutputWithContext(ctx context.Context) TierPtrOutput {
	return o
}

func (o TierPtrOutput) Elem() TierOutput {
	return o.ApplyT(func(v *Tier) Tier {
		if v != nil {
			return *v
		}
		var ret Tier
		return ret
	}).(TierOutput)
}

func (o TierPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o TierPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *Tier) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// TierInput is an input type that accepts TierArgs and TierOutput values.
// You can construct a concrete instance of `TierInput` via:
//
//          TierArgs{...}
type TierInput interface {
	pulumi.Input

	ToTierOutput() TierOutput
	ToTierOutputWithContext(context.Context) TierOutput
}

var tierPtrType = reflect.TypeOf((**Tier)(nil)).Elem()

type TierPtrInput interface {
	pulumi.Input

	ToTierPtrOutput() TierPtrOutput
	ToTierPtrOutputWithContext(context.Context) TierPtrOutput
}

type tierPtr string

func TierPtr(v string) TierPtrInput {
	return (*tierPtr)(&v)
}

func (*tierPtr) ElementType() reflect.Type {
	return tierPtrType
}

func (in *tierPtr) ToTierPtrOutput() TierPtrOutput {
	return pulumi.ToOutput(in).(TierPtrOutput)
}

func (in *tierPtr) ToTierPtrOutputWithContext(ctx context.Context) TierPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(TierPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(DaysOfWeekOutput{})
	pulumi.RegisterOutputType(DaysOfWeekPtrOutput{})
	pulumi.RegisterOutputType(DaysOfWeekArrayOutput{})
	pulumi.RegisterOutputType(DirectoryTypeOutput{})
	pulumi.RegisterOutputType(DirectoryTypePtrOutput{})
	pulumi.RegisterOutputType(OSTypeOutput{})
	pulumi.RegisterOutputType(OSTypePtrOutput{})
	pulumi.RegisterOutputType(ResourceIdentityTypeOutput{})
	pulumi.RegisterOutputType(ResourceIdentityTypePtrOutput{})
	pulumi.RegisterOutputType(TierOutput{})
	pulumi.RegisterOutputType(TierPtrOutput{})
}
