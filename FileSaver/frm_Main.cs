using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSaver
{
    public partial class frm_Main : Form
    {
        private string name;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (opFileDia_Open.ShowDialog() == DialogResult.OK)
            {
                name = opFileDia_Open.FileName;
                txtBx_TextArea.Clear();
                txtBx_TextArea.Text = File.ReadAllText(name);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (savFileDia_Save.ShowDialog() == DialogResult.OK)
            {
                name = savFileDia_Save.FileName;
                File.WriteAllText(name, txtBx_TextArea.Text);
            }
        }
    }
}
