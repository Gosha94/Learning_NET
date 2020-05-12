using System;
using System.Windows.Forms;
using AceOfSpades_Game.Enums;

namespace AceOfSpades_Game
{
    public partial class frm_Main : Form
    {
        Random random = new Random();

        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_GetCard_Click(object sender, EventArgs e)
        {
            Card card = new Card( (Suits)random.Next(4), (Values)random.Next(1, 14) );            
            MessageBox.Show( card.Name , "Рандомная карта выбрана" );
        }
    }
}
