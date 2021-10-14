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
    }
}