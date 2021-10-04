using System;

namespace Hackney.Shared.Asset.Boundary.Responses.Metadata
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("Result not found")
        { }
        public NotFoundException(string message) : base(message)
        { }
    }
}
