using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class PasswordRule2
    {
        public static string Regex_Password = "(?=.*[A-Z])(?=.[0-9a-z]{7,})";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
