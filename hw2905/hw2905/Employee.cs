using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2905
{
    internal class Employee
    {
        public string Fullname { get; set; }
        public int salary;
        private int Salary
        {
            get { return Salary; }
            set { Salary = Math.Max(value, 300); }
        }

        
    }
}
