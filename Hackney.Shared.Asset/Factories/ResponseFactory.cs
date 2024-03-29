using Hackney.Shared.Asset.Boundary.Response;
using Hackney.Shared.Asset.Domain;
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
                AreaId = domain.AreaId,
                PatchId = domain.PatchId,
                AssetType = domain.AssetType,
                RentGroup = domain.RentGroup,
                RootAsset = domain.RootAsset,
                IsActive = domain.IsActive,
                ParentAssetIds = domain.ParentAssetIds,
                BoilerHouseId = domain.BoilerHouseId,
                AssetLocation = domain.AssetLocation,
                AssetAddress = domain.AssetAddress,
                AssetManagement = domain.AssetManagement,
                AssetCharacteristics = domain.AssetCharacteristics.ToResponse(),
                Tenure = domain.Tenure.ToResponse(),
                VersionNumber = domain.VersionNumber
            };
        }

        public static AssetCharacteristicsResponse ToResponse(this AssetCharacteristics domainEntity)
        {
            if (domainEntity is null) return null;

            return new AssetCharacteristicsResponse
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
    }
}
