// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteBuildUserProvidedFunctionAppResource : IJsonModel<StaticSiteUserProvidedFunctionAppData>
    {
        void IJsonModel<StaticSiteUserProvidedFunctionAppData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StaticSiteUserProvidedFunctionAppData>)Data).Write(writer, options);

        StaticSiteUserProvidedFunctionAppData IJsonModel<StaticSiteUserProvidedFunctionAppData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StaticSiteUserProvidedFunctionAppData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StaticSiteUserProvidedFunctionAppData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        StaticSiteUserProvidedFunctionAppData IPersistableModel<StaticSiteUserProvidedFunctionAppData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StaticSiteUserProvidedFunctionAppData>(data, options);

        string IPersistableModel<StaticSiteUserProvidedFunctionAppData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StaticSiteUserProvidedFunctionAppData>)Data).GetFormatFromOptions(options);
    }
}
