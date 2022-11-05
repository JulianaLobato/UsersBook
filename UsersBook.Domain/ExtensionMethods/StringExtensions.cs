using System.Text.RegularExpressions;

namespace UsersBook.Domain.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsValid(this string email)
        {
            return Regex.IsMatch(email, @"(.+?)(?:@(.+?))(?:\.(.+))", RegexOptions.IgnoreCase);
        }
    }
}
