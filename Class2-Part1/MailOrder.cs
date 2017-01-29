using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class2_Part1
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            TotalHoursWorkedTextbox.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double HoursWorked = Int32.Parse(TotalHoursWorkedTextbox.Text);
            double GrossSales = Int32.Parse(TotalMonthlySalesTextBox.Text);
            double SalesBonus = HoursWorked / 160 * 0.02 * GrossSales;
            SalesBonusTextBox.Text = SalesBonus.ToString();
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Employee Name";
            EmployeeIdLabel.Text = "Employee ID";
            TotalHoursWorkedLabel.Text = "Total Hours Worked";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            SalesBonusLabel.Text = "Sales Bonus";
        }

        private void FrenchButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nom de l'employé";
            EmployeeIdLabel.Text = "ID employé";
            TotalHoursWorkedLabel.Text = "Heures travaillées";
            TotalMonthlySalesLabel.Text = "Ventes mensuelles";
            SalesBonusLabel.Text = "Bonus de vente";
        }
    }
}
