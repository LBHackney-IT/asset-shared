using System.Collections.Generic;

namespace Hackney.Shared.Asset.Boundary.Responses
{
    public class GetAssetListResponse
    {
        private long _total;

        public List<Domain.Asset> Assets { get; set; }

        public GetAssetListResponse()
        {
            Assets = new List<Domain.Asset>();
        }

        public void SetTotal(long total)
        {
            _total = total;
        }

        public long Total()
        {
            return _total;
        }
    }
}