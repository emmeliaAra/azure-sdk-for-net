// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkSecurityPerimeterLinkResource"/> and their operations.
    /// Each <see cref="NetworkSecurityPerimeterLinkResource"/> in the collection will belong to the same instance of <see cref="NetworkSecurityPerimeterResource"/>.
    /// To get a <see cref="NetworkSecurityPerimeterLinkCollection"/> instance call the GetNetworkSecurityPerimeterLinks method from an instance of <see cref="NetworkSecurityPerimeterResource"/>.
    /// </summary>
    public partial class NetworkSecurityPerimeterLinkCollection : ArmCollection, IEnumerable<NetworkSecurityPerimeterLinkResource>, IAsyncEnumerable<NetworkSecurityPerimeterLinkResource>
    {
        private readonly ClientDiagnostics _networkSecurityPerimeterLinkClientDiagnostics;
        private readonly NetworkSecurityPerimeterLinksRestOperations _networkSecurityPerimeterLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterLinkCollection"/> class for mocking. </summary>
        protected NetworkSecurityPerimeterLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkSecurityPerimeterLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityPerimeterLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkSecurityPerimeterLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkSecurityPerimeterLinkResource.ResourceType, out string networkSecurityPerimeterLinkApiVersion);
            _networkSecurityPerimeterLinkRestClient = new NetworkSecurityPerimeterLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkSecurityPerimeterLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkSecurityPerimeterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkSecurityPerimeterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates NSP link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="data"> Parameters that hold the NspLink resource to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkSecurityPerimeterLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkName, NetworkSecurityPerimeterLinkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data, cancellationToken).ConfigureAwait(false);
                var uri = _networkSecurityPerimeterLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<NetworkSecurityPerimeterLinkResource>(Response.FromValue(new NetworkSecurityPerimeterLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates NSP link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="data"> Parameters that hold the NspLink resource to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkSecurityPerimeterLinkResource> CreateOrUpdate(WaitUntil waitUntil, string linkName, NetworkSecurityPerimeterLinkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data, cancellationToken);
                var uri = _networkSecurityPerimeterLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<NetworkSecurityPerimeterLinkResource>(Response.FromValue(new NetworkSecurityPerimeterLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified NSP link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityPerimeterLinkResource>> GetAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified NSP link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual Response<NetworkSecurityPerimeterLinkResource> Get(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the NSP Link resources in the specified network security perimeter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityPerimeterLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityPerimeterLinkResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterLinkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterLinkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterLinkResource(Client, NetworkSecurityPerimeterLinkData.DeserializeNetworkSecurityPerimeterLinkData(e)), _networkSecurityPerimeterLinkClientDiagnostics, Pipeline, "NetworkSecurityPerimeterLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the NSP Link resources in the specified network security perimeter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityPerimeterLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityPerimeterLinkResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterLinkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterLinkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterLinkResource(Client, NetworkSecurityPerimeterLinkData.DeserializeNetworkSecurityPerimeterLinkData(e)), _networkSecurityPerimeterLinkClientDiagnostics, Pipeline, "NetworkSecurityPerimeterLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkSecurityPerimeterLinkResource>> GetIfExistsAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterLinkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the NSP link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual NullableResponse<NetworkSecurityPerimeterLinkResource> GetIfExists(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _networkSecurityPerimeterLinkClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterLinkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityPerimeterLinkResource> IEnumerable<NetworkSecurityPerimeterLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityPerimeterLinkResource> IAsyncEnumerable<NetworkSecurityPerimeterLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
