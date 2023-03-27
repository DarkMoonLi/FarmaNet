using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class ExperienceValidator
    {
        public static void Validate(float? experience, ModelStateDictionary ModelState)
        {
            if (experience < 0 || experience > 100)
            {
                ModelState.AddModelError("Experience", "Experience is incorrect.");
            }
        }
    }
}
