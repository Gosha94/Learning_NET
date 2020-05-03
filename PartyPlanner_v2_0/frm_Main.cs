using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner_v2_0
{
    public partial class frm_Main : Form
    {
        Types_Party.DinnerParty dinnerParty;
        Types_Party.BirthdayParty birthdayParty;

        public frm_Main()
        {
            InitializeComponent();
            /* Связанный с формой конструктор присваивает экземпляру BirthdayParty начальные значения подобно тому, 
             * как это было сделано для экземпляра DinnerParty. */
            dinnerParty = new Types_Party.DinnerParty((int)numUpD_numbPeople.Value, chkBx_Healthy.Checked, chkBx_Fancy.Checked);
            //DisplayDinnerPartyCost();

            birthdayParty = new Types_Party.BirthdayParty((int)numUpD_NumPipl.Value, chkBx_FancyDecor.Checked, txtBx_CakeWrit.Text);
            DisplayBirthdayPartyCost();
        }
        // DinnerParty Components
        private void numUpD_numbPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numUpD_numbPeople.Value;
            DisplayDinnerPartyCost();
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
        // END_DinnerParty Components

        // BirthdayParty Components
        private void numUpD_NumPipl_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numUpD_NumPipl.Value;
            DisplayBirthdayPartyCost();
        }

        private void chkBx_FancyDecor_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecoraions = chkBx_FancyDecor.Checked;
            DisplayBirthdayPartyCost();
        }

        private void txtBx_CakeWrit_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = txtBx_CakeWrit.Text;
            DisplayBirthdayPartyCost();
        }
        // END_BirthdayParty Components

        private void DisplayBirthdayPartyCost()
        {
            // Делаем видимым или прячем окно с ошибкой в зависимости от значения поля класса
            lbl_tooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            lbl_BirthCost.Text = cost.ToString("c");
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            lbl_CostOut.Text = cost.ToString("c");
        }
    }
}
