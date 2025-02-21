# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetDiskResult',
    'AwaitableGetDiskResult',
    'get_disk',
    'get_disk_output',
]

warnings.warn("""Version 2016-05-15 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetDiskResult:
    """
    A Disk.
    """
    def __init__(__self__, created_date=None, disk_blob_name=None, disk_size_gi_b=None, disk_type=None, disk_uri=None, host_caching=None, id=None, leased_by_lab_vm_id=None, location=None, managed_disk_id=None, name=None, provisioning_state=None, tags=None, type=None, unique_identifier=None):
        if created_date and not isinstance(created_date, str):
            raise TypeError("Expected argument 'created_date' to be a str")
        pulumi.set(__self__, "created_date", created_date)
        if disk_blob_name and not isinstance(disk_blob_name, str):
            raise TypeError("Expected argument 'disk_blob_name' to be a str")
        pulumi.set(__self__, "disk_blob_name", disk_blob_name)
        if disk_size_gi_b and not isinstance(disk_size_gi_b, int):
            raise TypeError("Expected argument 'disk_size_gi_b' to be a int")
        pulumi.set(__self__, "disk_size_gi_b", disk_size_gi_b)
        if disk_type and not isinstance(disk_type, str):
            raise TypeError("Expected argument 'disk_type' to be a str")
        pulumi.set(__self__, "disk_type", disk_type)
        if disk_uri and not isinstance(disk_uri, str):
            raise TypeError("Expected argument 'disk_uri' to be a str")
        pulumi.set(__self__, "disk_uri", disk_uri)
        if host_caching and not isinstance(host_caching, str):
            raise TypeError("Expected argument 'host_caching' to be a str")
        pulumi.set(__self__, "host_caching", host_caching)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if leased_by_lab_vm_id and not isinstance(leased_by_lab_vm_id, str):
            raise TypeError("Expected argument 'leased_by_lab_vm_id' to be a str")
        pulumi.set(__self__, "leased_by_lab_vm_id", leased_by_lab_vm_id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if managed_disk_id and not isinstance(managed_disk_id, str):
            raise TypeError("Expected argument 'managed_disk_id' to be a str")
        pulumi.set(__self__, "managed_disk_id", managed_disk_id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
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
    @pulumi.getter(name="createdDate")
    def created_date(self) -> str:
        """
        The creation date of the disk.
        """
        return pulumi.get(self, "created_date")

    @property
    @pulumi.getter(name="diskBlobName")
    def disk_blob_name(self) -> Optional[str]:
        """
        When backed by a blob, the name of the VHD blob without extension.
        """
        return pulumi.get(self, "disk_blob_name")

    @property
    @pulumi.getter(name="diskSizeGiB")
    def disk_size_gi_b(self) -> Optional[int]:
        """
        The size of the disk in Gibibytes.
        """
        return pulumi.get(self, "disk_size_gi_b")

    @property
    @pulumi.getter(name="diskType")
    def disk_type(self) -> Optional[str]:
        """
        The storage type for the disk (i.e. Standard, Premium).
        """
        return pulumi.get(self, "disk_type")

    @property
    @pulumi.getter(name="diskUri")
    def disk_uri(self) -> Optional[str]:
        """
        When backed by a blob, the URI of underlying blob.
        """
        return pulumi.get(self, "disk_uri")

    @property
    @pulumi.getter(name="hostCaching")
    def host_caching(self) -> Optional[str]:
        """
        The host caching policy of the disk (i.e. None, ReadOnly, ReadWrite).
        """
        return pulumi.get(self, "host_caching")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The identifier of the resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="leasedByLabVmId")
    def leased_by_lab_vm_id(self) -> Optional[str]:
        """
        The resource ID of the VM to which this disk is leased.
        """
        return pulumi.get(self, "leased_by_lab_vm_id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The location of the resource.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedDiskId")
    def managed_disk_id(self) -> Optional[str]:
        """
        When backed by managed disk, this is the ID of the compute disk resource.
        """
        return pulumi.get(self, "managed_disk_id")

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


class AwaitableGetDiskResult(GetDiskResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDiskResult(
            created_date=self.created_date,
            disk_blob_name=self.disk_blob_name,
            disk_size_gi_b=self.disk_size_gi_b,
            disk_type=self.disk_type,
            disk_uri=self.disk_uri,
            host_caching=self.host_caching,
            id=self.id,
            leased_by_lab_vm_id=self.leased_by_lab_vm_id,
            location=self.location,
            managed_disk_id=self.managed_disk_id,
            name=self.name,
            provisioning_state=self.provisioning_state,
            tags=self.tags,
            type=self.type,
            unique_identifier=self.unique_identifier)


def get_disk(expand: Optional[str] = None,
             lab_name: Optional[str] = None,
             name: Optional[str] = None,
             resource_group_name: Optional[str] = None,
             user_name: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDiskResult:
    """
    A Disk.


    :param str expand: Specify the $expand query. Example: 'properties($select=diskType)'
    :param str lab_name: The name of the lab.
    :param str name: The name of the disk.
    :param str resource_group_name: The name of the resource group.
    :param str user_name: The name of the user profile.
    """
    pulumi.log.warn("""get_disk is deprecated: Version 2016-05-15 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['expand'] = expand
    __args__['labName'] = lab_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['userName'] = user_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:devtestlab/v20160515:getDisk', __args__, opts=opts, typ=GetDiskResult).value

    return AwaitableGetDiskResult(
        created_date=__ret__.created_date,
        disk_blob_name=__ret__.disk_blob_name,
        disk_size_gi_b=__ret__.disk_size_gi_b,
        disk_type=__ret__.disk_type,
        disk_uri=__ret__.disk_uri,
        host_caching=__ret__.host_caching,
        id=__ret__.id,
        leased_by_lab_vm_id=__ret__.leased_by_lab_vm_id,
        location=__ret__.location,
        managed_disk_id=__ret__.managed_disk_id,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        tags=__ret__.tags,
        type=__ret__.type,
        unique_identifier=__ret__.unique_identifier)


@_utilities.lift_output_func(get_disk)
def get_disk_output(expand: Optional[pulumi.Input[Optional[str]]] = None,
                    lab_name: Optional[pulumi.Input[str]] = None,
                    name: Optional[pulumi.Input[str]] = None,
                    resource_group_name: Optional[pulumi.Input[str]] = None,
                    user_name: Optional[pulumi.Input[str]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDiskResult]:
    """
    A Disk.


    :param str expand: Specify the $expand query. Example: 'properties($select=diskType)'
    :param str lab_name: The name of the lab.
    :param str name: The name of the disk.
    :param str resource_group_name: The name of the resource group.
    :param str user_name: The name of the user profile.
    """
    pulumi.log.warn("""get_disk is deprecated: Version 2016-05-15 will be removed in v2 of the provider.""")
    ...
