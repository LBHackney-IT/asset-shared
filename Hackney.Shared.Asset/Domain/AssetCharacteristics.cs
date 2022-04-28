using System;
using System.Collections.Generic;

namespace Hackney.Shared.Asset.Domain
{
    public class AssetCharacteristics
    {
        public int NumberOfBedrooms { get; set; }
        public int NumberOfLifts { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
        public int NumberOfShowerRooms { get; set; }
        public string AssetPropertyFolderLink { get; set; }
        public DateTime? EpcExpiryDate { get; set; }
        public DateTime? FireSafetyCertificateExpiryDate { get; set; }
        public DateTime? GasSafetyCertificateExpiryDate { get; set; }
        public DateTime? ElecCertificateExpiryDate { get; set; }
        public bool OptionToTax { get; set; }
        public bool HasStairs { get; set; }
        public int NumberOfStairs { get; set; }
        public bool RampAccess { get; set; }
        public bool CommunalAreas { get; set; }
        public bool PrivateBathroom { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string BathroomFloor { get; set; }
        public bool PrivateKitchen { get; set; }
        public int NumberOfKitchens { get; set; }
        public string Kitchenfloor { get; set; }
        public DateTime AlertSystemExpiryDate { get; set; }
        public string EpcScore { get; set; }
        public int NumberOfFloors { get; set; }
        public string AccessibilityComments { get; set; }
        public int NumberOfBedSpaces { get; set; }
        public int NumberOfCots { get; set; }
        public int SleepingArrangementNotes { get; set; }
        public int NumberOfShowers { get; set; }
        public string KitchenNotes { get; set; }
        public int KitchenType { get; set; }
        public bool StepFree { get; set; }
        public List<string> SupplierInformation { get; set; }
        public bool IsStepFree { get; set; }
        public bool HasPrivateBathroom { get; set; }
        public bool HasPrivateKitchen { get; set; }
    }
}

