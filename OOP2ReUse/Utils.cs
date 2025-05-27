using OOPDemo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2ReUse
{
    public static class Utils
    {
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.BirthDate.Year + 1;
        }
    }
}
