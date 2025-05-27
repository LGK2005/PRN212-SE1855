using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo1
{
    public class Employee
    {
        #region Employee Field
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _cccd;
        #endregion

        #region Constructor
        public Employee() 
        {
            this._id= 1;
            Cccd = "0000";
            this._name = "Noa";
        }

        public Employee(int _id, string _name, string _email, string _phone, string _cccd)
        {
            Id = _id;
            Name = _name;
            Email = _email;
            Phone = _phone;
            Cccd = _cccd;
        }
        #endregion

        #region Getter Setter
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Cccd
        {
            get { return _cccd; }
            set { _cccd = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        #endregion

        public void PrintInfor()
        {
            string msg = $"{Id}\t{Cccd}\t{Name}\t{Email}\t{Phone}";
            Console.WriteLine(msg);
        }

        public override string ToString()
        {
            string msg = $"{Id}\t{Cccd}\t{Name}\t{Email}\t{Phone}";
            return msg;
        }
    }
}
