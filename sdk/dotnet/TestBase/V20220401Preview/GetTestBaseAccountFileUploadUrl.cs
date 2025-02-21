// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.TestBase.V20220401Preview
{
    public static class GetTestBaseAccountFileUploadUrl
    {
        /// <summary>
        /// The URL response
        /// </summary>
        public static Task<GetTestBaseAccountFileUploadUrlResult> InvokeAsync(GetTestBaseAccountFileUploadUrlArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTestBaseAccountFileUploadUrlResult>("azure-native:testbase/v20220401preview:getTestBaseAccountFileUploadUrl", args ?? new GetTestBaseAccountFileUploadUrlArgs(), options.WithDefaults());

        /// <summary>
        /// The URL response
        /// </summary>
        public static Output<GetTestBaseAccountFileUploadUrlResult> Invoke(GetTestBaseAccountFileUploadUrlInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTestBaseAccountFileUploadUrlResult>("azure-native:testbase/v20220401preview:getTestBaseAccountFileUploadUrl", args ?? new GetTestBaseAccountFileUploadUrlInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTestBaseAccountFileUploadUrlArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The custom file name of the uploaded blob.
        /// </summary>
        [Input("blobName")]
        public string? BlobName { get; set; }

        /// <summary>
        /// The name of the resource group that contains the resource.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource name of the Test Base Account.
        /// </summary>
        [Input("testBaseAccountName", required: true)]
        public string TestBaseAccountName { get; set; } = null!;

        public GetTestBaseAccountFileUploadUrlArgs()
        {
        }
    }

    public sealed class GetTestBaseAccountFileUploadUrlInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The custom file name of the uploaded blob.
        /// </summary>
        [Input("blobName")]
        public Input<string>? BlobName { get; set; }

        /// <summary>
        /// The name of the resource group that contains the resource.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource name of the Test Base Account.
        /// </summary>
        [Input("testBaseAccountName", required: true)]
        public Input<string> TestBaseAccountName { get; set; } = null!;

        public GetTestBaseAccountFileUploadUrlInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTestBaseAccountFileUploadUrlResult
    {
        /// <summary>
        /// The blob path of the uploaded package. It will be used as the 'blobPath' property of PackageResource.
        /// </summary>
        public readonly string BlobPath;
        /// <summary>
        /// The URL used for uploading the package.
        /// </summary>
        public readonly string UploadUrl;

        [OutputConstructor]
        private GetTestBaseAccountFileUploadUrlResult(
            string blobPath,

            string uploadUrl)
        {
            BlobPath = blobPath;
            UploadUrl = uploadUrl;
        }
    }
}
