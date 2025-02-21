// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class CustomOpenIdConnectProviderResponse
    {
        public readonly bool? Enabled;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        public readonly Outputs.OpenIdConnectLoginResponse? Login;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        public readonly Outputs.OpenIdConnectRegistrationResponse? Registration;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private CustomOpenIdConnectProviderResponse(
            bool? enabled,

            string id,

            string? kind,

            Outputs.OpenIdConnectLoginResponse? login,

            string name,

            Outputs.OpenIdConnectRegistrationResponse? registration,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Enabled = enabled;
            Id = id;
            Kind = kind;
            Login = login;
            Name = name;
            Registration = registration;
            SystemData = systemData;
            Type = type;
        }
    }
}
