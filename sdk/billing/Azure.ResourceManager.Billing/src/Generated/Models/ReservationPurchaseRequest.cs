// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The request for reservation purchase. </summary>
    public partial class ReservationPurchaseRequest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationPurchaseRequest"/>. </summary>
        public ReservationPurchaseRequest()
        {
            AppliedScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ReservationPurchaseRequest"/>. </summary>
        /// <param name="sku"> The name of sku. </param>
        /// <param name="location"> The Azure region where the reserved resource lives. </param>
        /// <param name="reservedResourceType"> The reserved source type of the reservation, e.g. virtual machine. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing reservation or savings plan. </param>
        /// <param name="term"> The term of the reservation, e.g. P1Y. </param>
        /// <param name="billingPlan"> Represent the billing plans. </param>
        /// <param name="quantity"> Quantity of the skus that are part of the reservation. Must be greater than zero. </param>
        /// <param name="displayName"> Friendly name of the reservation. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopes"> List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </param>
        /// <param name="isRenewed"> Setting this to true will automatically purchase a new benefit on the expiration date time. </param>
        /// <param name="instanceFlexibilityPropertiesInstanceFlexibility"> Allows reservation discount to be applied across skus within the same auto fit group. Not all skus support instance size flexibility. </param>
        /// <param name="reviewOn"> This is the date-time when the Azure hybrid benefit needs to be reviewed. </param>
        /// <param name="instanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility"> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationPurchaseRequest(BillingSkuName sku, AzureLocation? location, string reservedResourceType, string billingScopeId, string term, ReservationBillingPlan? billingPlan, int? quantity, string displayName, BillingAppliedScopeType? appliedScopeType, IList<string> appliedScopes, ReservationAppliedScopeProperties appliedScopeProperties, bool? isRenewed, InstanceFlexibility? instanceFlexibilityPropertiesInstanceFlexibility, DateTimeOffset? reviewOn, InstanceFlexibility? instanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sku = sku;
            Location = location;
            ReservedResourceType = reservedResourceType;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            Quantity = quantity;
            DisplayName = displayName;
            AppliedScopeType = appliedScopeType;
            AppliedScopes = appliedScopes;
            AppliedScopeProperties = appliedScopeProperties;
            IsRenewed = isRenewed;
            InstanceFlexibilityPropertiesInstanceFlexibility = instanceFlexibilityPropertiesInstanceFlexibility;
            ReviewOn = reviewOn;
            InstanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility = instanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of sku. </summary>
        internal BillingSkuName Sku { get; set; }
        /// <summary> Gets or sets the sku name. </summary>
        [WirePath("sku.name")]
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new BillingSkuName();
                Sku.Name = value;
            }
        }

        /// <summary> The Azure region where the reserved resource lives. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> The reserved source type of the reservation, e.g. virtual machine. </summary>
        [WirePath("properties.reservedResourceType")]
        public string ReservedResourceType { get; }
        /// <summary> Subscription that will be charged for purchasing reservation or savings plan. </summary>
        [WirePath("properties.billingScopeId")]
        public string BillingScopeId { get; }
        /// <summary> The term of the reservation, e.g. P1Y. </summary>
        [WirePath("properties.term")]
        public string Term { get; }
        /// <summary> Represent the billing plans. </summary>
        [WirePath("properties.billingPlan")]
        public ReservationBillingPlan? BillingPlan { get; set; }
        /// <summary> Quantity of the skus that are part of the reservation. Must be greater than zero. </summary>
        [WirePath("properties.quantity")]
        public int? Quantity { get; set; }
        /// <summary> Friendly name of the reservation. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        [WirePath("properties.appliedScopeType")]
        public BillingAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. </summary>
        [WirePath("properties.appliedScopes")]
        public IList<string> AppliedScopes { get; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </summary>
        [WirePath("properties.appliedScopeProperties")]
        public ReservationAppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Setting this to true will automatically purchase a new benefit on the expiration date time. </summary>
        [WirePath("properties.renew")]
        public bool? IsRenewed { get; set; }
        /// <summary> Allows reservation discount to be applied across skus within the same auto fit group. Not all skus support instance size flexibility. </summary>
        [WirePath("properties.instanceFlexibility")]
        public InstanceFlexibility? InstanceFlexibilityPropertiesInstanceFlexibility { get; set; }
        /// <summary> This is the date-time when the Azure hybrid benefit needs to be reviewed. </summary>
        [WirePath("properties.reviewDateTime")]
        public DateTimeOffset? ReviewOn { get; set; }
        /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </summary>
        [WirePath("properties.instanceFlexibility")]
        public InstanceFlexibility? InstanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility { get; set; }
    }
}
