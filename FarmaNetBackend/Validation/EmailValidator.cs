using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class EmailValidator
    {
        public static void Validate(string email, ModelStateDictionary ModelState)
        {
            if (email == null)
            {
                ModelState.AddModelError("Email", "Email is empty");
            }
            else if (email.Length > Constants.emailLength)
            {
                ModelState.AddModelError("Email", "Email length more than " + Constants.emailLength);
            }
        }
    }
}
