# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetGroupResult',
    'AwaitableGetGroupResult',
    'get_group',
    'get_group_output',
]

warnings.warn("""Version 2017-11-11-preview will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetGroupResult:
    """
    A group created in a Migration project.
    """
    def __init__(__self__, assessments=None, created_timestamp=None, e_tag=None, id=None, machines=None, name=None, type=None, updated_timestamp=None):
        if assessments and not isinstance(assessments, list):
            raise TypeError("Expected argument 'assessments' to be a list")
        pulumi.set(__self__, "assessments", assessments)
        if created_timestamp and not isinstance(created_timestamp, str):
            raise TypeError("Expected argument 'created_timestamp' to be a str")
        pulumi.set(__self__, "created_timestamp", created_timestamp)
        if e_tag and not isinstance(e_tag, str):
            raise TypeError("Expected argument 'e_tag' to be a str")
        pulumi.set(__self__, "e_tag", e_tag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if machines and not isinstance(machines, list):
            raise TypeError("Expected argument 'machines' to be a list")
        pulumi.set(__self__, "machines", machines)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if updated_timestamp and not isinstance(updated_timestamp, str):
            raise TypeError("Expected argument 'updated_timestamp' to be a str")
        pulumi.set(__self__, "updated_timestamp", updated_timestamp)

    @property
    @pulumi.getter
    def assessments(self) -> Sequence[str]:
        """
        List of References to Assessments created on this group.
        """
        return pulumi.get(self, "assessments")

    @property
    @pulumi.getter(name="createdTimestamp")
    def created_timestamp(self) -> str:
        """
        Time when this project was created. Date-Time represented in ISO-8601 format.
        """
        return pulumi.get(self, "created_timestamp")

    @property
    @pulumi.getter(name="eTag")
    def e_tag(self) -> Optional[str]:
        """
        For optimistic concurrency control.
        """
        return pulumi.get(self, "e_tag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Path reference to this group. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/projects/{projectName}/groups/{groupName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def machines(self) -> Sequence[str]:
        """
        List of machine names that are part of this group.
        """
        return pulumi.get(self, "machines")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the group.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of the object = [Microsoft.Migrate/projects/groups].
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedTimestamp")
    def updated_timestamp(self) -> str:
        """
        Time when this project was last updated. Date-Time represented in ISO-8601 format.
        """
        return pulumi.get(self, "updated_timestamp")


class AwaitableGetGroupResult(GetGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGroupResult(
            assessments=self.assessments,
            created_timestamp=self.created_timestamp,
            e_tag=self.e_tag,
            id=self.id,
            machines=self.machines,
            name=self.name,
            type=self.type,
            updated_timestamp=self.updated_timestamp)


def get_group(group_name: Optional[str] = None,
              project_name: Optional[str] = None,
              resource_group_name: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGroupResult:
    """
    A group created in a Migration project.


    :param str group_name: Unique name of a group within a project.
    :param str project_name: Name of the Azure Migrate project.
    :param str resource_group_name: Name of the Azure Resource Group that project is part of.
    """
    pulumi.log.warn("""get_group is deprecated: Version 2017-11-11-preview will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['groupName'] = group_name
    __args__['projectName'] = project_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:migrate/v20171111preview:getGroup', __args__, opts=opts, typ=GetGroupResult).value

    return AwaitableGetGroupResult(
        assessments=__ret__.assessments,
        created_timestamp=__ret__.created_timestamp,
        e_tag=__ret__.e_tag,
        id=__ret__.id,
        machines=__ret__.machines,
        name=__ret__.name,
        type=__ret__.type,
        updated_timestamp=__ret__.updated_timestamp)


@_utilities.lift_output_func(get_group)
def get_group_output(group_name: Optional[pulumi.Input[str]] = None,
                     project_name: Optional[pulumi.Input[str]] = None,
                     resource_group_name: Optional[pulumi.Input[str]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetGroupResult]:
    """
    A group created in a Migration project.


    :param str group_name: Unique name of a group within a project.
    :param str project_name: Name of the Azure Migrate project.
    :param str resource_group_name: Name of the Azure Resource Group that project is part of.
    """
    pulumi.log.warn("""get_group is deprecated: Version 2017-11-11-preview will be removed in v2 of the provider.""")
    ...
