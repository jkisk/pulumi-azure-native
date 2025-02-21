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
    'GetSmartDetectorAlertRuleResult',
    'AwaitableGetSmartDetectorAlertRuleResult',
    'get_smart_detector_alert_rule',
    'get_smart_detector_alert_rule_output',
]

warnings.warn("""Version 2019-03-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetSmartDetectorAlertRuleResult:
    """
    The alert rule information
    """
    def __init__(__self__, action_groups=None, description=None, detector=None, frequency=None, id=None, name=None, scope=None, severity=None, state=None, throttling=None, type=None):
        if action_groups and not isinstance(action_groups, dict):
            raise TypeError("Expected argument 'action_groups' to be a dict")
        pulumi.set(__self__, "action_groups", action_groups)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if detector and not isinstance(detector, dict):
            raise TypeError("Expected argument 'detector' to be a dict")
        pulumi.set(__self__, "detector", detector)
        if frequency and not isinstance(frequency, str):
            raise TypeError("Expected argument 'frequency' to be a str")
        pulumi.set(__self__, "frequency", frequency)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if scope and not isinstance(scope, list):
            raise TypeError("Expected argument 'scope' to be a list")
        pulumi.set(__self__, "scope", scope)
        if severity and not isinstance(severity, str):
            raise TypeError("Expected argument 'severity' to be a str")
        pulumi.set(__self__, "severity", severity)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if throttling and not isinstance(throttling, dict):
            raise TypeError("Expected argument 'throttling' to be a dict")
        pulumi.set(__self__, "throttling", throttling)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="actionGroups")
    def action_groups(self) -> 'outputs.ActionGroupsInformationResponse':
        """
        The alert rule actions.
        """
        return pulumi.get(self, "action_groups")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The alert rule description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def detector(self) -> 'outputs.DetectorResponse':
        """
        The alert rule's detector.
        """
        return pulumi.get(self, "detector")

    @property
    @pulumi.getter
    def frequency(self) -> str:
        """
        The alert rule frequency in ISO8601 format. The time granularity must be in minutes and minimum value is 5 minutes.
        """
        return pulumi.get(self, "frequency")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The resource ID.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def scope(self) -> Sequence[str]:
        """
        The alert rule resources scope.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter
    def severity(self) -> str:
        """
        The alert rule severity.
        """
        return pulumi.get(self, "severity")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        The alert rule state.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def throttling(self) -> Optional['outputs.ThrottlingInformationResponse']:
        """
        The alert rule throttling information.
        """
        return pulumi.get(self, "throttling")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetSmartDetectorAlertRuleResult(GetSmartDetectorAlertRuleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSmartDetectorAlertRuleResult(
            action_groups=self.action_groups,
            description=self.description,
            detector=self.detector,
            frequency=self.frequency,
            id=self.id,
            name=self.name,
            scope=self.scope,
            severity=self.severity,
            state=self.state,
            throttling=self.throttling,
            type=self.type)


def get_smart_detector_alert_rule(alert_rule_name: Optional[str] = None,
                                  expand_detector: Optional[bool] = None,
                                  resource_group_name: Optional[str] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSmartDetectorAlertRuleResult:
    """
    The alert rule information


    :param str alert_rule_name: The name of the alert rule.
    :param bool expand_detector: Indicates if Smart Detector should be expanded.
    :param str resource_group_name: The name of the resource group.
    """
    pulumi.log.warn("""get_smart_detector_alert_rule is deprecated: Version 2019-03-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['alertRuleName'] = alert_rule_name
    __args__['expandDetector'] = expand_detector
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:alertsmanagement/v20190301:getSmartDetectorAlertRule', __args__, opts=opts, typ=GetSmartDetectorAlertRuleResult).value

    return AwaitableGetSmartDetectorAlertRuleResult(
        action_groups=__ret__.action_groups,
        description=__ret__.description,
        detector=__ret__.detector,
        frequency=__ret__.frequency,
        id=__ret__.id,
        name=__ret__.name,
        scope=__ret__.scope,
        severity=__ret__.severity,
        state=__ret__.state,
        throttling=__ret__.throttling,
        type=__ret__.type)


@_utilities.lift_output_func(get_smart_detector_alert_rule)
def get_smart_detector_alert_rule_output(alert_rule_name: Optional[pulumi.Input[str]] = None,
                                         expand_detector: Optional[pulumi.Input[Optional[bool]]] = None,
                                         resource_group_name: Optional[pulumi.Input[str]] = None,
                                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSmartDetectorAlertRuleResult]:
    """
    The alert rule information


    :param str alert_rule_name: The name of the alert rule.
    :param bool expand_detector: Indicates if Smart Detector should be expanded.
    :param str resource_group_name: The name of the resource group.
    """
    pulumi.log.warn("""get_smart_detector_alert_rule is deprecated: Version 2019-03-01 will be removed in v2 of the provider.""")
    ...
