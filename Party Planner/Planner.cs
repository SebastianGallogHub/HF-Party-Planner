using System;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Planner : Form
    {
        DinnerParty dinnerparty;

        public Planner()
        {
            InitializeComponent();
            dinnerparty = new DinnerParty(
                (int)numericUpDown1.Value, HealthyOption.Checked, FancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerparty.Cost;
            Cost.Text = cost.ToString("c"); //la c es por "Currency" lo cual agrega automáticamente el signo peso
        }

        private void FancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.FancyDecorations = FancyDecorations.Checked;
            DisplayDinnerPartyCost();
        }

        private void HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.HealthyOption = HealthyOption.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
    }
}
