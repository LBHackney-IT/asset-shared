using Hackney.Shared.Asset.Domain;

namespace Hackney.Shared.Asset.Boundary.Request
{
    public class EditAssetAddressRequest : EditAssetRequest
    {
        public AssetAddress AssetAddress { get; set; }
    }
}
