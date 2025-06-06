// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningRegistryEnvironmentContainerResource : IJsonModel<MachineLearningEnvironmentContainerData>
    {
        private static MachineLearningEnvironmentContainerData s_dataDeserializationInstance;
        private static MachineLearningEnvironmentContainerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MachineLearningEnvironmentContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningEnvironmentContainerData>)Data).Write(writer, options);

        MachineLearningEnvironmentContainerData IJsonModel<MachineLearningEnvironmentContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningEnvironmentContainerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningEnvironmentContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningEnvironmentContainerData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningEnvironmentContainerData IPersistableModel<MachineLearningEnvironmentContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningEnvironmentContainerData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningEnvironmentContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningEnvironmentContainerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
