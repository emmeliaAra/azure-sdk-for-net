// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class PartnerDestinationResource : IJsonModel<PartnerDestinationData>
    {
        void IJsonModel<PartnerDestinationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PartnerDestinationData>)Data).Write(writer, options);

        PartnerDestinationData IJsonModel<PartnerDestinationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PartnerDestinationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PartnerDestinationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PartnerDestinationData IPersistableModel<PartnerDestinationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PartnerDestinationData>(data, options);

        string IPersistableModel<PartnerDestinationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PartnerDestinationData>)Data).GetFormatFromOptions(options);
    }
}
