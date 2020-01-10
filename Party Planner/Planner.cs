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
            dinnerparty = new DinnerParty();
            dinnerparty.SetHealthyOption(false);
            dinnerparty.SetPartyOptions(5, true);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerparty.CalculateCost(HealthyOption.Checked);
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
            dinnerparty.SetPartyOptions((int)numericUpDown1.Value, FancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
