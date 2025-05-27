﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2
{
    public class Employee
    {
        public int Id { get; set; }
        public string IdCard { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual double TinhLuong()
        {
            return 4000000;
        }

        public override string ToString()
        {
            return Id + "\t" + IdCard + "\t" + Name + "\t" + BirthDate.ToString("dd/MM/yyyy") + "\t" + TinhLuong();
        }
    }
}
