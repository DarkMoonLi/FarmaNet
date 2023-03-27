using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class SumValidator
    {
        public static void Validate(double? sum, ModelStateDictionary ModelState)
        {
            if (sum < 0)
            {
                ModelState.AddModelError("Price", "Price must be qreater than or equal to 0.");
            }
        }
    }
}
