using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class EmailSample
    {
        public static string Regex_Email = "^[a-z][a-z0-9]{2}([-.+]{1}[a-z0-9]{3})?[@][a-z0-9]{1,}[.][a-z]{3}([.][a-z]{2,3})?$";

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }

    }
}
