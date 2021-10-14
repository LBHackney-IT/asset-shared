using Amazon.DynamoDBv2.DataModel;
using AutoFixture;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Hackney.Shared.Asset.Domain;
using Hackney.Shared.Asset.Factories;
using Hackney.Shared.Asset.Gateway;
using Hackney.Shared.Asset.Infrastructure;
using System.Text;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;

namespace Hackney.Shared.Asset.Tests.Gateway
{
    [Collection("Aws collection")]

    public class AssetGatewayTests : IDisposable
    {
        private readonly Fixture _fixture = new Fixture();
        private readonly Mock<ILogger<AssetGateway>> _logger;
        private readonly AssetGateway _classUnderTest;
        private AwsIntegrationTests _dbTestFixture;
        private IDynamoDBContext DynamoDb => _dbTestFixture.DynamoDbContext;
        private readonly List<Action> _cleanup = new List<Action>();

        public AssetGatewayTests(AwsIntegrationTests dbTestFixture)
        {
            _dbTestFixture = dbTestFixture;
            _logger = new Mock<ILogger<AssetGateway>>();
            _classUnderTest = new AssetGateway(DynamoDb, _logger.Object);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                foreach (var action in _cleanup)
                    action();

                if (_dbTestFixture != null)
                {
                    _dbTestFixture.Dispose();
                    _dbTestFixture = null;
                }

                _disposed = true;
            }
        }

        private async Task InsertDatatoDynamoDB(AssetDomain entity)
        {
            await DynamoDb.SaveAsync(entity.ToDatabase()).ConfigureAwait(false);
            _cleanup.Add(async () => await DynamoDb.DeleteAsync<AssetDb>(entity.Id).ConfigureAwait(false));
        }

        private AssetDomain ConstructAsset()
        {
            var entity = _fixture.Build<AssetDomain>()
                                 .With(x => x.VersionNumber, (int?)null)
                                 .Create();
            return entity;
        }

        [Fact]
        public async Task GetAssetByIdAsyncTestReturnsRecord()
        {
            var domainEntity = ConstructAsset();
            await InsertDatatoDynamoDB(domainEntity).ConfigureAwait(false);

            var result = await _classUnderTest.GetAssetByIdAsync(domainEntity.Id).ConfigureAwait(false);

            result.Should().BeEquivalentTo(domainEntity, (e) => e.Excluding(y => y.VersionNumber));
            result.VersionNumber.Should().Be(0);

            _logger.VerifyExact(LogLevel.Debug, $"Calling IDynamoDBContext.LoadAsync for id {domainEntity.Id}", Times.Once());
        }

        [Fact]
        public async Task GetAssetByIdAsyncTestReturnsNullWhenNotFound()
        {
            var id = Guid.NewGuid();
            var result = await _classUnderTest.GetAssetByIdAsync(id).ConfigureAwait(false);

            result.Should().BeNull();

            _logger.VerifyExact(LogLevel.Debug, $"Calling IDynamoDBContext.LoadAsync for id {id}", Times.Once());
        }

        [Fact]
        public async Task SaveAssetAsyncTestUpdatesDatabase()
        {
            var domainEntity = ConstructAsset();
            await InsertDatatoDynamoDB(domainEntity).ConfigureAwait(false);

            domainEntity.RootAsset = Guid.NewGuid().ToString();
            domainEntity.Tenure = _fixture.Create<AssetTenure>();
            domainEntity.AssetAddress = _fixture.Create<AssetAddress>();
            domainEntity.VersionNumber = 0;
            await _classUnderTest.SaveAssetAsync(domainEntity).ConfigureAwait(false);

            var updatedInDB = await DynamoDb.LoadAsync<AssetDb>(domainEntity.Id).ConfigureAwait(false);
            updatedInDB.ToDomain().Should().BeEquivalentTo(domainEntity, (e) => e.Excluding(y => y.VersionNumber));
            updatedInDB.VersionNumber.Should().Be(domainEntity.VersionNumber + 1);

            _logger.VerifyExact(LogLevel.Debug, $"Calling IDynamoDBContext.SaveAsync for id {domainEntity.Id}", Times.Once());
        }
    }
}
