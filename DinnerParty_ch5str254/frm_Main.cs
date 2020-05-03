using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty_ch5str254
{
    public partial class frm_Main : Form
    {
        DinnerParty.DinnerParty dinnerParty;

        public frm_Main()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty.DinnerParty((int)numUpD_numbPeople.Value, chkBx_Healthy.Checked, chkBx_Fancy.Checked);

            DisplayDinnerPartyCost();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void numUpD_numbPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numUpD_numbPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            lbl_CostOut.Text = Cost.ToString("c");
        }

        private void chkBx_Fancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = chkBx_Fancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void chkBx_Healthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = chkBx_Healthy.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
