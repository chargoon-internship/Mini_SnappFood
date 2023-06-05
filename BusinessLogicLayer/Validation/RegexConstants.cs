using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Enum
{
    public static class RegexConstants
    {

        public const string PatternName = "^[a-zA-Z]*$";
        public const string Address = @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$"; // "124 street" or "hemmat 22";
        public const string NationalCode = "^[0-9]{10}$";

    }
}
