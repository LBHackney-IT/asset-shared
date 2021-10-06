using System.Collections.Generic;

namespace Hackney.Shared.Asset.Boundary.Response.Metadata
{
    public class APIError
    {
        public bool IsValid { get; set; }
        public IList<ValidationError> ValidationErrors { get; set; }
    }
}
