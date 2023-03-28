using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class LoginValidator
    {
        public static void Validate(string login, ModelStateDictionary ModelState)
        {
            if (login == null)
            {
                ModelState.AddModelError("Login", "Login is empty");
            }
            else if (login.Length > Constants.loginLength)
            {
                ModelState.AddModelError("Login", "Login length is greater than " + Constants.loginLength);
            }
        }
    }
}
