// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MongoDBAtlas.Models
{
    /// <summary> Marketplace details for an organization. </summary>
    public partial class MongoDBAtlasMarketplaceDetails
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

        /// <summary> Initializes a new instance of <see cref="MongoDBAtlasMarketplaceDetails"/>. </summary>
        /// <param name="subscriptionId"> Azure subscription id for the the marketplace offer is purchased from. </param>
        /// <param name="offerDetails"> Offer details for the marketplace that is selected by the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="offerDetails"/> is null. </exception>
        public MongoDBAtlasMarketplaceDetails(string subscriptionId, MongoDBAtlasOfferDetails offerDetails)
        {
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(offerDetails, nameof(offerDetails));

            SubscriptionId = subscriptionId;
            OfferDetails = offerDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBAtlasMarketplaceDetails"/>. </summary>
        /// <param name="subscriptionId"> Azure subscription id for the the marketplace offer is purchased from. </param>
        /// <param name="subscriptionStatus"> Marketplace subscription status. </param>
        /// <param name="offerDetails"> Offer details for the marketplace that is selected by the user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBAtlasMarketplaceDetails(string subscriptionId, MarketplaceSubscriptionStatus? subscriptionStatus, MongoDBAtlasOfferDetails offerDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubscriptionId = subscriptionId;
            SubscriptionStatus = subscriptionStatus;
            OfferDetails = offerDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBAtlasMarketplaceDetails"/> for deserialization. </summary>
        internal MongoDBAtlasMarketplaceDetails()
        {
        }

        /// <summary> Azure subscription id for the the marketplace offer is purchased from. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Marketplace subscription status. </summary>
        public MarketplaceSubscriptionStatus? SubscriptionStatus { get; }
        /// <summary> Offer details for the marketplace that is selected by the user. </summary>
        public MongoDBAtlasOfferDetails OfferDetails { get; set; }
    }
}
