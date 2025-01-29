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
        public string PropertyOccupiedStatusReason { get; set; }
        public bool? IsNoRepairsMaintenance { get; set; }
        public string CouncilTaxType { get; set; }
        public string CouncilTaxLiability { get; set; }
        public bool? IsTemporaryAccomodation { get; set; }
        public bool? IsTemporaryAccommodationBlock { get; set; }
        public bool? IsPartOfTemporaryAccommodationBlock { get; set; }
        public Guid? TemporaryAccommodationParentAssetId { get; set; }
        public bool? ReadyToLetDate { get; set; }
    }
}
