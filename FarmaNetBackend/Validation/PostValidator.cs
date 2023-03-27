using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FarmaNetBackend.Validation
{
    public class PostValidator
    {
        public static void Validate(string post, ModelStateDictionary ModelState)
        {
            if (post == null)
            {
                ModelState.AddModelError("Post", "Post is empty.");
            }
            else if (post.Length > Constants.positionLength)
            {
                ModelState.AddModelError("Post", "Post length is greater than " + Constants.positionLength);
            }
        }
    }
}
