using FarmaNetBackend.Dto.ManufacturerDto;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class AddressValidator
    {
        public static void Validate(string address, ModelStateDictionary ModelState)
        {
            if(address.Length > Constants.addressLength)
            {
                ModelState.AddModelError("Address", "Address length more than " + Constants.addressLength);
            }
        }
    }
}
