using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class PasswordValidator
    {
        public static void Validate(string password, ModelStateDictionary ModelState)
        {
            if (password == null)
            {
                ModelState.AddModelError("Password", "Password is empty.");
            }
            else if (password.Length > Constants.passwordLength)
            {
                ModelState.AddModelError("Password", "Password length greater than " + Constants.passwordLength);
            }
        }
    }
}
