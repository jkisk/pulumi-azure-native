# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from .. import _utilities
import typing
# Export this package's modules as members:
from ._enums import *
from .blob import *
from .blob_container import *
from .blob_container_immutability_policy import *
from .blob_inventory_policy import *
from .blob_service_properties import *
from .encryption_scope import *
from .file_service_properties import *
from .file_share import *
from .get_blob_container import *
from .get_blob_container_immutability_policy import *
from .get_blob_inventory_policy import *
from .get_blob_service_properties import *
from .get_encryption_scope import *
from .get_file_service_properties import *
from .get_file_share import *
from .get_local_user import *
from .get_management_policy import *
from .get_object_replication_policy import *
from .get_private_endpoint_connection import *
from .get_queue import *
from .get_queue_service_properties import *
from .get_storage_account import *
from .get_table import *
from .get_table_service_properties import *
from .list_local_user_keys import *
from .list_storage_account_keys import *
from .list_storage_account_sas import *
from .list_storage_account_service_sas import *
from .local_user import *
from .management_policy import *
from .object_replication_policy import *
from .private_endpoint_connection import *
from .queue import *
from .queue_service_properties import *
from .storage_account import *
from .storage_account_static_website import *
from .table import *
from .table_service_properties import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_azure_native.storage.v20150501preview as __v20150501preview
    v20150501preview = __v20150501preview
    import pulumi_azure_native.storage.v20150615 as __v20150615
    v20150615 = __v20150615
    import pulumi_azure_native.storage.v20160101 as __v20160101
    v20160101 = __v20160101
    import pulumi_azure_native.storage.v20160501 as __v20160501
    v20160501 = __v20160501
    import pulumi_azure_native.storage.v20161201 as __v20161201
    v20161201 = __v20161201
    import pulumi_azure_native.storage.v20170601 as __v20170601
    v20170601 = __v20170601
    import pulumi_azure_native.storage.v20171001 as __v20171001
    v20171001 = __v20171001
    import pulumi_azure_native.storage.v20180201 as __v20180201
    v20180201 = __v20180201
    import pulumi_azure_native.storage.v20180301preview as __v20180301preview
    v20180301preview = __v20180301preview
    import pulumi_azure_native.storage.v20180701 as __v20180701
    v20180701 = __v20180701
    import pulumi_azure_native.storage.v20181101 as __v20181101
    v20181101 = __v20181101
    import pulumi_azure_native.storage.v20190401 as __v20190401
    v20190401 = __v20190401
    import pulumi_azure_native.storage.v20190601 as __v20190601
    v20190601 = __v20190601
    import pulumi_azure_native.storage.v20200801preview as __v20200801preview
    v20200801preview = __v20200801preview
    import pulumi_azure_native.storage.v20210101 as __v20210101
    v20210101 = __v20210101
    import pulumi_azure_native.storage.v20210201 as __v20210201
    v20210201 = __v20210201
    import pulumi_azure_native.storage.v20210401 as __v20210401
    v20210401 = __v20210401
    import pulumi_azure_native.storage.v20210601 as __v20210601
    v20210601 = __v20210601
    import pulumi_azure_native.storage.v20210801 as __v20210801
    v20210801 = __v20210801
    import pulumi_azure_native.storage.v20210901 as __v20210901
    v20210901 = __v20210901
else:
    v20150501preview = _utilities.lazy_import('pulumi_azure_native.storage.v20150501preview')
    v20150615 = _utilities.lazy_import('pulumi_azure_native.storage.v20150615')
    v20160101 = _utilities.lazy_import('pulumi_azure_native.storage.v20160101')
    v20160501 = _utilities.lazy_import('pulumi_azure_native.storage.v20160501')
    v20161201 = _utilities.lazy_import('pulumi_azure_native.storage.v20161201')
    v20170601 = _utilities.lazy_import('pulumi_azure_native.storage.v20170601')
    v20171001 = _utilities.lazy_import('pulumi_azure_native.storage.v20171001')
    v20180201 = _utilities.lazy_import('pulumi_azure_native.storage.v20180201')
    v20180301preview = _utilities.lazy_import('pulumi_azure_native.storage.v20180301preview')
    v20180701 = _utilities.lazy_import('pulumi_azure_native.storage.v20180701')
    v20181101 = _utilities.lazy_import('pulumi_azure_native.storage.v20181101')
    v20190401 = _utilities.lazy_import('pulumi_azure_native.storage.v20190401')
    v20190601 = _utilities.lazy_import('pulumi_azure_native.storage.v20190601')
    v20200801preview = _utilities.lazy_import('pulumi_azure_native.storage.v20200801preview')
    v20210101 = _utilities.lazy_import('pulumi_azure_native.storage.v20210101')
    v20210201 = _utilities.lazy_import('pulumi_azure_native.storage.v20210201')
    v20210401 = _utilities.lazy_import('pulumi_azure_native.storage.v20210401')
    v20210601 = _utilities.lazy_import('pulumi_azure_native.storage.v20210601')
    v20210801 = _utilities.lazy_import('pulumi_azure_native.storage.v20210801')
    v20210901 = _utilities.lazy_import('pulumi_azure_native.storage.v20210901')

