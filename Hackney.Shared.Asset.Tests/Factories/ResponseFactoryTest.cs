using Hackney.Shared.Asset.Domain;
using Hackney.Shared.Asset.Factories;
using AutoFixture;
using FluentAssertions;
using Xunit;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;
using Hackney.Shared.Asset.Boundary.Response;

namespace Hackney.Shared.Asset.Tests.Factories
{
    public class ResponseFactoryTest
    {
        private readonly Fixture _fixture = new Fixture();

        [Fact]
        public void CanMapANullAssetToAResponseObject()
        {
            AssetDomain domain = null;
            var response = domain.ToResponse();

            response.Should().BeNull();
        }

        [Fact]
        public void CanMapAnAssetToAResponseObject()
        {
            var domain = _fixture.Create<AssetDomain>();
            var response = domain.ToResponse();
            domain.Should().BeEquivalentTo(response);
        }

        [Fact]
        public void CanMapANullAssetTenureToAResponseObject()
        {
            AssetTenure domain = null;
            var response = domain.ToResponse();

            response.Should().BeNull();
        }

        [Fact]
        public void CanMapAnAssetTenureToAResponseObject()
        {
            var domain = _fixture.Create<AssetTenure>();
            var response = domain.ToResponse();
            domain.Should().BeEquivalentTo(response);
        }

        #region Asset Characteristics
        private void StrictAssertDomainToPresentationAssetCharacteristicsMapping(AssetCharacteristics domainAC, AssetCharacteristicsResponse presentationAC)
        {
            presentationAC.NumberOfBedrooms.Should().Be(domainAC.NumberOfBedrooms);
            presentationAC.NumberOfSingleBeds.Should().Be(domainAC.NumberOfSingleBeds);
            presentationAC.NumberOfDoubleBeds.Should().Be(domainAC.NumberOfDoubleBeds);
            presentationAC.NumberOfLifts.Should().Be(domainAC.NumberOfLifts);
            presentationAC.NumberOfLivingRooms.Should().Be(domainAC.NumberOfLivingRooms);
            presentationAC.WindowType.Should().Be(domainAC.WindowType);
            presentationAC.YearConstructed.Should().Be(domainAC.YearConstructed);
            presentationAC.AssetPropertyFolderLink.Should().Be(domainAC.AssetPropertyFolderLink);
            presentationAC.EpcExpiryDate.Should().Be(domainAC.EpcExpiryDate);
            presentationAC.FireSafetyCertificateExpiryDate.Should().Be(domainAC.FireSafetyCertificateExpiryDate);
            presentationAC.GasSafetyCertificateExpiryDate.Should().Be(domainAC.GasSafetyCertificateExpiryDate);
            presentationAC.ElecCertificateExpiryDate.Should().Be(domainAC.ElecCertificateExpiryDate);
            presentationAC.HasStairs.Should().Be(domainAC.HasStairs);
            presentationAC.NumberOfStairs.Should().Be(domainAC.NumberOfStairs);
            presentationAC.HasRampAccess.Should().Be(domainAC.HasRampAccess);
            presentationAC.HasCommunalAreas.Should().Be(domainAC.HasCommunalAreas);
            presentationAC.HasPrivateBathroom.Should().Be(domainAC.HasPrivateBathroom);
            presentationAC.NumberOfBathrooms.Should().Be(domainAC.NumberOfBathrooms);
            presentationAC.BathroomFloor.Should().Be(domainAC.BathroomFloor);
            presentationAC.HasPrivateKitchen.Should().Be(domainAC.HasPrivateKitchen);
            presentationAC.NumberOfKitchens.Should().Be(domainAC.NumberOfKitchens);
            presentationAC.Kitchenfloor.Should().Be(domainAC.Kitchenfloor);
            presentationAC.AlertSystemExpiryDate.Should().Be(domainAC.AlertSystemExpiryDate);
            presentationAC.EpcScore.Should().Be(domainAC.EpcScore);
            presentationAC.NumberOfFloors.Should().Be(domainAC.NumberOfFloors);
            presentationAC.Heating.Should().Be(domainAC.Heating);
            presentationAC.PropertyFactor.Should().Be(domainAC.PropertyFactor);
            presentationAC.ArchitecturalType.Should().Be(domainAC.ArchitecturalType);
            presentationAC.AccessibilityComments.Should().Be(domainAC.AccessibilityComments);
            presentationAC.NumberOfBedSpaces.Should().Be(domainAC.NumberOfBedSpaces);
            presentationAC.NumberOfCots.Should().Be(domainAC.NumberOfCots);
            presentationAC.SleepingArrangementNotes.Should().Be(domainAC.SleepingArrangementNotes);
            presentationAC.NumberOfShowers.Should().Be(domainAC.NumberOfShowers);
            presentationAC.KitchenNotes.Should().Be(domainAC.KitchenNotes);
            presentationAC.IsStepFree.Should().Be(domainAC.IsStepFree);
            presentationAC.BathroomNotes.Should().Be(domainAC.BathroomNotes);
            presentationAC.LivingRoomNotes.Should().Be(domainAC.LivingRoomNotes);
        }

        [Fact]
        public void AssetCharacteristicsMapsFromDomainToDatabase()
        {
            // arrange
            var domainAC = _fixture.Create<AssetCharacteristics>();

            // act
            var presentationAC = domainAC.ToResponse();

            // assert
            StrictAssertDomainToPresentationAssetCharacteristicsMapping(domainAC, presentationAC);
        }

        [Fact]
        public void GivenAssetCharacteristicsIsNullWhenMappedFromDomainToPresentationThenItStaysNull()
        {
            // arrange
            AssetCharacteristics domainAC = null;

            // act
            var presentationAC = domainAC.ToResponse();

            // assert
            presentationAC.Should().BeNull();
        }

        [Fact]
        public void AssetCharacteristicsFromDomainToDatabaseMappingIsTriggeredByTheParentAssetObjectMapping()
        {
            // arrange
            var domainAsset = _fixture.Create<AssetDomain>();
            var expectedPresentationC = domainAsset.AssetCharacteristics.ToResponse();

            // act
            var presentationAsset = domainAsset.ToResponse();

            // assert
            // Using 'BeEquivalent' here, but not before because here we're comparing 2 objects that are part of the same layer: Presentation.
            presentationAsset.AssetCharacteristics.Should().BeEquivalentTo(expectedPresentationC);
        }
        #endregion
    }
}