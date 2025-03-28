using System;

namespace Hackney.Shared.Asset.Boundary.Request
{
    public class EditPropertyPatchRequest : EditAssetRequest
    {
        public Guid AreaId { get; set; }
        public Guid PatchId { get; set; }
    }
}