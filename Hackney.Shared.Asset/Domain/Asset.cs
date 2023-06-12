using Hackney.Shared.PatchesAndAreas.Domain;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.Asset.Domain
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string AssetId { get; set; }
        public AssetType AssetType { get; set; }
        public RentGroup? RentGroup { get; set; }
        public string RootAsset { get; set; }
        public string ParentAssetIds { get; set; }

        public bool IsActive { get; set; }
        public AssetLocation AssetLocation { get; set; }
        public AssetAddress AssetAddress { get; set; }
        public AssetManagement AssetManagement { get; set; }
        public AssetCharacteristics AssetCharacteristics { get; set; }
        public AssetTenure Tenure { get; set; }
        public int? VersionNumber { get; set; }
        public List<PatchEntity?> Patches { get; set; }

        public static Asset Create(string id,
            string assetId,
            string assetType,
            string rootAsset,
            bool isActive,
            string parentAssetIds,
            AssetAddress assetAddress,
            AssetTenure tenure,
            AssetCharacteristics assetCharacteristics,
            AssetManagement assetManagement)
        {
            return new Asset
            {
                Id = Guid.Parse(id),
                AssetId = assetId,
                AssetType = (AssetType)Enum.Parse(typeof(AssetType), assetType),
                RootAsset = rootAsset,
                IsActive = isActive,
                ParentAssetIds = parentAssetIds,
                AssetAddress = assetAddress,
                Tenure = tenure,
                AssetCharacteristics = assetCharacteristics,
                AssetManagement = assetManagement
            };
        }
    }
}
