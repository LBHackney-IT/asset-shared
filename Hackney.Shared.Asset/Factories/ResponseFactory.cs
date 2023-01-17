using Hackney.Shared.Asset.Boundary.Response;
using Hackney.Shared.Asset.Domain;
using Hackney.Shared.PatchesAndAreas.Boundary.Response;
using Hackney.Shared.PatchesAndAreas.Domain;
using Hackney.Shared.PatchesAndAreas.Factories;
using System.Collections.Generic;
using System.Linq;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;

namespace Hackney.Shared.Asset.Factories
{
    public static class ResponseFactory
    {
        public static AssetResponseObject ToResponse(this AssetDomain domain)
        {
            if (domain == null) return null;
            return new AssetResponseObject()
            {
                Id = domain.Id,
                AssetId = domain.AssetId,
                AssetType = domain.AssetType,
                RootAsset = domain.RootAsset,
                IsActive = domain.IsActive,
                ParentAssetIds = domain.ParentAssetIds,
                AssetLocation = domain.AssetLocation,
                AssetAddress = domain.AssetAddress,
                AssetManagement = domain.AssetManagement,
                AssetCharacteristics = domain.AssetCharacteristics,
                Tenure = domain.Tenure.ToResponse(),
                Patches = domain.Patches?.ToResponse(),
                VersionNumber = domain.VersionNumber
            };
        }

        public static AssetTenureResponseObject ToResponse(this AssetTenure domain)
        {
            if (domain == null) return null;
            return new AssetTenureResponseObject()
            {
                Id = domain.Id,
                PaymentReference = domain.PaymentReference,
                Type = domain.Type,
                StartOfTenureDate = domain.StartOfTenureDate,
                EndOfTenureDate = domain.EndOfTenureDate,
                IsActive = domain.IsActive
            };
        }

        public static List<PatchesResponseObject?> ToResponse(this IEnumerable<PatchEntity?> domainList)
        {
            if (null == domainList) return new List<PatchesResponseObject?>();
            return domainList.Select(domain => domain.ToResponse()).ToList();
        }
    }
}
