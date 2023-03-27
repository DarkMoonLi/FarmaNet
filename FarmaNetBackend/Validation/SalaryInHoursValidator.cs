using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class SalaryInHoursValidator
    {
        public static void Validate(float? salary, ModelStateDictionary ModelState)
        {
            if (salary <= 0)
            {
                ModelState.AddModelError("Salary", "The salary must be greater than 0.");
            }
        }
    }
}
