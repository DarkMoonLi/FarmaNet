using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class QuantityValidator
    {
        public static void Validate(int quantity, ModelStateDictionary ModelState)
        {
            if (quantity == 0)
            {
                ModelState.AddModelError("Quantity", "Quantity is 0");
            }
        }
    }
}
