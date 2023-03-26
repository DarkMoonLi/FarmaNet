using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class ImagePathValidator
    {
        public static void Validate(string path, ModelStateDictionary ModelState)
        {
            if (path == null)
            {
                ModelState.AddModelError("Path", "Path is empty");
            }
            else if (path.Length > Constants.imagePathLength)
            {
                ModelState.AddModelError("Path", "Path length more than " + Constants.imagePathLength);
            }
        }
    }
}
