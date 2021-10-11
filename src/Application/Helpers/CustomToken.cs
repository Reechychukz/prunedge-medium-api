using System;

namespace Application.Helpers
{
    public class CustomToken
    {
        public static string GenerateToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }
        public static string GenerateOtp()
        {
            Random rnd = new Random();
            var randomNumber = (rnd.Next(100000, 999999)).ToString();
            return randomNumber;
        }
    }
}
