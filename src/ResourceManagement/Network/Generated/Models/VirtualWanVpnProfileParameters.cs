// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Virtual Wan Vpn profile parameters Vpn profile generation.
    /// </summary>
    public partial class VirtualWanVpnProfileParameters
    {
        /// <summary>
        /// Initializes a new instance of the VirtualWanVpnProfileParameters
        /// class.
        /// </summary>
        public VirtualWanVpnProfileParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualWanVpnProfileParameters
        /// class.
        /// </summary>
        /// <param
        /// name="vpnServerConfigurationResourceId">VpnServerConfiguration
        /// partial resource uri with which VirtualWan is associated
        /// to.</param>
        /// <param name="authenticationMethod">VPN client authentication
        /// method. Possible values include: 'EAPTLS', 'EAPMSCHAPv2'</param>
        public VirtualWanVpnProfileParameters(string vpnServerConfigurationResourceId = default(string), AuthenticationMethod authenticationMethod = default(AuthenticationMethod))
        {
            VpnServerConfigurationResourceId = vpnServerConfigurationResourceId;
            AuthenticationMethod = authenticationMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets vpnServerConfiguration partial resource uri with which
        /// VirtualWan is associated to.
        /// </summary>
        [JsonProperty(PropertyName = "vpnServerConfigurationResourceId")]
        public string VpnServerConfigurationResourceId { get; set; }

        /// <summary>
        /// Gets or sets VPN client authentication method. Possible values
        /// include: 'EAPTLS', 'EAPMSCHAPv2'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationMethod")]
        public AuthenticationMethod AuthenticationMethod { get; set; }

    }
}
