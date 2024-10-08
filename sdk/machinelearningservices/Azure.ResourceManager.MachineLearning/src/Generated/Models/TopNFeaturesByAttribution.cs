// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The TopNFeaturesByAttribution. </summary>
    public partial class TopNFeaturesByAttribution : MonitoringFeatureFilterBase
    {
        /// <summary> Initializes a new instance of <see cref="TopNFeaturesByAttribution"/>. </summary>
        public TopNFeaturesByAttribution()
        {
            FilterType = MonitoringFeatureFilterType.TopNByAttribution;
        }

        /// <summary> Initializes a new instance of <see cref="TopNFeaturesByAttribution"/>. </summary>
        /// <param name="filterType"> [Required] Specifies the feature filter to leverage when selecting features to calculate metrics over. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="top"> The number of top features to include. </param>
        internal TopNFeaturesByAttribution(MonitoringFeatureFilterType filterType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? top) : base(filterType, serializedAdditionalRawData)
        {
            Top = top;
            FilterType = filterType;
        }

        /// <summary> The number of top features to include. </summary>
        [WirePath("top")]
        public int? Top { get; set; }
    }
}
