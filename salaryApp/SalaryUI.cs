using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaryApp
{
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
        }

        private SalaryCalculation aCalculation = new SalaryCalculation();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            double amount = Convert.ToDouble(amountTextBox.Text);
            double houseRent = Convert.ToDouble(houseRentTextBox.Text);
            double medAllow = Convert.ToDouble(medAllowanceTextBox.Text);
            double sal=aCalculation.CalculateSalary(amount, houseRent, medAllow);
            MessageBox.Show(name+" "+"your salary:"+" "+sal);
        }
    }
}
