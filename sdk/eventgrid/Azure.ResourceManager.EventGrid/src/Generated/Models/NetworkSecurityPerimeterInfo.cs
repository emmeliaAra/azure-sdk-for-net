// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Network security perimeter info. </summary>
    public partial class NetworkSecurityPerimeterInfo
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterInfo"/>. </summary>
        public NetworkSecurityPerimeterInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterInfo"/>. </summary>
        /// <param name="id"> Arm id for network security perimeter. </param>
        /// <param name="perimeterGuid"> Network security perimeter guid. </param>
        /// <param name="location"> Network security perimeter location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterInfo(string id, string perimeterGuid, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            PerimeterGuid = perimeterGuid;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Arm id for network security perimeter. </summary>
        [WirePath("id")]
        public string Id { get; set; }
        /// <summary> Network security perimeter guid. </summary>
        [WirePath("perimeterGuid")]
        public string PerimeterGuid { get; set; }
        /// <summary> Network security perimeter location. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
    }
}
