using Hackney.Shared.Asset.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.Asset.Boundary.Request
{
    public class EditAssetRequest
    {
        public string RootAsset { get; set; }
        public string ParentAssetIds { get; set; }
        public string BoilerHouseId { get; set; }
        public bool IsActive { get; set; }
        public AssetLocation AssetLocation { get; set; }
        public AssetManagement AssetManagement { get; set; }
        public AssetCharacteristics AssetCharacteristics { get; set; }
    }
}
