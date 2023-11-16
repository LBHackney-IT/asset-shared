using Hackney.Shared.Asset.Domain;
using System;

namespace Hackney.Shared.Asset.Boundary.Response
{
    public class AssetResponseObject
    {
        public Guid Id { get; set; }
        public string AssetId { get; set; }
        public Guid? AreaId { get; set; }
        public Guid? PatchId { get; set; }
        public AssetType AssetType { get; set; }
        public RentGroup? RentGroup { get; set; }
        public string RootAsset { get; set; }
        public bool IsActive { get; set; }
        public string ParentAssetIds { get; set; }
        public string BoilerHouseId { get; set; }
        public AssetLocation AssetLocation { get; set; }
        public AssetAddress AssetAddress { get; set; }
        public AssetManagement AssetManagement { get; set; }
        public AssetCharacteristicsResponse AssetCharacteristics { get; set; }
        public AssetTenureResponseObject Tenure { get; set; }
        public int? VersionNumber { get; set; }
    }
}