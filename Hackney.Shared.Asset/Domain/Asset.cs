using System;

namespace Hackney.Shared.Asset.Domain
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string AssetId { get; set; }
        public AssetType AssetType { get; set; }
        public string RootAsset { get; set; }
        public string ParentAssetIds { get; set; }

        public AssetLocation AssetLocation { get; set; }
        public AssetAddress AssetAddress { get; set; }
        public AssetManagement AssetManagement { get; set; }
        public AssetCharacteristics AssetCharacteristics { get; set; }
        public AssetTenure Tenure { get; set; }
        public int? VersionNumber { get; set; }

        public static Asset Create(string id,
            string assetId,
            string assetType,
            string rootAsset,
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
                ParentAssetIds = parentAssetIds,
                AssetAddress = assetAddress,
                Tenure = tenure,
                AssetCharacteristics = assetCharacteristics,
                AssetManagement = assetManagement
            };
        }
    }
}
