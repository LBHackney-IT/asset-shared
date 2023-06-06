using AutoFixture;
using Hackney.Shared.Asset.Domain;
using Hackney.Shared.Asset.Factories;
using Hackney.Shared.Asset.Infrastructure;
using FluentAssertions;
using Xunit;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;

namespace Hackney.Shared.Asset.Tests.Factories
{
    public class EntityFactoryTest
    {
        private readonly Fixture _fixture = new Fixture();

        [Fact]
        public void CanMapANullAssetDbToAnAsset()
        {
            AssetDb databaseEntity = null;
            var entity = databaseEntity.ToDomain();
            entity.Should().BeNull();
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(true, true)]
        public void CanMapAnAssetDbToAnAsset(bool nullStartDate, bool nullEndDate)
        {
            var databaseEntity = _fixture.Create<AssetDb>();

            if (nullStartDate) databaseEntity.Tenure.StartOfTenureDate = null;
            if (nullEndDate) databaseEntity.Tenure.EndOfTenureDate = null;

            var entity = databaseEntity.ToDomain();
            databaseEntity.Should().BeEquivalentTo(entity, config => config.Excluding(x => x.Tenure.IsActive));
        }

        [Fact]
        public void CanMapANullAssetToAnAssetDb()
        {
            AssetDomain entity = null;
            var databaseEntity = entity.ToDatabase();
            databaseEntity.Should().BeNull();
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(true, true)]
        public void CanMapAnAssetToAnAssetDb(bool nullStartDate, bool nullEndDate)
        {
            var entity = _fixture.Create<AssetDomain>();

            if (nullStartDate) entity.Tenure.StartOfTenureDate = null;
            if (nullEndDate) entity.Tenure.EndOfTenureDate = null;

            var databaseEntity = entity.ToDatabase();

            entity.Should().BeEquivalentTo(databaseEntity);
        }


        [Fact]
        public void CanMapANullAssetTenureDbToAnAssetTenure()
        {
            AssetTenureDb databaseEntity = null;
            var entity = databaseEntity.ToDomain();
            entity.Should().BeNull();
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(true, true)]
        public void CanMapAnAssetTenureDbToAnAssetTenure(bool nullStartDate, bool nullEndDate)
        {
            var databaseEntity = _fixture.Create<AssetTenureDb>();

            if (nullStartDate) databaseEntity.StartOfTenureDate = null;
            if (nullEndDate) databaseEntity.EndOfTenureDate = null;

            var entity = databaseEntity.ToDomain();
            databaseEntity.Should().BeEquivalentTo(entity, config => config.Excluding(x => x.IsActive));
        }

        [Fact]
        public void CanMapANullAssetTenureToAnAssetTenureDb()
        {
            AssetTenure entity = null;
            var databaseEntity = entity.ToDatabase();
            databaseEntity.Should().BeNull();
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void CanMapAnAssetTenureToAnAssetTenureDb(bool nullEndDate)
        {
            var entity = _fixture.Create<AssetTenure>();
            if (nullEndDate)
                entity.EndOfTenureDate = null;

            var databaseEntity = entity.ToDatabase();

            entity.Should().BeEquivalentTo(databaseEntity);
        }

        #region Asset Characteristics
        private void StrictAssertDatabaseToDomainAssetCharacteristicMapping(AssetCharacteristicsDb databaseAC, AssetCharacteristics domainAC)
        {
            domainAC.NumberOfBedrooms.Should().Be(databaseAC.NumberOfBedrooms);
            domainAC.NumberOfSingleBeds.Should().Be(databaseAC.NumberOfSingleBeds);
            domainAC.NumberOfDoubleBeds.Should().Be(databaseAC.NumberOfDoubleBeds);
            domainAC.NumberOfLifts.Should().Be(databaseAC.NumberOfLifts);
            domainAC.NumberOfLivingRooms.Should().Be(databaseAC.NumberOfLivingRooms);
            domainAC.WindowType.Should().Be(databaseAC.WindowType);
            domainAC.YearConstructed.Should().Be(databaseAC.YearConstructed);
            domainAC.AssetPropertyFolderLink.Should().Be(databaseAC.AssetPropertyFolderLink);
            domainAC.EpcExpiryDate.Should().Be(databaseAC.EpcExpiryDate);
            domainAC.FireSafetyCertificateExpiryDate.Should().Be(databaseAC.FireSafetyCertificateExpiryDate);
            domainAC.GasSafetyCertificateExpiryDate.Should().Be(databaseAC.GasSafetyCertificateExpiryDate);
            domainAC.ElecCertificateExpiryDate.Should().Be(databaseAC.ElecCertificateExpiryDate);
            domainAC.HasStairs.Should().Be(databaseAC.HasStairs);
            domainAC.NumberOfStairs.Should().Be(databaseAC.NumberOfStairs);
            domainAC.HasRampAccess.Should().Be(databaseAC.HasRampAccess);
            domainAC.HasCommunalAreas.Should().Be(databaseAC.HasCommunalAreas);
            domainAC.HasPrivateBathroom.Should().Be(databaseAC.HasPrivateBathroom);
            domainAC.NumberOfBathrooms.Should().Be(databaseAC.NumberOfBathrooms);
            domainAC.BathroomFloor.Should().Be(databaseAC.BathroomFloor);
            domainAC.HasPrivateKitchen.Should().Be(databaseAC.HasPrivateKitchen);
            domainAC.NumberOfKitchens.Should().Be(databaseAC.NumberOfKitchens);
            domainAC.Kitchenfloor.Should().Be(databaseAC.Kitchenfloor);
            domainAC.AlertSystemExpiryDate.Should().Be(databaseAC.AlertSystemExpiryDate);
            domainAC.EpcScore.Should().Be(databaseAC.EpcScore);
            domainAC.NumberOfFloors.Should().Be(databaseAC.NumberOfFloors);
            domainAC.Heating.Should().Be(databaseAC.Heating);
            domainAC.PropertyFactor.Should().Be(databaseAC.PropertyFactor);
            domainAC.ArchitecturalType.Should().Be(databaseAC.ArchitecturalType);
            domainAC.AccessibilityComments.Should().Be(databaseAC.AccessibilityComments);
            domainAC.NumberOfBedSpaces.Should().Be(databaseAC.NumberOfBedSpaces);
            domainAC.NumberOfCots.Should().Be(databaseAC.NumberOfCots);
            domainAC.SleepingArrangementNotes.Should().Be(databaseAC.SleepingArrangementNotes);
            domainAC.NumberOfShowers.Should().Be(databaseAC.NumberOfShowers);
            domainAC.KitchenNotes.Should().Be(databaseAC.KitchenNotes);
            domainAC.IsStepFree.Should().Be(databaseAC.IsStepFree);
            domainAC.BathroomNotes.Should().Be(databaseAC.BathroomNotes);
            domainAC.LivingRoomNotes.Should().Be(databaseAC.LivingRoomNotes);
        }

        // These assertions are the same now, but in general case they won't be (Calculated fields, Excluded fields, etc).
        private void StrictAssertDomainToDatabaseAssetCharacteristicMapping(AssetCharacteristics domainAC, AssetCharacteristicsDb databaseAC)
        {
            databaseAC.NumberOfBedrooms.Should().Be(domainAC.NumberOfBedrooms);
            databaseAC.NumberOfSingleBeds.Should().Be(domainAC.NumberOfSingleBeds);
            databaseAC.NumberOfDoubleBeds.Should().Be(domainAC.NumberOfDoubleBeds);
            databaseAC.NumberOfLifts.Should().Be(domainAC.NumberOfLifts);
            databaseAC.NumberOfLivingRooms.Should().Be(domainAC.NumberOfLivingRooms);
            databaseAC.WindowType.Should().Be(domainAC.WindowType);
            databaseAC.YearConstructed.Should().Be(domainAC.YearConstructed);
            databaseAC.AssetPropertyFolderLink.Should().Be(domainAC.AssetPropertyFolderLink);
            databaseAC.EpcExpiryDate.Should().Be(domainAC.EpcExpiryDate);
            databaseAC.FireSafetyCertificateExpiryDate.Should().Be(domainAC.FireSafetyCertificateExpiryDate);
            databaseAC.GasSafetyCertificateExpiryDate.Should().Be(domainAC.GasSafetyCertificateExpiryDate);
            databaseAC.ElecCertificateExpiryDate.Should().Be(domainAC.ElecCertificateExpiryDate);
            databaseAC.HasStairs.Should().Be(domainAC.HasStairs);
            databaseAC.NumberOfStairs.Should().Be(domainAC.NumberOfStairs);
            databaseAC.HasRampAccess.Should().Be(domainAC.HasRampAccess);
            databaseAC.HasCommunalAreas.Should().Be(domainAC.HasCommunalAreas);
            databaseAC.HasPrivateBathroom.Should().Be(domainAC.HasPrivateBathroom);
            databaseAC.NumberOfBathrooms.Should().Be(domainAC.NumberOfBathrooms);
            databaseAC.BathroomFloor.Should().Be(domainAC.BathroomFloor);
            databaseAC.HasPrivateKitchen.Should().Be(domainAC.HasPrivateKitchen);
            databaseAC.NumberOfKitchens.Should().Be(domainAC.NumberOfKitchens);
            databaseAC.Kitchenfloor.Should().Be(domainAC.Kitchenfloor);
            databaseAC.AlertSystemExpiryDate.Should().Be(domainAC.AlertSystemExpiryDate);
            databaseAC.EpcScore.Should().Be(domainAC.EpcScore);
            databaseAC.NumberOfFloors.Should().Be(domainAC.NumberOfFloors);
            databaseAC.Heating.Should().Be(domainAC.Heating);
            databaseAC.PropertyFactor.Should().Be(domainAC.PropertyFactor);
            databaseAC.ArchitecturalType.Should().Be(domainAC.ArchitecturalType);
            databaseAC.AccessibilityComments.Should().Be(domainAC.AccessibilityComments);
            databaseAC.NumberOfBedSpaces.Should().Be(domainAC.NumberOfBedSpaces);
            databaseAC.NumberOfCots.Should().Be(domainAC.NumberOfCots);
            databaseAC.SleepingArrangementNotes.Should().Be(domainAC.SleepingArrangementNotes);
            databaseAC.NumberOfShowers.Should().Be(domainAC.NumberOfShowers);
            databaseAC.KitchenNotes.Should().Be(domainAC.KitchenNotes);
            databaseAC.IsStepFree.Should().Be(domainAC.IsStepFree);
            databaseAC.BathroomNotes.Should().Be(domainAC.BathroomNotes);
            databaseAC.LivingRoomNotes.Should().Be(domainAC.LivingRoomNotes);
        }

        [Fact]
        public void AssetCharacteristicsMapsFromDatabaseToDomain()
        {
            // arrange
            var databaseAC = _fixture.Create<AssetCharacteristicsDb>();

            // act
            var domainAC = databaseAC.ToDomain();

            // assert
            StrictAssertDatabaseToDomainAssetCharacteristicMapping(databaseAC, domainAC);
        }

        [Fact]
        public void AssetCharacteristicsMapsFromDomainToDatabase()
        {
            // arrange
            var domainAC = _fixture.Create<AssetCharacteristics>();

            // act
            var databaseAC = domainAC.ToDatabase();

            // assert
            StrictAssertDomainToDatabaseAssetCharacteristicMapping(domainAC, databaseAC);
        }

        [Fact]
        public void GivenAssetCharacteristicsIsNullWhenMappedFromDomainToDatabaseLayersThenItStaysNull()
        {
            // arrange
            AssetCharacteristics domainAC = null;

            // act
            var databaseAC = domainAC.ToDatabase();

            // assert
            databaseAC.Should().BeNull();
        }

        [Fact]
        public void GivenAssetCharacteristicsIsNullWhenMappedFromDatabaseToDomainLayersThenItStaysNull()
        {
            // arrange
            AssetCharacteristicsDb databaseAC = null;

            // act
            var domainAC = databaseAC.ToDomain();

            // assert
            domainAC.Should().BeNull();
        }

        [Fact]
        public void AssetCharacteristicsFromDomainToDatabaseMappingIsTriggeredByTheParentAssetObjectMapping()
        {
            // arrange
            var domainAsset = _fixture.Create<AssetDomain>();
            var expectedDatabaseAC = domainAsset.AssetCharacteristics.ToDatabase();

            // act
            var databaseAsset = domainAsset.ToDatabase();

            // assert
            // Using 'BeEquivalent' here, but not before because here we're comparing 2 objects that are part of the same layer: Database.
            databaseAsset.AssetCharacteristics.Should().BeEquivalentTo(expectedDatabaseAC);
        }

        [Fact]
        public void AssetCharacteristicsFromDatabaseToDomainMappingIsTriggeredByTheParentAssetObjectMapping()
        {
            // arrange
            var databaseAsset = _fixture.Create<AssetDb>();
            var expectedDomainAC = databaseAsset.AssetCharacteristics.ToDomain();

            // act
            var domainAsset = databaseAsset.ToDomain();

            // assert
            // Using 'BeEquivalent' here, but not before because here we're comparing 2 objects that are part of the same layer: Domain.
            domainAsset.AssetCharacteristics.Should().BeEquivalentTo(expectedDomainAC);
        }
        #endregion
    }
}