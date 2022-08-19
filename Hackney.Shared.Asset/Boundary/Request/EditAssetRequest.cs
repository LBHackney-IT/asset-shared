using Hackney.Shared.Asset.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.Asset.Boundary.Request
{
    public class EditAssetRequest
    {
        public AssetType AssetType { get; set; }

        public string RootAsset { get; set; }

        public string ParentAssetIds { get; set; }

        public AssetLocation AssetLocation { get; set; }

        public AssetAddress AssetAddress { get; set; }

        public AssetManagement AssetManagement { get; set; }

        public AssetCharacteristics AssetCharacteristics { get; set; }

    }
}
