namespace JerseyNumbers
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBx_Number = new System.Windows.Forms.ComboBox();
            this.lbl_Numb = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Retire = new System.Windows.Forms.Label();
            this.txtBx_Name = new System.Windows.Forms.TextBox();
            this.txtBx_Retire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBx_Number
            // 
            this.cmbBx_Number.FormattingEnabled = true;
            this.cmbBx_Number.Location = new System.Drawing.Point(70, 13);
            this.cmbBx_Number.Name = "cmbBx_Number";
            this.cmbBx_Number.Size = new System.Drawing.Size(63, 21);
            this.cmbBx_Number.TabIndex = 0;
            this.cmbBx_Number.SelectedIndexChanged += new System.EventHandler(this.cmbBx_Number_SelectedIndexChanged);
            // 
            // lbl_Numb
            // 
            this.lbl_Numb.AutoSize = true;
            this.lbl_Numb.Location = new System.Drawing.Point(20, 17);
            this.lbl_Numb.Name = "lbl_Numb";
            this.lbl_Numb.Size = new System.Drawing.Size(44, 13);
            this.lbl_Numb.TabIndex = 1;
            this.lbl_Numb.Text = "Number";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(144, 17);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 13);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "wear by";
            // 
            // lbl_Retire
            // 
            this.lbl_Retire.AutoSize = true;
            this.lbl_Retire.Location = new System.Drawing.Point(318, 17);
            this.lbl_Retire.Name = "lbl_Retire";
            this.lbl_Retire.Size = new System.Drawing.Size(68, 13);
            this.lbl_Retire.TabIndex = 3;
            this.lbl_Retire.Text = "and retired in";
            // 
            // txtBx_Name
            // 
            this.txtBx_Name.Location = new System.Drawing.Point(194, 13);
            this.txtBx_Name.Name = "txtBx_Name";
            this.txtBx_Name.ReadOnly = true;
            this.txtBx_Name.Size = new System.Drawing.Size(118, 20);
            this.txtBx_Name.TabIndex = 4;
            // 
            // txtBx_Retire
            // 
            this.txtBx_Retire.Location = new System.Drawing.Point(400, 12);
            this.txtBx_Retire.Name = "txtBx_Retire";
            this.txtBx_Retire.ReadOnly = true;
            this.txtBx_Retire.Size = new System.Drawing.Size(52, 20);
            this.txtBx_Retire.TabIndex = 5;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 54);
            this.Controls.Add(this.txtBx_Retire);
            this.Controls.Add(this.txtBx_Name);
            this.Controls.Add(this.lbl_Retire);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Numb);
            this.Controls.Add(this.cmbBx_Number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Retired Jersey Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBx_Number;
        private System.Windows.Forms.Label lbl_Numb;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Retire;
        private System.Windows.Forms.TextBox txtBx_Name;
        private System.Windows.Forms.TextBox txtBx_Retire;
    }
}

