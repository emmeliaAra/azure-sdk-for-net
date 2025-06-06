# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: Quota
namespace: Azure.ResourceManager.Quota
require: https://github.com/Azure/azure-rest-api-specs/blob/8abab3c9c1ff7c4f9d393c2ddb00e5f735289b37/specification/quota/resource-manager/readme.md
#tag: package-2025-03-01
output-folder: $(this-folder)/Generated
clear-output-folder: true
sample-gen:
  output-folder: $(this-folder)/../tests/Generated
  clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false
use-model-reader-writer: true
enable-bicep-serialization: true

#mgmt-debug:
#  show-serialized-names: true

format-by-name-rules:
  'tenantId': 'uuid'
  'ETag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

acronym-mapping:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs|ips
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4|ipv4
  Ipv6: IPv6|ipv6
  Ipsec: IPsec|ipsec
  SSO: Sso
  URI: Uri
  Etag: ETag|etag

rename-mapping:
  LimitJsonObject: QuotaLimitJsonObject
  LimitObject: QuotaLimitObject
  OperationList: QuotaOperationListResult
  OperationResponse: QuotaOperationResult
  OperationDisplay: QuotaOperationDisplay
  ResourceName: QuotaRequestResourceName
  SubRequest: QuotaSubRequestDetail
  SubRequest.subRequestId: -|uuid
  UsagesObject: QuotaUsagesObject
  UsagesProperties: QuotaUsagesProperties
  UsagesTypes: QuotaUsagesType
  UsagesProperties.resourceType: ResourceTypeName
  QuotaProperties.resourceType: ResourceTypeName
  SubRequest.resourceType: ResourceTypeName
  GroupQuotasEntity: GroupQuotaEntity
  GroupQuotasEntityBase: GroupQuotaEntityBase
  GroupQuotaSubscriptionId: GroupQuotaSubscription
  GroupQuotaSubscriptionIdProperties: GroupQuotaSubscriptionProperties
  QuotaAllocationRequestStatus.properties.requestSubmitTime: RequestSubmittedOn
  SubmittedResourceRequestStatus: GroupQuotaRequestStatus
  SubmittedResourceRequestStatusProperties: GroupQuotaRequestStatusProperties
  SubmittedResourceRequestStatusProperties.requestSubmitTime: RequestSubmittedOn
  AllocatedToSubscription: SubscriptionAllocatedQuota
  RequestState: QuotaRequestStatus
  ResourceUsages: GroupQuotaResourceUsages

directive:
# Correct the type of properties
  - from: quota.json
    where: $.definitions
    transform: >
      $.QuotaProperties.properties.quotaPeriod['format'] = 'duration';
      $.UsagesProperties.properties.quotaPeriod['format'] = 'duration';

list-exception:
- /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/groupQuotaRequests/{requestId}
- /providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/quotaAllocationRequests/{allocationId}

```
