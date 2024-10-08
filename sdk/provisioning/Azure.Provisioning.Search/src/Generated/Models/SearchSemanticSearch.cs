// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Search;

/// <summary>
/// Sets options that control the availability of semantic search. This
/// configuration is only possible for certain Azure AI Search SKUs in certain
/// locations.
/// </summary>
public enum SearchSemanticSearch
{
    /// <summary>
    /// Indicates that semantic reranker is disabled for the search service.
    /// This is the default.
    /// </summary>
    [DataMember(Name = "disabled")]
    Disabled,

    /// <summary>
    /// Enables semantic reranker on a search service and indicates that it is
    /// to be used within the limits of the free plan. The free plan would cap
    /// the volume of semantic ranking requests and is offered at no extra
    /// charge. This is the default for newly provisioned search services.
    /// </summary>
    [DataMember(Name = "free")]
    Free,

    /// <summary>
    /// Enables semantic reranker on a search service as a billable feature,
    /// with higher throughput and volume of semantically reranked queries.
    /// </summary>
    [DataMember(Name = "standard")]
    Standard,
}
