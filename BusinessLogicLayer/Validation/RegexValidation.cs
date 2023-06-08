using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Enum
{
    public static class RegexValidation
    {

        public const string Name = "^[\\p{L}\\s]+$|[\\u0600-\\u06FF\\p{L}\\s]+$";
        public const string Address = "^[\\p{L}\\d\\s]+$|[\\u0600-\\u06FF\\p{L}\\d\\s]+$";
        public const string NationalCode = "^[0-9]{10}$";
        public const string UserName = "^[a-zA-Z0-9_-]{3,16}$";
        public const string Password = "^(?=.*[a-zA-Z0-9@])(?=.*[a-zA-Z ])[a-zA-Z0-9@ ]{8,}$";

        public static bool CheckRegex(string pattern, string target)
        {
            Regex rg = null;
            switch (pattern)
            {
                case "Name":
                    rg = new Regex(Name);
                    break;
                case "Address":
                    rg = new Regex(Address);
                    break;
                case "NationalCode":
                    rg = new Regex(NationalCode);
                    break;
                case "UserName":
                    rg = new Regex(UserName);
                    break;
                case "PassWord":
                    rg = new Regex(Password);
                    break;

            }

            if (rg != null)
                return rg.IsMatch(target);
            else
                return false;
        }
    }

}
