using System;
using System.Text.Json.Serialization;

namespace Hackney.Shared.Asset.Domain
{
    public class AssetTenure
    {
        public string Id { get; set; }
        public string PaymentReference { get; set; }
        public string Type { get; set; }
        public DateTime StartOfTenureDate { get; set; }
        public DateTime? EndOfTenureDate { get; set; }
        [JsonIgnore]
        public bool IsActive => AssetHelpers.IsTenureActive(EndOfTenureDate);
    }
}
