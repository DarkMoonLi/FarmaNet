using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class NumberValidator
    {
        public static void Validate(int number, ModelStateDictionary ModelState)
        {
            if (number <= 0)
            {
                ModelState.AddModelError("Number", "Number must be greater than 0");
            }
        }
    }
}
