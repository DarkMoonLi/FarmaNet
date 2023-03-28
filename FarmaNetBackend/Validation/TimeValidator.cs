using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace FarmaNetBackend.Validation
{
    public class TimeValidator
    {
        public static void Validate(TimeSpan time, ModelStateDictionary ModelState)
        {
            if (time.Hours < 0)
            {
                ModelState.AddModelError("Time", "The time cannot be less than 0 hours");
            }
            if (time.Hours > 24)
            {
                ModelState.AddModelError("Time", "The time cannot be more than 24 hours");
            }
        }
    }
}
