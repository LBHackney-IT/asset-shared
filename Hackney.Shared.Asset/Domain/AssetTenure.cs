using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Hackney.Shared.Tenure.Domain;

namespace Hackney.Shared.Asset.Domain
{
    public class AssetTenure
    {
        public string Id { get; set; }
        public string PaymentReference { get; set; }
        public string Type { get; set; }
        public DateTime? StartOfTenureDate { get; set; }
        public DateTime? EndOfTenureDate { get; set; }
        [JsonIgnore]
        public bool IsActive => TenureHelpers.IsTenureActive(EndOfTenureDate);
        public List<LegacyReference> LegacyReferences { get; set; }
        public TenureType TenureType { get; set; }
        public string FundingSource { get; set; }
        public int NumberOfAdultsInProperty { get; set; }
        public int NumberOfChildrenInProperty { get; set; }
        public bool? HasOffsiteStorage { get; set; }
        public FurtherAccountInformation FurtherAccountInformation { get; set; }
    }
}
