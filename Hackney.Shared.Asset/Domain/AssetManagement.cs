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
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierDetails { get; set; }
        public string PatchOfficer { get; set; }
        public string LandlordName { get; set; }
        public string LandlordEmail { get; set; }
        public string LandlordDetails { get; set; }
        public string HostelManagerName { get; set; }
        public string HostelManagerEmail { get; set; }
        public string HostelManagerDetails { get; set; }
        public string HostelCaretakerName { get; set; }
        public string HostelCaretakerEmail { get; set; }
        public string HostelCaretakerDetails { get; set; }
        public DateTime ContractRenewDate { get; set; }
        public string FundingSource { get; set; }
        public string CostCentre { get; set; }
        public string CouncilTaxBand { get; set; }
        public string CouncilTaxType { get; set; }
        public string CouncilTaxLiability { get; set; }
        public double RatesNightly { get; set; }
        public double RatesWeekly { get; set; }
        public double RatesMonthly { get; set; }
        public string LhaArea { get; set; }
        public double LhaRate { get; set; }
        public AssetType AssetStatus { get; set; }
        public bool AvailableToTA { get; set; }
        public bool ReadyToLetDate { get; set; }
        public bool IsHackneyManaged { get; set; }
        public bool StepFree { get; set; }
        public bool PrivateBathroom { get; set; }
        public bool PrivateKitchen { get; set; }
    }
}
