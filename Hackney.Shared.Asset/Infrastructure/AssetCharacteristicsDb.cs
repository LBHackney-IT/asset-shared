using System;

namespace Hackney.Shared.Asset.Infrastructure
{
    public class AssetCharacteristicsDb
    {
        public int? NumberOfBedrooms { get; set; }
        public int? NumberOfSingleBeds { get; set; }
        public int? NumberOfDoubleBeds { get; set; }
        public int? NumberOfLifts { get; set; }
        public int? NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
        public string AssetPropertyFolderLink { get; set; }
        public DateTime? EpcExpiryDate { get; set; }
        public DateTime? FireSafetyCertificateExpiryDate { get; set; }
        public DateTime? GasSafetyCertificateExpiryDate { get; set; }
        public DateTime? ElecCertificateExpiryDate { get; set; }
        public bool? HasStairs { get; set; }
        public int? NumberOfStairs { get; set; }
        public bool? HasRampAccess { get; set; }
        public bool? HasCommunalAreas { get; set; }
        public bool? HasPrivateBathroom { get; set; }
        public int? NumberOfBathrooms { get; set; }
        public string BathroomFloor { get; set; }
        public bool? HasPrivateKitchen { get; set; }
        public int? NumberOfKitchens { get; set; }
        public string Kitchenfloor { get; set; }
        public DateTime? AlertSystemExpiryDate { get; set; }
        public string EpcScore { get; set; }
        public int? NumberOfFloors { get; set; }
        public string Heating { get; set; }
        public float? PropertyFactor { get; set; }
        public string ArchitecturalType { get; set; }
        public string AccessibilityComments { get; set; }
        public int? NumberOfBedSpaces { get; set; }
        public int? NumberOfCots { get; set; }
        public string SleepingArrangementNotes { get; set; }
        public int? NumberOfShowers { get; set; }
        public string KitchenNotes { get; set; }
        public bool? IsStepFree { get; set; }
        public string BathroomNotes { get; set; }
        public string LivingRoomNotes { get; set; }
    }
}
