using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Newtonsoft.Json;

namespace Hackney.Shared.Asset.Tests.Domain
{
    public class AssetTests
    {
        private Asset.Domain.Asset _sut;

        public AssetTests()
        {

        }

        [Fact]
        public void GivenValidJsonWithNewBuild_DeserialisesCorrectly()
        {
            var json = "{ \"id\": \"1f77d06c-50e4-b3a1-64c8-f4d38f9d2757\", \"assetId\": \"00090442\", \"assetType\": \"Dwelling\", \"isAssetCautionaryAlerted\": false, \"assetAddress\": { \"uprn\": \"10008355637\", \"addressLine1\": \"61 Peregrine Court\", \"addressLine2\": \"Clapton Common\", \"addressLine3\": \"London\", \"addressLine4\": \"\", \"postCode\": \"E5 9AN\", \"postPreamble\": \"\" }, \"tenure\": { \"id\": \"\", \"paymentReference\": \"\", \"startOfTenureDate\": \"\", \"endOfTenureDate\": \"\", \"type\": \"\", \"isActive\": true }, \"rootAsset\": null, \"isActive\": false, \"parentAssetIds\": null, \"assetCharacteristics\": null, \"assetManagement\": null, \"assetStatus\": null, \"assetLocation\": null }";

            _sut = JsonConvert.DeserializeObject<Asset.Domain.Asset>(json);
        }

        [Fact]
        public void GivenValidJsonWithNewBuild_DeserialisesCorrectly_WithNamedMember()
        {
            var json = "{ \"id\": \"1f77d06c-50e4-b3a1-64c8-f4d38f9d2757\", \"assetId\": \"00090442\", \"assetType\": \"New build\", \"isAssetCautionaryAlerted\": false, \"assetAddress\": { \"uprn\": \"10008355637\", \"addressLine1\": \"61 Peregrine Court\", \"addressLine2\": \"Clapton Common\", \"addressLine3\": \"London\", \"addressLine4\": \"\", \"postCode\": \"E5 9AN\", \"postPreamble\": \"\" }, \"tenure\": { \"id\": \"\", \"paymentReference\": \"\", \"startOfTenureDate\": \"\", \"endOfTenureDate\": \"\", \"type\": \"\", \"isActive\": true }, \"rootAsset\": null, \"isActive\": false, \"parentAssetIds\": null, \"assetCharacteristics\": null, \"assetManagement\": null, \"assetStatus\": null, \"assetLocation\": null }";

            _sut = JsonConvert.DeserializeObject<Asset.Domain.Asset>(json);
        }
    }
}
