using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace FarmaNetBackend.Validation
{
    public class DateValidator
    {
        public void Validate(DateTime date, ModelStateDictionary ModelState)
        {
            if (date >= new DateTime())
            { }
        }
    }
}
