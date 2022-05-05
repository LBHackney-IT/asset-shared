using System;

namespace Hackney.Shared.Asset.Domain
{
    public class AssetManagement
    {
        public string Agent { get; set; }
        public string AreaOfficeName { get; set; }
        public bool IsCouncilProperty { get; set; }
        public string ManagingOrganisation { get; set; }
        public Guid ManagingOrganisationId { get; set; }
        public string Owner { get; set; }
        public bool IsTMOManaged { get; set; }
        public string PropertyOccupiedStatus { get; set; }
        public bool IsNoRepairsMaintenance { get; set; }
        public string FundingSource { get; set; }
        public string CostCentre { get; set; }
        public string CouncilTaxType { get; set; }
        public string CouncilTaxLiability { get; set; }
        public string LhaArea { get; set; }
        public bool IsTemporaryAccomodation { get; set; }
        public bool ReadyToLetDate { get; set; }
    }
}
