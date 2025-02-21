# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from .. import _utilities
import typing
# Export this package's modules as members:
from ._enums import *
from .account import *
from .commitment_plan import *
from .deployment import *
from .get_account import *
from .get_commitment_plan import *
from .get_deployment import *
from .get_private_endpoint_connection import *
from .list_account_keys import *
from .private_endpoint_connection import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_azure_native.cognitiveservices.v20160201preview as __v20160201preview
    v20160201preview = __v20160201preview
    import pulumi_azure_native.cognitiveservices.v20170418 as __v20170418
    v20170418 = __v20170418
    import pulumi_azure_native.cognitiveservices.v20210430 as __v20210430
    v20210430 = __v20210430
    import pulumi_azure_native.cognitiveservices.v20211001 as __v20211001
    v20211001 = __v20211001
    import pulumi_azure_native.cognitiveservices.v20220301 as __v20220301
    v20220301 = __v20220301
else:
    v20160201preview = _utilities.lazy_import('pulumi_azure_native.cognitiveservices.v20160201preview')
    v20170418 = _utilities.lazy_import('pulumi_azure_native.cognitiveservices.v20170418')
    v20210430 = _utilities.lazy_import('pulumi_azure_native.cognitiveservices.v20210430')
    v20211001 = _utilities.lazy_import('pulumi_azure_native.cognitiveservices.v20211001')
    v20220301 = _utilities.lazy_import('pulumi_azure_native.cognitiveservices.v20220301')

