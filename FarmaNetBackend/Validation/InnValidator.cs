using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class InnValidator
    {
        public static void Validate(string inn, ModelStateDictionary ModelState)
        {
            if (inn == null)
            {
                ModelState.AddModelError("Inn", "Inn is empty.");
            }
            else if (inn.Length > Constants.innLength)
            {
                ModelState.AddModelError("Inn", "Inn length greater than " + Constants.innLength);
            }
        }
    }
}
