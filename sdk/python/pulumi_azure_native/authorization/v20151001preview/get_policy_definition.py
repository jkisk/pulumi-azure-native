# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetPolicyDefinitionResult',
    'AwaitableGetPolicyDefinitionResult',
    'get_policy_definition',
    'get_policy_definition_output',
]

warnings.warn("""Version 2015-10-01-preview will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetPolicyDefinitionResult:
    """
    The policy definition.
    """
    def __init__(__self__, description=None, display_name=None, id=None, name=None, policy_rule=None, policy_type=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if policy_rule and not isinstance(policy_rule, dict):
            raise TypeError("Expected argument 'policy_rule' to be a dict")
        pulumi.set(__self__, "policy_rule", policy_rule)
        if policy_type and not isinstance(policy_type, str):
            raise TypeError("Expected argument 'policy_type' to be a str")
        pulumi.set(__self__, "policy_type", policy_type)

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The policy definition description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name of the policy definition.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the policy definition.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="policyRule")
    def policy_rule(self) -> Optional[Any]:
        """
        The policy rule.
        """
        return pulumi.get(self, "policy_rule")

    @property
    @pulumi.getter(name="policyType")
    def policy_type(self) -> Optional[str]:
        """
        The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        """
        return pulumi.get(self, "policy_type")


class AwaitableGetPolicyDefinitionResult(GetPolicyDefinitionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyDefinitionResult(
            description=self.description,
            display_name=self.display_name,
            id=self.id,
            name=self.name,
            policy_rule=self.policy_rule,
            policy_type=self.policy_type)


def get_policy_definition(policy_definition_name: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPolicyDefinitionResult:
    """
    The policy definition.


    :param str policy_definition_name: The name of the policy definition to get.
    """
    pulumi.log.warn("""get_policy_definition is deprecated: Version 2015-10-01-preview will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['policyDefinitionName'] = policy_definition_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:authorization/v20151001preview:getPolicyDefinition', __args__, opts=opts, typ=GetPolicyDefinitionResult).value

    return AwaitableGetPolicyDefinitionResult(
        description=__ret__.description,
        display_name=__ret__.display_name,
        id=__ret__.id,
        name=__ret__.name,
        policy_rule=__ret__.policy_rule,
        policy_type=__ret__.policy_type)


@_utilities.lift_output_func(get_policy_definition)
def get_policy_definition_output(policy_definition_name: Optional[pulumi.Input[str]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPolicyDefinitionResult]:
    """
    The policy definition.


    :param str policy_definition_name: The name of the policy definition to get.
    """
    pulumi.log.warn("""get_policy_definition is deprecated: Version 2015-10-01-preview will be removed in v2 of the provider.""")
    ...
