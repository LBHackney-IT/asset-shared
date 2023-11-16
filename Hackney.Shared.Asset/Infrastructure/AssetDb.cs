
using Amazon.DynamoDBv2.DataModel;
using Hackney.Shared.Asset.Domain;
using Hackney.Core.DynamoDb.Converters;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.Asset.Infrastructure
{
    [DynamoDBTable("Assets", LowerCamelCaseProperties = true)]
    public class AssetDb
    {
        [DynamoDBHashKey]
        public Guid Id { get; set; }

        [DynamoDBProperty]
        public string AssetId { get; set; }

        [DynamoDBProperty]
        public Guid? AreaId { get; set; }

        [DynamoDBProperty]
        public Guid? PatchId { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbEnumConverter<AssetType>))]
        public AssetType AssetType { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbEnumConverter<RentGroup>))]
        public RentGroup? RentGroup { get; set; }

        [DynamoDBProperty]
        public string RootAsset { get; set; }

        [DynamoDBProperty]
        public bool IsActive { get; set; }

        [DynamoDBProperty]
        public string ParentAssetIds { get; set; }

        [DynamoDBProperty]
        public string BoilerHouseId { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbObjectConverter<AssetLocation>))]
        public AssetLocation AssetLocation { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbObjectConverter<AssetAddress>))]
        public AssetAddress AssetAddress { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbObjectConverter<AssetManagement>))]
        public AssetManagement AssetManagement { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbObjectConverter<AssetCharacteristicsDb>))]
        public AssetCharacteristicsDb AssetCharacteristics { get; set; }

        [DynamoDBProperty(Converter = typeof(DynamoDbObjectConverter<AssetTenureDb>))]
        public AssetTenureDb Tenure { get; set; }

        [DynamoDBVersion]
        public int? VersionNumber { get; set; }
    }
}