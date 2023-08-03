using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Hackney.Core.Validation;

namespace Hackney.Shared.Asset.Boundary.Request.Validation
{
    public class EditAssetAddressRequestValidator : AbstractValidator<EditAssetAddressRequest>
    {
        public EditAssetAddressRequestValidator()
        {
            RuleFor(x => x.AssetAddress).NotNull()
                                        .NotEmpty()
                                        .WithErrorCode(ErrorCodes.AssetAddressEmptyOrInvalid);

            RuleFor(x => x.AssetAddress).NotXssString()
                                        .WithErrorCode(ErrorCodes.XssFailure);

            RuleFor(x => x.AssetAddress.Uprn).NotXssString()
                                             .WithErrorCode(ErrorCodes.XssFailure);

            RuleFor(x => x.AssetAddress.AddressLine1).NotNull()
                                                     .NotEmpty()
                                                     .WithErrorCode(ErrorCodes.AssetAddressLine1EmptyOrInvalid);

            RuleFor(x => x.AssetAddress.AddressLine1).NotXssString()
                                                     .WithErrorCode(ErrorCodes.XssFailure);

            RuleFor(x => x.AssetAddress.AddressLine2).NotXssString()
                                         .WithErrorCode(ErrorCodes.XssFailure);
            RuleFor(x => x.AssetAddress.AddressLine3).NotXssString()
                                         .WithErrorCode(ErrorCodes.XssFailure);
            RuleFor(x => x.AssetAddress.AddressLine4).NotXssString()
                                         .WithErrorCode(ErrorCodes.XssFailure);

            RuleFor(x => x.AssetAddress.PostCode).NotNull()
                                                 .NotEmpty()
                                                 .WithErrorCode(ErrorCodes.AssetAddressPostcodeEmptyOrInvalid);

            RuleFor(x => x.AssetAddress.PostCode).NotXssString()
                                                 .WithErrorCode(ErrorCodes.XssFailure);
        }
    }
}
