using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2
{
    public class PartimeEmployee : Employee
    {
        public int WorkingHours { get; set; }
        public override double TinhLuong()
        {
            return 100000 * WorkingHours;
        }
    }
}
