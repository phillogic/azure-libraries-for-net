// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Used for getting ResourceHealthCheck settings.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ResourceHealthMetadataInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceHealthMetadataInner
        /// class.
        /// </summary>
        public ResourceHealthMetadataInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceHealthMetadataInner
        /// class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="category">The category that the resource matches in
        /// the RHC Policy File</param>
        /// <param name="signalAvailability">Is there a health signal for the
        /// resource</param>
        public ResourceHealthMetadataInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string category = default(string), bool? signalAvailability = default(bool?))
            : base(id, name, type, kind)
        {
            Category = category;
            SignalAvailability = signalAvailability;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the category that the resource matches in the RHC
        /// Policy File
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets is there a health signal for the resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.signalAvailability")]
        public bool? SignalAvailability { get; set; }

    }
}
