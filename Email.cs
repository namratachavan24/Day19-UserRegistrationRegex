﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Email
    {
        public static string Regex_Email = "^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}([.][A-Za-z]{2})?$";

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
