using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.Asset.Boundary.Request.Validation
{
    public static class ErrorCodes
    {
        public const string AssetAddressEmptyOrInvalid = "AD1";
        public const string AssetAddressLine1EmptyOrInvalid = "AD2";
        public const string AssetAddressUprnEmptyOrInvalid = "AD3";
        public const string AssetAddressPostcodeEmptyOrInvalid = "AD4";
        public const string XssFailure = "W42";
    }
}
