// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The FeatureAttributionDriftMonitoringSignal. </summary>
    public partial class FeatureAttributionDriftMonitoringSignal : MonitoringSignalBase
    {
        /// <summary> Initializes a new instance of <see cref="FeatureAttributionDriftMonitoringSignal"/>. </summary>
        /// <param name="metricThreshold"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <param name="featureImportanceSettings"> [Required] The settings for computing feature importance. </param>
        /// <param name="productionData">
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="RollingInputData"/> and <see cref="StaticInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="RollingInputData"/> and <see cref="StaticInputData"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricThreshold"/>, <paramref name="featureImportanceSettings"/>, <paramref name="productionData"/> or <paramref name="referenceData"/> is null. </exception>
        public FeatureAttributionDriftMonitoringSignal(FeatureAttributionMetricThreshold metricThreshold, FeatureImportanceSettings featureImportanceSettings, IEnumerable<MonitoringInputDataBase> productionData, MonitoringInputDataBase referenceData)
        {
            Argument.AssertNotNull(metricThreshold, nameof(metricThreshold));
            Argument.AssertNotNull(featureImportanceSettings, nameof(featureImportanceSettings));
            Argument.AssertNotNull(productionData, nameof(productionData));
            Argument.AssertNotNull(referenceData, nameof(referenceData));

            MetricThreshold = metricThreshold;
            FeatureImportanceSettings = featureImportanceSettings;
            ProductionData = productionData.ToList();
            ReferenceData = referenceData;
            FeatureDataTypeOverride = new ChangeTrackingDictionary<string, MonitoringFeatureDataType>();
            SignalType = MonitoringSignalType.FeatureAttributionDrift;
        }

        /// <summary> Initializes a new instance of <see cref="FeatureAttributionDriftMonitoringSignal"/>. </summary>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="notificationTypes"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="metricThreshold"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <param name="featureImportanceSettings"> [Required] The settings for computing feature importance. </param>
        /// <param name="productionData">
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="RollingInputData"/> and <see cref="StaticInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="RollingInputData"/> and <see cref="StaticInputData"/>.
        /// </param>
        /// <param name="featureDataTypeOverride"> A dictionary that maps feature names to their respective data types. </param>
        internal FeatureAttributionDriftMonitoringSignal(MonitoringSignalType signalType, IList<MonitoringNotificationType> notificationTypes, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, FeatureAttributionMetricThreshold metricThreshold, FeatureImportanceSettings featureImportanceSettings, IList<MonitoringInputDataBase> productionData, MonitoringInputDataBase referenceData, IDictionary<string, MonitoringFeatureDataType> featureDataTypeOverride) : base(signalType, notificationTypes, properties, serializedAdditionalRawData)
        {
            MetricThreshold = metricThreshold;
            FeatureImportanceSettings = featureImportanceSettings;
            ProductionData = productionData;
            ReferenceData = referenceData;
            FeatureDataTypeOverride = featureDataTypeOverride;
            SignalType = signalType;
        }

        /// <summary> Initializes a new instance of <see cref="FeatureAttributionDriftMonitoringSignal"/> for deserialization. </summary>
        internal FeatureAttributionDriftMonitoringSignal()
        {
        }

        /// <summary> [Required] A list of metrics to calculate and their associated thresholds. </summary>
        [WirePath("metricThreshold")]
        public FeatureAttributionMetricThreshold MetricThreshold { get; set; }
        /// <summary> [Required] The settings for computing feature importance. </summary>
        [WirePath("featureImportanceSettings")]
        public FeatureImportanceSettings FeatureImportanceSettings { get; set; }
        /// <summary>
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="RollingInputData"/> and <see cref="StaticInputData"/>.
        /// </summary>
        [WirePath("productionData")]
        public IList<MonitoringInputDataBase> ProductionData { get; }
        /// <summary>
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="RollingInputData"/> and <see cref="StaticInputData"/>.
        /// </summary>
        [WirePath("referenceData")]
        public MonitoringInputDataBase ReferenceData { get; set; }
        /// <summary> A dictionary that maps feature names to their respective data types. </summary>
        [WirePath("featureDataTypeOverride")]
        public IDictionary<string, MonitoringFeatureDataType> FeatureDataTypeOverride { get; set; }
    }
}
