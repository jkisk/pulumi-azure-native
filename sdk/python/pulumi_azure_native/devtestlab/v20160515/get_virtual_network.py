# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs

__all__ = [
    'GetVirtualNetworkResult',
    'AwaitableGetVirtualNetworkResult',
    'get_virtual_network',
    'get_virtual_network_output',
]

warnings.warn("""Version 2016-05-15 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetVirtualNetworkResult:
    """
    A virtual network.
    """
    def __init__(__self__, allowed_subnets=None, created_date=None, description=None, external_provider_resource_id=None, external_subnets=None, id=None, location=None, name=None, provisioning_state=None, subnet_overrides=None, tags=None, type=None, unique_identifier=None):
        if allowed_subnets and not isinstance(allowed_subnets, list):
            raise TypeError("Expected argument 'allowed_subnets' to be a list")
        pulumi.set(__self__, "allowed_subnets", allowed_subnets)
        if created_date and not isinstance(created_date, str):
            raise TypeError("Expected argument 'created_date' to be a str")
        pulumi.set(__self__, "created_date", created_date)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if external_provider_resource_id and not isinstance(external_provider_resource_id, str):
            raise TypeError("Expected argument 'external_provider_resource_id' to be a str")
        pulumi.set(__self__, "external_provider_resource_id", external_provider_resource_id)
        if external_subnets and not isinstance(external_subnets, list):
            raise TypeError("Expected argument 'external_subnets' to be a list")
        pulumi.set(__self__, "external_subnets", external_subnets)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if subnet_overrides and not isinstance(subnet_overrides, list):
            raise TypeError("Expected argument 'subnet_overrides' to be a list")
        pulumi.set(__self__, "subnet_overrides", subnet_overrides)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if unique_identifier and not isinstance(unique_identifier, str):
            raise TypeError("Expected argument 'unique_identifier' to be a str")
        pulumi.set(__self__, "unique_identifier", unique_identifier)

    @property
    @pulumi.getter(name="allowedSubnets")
    def allowed_subnets(self) -> Optional[Sequence['outputs.SubnetResponse']]:
        """
        The allowed subnets of the virtual network.
        """
        return pulumi.get(self, "allowed_subnets")

    @property
    @pulumi.getter(name="createdDate")
    def created_date(self) -> str:
        """
        The creation date of the virtual network.
        """
        return pulumi.get(self, "created_date")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The description of the virtual network.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="externalProviderResourceId")
    def external_provider_resource_id(self) -> Optional[str]:
        """
        The Microsoft.Network resource identifier of the virtual network.
        """
        return pulumi.get(self, "external_provider_resource_id")

    @property
    @pulumi.getter(name="externalSubnets")
    def external_subnets(self) -> Optional[Sequence['outputs.ExternalSubnetResponse']]:
        """
        The external subnet properties.
        """
        return pulumi.get(self, "external_subnets")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The identifier of the resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The location of the resource.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        The provisioning status of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="subnetOverrides")
    def subnet_overrides(self) -> Optional[Sequence['outputs.SubnetOverrideResponse']]:
        """
        The subnet overrides of the virtual network.
        """
        return pulumi.get(self, "subnet_overrides")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        The tags of the resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="uniqueIdentifier")
    def unique_identifier(self) -> Optional[str]:
        """
        The unique immutable identifier of a resource (Guid).
        """
        return pulumi.get(self, "unique_identifier")


class AwaitableGetVirtualNetworkResult(GetVirtualNetworkResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVirtualNetworkResult(
            allowed_subnets=self.allowed_subnets,
            created_date=self.created_date,
            description=self.description,
            external_provider_resource_id=self.external_provider_resource_id,
            external_subnets=self.external_subnets,
            id=self.id,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            subnet_overrides=self.subnet_overrides,
            tags=self.tags,
            type=self.type,
            unique_identifier=self.unique_identifier)


def get_virtual_network(expand: Optional[str] = None,
                        lab_name: Optional[str] = None,
                        name: Optional[str] = None,
                        resource_group_name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVirtualNetworkResult:
    """
    A virtual network.


    :param str expand: Specify the $expand query. Example: 'properties($expand=externalSubnets)'
    :param str lab_name: The name of the lab.
    :param str name: The name of the virtual network.
    :param str resource_group_name: The name of the resource group.
    """
    pulumi.log.warn("""get_virtual_network is deprecated: Version 2016-05-15 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['expand'] = expand
    __args__['labName'] = lab_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:devtestlab/v20160515:getVirtualNetwork', __args__, opts=opts, typ=GetVirtualNetworkResult).value

    return AwaitableGetVirtualNetworkResult(
        allowed_subnets=__ret__.allowed_subnets,
        created_date=__ret__.created_date,
        description=__ret__.description,
        external_provider_resource_id=__ret__.external_provider_resource_id,
        external_subnets=__ret__.external_subnets,
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        subnet_overrides=__ret__.subnet_overrides,
        tags=__ret__.tags,
        type=__ret__.type,
        unique_identifier=__ret__.unique_identifier)


@_utilities.lift_output_func(get_virtual_network)
def get_virtual_network_output(expand: Optional[pulumi.Input[Optional[str]]] = None,
                               lab_name: Optional[pulumi.Input[str]] = None,
                               name: Optional[pulumi.Input[str]] = None,
                               resource_group_name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVirtualNetworkResult]:
    """
    A virtual network.


    :param str expand: Specify the $expand query. Example: 'properties($expand=externalSubnets)'
    :param str lab_name: The name of the lab.
    :param str name: The name of the virtual network.
    :param str resource_group_name: The name of the resource group.
    """
    pulumi.log.warn("""get_virtual_network is deprecated: Version 2016-05-15 will be removed in v2 of the provider.""")
    ...
