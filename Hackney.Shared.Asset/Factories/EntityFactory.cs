

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
                RentGroup = databaseEntity.RentGroup,
                RootAsset = databaseEntity.RootAsset,
                IsActive = databaseEntity.IsActive,
                ParentAssetIds = databaseEntity.ParentAssetIds,
                AssetLocation = databaseEntity.AssetLocation,
                AssetAddress = databaseEntity.AssetAddress,
                AssetManagement = databaseEntity.AssetManagement,
                AssetCharacteristics = databaseEntity.AssetCharacteristics.ToDomain(),
                Tenure = databaseEntity.Tenure.ToDomain(),
                VersionNumber = databaseEntity.VersionNumber,
                Patches = databaseEntity.Patches?.ToDomain()
            };
        }

        # region Asset Characteristics
        public static AssetCharacteristics ToDomain(this AssetCharacteristicsDb databaseEntity)
        {
            if (databaseEntity is null) return null;

            return new AssetCharacteristics
            {
                NumberOfBedrooms = databaseEntity.NumberOfBedrooms,
                NumberOfSingleBeds = databaseEntity.NumberOfSingleBeds,
                NumberOfDoubleBeds = databaseEntity.NumberOfDoubleBeds,
                NumberOfLifts = databaseEntity.NumberOfLifts,
                NumberOfLivingRooms = databaseEntity.NumberOfLivingRooms,
                WindowType = databaseEntity.WindowType,
                YearConstructed = databaseEntity.YearConstructed,
                AssetPropertyFolderLink = databaseEntity.AssetPropertyFolderLink,
                EpcExpiryDate = databaseEntity.EpcExpiryDate,
                FireSafetyCertificateExpiryDate = databaseEntity.FireSafetyCertificateExpiryDate,
                GasSafetyCertificateExpiryDate = databaseEntity.GasSafetyCertificateExpiryDate,
                ElecCertificateExpiryDate = databaseEntity.ElecCertificateExpiryDate,
                HasStairs = databaseEntity.HasStairs,
                NumberOfStairs = databaseEntity.NumberOfStairs,
                HasRampAccess = databaseEntity.HasRampAccess,
                HasCommunalAreas = databaseEntity.HasCommunalAreas,
                HasPrivateBathroom = databaseEntity.HasPrivateBathroom,
                NumberOfBathrooms = databaseEntity.NumberOfBathrooms,
                BathroomFloor = databaseEntity.BathroomFloor,
                HasPrivateKitchen = databaseEntity.HasPrivateKitchen,
                NumberOfKitchens = databaseEntity.NumberOfKitchens,
                Kitchenfloor = databaseEntity.Kitchenfloor,
                AlertSystemExpiryDate = databaseEntity.AlertSystemExpiryDate,
                EpcScore = databaseEntity.EpcScore,
                NumberOfFloors = databaseEntity.NumberOfFloors,
                Heating = databaseEntity.Heating,
                PropertyFactor = databaseEntity.PropertyFactor,
                ArchitecturalType = databaseEntity.ArchitecturalType,
                AccessibilityComments = databaseEntity.AccessibilityComments,
                NumberOfBedSpaces = databaseEntity.NumberOfBedSpaces,
                NumberOfCots = databaseEntity.NumberOfCots,
                SleepingArrangementNotes = databaseEntity.SleepingArrangementNotes,
                NumberOfShowers = databaseEntity.NumberOfShowers,
                KitchenNotes = databaseEntity.KitchenNotes,
                IsStepFree = databaseEntity.IsStepFree,
                BathroomNotes = databaseEntity.BathroomNotes,
                LivingRoomNotes = databaseEntity.LivingRoomNotes
            };
        }

        public static AssetCharacteristicsDb ToDatabase(this AssetCharacteristics domainEntity)
        {
            if (domainEntity is null) return null;

            return new AssetCharacteristicsDb
            {
                NumberOfBedrooms = domainEntity.NumberOfBedrooms,
                NumberOfSingleBeds = domainEntity.NumberOfSingleBeds,
                NumberOfDoubleBeds = domainEntity.NumberOfDoubleBeds,
                NumberOfLifts = domainEntity.NumberOfLifts,
                NumberOfLivingRooms = domainEntity.NumberOfLivingRooms,
                WindowType = domainEntity.WindowType,
                YearConstructed = domainEntity.YearConstructed,
                AssetPropertyFolderLink = domainEntity.AssetPropertyFolderLink,
                EpcExpiryDate = domainEntity.EpcExpiryDate,
                FireSafetyCertificateExpiryDate = domainEntity.FireSafetyCertificateExpiryDate,
                GasSafetyCertificateExpiryDate = domainEntity.GasSafetyCertificateExpiryDate,
                ElecCertificateExpiryDate = domainEntity.ElecCertificateExpiryDate,
                HasStairs = domainEntity.HasStairs,
                NumberOfStairs = domainEntity.NumberOfStairs,
                HasRampAccess = domainEntity.HasRampAccess,
                HasCommunalAreas = domainEntity.HasCommunalAreas,
                HasPrivateBathroom = domainEntity.HasPrivateBathroom,
                NumberOfBathrooms = domainEntity.NumberOfBathrooms,
                BathroomFloor = domainEntity.BathroomFloor,
                HasPrivateKitchen = domainEntity.HasPrivateKitchen,
                NumberOfKitchens = domainEntity.NumberOfKitchens,
                Kitchenfloor = domainEntity.Kitchenfloor,
                AlertSystemExpiryDate = domainEntity.AlertSystemExpiryDate,
                EpcScore = domainEntity.EpcScore,
                NumberOfFloors = domainEntity.NumberOfFloors,
                Heating = domainEntity.Heating,
                PropertyFactor = domainEntity.PropertyFactor,
                ArchitecturalType = domainEntity.ArchitecturalType,
                AccessibilityComments = domainEntity.AccessibilityComments,
                NumberOfBedSpaces = domainEntity.NumberOfBedSpaces,
                NumberOfCots = domainEntity.NumberOfCots,
                SleepingArrangementNotes = domainEntity.SleepingArrangementNotes,
                NumberOfShowers = domainEntity.NumberOfShowers,
                KitchenNotes = domainEntity.KitchenNotes,
                IsStepFree = domainEntity.IsStepFree,
                BathroomNotes = domainEntity.BathroomNotes,
                LivingRoomNotes = domainEntity.LivingRoomNotes
            };
        }
        #endregion

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
                RentGroup = domain.RentGroup,
                RootAsset = domain.RootAsset,
                IsActive = domain.IsActive,
                ParentAssetIds = domain.ParentAssetIds,
                AssetLocation = domain.AssetLocation,
                AssetAddress = domain.AssetAddress,
                AssetManagement = domain.AssetManagement,
                AssetCharacteristics = domain.AssetCharacteristics.ToDatabase(),
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