using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryApp
{
    class SalaryCalculation
    {
        public double salary { get; private set; }

        public double CalculateSalary(double amount,double houseRent,double medAllow)
        {
            return salary = amount + ((amount*houseRent)/100) + ((amount*medAllow)/100);
        }
    }
}
