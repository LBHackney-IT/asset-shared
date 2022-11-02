using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.Asset.Domain
{
    public class AssetContract
    {
        public string Id { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public IEnumerable<Charges> Charges { get; set; }
    }
}
