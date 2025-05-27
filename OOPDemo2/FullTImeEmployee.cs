using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2
{
    public class FullTImeEmployee : Employee
    {
        public override double TinhLuong()
        {
            return base.TinhLuong() + 5000000;
        }
    }
}
