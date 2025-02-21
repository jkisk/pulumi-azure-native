# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._inputs import *

__all__ = ['RecordSetArgs', 'RecordSet']

@pulumi.input_type
class RecordSetArgs:
    def __init__(__self__, *,
                 record_type: pulumi.Input[str],
                 resource_group_name: pulumi.Input[str],
                 zone_name: pulumi.Input[str],
                 a_aaa_records: Optional[pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]]] = None,
                 a_records: Optional[pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]]] = None,
                 c_name_record: Optional[pulumi.Input['CnameRecordArgs']] = None,
                 m_x_records: Optional[pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]]] = None,
                 n_s_records: Optional[pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]]] = None,
                 p_tr_records: Optional[pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]]] = None,
                 relative_record_set_name: Optional[pulumi.Input[str]] = None,
                 s_oa_record: Optional[pulumi.Input['SoaRecordArgs']] = None,
                 s_rv_records: Optional[pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]]] = None,
                 t_xt_records: Optional[pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]]] = None,
                 ttl: Optional[pulumi.Input[float]] = None):
        """
        The set of arguments for constructing a RecordSet resource.
        :param pulumi.Input[str] record_type: The type of DNS record.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] zone_name: The name of the zone without a terminating dot.
        :param pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]] a_aaa_records: Gets or sets the list of AAAA records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]] a_records: Gets or sets the list of A records in the RecordSet.
        :param pulumi.Input['CnameRecordArgs'] c_name_record: Gets or sets the CNAME record in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]] m_x_records: Gets or sets the list of MX records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]] n_s_records: Gets or sets the list of NS records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]] p_tr_records: Gets or sets the list of PTR records in the RecordSet.
        :param pulumi.Input[str] relative_record_set_name: The name of the RecordSet, relative to the name of the zone.
        :param pulumi.Input['SoaRecordArgs'] s_oa_record: Gets or sets the SOA record in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]] s_rv_records: Gets or sets the list of SRV records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]] t_xt_records: Gets or sets the list of TXT records in the RecordSet.
        :param pulumi.Input[float] ttl: Gets or sets the TTL of the records in the RecordSet.
        """
        pulumi.set(__self__, "record_type", record_type)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        pulumi.set(__self__, "zone_name", zone_name)
        if a_aaa_records is not None:
            pulumi.set(__self__, "a_aaa_records", a_aaa_records)
        if a_records is not None:
            pulumi.set(__self__, "a_records", a_records)
        if c_name_record is not None:
            pulumi.set(__self__, "c_name_record", c_name_record)
        if m_x_records is not None:
            pulumi.set(__self__, "m_x_records", m_x_records)
        if n_s_records is not None:
            pulumi.set(__self__, "n_s_records", n_s_records)
        if p_tr_records is not None:
            pulumi.set(__self__, "p_tr_records", p_tr_records)
        if relative_record_set_name is not None:
            pulumi.set(__self__, "relative_record_set_name", relative_record_set_name)
        if s_oa_record is not None:
            pulumi.set(__self__, "s_oa_record", s_oa_record)
        if s_rv_records is not None:
            pulumi.set(__self__, "s_rv_records", s_rv_records)
        if t_xt_records is not None:
            pulumi.set(__self__, "t_xt_records", t_xt_records)
        if ttl is not None:
            pulumi.set(__self__, "ttl", ttl)

    @property
    @pulumi.getter(name="recordType")
    def record_type(self) -> pulumi.Input[str]:
        """
        The type of DNS record.
        """
        return pulumi.get(self, "record_type")

    @record_type.setter
    def record_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "record_type", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The name of the resource group. The name is case insensitive.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="zoneName")
    def zone_name(self) -> pulumi.Input[str]:
        """
        The name of the zone without a terminating dot.
        """
        return pulumi.get(self, "zone_name")

    @zone_name.setter
    def zone_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "zone_name", value)

    @property
    @pulumi.getter(name="aAAARecords")
    def a_aaa_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]]]:
        """
        Gets or sets the list of AAAA records in the RecordSet.
        """
        return pulumi.get(self, "a_aaa_records")

    @a_aaa_records.setter
    def a_aaa_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]]]):
        pulumi.set(self, "a_aaa_records", value)

    @property
    @pulumi.getter(name="aRecords")
    def a_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]]]:
        """
        Gets or sets the list of A records in the RecordSet.
        """
        return pulumi.get(self, "a_records")

    @a_records.setter
    def a_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]]]):
        pulumi.set(self, "a_records", value)

    @property
    @pulumi.getter(name="cNAMERecord")
    def c_name_record(self) -> Optional[pulumi.Input['CnameRecordArgs']]:
        """
        Gets or sets the CNAME record in the RecordSet.
        """
        return pulumi.get(self, "c_name_record")

    @c_name_record.setter
    def c_name_record(self, value: Optional[pulumi.Input['CnameRecordArgs']]):
        pulumi.set(self, "c_name_record", value)

    @property
    @pulumi.getter(name="mXRecords")
    def m_x_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]]]:
        """
        Gets or sets the list of MX records in the RecordSet.
        """
        return pulumi.get(self, "m_x_records")

    @m_x_records.setter
    def m_x_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]]]):
        pulumi.set(self, "m_x_records", value)

    @property
    @pulumi.getter(name="nSRecords")
    def n_s_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]]]:
        """
        Gets or sets the list of NS records in the RecordSet.
        """
        return pulumi.get(self, "n_s_records")

    @n_s_records.setter
    def n_s_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]]]):
        pulumi.set(self, "n_s_records", value)

    @property
    @pulumi.getter(name="pTRRecords")
    def p_tr_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]]]:
        """
        Gets or sets the list of PTR records in the RecordSet.
        """
        return pulumi.get(self, "p_tr_records")

    @p_tr_records.setter
    def p_tr_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]]]):
        pulumi.set(self, "p_tr_records", value)

    @property
    @pulumi.getter(name="relativeRecordSetName")
    def relative_record_set_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the RecordSet, relative to the name of the zone.
        """
        return pulumi.get(self, "relative_record_set_name")

    @relative_record_set_name.setter
    def relative_record_set_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "relative_record_set_name", value)

    @property
    @pulumi.getter(name="sOARecord")
    def s_oa_record(self) -> Optional[pulumi.Input['SoaRecordArgs']]:
        """
        Gets or sets the SOA record in the RecordSet.
        """
        return pulumi.get(self, "s_oa_record")

    @s_oa_record.setter
    def s_oa_record(self, value: Optional[pulumi.Input['SoaRecordArgs']]):
        pulumi.set(self, "s_oa_record", value)

    @property
    @pulumi.getter(name="sRVRecords")
    def s_rv_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]]]:
        """
        Gets or sets the list of SRV records in the RecordSet.
        """
        return pulumi.get(self, "s_rv_records")

    @s_rv_records.setter
    def s_rv_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]]]):
        pulumi.set(self, "s_rv_records", value)

    @property
    @pulumi.getter(name="tXTRecords")
    def t_xt_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]]]:
        """
        Gets or sets the list of TXT records in the RecordSet.
        """
        return pulumi.get(self, "t_xt_records")

    @t_xt_records.setter
    def t_xt_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]]]):
        pulumi.set(self, "t_xt_records", value)

    @property
    @pulumi.getter
    def ttl(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the TTL of the records in the RecordSet.
        """
        return pulumi.get(self, "ttl")

    @ttl.setter
    def ttl(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "ttl", value)


warnings.warn("""Version 2015-05-04-preview will be removed in v2 of the provider.""", DeprecationWarning)


class RecordSet(pulumi.CustomResource):
    warnings.warn("""Version 2015-05-04-preview will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 a_aaa_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AaaaRecordArgs']]]]] = None,
                 a_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ARecordArgs']]]]] = None,
                 c_name_record: Optional[pulumi.Input[pulumi.InputType['CnameRecordArgs']]] = None,
                 m_x_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MxRecordArgs']]]]] = None,
                 n_s_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NsRecordArgs']]]]] = None,
                 p_tr_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PtrRecordArgs']]]]] = None,
                 record_type: Optional[pulumi.Input[str]] = None,
                 relative_record_set_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 s_oa_record: Optional[pulumi.Input[pulumi.InputType['SoaRecordArgs']]] = None,
                 s_rv_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SrvRecordArgs']]]]] = None,
                 t_xt_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TxtRecordArgs']]]]] = None,
                 ttl: Optional[pulumi.Input[float]] = None,
                 zone_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Describes a DNS record set (a collection of DNS records with the same name and type).

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AaaaRecordArgs']]]] a_aaa_records: Gets or sets the list of AAAA records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ARecordArgs']]]] a_records: Gets or sets the list of A records in the RecordSet.
        :param pulumi.Input[pulumi.InputType['CnameRecordArgs']] c_name_record: Gets or sets the CNAME record in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MxRecordArgs']]]] m_x_records: Gets or sets the list of MX records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NsRecordArgs']]]] n_s_records: Gets or sets the list of NS records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PtrRecordArgs']]]] p_tr_records: Gets or sets the list of PTR records in the RecordSet.
        :param pulumi.Input[str] record_type: The type of DNS record.
        :param pulumi.Input[str] relative_record_set_name: The name of the RecordSet, relative to the name of the zone.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[pulumi.InputType['SoaRecordArgs']] s_oa_record: Gets or sets the SOA record in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SrvRecordArgs']]]] s_rv_records: Gets or sets the list of SRV records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TxtRecordArgs']]]] t_xt_records: Gets or sets the list of TXT records in the RecordSet.
        :param pulumi.Input[float] ttl: Gets or sets the TTL of the records in the RecordSet.
        :param pulumi.Input[str] zone_name: The name of the zone without a terminating dot.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RecordSetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Describes a DNS record set (a collection of DNS records with the same name and type).

        :param str resource_name: The name of the resource.
        :param RecordSetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RecordSetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 a_aaa_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AaaaRecordArgs']]]]] = None,
                 a_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ARecordArgs']]]]] = None,
                 c_name_record: Optional[pulumi.Input[pulumi.InputType['CnameRecordArgs']]] = None,
                 m_x_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MxRecordArgs']]]]] = None,
                 n_s_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NsRecordArgs']]]]] = None,
                 p_tr_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PtrRecordArgs']]]]] = None,
                 record_type: Optional[pulumi.Input[str]] = None,
                 relative_record_set_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 s_oa_record: Optional[pulumi.Input[pulumi.InputType['SoaRecordArgs']]] = None,
                 s_rv_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SrvRecordArgs']]]]] = None,
                 t_xt_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TxtRecordArgs']]]]] = None,
                 ttl: Optional[pulumi.Input[float]] = None,
                 zone_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""RecordSet is deprecated: Version 2015-05-04-preview will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RecordSetArgs.__new__(RecordSetArgs)

            __props__.__dict__["a_aaa_records"] = a_aaa_records
            __props__.__dict__["a_records"] = a_records
            __props__.__dict__["c_name_record"] = c_name_record
            __props__.__dict__["m_x_records"] = m_x_records
            __props__.__dict__["n_s_records"] = n_s_records
            __props__.__dict__["p_tr_records"] = p_tr_records
            if record_type is None and not opts.urn:
                raise TypeError("Missing required property 'record_type'")
            __props__.__dict__["record_type"] = record_type
            __props__.__dict__["relative_record_set_name"] = relative_record_set_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["s_oa_record"] = s_oa_record
            __props__.__dict__["s_rv_records"] = s_rv_records
            __props__.__dict__["t_xt_records"] = t_xt_records
            __props__.__dict__["ttl"] = ttl
            if zone_name is None and not opts.urn:
                raise TypeError("Missing required property 'zone_name'")
            __props__.__dict__["zone_name"] = zone_name
            __props__.__dict__["etag"] = None
            __props__.__dict__["fqdn"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:network:RecordSet"), pulumi.Alias(type_="azure-native:network/v20160401:RecordSet"), pulumi.Alias(type_="azure-native:network/v20170901:RecordSet"), pulumi.Alias(type_="azure-native:network/v20171001:RecordSet"), pulumi.Alias(type_="azure-native:network/v20180301preview:RecordSet"), pulumi.Alias(type_="azure-native:network/v20180501:RecordSet")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(RecordSet, __self__).__init__(
            'azure-native:network/v20150504preview:RecordSet',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'RecordSet':
        """
        Get an existing RecordSet resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = RecordSetArgs.__new__(RecordSetArgs)

        __props__.__dict__["a_aaa_records"] = None
        __props__.__dict__["a_records"] = None
        __props__.__dict__["c_name_record"] = None
        __props__.__dict__["etag"] = None
        __props__.__dict__["fqdn"] = None
        __props__.__dict__["m_x_records"] = None
        __props__.__dict__["n_s_records"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["p_tr_records"] = None
        __props__.__dict__["s_oa_record"] = None
        __props__.__dict__["s_rv_records"] = None
        __props__.__dict__["t_xt_records"] = None
        __props__.__dict__["ttl"] = None
        __props__.__dict__["type"] = None
        return RecordSet(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aAAARecords")
    def a_aaa_records(self) -> pulumi.Output[Optional[Sequence['outputs.AaaaRecordResponse']]]:
        """
        Gets or sets the list of AAAA records in the RecordSet.
        """
        return pulumi.get(self, "a_aaa_records")

    @property
    @pulumi.getter(name="aRecords")
    def a_records(self) -> pulumi.Output[Optional[Sequence['outputs.ARecordResponse']]]:
        """
        Gets or sets the list of A records in the RecordSet.
        """
        return pulumi.get(self, "a_records")

    @property
    @pulumi.getter(name="cNAMERecord")
    def c_name_record(self) -> pulumi.Output[Optional['outputs.CnameRecordResponse']]:
        """
        Gets or sets the CNAME record in the RecordSet.
        """
        return pulumi.get(self, "c_name_record")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        The etag of the record set.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def fqdn(self) -> pulumi.Output[str]:
        """
        Fully qualified domain name of the record set.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter(name="mXRecords")
    def m_x_records(self) -> pulumi.Output[Optional[Sequence['outputs.MxRecordResponse']]]:
        """
        Gets or sets the list of MX records in the RecordSet.
        """
        return pulumi.get(self, "m_x_records")

    @property
    @pulumi.getter(name="nSRecords")
    def n_s_records(self) -> pulumi.Output[Optional[Sequence['outputs.NsRecordResponse']]]:
        """
        Gets or sets the list of NS records in the RecordSet.
        """
        return pulumi.get(self, "n_s_records")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the record set.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="pTRRecords")
    def p_tr_records(self) -> pulumi.Output[Optional[Sequence['outputs.PtrRecordResponse']]]:
        """
        Gets or sets the list of PTR records in the RecordSet.
        """
        return pulumi.get(self, "p_tr_records")

    @property
    @pulumi.getter(name="sOARecord")
    def s_oa_record(self) -> pulumi.Output[Optional['outputs.SoaRecordResponse']]:
        """
        Gets or sets the SOA record in the RecordSet.
        """
        return pulumi.get(self, "s_oa_record")

    @property
    @pulumi.getter(name="sRVRecords")
    def s_rv_records(self) -> pulumi.Output[Optional[Sequence['outputs.SrvRecordResponse']]]:
        """
        Gets or sets the list of SRV records in the RecordSet.
        """
        return pulumi.get(self, "s_rv_records")

    @property
    @pulumi.getter(name="tXTRecords")
    def t_xt_records(self) -> pulumi.Output[Optional[Sequence['outputs.TxtRecordResponse']]]:
        """
        Gets or sets the list of TXT records in the RecordSet.
        """
        return pulumi.get(self, "t_xt_records")

    @property
    @pulumi.getter
    def ttl(self) -> pulumi.Output[Optional[float]]:
        """
        Gets or sets the TTL of the records in the RecordSet.
        """
        return pulumi.get(self, "ttl")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the record set.
        """
        return pulumi.get(self, "type")

