using System;

namespace Hackney.Shared.Asset.Domain
{
    public class AssetCharacteristics
    {
        public int NumberOfBedrooms { get; set; }
        public int NumberOfLifts { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
        public int NumberOfBedSpaces { get; set; }
        public int NumberOfCots { get; set; }
        public int ShowerRoomAmount { get; set; }
        public int BathroomAmount { get; set; }
        public string AssetPropertyFolderLink { get; set; }
        public DateTime? EpcExpiryDate { get; set; }
        public DateTime? FireSafetyCertificateExpiryDate { get; set; }
        public DateTime? GasSafetyCertificateExpiryDate { get; set; }
        public DateTime? ElecCertificateExpiryDate { get; set; }


    }
}

