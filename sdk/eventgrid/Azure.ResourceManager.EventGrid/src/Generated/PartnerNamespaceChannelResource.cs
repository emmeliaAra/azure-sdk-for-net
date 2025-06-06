// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a PartnerNamespaceChannel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PartnerNamespaceChannelResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPartnerNamespaceChannelResource method.
    /// Otherwise you can get one from its parent resource <see cref="PartnerNamespaceResource"/> using the GetPartnerNamespaceChannel method.
    /// </summary>
    public partial class PartnerNamespaceChannelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PartnerNamespaceChannelResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="partnerNamespaceName"> The partnerNamespaceName. </param>
        /// <param name="channelName"> The channelName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string partnerNamespaceName, string channelName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _partnerNamespaceChannelChannelsClientDiagnostics;
        private readonly ChannelsRestOperations _partnerNamespaceChannelChannelsRestClient;
        private readonly PartnerNamespaceChannelData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/partnerNamespaces/channels";

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespaceChannelResource"/> class for mocking. </summary>
        protected PartnerNamespaceChannelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespaceChannelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PartnerNamespaceChannelResource(ArmClient client, PartnerNamespaceChannelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespaceChannelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PartnerNamespaceChannelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerNamespaceChannelChannelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string partnerNamespaceChannelChannelsApiVersion);
            _partnerNamespaceChannelChannelsRestClient = new ChannelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerNamespaceChannelChannelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PartnerNamespaceChannelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of a channel.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PartnerNamespaceChannelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.Get");
            scope.Start();
            try
            {
                var response = await _partnerNamespaceChannelChannelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerNamespaceChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a channel.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PartnerNamespaceChannelResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.Get");
            scope.Start();
            try
            {
                var response = _partnerNamespaceChannelChannelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerNamespaceChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existing channel.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.Delete");
            scope.Start();
            try
            {
                var response = await _partnerNamespaceChannelChannelsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_partnerNamespaceChannelChannelsClientDiagnostics, Pipeline, _partnerNamespaceChannelChannelsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existing channel.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.Delete");
            scope.Start();
            try
            {
                var response = _partnerNamespaceChannelChannelsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_partnerNamespaceChannelChannelsClientDiagnostics, Pipeline, _partnerNamespaceChannelChannelsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Synchronously updates a channel with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Channel update information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response> UpdateAsync(PartnerNamespaceChannelPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.Update");
            scope.Start();
            try
            {
                var response = await _partnerNamespaceChannelChannelsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Synchronously updates a channel with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Channel update information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response Update(PartnerNamespaceChannelPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.Update");
            scope.Start();
            try
            {
                var response = _partnerNamespaceChannelChannelsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the full endpoint URL of a partner destination channel.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}/getFullUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_GetFullUri</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventSubscriptionFullUri>> GetFullUriAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.GetFullUri");
            scope.Start();
            try
            {
                var response = await _partnerNamespaceChannelChannelsRestClient.GetFullUriAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the full endpoint URL of a partner destination channel.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{partnerNamespaceName}/channels/{channelName}/getFullUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_GetFullUri</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerNamespaceChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventSubscriptionFullUri> GetFullUri(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerNamespaceChannelChannelsClientDiagnostics.CreateScope("PartnerNamespaceChannelResource.GetFullUri");
            scope.Start();
            try
            {
                var response = _partnerNamespaceChannelChannelsRestClient.GetFullUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
