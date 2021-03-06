// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a built-in preset for encoding the input video with the
    /// Standard Encoder.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.BuiltInStandardEncoderPreset")]
    public partial class BuiltInStandardEncoderPreset : Preset
    {
        /// <summary>
        /// Initializes a new instance of the BuiltInStandardEncoderPreset
        /// class.
        /// </summary>
        public BuiltInStandardEncoderPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuiltInStandardEncoderPreset
        /// class.
        /// </summary>
        /// <param name="presetName">The built-in preset to be used for
        /// encoding videos. Possible values include: 'H264SingleBitrateSD',
        /// 'H264SingleBitrate720p', 'H264SingleBitrate1080p',
        /// 'AdaptiveStreaming', 'AACGoodQualityAudio',
        /// 'H264MultipleBitrate1080p', 'H264MultipleBitrate720p',
        /// 'H264MultipleBitrateSD'</param>
        public BuiltInStandardEncoderPreset(EncoderNamedPreset presetName)
        {
            PresetName = presetName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the built-in preset to be used for encoding videos.
        /// Possible values include: 'H264SingleBitrateSD',
        /// 'H264SingleBitrate720p', 'H264SingleBitrate1080p',
        /// 'AdaptiveStreaming', 'AACGoodQualityAudio',
        /// 'H264MultipleBitrate1080p', 'H264MultipleBitrate720p',
        /// 'H264MultipleBitrateSD'
        /// </summary>
        [JsonProperty(PropertyName = "presetName")]
        public EncoderNamedPreset PresetName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
