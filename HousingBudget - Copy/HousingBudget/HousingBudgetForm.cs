using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingBudget
{
    public partial class HousingBudget : Form
    {
        public HousingBudget()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal annualIncome = Convert.ToDecimal(txtAnnualIncome.Text);
            decimal monthlyDebt = Convert.ToDecimal(txtMonthlyDebt.Text);
            decimal rule36 = .36m;
            decimal grossBudget = (annualIncome/12) * rule36;
            decimal netBudget = grossBudget - monthlyDebt;

            txtAnnualIncome.Text = annualIncome.ToString("c");
            txtMonthlyDebt.Text = monthlyDebt.ToString("c");
            txtNetHousingBudget.Text = netBudget.ToString("c");

            txtAnnualIncome.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNetHousingBudget_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMortgage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
