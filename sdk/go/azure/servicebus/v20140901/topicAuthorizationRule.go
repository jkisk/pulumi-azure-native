// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20140901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Description of a namespace authorization rule.
//
// Deprecated: Version 2014-09-01 will be removed in v2 of the provider.
type TopicAuthorizationRule struct {
	pulumi.CustomResourceState

	// A string that describes Claim Type for authorization rule.
	ClaimType pulumi.StringPtrOutput `pulumi:"claimType"`
	// A string that describes Claim Value of authorization rule.
	ClaimValue pulumi.StringPtrOutput `pulumi:"claimValue"`
	// The time the namespace was created.
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// A string that describes the Key Name of authorization rule.
	KeyName pulumi.StringPtrOutput `pulumi:"keyName"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The time the namespace was updated.
	ModifiedTime pulumi.StringOutput `pulumi:"modifiedTime"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	PrimaryKey pulumi.StringPtrOutput `pulumi:"primaryKey"`
	// The rights associated with the rule.
	Rights pulumi.StringArrayOutput `pulumi:"rights"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	SecondaryKey pulumi.StringPtrOutput `pulumi:"secondaryKey"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewTopicAuthorizationRule registers a new resource with the given unique name, arguments, and options.
func NewTopicAuthorizationRule(ctx *pulumi.Context,
	name string, args *TopicAuthorizationRuleArgs, opts ...pulumi.ResourceOption) (*TopicAuthorizationRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NamespaceName == nil {
		return nil, errors.New("invalid value for required argument 'NamespaceName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Rights == nil {
		return nil, errors.New("invalid value for required argument 'Rights'")
	}
	if args.TopicName == nil {
		return nil, errors.New("invalid value for required argument 'TopicName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:servicebus:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20150801:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20170401:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20180101preview:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20210101preview:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20210601preview:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20211101:TopicAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-native:servicebus/v20220101preview:TopicAuthorizationRule"),
		},
	})
	opts = append(opts, aliases)
	var resource TopicAuthorizationRule
	err := ctx.RegisterResource("azure-native:servicebus/v20140901:TopicAuthorizationRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTopicAuthorizationRule gets an existing TopicAuthorizationRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTopicAuthorizationRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TopicAuthorizationRuleState, opts ...pulumi.ResourceOption) (*TopicAuthorizationRule, error) {
	var resource TopicAuthorizationRule
	err := ctx.ReadResource("azure-native:servicebus/v20140901:TopicAuthorizationRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TopicAuthorizationRule resources.
type topicAuthorizationRuleState struct {
}

type TopicAuthorizationRuleState struct {
}

func (TopicAuthorizationRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*topicAuthorizationRuleState)(nil)).Elem()
}

type topicAuthorizationRuleArgs struct {
	// The authorization rule name.
	AuthorizationRuleName *string `pulumi:"authorizationRuleName"`
	// A string that describes Claim Type for authorization rule.
	ClaimType *string `pulumi:"claimType"`
	// A string that describes Claim Value of authorization rule.
	ClaimValue *string `pulumi:"claimValue"`
	// A string that describes the Key Name of authorization rule.
	KeyName *string `pulumi:"keyName"`
	// data center location.
	Location *string `pulumi:"location"`
	// Name of the authorization rule.
	Name *string `pulumi:"name"`
	// The namespace name
	NamespaceName string `pulumi:"namespaceName"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	PrimaryKey *string `pulumi:"primaryKey"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The rights associated with the rule.
	Rights []AccessRights `pulumi:"rights"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	SecondaryKey *string `pulumi:"secondaryKey"`
	// The topic name.
	TopicName string `pulumi:"topicName"`
}

// The set of arguments for constructing a TopicAuthorizationRule resource.
type TopicAuthorizationRuleArgs struct {
	// The authorization rule name.
	AuthorizationRuleName pulumi.StringPtrInput
	// A string that describes Claim Type for authorization rule.
	ClaimType pulumi.StringPtrInput
	// A string that describes Claim Value of authorization rule.
	ClaimValue pulumi.StringPtrInput
	// A string that describes the Key Name of authorization rule.
	KeyName pulumi.StringPtrInput
	// data center location.
	Location pulumi.StringPtrInput
	// Name of the authorization rule.
	Name pulumi.StringPtrInput
	// The namespace name
	NamespaceName pulumi.StringInput
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	PrimaryKey pulumi.StringPtrInput
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The rights associated with the rule.
	Rights AccessRightsArrayInput
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	SecondaryKey pulumi.StringPtrInput
	// The topic name.
	TopicName pulumi.StringInput
}

func (TopicAuthorizationRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*topicAuthorizationRuleArgs)(nil)).Elem()
}

type TopicAuthorizationRuleInput interface {
	pulumi.Input

	ToTopicAuthorizationRuleOutput() TopicAuthorizationRuleOutput
	ToTopicAuthorizationRuleOutputWithContext(ctx context.Context) TopicAuthorizationRuleOutput
}

func (*TopicAuthorizationRule) ElementType() reflect.Type {
	return reflect.TypeOf((**TopicAuthorizationRule)(nil)).Elem()
}

func (i *TopicAuthorizationRule) ToTopicAuthorizationRuleOutput() TopicAuthorizationRuleOutput {
	return i.ToTopicAuthorizationRuleOutputWithContext(context.Background())
}

func (i *TopicAuthorizationRule) ToTopicAuthorizationRuleOutputWithContext(ctx context.Context) TopicAuthorizationRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TopicAuthorizationRuleOutput)
}

type TopicAuthorizationRuleOutput struct{ *pulumi.OutputState }

func (TopicAuthorizationRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TopicAuthorizationRule)(nil)).Elem()
}

func (o TopicAuthorizationRuleOutput) ToTopicAuthorizationRuleOutput() TopicAuthorizationRuleOutput {
	return o
}

func (o TopicAuthorizationRuleOutput) ToTopicAuthorizationRuleOutputWithContext(ctx context.Context) TopicAuthorizationRuleOutput {
	return o
}

// A string that describes Claim Type for authorization rule.
func (o TopicAuthorizationRuleOutput) ClaimType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringPtrOutput { return v.ClaimType }).(pulumi.StringPtrOutput)
}

// A string that describes Claim Value of authorization rule.
func (o TopicAuthorizationRuleOutput) ClaimValue() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringPtrOutput { return v.ClaimValue }).(pulumi.StringPtrOutput)
}

// The time the namespace was created.
func (o TopicAuthorizationRuleOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringOutput { return v.CreatedTime }).(pulumi.StringOutput)
}

// A string that describes the Key Name of authorization rule.
func (o TopicAuthorizationRuleOutput) KeyName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringPtrOutput { return v.KeyName }).(pulumi.StringPtrOutput)
}

// Resource location.
func (o TopicAuthorizationRuleOutput) Location() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringPtrOutput { return v.Location }).(pulumi.StringPtrOutput)
}

// The time the namespace was updated.
func (o TopicAuthorizationRuleOutput) ModifiedTime() pulumi.StringOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringOutput { return v.ModifiedTime }).(pulumi.StringOutput)
}

// Resource name
func (o TopicAuthorizationRuleOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// A base64-encoded 256-bit primary key for signing and validating the SAS token.
func (o TopicAuthorizationRuleOutput) PrimaryKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringPtrOutput { return v.PrimaryKey }).(pulumi.StringPtrOutput)
}

// The rights associated with the rule.
func (o TopicAuthorizationRuleOutput) Rights() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringArrayOutput { return v.Rights }).(pulumi.StringArrayOutput)
}

// A base64-encoded 256-bit primary key for signing and validating the SAS token.
func (o TopicAuthorizationRuleOutput) SecondaryKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringPtrOutput { return v.SecondaryKey }).(pulumi.StringPtrOutput)
}

// Resource type
func (o TopicAuthorizationRuleOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *TopicAuthorizationRule) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(TopicAuthorizationRuleOutput{})
}
