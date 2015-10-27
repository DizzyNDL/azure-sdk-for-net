// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A mobile service
    /// </summary>
    public partial class ClassicMobileService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ClassicMobileService class.
        /// </summary>
        public ClassicMobileService() { }

        /// <summary>
        /// Initializes a new instance of the ClassicMobileService class.
        /// </summary>
        public ClassicMobileService(string classicMobileServiceName = default(string))
        {
            ClassicMobileServiceName = classicMobileServiceName;
        }

        /// <summary>
        /// Name of the mobile service
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string ClassicMobileServiceName { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}