using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Hackney.Core.Validation;

namespace Hackney.Shared.Asset.Boundary.Request.Validation
{
    public class EditPropertyPatchRequestValidator : AbstractValidator<EditPropertyPatchRequest>
    {
        public EditPropertyPatchRequestValidator()
        {
            RuleFor(x => x.AreaId).NotNull()
                                  .NotEqual(Guid.Empty);
            
            RuleFor(x => x.PatchId).NotNull()
                                  .NotEqual(Guid.Empty);
        }
    }
}
