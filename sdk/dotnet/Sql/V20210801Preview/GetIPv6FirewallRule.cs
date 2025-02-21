// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Sql.V20210801Preview
{
    public static class GetIPv6FirewallRule
    {
        /// <summary>
        /// An IPv6 server firewall rule.
        /// </summary>
        public static Task<GetIPv6FirewallRuleResult> InvokeAsync(GetIPv6FirewallRuleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIPv6FirewallRuleResult>("azure-native:sql/v20210801preview:getIPv6FirewallRule", args ?? new GetIPv6FirewallRuleArgs(), options.WithDefaults());

        /// <summary>
        /// An IPv6 server firewall rule.
        /// </summary>
        public static Output<GetIPv6FirewallRuleResult> Invoke(GetIPv6FirewallRuleInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetIPv6FirewallRuleResult>("azure-native:sql/v20210801preview:getIPv6FirewallRule", args ?? new GetIPv6FirewallRuleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetIPv6FirewallRuleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the firewall rule.
        /// </summary>
        [Input("firewallRuleName", required: true)]
        public string FirewallRuleName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public string ServerName { get; set; } = null!;

        public GetIPv6FirewallRuleArgs()
        {
        }
    }

    public sealed class GetIPv6FirewallRuleInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the firewall rule.
        /// </summary>
        [Input("firewallRuleName", required: true)]
        public Input<string> FirewallRuleName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        public GetIPv6FirewallRuleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIPv6FirewallRuleResult
    {
        /// <summary>
        /// The end IP address of the firewall rule. Must be IPv6 format. Must be greater than or equal to startIpAddress.
        /// </summary>
        public readonly string? EndIPv6Address;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The start IP address of the firewall rule. Must be IPv6 format.
        /// </summary>
        public readonly string? StartIPv6Address;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetIPv6FirewallRuleResult(
            string? endIPv6Address,

            string id,

            string? name,

            string? startIPv6Address,

            string type)
        {
            EndIPv6Address = endIPv6Address;
            Id = id;
            Name = name;
            StartIPv6Address = startIPv6Address;
            Type = type;
        }
    }
}
