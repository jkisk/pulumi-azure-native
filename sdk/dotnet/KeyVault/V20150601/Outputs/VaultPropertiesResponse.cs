// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KeyVault.V20150601.Outputs
{

    /// <summary>
    /// Properties of the vault
    /// </summary>
    [OutputType]
    public sealed class VaultPropertiesResponse
    {
        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID.
        /// </summary>
        public readonly ImmutableArray<Outputs.AccessPolicyEntryResponse> AccessPolicies;
        /// <summary>
        /// Property to specify whether the 'soft delete' functionality is enabled for this key vault.
        /// </summary>
        public readonly bool? EnableSoftDelete;
        /// <summary>
        /// Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault.
        /// </summary>
        public readonly bool? EnabledForDeployment;
        /// <summary>
        /// Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        public readonly bool? EnabledForDiskEncryption;
        /// <summary>
        /// Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        /// </summary>
        public readonly bool? EnabledForTemplateDeployment;
        /// <summary>
        /// SKU details
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The URI of the vault for performing operations on keys and secrets.
        /// </summary>
        public readonly string? VaultUri;

        [OutputConstructor]
        private VaultPropertiesResponse(
            ImmutableArray<Outputs.AccessPolicyEntryResponse> accessPolicies,

            bool? enableSoftDelete,

            bool? enabledForDeployment,

            bool? enabledForDiskEncryption,

            bool? enabledForTemplateDeployment,

            Outputs.SkuResponse sku,

            string tenantId,

            string? vaultUri)
        {
            AccessPolicies = accessPolicies;
            EnableSoftDelete = enableSoftDelete;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            Sku = sku;
            TenantId = tenantId;
            VaultUri = vaultUri;
        }
    }
}
