// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This activity blocks execution until a file has been validated to
    /// exist, with an optional minimum size, or the timeout is reached,
    /// whichever is earlier.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Validation")]
    [Rest.Serialization.JsonTransformation]
    public partial class ValidationActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the ValidationActivity class.
        /// </summary>
        public ValidationActivity()
        {
            Dataset = new DatasetReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidationActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="dataset">Validation activity dataset
        /// reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="timeout">Specifies the timeout for the activity to
        /// run. If there is no value specified, it takes the value of
        /// TimeSpan.FromDays(7) which is 1 week as default. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sleep">A delay in seconds between validation attempts.
        /// If no value is specified, 10 seconds will be used as the
        /// default.</param>
        /// <param name="minimumSize">Minimum size of a file in byte. If no
        /// value is specified, 0 byte will be used as the default.</param>
        public ValidationActivity(string name, DatasetReference dataset, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), object timeout = default(object), int? sleep = default(int?), int? minimumSize = default(int?))
            : base(name, additionalProperties, description, dependsOn, userProperties)
        {
            Timeout = timeout;
            Sleep = sleep;
            MinimumSize = minimumSize;
            Dataset = dataset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the timeout for the activity to run. If
        /// there is no value specified, it takes the value of
        /// TimeSpan.FromDays(7) which is 1 week as default. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeout")]
        public object Timeout { get; set; }

        /// <summary>
        /// Gets or sets a delay in seconds between validation attempts. If no
        /// value is specified, 10 seconds will be used as the default.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sleep")]
        public int? Sleep { get; set; }

        /// <summary>
        /// Gets or sets minimum size of a file in byte. If no value is
        /// specified, 0 byte will be used as the default.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.minimumSize")]
        public int? MinimumSize { get; set; }

        /// <summary>
        /// Gets or sets validation activity dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dataset");
            }
            if (Dataset != null)
            {
                Dataset.Validate();
            }
        }
    }
}