using Hackney.Shared.Asset.Domain;
using Hackney.Shared.PatchesAndAreas.Boundary.Response;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.Asset.Boundary.Response
{
    public class AssetResponseObject
    {
        public Guid Id { get; set; }
        public string AssetId { get; set; }
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
        public List<PatchesResponseObject?> Patches { get; set; }
        public int? VersionNumber { get; set; }
    }
}