using System.Security.Cryptography;
using System.Text;
using System;

namespace GravatarPK;
public static class GravatarExtension
{
    public static string ToGravatarPK(this string email, int size = 80)
    {
        if (string.IsNullOrEmpty(email))
            return string.Empty;

        using var md5 = MD5.Create();
        var inputBytes = Encoding.ASCII.GetBytes(email);
        var hashBytes = md5.ComputeHash(inputBytes);


        var sb = new StringBuilder();
        foreach (var t in hashBytes)
            sb.Append(t.ToString("X2"));

         return $"https://www.gravatar.com/avatar/{sb.ToString().ToLower()}";   

    }
}
