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
        public int numberOfBedSpaces { get; set; }
        public int numberOfCots { get; set; }
        public int showerRoomAmount { get; set; }
        public int bathroomAmount { get; set; }
        public string assetPropertyFolderLink { get; set; }
        public DateTime epcExpiryDate { get; set; }
        public DateTime fireSafetyCertificateExpiryDate { get; set; }
        public DateTime gasSafetyCertificateExpiryDate { get; set; }
        public DateTime elecCertificateExpiryDate { get; set; }


    }
}

