// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20191201.Outputs
{

    /// <summary>
    /// Http message diagnostic settings.
    /// </summary>
    [OutputType]
    public sealed class HttpMessageDiagnosticResponse
    {
        /// <summary>
        /// Body logging settings.
        /// </summary>
        public readonly Outputs.BodyDiagnosticSettingsResponse? Body;
        /// <summary>
        /// Array of HTTP Headers to log.
        /// </summary>
        public readonly ImmutableArray<string> Headers;

        [OutputConstructor]
        private HttpMessageDiagnosticResponse(
            Outputs.BodyDiagnosticSettingsResponse? body,

            ImmutableArray<string> headers)
        {
            Body = body;
            Headers = headers;
        }
    }
}
