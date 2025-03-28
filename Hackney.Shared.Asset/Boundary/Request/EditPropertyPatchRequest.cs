using System;

namespace Hackney.Shared.Asset.Boundary.Request
{
    public class EditPropertyPatchRequest
    {
        public Guid AreaId { get; set; }
        public Guid PatchId { get; set; }
    }
}