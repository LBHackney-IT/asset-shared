using Hackney.Shared.Asset.Domain;
using Hackney.Shared.Asset.Factories;
using AutoFixture;
using FluentAssertions;
using Xunit;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;

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
    }
}