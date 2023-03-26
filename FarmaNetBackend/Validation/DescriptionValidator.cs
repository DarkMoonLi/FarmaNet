using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class DescriptionValidator
    {
        public static void Validate(string description, ModelStateDictionary ModelState)
        {
            if (description != null && description.Length > Constants.descriptionLength)
            {
                ModelState.AddModelError("Description", "Description length more than " + Constants.descriptionLength);
            }
        }
    }
}
