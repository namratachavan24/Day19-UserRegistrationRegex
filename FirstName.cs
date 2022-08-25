using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class FirstName
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";

        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }

    }
}
