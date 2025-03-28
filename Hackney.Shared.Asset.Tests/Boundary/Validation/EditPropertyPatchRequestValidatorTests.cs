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
    public class EditPropertyPatchRequestValidatorTests
    {
        private readonly EditPropertyPatchRequestValidator _sut;

        public EditPropertyPatchRequestValidatorTests()
        {
            _sut = new EditPropertyPatchRequestValidator();
        }

        [Fact]
        public void RequestShouldErrorWithNullAreaId()
        {
            var query = new EditPropertyPatchRequest();
            var result = _sut.TestValidate(query);
            result.ShouldHaveValidationErrorFor(x => x.AreaId);
        }

        [Fact]
        public void RequestShouldErrorWithEmptyAreaId()
        {
            var query = new EditPropertyPatchRequest() { AreaId = Guid.Empty };
            var result = _sut.TestValidate(query);
            result.ShouldHaveValidationErrorFor(x => x.AreaId);
        }

        [Fact]
        public void RequestShouldErrorWithNullPatchId()
        {
            var query = new EditPropertyPatchRequest();
            var result = _sut.TestValidate(query);
            result.ShouldHaveValidationErrorFor(x => x.PatchId);
        }

        [Fact]
        public void RequestShouldErrorWithEmptyPatchId()
        {
            var query = new EditPropertyPatchRequest() { PatchId = Guid.Empty };
            var result = _sut.TestValidate(query);
            result.ShouldHaveValidationErrorFor(x => x.PatchId);
        }
    }
}