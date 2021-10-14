using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;

namespace Hackney.Shared.Asset.Gateway.Interfaces
{
    public interface IAssetGateway
    {
        Task<AssetDomain> GetAssetByIdAsync(Guid id);
        Task SaveAssetAsync(AssetDomain entity);
    }
}
