// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.PineconeVectorDB.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PineconeVectorDB
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PineconeVectorDB. </summary>
    public static partial class PineconeVectorDBExtensions
    {
        private static MockablePineconeVectorDBArmClient GetMockablePineconeVectorDBArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockablePineconeVectorDBArmClient(client0));
        }

        private static MockablePineconeVectorDBResourceGroupResource GetMockablePineconeVectorDBResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePineconeVectorDBResourceGroupResource(client, resource.Id));
        }

        private static MockablePineconeVectorDBSubscriptionResource GetMockablePineconeVectorDBSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePineconeVectorDBSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="PineconeVectorDBOrganizationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PineconeVectorDBOrganizationResource.CreateResourceIdentifier" /> to create a <see cref="PineconeVectorDBOrganizationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePineconeVectorDBArmClient.GetPineconeVectorDBOrganizationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PineconeVectorDBOrganizationResource"/> object. </returns>
        public static PineconeVectorDBOrganizationResource GetPineconeVectorDBOrganizationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePineconeVectorDBArmClient(client).GetPineconeVectorDBOrganizationResource(id);
        }

        /// <summary>
        /// Gets a collection of PineconeVectorDBOrganizationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePineconeVectorDBResourceGroupResource.GetPineconeVectorDBOrganizations()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of PineconeVectorDBOrganizationResources and their operations over a PineconeVectorDBOrganizationResource. </returns>
        public static PineconeVectorDBOrganizationCollection GetPineconeVectorDBOrganizations(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePineconeVectorDBResourceGroupResource(resourceGroupResource).GetPineconeVectorDBOrganizations();
        }

        /// <summary>
        /// Get a OrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Pinecone.VectorDb/organizations/{organizationname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-22-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PineconeVectorDBOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePineconeVectorDBResourceGroupResource.GetPineconeVectorDBOrganizationAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationname"> Name of the Organization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="organizationname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationname"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PineconeVectorDBOrganizationResource>> GetPineconeVectorDBOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockablePineconeVectorDBResourceGroupResource(resourceGroupResource).GetPineconeVectorDBOrganizationAsync(organizationname, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a OrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Pinecone.VectorDb/organizations/{organizationname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-22-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PineconeVectorDBOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePineconeVectorDBResourceGroupResource.GetPineconeVectorDBOrganization(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationname"> Name of the Organization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="organizationname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationname"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PineconeVectorDBOrganizationResource> GetPineconeVectorDBOrganization(this ResourceGroupResource resourceGroupResource, string organizationname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePineconeVectorDBResourceGroupResource(resourceGroupResource).GetPineconeVectorDBOrganization(organizationname, cancellationToken);
        }

        /// <summary>
        /// List OrganizationResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Pinecone.VectorDb/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-22-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PineconeVectorDBOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePineconeVectorDBSubscriptionResource.GetPineconeVectorDBOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="PineconeVectorDBOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PineconeVectorDBOrganizationResource> GetPineconeVectorDBOrganizationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePineconeVectorDBSubscriptionResource(subscriptionResource).GetPineconeVectorDBOrganizationsAsync(cancellationToken);
        }

        /// <summary>
        /// List OrganizationResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Pinecone.VectorDb/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-22-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PineconeVectorDBOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePineconeVectorDBSubscriptionResource.GetPineconeVectorDBOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="PineconeVectorDBOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PineconeVectorDBOrganizationResource> GetPineconeVectorDBOrganizations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePineconeVectorDBSubscriptionResource(subscriptionResource).GetPineconeVectorDBOrganizations(cancellationToken);
        }
    }
}
