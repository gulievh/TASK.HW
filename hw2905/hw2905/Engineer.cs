using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw2905
{
    internal class Engineer : Employee
    {
        public Engineer(string FulName, int Sallary)
        {
            Fullname = FulName;
            salary = Sallary;
        }
        public new int Salary
        {
            get { return Salary; }
            set { Salary = Math.Max(value, 1000); }
        }
    }

}