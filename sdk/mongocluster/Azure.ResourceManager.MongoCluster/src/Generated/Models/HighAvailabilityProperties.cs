// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The high availability properties of the cluster. </summary>
    internal partial class HighAvailabilityProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HighAvailabilityProperties"/>. </summary>
        public HighAvailabilityProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HighAvailabilityProperties"/>. </summary>
        /// <param name="targetMode"> The target high availability mode requested for the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HighAvailabilityProperties(HighAvailabilityMode? targetMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetMode = targetMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The target high availability mode requested for the cluster. </summary>
        public HighAvailabilityMode? TargetMode { get; set; }
    }
}
