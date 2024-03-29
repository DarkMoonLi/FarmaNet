﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class PassportSeriesValidator
    {
        public static void Validate(int? series, ModelStateDictionary ModelState)
        {
            if (series > 9999)
            {
                ModelState.AddModelError("PassportSeries", "Passport series is incorrect");
            }
        }
    }
}
