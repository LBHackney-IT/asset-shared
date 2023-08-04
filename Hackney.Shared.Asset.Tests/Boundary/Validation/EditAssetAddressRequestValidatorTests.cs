using AutoFixture;
using FluentValidation.TestHelper;
using Hackney.Shared.Asset.Boundary.Request;
using Hackney.Shared.Asset.Boundary.Request.Validation;
using Hackney.Shared.Asset.Domain;
using System;
using System.Linq;
using Xunit;

namespace Hackney.Shared.Asset.Tests.Boundary.Validation
{
    public class EditAssetAddressRequestValidatorTests
    {
        private readonly EditAssetAddressRequestValidator _sut;
        private readonly Fixture _fixture = new Fixture();

        public EditAssetAddressRequestValidatorTests()
        {
            _sut = new EditAssetAddressRequestValidator();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AddressLine1ShouldErrorWithNoValue(string value)
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine1 = value;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.AddressLine1)
                .WithErrorCode(ErrorCodes.AssetAddressLine1EmptyOrInvalid);
        }

        [Fact]
        public void AddressLine1ShouldErrorWithXssTags()
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine1 = StringWithTags;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.AddressLine1)
                .WithErrorCode(ErrorCodes.XssFailure);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AddressLine2ShouldNotErrorWithNoValue(string value)
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine2 = value;

            var result = _sut.TestValidate(request);
            result.ShouldNotHaveValidationErrorFor(x => x.AssetAddress.AddressLine2);
        }

        [Fact]
        public void AddressLine2ShouldErrorWithXssTags()
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine2 = StringWithTags;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.AddressLine2)
                .WithErrorCode(ErrorCodes.XssFailure);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AddressLine3ShouldNotErrorWithNoValue(string value)
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine3 = value;

            var result = _sut.TestValidate(request);
            result.ShouldNotHaveValidationErrorFor(x => x.AssetAddress.AddressLine3);
        }

        [Fact]
        public void AddressLine3ShouldErrorWithXssTags()
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine3 = StringWithTags;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.AddressLine3)
                .WithErrorCode(ErrorCodes.XssFailure);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AddressLine4ShouldNotErrorWithNoValue(string value)
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine4 = value;

            var result = _sut.TestValidate(request);
            result.ShouldNotHaveValidationErrorFor(x => x.AssetAddress.AddressLine4);
        }

        [Fact]
        public void AddressLine4ShouldErrorWithXssTags()
        {
            var request = CreateValidRequest();
            request.AssetAddress.AddressLine4 = StringWithTags;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.AddressLine4)
                .WithErrorCode(ErrorCodes.XssFailure);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void PostCodeShouldErrorWithNoValue(string value)
        {
            var request = CreateValidRequest();
            request.AssetAddress.PostCode = value;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.PostCode)
                .WithErrorCode(ErrorCodes.AssetAddressPostcodeEmptyOrInvalid);
        }

        [Fact]
        public void PostCodeShouldErrorWithXssTags()
        {
            var request = CreateValidRequest();
            request.AssetAddress.PostCode = StringWithTags;

            var result = _sut.TestValidate(request);
            result.ShouldHaveValidationErrorFor(x => x.AssetAddress.PostCode)
                .WithErrorCode(ErrorCodes.XssFailure);
        }


        private EditAssetAddressRequest CreateValidRequest()
        {
            return new EditAssetAddressRequest()
            {
                AssetAddress = _fixture.Create<AssetAddress>()
            };
        }

        private const string StringWithTags = "Some string with <tag> in it <script src='http://bad-actor.net/hijack.js'>.";
    }
}
