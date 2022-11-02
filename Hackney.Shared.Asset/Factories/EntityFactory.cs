

using Hackney.Shared.Asset.Domain;
using Hackney.Shared.Asset.Infrastructure;
using Hackney.Shared.PatchesAndAreas.Domain;
using Hackney.Shared.PatchesAndAreas.Factories;
using Hackney.Shared.PatchesAndAreas.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;

namespace Hackney.Shared.Asset.Factories
{
    public static class EntityFactory
    {
        public static AssetDomain ToDomain(this AssetDb databaseEntity)
        {
            if (databaseEntity == null) return null;
            return new AssetDomain
            {
                Id = databaseEntity.Id,
                AssetId = databaseEntity.AssetId,
                AssetType = databaseEntity.AssetType,
                RootAsset = databaseEntity.RootAsset,
                IsActive = databaseEntity.IsActive,
                ParentAssetIds = databaseEntity.ParentAssetIds,
                AssetLocation = databaseEntity.AssetLocation,
                AssetAddress = databaseEntity.AssetAddress,
                AssetManagement = databaseEntity.AssetManagement,
                AssetCharacteristics = databaseEntity.AssetCharacteristics,
                AssetContract = databaseEntity.AssetContract,
                Tenure = databaseEntity.Tenure.ToDomain(),
                VersionNumber = databaseEntity.VersionNumber,
                Patches = databaseEntity.Patches?.ToDomain()
            };
        }

        public static AssetTenure ToDomain(this AssetTenureDb databaseEntity)
        {
            if (databaseEntity == null) return null;
            return new AssetTenure
            {
                Id = databaseEntity.Id,
                Type = databaseEntity.Type,
                PaymentReference = databaseEntity.PaymentReference,
                StartOfTenureDate = databaseEntity.StartOfTenureDate,
                EndOfTenureDate = databaseEntity.EndOfTenureDate
            };
        }

        public static List<PatchEntity?> ToDomain(this IEnumerable<PatchesDb?> databaseEntity)
        {
            return databaseEntity.Select(p => p.ToDomain())
                     .ToList();

        }

        public static AssetDb ToDatabase(this AssetDomain domain)
        {
            if (domain == null) return null;
            return new AssetDb
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
                AssetContract = domain.AssetContract,
                Tenure = domain.Tenure.ToDatabase(),
                VersionNumber = domain.VersionNumber,
                Patches = domain.Patches?.ToDatabase()
            };
        }

        public static AssetTenureDb ToDatabase(this AssetTenure domain)
        {
            if (domain == null) return null;
            return new AssetTenureDb
            {
                Id = domain.Id,
                Type = domain.Type,
                PaymentReference = domain.PaymentReference,
                StartOfTenureDate = domain.StartOfTenureDate,
                EndOfTenureDate = domain.EndOfTenureDate
            };
        }


        public static List<PatchesDb?> ToDatabase(this IEnumerable<PatchEntity?> domain)
        {
            return domain.Select(p => p.ToDatabase())
                     .ToList();

        }
    }
}