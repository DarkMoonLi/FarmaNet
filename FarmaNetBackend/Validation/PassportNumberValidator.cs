using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class PassportNumberValidator
    {
        public static void Validate(int? number, ModelStateDictionary ModelState)
        {
            if (number > 999999)
            {
                ModelState.AddModelError("PassportNumber", "Passport number is incorrect");
            }
        }
    }
}
