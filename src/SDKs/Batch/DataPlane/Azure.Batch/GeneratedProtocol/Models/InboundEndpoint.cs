// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An inbound endpoint on a compute node.
    /// </summary>
    public partial class InboundEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the InboundEndpoint class.
        /// </summary>
        public InboundEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InboundEndpoint class.
        /// </summary>
        /// <param name="name">The name of the endpoint.</param>
        /// <param name="protocol">The protocol of the endpoint.</param>
        /// <param name="publicIPAddress">The public IP address of the compute
        /// node.</param>
        /// <param name="publicFQDN">The public fully qualified domain name for
        /// the compute node.</param>
        /// <param name="frontendPort">The public port number of the
        /// endpoint.</param>
        /// <param name="backendPort">The backend port number of the
        /// endpoint.</param>
        public InboundEndpoint(string name, InboundEndpointProtocol protocol, string publicIPAddress, string publicFQDN, int frontendPort, int backendPort)
        {
            Name = name;
            Protocol = protocol;
            PublicIPAddress = publicIPAddress;
            PublicFQDN = publicFQDN;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the protocol of the endpoint.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'tcp', 'udp'
        /// </remarks>
        [JsonProperty(PropertyName = "protocol")]
        public InboundEndpointProtocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets the public IP address of the compute node.
        /// </summary>
        [JsonProperty(PropertyName = "publicIPAddress")]
        public string PublicIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the public fully qualified domain name for the compute
        /// node.
        /// </summary>
        [JsonProperty(PropertyName = "publicFQDN")]
        public string PublicFQDN { get; set; }

        /// <summary>
        /// Gets or sets the public port number of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "frontendPort")]
        public int FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets the backend port number of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "backendPort")]
        public int BackendPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (PublicIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicIPAddress");
            }
            if (PublicFQDN == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicFQDN");
            }
        }
    }
}