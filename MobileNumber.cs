using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class MobileNumber
    {

        public static string Regex_MobileNumber = "^[1-9][0-9][ ]?[6-9][0-9]{9}$";

        public bool validateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, Regex_MobileNumber);
        }
    }
    
}
