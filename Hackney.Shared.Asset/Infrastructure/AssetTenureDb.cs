using System;

namespace Hackney.Shared.Asset.Infrastructure
{
    public class AssetTenureDb
    {
        public string Id { get; set; }
        public string PaymentReference { get; set; }
        public string Type { get; set; }
        public DateTime StartOfTenureDate { get; set; }
        public DateTime? EndOfTenureDate { get; set; }
    }
}