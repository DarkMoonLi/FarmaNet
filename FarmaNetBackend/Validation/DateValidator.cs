using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace FarmaNetBackend.Validation
{
    public class DateValidator
    {
        public static void Validate(DateTime date, ModelStateDictionary ModelState)
        {
            if (date < new DateTime(1900, 1, 1) || date > new DateTime(2999, 12, 31, 23, 59, 59))
            {
                ModelState.AddModelError("Date", "Date is incorrect.");
            }
        }
    }
}
