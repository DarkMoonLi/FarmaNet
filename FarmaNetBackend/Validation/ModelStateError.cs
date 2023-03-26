using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class ModelStateError
    {
        public static string Errors(ModelStateDictionary ModelState)
        {
            string errorMessage = "";

            foreach (var item in ModelState)
            {
                if (item.Value.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    foreach (var error in item.Value.Errors)
                    {
                        errorMessage = $"{errorMessage}{error.ErrorMessage}\n";
                    }
                }
            }

            return errorMessage;
        }
    }
}
