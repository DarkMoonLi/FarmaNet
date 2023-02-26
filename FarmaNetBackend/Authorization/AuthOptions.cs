using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace FarmaNetBackend.Authorization
{
    public class AuthOptions
    {
        public const string ISSUER = "FarmaNetServer"; // издатель токена
        public const string AUDIENCE = "FarmaNetClient"; // потребитель токена
        const string KEY = "ghGhft%465ff^ghhgGtfd6edfg&65rd";   // ключ для шифрации
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
