using System.Security.Cryptography;
using System.Text;

public static class SeguridadHelper
{
    public static byte[] GenerarHash(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}