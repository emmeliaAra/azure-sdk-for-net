// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// ObjectReplicationPolicy.
/// </summary>
public partial class ObjectReplicationPolicy : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Required. Destination account name. It should be full resource id if
    /// allowCrossTenantReplication set to false.
    /// </summary>
    public BicepValue<string> DestinationAccount { get => _destinationAccount; set => _destinationAccount.Assign(value); }
    private readonly BicepValue<string> _destinationAccount;

    /// <summary>
    /// The storage account object replication rules.
    /// </summary>
    public BicepList<ObjectReplicationPolicyRule> Rules { get => _rules; set => _rules.Assign(value); }
    private readonly BicepList<ObjectReplicationPolicyRule> _rules;

    /// <summary>
    /// Required. Source account name. It should be full resource id if
    /// allowCrossTenantReplication set to false.
    /// </summary>
    public BicepValue<string> SourceAccount { get => _sourceAccount; set => _sourceAccount.Assign(value); }
    private readonly BicepValue<string> _sourceAccount;

    /// <summary>
    /// Indicates when the policy is enabled on the source account.
    /// </summary>
    public BicepValue<DateTimeOffset> EnabledOn { get => _enabledOn; }
    private readonly BicepValue<DateTimeOffset> _enabledOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// A unique id for object replication policy.
    /// </summary>
    public BicepValue<string> PolicyId { get => _policyId; }
    private readonly BicepValue<string> _policyId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Creates a new ObjectReplicationPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the ObjectReplicationPolicy.</param>
    /// <param name="resourceVersion">Version of the ObjectReplicationPolicy.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ObjectReplicationPolicy(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts/objectReplicationPolicies", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _destinationAccount = BicepValue<string>.DefineProperty(this, "DestinationAccount", ["properties", "destinationAccount"]);
        _rules = BicepList<ObjectReplicationPolicyRule>.DefineProperty(this, "Rules", ["properties", "rules"]);
        _sourceAccount = BicepValue<string>.DefineProperty(this, "SourceAccount", ["properties", "sourceAccount"]);
        _enabledOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EnabledOn", ["properties", "enabledTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _policyId = BicepValue<string>.DefineProperty(this, "PolicyId", ["properties", "policyId"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing ObjectReplicationPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the ObjectReplicationPolicy.</param>
    /// <param name="resourceVersion">Version of the ObjectReplicationPolicy.</param>
    /// <returns>The existing ObjectReplicationPolicy resource.</returns>
    public static ObjectReplicationPolicy FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
