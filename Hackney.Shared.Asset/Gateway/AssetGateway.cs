using Hackney.Shared.Asset.Gateway.Interfaces;
using System;
using System.Threading.Tasks;
using Hackney.Core.Logging;
using AssetDomain = Hackney.Shared.Asset.Domain.Asset;
using Amazon.DynamoDBv2.DataModel;
using Hackney.Shared.Asset.Infrastructure;
using Hackney.Shared.Asset.Factories;
using Microsoft.Extensions.Logging;

namespace Hackney.Shared.Asset.Gateway
{
    public class AssetGateway : IAssetGateway
    {
        private readonly IDynamoDBContext _dynamoDbContext;
        private readonly ILogger<AssetGateway> _logger;

        public AssetGateway(IDynamoDBContext dynamoDbContext, ILogger<AssetGateway> logger)
        {
            _logger = logger;
            _dynamoDbContext = dynamoDbContext;
        }

        [LogCall]
        public async Task<AssetDomain> GetAssetByIdAsync(Guid id)
        {
            _logger.LogDebug($"Calling IDynamoDBContext.LoadAsync for id {id}");
            var dbEntity = await _dynamoDbContext.LoadAsync<AssetDb>(id).ConfigureAwait(false);
            return dbEntity?.ToDomain();
        }

        [LogCall]
        public async Task SaveAssetAsync(AssetDomain entity)
        {
            _logger.LogDebug($"Calling IDynamoDBContext.SaveAsync for id {entity.Id}");
            await _dynamoDbContext.SaveAsync(entity.ToDatabase()).ConfigureAwait(false);
        }
    }
}
