# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'ListNamedValueResult',
    'AwaitableListNamedValueResult',
    'list_named_value',
    'list_named_value_output',
]

@pulumi.output_type
class ListNamedValueResult:
    """
    Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.
    """
    def __init__(__self__, value=None):
        if value and not isinstance(value, str):
            raise TypeError("Expected argument 'value' to be a str")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        This is secret value of the NamedValue entity.
        """
        return pulumi.get(self, "value")


class AwaitableListNamedValueResult(ListNamedValueResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListNamedValueResult(
            value=self.value)


def list_named_value(named_value_id: Optional[str] = None,
                     resource_group_name: Optional[str] = None,
                     service_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListNamedValueResult:
    """
    Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.


    :param str named_value_id: Identifier of the NamedValue.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the API Management service.
    """
    __args__ = dict()
    __args__['namedValueId'] = named_value_id
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:apimanagement/v20211201preview:listNamedValue', __args__, opts=opts, typ=ListNamedValueResult).value

    return AwaitableListNamedValueResult(
        value=__ret__.value)


@_utilities.lift_output_func(list_named_value)
def list_named_value_output(named_value_id: Optional[pulumi.Input[str]] = None,
                            resource_group_name: Optional[pulumi.Input[str]] = None,
                            service_name: Optional[pulumi.Input[str]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListNamedValueResult]:
    """
    Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.


    :param str named_value_id: Identifier of the NamedValue.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the API Management service.
    """
    ...
