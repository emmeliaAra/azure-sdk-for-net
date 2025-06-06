// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CarbonOptimization.Models
{
    /// <summary> Query filter parameter to configure MonthlySummaryReport queries. </summary>
    public partial class MonthlySummaryReportQueryFilter : CarbonEmissionQueryFilter
    {
        /// <summary> Initializes a new instance of <see cref="MonthlySummaryReportQueryFilter"/>. </summary>
        /// <param name="dateRange"> The start and end dates for carbon emissions data. Required. For ItemDetailsReport and TopItemsSummaryReport, only one month of data is supported at a time, so start and end dates should be equal within DateRange (e.g., start: 2024-06-01 and end: 2024-06-01). </param>
        /// <param name="subscriptionList"> List of subscription IDs for which carbon emissions data is requested. Required. Each subscription ID should be in lowercase format. The max length of list is 100. </param>
        /// <param name="carbonScopeList"> List of carbon emission scopes. Required. Accepts one or more values from EmissionScopeEnum (e.g., Scope1, Scope2, Scope3) in list form. The output will include the total emissions for the specified scopes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dateRange"/>, <paramref name="subscriptionList"/> or <paramref name="carbonScopeList"/> is null. </exception>
        public MonthlySummaryReportQueryFilter(CarbonEmissionQueryDateRange dateRange, IEnumerable<string> subscriptionList, IEnumerable<CarbonEmissionScope> carbonScopeList) : base(dateRange, subscriptionList, carbonScopeList)
        {
            Argument.AssertNotNull(dateRange, nameof(dateRange));
            Argument.AssertNotNull(subscriptionList, nameof(subscriptionList));
            Argument.AssertNotNull(carbonScopeList, nameof(carbonScopeList));

            ReportType = CarbonEmissionQueryReportType.MonthlySummaryReport;
        }

        /// <summary> Initializes a new instance of <see cref="MonthlySummaryReportQueryFilter"/>. </summary>
        /// <param name="reportType"> The ReportType requested for carbon emissions data. Required. Specifies how data is aggregated and displayed in the output, as explained in the ReportTypeEnum. </param>
        /// <param name="dateRange"> The start and end dates for carbon emissions data. Required. For ItemDetailsReport and TopItemsSummaryReport, only one month of data is supported at a time, so start and end dates should be equal within DateRange (e.g., start: 2024-06-01 and end: 2024-06-01). </param>
        /// <param name="subscriptionList"> List of subscription IDs for which carbon emissions data is requested. Required. Each subscription ID should be in lowercase format. The max length of list is 100. </param>
        /// <param name="resourceGroupUrlList"> List of resource group URLs for carbon emissions data. Optional. Each URL must follow the format '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroup}', and should be in all lowercase. </param>
        /// <param name="resourceTypeList"> List of resource types for carbon emissions data. Optional. Each resource type should be specified in lowercase, following the format 'microsoft.{service}/{resourceType}', e.g., 'microsoft.storage/storageaccounts'. </param>
        /// <param name="locationList"> List of locations(Azure Region Display Name) for carbon emissions data, with each location specified in lowercase (e.g., 'east us'). Optional. You can use the command 'az account list-locations -o table' to find Azure Region Display Names. </param>
        /// <param name="carbonScopeList"> List of carbon emission scopes. Required. Accepts one or more values from EmissionScopeEnum (e.g., Scope1, Scope2, Scope3) in list form. The output will include the total emissions for the specified scopes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonthlySummaryReportQueryFilter(CarbonEmissionQueryReportType reportType, CarbonEmissionQueryDateRange dateRange, IList<string> subscriptionList, IList<string> resourceGroupUrlList, IList<ResourceType> resourceTypeList, IList<AzureLocation> locationList, IList<CarbonEmissionScope> carbonScopeList, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(reportType, dateRange, subscriptionList, resourceGroupUrlList, resourceTypeList, locationList, carbonScopeList, serializedAdditionalRawData)
        {
            ReportType = reportType;
        }

        /// <summary> Initializes a new instance of <see cref="MonthlySummaryReportQueryFilter"/> for deserialization. </summary>
        internal MonthlySummaryReportQueryFilter()
        {
        }
    }
}
