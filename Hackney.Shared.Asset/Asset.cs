using System;

namespace Hackney.Shared.Asset
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string AssetId { get; set; }
        public AssetType AssetType { get; set; }
        public string RootAsset { get; set; }
        public string ParentAssetIds { get; set; }
        public bool IsAssetCautionaryAlerted { get; set; }

        public AssetLocation AssetLocation { get; set; }
        public AssetAddress AssetAddress { get; set; }
        public AssetManagement AssetManagement { get; set; }
        public AssetCharacteristics AssetCharacteristics { get; set; }
        public AssetTenure Tenure { get; set; }

        public int? VersionNumber { get; set; }

        public static Asset Create(string id,
            string assetId,
            string assetType,
            bool isAssetCautionaryAlerted,
            AssetAddress assetAddress,
            AssetTenure tenure)
        {
            return new Asset
            {
                Id = Guid.Parse(id),
                AssetId = assetId,
                AssetType = (AssetType)Enum.Parse(typeof(AssetType), assetType),
                IsAssetCautionaryAlerted = isAssetCautionaryAlerted,
                AssetAddress = assetAddress,
                Tenure = tenure
            };
        }
    }
}
