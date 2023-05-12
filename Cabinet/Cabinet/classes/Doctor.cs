using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.classes
{
    internal class Doctor
    {
        private int id;
        private string fname;
        private string lname;
        private string phone;

        public Doctor(int id, string fname, string lname, string phone)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
        }


        public Doctor(string fname, string lname, string phone)
        {
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
        }


        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Phone { get => phone; set => phone = value; }

        public override string ToString()
        {
            return lname + " " + fname;
        }
    }
}
