// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Ranking options for file search. </summary>
    public partial class FileSearchRankingOptions
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

        /// <summary> Initializes a new instance of <see cref="FileSearchRankingOptions"/>. </summary>
        /// <param name="ranker"> File search ranker. </param>
        /// <param name="scoreThreshold"> Ranker search threshold. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ranker"/> is null. </exception>
        public FileSearchRankingOptions(string ranker, float scoreThreshold)
        {
            Argument.AssertNotNull(ranker, nameof(ranker));

            Ranker = ranker;
            ScoreThreshold = scoreThreshold;
        }

        /// <summary> Initializes a new instance of <see cref="FileSearchRankingOptions"/>. </summary>
        /// <param name="ranker"> File search ranker. </param>
        /// <param name="scoreThreshold"> Ranker search threshold. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileSearchRankingOptions(string ranker, float scoreThreshold, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Ranker = ranker;
            ScoreThreshold = scoreThreshold;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FileSearchRankingOptions"/> for deserialization. </summary>
        internal FileSearchRankingOptions()
        {
        }

        /// <summary> File search ranker. </summary>
        public string Ranker { get; set; }
        /// <summary> Ranker search threshold. </summary>
        public float ScoreThreshold { get; set; }
    }
}
