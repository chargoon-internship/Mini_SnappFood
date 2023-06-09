using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Invoice
{
    public static class Converter
    {
        public static string ToShamsi(this DateTime time)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(time) + "/" + persianCalendar.GetMonth(time) + "/" + persianCalendar.GetDayOfMonth(time);
        }
    }
}
