using FarmaNetBackend.Dto.ManufacturerDto;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class NameValidator
    {
        public static void Validate(string name, ModelStateDictionary ModelState)
        {
            if (name == null)
            {
                ModelState.AddModelError("Name", "Name is empty");
            }
            else if (name.Length == 0 || name.Length > Constants.nameLength)
            {
                ModelState.AddModelError("Name", "Name length is equal 0 or more than " + Constants.nameLength);
            }
        }
    }
}
