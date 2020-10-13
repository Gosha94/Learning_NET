using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Go_Fish_408.Classes;

namespace Go_Fish_408
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private Game game;

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBx_PlayerName.Text))
            {
                MessageBox.Show("Please enter your name", "Can’t start the game yet");
                return;
            }
            game = new Game(txtBx_PlayerName.Text, new List<string> { "Joe", "Bob" }, txtBx_Progress);
            btn_StartGame.Enabled = false;
            txtBx_PlayerName.Enabled = false;
            btn_AskCards.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lstBx_PlayerHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                lstBx_PlayerHand.Items.Add(cardName);
            txtBx_Books.Text = game.DescribeBooks();
            txtBx_Progress.Text += game.DescribePlayerHands();
            txtBx_Progress.SelectionStart = txtBx_Progress.Text.Length;
            txtBx_Progress.ScrollToCaret();
        }

        private void btn_AskCards_Click(object sender, EventArgs e)
        {
            txtBx_Progress.Text = "";
            if (lstBx_PlayerHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(lstBx_PlayerHand.SelectedIndex))
            {
                txtBx_Progress.Text += "The winner is ... " +game.GetWinnerName();
                txtBx_Books.Text = game.DescribeBooks();
                btn_AskCards.Enabled = false;
            }
            else
                UpdateForm();
        }
    }    
}