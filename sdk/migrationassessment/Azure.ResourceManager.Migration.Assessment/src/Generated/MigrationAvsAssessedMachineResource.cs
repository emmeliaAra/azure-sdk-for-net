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

namespace Azure.ResourceManager.Migration.Assessment
{
    /// <summary>
    /// A Class representing a MigrationAvsAssessedMachine along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MigrationAvsAssessedMachineResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMigrationAvsAssessedMachineResource method.
    /// Otherwise you can get one from its parent resource <see cref="MigrationAvsAssessmentResource"/> using the GetMigrationAvsAssessedMachine method.
    /// </summary>
    public partial class MigrationAvsAssessedMachineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MigrationAvsAssessedMachineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="groupName"> The groupName. </param>
        /// <param name="assessmentName"> The assessmentName. </param>
        /// <param name="avsAssessedMachineName"> The avsAssessedMachineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string avsAssessedMachineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}/avsAssessedMachines/{avsAssessedMachineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _migrationAvsAssessedMachineAvsAssessedMachinesOperationsClientDiagnostics;
        private readonly AvsAssessedMachinesRestOperations _migrationAvsAssessedMachineAvsAssessedMachinesOperationsRestClient;
        private readonly MigrationAvsAssessedMachineData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Migrate/assessmentProjects/groups/avsAssessments/avsAssessedMachines";

        /// <summary> Initializes a new instance of the <see cref="MigrationAvsAssessedMachineResource"/> class for mocking. </summary>
        protected MigrationAvsAssessedMachineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAvsAssessedMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MigrationAvsAssessedMachineResource(ArmClient client, MigrationAvsAssessedMachineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAvsAssessedMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MigrationAvsAssessedMachineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationAvsAssessedMachineAvsAssessedMachinesOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string migrationAvsAssessedMachineAvsAssessedMachinesOperationsApiVersion);
            _migrationAvsAssessedMachineAvsAssessedMachinesOperationsRestClient = new AvsAssessedMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationAvsAssessedMachineAvsAssessedMachinesOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MigrationAvsAssessedMachineData Data
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
        /// Get a AvsAssessedMachine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}/avsAssessedMachines/{avsAssessedMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessedMachinesOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessedMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MigrationAvsAssessedMachineResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationAvsAssessedMachineAvsAssessedMachinesOperationsClientDiagnostics.CreateScope("MigrationAvsAssessedMachineResource.Get");
            scope.Start();
            try
            {
                var response = await _migrationAvsAssessedMachineAvsAssessedMachinesOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAvsAssessedMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AvsAssessedMachine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}/avsAssessedMachines/{avsAssessedMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessedMachinesOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessedMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrationAvsAssessedMachineResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationAvsAssessedMachineAvsAssessedMachinesOperationsClientDiagnostics.CreateScope("MigrationAvsAssessedMachineResource.Get");
            scope.Start();
            try
            {
                var response = _migrationAvsAssessedMachineAvsAssessedMachinesOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAvsAssessedMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
