using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Infrastructure.Helpers
{
    public static class SecurityHelper
    {
        public static string Hash(string password)
        => BCrypt.Net.BCrypt.HashPassword(password);

        public static bool Verify(string password, string hash)
            => BCrypt.Net.BCrypt.Verify(password, hash);

        public static string Encoding(string secret)
        {
            return secret;
        }

        public static string Decoding(string secret)
        {
            return secret;
        }
    }
}
