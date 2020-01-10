using System;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Planner : Form
    {
        DinnerParty dinnerparty;
        BirthdayParty birthdayParty;

        public Planner()
        {
            InitializeComponent();

            dinnerparty = new DinnerParty(
                (int)numericUpDown1.Value, HealthyOption.Checked, FancyDecorations.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, checkBox1.Checked, textBox1.Text);
            DisplayBirthdayPartyCost();
        }

        #region Dinner Party
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
        #endregion

        #region Birthday Party
        private void DisplayBirthdayPartyCost()
        {
            label5.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            label7.Text = cost.ToString("c");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox1.Checked;
            DisplayBirthdayPartyCost();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCost();
        } 
        #endregion
    }
}
