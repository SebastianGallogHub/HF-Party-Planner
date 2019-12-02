using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Planner : Form
    {
        DinnerParty dinnerparty;

        public Planner()
        {
            InitializeComponent();
            dinnerparty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerparty.SetHealthyOption(false);
            dinnerparty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerparty.CalculateCost(HealthyOption.Checked) ;
            Cost.Text = cost.ToString("c"); //la c es por "Currency" lo cual agrega automáticamente el signo peso
        }

        private void FancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.CalculateCostOfDecorations(FancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealthyOption(HealthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
    }
}
