using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.Asset.Domain
{
    public class Charges
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public Frequency Frequency { get; set; }
        public decimal? Amount { get; set; }
    }
}
