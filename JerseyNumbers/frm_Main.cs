using JerseyNumbers.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JerseyNumbers
{
    public partial class frm_Main : Form
    {
        Dictionary<int, JerseyNumber> retiredNumbers = new Dictionary<int, JerseyNumber>() {
            {3, new JerseyNumber("Babe Ruth", 1948)},
            {4, new JerseyNumber("Lou Gehrig", 1939)},
            {5, new JerseyNumber("Joe DiMaggio", 1952)},
            {7, new JerseyNumber("Mickey Mantle", 1969)},
            {8, new JerseyNumber("Yogi Berra", 1972)},
            {10, new JerseyNumber("Phil Rizzuto", 1985)},
            {23, new JerseyNumber("Don Mattingly", 1997)},
            {42, new JerseyNumber("Jackie Robinson", 1993)},
            {44, new JerseyNumber("Reggie Jackson", 1993)},
        };
        public frm_Main()
        {
            InitializeComponent();

            foreach (int key in retiredNumbers.Keys)
            {
                cmbBx_Number.Items.Add(key);                
            }
        }

        private void cmbBx_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumbers[(int)cmbBx_Number.SelectedItem] as JerseyNumber;
            txtBx_Name.Text = jerseyNumber.Player;
            txtBx_Retire.Text = jerseyNumber.YearRetired.ToString();
        }
    }
}
